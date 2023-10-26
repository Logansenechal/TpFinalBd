
using System.Data;
using System.Data.SqlClient;

//Déclaration de la classe Table
public class Table

{
    private SqlDataAdapter dataAdapter;//Crée un objet SqlDataAdapter pour récupérer les données de la base de données
    private DataTable dataTable;//Crée un objet DataTable pour stocker les données

    //Méthode pour afficher les données d'une table dans un dataGridView
    public void AfficherTable(string Table, string resume, Label resumeLabel, DataGridView dataGridView)
    {
        //string de connection à la base de données
        string connectionString = "Server=CL5-WIN10-LS\\SQLEXPRESS;Database=travailpratique2;Integrated Security=True;";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Ouvrir la connexion
                connection.Open();

                // Définit la requête SQL
                string requeteSql = $"SELECT * FROM {Table}";

                //Crée une instance de SqlDataAdapter pour exécuter la requête et récupérer les données
                dataAdapter = new SqlDataAdapter(requeteSql, connection);
                dataTable = new DataTable();

                // Remplir le DataTable avec les données de la base de données
                dataAdapter.Fill(dataTable);

                // Lier le DataGridView au DataTable
                dataGridView.DataSource = dataTable;
                //Affiche le résumé de la requête dans resumeLabel 
                resumeLabel.Text = resume;
            }


        }
        catch (Exception ex)
        {

            // Afficher un message d'erreur si une exception est levée
            MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
    

