using System.Data;
using System.Data.SqlClient;


namespace TravailPratique2bd
{
    //Déclaration de la class TableForm qui hérite de la classe Form
    public partial class TableForm : Form
    {
        private Panel borderBtn;
        private Table table;
        private Button currentButton;
        private DataTable dataTable;
        private SqlDataAdapter dataAdapter;

        //Constructeur de la classe TableForm
        public TableForm()
        {
            InitializeComponent();
            table = new Table();
            borderBtn = new Panel();
            borderBtn.Size = new Size(5, 80);
            panel3.Controls.Add(borderBtn);
        }

        //Évenement suite au click du bouton 1 (Affiche joueur)
        private void button1_Click(object sender, EventArgs e)
        {
            string resume = "Affiche tout les joueurs.";//Résumé de la requête 

            ActivateButton(sender);//Appel la fonction ActivateButton pour le style du bouton lorsquil est activé

            table.AfficherTable("joueur", resume, resumeLabel, dataGridView1);//Appel la fonction qui fait la requête SQL et qui l'ajoute dans le DataGridView

        }
        //Évenement suite au click du bouton 2 (Affiche tournoi)
        private void button2_Click(object sender, EventArgs e)
        {
            string resume = "Affiche tout les tounois.";//Résumé de la requête 

            ActivateButton(sender);//Appel la fonction ActivateButton pour le style du bouton lorsquil est activé

            table.AfficherTable("tournoi", resume, resumeLabel, dataGridView1);//Appel la fonction qui fait la requête SQL et qui l'ajoute dans le DataGridView

        }
        //Évenement suite au click du bouton 3 (Affiche epreuve)
        private void button3_Click(object sender, EventArgs e)
        {
            string resume = "Affiche toutes les épreuves.";//Résumé de la requête 

            ActivateButton(sender);//Appel la fonction ActivateButton pour le style du bouton lorsquil est activé

            table.AfficherTable("epreuve", resume, resumeLabel, dataGridView1);//Appel la fonction qui fait la requête SQL et qui l'ajoute dans le DataGridView

        }
        //Évenement suite au click du bouton 4 (Affiche match_tennis)
        private void button4_Click(object sender, EventArgs e)
        {
            string resume = "Affiche tout les matchs de tennis.";//Résumé de la requête 

            ActivateButton(sender);//Appel la fonction ActivateButton pour le style du bouton lorsquil est activé

            table.AfficherTable("match_tennis", resume, resumeLabel, dataGridView1);//Appel la fonction qui fait la requête SQL et qui l'ajoute dans le DataGridView

        }
        //Évenement suite au click du bouton 5 (Affiche score_vainqueur)
        private void button5_Click(object sender, EventArgs e)
        {
            string resume = "Affiche tout les scores des vainqueurs.";//Résumé de la requête 

            ActivateButton(sender);//Appel la fonction ActivateButton pour le style du bouton lorsquil est activé

            table.AfficherTable("score_vainqueur", resume, resumeLabel, dataGridView1);//Appel la fonction qui fait la requête SQL et qui l'ajoute dans le DataGridView

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
                    currentButton.BackColor = Color.FromArgb(51, 51, 51);
                    borderBtn.BackColor = Color.CadetBlue;
                    currentButton.ForeColor = Color.CadetBlue;
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




