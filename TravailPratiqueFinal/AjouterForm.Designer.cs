namespace TravailPratiqueFinal
{
    partial class AjouterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            textBox2 = new TextBox();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            buttonAjouter = new Button();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 31, 31);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(buttonAjouter);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(711, 576);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(41, 136);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 13;
            label2.Text = "label2";
            label2.Visible = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(711, 39);
            panel4.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(138, 21);
            label1.TabIndex = 0;
            label1.Text = "Ajouter un joueur";
            // 
            // panel3
            // 
            panel3.BackColor = Color.CadetBlue;
            panel3.Location = new Point(231, 97);
            panel3.Name = "panel3";
            panel3.Size = new Size(170, 4);
            panel3.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(31, 31, 31);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(231, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 18);
            textBox2.TabIndex = 9;
            textBox2.Text = "Prénom";
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Location = new Point(41, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(170, 4);
            panel1.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(31, 31, 31);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "F", "M" });
            comboBox1.Location = new Point(446, 78);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(82, 25);
            comboBox1.TabIndex = 7;
            comboBox1.Text = "Sexe";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(31, 31, 31);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(41, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 18);
            textBox1.TabIndex = 1;
            textBox1.Text = "Nom";
            // 
            // buttonAjouter
            // 
            buttonAjouter.FlatAppearance.BorderColor = Color.CadetBlue;
            buttonAjouter.FlatAppearance.BorderSize = 2;
            buttonAjouter.FlatStyle = FlatStyle.Flat;
            buttonAjouter.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAjouter.ForeColor = Color.CadetBlue;
            buttonAjouter.Location = new Point(564, 73);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(111, 32);
            buttonAjouter.TabIndex = 0;
            buttonAjouter.Text = "Ajouter";
            buttonAjouter.UseVisualStyleBackColor = true;
            buttonAjouter.Click += buttonAjouter_Click;
            // 
            // AjouterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 576);
            Controls.Add(panel2);
            Name = "AjouterForm";
            Text = "AfficherForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button buttonAjouter;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Panel panel1;
        private Panel panel3;
        private TextBox textBox2;
        private Panel panel4;
        private Label label1;
        private Label label2;
    }
}