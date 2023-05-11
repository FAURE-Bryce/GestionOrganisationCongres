namespace GestionOrganisationCongres
{
    partial class FrmGestionSession
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControlSession = new System.Windows.Forms.TabControl();
            this.listeSession = new System.Windows.Forms.TabPage();
            this.btAjouterSession = new System.Windows.Forms.Button();
            this.dataGridViewSession = new System.Windows.Forms.DataGridView();
            this.numSessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.themeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDebutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbPlacesMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomPresidentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.congressistesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcSessions = new System.Windows.Forms.BindingSource(this.components);
            this.detailsSession = new System.Windows.Forms.TabPage();
            this.txtBoxPrixSession = new System.Windows.Forms.TextBox();
            this.txtBoxNombrePlacesMaxSession = new System.Windows.Forms.TextBox();
            this.btValiderModifSession = new System.Windows.Forms.Button();
            this.btAnnulerModifSession = new System.Windows.Forms.Button();
            this.comboBoxHeureDebut = new System.Windows.Forms.ComboBox();
            this.lblInscrits = new System.Windows.Forms.Label();
            this.btSupprimerInscritSession = new System.Windows.Forms.Button();
            this.btAjouterInscritSession = new System.Windows.Forms.Button();
            this.lblNonInscrits = new System.Windows.Forms.Label();
            this.comboBoxNonInscrits = new System.Windows.Forms.ComboBox();
            this.txtBoxThemeSession = new System.Windows.Forms.TextBox();
            this.dateTimePickerSession = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSalleSession = new System.Windows.Forms.ComboBox();
            this.salleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblSalleSession = new System.Windows.Forms.Label();
            this.lblPrixSession = new System.Windows.Forms.Label();
            this.lblNbPlacesMaxSession = new System.Windows.Forms.Label();
            this.lblHeureDebutSession = new System.Windows.Forms.Label();
            this.lblDateSession = new System.Windows.Forms.Label();
            this.lblThemeSession = new System.Windows.Forms.Label();
            this.btSupprimerSession = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControlSession.SuspendLayout();
            this.listeSession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcSessions)).BeginInit();
            this.detailsSession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSession
            // 
            this.tabControlSession.Controls.Add(this.listeSession);
            this.tabControlSession.Controls.Add(this.detailsSession);
            this.tabControlSession.Location = new System.Drawing.Point(9, 10);
            this.tabControlSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControlSession.Name = "tabControlSession";
            this.tabControlSession.SelectedIndex = 0;
            this.tabControlSession.Size = new System.Drawing.Size(766, 472);
            this.tabControlSession.TabIndex = 0;
            // 
            // listeSession
            // 
            this.listeSession.Controls.Add(this.btAjouterSession);
            this.listeSession.Controls.Add(this.dataGridViewSession);
            this.listeSession.Location = new System.Drawing.Point(4, 22);
            this.listeSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listeSession.Name = "listeSession";
            this.listeSession.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listeSession.Size = new System.Drawing.Size(758, 446);
            this.listeSession.TabIndex = 0;
            this.listeSession.Text = "Liste";
            this.listeSession.UseVisualStyleBackColor = true;
            // 
            // btAjouterSession
            // 
            this.btAjouterSession.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btAjouterSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btAjouterSession.Location = new System.Drawing.Point(238, 382);
            this.btAjouterSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAjouterSession.Name = "btAjouterSession";
            this.btAjouterSession.Size = new System.Drawing.Size(190, 51);
            this.btAjouterSession.TabIndex = 1;
            this.btAjouterSession.Text = "Ajouter une session";
            this.btAjouterSession.UseVisualStyleBackColor = false;
            // 
            // dataGridViewSession
            // 
            this.dataGridViewSession.AllowUserToAddRows = false;
            this.dataGridViewSession.AllowUserToDeleteRows = false;
            this.dataGridViewSession.AutoGenerateColumns = false;
            this.dataGridViewSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSession.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numSessionDataGridViewTextBoxColumn,
            this.themeDataGridViewTextBoxColumn,
            this.heureDebutDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.nbPlacesMaxDataGridViewTextBoxColumn,
            this.prixDataGridViewTextBoxColumn,
            this.nomPresidentDataGridViewTextBoxColumn,
            this.idSalleDataGridViewTextBoxColumn,
            this.congressistesDataGridViewTextBoxColumn});
            this.dataGridViewSession.DataSource = this.bindSrcSessions;
            this.dataGridViewSession.Location = new System.Drawing.Point(2, 5);
            this.dataGridViewSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewSession.Name = "dataGridViewSession";
            this.dataGridViewSession.ReadOnly = true;
            this.dataGridViewSession.RowHeadersWidth = 51;
            this.dataGridViewSession.RowTemplate.Height = 24;
            this.dataGridViewSession.Size = new System.Drawing.Size(641, 357);
            this.dataGridViewSession.TabIndex = 0;
            // 
            // numSessionDataGridViewTextBoxColumn
            // 
            this.numSessionDataGridViewTextBoxColumn.DataPropertyName = "numSession";
            this.numSessionDataGridViewTextBoxColumn.HeaderText = "N° session";
            this.numSessionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numSessionDataGridViewTextBoxColumn.Name = "numSessionDataGridViewTextBoxColumn";
            this.numSessionDataGridViewTextBoxColumn.ReadOnly = true;
            this.numSessionDataGridViewTextBoxColumn.Width = 125;
            // 
            // themeDataGridViewTextBoxColumn
            // 
            this.themeDataGridViewTextBoxColumn.DataPropertyName = "theme";
            this.themeDataGridViewTextBoxColumn.HeaderText = "Thème";
            this.themeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.themeDataGridViewTextBoxColumn.Name = "themeDataGridViewTextBoxColumn";
            this.themeDataGridViewTextBoxColumn.ReadOnly = true;
            this.themeDataGridViewTextBoxColumn.Width = 125;
            // 
            // heureDebutDataGridViewTextBoxColumn
            // 
            this.heureDebutDataGridViewTextBoxColumn.DataPropertyName = "heureDebut";
            this.heureDebutDataGridViewTextBoxColumn.HeaderText = "Heure de début";
            this.heureDebutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.heureDebutDataGridViewTextBoxColumn.Name = "heureDebutDataGridViewTextBoxColumn";
            this.heureDebutDataGridViewTextBoxColumn.ReadOnly = true;
            this.heureDebutDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // nbPlacesMaxDataGridViewTextBoxColumn
            // 
            this.nbPlacesMaxDataGridViewTextBoxColumn.DataPropertyName = "nbPlacesMax";
            this.nbPlacesMaxDataGridViewTextBoxColumn.HeaderText = "Nombre de places max";
            this.nbPlacesMaxDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nbPlacesMaxDataGridViewTextBoxColumn.Name = "nbPlacesMaxDataGridViewTextBoxColumn";
            this.nbPlacesMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.nbPlacesMaxDataGridViewTextBoxColumn.Width = 125;
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "prix";
            this.prixDataGridViewTextBoxColumn.HeaderText = "Prix";
            this.prixDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            this.prixDataGridViewTextBoxColumn.ReadOnly = true;
            this.prixDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomPresidentDataGridViewTextBoxColumn
            // 
            this.nomPresidentDataGridViewTextBoxColumn.DataPropertyName = "nomPresident";
            this.nomPresidentDataGridViewTextBoxColumn.HeaderText = "Nom du président";
            this.nomPresidentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomPresidentDataGridViewTextBoxColumn.Name = "nomPresidentDataGridViewTextBoxColumn";
            this.nomPresidentDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomPresidentDataGridViewTextBoxColumn.Width = 125;
            // 
            // idSalleDataGridViewTextBoxColumn
            // 
            this.idSalleDataGridViewTextBoxColumn.DataPropertyName = "idSalle";
            this.idSalleDataGridViewTextBoxColumn.HeaderText = "Salle";
            this.idSalleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idSalleDataGridViewTextBoxColumn.Name = "idSalleDataGridViewTextBoxColumn";
            this.idSalleDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSalleDataGridViewTextBoxColumn.Width = 125;
            // 
            // congressistesDataGridViewTextBoxColumn
            // 
            this.congressistesDataGridViewTextBoxColumn.DataPropertyName = "Congressistes";
            this.congressistesDataGridViewTextBoxColumn.HeaderText = "Congressistes";
            this.congressistesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.congressistesDataGridViewTextBoxColumn.Name = "congressistesDataGridViewTextBoxColumn";
            this.congressistesDataGridViewTextBoxColumn.ReadOnly = true;
            this.congressistesDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindSrcSessions
            // 
            this.bindSrcSessions.DataSource = typeof(GestionOrganisationCongres.Session);
            // 
            // detailsSession
            // 
            this.detailsSession.Controls.Add(this.txtBoxPrixSession);
            this.detailsSession.Controls.Add(this.txtBoxNombrePlacesMaxSession);
            this.detailsSession.Controls.Add(this.btValiderModifSession);
            this.detailsSession.Controls.Add(this.btAnnulerModifSession);
            this.detailsSession.Controls.Add(this.comboBoxHeureDebut);
            this.detailsSession.Controls.Add(this.lblInscrits);
            this.detailsSession.Controls.Add(this.btSupprimerInscritSession);
            this.detailsSession.Controls.Add(this.btAjouterInscritSession);
            this.detailsSession.Controls.Add(this.lblNonInscrits);
            this.detailsSession.Controls.Add(this.comboBoxNonInscrits);
            this.detailsSession.Controls.Add(this.txtBoxThemeSession);
            this.detailsSession.Controls.Add(this.dateTimePickerSession);
            this.detailsSession.Controls.Add(this.comboBoxSalleSession);
            this.detailsSession.Controls.Add(this.lblSalleSession);
            this.detailsSession.Controls.Add(this.lblPrixSession);
            this.detailsSession.Controls.Add(this.lblNbPlacesMaxSession);
            this.detailsSession.Controls.Add(this.lblHeureDebutSession);
            this.detailsSession.Controls.Add(this.lblDateSession);
            this.detailsSession.Controls.Add(this.lblThemeSession);
            this.detailsSession.Controls.Add(this.btSupprimerSession);
            this.detailsSession.Controls.Add(this.dataGridView2);
            this.detailsSession.Location = new System.Drawing.Point(4, 22);
            this.detailsSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.detailsSession.Name = "detailsSession";
            this.detailsSession.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.detailsSession.Size = new System.Drawing.Size(758, 446);
            this.detailsSession.TabIndex = 1;
            this.detailsSession.Text = "Détails";
            this.detailsSession.UseVisualStyleBackColor = true;
            // 
            // txtBoxPrixSession
            // 
            this.txtBoxPrixSession.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcSessions, "prix", true));
            this.txtBoxPrixSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxPrixSession.Location = new System.Drawing.Point(84, 247);
            this.txtBoxPrixSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxPrixSession.Name = "txtBoxPrixSession";
            this.txtBoxPrixSession.Size = new System.Drawing.Size(92, 23);
            this.txtBoxPrixSession.TabIndex = 50;
            // 
            // txtBoxNombrePlacesMaxSession
            // 
            this.txtBoxNombrePlacesMaxSession.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcSessions, "nbPlacesMax", true));
            this.txtBoxNombrePlacesMaxSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxNombrePlacesMaxSession.Location = new System.Drawing.Point(185, 170);
            this.txtBoxNombrePlacesMaxSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxNombrePlacesMaxSession.Name = "txtBoxNombrePlacesMaxSession";
            this.txtBoxNombrePlacesMaxSession.Size = new System.Drawing.Size(75, 23);
            this.txtBoxNombrePlacesMaxSession.TabIndex = 49;
            // 
            // btValiderModifSession
            // 
            this.btValiderModifSession.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btValiderModifSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btValiderModifSession.Location = new System.Drawing.Point(51, 325);
            this.btValiderModifSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btValiderModifSession.Name = "btValiderModifSession";
            this.btValiderModifSession.Size = new System.Drawing.Size(95, 49);
            this.btValiderModifSession.TabIndex = 48;
            this.btValiderModifSession.Text = "Valider";
            this.btValiderModifSession.UseVisualStyleBackColor = false;
            // 
            // btAnnulerModifSession
            // 
            this.btAnnulerModifSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btAnnulerModifSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btAnnulerModifSession.Location = new System.Drawing.Point(215, 325);
            this.btAnnulerModifSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAnnulerModifSession.Name = "btAnnulerModifSession";
            this.btAnnulerModifSession.Size = new System.Drawing.Size(86, 39);
            this.btAnnulerModifSession.TabIndex = 47;
            this.btAnnulerModifSession.Text = "Annuler";
            this.btAnnulerModifSession.UseVisualStyleBackColor = false;
            // 
            // comboBoxHeureDebut
            // 
            this.comboBoxHeureDebut.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindSrcSessions, "heureDebut", true));
            this.comboBoxHeureDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxHeureDebut.FormattingEnabled = true;
            this.comboBoxHeureDebut.Location = new System.Drawing.Point(143, 76);
            this.comboBoxHeureDebut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxHeureDebut.Name = "comboBoxHeureDebut";
            this.comboBoxHeureDebut.Size = new System.Drawing.Size(92, 24);
            this.comboBoxHeureDebut.TabIndex = 3;
            // 
            // lblInscrits
            // 
            this.lblInscrits.AutoSize = true;
            this.lblInscrits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscrits.Location = new System.Drawing.Point(341, 11);
            this.lblInscrits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInscrits.Name = "lblInscrits";
            this.lblInscrits.Size = new System.Drawing.Size(64, 17);
            this.lblInscrits.TabIndex = 18;
            this.lblInscrits.Text = "Inscrits : ";
            // 
            // btSupprimerInscritSession
            // 
            this.btSupprimerInscritSession.BackColor = System.Drawing.Color.LightPink;
            this.btSupprimerInscritSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupprimerInscritSession.Location = new System.Drawing.Point(462, 340);
            this.btSupprimerInscritSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSupprimerInscritSession.Name = "btSupprimerInscritSession";
            this.btSupprimerInscritSession.Size = new System.Drawing.Size(146, 57);
            this.btSupprimerInscritSession.TabIndex = 11;
            this.btSupprimerInscritSession.Text = "Supprimer un inscrit";
            this.btSupprimerInscritSession.UseVisualStyleBackColor = false;
            // 
            // btAjouterInscritSession
            // 
            this.btAjouterInscritSession.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btAjouterInscritSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjouterInscritSession.Location = new System.Drawing.Point(647, 277);
            this.btAjouterInscritSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAjouterInscritSession.Name = "btAjouterInscritSession";
            this.btAjouterInscritSession.Size = new System.Drawing.Size(90, 43);
            this.btAjouterInscritSession.TabIndex = 10;
            this.btAjouterInscritSession.Text = "Ajouter";
            this.btAjouterInscritSession.UseVisualStyleBackColor = false;
            // 
            // lblNonInscrits
            // 
            this.lblNonInscrits.AutoSize = true;
            this.lblNonInscrits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNonInscrits.Location = new System.Drawing.Point(341, 291);
            this.lblNonInscrits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNonInscrits.Name = "lblNonInscrits";
            this.lblNonInscrits.Size = new System.Drawing.Size(94, 17);
            this.lblNonInscrits.TabIndex = 15;
            this.lblNonInscrits.Text = "Non inscrits : ";
            // 
            // comboBoxNonInscrits
            // 
            this.comboBoxNonInscrits.FormattingEnabled = true;
            this.comboBoxNonInscrits.Location = new System.Drawing.Point(462, 288);
            this.comboBoxNonInscrits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxNonInscrits.Name = "comboBoxNonInscrits";
            this.comboBoxNonInscrits.Size = new System.Drawing.Size(160, 21);
            this.comboBoxNonInscrits.TabIndex = 9;
            // 
            // txtBoxThemeSession
            // 
            this.txtBoxThemeSession.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcSessions, "theme", true));
            this.txtBoxThemeSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxThemeSession.Location = new System.Drawing.Point(88, 32);
            this.txtBoxThemeSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxThemeSession.Name = "txtBoxThemeSession";
            this.txtBoxThemeSession.Size = new System.Drawing.Size(198, 23);
            this.txtBoxThemeSession.TabIndex = 2;
            // 
            // dateTimePickerSession
            // 
            this.dateTimePickerSession.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindSrcSessions, "date", true));
            this.dateTimePickerSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerSession.Location = new System.Drawing.Point(84, 121);
            this.dateTimePickerSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerSession.Name = "dateTimePickerSession";
            this.dateTimePickerSession.Size = new System.Drawing.Size(151, 23);
            this.dateTimePickerSession.TabIndex = 4;
            // 
            // comboBoxSalleSession
            // 
            this.comboBoxSalleSession.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcSessions, "Salle", true));
            this.comboBoxSalleSession.DataSource = this.salleBindingSource;
            this.comboBoxSalleSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxSalleSession.FormattingEnabled = true;
            this.comboBoxSalleSession.Location = new System.Drawing.Point(84, 209);
            this.comboBoxSalleSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxSalleSession.Name = "comboBoxSalleSession";
            this.comboBoxSalleSession.Size = new System.Drawing.Size(92, 24);
            this.comboBoxSalleSession.TabIndex = 6;
            // 
            // salleBindingSource
            // 
            this.salleBindingSource.DataSource = typeof(GestionOrganisationCongres.Salle);
            // 
            // lblSalleSession
            // 
            this.lblSalleSession.AutoSize = true;
            this.lblSalleSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSalleSession.Location = new System.Drawing.Point(20, 212);
            this.lblSalleSession.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalleSession.Name = "lblSalleSession";
            this.lblSalleSession.Size = new System.Drawing.Size(51, 17);
            this.lblSalleSession.TabIndex = 8;
            this.lblSalleSession.Text = "Salle : ";
            // 
            // lblPrixSession
            // 
            this.lblPrixSession.AutoSize = true;
            this.lblPrixSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPrixSession.Location = new System.Drawing.Point(20, 252);
            this.lblPrixSession.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrixSession.Name = "lblPrixSession";
            this.lblPrixSession.Size = new System.Drawing.Size(43, 17);
            this.lblPrixSession.TabIndex = 7;
            this.lblPrixSession.Text = "Prix : ";
            // 
            // lblNbPlacesMaxSession
            // 
            this.lblNbPlacesMaxSession.AutoSize = true;
            this.lblNbPlacesMaxSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNbPlacesMaxSession.Location = new System.Drawing.Point(20, 170);
            this.lblNbPlacesMaxSession.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNbPlacesMaxSession.Name = "lblNbPlacesMaxSession";
            this.lblNbPlacesMaxSession.Size = new System.Drawing.Size(164, 17);
            this.lblNbPlacesMaxSession.TabIndex = 6;
            this.lblNbPlacesMaxSession.Text = "Nombre de places max : ";
            // 
            // lblHeureDebutSession
            // 
            this.lblHeureDebutSession.AutoSize = true;
            this.lblHeureDebutSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHeureDebutSession.Location = new System.Drawing.Point(20, 79);
            this.lblHeureDebutSession.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeureDebutSession.Name = "lblHeureDebutSession";
            this.lblHeureDebutSession.Size = new System.Drawing.Size(119, 17);
            this.lblHeureDebutSession.TabIndex = 5;
            this.lblHeureDebutSession.Text = "Heure de début : ";
            // 
            // lblDateSession
            // 
            this.lblDateSession.AutoSize = true;
            this.lblDateSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDateSession.Location = new System.Drawing.Point(20, 126);
            this.lblDateSession.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateSession.Name = "lblDateSession";
            this.lblDateSession.Size = new System.Drawing.Size(50, 17);
            this.lblDateSession.TabIndex = 4;
            this.lblDateSession.Text = "Date : ";
            // 
            // lblThemeSession
            // 
            this.lblThemeSession.AutoSize = true;
            this.lblThemeSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblThemeSession.Location = new System.Drawing.Point(20, 35);
            this.lblThemeSession.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThemeSession.Name = "lblThemeSession";
            this.lblThemeSession.Size = new System.Drawing.Size(64, 17);
            this.lblThemeSession.TabIndex = 3;
            this.lblThemeSession.Text = "Thème : ";
            // 
            // btSupprimerSession
            // 
            this.btSupprimerSession.BackColor = System.Drawing.Color.LightPink;
            this.btSupprimerSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btSupprimerSession.Location = new System.Drawing.Point(12, 325);
            this.btSupprimerSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSupprimerSession.Name = "btSupprimerSession";
            this.btSupprimerSession.Size = new System.Drawing.Size(172, 58);
            this.btSupprimerSession.TabIndex = 12;
            this.btSupprimerSession.Text = "Supprimer la session";
            this.btSupprimerSession.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(344, 30);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(381, 239);
            this.dataGridView2.TabIndex = 1;
            // 
            // FrmGestionSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 493);
            this.Controls.Add(this.tabControlSession);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmGestionSession";
            this.Text = "Gestion Session";
            this.Load += new System.EventHandler(this.FrmGestionSession_Load);
            this.tabControlSession.ResumeLayout(false);
            this.listeSession.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcSessions)).EndInit();
            this.detailsSession.ResumeLayout(false);
            this.detailsSession.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSession;
        private System.Windows.Forms.TabPage listeSession;
        private System.Windows.Forms.DataGridView dataGridViewSession;
        private System.Windows.Forms.TabPage detailsSession;
        private System.Windows.Forms.Button btAjouterSession;
        private System.Windows.Forms.ComboBox comboBoxSalleSession;
        private System.Windows.Forms.Label lblSalleSession;
        private System.Windows.Forms.Label lblPrixSession;
        private System.Windows.Forms.Label lblNbPlacesMaxSession;
        private System.Windows.Forms.Label lblHeureDebutSession;
        private System.Windows.Forms.Label lblDateSession;
        private System.Windows.Forms.Label lblThemeSession;
        private System.Windows.Forms.Button btSupprimerSession;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboBoxHeureDebut;
        private System.Windows.Forms.Label lblInscrits;
        private System.Windows.Forms.Button btSupprimerInscritSession;
        private System.Windows.Forms.Button btAjouterInscritSession;
        private System.Windows.Forms.Label lblNonInscrits;
        private System.Windows.Forms.ComboBox comboBoxNonInscrits;
        private System.Windows.Forms.TextBox txtBoxThemeSession;
        private System.Windows.Forms.DateTimePicker dateTimePickerSession;
        private System.Windows.Forms.Button btValiderModifSession;
        private System.Windows.Forms.Button btAnnulerModifSession;
        private System.Windows.Forms.BindingSource bindSrcSessions;
        private System.Windows.Forms.TextBox txtBoxPrixSession;
        private System.Windows.Forms.TextBox txtBoxNombrePlacesMaxSession;
        private System.Windows.Forms.DataGridViewTextBoxColumn numSessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn themeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDebutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbPlacesMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomPresidentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn congressistesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource salleBindingSource;
    }
}

