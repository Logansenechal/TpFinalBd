using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravailPratique2bd;

namespace TravailPratiqueFinal
{
    public partial class FormAfficher : Form
    {
        //TableForm tableform;
        Table table;

        public FormAfficher(string tableChoisis, string resume)
        {
            table = new Table();
            //tableform = new TableForm();

            InitializeComponent();
            table.AfficherTable(tableChoisis, resume, labelResume, dataGridView1);
        }

    }
}
