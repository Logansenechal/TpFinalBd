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
            panel3 = new Panel();
            minimizeButton = new Button();
            button2 = new Button();
            button1 = new Button();
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
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(minimizeButton);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(722, 36);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 36);
            label1.TabIndex = 0;
            label1.Text = "TravailPratiqueFinal";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.BackgroundImage = TravailPratiqueFinal.Properties.Resources.icons8_database_administrator_24;
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(30, 36);
            panel3.TabIndex = 3;
            // 
            // minimizeButton
            // 
            minimizeButton.Dock = DockStyle.Right;
            minimizeButton.FlatAppearance.BorderSize = 0;
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.Image = TravailPratiqueFinal.Properties.Resources.icons8_minus_24;
            minimizeButton.Location = new Point(566, 0);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new Size(52, 36);
            minimizeButton.TabIndex = 2;
            minimizeButton.UseVisualStyleBackColor = true;
            minimizeButton.Click += minimizeButton_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = TravailPratiqueFinal.Properties.Resources.icons8_square_24;
            button2.Location = new Point(618, 0);
            button2.Name = "button2";
            button2.Size = new Size(52, 36);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += reduceOrMaximizeButton_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            button1.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = TravailPratiqueFinal.Properties.Resources.icons8_close_24;
            button1.Location = new Point(670, 0);
            button1.Name = "button1";
            button1.Size = new Size(52, 36);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += xButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 51, 51);
            panel2.Controls.Add(QuitButton);
            panel2.Controls.Add(AfficherRequetes);
            panel2.Controls.Add(AfficherTable);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(722, 480);
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
            QuitButton.Location = new Point(178, 302);
            QuitButton.Name = "QuitButton";
            QuitButton.Size = new Size(368, 68);
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
            AfficherRequetes.Location = new Point(178, 198);
            AfficherRequetes.Name = "AfficherRequetes";
            AfficherRequetes.Size = new Size(368, 68);
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
            AfficherTable.Location = new Point(178, 94);
            AfficherTable.Name = "AfficherTable";
            AfficherTable.Size = new Size(368, 68);
            AfficherTable.TabIndex = 3;
            AfficherTable.Text = "Gestion des tables";
            AfficherTable.UseVisualStyleBackColor = true;
            AfficherTable.Click += GestionTables_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 516);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(408, 451);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button minimizeButton;
        private Button button2;
        private Button button1;
        private Panel panel3;
    }
}