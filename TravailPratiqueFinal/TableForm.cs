using System.Data;
using System.Data.SqlClient;
using TravailPratiqueFinal;

namespace TravailPratique2bd
{
    //Déclaration de la class TableForm qui hérite de la classe Form
    public partial class TableForm : Form
    {
        public string resume;
       // public AjouterForm ajouterForm; 
        public string tableChoisis;
        public Point mouseLocation;
        private Panel borderBtn;
        private Table table;
        private Button currentButton;
        private DataTable dataTable;
        private SqlDataAdapter dataAdapter;
        
        //Constructeur de la classe TableForm
        public TableForm()
        {
            InitializeComponent();
            CustomSousMenu();
            
            
            table = new Table();
            borderBtn = new Panel();
            borderBtn.Size = new Size(2, 45);
            leftPanel.Controls.Add(borderBtn);
        }
        
        

        //Évenement suite au click du bouton 1 (Affiche joueur)
        private void buttonJoueur_Click(object sender, EventArgs e)
        {
            
            resume = "Affiche tout les joueurs.";//Résumé de la requête 
            tableChoisis = "joueur";
            ActivateButton(sender, panelJoueurSousMenu);//Appel la fonction ActivateButton pour le style du bouton lorsquil est activé


            //table.AfficherTable("joueur", resume, resumeLabel, dataGridView1);//Appel la fonction qui fait la requête SQL et qui l'ajoute dans le DataGridView

        }
        //Évenement suite au click du bouton 2 (Affiche tournoi)
        private void buttonTournoi_Click(object sender, EventArgs e)
        {
            resume = "Affiche tout les tounois.";//Résumé de la requête 
            tableChoisis = "tournoi";
            ActivateButton(sender, panelTournoiSousMenu);//Appel la fonction ActivateButton pour le style du bouton lorsquil est activé

            //table.AfficherTable("tournoi", resume, resumeLabel, dataGridView1);//Appel la fonction qui fait la requête SQL et qui l'ajoute dans le DataGridView

        }
        //Évenement suite au click du bouton 3 (Affiche epreuve)
        private void buttonEpreuve_Click(object sender, EventArgs e)
        {
            resume = "Affiche toutes les épreuves.";//Résumé de la requête 
            tableChoisis = "epreuve";
            ActivateButton(sender, panelEpreuveSousMenu);//Appel la fonction ActivateButton pour le style du bouton lorsquil est activé

            //table.AfficherTable("epreuve", resume, resumeLabel, dataGridView1);//Appel la fonction qui fait la requête SQL et qui l'ajoute dans le DataGridView

        }
        //Évenement suite au click du bouton 4 (Affiche match_tennis)
        private void buttonMatchTennis_Click(object sender, EventArgs e)
        {
            resume = "Affiche tout les matchs de tennis.";//Résumé de la requête 
            tableChoisis = "match_tennis";
            ActivateButton(sender, panelMatchTennisSousMenu);//Appel la fonction ActivateButton pour le style du bouton lorsquil est activé

            //table.AfficherTable("match_tennis", resume, resumeLabel, dataGridView1);//Appel la fonction qui fait la requête SQL et qui l'ajoute dans le DataGridView

        }
        //Évenement suite au click du bouton 5 (Affiche score_vainqueur)
        private void buttonScoreVainqueur_Click(object sender, EventArgs e)
        {
            resume = "Affiche tout les scores des vainqueurs.";//Résumé de la requête 
            tableChoisis = "score_vainqueur";
            ActivateButton(sender, panelSVSousMenu);//Appel la fonction ActivateButton pour le style du bouton lorsquil est activé

            // table.AfficherTable("score_vainqueur", resume, resumeLabel, dataGridView1);//Appel la fonction qui fait la requête SQL et qui l'ajoute dans le DataGridView

        }
        //Fonction qui change le style du bouton lorsqu'il est actif
        private void ActivateButton(object sender, Panel sousMenu)
        {
            //Si le bouton n'est pas null
            if (sender != null)
            {
                AfficheSousMenu(sousMenu);
                //Si le bouton actuellement selectionné est différent du bouton qui à appelé l'évenement
                if (currentButton != (Button)sender)
                {
                    DisableButton();//Appel de la fonction DisableButton pour réinitialiser le bouton

                    //Changement du style du bouton
                    currentButton = (Button)sender;
                    currentButton.BackColor = Color.FromArgb(31, 31, 31);
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
            foreach (Control previousBtn in leftPanel.Controls)
            {
                //Réinitialiser le style du bouton
                previousBtn.BackColor = Color.FromArgb(26, 26, 26);
                borderBtn.BackColor = previousBtn.BackColor;
                previousBtn.ForeColor = Color.White;
            }

        }
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void reduceOrMaximizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void xButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void headerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);


        }

