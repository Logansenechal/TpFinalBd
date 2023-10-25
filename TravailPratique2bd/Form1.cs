namespace TravailPratique2bd
{
    public partial class Form1 : Form
    {
        TableForm? table;
        ViewForm? requete;
        public Form1()
        {
            InitializeComponent();
        }

        private void AfficherTables_Click(object sender, EventArgs e)
        {

            if (table == null)
            {
                table = new TableForm();
            }
            table.ShowDialog();
        }

        private void AfficherRequetes_Click(object sender, EventArgs e)
        {

            if (requete == null)
            {
                requete = new ViewForm();
            }
            requete.ShowDialog();


        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}