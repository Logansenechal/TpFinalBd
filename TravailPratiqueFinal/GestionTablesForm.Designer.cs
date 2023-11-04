namespace TravailPratique2bd
{
    partial class GestionTablesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            headerPanel = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            minimizeButton = new Button();
            buttonMaximize = new Button();
            xButton = new Button();
            leftPanel = new Panel();
            panelSVSousMenu = new Panel();
            buttonRechercherSCV = new Button();
            buttonSupprimerSCV = new Button();
            buttonModifierSCV = new Button();
            buttonAjouterSCV = new Button();
            buttonAfficherSCV = new Button();
            buttonScoreVainqueurs = new Button();
            panelMatchTennisSousMenu = new Panel();
            buttonRechercherMatch = new Button();
            buttonSupprimerMatch = new Button();
            buttonAjouterMatch = new Button();
            buttonAfficherMatch = new Button();
            buttonMatchTennis = new Button();
            panelEpreuveSousMenu = new Panel();
            buttonRechercherEpreuve = new Button();
            buttonSupprimerEpreuve = new Button();
            buttonModifierEpreuve = new Button();
            buttonAjouterEpreuve = new Button();
            buttonAfficherEpreuve = new Button();
            buttonEpreuve = new Button();
            panelTournoiSousMenu = new Panel();
            buttonRechercherTournoi = new Button();
            buttonSupprimerTournoi = new Button();
            buttonModifierTournoi = new Button();
            buttonAjouterTournoi = new Button();
            buttonAfficherTournoi = new Button();
            buttonTournoi = new Button();
            panelJoueurSousMenu = new Panel();
            buttonRechercherJoueur = new Button();
            buttonSupprimerJoueur = new Button();
            button2 = new Button();
            buttonAjouterJoueur = new Button();
            buttonAfficherJoueur = new Button();
            buttonJoueur = new Button();
            buttonAfficherMatchTennis = new Button();
            panelGestion = new Panel();
            panel1.SuspendLayout();
            headerPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            panelSVSousMenu.SuspendLayout();
            panelMatchTennisSousMenu.SuspendLayout();
            panelEpreuveSousMenu.SuspendLayout();
            panelTournoiSousMenu.SuspendLayout();
            panelJoueurSousMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(headerPanel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(961, 31);
            panel1.TabIndex = 0;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(31, 31, 31);
            headerPanel.Controls.Add(label1);
            headerPanel.Controls.Add(panel3);
            headerPanel.Controls.Add(minimizeButton);
            headerPanel.Controls.Add(buttonMaximize);
            headerPanel.Controls.Add(xButton);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(961, 28);
            headerPanel.TabIndex = 1;
            headerPanel.MouseDown += headerPanel_MouseDown;
            headerPanel.MouseMove += headerPanel_MouseMove;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 28);
            label1.TabIndex = 4;
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
            panel3.Size = new Size(30, 28);
            panel3.TabIndex = 8;
            // 
            // minimizeButton
            // 
            minimizeButton.Dock = DockStyle.Right;
            minimizeButton.FlatAppearance.BorderSize = 0;
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.Image = TravailPratiqueFinal.Properties.Resources.icons8_minus_24;
            minimizeButton.Location = new Point(805, 0);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new Size(52, 28);
            minimizeButton.TabIndex = 7;
            minimizeButton.UseVisualStyleBackColor = true;
            minimizeButton.Click += minimizeButton_Click;
            // 
            // buttonMaximize
            // 
            buttonMaximize.Dock = DockStyle.Right;
            buttonMaximize.FlatAppearance.BorderSize = 0;
            buttonMaximize.FlatStyle = FlatStyle.Flat;
            buttonMaximize.Image = TravailPratiqueFinal.Properties.Resources.icons8_square_24;
            buttonMaximize.Location = new Point(857, 0);
            buttonMaximize.Name = "buttonMaximize";
            buttonMaximize.Size = new Size(52, 28);
            buttonMaximize.TabIndex = 6;
            buttonMaximize.UseVisualStyleBackColor = true;
            buttonMaximize.Click += reduceOrMaximizeButton_Click;
            // 
            // xButton
            // 
            xButton.Dock = DockStyle.Right;
            xButton.FlatAppearance.BorderSize = 0;
            xButton.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            xButton.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            xButton.FlatStyle = FlatStyle.Flat;
            xButton.Image = TravailPratiqueFinal.Properties.Resources.icons8_close_24;
            xButton.Location = new Point(909, 0);
            xButton.Name = "xButton";
            xButton.Size = new Size(52, 28);
            xButton.TabIndex = 5;
            xButton.UseVisualStyleBackColor = true;
            xButton.Click += xButton_Click;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.FromArgb(46, 46, 46);
            leftPanel.Controls.Add(panelSVSousMenu);
            leftPanel.Controls.Add(buttonScoreVainqueurs);
            leftPanel.Controls.Add(panelMatchTennisSousMenu);
            leftPanel.Controls.Add(buttonMatchTennis);
            leftPanel.Controls.Add(panelEpreuveSousMenu);
            leftPanel.Controls.Add(buttonEpreuve);
            leftPanel.Controls.Add(panelTournoiSousMenu);
            leftPanel.Controls.Add(buttonTournoi);
            leftPanel.Controls.Add(panelJoueurSousMenu);
            leftPanel.Controls.Add(buttonJoueur);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 31);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(250, 576);
            leftPanel.TabIndex = 1;
            // 
            // panelSVSousMenu
            // 
            panelSVSousMenu.BackColor = Color.FromArgb(46, 46, 46);
            panelSVSousMenu.Controls.Add(buttonRechercherSCV);
            panelSVSousMenu.Controls.Add(buttonSupprimerSCV);
            panelSVSousMenu.Controls.Add(buttonModifierSCV);
            panelSVSousMenu.Controls.Add(buttonAjouterSCV);
            panelSVSousMenu.Controls.Add(buttonAfficherSCV);
            panelSVSousMenu.Dock = DockStyle.Top;
            panelSVSousMenu.Location = new Point(0, 985);
            panelSVSousMenu.Name = "panelSVSousMenu";
            panelSVSousMenu.Size = new Size(250, 200);
            panelSVSousMenu.TabIndex = 10;
            // 
            // buttonRechercherSCV
            // 
            buttonRechercherSCV.BackColor = Color.FromArgb(46, 46, 46);
            buttonRechercherSCV.Dock = DockStyle.Top;
            buttonRechercherSCV.FlatAppearance.BorderSize = 0;
            buttonRechercherSCV.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonRechercherSCV.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            buttonRechercherSCV.FlatStyle = FlatStyle.Flat;
            buttonRechercherSCV.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRechercherSCV.ForeColor = Color.White;
            buttonRechercherSCV.Location = new Point(0, 160);
            buttonRechercherSCV.Name = "buttonRechercherSCV";
            buttonRechercherSCV.Padding = new Padding(20, 0, 0, 0);
            buttonRechercherSCV.Size = new Size(250, 40);
            buttonRechercherSCV.TabIndex = 5;
            buttonRechercherSCV.Text = "Rechercher";
            buttonRechercherSCV.TextAlign = ContentAlignment.MiddleLeft;
            buttonRechercherSCV.UseVisualStyleBackColor = false;
            buttonRechercherSCV.Click += buttonRechercher_Click;
            // 
            // buttonSupprimerSCV
            // 
            buttonSupprimerSCV.BackColor = Color.FromArgb(46, 46, 46);
            buttonSupprimerSCV.Dock = DockStyle.Top;
            buttonSupprimerSCV.FlatAppearance.BorderSize = 0;
            buttonSupprimerSCV.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonSupprimerSCV.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            buttonSupprimerSCV.FlatStyle = FlatStyle.Flat;
            buttonSupprimerSCV.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSupprimerSCV.ForeColor = Color.White;
            buttonSupprimerSCV.Location = new Point(0, 120);
            buttonSupprimerSCV.Name = "buttonSupprimerSCV";
            buttonSupprimerSCV.Padding = new Padding(20, 0, 0, 0);
            buttonSupprimerSCV.Size = new Size(250, 40);
            buttonSupprimerSCV.TabIndex = 4;
            buttonSupprimerSCV.Text = "Supprimer";
            buttonSupprimerSCV.TextAlign = ContentAlignment.MiddleLeft;
            buttonSupprimerSCV.UseVisualStyleBackColor = false;
            buttonSupprimerSCV.Click += buttonSupprimer_Click;
            // 
            // buttonModifierSCV
            // 
            buttonModifierSCV.BackColor = Color.FromArgb(46, 46, 46);
            buttonModifierSCV.Dock = DockStyle.Top;
            buttonModifierSCV.FlatAppearance.BorderSize = 0;
            buttonModifierSCV.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonModifierSCV.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            buttonModifierSCV.FlatStyle = FlatStyle.Flat;
            buttonModifierSCV.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonModifierSCV.ForeColor = Color.White;
            buttonModifierSCV.Location = new Point(0, 80);
            buttonModifierSCV.Name = "buttonModifierSCV";
            buttonModifierSCV.Padding = new Padding(20, 0, 0, 0);
            buttonModifierSCV.Size = new Size(250, 40);
            buttonModifierSCV.TabIndex = 3;
            buttonModifierSCV.Text = "Modifier les résultats des sets";
            buttonModifierSCV.TextAlign = ContentAlignment.MiddleLeft;
            buttonModifierSCV.UseVisualStyleBackColor = false;
            buttonModifierSCV.Click += buttonModifier_Click;
            // 
            // buttonAjouterSCV
            // 
            buttonAjouterSCV.BackColor = Color.FromArgb(46, 46, 46);
            buttonAjouterSCV.Dock = DockStyle.Top;
            buttonAjouterSCV.FlatAppearance.BorderSize = 0;
            buttonAjouterSCV.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonAjouterSCV.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            buttonAjouterSCV.FlatStyle = FlatStyle.Flat;
            buttonAjouterSCV.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAjouterSCV.ForeColor = Color.White;
            buttonAjouterSCV.Location = new Point(0, 40);
            buttonAjouterSCV.Name = "buttonAjouterSCV";
            buttonAjouterSCV.Padding = new Padding(20, 0, 0, 0);
            buttonAjouterSCV.Size = new Size(250, 40);
            buttonAjouterSCV.TabIndex = 2;
            buttonAjouterSCV.Text = "Ajouter";
            buttonAjouterSCV.TextAlign = ContentAlignment.MiddleLeft;
            buttonAjouterSCV.UseVisualStyleBackColor = false;
            buttonAjouterSCV.Click += buttonAjouter_Click;
            // 
            // buttonAfficherSCV
            // 
            buttonAfficherSCV.BackColor = Color.FromArgb(46, 46, 46);
            buttonAfficherSCV.Dock = DockStyle.Top;
            buttonAfficherSCV.FlatAppearance.BorderSize = 0;
            buttonAfficherSCV.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonAfficherSCV.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            buttonAfficherSCV.FlatStyle = FlatStyle.Flat;
            buttonAfficherSCV.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAfficherSCV.ForeColor = Color.White;
            buttonAfficherSCV.Location = new Point(0, 0);
            buttonAfficherSCV.Name = "buttonAfficherSCV";
            buttonAfficherSCV.Padding = new Padding(20, 0, 0, 0);
            buttonAfficherSCV.Size = new Size(250, 40);
            buttonAfficherSCV.TabIndex = 1;
            buttonAfficherSCV.Text = "Afficher la table";
            buttonAfficherSCV.TextAlign = ContentAlignment.MiddleLeft;
            buttonAfficherSCV.UseVisualStyleBackColor = false;
            buttonAfficherSCV.Click += buttonAfficher_Click;
            // 
            // buttonScoreVainqueurs
            // 
            buttonScoreVainqueurs.BackColor = Color.FromArgb(31, 31, 31);
            buttonScoreVainqueurs.Dock = DockStyle.Top;
            buttonScoreVainqueurs.FlatAppearance.BorderSize = 0;
            buttonScoreVainqueurs.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonScoreVainqueurs.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            buttonScoreVainqueurs.FlatStyle = FlatStyle.Flat;
            buttonScoreVainqueurs.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonScoreVainqueurs.ForeColor = Color.White;
            buttonScoreVainqueurs.Location = new Point(0, 940);
            buttonScoreVainqueurs.Name = "buttonScoreVainqueurs";
            buttonScoreVainqueurs.Padding = new Padding(10, 0, 0, 0);
            buttonScoreVainqueurs.Size = new Size(250, 45);
            buttonScoreVainqueurs.TabIndex = 9;
            buttonScoreVainqueurs.Text = "score_vainqueurs";
            buttonScoreVainqueurs.TextAlign = ContentAlignment.MiddleLeft;
            buttonScoreVainqueurs.UseVisualStyleBackColor = false;
            buttonScoreVainqueurs.Click += buttonScoreVainqueur_Click;
            // 
            // panelMatchTennisSousMenu
            // 
            panelMatchTennisSousMenu.BackColor = Color.FromArgb(46, 46, 46);
            panelMatchTennisSousMenu.Controls.Add(buttonRechercherMatch);
            panelMatchTennisSousMenu.Controls.Add(buttonSupprimerMatch);
            panelMatchTennisSousMenu.Controls.Add(buttonAjouterMatch);
            panelMatchTennisSousMenu.Controls.Add(buttonAfficherMatch);
            panelMatchTennisSousMenu.Dock = DockStyle.Top;
            panelMatchTennisSousMenu.Location = new Point(0, 780);
            panelMatchTennisSousMenu.Name = "panelMatchTennisSousMenu";
            panelMatchTennisSousMenu.Size = new Size(250, 160);
            panelMatchTennisSousMenu.TabIndex = 11;
            // 
            // buttonRechercherMatch
            // 
            buttonRechercherMatch.BackColor = Color.FromArgb(46, 46, 46);
            buttonRechercherMatch.Dock = DockStyle.Top;
            buttonRechercherMatch.FlatAppearance.BorderSize = 0;
            buttonRechercherMatch.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonRechercherMatch.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            buttonRechercherMatch.FlatStyle = FlatStyle.Flat;
            buttonRechercherMatch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRechercherMatch.ForeColor = Color.White;
            buttonRechercherMatch.Location = new Point(0, 120);
            buttonRechercherMatch.Name = "buttonRechercherMatch";
            buttonRechercherMatch.Padding = new Padding(20, 0, 0, 0);
            buttonRechercherMatch.Size = new Size(250, 40);
            buttonRechercherMatch.TabIndex = 10;
            buttonRechercherMatch.Text = "Rechercher";
            buttonRechercherMatch.TextAlign = ContentAlignment.MiddleLeft;
            buttonRechercherMatch.UseVisualStyleBackColor = false;
            buttonRechercherMatch.Click += buttonRechercher_Click;
            // 
            // buttonSupprimerMatch
            // 
            buttonSupprimerMatch.BackColor = Color.FromArgb(46, 46, 46);
            buttonSupprimerMatch.Dock = DockStyle.Top;
            buttonSupprimerMatch.FlatAppearance.BorderSize = 0;
            buttonSupprimerMatch.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonSupprimerMatch.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            buttonSupprimerMatch.FlatStyle = FlatStyle.Flat;
            buttonSupprimerMatch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSupprimerMatch.ForeColor = Color.White;
            buttonSupprimerMatch.Location = new Point(0, 80);
            buttonSupprimerMatch.Name = "buttonSupprimerMatch";
            buttonSupprimerMatch.Padding = new Padding(20, 0, 0, 0);
            buttonSupprimerMatch.Size = new Size(250, 40);
            buttonSupprimerMatch.TabIndex = 9;
            buttonSupprimerMatch.Text = "Supprimer";
            buttonSupprimerMatch.TextAlign = ContentAlignment.MiddleLeft;
            buttonSupprimerMatch.UseVisualStyleBackColor = false;
            buttonSupprimerMatch.Click += buttonSupprimer_Click;
            // 
            // buttonAjouterMatch
            // 
            buttonAjouterMatch.BackColor = Color.FromArgb(46, 46, 46);
            buttonAjouterMatch.Dock = DockStyle.Top;
            buttonAjouterMatch.FlatAppearance.BorderSize = 0;
            buttonAjouterMatch.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonAjouterMatch.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            buttonAjouterMatch.FlatStyle = FlatStyle.Flat;
            buttonAjouterMatch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAjouterMatch.ForeColor = Color.White;
            buttonAjouterMatch.Location = new Point(0, 40);
            buttonAjouterMatch.Name = "buttonAjouterMatch";
            buttonAjouterMatch.Padding = new Padding(20, 0, 0, 0);
            buttonAjouterMatch.Size = new Size(250, 40);
            buttonAjouterMatch.TabIndex = 7;
            buttonAjouterMatch.Text = "Ajouter";
            buttonAjouterMatch.TextAlign = ContentAlignment.MiddleLeft;
            buttonAjouterMatch.UseVisualStyleBackColor = false;
            buttonAjouterMatch.Click += buttonAjouter_Click;
            // 
            // buttonAfficherMatch
            // 
            buttonAfficherMatch.BackColor = Color.FromArgb(46, 46, 46);
            buttonAfficherMatch.Dock = DockStyle.Top;
            buttonAfficherMatch.FlatAppearance.BorderSize = 0;
            buttonAfficherMatch.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonAfficherMatch.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            buttonAfficherMatch.FlatStyle = FlatStyle.Flat;
            buttonAfficherMatch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAfficherMatch.ForeColor = Color.White;
            buttonAfficherMatch.Location = new Point(0, 0);
            buttonAfficherMatch.Name = "buttonAfficherMatch";
            buttonAfficherMatch.Padding = new Padding(20, 0, 0, 0);
            buttonAfficherMatch.Size = new Size(250, 40);
            buttonAfficherMatch.TabIndex = 6;
            buttonAfficherMatch.Text = "Afficher la table";
            buttonAfficherMatch.TextAlign = ContentAlignment.MiddleLeft;
            buttonAfficherMatch.UseVisualStyleBackColor = false;
            buttonAfficherMatch.Click += buttonAfficher_Click;
            // 
            // buttonMatchTennis
            // 
            buttonMatchTennis.BackColor = Color.FromArgb(31, 31, 31);
            buttonMatchTennis.Dock = DockStyle.Top;
            buttonMatchTennis.FlatAppearance.BorderSize = 0;
            buttonMatchTennis.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonMatchTennis.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            buttonMatchTennis.FlatStyle = FlatStyle.Flat;
            buttonMatchTennis.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMatchTennis.ForeColor = Color.White;
            buttonMatchTennis.Location = new Point(0, 735);
            buttonMatchTennis.Name = "buttonMatchTennis";
            buttonMatchTennis.Padding = new Padding(10, 0, 0, 0);
            buttonMatchTennis.Size = new Size(250, 45);
            buttonMatchTennis.TabIndex = 7;
            buttonMatchTennis.Text = "match_tennis";
            buttonMatchTennis.TextAlign = ContentAlignment.MiddleLeft;
            buttonMatchTennis.UseVisualStyleBackColor = false;
            buttonMatchTennis.Click += buttonMatchTennis_Click;
            // 
            // panelEpreuveSousMenu
            // 
            panelEpreuveSousMenu.BackColor = Color.FromArgb(46, 46, 46);
            panelEpreuveSousMenu.Controls.Add(buttonRechercherEpreuve);
            panelEpreuveSousMenu.Controls.Add(buttonSupprimerEpreuve);
            panelEpreuveSousMenu.Controls.Add(buttonModifierEpreuve);
            panelEpreuveSousMenu.Controls.Add(buttonAjouterEpreuve);
            panelEpreuveSousMenu.Controls.Add(buttonAfficherEpreuve);
            panelEpreuveSousMenu.Dock = DockStyle.Top;
            panelEpreuveSousMenu.Location = new Point(0, 535);
            panelEpreuveSousMenu.Name = "panelEpreuveSousMenu";
            panelEpreuveSousMenu.Size = new Size(250, 200);
            panelEpreuveSousMenu.TabIndex = 6;
            // 
            // buttonRechercherEpreuve
            // 
            buttonRechercherEpreuve.BackColor = Color.FromArgb(46, 46, 46);
            buttonRechercherEpreuve.Dock = DockStyle.Top;
            buttonRechercherEpreuve.FlatAppearance.BorderSize = 0;
            buttonRechercherEpreuve.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonRechercherEpreuve.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            buttonRechercherEpreuve.FlatStyle = FlatStyle.Flat;
            buttonRechercherEpreuve.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRechercherEpreuve.ForeColor = Color.White;
            buttonRechercherEpreuve.Location = new Point(0, 160);
            buttonRechercherEpreuve.Name = "buttonRechercherEpreuve";
            buttonRechercherEpreuve.Padding = new Padding(20, 0, 0, 0);
            buttonRechercherEpreuve.Size = new Size(250, 40);
            buttonRechercherEpreuve.TabIndex = 5;
            buttonRechercherEpreuve.Text = "Rechercher";
            buttonRechercherEpreuve.TextAlign = ContentAlignment.MiddleLeft;
            buttonRechercherEpreuve.UseVisualStyleBackColor = false;
            buttonRechercherEpreuve.Click += buttonRechercher_Click;
            // 
            // buttonSupprimerEpreuve
            // 
            buttonSupprimerEpreuve.BackColor = Color.FromArgb(46, 46, 46);
            buttonSupprimerEpreuve.Dock = DockStyle.Top;
            buttonSupprimerEpreuve.FlatAppearance.BorderSize = 0;
            buttonSupprimerEpreuve.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonSupprimerEpreuve.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            buttonSupprimerEpreuve.FlatStyle = FlatStyle.Flat;
            buttonSupprimerEpreuve.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSupprimerEpreuve.ForeColor = Color.White;
            buttonSupprimerEpreuve.Location = new Point(0, 120);
            buttonSupprimerEpreuve.Name = "buttonSupprimerEpreuve";
            buttonSupprimerEpreuve.Padding = new Padding(20, 0, 0, 0);
            buttonSupprimerEpreuve.Size = new Size(250, 40);
            buttonSupprimerEpreuve.TabIndex = 4;
            buttonSupprimerEpreuve.Text = "Supprimer";
            buttonSupprimerEpreuve.TextAlign = ContentAlignment.MiddleLeft;
            buttonSupprimerEpreuve.UseVisualStyleBackColor = false;
            buttonSupprimerEpreuve.Click += buttonSupprimer_Click;
            // 
            // buttonModifierEpreuve
            // 
            buttonModifierEpreuve.BackColor = Color.FromArgb(46, 46, 46);
            buttonModifierEpreuve.Dock = DockStyle.Top;
            buttonModifierEpreuve.FlatAppearance.BorderSize = 0;
            buttonModifierEpreuve.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonModifierEpreuve.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            buttonModifierEpreuve.FlatStyle = FlatStyle.Flat;
            buttonModifierEpreuve.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonModifierEpreuve.ForeColor = Color.White;
            buttonModifierEpreuve.Location = new Point(0, 80);
            buttonModifierEpreuve.Name = "buttonModifierEpreuve";
            buttonModifierEpreuve.Padding = new Padding(20, 0, 0, 0);
            buttonModifierEpreuve.Size = new Size(250, 40);
            buttonModifierEpreuve.TabIndex = 3;
            buttonModifierEpreuve.Text = "Modifier le type";
            buttonModifierEpreuve.TextAlign = ContentAlignment.MiddleLeft;
            buttonModifierEpreuve.UseVisualStyleBackColor = false;
            buttonModifierEpreuve.Click += buttonModifier_Click;
            // 
            // buttonAjouterEpreuve
            // 
            buttonAjouterEpreuve.BackColor = Color.FromArgb(46, 46, 46);
            buttonAjouterEpreuve.Dock = DockStyle.Top;
            buttonAjouterEpreuve.FlatAppearance.BorderSize = 0;
            buttonAjouterEpreuve.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonAjouterEpreuve.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            buttonAjouterEpreuve.FlatStyle = FlatStyle.Flat;
            buttonAjouterEpreuve.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAjouterEpreuve.ForeColor = Color.White;
            buttonAjouterEpreuve.Location = new Point(0, 40);
            buttonAjouterEpreuve.Name = "buttonAjouterEpreuve";
            buttonAjouterEpreuve.Padding = new Padding(20, 0, 0, 0);
            buttonAjouterEpreuve.Size = new Size(250, 40);
            buttonAjouterEpreuve.TabIndex = 2;
            buttonAjouterEpreuve.Text = "Ajouter";
            buttonAjouterEpreuve.TextAlign = ContentAlignment.MiddleLeft;
            buttonAjouterEpreuve.UseVisualStyleBackColor = false;
            buttonAjouterEpreuve.Click += buttonAjouter_Click;
            // 
            // buttonAfficherEpreuve
            // 
            buttonAfficherEpreuve.BackColor = Color.FromArgb(46, 46, 46);
            buttonAfficherEpreuve.Dock = DockStyle.Top;
            buttonAfficherEpreuve.FlatAppearance.BorderSize = 0;
            buttonAfficherEpreuve.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonAfficherEpreuve.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            buttonAfficherEpreuve.FlatStyle = FlatStyle.Flat;
            buttonAfficherEpreuve.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAfficherEpreuve.ForeColor = Color.White;
            buttonAfficherEpreuve.Location = new Point(0, 0);
            buttonAfficherEpreuve.Name = "buttonAfficherEpreuve";
            buttonAfficherEpreuve.Padding = new Padding(20, 0, 0, 0);
            buttonAfficherEpreuve.Size = new Size(250, 40);
            buttonAfficherEpreuve.TabIndex = 1;
            buttonAfficherEpreuve.Text = "Afficher la table";
            buttonAfficherEpreuve.TextAlign = ContentAlignment.MiddleLeft;
            buttonAfficherEpreuve.UseVisualStyleBackColor = false;
            buttonAfficherEpreuve.Click += buttonAfficher_Click;
            // 
            // buttonEpreuve
            // 
            buttonEpreuve.BackColor = Color.FromArgb(31, 31, 31);
            buttonEpreuve.Dock = DockStyle.Top;
            buttonEpreuve.FlatAppearance.BorderSize = 0;
            buttonEpreuve.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonEpreuve.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            buttonEpreuve.FlatStyle = FlatStyle.Flat;
            buttonEpreuve.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEpreuve.ForeColor = Color.White;
            buttonEpreuve.Location = new Point(0, 490);
            buttonEpreuve.Name = "buttonEpreuve";
            buttonEpreuve.Padding = new Padding(10, 0, 0, 0);
            buttonEpreuve.Size = new Size(250, 45);
            buttonEpreuve.TabIndex = 5;
            buttonEpreuve.Text = "Epreuve";
            buttonEpreuve.TextAlign = ContentAlignment.MiddleLeft;
            buttonEpreuve.UseVisualStyleBackColor = false;
            buttonEpreuve.Click += buttonEpreuve_Click;
            // 
            // panelTournoiSousMenu
            // 
            panelTournoiSousMenu.BackColor = Color.FromArgb(46, 46, 46);
            panelTournoiSousMenu.Controls.Add(buttonRechercherTournoi);
            panelTournoiSousMenu.Controls.Add(buttonSupprimerTournoi);
            panelTournoiSousMenu.Controls.Add(buttonModifierTournoi);
            panelTournoiSousMenu.Controls.Add(buttonAjouterTournoi);
            panelTournoiSousMenu.Controls.Add(buttonAfficherTournoi);
            panelTournoiSousMenu.Dock = DockStyle.Top;
            panelTournoiSousMenu.Location = new Point(0, 290);
            panelTournoiSousMenu.Name = "panelTournoiSousMenu";
            panelTournoiSousMenu.Size = new Size(250, 200);
            panelTournoiSousMenu.TabIndex = 4;
            // 
            // buttonRechercherTournoi
            // 
            buttonRechercherTournoi.BackColor = Color.FromArgb(46, 46, 46);
            buttonRechercherTournoi.Dock = DockStyle.Top;
            buttonRechercherTournoi.FlatAppearance.BorderSize = 0;
            buttonRechercherTournoi.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonRechercherTournoi.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            buttonRechercherTournoi.FlatStyle = FlatStyle.Flat;
            buttonRechercherTournoi.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRechercherTournoi.ForeColor = Color.White;
            buttonRechercherTournoi.Location = new Point(0, 160);
            buttonRechercherTournoi.Name = "buttonRechercherTournoi";
            buttonRechercherTournoi.Padding = new Padding(20, 0, 0, 0);
            buttonRechercherTournoi.Size = new Size(250, 40);
            buttonRechercherTournoi.TabIndex = 5;
            buttonRechercherTournoi.Text = "Rechercher";
            buttonRechercherTournoi.TextAlign = ContentAlignment.MiddleLeft;
            buttonRechercherTournoi.UseVisualStyleBackColor = false;
            buttonRechercherTournoi.Click += buttonRechercher_Click;
            // 
            // buttonSupprimerTournoi
            // 
            buttonSupprimerTournoi.BackColor = Color.FromArgb(46, 46, 46);
            buttonSupprimerTournoi.Dock = DockStyle.Top;
            buttonSupprimerTournoi.FlatAppearance.BorderSize = 0;
            buttonSupprimerTournoi.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonSupprimerTournoi.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            buttonSupprimerTournoi.FlatStyle = FlatStyle.Flat;
            buttonSupprimerTournoi.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSupprimerTournoi.ForeColor = Color.White;
            buttonSupprimerTournoi.Location = new Point(0, 120);
            buttonSupprimerTournoi.Name = "buttonSupprimerTournoi";
            buttonSupprimerTournoi.Padding = new Padding(20, 0, 0, 0);
            buttonSupprimerTournoi.Size = new Size(250, 40);
            buttonSupprimerTournoi.TabIndex = 4;
            buttonSupprimerTournoi.Text = "Supprimer";
            buttonSupprimerTournoi.TextAlign = ContentAlignment.MiddleLeft;
            buttonSupprimerTournoi.UseVisualStyleBackColor = false;
            buttonSupprimerTournoi.Click += buttonSupprimer_Click;
            // 
            // buttonModifierTournoi
            // 
            buttonModifierTournoi.BackColor = Color.FromArgb(46, 46, 46);
            buttonModifierTournoi.Dock = DockStyle.Top;
            buttonModifierTournoi.FlatAppearance.BorderSize = 0;
            buttonModifierTournoi.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonModifierTournoi.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            buttonModifierTournoi.FlatStyle = FlatStyle.Flat;
            buttonModifierTournoi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonModifierTournoi.ForeColor = Color.White;
            buttonModifierTournoi.Location = new Point(0, 80);
            buttonModifierTournoi.Name = "buttonModifierTournoi";
            buttonModifierTournoi.Padding = new Padding(20, 0, 0, 0);
            buttonModifierTournoi.Size = new Size(250, 40);
            buttonModifierTournoi.TabIndex = 3;
            buttonModifierTournoi.Text = "Modifier le nom d'un tournoi";
            buttonModifierTournoi.TextAlign = ContentAlignment.MiddleLeft;
            buttonModifierTournoi.UseVisualStyleBackColor = false;
            buttonModifierTournoi.Click += buttonModifier_Click;
            // 
            // buttonAjouterTournoi
            // 
            buttonAjouterTournoi.BackColor = Color.FromArgb(46, 46, 46);
            buttonAjouterTournoi.Dock = DockStyle.Top;
            buttonAjouterTournoi.FlatAppearance.BorderSize = 0;
            buttonAjouterTournoi.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonAjouterTournoi.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            buttonAjouterTournoi.FlatStyle = FlatStyle.Flat;
            buttonAjouterTournoi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAjouterTournoi.ForeColor = Color.White;
            buttonAjouterTournoi.Location = new Point(0, 40);
            buttonAjouterTournoi.Name = "buttonAjouterTournoi";
            buttonAjouterTournoi.Padding = new Padding(20, 0, 0, 0);
            buttonAjouterTournoi.Size = new Size(250, 40);
            buttonAjouterTournoi.TabIndex = 2;
            buttonAjouterTournoi.Text = "Ajouter";
            buttonAjouterTournoi.TextAlign = ContentAlignment.MiddleLeft;
            buttonAjouterTournoi.UseVisualStyleBackColor = false;
            buttonAjouterTournoi.Click += buttonAjouter_Click;
            // 
            // buttonAfficherTournoi
            // 
            buttonAfficherTournoi.BackColor = Color.FromArgb(46, 46, 46);
            buttonAfficherTournoi.Dock = DockStyle.Top;
            buttonAfficherTournoi.FlatAppearance.BorderSize = 0;
            buttonAfficherTournoi.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonAfficherTournoi.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            buttonAfficherTournoi.FlatStyle = FlatStyle.Flat;
            buttonAfficherTournoi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAfficherTournoi.ForeColor = Color.White;
            buttonAfficherTournoi.Location = new Point(0, 0);
            buttonAfficherTournoi.Name = "buttonAfficherTournoi";
            buttonAfficherTournoi.Padding = new Padding(20, 0, 0, 0);
            buttonAfficherTournoi.Size = new Size(250, 40);
            buttonAfficherTournoi.TabIndex = 1;
            buttonAfficherTournoi.Text = "Afficher la table";
            buttonAfficherTournoi.TextAlign = ContentAlignment.MiddleLeft;
            buttonAfficherTournoi.UseVisualStyleBackColor = false;
            buttonAfficherTournoi.Click += buttonAfficher_Click;
            // 
            // buttonTournoi
            // 
            buttonTournoi.BackColor = Color.FromArgb(31, 31, 31);
            buttonTournoi.Dock = DockStyle.Top;
            buttonTournoi.FlatAppearance.BorderSize = 0;
            buttonTournoi.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonTournoi.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            buttonTournoi.FlatStyle = FlatStyle.Flat;
            buttonTournoi.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTournoi.ForeColor = Color.White;
            buttonTournoi.Location = new Point(0, 245);
            buttonTournoi.Name = "buttonTournoi";
            buttonTournoi.Padding = new Padding(10, 0, 0, 0);
            buttonTournoi.Size = new Size(250, 45);
            buttonTournoi.TabIndex = 3;
            buttonTournoi.Text = "Tournoi";
            buttonTournoi.TextAlign = ContentAlignment.MiddleLeft;
            buttonTournoi.UseVisualStyleBackColor = false;
            buttonTournoi.Click += buttonTournoi_Click;
            // 
            // panelJoueurSousMenu
            // 
            panelJoueurSousMenu.BackColor = Color.FromArgb(46, 46, 46);
            panelJoueurSousMenu.Controls.Add(buttonRechercherJoueur);
            panelJoueurSousMenu.Controls.Add(buttonSupprimerJoueur);
            panelJoueurSousMenu.Controls.Add(button2);
            panelJoueurSousMenu.Controls.Add(buttonAjouterJoueur);
            panelJoueurSousMenu.Controls.Add(buttonAfficherJoueur);
            panelJoueurSousMenu.Dock = DockStyle.Top;
            panelJoueurSousMenu.Location = new Point(0, 45);
            panelJoueurSousMenu.Name = "panelJoueurSousMenu";
            panelJoueurSousMenu.Size = new Size(250, 200);
            panelJoueurSousMenu.TabIndex = 2;
            // 
            // buttonRechercherJoueur
            // 
            buttonRechercherJoueur.BackColor = Color.FromArgb(46, 46, 46);
            buttonRechercherJoueur.Dock = DockStyle.Top;
            buttonRechercherJoueur.FlatAppearance.BorderSize = 0;
            buttonRechercherJoueur.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonRechercherJoueur.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            buttonRechercherJoueur.FlatStyle = FlatStyle.Flat;
            buttonRechercherJoueur.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRechercherJoueur.ForeColor = Color.White;
            buttonRechercherJoueur.Location = new Point(0, 160);
            buttonRechercherJoueur.Name = "buttonRechercherJoueur";
            buttonRechercherJoueur.Padding = new Padding(20, 0, 0, 0);
            buttonRechercherJoueur.Size = new Size(250, 40);
            buttonRechercherJoueur.TabIndex = 5;
            buttonRechercherJoueur.Text = "Rechercher";
            buttonRechercherJoueur.TextAlign = ContentAlignment.MiddleLeft;
            buttonRechercherJoueur.UseVisualStyleBackColor = false;
            buttonRechercherJoueur.Click += buttonRechercher_Click;
            // 
            // buttonSupprimerJoueur
            // 
            buttonSupprimerJoueur.BackColor = Color.FromArgb(46, 46, 46);
            buttonSupprimerJoueur.Dock = DockStyle.Top;
            buttonSupprimerJoueur.FlatAppearance.BorderSize = 0;
            buttonSupprimerJoueur.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonSupprimerJoueur.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            buttonSupprimerJoueur.FlatStyle = FlatStyle.Flat;
            buttonSupprimerJoueur.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSupprimerJoueur.ForeColor = Color.White;
            buttonSupprimerJoueur.Location = new Point(0, 120);
            buttonSupprimerJoueur.Name = "buttonSupprimerJoueur";
            buttonSupprimerJoueur.Padding = new Padding(20, 0, 0, 0);
            buttonSupprimerJoueur.Size = new Size(250, 40);
            buttonSupprimerJoueur.TabIndex = 4;
            buttonSupprimerJoueur.Text = "Supprimer";
            buttonSupprimerJoueur.TextAlign = ContentAlignment.MiddleLeft;
            buttonSupprimerJoueur.UseVisualStyleBackColor = false;
            buttonSupprimerJoueur.Click += buttonSupprimer_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(46, 46, 46);
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 80);
            button2.Name = "button2";
            button2.Padding = new Padding(20, 0, 0, 0);
            button2.Size = new Size(250, 40);
            button2.TabIndex = 3;
            button2.Text = "Modifier le nom et le prénom d'un joueur";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonModifier_Click;
            // 
            // buttonAjouterJoueur
            // 
            buttonAjouterJoueur.BackColor = Color.FromArgb(46, 46, 46);
            buttonAjouterJoueur.Dock = DockStyle.Top;
            buttonAjouterJoueur.FlatAppearance.BorderSize = 0;
            buttonAjouterJoueur.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonAjouterJoueur.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            buttonAjouterJoueur.FlatStyle = FlatStyle.Flat;
            buttonAjouterJoueur.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAjouterJoueur.ForeColor = Color.White;
            buttonAjouterJoueur.Location = new Point(0, 40);
            buttonAjouterJoueur.Name = "buttonAjouterJoueur";
            buttonAjouterJoueur.Padding = new Padding(20, 0, 0, 0);
            buttonAjouterJoueur.Size = new Size(250, 40);
            buttonAjouterJoueur.TabIndex = 2;
            buttonAjouterJoueur.Text = "Ajouter";
            buttonAjouterJoueur.TextAlign = ContentAlignment.MiddleLeft;
            buttonAjouterJoueur.UseVisualStyleBackColor = false;
            buttonAjouterJoueur.Click += buttonAjouter_Click;
            // 
            // buttonAfficherJoueur
            // 
            buttonAfficherJoueur.BackColor = Color.FromArgb(46, 46, 46);
            buttonAfficherJoueur.Dock = DockStyle.Top;
            buttonAfficherJoueur.FlatAppearance.BorderSize = 0;
            buttonAfficherJoueur.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonAfficherJoueur.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            buttonAfficherJoueur.FlatStyle = FlatStyle.Flat;
            buttonAfficherJoueur.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAfficherJoueur.ForeColor = Color.White;
            buttonAfficherJoueur.Location = new Point(0, 0);
            buttonAfficherJoueur.Name = "buttonAfficherJoueur";
            buttonAfficherJoueur.Padding = new Padding(20, 0, 0, 0);
            buttonAfficherJoueur.Size = new Size(250, 40);
            buttonAfficherJoueur.TabIndex = 1;
            buttonAfficherJoueur.Text = "Afficher la table";
            buttonAfficherJoueur.TextAlign = ContentAlignment.MiddleLeft;
            buttonAfficherJoueur.UseVisualStyleBackColor = false;
            buttonAfficherJoueur.Click += buttonAfficher_Click;
            // 
            // buttonJoueur
            // 
            buttonJoueur.BackColor = Color.FromArgb(31, 31, 31);
            buttonJoueur.Dock = DockStyle.Top;
            buttonJoueur.FlatAppearance.BorderSize = 0;
            buttonJoueur.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonJoueur.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            buttonJoueur.FlatStyle = FlatStyle.Flat;
            buttonJoueur.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonJoueur.ForeColor = Color.White;
            buttonJoueur.Location = new Point(0, 0);
            buttonJoueur.Name = "buttonJoueur";
            buttonJoueur.Padding = new Padding(10, 0, 0, 0);
            buttonJoueur.Size = new Size(250, 45);
            buttonJoueur.TabIndex = 0;
            buttonJoueur.Text = "Joueur";
            buttonJoueur.TextAlign = ContentAlignment.MiddleLeft;
            buttonJoueur.UseVisualStyleBackColor = false;
            buttonJoueur.Click += buttonJoueur_Click;
            // 
            // buttonAfficherMatchTennis
            // 
            buttonAfficherMatchTennis.Dock = DockStyle.Top;
            buttonAfficherMatchTennis.FlatAppearance.BorderSize = 0;
            buttonAfficherMatchTennis.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            buttonAfficherMatchTennis.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            buttonAfficherMatchTennis.FlatStyle = FlatStyle.Flat;
            buttonAfficherMatchTennis.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAfficherMatchTennis.ForeColor = Color.White;
            buttonAfficherMatchTennis.Location = new Point(0, 0);
            buttonAfficherMatchTennis.Name = "buttonAfficherMatchTennis";
            buttonAfficherMatchTennis.Padding = new Padding(20, 0, 0, 0);
            buttonAfficherMatchTennis.Size = new Size(233, 40);
            buttonAfficherMatchTennis.TabIndex = 1;
            buttonAfficherMatchTennis.Text = "Afficher la table";
            buttonAfficherMatchTennis.TextAlign = ContentAlignment.MiddleLeft;
            buttonAfficherMatchTennis.UseVisualStyleBackColor = true;
            buttonAfficherMatchTennis.Click += buttonAfficher_Click;
            // 
            // panelGestion
            // 
            panelGestion.Dock = DockStyle.Fill;
            panelGestion.Location = new Point(250, 31);
            panelGestion.Name = "panelGestion";
            panelGestion.Size = new Size(711, 576);
            panelGestion.TabIndex = 3;
            // 
            // GestionTablesForm
            // 
            BackColor = Color.FromArgb(51, 51, 51);
            ClientSize = new Size(961, 607);
            Controls.Add(panelGestion);
            Controls.Add(leftPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(961, 607);
            Name = "GestionTablesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Afficher les tables";
            panel1.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            panelSVSousMenu.ResumeLayout(false);
            panelMatchTennisSousMenu.ResumeLayout(false);
            panelEpreuveSousMenu.ResumeLayout(false);
            panelTournoiSousMenu.ResumeLayout(false);
            panelJoueurSousMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.ComponentModel.IContainer components;
        private Panel panel1;
        private Panel headerPanel;
        private Panel leftPanel;
        private Button buttonJoueur;
        private Panel panelJoueurSousMenu;
        private Button buttonSupprimerJoueur;
        private Button button2;
        private Button buttonAjouterJoueur;
        private Button buttonAfficherJoueur;
        private Button buttonRechercherJoueur;
        private Panel panelTournoiSousMenu;
        private Button buttonRechercherTournoi;
        private Button buttonSupprimerTournoi;
        private Button buttonModifierTournoi;
        private Button buttonAjouterTournoi;
        private Button buttonAfficherTournoi;
        private Button buttonTournoi;
        private Panel panelEpreuveSousMenu;
        private Button buttonRechercherEpreuve;
        private Button buttonSupprimerEpreuve;
        private Button buttonModifierEpreuve;
        private Button buttonAjouterEpreuve;
        private Button buttonAfficherEpreuve;
        private Button buttonEpreuve;
        private Panel panelMatchTennisSousMenu;
        private Button button5;
        private Button buttonAfficherMatchTennis;
        private Button buttonMatchTennis;
        private Panel panelSVSousMenu;
        private Button buttonRechercherSCV;
        private Button buttonSupprimerSCV;
        private Button buttonModifierSCV;
        private Button buttonAjouterSCV;
        private Button buttonAfficherSCV;
        private Button buttonScoreVainqueurs;
        private Button buttonRechercherMatch;
        private Button buttonSupprimerMatch;
        private Button buttonAjouterMatch;
        private Button buttonAfficherMatch;
        private Label label1;
        private Panel panel3;
        private Button minimizeButton;
        private Button buttonMaximize;
        private Button xButton;
        private Panel panelGestion;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>




    }
}