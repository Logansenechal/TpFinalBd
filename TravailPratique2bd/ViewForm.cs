using System.Data;
using System.Data.SqlClient;


namespace TravailPratique2bd
{

    //Déclaration de la class ViewForm qui hérite de la classe Form
    public partial class ViewForm : Form
    {
        private Panel borderBtn;
        private Table table;
        private Button currentButton;
        private DataTable dataTable;
        private SqlDataAdapter dataAdapter;

        //Constructeur de la classe ViewForm
        public ViewForm()
        {
            InitializeComponent();
            table = new Table(); 
            borderBtn = new Panel();
            borderBtn.Size = new Size(5, 95);
            panel3.Controls.Add(borderBtn);

        }
        //Évenement suite au click du bouton 1
        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);//Appel la fonction ActivateButton pour le style du bouton lorsquil est activé

            String resume = "Affiche les informations des joueuses vainqueures avec les scores du tournoi de Wimbledon avec l’année du tournoi.";//Résumé de la requête 

            table.AfficherTable("requete1", resume, resumeLabel, dataGridView1);//Appel la fonction qui fait la requête SQL et qui l'ajoute dans le DataGridView

        }
        //Évenement suite au click du bouton 2
        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);//Appel la fonction ActivateButton pour le style du bouton lorsquil est activé
            String resume = "Afficher tous les hommes qui ont participé au tournoi de Roland Garros.";//Résumé de la requête 
            table.AfficherTable("requete2", resume, resumeLabel, dataGridView1);//Appel la fonction qui fait la requête SQL et qui l'ajoute dans le DataGridView


        }
        //Évenement suite au click du bouton 3
        private void button3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);//Appel la fonction ActivateButton pour le style du bouton lorsquil est activé
            string resume = "Afficher informations des joueurs vainqueurs avec les scores du tournoi de tous les tournois avec l’année du tournoi.";//Résumé de la requête 
            table.AfficherTable("requete4", resume, resumeLabel, dataGridView1);//Appel la fonction qui fait la requête SQL et qui l'ajoute dans le DataGridView
        }
        //Évenement suite au click du bouton 3
        private void button4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);//Appel la fonction ActivateButton pour le style du bouton lorsquil est activé
            string resume = "Compter le nombre de participants par tournoi, année et sexe.";//Résumé de la requête 
            table.AfficherTable("requete3", resume, resumeLabel, dataGridView1);//Appel la fonction qui fait la requête SQL et qui l'ajoute dans le DataGridView
        }




        //Fonction qui change le style du bouton lorsqu'il est actif
        private void ActivateButton(object sender)
        {
            //Si le bouton n'est pas null
            if (sender != null)
            {
                //Si le bouton actuellement selectionné est différent du bouton qui à appelé l'évenement
                if (currentButton != (Button)sender)
                {
                    DisableButton();//Appel de la fonction DisableButton pour réinitialiser le bouton

                    //Changement du style du bouton
                    currentButton = (Button)sender;
                    currentButton.BackColor = Color.FromArgb(56, 56, 56);
                    currentButton.ForeColor = Color.MediumSlateBlue;
                    borderBtn.BackColor = Color.MediumSlateBlue;
                    borderBtn.Location = new Point(0, currentButton.Location.Y);
                    borderBtn.Visible = true;
                    borderBtn.BringToFront();
                }
            }
        }
        //Fonction qui réinitialise le bouton
        private void DisableButton()
        {
            // Pour chaques bouton du panel3 
            foreach (Control previousBtn in panel3.Controls)
            {
                //Réinitialiser le style du bouton
                previousBtn.BackColor = Color.FromArgb(31, 31, 31);
                borderBtn.BackColor = previousBtn.BackColor;
                previousBtn.ForeColor = Color.White;
            }
        }
    }
}
