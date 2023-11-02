using System.Runtime.InteropServices;

namespace TravailPratique2bd
{

    //D�claration de la class Form1 qui h�rite de la classe Form
    public partial class Form1 : Form
    {
        public Point mouseLocation;
        TableForm? table;//D�claration de la Form qui va afficher les tables
        ViewForm? requete;//D�claration de la Form qui va afficher les requ�tes
        public Form1()
        {
            InitializeComponent();
        }
        //�venement suite au click du bouton AfficherTables
        private void GestionTables_Click(object sender, EventArgs e)
        {
            //Si il n'y a pas de Form table 
            if (table == null)
            {
                //Cr�e une instance de TableForm
                table = new TableForm();
            }
            //Affiche la Form TableForm
            table.ShowDialog();
        }

        //�venement suite au click du bouton AfficherRequetes
        private void AfficherRequetes_Click(object sender, EventArgs e)
        {
            //Si il n'y a pas de Form requete 
            if (requete == null)
            {
                //Cr�e une instance de ViewForm
                requete = new ViewForm();
            }
            //Affiche la Form ViewForm
            requete.ShowDialog();


        }

        //�venement suite au click du bouton QuitButton
        private void QuitButton_Click(object sender, EventArgs e)
        {
            //Ferme le menu
            this.Close();
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
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);


        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }
    }
}