using System.Data;
using System.Data.SqlClient;

namespace TravailPratiqueFinal
{
    public partial class AjouterForm : Form
    {
        //public string tableChoisis;

        public AjouterForm(string tableChoisis)
        {
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
                                // bool isAutoIncrement = Convert.ToBoolean(row["IsIdentity"]);
                                if (!firstColumn)
                                {
                                    if (isForeignKey(tableChoisis, columnName, connectionString))
                                    {
                                        ComboBox comboBox = new ComboBox();
                                        comboBox.Name = "comboBox" + columnName;
                                        comboBox.Text = columnName;
                                        comboBox.Location = new System.Drawing.Point(10 , 50+ (30 * (panel2.Controls.Count - 3)));
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
                                        textBox.Location = new System.Drawing.Point(10 , 50+ (30 * (panel2.Controls.Count - 3)));
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






            //label2.Visible = true;
            //label2.Text = $"Le joueur {textBox1.Text}, {textBox2.Text} a été ajouter à la table des joueurs";
        }
        /*
                private void AjouterForm_Load(object sender, EventArgs e)
                {


                }*/
    }
}
