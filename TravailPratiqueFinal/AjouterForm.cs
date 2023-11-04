using System.Data;
using System.Data.SqlClient;

namespace TravailPratiqueFinal
{
    public partial class AjouterForm : Form
    {
        public string table;

        public AjouterForm(string tableChoisis)
        {
            table = tableChoisis;
            InitializeComponent();
            label1.Text = $"Ajouter un(e) {tableChoisis}";
            string connectionString = "Server=CL5-WIN10-LS\\SQLEXPRESS;Database=travailpratique2;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Ouvrir la connexion
                connection.Open();

                // Définit la requête SQL
                string requeteSql = $"SELECT * FROM {tableChoisis}";

                using (SqlCommand command = new SqlCommand(requeteSql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            bool firstColumn = true;
                            DataTable schemaTable = reader.GetSchemaTable();
                            foreach (DataRow row in schemaTable.Rows)
                            {
                                string columnName = row["ColumnName"].ToString();

                                if (!firstColumn)
                                {
                                    if (isForeignKey(tableChoisis, columnName, connectionString))
                                    {
                                        ComboBox comboBox = new ComboBox();
                                        comboBox.Name = "comboBox" + columnName;
                                        comboBox.Text = columnName;
                                        comboBox.Tag = columnName;
                                        comboBox.Location = new System.Drawing.Point(10, 50 + (30 * (panel2.Controls.Count - 1)));
                                        comboBox.BackColor = Color.FromArgb(31, 31, 31);
                                        comboBox.Size = new Size(170, 18);
                                        comboBox.FlatStyle = FlatStyle.Flat;
                                        comboBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
                                        comboBox.ForeColor = Color.White;
                                        fillCombobox(tableChoisis, columnName, connectionString, comboBox);
                                        panel2.Controls.Add(comboBox);
                                    }
                                    else
                                    {
                                        TextBox textBox = new TextBox();
                                        textBox.Name = "textBox" + columnName;
                                        textBox.PlaceholderText = columnName;
                                        textBox.Tag = columnName;
                                        textBox.Location = new System.Drawing.Point(10, 50 + (30 * (panel2.Controls.Count - 1)));
                                        textBox.Size = new Size(170, 18);
                                        textBox.BackColor = Color.FromArgb(31, 31, 31);
                                        textBox.BorderStyle = BorderStyle.FixedSingle;
                                        textBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
                                        textBox.ForeColor = Color.White;
                                        panel2.Controls.Add(textBox);
                                    }

                                }
                                firstColumn = false;
                            }
                            Button buttonAjouter = new Button();
                            buttonAjouter.FlatAppearance.BorderColor = Color.CadetBlue;
                            buttonAjouter.FlatAppearance.BorderSize = 2;
                            buttonAjouter.FlatStyle = FlatStyle.Flat;
                            buttonAjouter.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
                            buttonAjouter.ForeColor = Color.CadetBlue;
                            buttonAjouter.Location = new Point(10, 50 + (30 * (panel2.Controls.Count - 1)));
                            buttonAjouter.Name = "buttonAjouter";
                            buttonAjouter.Size = new Size(111, 32);
                            buttonAjouter.TabIndex = 0;
                            buttonAjouter.Text = "Ajouter";
                            buttonAjouter.UseVisualStyleBackColor = true;
                            buttonAjouter.Click += buttonAjouter_Click;
                            panel2.Controls.Add(buttonAjouter);
                        }

                    }
                }

            }

        }
        public bool isForeignKey(string tableName, string columnName, string connectionString)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string requeteSQL = @"
                    SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE 
                    WHERE OBJECTPROPERTY(OBJECT_ID(CONSTRAINT_NAME),'IsForeignKey')=1 
                    AND TABLE_NAME=@tableName 
                    AND COLUMN_NAME=@columnName;";

                using (SqlCommand command = new SqlCommand(requeteSQL, connection))
                {
                    command.Parameters.Add("@tableName", SqlDbType.NVarChar).Value = tableName;
                    command.Parameters.Add("@columnName", SqlDbType.NVarChar).Value = columnName;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows) { return true; }
                        else return false;

                    }
                }
            }
        }
        public bool isExpectedType(string type, string columnName, string connectionString)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string requeteSQL = $"SELECT DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME='{table}' AND COLUMN_NAME='{columnName}'";

                using (SqlCommand commande = new SqlCommand(requeteSQL, connection))
                {
                    
                    using (SqlDataReader reader = commande.ExecuteReader())
                    {
                        if (reader.Read()) {
                            string dataType = reader["DATA_TYPE"].ToString();
                            return string.Equals(dataType,type , StringComparison.OrdinalIgnoreCase);
                                }

                    }
                }
            }
            return false;
        }
        public void fillCombobox(string tableName, string columnName, string connectionString, ComboBox comboBox)
        {
            comboBox.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string requeteSQL = $"SELECT DISTINCT {columnName} FROM {tableName}";
                using (SqlCommand command = new SqlCommand(requeteSQL, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read()) { comboBox.Items.Add(reader[columnName].ToString()); }
                    }
                }
            }
        }


        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            var listData = new List<string>();
            var listColumn = new List<string>();
            string connectionString = "Server=CL5-WIN10-LS\\SQLEXPRESS;Database=TravailPratiqueFinal;Integrated Security=True;";

            foreach (Control champ in panel2.Controls)
            {
                if (champ is TextBox || champ is ComboBox)
                {
                    
                    listData.Add($"'{champ.Text}'");
                    listColumn.Add(champ.Tag.ToString());
                }
            }
            var data = string.Join(",", listData);
            var columns = string.Join(",", listColumn);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string requeteSQL = $"INSERT INTO {table} ({columns}) VALUES ({data})";
                string sql = requeteSQL;
                using (SqlCommand commande = new SqlCommand(requeteSQL, connection))
                {
                    

                    Label message = new Label();
                    message.Name = "labelMessage";
                    

                    message.Location = new System.Drawing.Point(10, 50 + (30 * (panel2.Controls.Count - 1)));



                    message.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
                    message.ForeColor = Color.White;
                    panel2.Controls.Add(message);
                    int rowsAffected = commande.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        message.ForeColor = Color.Green;
                        message.Text = $"Requête réussi: {sql}";

                    }
                    else
                    {
                        message.ForeColor = Color.Red;
                        message.Text = $"Requêe échoué: {sql}";
                    }







                }
                /*
                        private void AjouterForm_Load(object sender, EventArgs e)
                        {


                        }*/
            }
        }
    }
}
