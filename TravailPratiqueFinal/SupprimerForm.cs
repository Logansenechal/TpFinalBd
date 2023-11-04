using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravailPratiqueFinal
{
    public partial class SupprimerForm : Form
    {
        string table;
        public SupprimerForm(string tableChoisis)
        {
            table = tableChoisis;
            InitializeComponent();


        }
    }

}
