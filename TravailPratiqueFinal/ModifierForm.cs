using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravailPratiqueFinal
{
    public partial class ModifierForm : Form
    {
        public string connectionString = "Server=CL5-WIN10-LS\\SQLEXPRESS;Database=TravailPratiqueFinal;Integrated Security=True;";
        Table column;
        string primaryKey;
        string table;
        List<string> champsModifiable = new List<string>();

        public ModifierForm(string tableChoisis)
        {

            table = tableChoisis;
            InitializeComponent();
            if (tableChoisis == "joueur")
            {
                champsModifiable.Clear();
                champsModifiable = new List<string> { "JOU_nom", "JOU_prenom" };
            }
            else if (tableChoisis == "tournoi")
            {
                champsModifiable.Clear();
                champsModifiable.Add("TOU_nom");
            }
            else if (tableChoisis == "epreuve")
            {
                champsModifiable.Clear();
                champsModifiable.Add("EPR_type");
            }
            else if (tableChoisis == "score_vainqueur")
            {
                champsModifiable.Clear();
                champsModifiable = new List<string> { "SCV_set1", "SCV_set2", "SCV_set3", "SCV_set4", "SCV_set5" };
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Ouvrir la connexion
                connection.Open();
                primaryKey = GetPrimaryKey(connection, tableChoisis);
                fillCombobox(table, GetPrimaryKey(connection, tableChoisis), comboBox1);
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
                                foreach (string columnToModify in champsModifiable)
                                {


                                    if (columnName == columnToModify)
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
                                        textBox.Enter += Control_Enter;
                                        textBox.Leave += Control_Leave;
                                    }
                                }
                            }
                        }
                        Button buttonModifier = new Button();
                        buttonModifier.FlatAppearance.BorderColor = Color.CadetBlue;
                        buttonModifier.FlatAppearance.BorderSize = 2;
                        buttonModifier.FlatStyle = FlatStyle.Flat;
                        buttonModifier.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
                        buttonModifier.ForeColor = Color.CadetBlue;
                        buttonModifier.Location = new Point(10, 50 + (30 * (panel2.Controls.Count - 2)));
                        buttonModifier.Name = "buttonAjouter";
                        buttonModifier.Size = new Size(111, 32);
                        buttonModifier.TabIndex = 0;
                        buttonModifier.Text = "Ajouter";
                        buttonModifier.UseVisualStyleBackColor = true;
                        buttonModifier.Click += ButtonModifier_Click;
                        panel2.Controls.Add(buttonModifier);
                    }
                }
            }
        }
        private void ButtonModifier_Click(object sender, EventArgs e)
        {
            var listOfColumn = new List<string>();
            var listOfnewValue = new List<string>();
            foreach (Control control in panel2.Controls)
            {
                if (control is TextBox)
                {
                    listOfColumn.Add((string)control.Tag);

                    listOfnewValue.Add(control.Text);
                    control.Text = control.Tag.ToString(); ;

                }
            }
            StringBuilder requeteUpdateBuilder = new StringBuilder($"UPDATE {table} SET ");
            for (int i = 0; i < listOfColumn.Count; i++)
            {
                requeteUpdateBuilder.Append($"{listOfColumn[i]} = '{listOfnewValue[i]}'");
                if (i < listOfColumn.Count - 1) { requeteUpdateBuilder.Append(", "); }

            }
            var selectedIndex = comboBox1.SelectedIndex;
            var selectedId = comboBox1.SelectedItem;
            requeteUpdateBuilder.Append($" WHERE {primaryKey} = {comboBox1.SelectedItem.ToString()}");
            string requeteUpdate = requeteUpdateBuilder.ToString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Ouvrir la connexion
                connection.Open();

                using (SqlCommand command = new SqlCommand(requeteUpdate, connection))
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    label3.Location = new System.Drawing.Point(10, 50 + (30 * (panel2.Controls.Count - 3)));

                    if (rowsAffected > 0)
                    {
                        label3.AutoEllipsis = true;
                        label3.ForeColor = Color.Green;
                        label3.Text = $"Requête réussi: {requeteUpdate}";
                        

                    }
                    else
                    {
                        label2.ForeColor = Color.Red;
                        label2.Text = $"Requêe échoué: {requeteUpdate}";
                    }
                }
            }
            if (selectedIndex==0)comboBox1.SelectedIndex =selectedIndex+1;
            else comboBox1.SelectedIndex = selectedIndex - 1;
            comboBox1.SelectedItem= selectedId;

        }
        private void Control_Leave(object? sender, EventArgs e)
        {
            Control champ = (Control)sender;
            if (champ.Text == champ.Tag.ToString() || string.IsNullOrWhiteSpace(champ.Text))
            {
                champ.Text = champ.Tag.ToString();
                champ.ForeColor = Color.DarkGray;
            }
        }

        private void Control_Enter(object? sender, EventArgs e)
        {
            Control champ = (Control)sender;
            if (champ.Text == champ.Tag.ToString())
            {
                champ.Text = "";
                champ.ForeColor = Color.White;
            }
        }








        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            column = new Table();
            //tableform = new TableForm();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                dataGridView1.Refresh();
                column.AfficherTable(table, dataGridView1, $"{GetPrimaryKey(connection, table)} = {comboBox1.Text}");
            }
        }

        public string GetPrimaryKey(SqlConnection connection, string tableName)
        {
            string primaryKey = string.Empty;
            using (SqlCommand command = new SqlCommand($@"SELECT COLUMN_NAME 
                                                        FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE
                                                        WHERE OBJECTPROPERTY(OBJECT_ID(CONSTRAINT_SCHEMA+'.'+CONSTRAINT_NAME), 'IsPrimaryKey')=1 
                                                        AND TABLE_NAME = '{tableName}'", connection))
            {
                //command.Parameters.AddWithValue("@TableName", tableName);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        primaryKey = reader["COLUMN_NAME"].ToString();
                    }
                }
            }
            return primaryKey;
        }
        public void fillCombobox(string tableName, string columnName, ComboBox comboBox)
        {
            comboBox.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();



                {
                    string requeteSQL = $"SELECT DISTINCT {columnName} FROM {tableName};";




                    using (SqlCommand command = new SqlCommand(requeteSQL, connection))
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    comboBox.Items.Add(reader[columnName].ToString());
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
