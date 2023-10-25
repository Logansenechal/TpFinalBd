using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Table

{
    private SqlDataAdapter dataAdapter;
    private DataTable dataTable;


    public void AfficherTable(string Table, string resume, Label resumeLabel, DataGridView dataGridView)
    {
        string connectionString = "Server=CL5-WIN10-LS\\SQLEXPRESS;Database=travailpratique2;Integrated Security=True;";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Ouvrir la connexion
                connection.Open();

                // Définir votre requête SQL
                string requeteSql = $"SELECT * FROM {Table}";


                dataAdapter = new SqlDataAdapter(requeteSql, connection);
                dataTable = new DataTable();

                // Remplir le DataTable avec les données de la base de données
                dataAdapter.Fill(dataTable);

                // Lier le DataGridView au DataTable
                dataGridView.DataSource = dataTable;
                resumeLabel.Text = resume;
            }


        }
        catch (Exception ex)
        {
            // Gérer les erreurs, par exemple, afficher un message d'erreur
            MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
    

