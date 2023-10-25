namespace TravailPratique2bd
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            QuitButton = new Button();
            AfficherRequetes = new Button();
            AfficherTable = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 31, 31);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(722, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(722, 100);
            label1.TabIndex = 0;
            label1.Text = "Travail Pratique 2";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(34, 31, 58);
            panel2.Controls.Add(QuitButton);
            panel2.Controls.Add(AfficherRequetes);
            panel2.Controls.Add(AfficherTable);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(722, 416);
            panel2.TabIndex = 1;
            // 
            // QuitButton
            // 
            QuitButton.Anchor = AnchorStyles.Top;
            QuitButton.FlatAppearance.BorderColor = Color.Firebrick;
            QuitButton.FlatAppearance.BorderSize = 4;
            QuitButton.FlatStyle = FlatStyle.Flat;
            QuitButton.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            QuitButton.ForeColor = Color.White;
            QuitButton.Location = new Point(183, 235);
            QuitButton.Name = "QuitButton";
            QuitButton.Size = new Size(359, 64);
            QuitButton.TabIndex = 5;
            QuitButton.Text = "Quitter";
            QuitButton.UseVisualStyleBackColor = true;
            QuitButton.Click += QuitButton_Click;
            // 
            // AfficherRequetes
            // 
            AfficherRequetes.Anchor = AnchorStyles.Top;
            AfficherRequetes.FlatAppearance.BorderColor = Color.MediumSlateBlue;
            AfficherRequetes.FlatAppearance.BorderSize = 4;
            AfficherRequetes.FlatStyle = FlatStyle.Flat;
            AfficherRequetes.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            AfficherRequetes.ForeColor = Color.White;
            AfficherRequetes.Location = new Point(183, 152);
            AfficherRequetes.Name = "AfficherRequetes";
            AfficherRequetes.Size = new Size(359, 64);
            AfficherRequetes.TabIndex = 4;
            AfficherRequetes.Text = "Afficher les requêtes";
            AfficherRequetes.UseVisualStyleBackColor = true;
            AfficherRequetes.Click += AfficherRequetes_Click;
            // 
            // AfficherTable
            // 
            AfficherTable.Anchor = AnchorStyles.Top;
            AfficherTable.FlatAppearance.BorderColor = Color.CadetBlue;
            AfficherTable.FlatAppearance.BorderSize = 4;
            AfficherTable.FlatStyle = FlatStyle.Flat;
            AfficherTable.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            AfficherTable.ForeColor = Color.White;
            AfficherTable.Location = new Point(183, 69);
            AfficherTable.Name = "AfficherTable";
            AfficherTable.Size = new Size(359, 64);
            AfficherTable.TabIndex = 3;
            AfficherTable.Text = "Afficher les tables";
            AfficherTable.UseVisualStyleBackColor = true;
            AfficherTable.Click += AfficherTables_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 516);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(408, 451);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;

        private Label label1;

        private Button AfficherTable;
        private Button QuitButton;
        private Button AfficherRequetes;
    }
}