        private void headerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CustomSousMenu()
        {
            panelJoueurSousMenu.Visible = false;
            panelTournoiSousMenu.Visible = false;
            panelEpreuveSousMenu.Visible = false;
            panelMatchTennisSousMenu.Visible = false;
            panelSVSousMenu.Visible = false;
        }
        private void CacherSousMenu()
        {
            if (panelJoueurSousMenu.Visible = true) { panelJoueurSousMenu.Visible = false; }
            if (panelTournoiSousMenu.Visible = true) { panelTournoiSousMenu.Visible = false; }
            if (panelEpreuveSousMenu.Visible = true) { panelEpreuveSousMenu.Visible = false; }
            if (panelMatchTennisSousMenu.Visible = true) { panelMatchTennisSousMenu.Visible = false; }
            if (panelSVSousMenu.Visible = true) { panelSVSousMenu.Visible = false; }
        }
        private void AfficheSousMenu(Panel sousMenu)
        {
            if (!sousMenu.Visible)
            {
                CacherSousMenu();
                sousMenu.Visible = true;
            }
            else
            {
                sousMenu.Visible = false;
            }
        }

        private void buttonAfficherJoueur_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAfficher(tableChoisis,resume));
            CacherSousMenu();
        }

        private void buttonAjouterJoueur_Click(object sender, EventArgs e)
        {
            
            openChildForm(new AjouterForm(tableChoisis));

            CacherSousMenu();
        }

        private void buttonModifierJoueur_Click(object sender, EventArgs e)
        {
            CacherSousMenu();
        }

        private void buttonSupprimerJoueur_Click(object sender, EventArgs e)
        {
            CacherSousMenu();
        }

        private void buttonRechercherJoueur_Click(object sender, EventArgs e)
        {
            CacherSousMenu();
        }

        private void buttonAfficherTournoi_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAfficher(tableChoisis, resume));
            CacherSousMenu();
        }

        private void buttonAjouterTournoi_Click(object sender, EventArgs e)
        {
            //ajouterForm = new AjouterForm();
           // ajouterForm.tableChoisis = "tournoi";
            openChildForm(new AjouterForm(tableChoisis));
            CacherSousMenu();
        }

        private void buttonModifierTournoi_Click(object sender, EventArgs e)
        {
            CacherSousMenu();
        }

        private void buttonSupprimerTournoi_Click(object sender, EventArgs e)
        {
            CacherSousMenu();
        }

        private void buttonRechercherTournoi_Click(object sender, EventArgs e)
        {
            CacherSousMenu();
        }

        private void buttonAfficherEpreuve_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAfficher(tableChoisis, resume));
            CacherSousMenu();
        }

        private void buttonAjouterEpreuve_Click(object sender, EventArgs e)
        {
            
            openChildForm(new AjouterForm(tableChoisis));
            CacherSousMenu();
        }

        private void buttonModifierEpreuve_Click(object sender, EventArgs e)
        {
            CacherSousMenu();
        }

        private void buttonSupprimerEpreuve_Click(object sender, EventArgs e)
        {
            CacherSousMenu();
        }

        private void buttonRechercherEpreuve_Click(object sender, EventArgs e)
        {
            CacherSousMenu();
        }

        private void buttonAfficherMatchTennis_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAfficher(tableChoisis, resume));
            CacherSousMenu();
        }

        private void buttonAjouterMatchTennis_Click(object sender, EventArgs e)
        {
            //ajouterForm = new AjouterForm();
            //ajouterForm.tableChoisis = "match_tennis";
            openChildForm(new AjouterForm(tableChoisis));
            CacherSousMenu();
        }

        private void buttonSupprimerMatchTennis_Click(object sender, EventArgs e)
        {
            CacherSousMenu();
        }

        private void buttonRechercherMatchTennis_Click(object sender, EventArgs e)
        {
            CacherSousMenu();
        }

        private void buttonAfficherSV_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAfficher(tableChoisis, resume));
            CacherSousMenu();
        }

        private void buttonAjouterSV_Click(object sender, EventArgs e)
        {
            //ajouterForm = new AjouterForm();
           // ajouterForm.tableChoisis = "score_vainqueurs";
            openChildForm(new AjouterForm(tableChoisis));
            CacherSousMenu();
        }

        private void buttonModifierSV_Click(object sender, EventArgs e)
        {
            CacherSousMenu();
        }

        private void buttonSupprimerSV_Click(object sender, EventArgs e)
        {
            CacherSousMenu();
        }

        private void buttonRechercherSV_Click(object sender, EventArgs e)
        {
            CacherSousMenu();
        }
        private Form formActif = null;
        private void openChildForm(Form form)
        {
            if (formActif != null) formActif.Close();
            formActif = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelGestion.Controls.Add(form);
            panelGestion.Tag = form;
            form.BringToFront();
            form.Show();
        }
    }
}




