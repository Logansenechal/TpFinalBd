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
    public partial class TableForm : Form
    {
        private Table table;
        private Button currentButton;
        private DataTable dataTable;
        private SqlDataAdapter dataAdapter;

        public TableForm()
        {
            InitializeComponent();
            table = new Table();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string resume = "Affiche tout les joueurs.";
            ActivateButton(sender);
            table.AfficherTable("joueur", resume, resumeLabel, dataGridView1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string resume = "Affiche tout les tounois.";
            ActivateButton(sender);
            table.AfficherTable("tournoi", resume, resumeLabel, dataGridView1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string resume = "Affiche toutes les épreuves.";
            ActivateButton(sender);
            table.AfficherTable("epreuve", resume, resumeLabel, dataGridView1);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string resume = "Affiche tout les matchs de tennis.";
            ActivateButton(sender);
            table.AfficherTable("match_tennis", resume, resumeLabel, dataGridView1);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string resume = "Affiche tout les scores des vainqueurs.";
            ActivateButton(sender);
            table.AfficherTable("score_vainqueur", resume, resumeLabel, dataGridView1);

        }

        private void ActivateButton(object sender)
        {

            if (sender != null)
            {
                if (currentButton != (Button)sender)
                {
                    DisableButton();
                    currentButton = (Button)sender;
                    currentButton.BackColor = Color.CadetBlue;
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




