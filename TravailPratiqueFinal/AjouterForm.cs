using Microsoft.Identity.Client;
using System;
using System.Data;
using System.Data.SqlClient;

namespace TravailPratiqueFinal
{
    public partial class AjouterForm : Form
    {

        public string table;
        public string connectionString = "Server=CL5-WIN10-LS\\SQLEXPRESS;Database=TravailPratiqueFinal;Integrated Security=True;";
        public AjouterForm(string tableChoisis)
        {
            table = tableChoisis;
            InitializeComponent();
            label1.Text = $"Ajouter un(e) {tableChoisis}";


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
                                    if (isForeignKey(tableChoisis, columnName))
                                    {
                                        ComboBox comboBox = new ComboBox();
                                        comboBox.Name = "comboBox" + columnName;
                                        comboBox.Text = columnName;
                                        comboBox.Tag = columnName;
                                        comboBox.Location = new System.Drawing.Point(10, 50 + (30 * (panel2.Controls.Count - 2)));
                                        comboBox.BackColor = Color.FromArgb(31, 31, 31);
                                        comboBox.Size = new Size(170, 18);
                                        comboBox.FlatStyle = FlatStyle.Flat;
                                        comboBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
                                        comboBox.ForeColor = Color.DarkGray;
                                       
                                        panel2.Controls.Add(comboBox);
                                        comboBox.Enter += ComboBox_Enter;
                                        comboBox.Leave += Control_Leave;
                                        fillCombobox(tableChoisis, columnName, comboBox);
                                    }
                                    else
                                    {
                                        TextBox textBox = new TextBox();
                                        textBox.Name = "textBox" + columnName;
                                        textBox.Tag = columnName;
                                        textBox.Location = new System.Drawing.Point(10, 50 + (30 * (panel2.Controls.Count - 2)));
                                        textBox.Size = new Size(170, 18);
                                        textBox.BackColor = Color.FromArgb(31, 31, 31);
                                        textBox.BorderStyle = BorderStyle.Fixed3D;
                                        textBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
                                        textBox.Text = columnName;
                                        textBox.ForeColor = Color.DarkGray;
                                        panel2.Controls.Add(textBox);
                                        textBox.Enter += ComboBox_Enter;
                                        textBox.Leave += Control_Leave;
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
                            buttonAjouter.Location = new Point(10, 50 + (30 * (panel2.Controls.Count - 2)));
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

        private void Control_Leave(object? sender, EventArgs e)
        {
            Control champ = (Control)sender;
            if (champ.Text == champ.Tag.ToString() || string.IsNullOrEmpty(champ.Text))
            {
                champ.Text = champ.Tag.ToString();
                champ.ForeColor = Color.DarkGray;
            }
        }

        private void ComboBox_Enter(object? sender, EventArgs e)
        {
            Control champ = (Control)sender;
            if (champ.Text == champ.Tag.ToString())
            {
                champ.Text = "";
                champ.ForeColor = Color.White;
            }
        }

        public bool isForeignKey(string tableName, string columnName)
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
        public bool isTypeOk(Control champ)
        {
            string columnName = champ.Tag.ToString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string requeteSQL = $"SELECT DATA_TYPE,CHARACTER_MAXIMUM_LENGTH FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME='{table}' AND COLUMN_NAME='{columnName}'";

                using (SqlCommand commande = new SqlCommand(requeteSQL, connection))
                {

                    using (SqlDataReader reader = commande.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (champ is TextBox textbox)
                            {

                                string dataType = reader["DATA_TYPE"].ToString();
                                if (string.Equals(dataType, "varchar", StringComparison.OrdinalIgnoreCase))
                                {
                                    int dataMaxLength = reader.GetInt32(reader.GetOrdinal("CHARACTER_MAXIMUM_LENGTH"));

                                    if (!string.IsNullOrEmpty(textbox.Text) && dataMaxLength >= textbox.TextLength)
                                    {
                                        return true;
                                    }
                                }

                                else if (string.Equals(dataType, "int", StringComparison.OrdinalIgnoreCase))
                                {

                                    if (int.TryParse(textbox.Text, out int result))
                                    {
                                        return true;
                                    }
                                }
                            }

                            else if (champ is ComboBox combobox)
                            {
                                if (combobox.Items.Contains(combobox.Text)) { return true; }

                            }

                        }

                    }

                }
            }


            return false;
        }
        public void fillCombobox(string tableName, string columnName, ComboBox comboBox)
        {
            comboBox.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                
                string primaryKeyTable= GetTableNameFromForeignKey(connection, columnName);
                string primaryKeyColumn = GetPrimaryKey(connection, primaryKeyTable);
                if (!string.IsNullOrEmpty(primaryKeyTable))
                {
                    string requeteSQL = $"SELECT DISTINCT {primaryKeyColumn} FROM {primaryKeyTable};";
                    //$"SELECT DISTINCT {columnName} FROM {tableName}";



                    using (SqlCommand command = new SqlCommand(requeteSQL, connection))
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    comboBox.Items.Add(reader[primaryKeyColumn].ToString());
                                }
                            }
                        }
                    }
                }
            } }
            public string GetTableNameFromForeignKey(SqlConnection connection,String foreignKey)
            {
            string tableName = null;
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string requeteSQL = $@"SELECT OBJECT_NAME(fkc.referenced_object_id) AS t1
                                    FROM sys.foreign_keys as fk
                                    inner join sys.foreign_key_columns as fkc on fk.object_id= fkc.constraint_object_id
                                    where OBJECT_NAME(fk.parent_object_id)='{foreignKey}'";
                using (SqlCommand command = new SqlCommand(requeteSQL, connection))
                {
                    //command.Parameters.Add("@TargetTableName", SqlDbType.NVarChar).Value = foreignKey;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tableName = reader["t1"].ToString();
                        }
                    }
                }
                    return tableName;


                } }

        public string GetPrimaryKey(SqlConnection connection, string tableName)
        {
            string primaryKey=string.Empty;
            using (SqlCommand command = new SqlCommand($@"SELECT COLUMN_NAME 
                                                        FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE
                                                        WHERE OBJECTPROPERTY(OBJECT_ID(CONSTRAINT_SCHEMA+'.'+CONSTRAINT_NAME), 'IsPrimaryKey')=1 AND TABLE_NAME = '{tableName}';", connection))
            {
                //command.Parameters.AddWithValue("@TableName", tableName);

                using(SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        primaryKey = reader["COLUMN_NAME"].ToString() ;
                    }
                }
            }
            return primaryKey;
        }


        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            var listData = new List<string>();
            var listColumn = new List<string>();


            foreach (Control champ in panel2.Controls)
            {
                if (champ is TextBox || champ is ComboBox)
                {
                    if (isTypeOk(champ))

                    {
                        listData.Add($"'{champ.Text}'");
                        listColumn.Add(champ.Tag.ToString());
                    }
                    else
                    {
                        MessageBox.Show($"Impossible d'ajouter la valeur: {champ.Text}.\nVeuillez entrer une donnée valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        champ.Text = "";
                        champ.Focus();
                        return;
                    }

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




                    label2.Location = new System.Drawing.Point(10, 50 + (30 * (panel2.Controls.Count - 1)));
                    int rowsAffected = commande.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        label2.AutoEllipsis = true;
                        label2.ForeColor = Color.Green;
                        label2.Text = $"Requête réussi: {sql}";


                    }
                    else
                    {
                        label2.ForeColor = Color.Red;
                        label2.Text = $"Requêe échoué: {sql}";
                    }







                }

            }
        }
    }
}
