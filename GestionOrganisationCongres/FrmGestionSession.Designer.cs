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
            this.bindSrcSessions = new System.Windows.Forms.BindingSource(this.components);
            this.detailsSession = new System.Windows.Forms.TabPage();
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
            this.maskedTxtBoxNbPlacesMaxSession = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxSalleSession = new System.Windows.Forms.ComboBox();
            this.maskedTxtBoxPrixSession = new System.Windows.Forms.MaskedTextBox();
            this.lblSalleSession = new System.Windows.Forms.Label();
            this.lblPrixSession = new System.Windows.Forms.Label();
            this.lblNbPlacesMaxSession = new System.Windows.Forms.Label();
            this.lblHeureDebutSession = new System.Windows.Forms.Label();
            this.lblDateSession = new System.Windows.Forms.Label();
            this.lblThemeSession = new System.Windows.Forms.Label();
            this.btSupprimerSession = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.themeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDebutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbPlacesMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomPresidentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEuro = new System.Windows.Forms.Label();
            this.tabControlSession.SuspendLayout();
            this.listeSession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcSessions)).BeginInit();
            this.detailsSession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSession
            // 
            this.tabControlSession.Controls.Add(this.listeSession);
            this.tabControlSession.Controls.Add(this.detailsSession);
            this.tabControlSession.Location = new System.Drawing.Point(9, 10);
            this.tabControlSession.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlSession.Name = "tabControlSession";
            this.tabControlSession.SelectedIndex = 0;
            this.tabControlSession.Size = new System.Drawing.Size(904, 491);
            this.tabControlSession.TabIndex = 0;
            // 
            // listeSession
            // 
            this.listeSession.Controls.Add(this.btAjouterSession);
            this.listeSession.Controls.Add(this.dataGridViewSession);
            this.listeSession.Location = new System.Drawing.Point(4, 22);
            this.listeSession.Margin = new System.Windows.Forms.Padding(2);
            this.listeSession.Name = "listeSession";
            this.listeSession.Padding = new System.Windows.Forms.Padding(2);
            this.listeSession.Size = new System.Drawing.Size(896, 465);
            this.listeSession.TabIndex = 0;
            this.listeSession.Text = "Liste";
            this.listeSession.UseVisualStyleBackColor = true;
            // 
            // btAjouterSession
            // 
            this.btAjouterSession.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btAjouterSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btAjouterSession.Location = new System.Drawing.Point(362, 383);
            this.btAjouterSession.Margin = new System.Windows.Forms.Padding(2);
            this.btAjouterSession.Name = "btAjouterSession";
            this.btAjouterSession.Size = new System.Drawing.Size(186, 57);
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
            this.themeDataGridViewTextBoxColumn,
            this.heureDebutDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.nbPlacesMaxDataGridViewTextBoxColumn,
            this.prixDataGridViewTextBoxColumn,
            this.nomPresidentDataGridViewTextBoxColumn,
            this.idSalleDataGridViewTextBoxColumn});
            this.dataGridViewSession.DataSource = this.bindSrcSessions;
            this.dataGridViewSession.Location = new System.Drawing.Point(2, 5);
            this.dataGridViewSession.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSession.Name = "dataGridViewSession";
            this.dataGridViewSession.ReadOnly = true;
            this.dataGridViewSession.RowHeadersWidth = 51;
            this.dataGridViewSession.RowTemplate.Height = 24;
            this.dataGridViewSession.Size = new System.Drawing.Size(890, 357);
            this.dataGridViewSession.TabIndex = 0;
            // 
            // bindSrcSessions
            // 
            this.bindSrcSessions.DataSource = typeof(GestionOrganisationCongres.Session);
            // 
            // detailsSession
            // 
            this.detailsSession.Controls.Add(this.lblEuro);
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
            this.detailsSession.Controls.Add(this.maskedTxtBoxNbPlacesMaxSession);
            this.detailsSession.Controls.Add(this.comboBoxSalleSession);
            this.detailsSession.Controls.Add(this.maskedTxtBoxPrixSession);
            this.detailsSession.Controls.Add(this.lblSalleSession);
            this.detailsSession.Controls.Add(this.lblPrixSession);
            this.detailsSession.Controls.Add(this.lblNbPlacesMaxSession);
            this.detailsSession.Controls.Add(this.lblHeureDebutSession);
            this.detailsSession.Controls.Add(this.lblDateSession);
            this.detailsSession.Controls.Add(this.lblThemeSession);
            this.detailsSession.Controls.Add(this.btSupprimerSession);
            this.detailsSession.Controls.Add(this.dataGridView2);
            this.detailsSession.Location = new System.Drawing.Point(4, 22);
            this.detailsSession.Margin = new System.Windows.Forms.Padding(2);
            this.detailsSession.Name = "detailsSession";
            this.detailsSession.Padding = new System.Windows.Forms.Padding(2);
            this.detailsSession.Size = new System.Drawing.Size(896, 465);
            this.detailsSession.TabIndex = 1;
            this.detailsSession.Text = "Détails";
            this.detailsSession.UseVisualStyleBackColor = true;
            // 
            // btValiderModifSession
            // 
            this.btValiderModifSession.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btValiderModifSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btValiderModifSession.Location = new System.Drawing.Point(213, 377);
            this.btValiderModifSession.Margin = new System.Windows.Forms.Padding(2);
            this.btValiderModifSession.Name = "btValiderModifSession";
            this.btValiderModifSession.Size = new System.Drawing.Size(108, 54);
            this.btValiderModifSession.TabIndex = 48;
            this.btValiderModifSession.Text = "Valider";
            this.btValiderModifSession.UseVisualStyleBackColor = false;
            // 
            // btAnnulerModifSession
            // 
            this.btAnnulerModifSession.BackColor = System.Drawing.Color.LightPink;
            this.btAnnulerModifSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btAnnulerModifSession.Location = new System.Drawing.Point(12, 388);
            this.btAnnulerModifSession.Margin = new System.Windows.Forms.Padding(2);
            this.btAnnulerModifSession.Name = "btAnnulerModifSession";
            this.btAnnulerModifSession.Size = new System.Drawing.Size(102, 43);
            this.btAnnulerModifSession.TabIndex = 47;
            this.btAnnulerModifSession.Text = "Annuler";
            this.btAnnulerModifSession.UseVisualStyleBackColor = false;
            // 
            // comboBoxHeureDebut
            // 
            this.comboBoxHeureDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxHeureDebut.FormattingEnabled = true;
            this.comboBoxHeureDebut.Location = new System.Drawing.Point(144, 85);
            this.comboBoxHeureDebut.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxHeureDebut.Name = "comboBoxHeureDebut";
            this.comboBoxHeureDebut.Size = new System.Drawing.Size(92, 24);
            this.comboBoxHeureDebut.TabIndex = 3;
            // 
            // lblInscrits
            // 
            this.lblInscrits.AutoSize = true;
            this.lblInscrits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscrits.Location = new System.Drawing.Point(433, 12);
            this.lblInscrits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInscrits.Name = "lblInscrits";
            this.lblInscrits.Size = new System.Drawing.Size(67, 18);
            this.lblInscrits.TabIndex = 18;
            this.lblInscrits.Text = "Inscrits : ";
            // 
            // btSupprimerInscritSession
            // 
            this.btSupprimerInscritSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btSupprimerInscritSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupprimerInscritSession.Location = new System.Drawing.Point(436, 374);
            this.btSupprimerInscritSession.Margin = new System.Windows.Forms.Padding(2);
            this.btSupprimerInscritSession.Name = "btSupprimerInscritSession";
            this.btSupprimerInscritSession.Size = new System.Drawing.Size(144, 61);
            this.btSupprimerInscritSession.TabIndex = 11;
            this.btSupprimerInscritSession.Text = "Supprimer un inscrit";
            this.btSupprimerInscritSession.UseVisualStyleBackColor = false;
            // 
            // btAjouterInscritSession
            // 
            this.btAjouterInscritSession.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btAjouterInscritSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjouterInscritSession.Location = new System.Drawing.Point(766, 344);
            this.btAjouterInscritSession.Margin = new System.Windows.Forms.Padding(2);
            this.btAjouterInscritSession.Name = "btAjouterInscritSession";
            this.btAjouterInscritSession.Size = new System.Drawing.Size(110, 37);
            this.btAjouterInscritSession.TabIndex = 10;
            this.btAjouterInscritSession.Text = "Ajouter";
            this.btAjouterInscritSession.UseVisualStyleBackColor = false;
            // 
            // lblNonInscrits
            // 
            this.lblNonInscrits.AutoSize = true;
            this.lblNonInscrits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNonInscrits.Location = new System.Drawing.Point(433, 301);
            this.lblNonInscrits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNonInscrits.Name = "lblNonInscrits";
            this.lblNonInscrits.Size = new System.Drawing.Size(99, 18);
            this.lblNonInscrits.TabIndex = 15;
            this.lblNonInscrits.Text = "Non inscrits : ";
            // 
            // comboBoxNonInscrits
            // 
            this.comboBoxNonInscrits.FormattingEnabled = true;
            this.comboBoxNonInscrits.Location = new System.Drawing.Point(536, 302);
            this.comboBoxNonInscrits.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxNonInscrits.Name = "comboBoxNonInscrits";
            this.comboBoxNonInscrits.Size = new System.Drawing.Size(210, 21);
            this.comboBoxNonInscrits.TabIndex = 9;
            // 
            // txtBoxThemeSession
            // 
            this.txtBoxThemeSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxThemeSession.Location = new System.Drawing.Point(88, 32);
            this.txtBoxThemeSession.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxThemeSession.Name = "txtBoxThemeSession";
            this.txtBoxThemeSession.Size = new System.Drawing.Size(198, 23);
            this.txtBoxThemeSession.TabIndex = 2;
            // 
            // dateTimePickerSession
            // 
            this.dateTimePickerSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerSession.Location = new System.Drawing.Point(75, 135);
            this.dateTimePickerSession.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerSession.Name = "dateTimePickerSession";
            this.dateTimePickerSession.Size = new System.Drawing.Size(151, 23);
            this.dateTimePickerSession.TabIndex = 4;
            // 
            // maskedTxtBoxNbPlacesMaxSession
            // 
            this.maskedTxtBoxNbPlacesMaxSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTxtBoxNbPlacesMaxSession.Location = new System.Drawing.Point(197, 187);
            this.maskedTxtBoxNbPlacesMaxSession.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTxtBoxNbPlacesMaxSession.Mask = "999999";
            this.maskedTxtBoxNbPlacesMaxSession.Name = "maskedTxtBoxNbPlacesMaxSession";
            this.maskedTxtBoxNbPlacesMaxSession.Size = new System.Drawing.Size(108, 23);
            this.maskedTxtBoxNbPlacesMaxSession.TabIndex = 5;
            // 
            // comboBoxSalleSession
            // 
            this.comboBoxSalleSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxSalleSession.FormattingEnabled = true;
            this.comboBoxSalleSession.Location = new System.Drawing.Point(75, 244);
            this.comboBoxSalleSession.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSalleSession.Name = "comboBoxSalleSession";
            this.comboBoxSalleSession.Size = new System.Drawing.Size(92, 24);
            this.comboBoxSalleSession.TabIndex = 6;
            // 
            // maskedTxtBoxPrixSession
            // 
            this.maskedTxtBoxPrixSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTxtBoxPrixSession.Location = new System.Drawing.Point(69, 300);
            this.maskedTxtBoxPrixSession.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTxtBoxPrixSession.Mask = "999999";
            this.maskedTxtBoxPrixSession.Name = "maskedTxtBoxPrixSession";
            this.maskedTxtBoxPrixSession.Size = new System.Drawing.Size(76, 23);
            this.maskedTxtBoxPrixSession.TabIndex = 8;
            // 
            // lblSalleSession
            // 
            this.lblSalleSession.AutoSize = true;
            this.lblSalleSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblSalleSession.Location = new System.Drawing.Point(20, 245);
            this.lblSalleSession.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalleSession.Name = "lblSalleSession";
            this.lblSalleSession.Size = new System.Drawing.Size(52, 18);
            this.lblSalleSession.TabIndex = 8;
            this.lblSalleSession.Text = "Salle : ";
            // 
            // lblPrixSession
            // 
            this.lblPrixSession.AutoSize = true;
            this.lblPrixSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPrixSession.Location = new System.Drawing.Point(20, 301);
            this.lblPrixSession.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrixSession.Name = "lblPrixSession";
            this.lblPrixSession.Size = new System.Drawing.Size(45, 18);
            this.lblPrixSession.TabIndex = 7;
            this.lblPrixSession.Text = "Prix : ";
            // 
            // lblNbPlacesMaxSession
            // 
            this.lblNbPlacesMaxSession.AutoSize = true;
            this.lblNbPlacesMaxSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNbPlacesMaxSession.Location = new System.Drawing.Point(20, 192);
            this.lblNbPlacesMaxSession.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNbPlacesMaxSession.Name = "lblNbPlacesMaxSession";
            this.lblNbPlacesMaxSession.Size = new System.Drawing.Size(173, 18);
            this.lblNbPlacesMaxSession.TabIndex = 6;
            this.lblNbPlacesMaxSession.Text = "Nombre de places max : ";
            // 
            // lblHeureDebutSession
            // 
            this.lblHeureDebutSession.AutoSize = true;
            this.lblHeureDebutSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblHeureDebutSession.Location = new System.Drawing.Point(20, 91);
            this.lblHeureDebutSession.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeureDebutSession.Name = "lblHeureDebutSession";
            this.lblHeureDebutSession.Size = new System.Drawing.Size(120, 18);
            this.lblHeureDebutSession.TabIndex = 5;
            this.lblHeureDebutSession.Text = "Heure de début : ";
            // 
            // lblDateSession
            // 
            this.lblDateSession.AutoSize = true;
            this.lblDateSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblDateSession.Location = new System.Drawing.Point(20, 140);
            this.lblDateSession.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateSession.Name = "lblDateSession";
            this.lblDateSession.Size = new System.Drawing.Size(51, 18);
            this.lblDateSession.TabIndex = 4;
            this.lblDateSession.Text = "Date : ";
            // 
            // lblThemeSession
            // 
            this.lblThemeSession.AutoSize = true;
            this.lblThemeSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblThemeSession.Location = new System.Drawing.Point(20, 35);
            this.lblThemeSession.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThemeSession.Name = "lblThemeSession";
            this.lblThemeSession.Size = new System.Drawing.Size(66, 18);
            this.lblThemeSession.TabIndex = 3;
            this.lblThemeSession.Text = "Thème : ";
            // 
            // btSupprimerSession
            // 
            this.btSupprimerSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btSupprimerSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btSupprimerSession.Location = new System.Drawing.Point(188, 376);
            this.btSupprimerSession.Margin = new System.Windows.Forms.Padding(2);
            this.btSupprimerSession.Name = "btSupprimerSession";
            this.btSupprimerSession.Size = new System.Drawing.Size(158, 56);
            this.btSupprimerSession.TabIndex = 12;
            this.btSupprimerSession.Text = "Supprimer la session";
            this.btSupprimerSession.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(436, 32);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(440, 251);
            this.dataGridView2.TabIndex = 1;
            // 
            // themeDataGridViewTextBoxColumn
            // 
            this.themeDataGridViewTextBoxColumn.DataPropertyName = "theme";
            this.themeDataGridViewTextBoxColumn.HeaderText = "Thème";
            this.themeDataGridViewTextBoxColumn.Name = "themeDataGridViewTextBoxColumn";
            this.themeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // heureDebutDataGridViewTextBoxColumn
            // 
            this.heureDebutDataGridViewTextBoxColumn.DataPropertyName = "heureDebut";
            this.heureDebutDataGridViewTextBoxColumn.HeaderText = "Heure de début";
            this.heureDebutDataGridViewTextBoxColumn.Name = "heureDebutDataGridViewTextBoxColumn";
            this.heureDebutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nbPlacesMaxDataGridViewTextBoxColumn
            // 
            this.nbPlacesMaxDataGridViewTextBoxColumn.DataPropertyName = "nbPlacesMax";
            this.nbPlacesMaxDataGridViewTextBoxColumn.HeaderText = "Nombre de places maximum";
            this.nbPlacesMaxDataGridViewTextBoxColumn.Name = "nbPlacesMaxDataGridViewTextBoxColumn";
            this.nbPlacesMaxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "prix";
            this.prixDataGridViewTextBoxColumn.HeaderText = "Prix";
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            this.prixDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomPresidentDataGridViewTextBoxColumn
            // 
            this.nomPresidentDataGridViewTextBoxColumn.DataPropertyName = "nomPresident";
            this.nomPresidentDataGridViewTextBoxColumn.HeaderText = "Nom du président";
            this.nomPresidentDataGridViewTextBoxColumn.Name = "nomPresidentDataGridViewTextBoxColumn";
            this.nomPresidentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idSalleDataGridViewTextBoxColumn
            // 
            this.idSalleDataGridViewTextBoxColumn.DataPropertyName = "idSalle";
            this.idSalleDataGridViewTextBoxColumn.HeaderText = "N° de salle";
            this.idSalleDataGridViewTextBoxColumn.Name = "idSalleDataGridViewTextBoxColumn";
            this.idSalleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro.Location = new System.Drawing.Point(152, 301);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(16, 18);
            this.lblEuro.TabIndex = 49;
            this.lblEuro.Text = "€";
            // 
            // FrmGestionSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 512);
            this.Controls.Add(this.tabControlSession);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmGestionSession";
            this.Text = "Gestion Session";
            this.Load += new System.EventHandler(this.FrmGestionSession_Load);
            this.tabControlSession.ResumeLayout(false);
            this.listeSession.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcSessions)).EndInit();
            this.detailsSession.ResumeLayout(false);
            this.detailsSession.PerformLayout();
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
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxPrixSession;
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
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxNbPlacesMaxSession;
        private System.Windows.Forms.Button btValiderModifSession;
        private System.Windows.Forms.Button btAnnulerModifSession;
        private System.Windows.Forms.BindingSource bindSrcSessions;
        private System.Windows.Forms.DataGridViewTextBoxColumn themeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDebutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbPlacesMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomPresidentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblEuro;
    }
}

