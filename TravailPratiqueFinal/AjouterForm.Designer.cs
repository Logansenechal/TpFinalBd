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
            label2.Location = new Point(12, 164);
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
            // buttonAjouter
            // 
            buttonAjouter.FlatAppearance.BorderColor = Color.CadetBlue;
            buttonAjouter.FlatAppearance.BorderSize = 2;
            buttonAjouter.FlatStyle = FlatStyle.Flat;
            buttonAjouter.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAjouter.ForeColor = Color.CadetBlue;
            buttonAjouter.Location = new Point(588, 87);
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
        private Panel panel4;
        private Label label1;
        private Label label2;
    }
}