using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace TravailPratique2bd
{


    public partial class ViewForm : Form
    {
        private Table table;
        private Button currentButton;
        private DataTable dataTable;
        private SqlDataAdapter dataAdapter;

        public ViewForm()
        {
            InitializeComponent();
            table = new Table();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            String resume = "Affiche les informations des joueuses vainqueures avec les scores du tournoi de Wimbledon avec l’année du tournoi.";
            table.AfficherTable("requete1", resume, resumeLabel, dataGridView1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            String resume = "Afficher tous les hommes qui ont participé au tournoi de Roland Garros.";
            table.AfficherTable("requete2", resume, resumeLabel, dataGridView1);


        }
        private void button3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            string resume = "Afficher informations des joueurs vainqueurs avec les scores du tournoi de tous les tournois avec l’année du tournoi.";
            table.AfficherTable("requete4", resume, resumeLabel, dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            string resume = "Compter le nombre de participants par tournoi, année et sexe.";
            table.AfficherTable("requete3", resume, resumeLabel, dataGridView1);
        }





        private void ActivateButton(object sender)
        {

            if (sender != null)
            {
                if (currentButton != (Button)sender)
                {
                    DisableButton();
                    currentButton = (Button)sender;
                    currentButton.BackColor = Color.MediumSlateBlue;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel3.Controls)
            {
                previousBtn.BackColor = Color.FromArgb(31, 31, 31);
            }
        }
    }
}
