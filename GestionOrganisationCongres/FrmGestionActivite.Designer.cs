namespace GestionOrganisationCongres
{
    partial class FrmGestionActivite
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ComboBox comboBoxNonInscrits;
            this.bindSrcNonInscrits = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlActivite = new System.Windows.Forms.TabControl();
            this.listeActivite = new System.Windows.Forms.TabPage();
            this.btAjouterActivite = new System.Windows.Forms.Button();
            this.dataGridViewActivite = new System.Windows.Forms.DataGridView();
            this.idActiviteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDebutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbPlacesMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcActivites = new System.Windows.Forms.BindingSource(this.components);
            this.detailsActivite = new System.Windows.Forms.TabPage();
            this.lblPlacesDispoValeur = new System.Windows.Forms.Label();
            this.lblPlacesDispo = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.txtBoxNbPlacesMax = new System.Windows.Forms.TextBox();
            this.txtBoxPrix = new System.Windows.Forms.TextBox();
            this.btValiderActivite = new System.Windows.Forms.Button();
            this.btAnnulerModifActivite = new System.Windows.Forms.Button();
            this.comboBoxHeureActivite = new System.Windows.Forms.ComboBox();
            this.lblInscrits = new System.Windows.Forms.Label();
            this.btSupprimerInscritActivite = new System.Windows.Forms.Button();
            this.btAjouterInscritActivite = new System.Windows.Forms.Button();
            this.lblNonInscrits = new System.Windows.Forms.Label();
            this.txtBoxDesignationActivite = new System.Windows.Forms.TextBox();
            this.dateTimePickerActiviter = new System.Windows.Forms.DateTimePicker();
            this.lblPrixActivite = new System.Windows.Forms.Label();
            this.lblNbPlacesMaxActivite = new System.Windows.Forms.Label();
            this.lblHeureDebutActivite = new System.Windows.Forms.Label();
            this.lblDateActivite = new System.Windows.Forms.Label();
            this.lblDesignationActivite = new System.Windows.Forms.Label();
            this.btSupprimerActivite = new System.Windows.Forms.Button();
            this.dataGridViewInscritsActivite = new System.Windows.Forms.DataGridView();
            this.numInscriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acompteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLigueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcInscriptions = new System.Windows.Forms.BindingSource(this.components);
            comboBoxNonInscrits = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcNonInscrits)).BeginInit();
            this.tabControlActivite.SuspendLayout();
            this.listeActivite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcActivites)).BeginInit();
            this.detailsActivite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInscritsActivite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcInscriptions)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxNonInscrits
            // 
            comboBoxNonInscrits.DataSource = this.bindSrcNonInscrits;
            comboBoxNonInscrits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxNonInscrits.FormattingEnabled = true;
            comboBoxNonInscrits.Location = new System.Drawing.Point(700, 379);
            comboBoxNonInscrits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            comboBoxNonInscrits.Name = "comboBoxNonInscrits";
            comboBoxNonInscrits.Size = new System.Drawing.Size(399, 24);
            comboBoxNonInscrits.TabIndex = 55;
            // 
            // bindSrcNonInscrits
            // 
            this.bindSrcNonInscrits.DataSource = typeof(GestionOrganisationCongres.Congressiste);
            // 
            // tabControlActivite
            // 
            this.tabControlActivite.Controls.Add(this.listeActivite);
            this.tabControlActivite.Controls.Add(this.detailsActivite);
            this.tabControlActivite.Location = new System.Drawing.Point(12, 11);
            this.tabControlActivite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlActivite.Name = "tabControlActivite";
            this.tabControlActivite.SelectedIndex = 0;
            this.tabControlActivite.Size = new System.Drawing.Size(1253, 561);
            this.tabControlActivite.TabIndex = 1;
            // 
            // listeActivite
            // 
            this.listeActivite.Controls.Add(this.btAjouterActivite);
            this.listeActivite.Controls.Add(this.dataGridViewActivite);
            this.listeActivite.Location = new System.Drawing.Point(4, 25);
            this.listeActivite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listeActivite.Name = "listeActivite";
            this.listeActivite.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listeActivite.Size = new System.Drawing.Size(1245, 532);
            this.listeActivite.TabIndex = 0;
            this.listeActivite.Text = "Liste";
            this.listeActivite.UseVisualStyleBackColor = true;
            // 
            // btAjouterActivite
            // 
            this.btAjouterActivite.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btAjouterActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btAjouterActivite.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btAjouterActivite.Location = new System.Drawing.Point(493, 442);
            this.btAjouterActivite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAjouterActivite.Name = "btAjouterActivite";
            this.btAjouterActivite.Size = new System.Drawing.Size(237, 64);
            this.btAjouterActivite.TabIndex = 1;
            this.btAjouterActivite.Text = "Ajouter une activité";
            this.btAjouterActivite.UseVisualStyleBackColor = false;
            this.btAjouterActivite.Click += new System.EventHandler(this.btAjouterActivite_Click);
            // 
            // dataGridViewActivite
            // 
            this.dataGridViewActivite.AllowUserToAddRows = false;
            this.dataGridViewActivite.AllowUserToDeleteRows = false;
            this.dataGridViewActivite.AutoGenerateColumns = false;
            this.dataGridViewActivite.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewActivite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActivite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idActiviteDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn,
            this.prixDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.heureDebutDataGridViewTextBoxColumn,
            this.nbPlacesMaxDataGridViewTextBoxColumn});
            this.dataGridViewActivite.DataSource = this.bindSrcActivites;
            this.dataGridViewActivite.Location = new System.Drawing.Point(3, 6);
            this.dataGridViewActivite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewActivite.MultiSelect = false;
            this.dataGridViewActivite.Name = "dataGridViewActivite";
            this.dataGridViewActivite.ReadOnly = true;
            this.dataGridViewActivite.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewActivite.RowTemplate.Height = 24;
            this.dataGridViewActivite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewActivite.Size = new System.Drawing.Size(1236, 416);
            this.dataGridViewActivite.TabIndex = 0;
            // 
            // idActiviteDataGridViewTextBoxColumn
            // 
            this.idActiviteDataGridViewTextBoxColumn.DataPropertyName = "idActivite";
            this.idActiviteDataGridViewTextBoxColumn.HeaderText = "N° activité";
            this.idActiviteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idActiviteDataGridViewTextBoxColumn.Name = "idActiviteDataGridViewTextBoxColumn";
            this.idActiviteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idActiviteDataGridViewTextBoxColumn.Width = 88;
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Désignation";
            this.designationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            this.designationDataGridViewTextBoxColumn.ReadOnly = true;
            this.designationDataGridViewTextBoxColumn.Width = 108;
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "prix";
            this.prixDataGridViewTextBoxColumn.HeaderText = "Prix";
            this.prixDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            this.prixDataGridViewTextBoxColumn.ReadOnly = true;
            this.prixDataGridViewTextBoxColumn.Width = 58;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 65;
            // 
            // heureDebutDataGridViewTextBoxColumn
            // 
            this.heureDebutDataGridViewTextBoxColumn.DataPropertyName = "heureDebut";
            this.heureDebutDataGridViewTextBoxColumn.HeaderText = "Heure de début";
            this.heureDebutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.heureDebutDataGridViewTextBoxColumn.Name = "heureDebutDataGridViewTextBoxColumn";
            this.heureDebutDataGridViewTextBoxColumn.ReadOnly = true;
            this.heureDebutDataGridViewTextBoxColumn.Width = 119;
            // 
            // nbPlacesMaxDataGridViewTextBoxColumn
            // 
            this.nbPlacesMaxDataGridViewTextBoxColumn.DataPropertyName = "nbPlacesMax";
            this.nbPlacesMaxDataGridViewTextBoxColumn.HeaderText = "Nombre de places max";
            this.nbPlacesMaxDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nbPlacesMaxDataGridViewTextBoxColumn.Name = "nbPlacesMaxDataGridViewTextBoxColumn";
            this.nbPlacesMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.nbPlacesMaxDataGridViewTextBoxColumn.Width = 138;
            // 
            // bindSrcActivites
            // 
            this.bindSrcActivites.DataSource = typeof(GestionOrganisationCongres.Activite);
            this.bindSrcActivites.CurrentChanged += new System.EventHandler(this.bindSrcActivites_CurrentChanged);
            // 
            // detailsActivite
            // 
            this.detailsActivite.Controls.Add(comboBoxNonInscrits);
            this.detailsActivite.Controls.Add(this.lblPlacesDispoValeur);
            this.detailsActivite.Controls.Add(this.lblPlacesDispo);
            this.detailsActivite.Controls.Add(this.lblEuro);
            this.detailsActivite.Controls.Add(this.txtBoxNbPlacesMax);
            this.detailsActivite.Controls.Add(this.txtBoxPrix);
            this.detailsActivite.Controls.Add(this.btValiderActivite);
            this.detailsActivite.Controls.Add(this.btAnnulerModifActivite);
            this.detailsActivite.Controls.Add(this.comboBoxHeureActivite);
            this.detailsActivite.Controls.Add(this.lblInscrits);
            this.detailsActivite.Controls.Add(this.btSupprimerInscritActivite);
            this.detailsActivite.Controls.Add(this.btAjouterInscritActivite);
            this.detailsActivite.Controls.Add(this.lblNonInscrits);
            this.detailsActivite.Controls.Add(this.txtBoxDesignationActivite);
            this.detailsActivite.Controls.Add(this.dateTimePickerActiviter);
            this.detailsActivite.Controls.Add(this.lblPrixActivite);
            this.detailsActivite.Controls.Add(this.lblNbPlacesMaxActivite);
            this.detailsActivite.Controls.Add(this.lblHeureDebutActivite);
            this.detailsActivite.Controls.Add(this.lblDateActivite);
            this.detailsActivite.Controls.Add(this.lblDesignationActivite);
            this.detailsActivite.Controls.Add(this.btSupprimerActivite);
            this.detailsActivite.Controls.Add(this.dataGridViewInscritsActivite);
            this.detailsActivite.Location = new System.Drawing.Point(4, 25);
            this.detailsActivite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.detailsActivite.Name = "detailsActivite";
            this.detailsActivite.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.detailsActivite.Size = new System.Drawing.Size(1245, 532);
            this.detailsActivite.TabIndex = 1;
            this.detailsActivite.Text = "Détails";
            this.detailsActivite.UseVisualStyleBackColor = true;
            // 
            // lblPlacesDispoValeur
            // 
            this.lblPlacesDispoValeur.AutoSize = true;
            this.lblPlacesDispoValeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacesDispoValeur.Location = new System.Drawing.Point(770, 424);
            this.lblPlacesDispoValeur.Name = "lblPlacesDispoValeur";
            this.lblPlacesDispoValeur.Size = new System.Drawing.Size(15, 20);
            this.lblPlacesDispoValeur.TabIndex = 54;
            this.lblPlacesDispoValeur.Text = "-";
            // 
            // lblPlacesDispo
            // 
            this.lblPlacesDispo.AutoSize = true;
            this.lblPlacesDispo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacesDispo.Location = new System.Drawing.Point(580, 424);
            this.lblPlacesDispo.Name = "lblPlacesDispo";
            this.lblPlacesDispo.Size = new System.Drawing.Size(159, 20);
            this.lblPlacesDispo.TabIndex = 53;
            this.lblPlacesDispo.Text = "Places disponibles :";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblEuro.Location = new System.Drawing.Point(193, 340);
            this.lblEuro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(20, 24);
            this.lblEuro.TabIndex = 52;
            this.lblEuro.Text = "€";
            // 
            // txtBoxNbPlacesMax
            // 
            this.txtBoxNbPlacesMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcActivites, "nbPlacesMax", true));
            this.txtBoxNbPlacesMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxNbPlacesMax.Location = new System.Drawing.Point(249, 258);
            this.txtBoxNbPlacesMax.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxNbPlacesMax.Name = "txtBoxNbPlacesMax";
            this.txtBoxNbPlacesMax.Size = new System.Drawing.Size(132, 26);
            this.txtBoxNbPlacesMax.TabIndex = 3;
            // 
            // txtBoxPrix
            // 
            this.txtBoxPrix.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcActivites, "prix", true));
            this.txtBoxPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxPrix.Location = new System.Drawing.Point(77, 336);
            this.txtBoxPrix.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPrix.Name = "txtBoxPrix";
            this.txtBoxPrix.Size = new System.Drawing.Size(107, 26);
            this.txtBoxPrix.TabIndex = 4;
            // 
            // btValiderActivite
            // 
            this.btValiderActivite.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btValiderActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btValiderActivite.Location = new System.Drawing.Point(55, 405);
            this.btValiderActivite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btValiderActivite.Name = "btValiderActivite";
            this.btValiderActivite.Size = new System.Drawing.Size(139, 39);
            this.btValiderActivite.TabIndex = 5;
            this.btValiderActivite.Text = "Valider";
            this.btValiderActivite.UseVisualStyleBackColor = false;
            this.btValiderActivite.Click += new System.EventHandler(this.btValiderActivite_Click);
            // 
            // btAnnulerModifActivite
            // 
            this.btAnnulerModifActivite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btAnnulerModifActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btAnnulerModifActivite.Location = new System.Drawing.Point(283, 405);
            this.btAnnulerModifActivite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAnnulerModifActivite.Name = "btAnnulerModifActivite";
            this.btAnnulerModifActivite.Size = new System.Drawing.Size(141, 39);
            this.btAnnulerModifActivite.TabIndex = 6;
            this.btAnnulerModifActivite.Text = "Annuler";
            this.btAnnulerModifActivite.UseVisualStyleBackColor = false;
            this.btAnnulerModifActivite.Click += new System.EventHandler(this.btAnnulerModifActivite_Click);
            // 
            // comboBoxHeureActivite
            // 
            this.comboBoxHeureActivite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcActivites, "heureDebut", true));
            this.comboBoxHeureActivite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHeureActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxHeureActivite.FormattingEnabled = true;
            this.comboBoxHeureActivite.Location = new System.Drawing.Point(176, 103);
            this.comboBoxHeureActivite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxHeureActivite.Name = "comboBoxHeureActivite";
            this.comboBoxHeureActivite.Size = new System.Drawing.Size(121, 28);
            this.comboBoxHeureActivite.TabIndex = 1;
            // 
            // lblInscrits
            // 
            this.lblInscrits.AutoSize = true;
            this.lblInscrits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscrits.Location = new System.Drawing.Point(580, 9);
            this.lblInscrits.Name = "lblInscrits";
            this.lblInscrits.Size = new System.Drawing.Size(79, 20);
            this.lblInscrits.TabIndex = 18;
            this.lblInscrits.Text = "Inscrits : ";
            // 
            // btSupprimerInscritActivite
            // 
            this.btSupprimerInscritActivite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btSupprimerInscritActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupprimerInscritActivite.Location = new System.Drawing.Point(725, 461);
            this.btSupprimerInscritActivite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSupprimerInscritActivite.Name = "btSupprimerInscritActivite";
            this.btSupprimerInscritActivite.Size = new System.Drawing.Size(296, 47);
            this.btSupprimerInscritActivite.TabIndex = 11;
            this.btSupprimerInscritActivite.Text = "Supprimer un inscrit";
            this.btSupprimerInscritActivite.UseVisualStyleBackColor = false;
            this.btSupprimerInscritActivite.Click += new System.EventHandler(this.btSupprimerInscritActivite_Click);
            // 
            // btAjouterInscritActivite
            // 
            this.btAjouterInscritActivite.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btAjouterInscritActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjouterInscritActivite.Location = new System.Drawing.Point(1118, 367);
            this.btAjouterInscritActivite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAjouterInscritActivite.Name = "btAjouterInscritActivite";
            this.btAjouterInscritActivite.Size = new System.Drawing.Size(127, 40);
            this.btAjouterInscritActivite.TabIndex = 10;
            this.btAjouterInscritActivite.Text = "Ajouter";
            this.btAjouterInscritActivite.UseVisualStyleBackColor = false;
            this.btAjouterInscritActivite.Click += new System.EventHandler(this.btAjouterInscritActivite_Click);
            // 
            // lblNonInscrits
            // 
            this.lblNonInscrits.AutoSize = true;
            this.lblNonInscrits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNonInscrits.Location = new System.Drawing.Point(580, 383);
            this.lblNonInscrits.Name = "lblNonInscrits";
            this.lblNonInscrits.Size = new System.Drawing.Size(114, 20);
            this.lblNonInscrits.TabIndex = 15;
            this.lblNonInscrits.Text = "Non inscrits : ";
            // 
            // txtBoxDesignationActivite
            // 
            this.txtBoxDesignationActivite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcActivites, "designation", true));
            this.txtBoxDesignationActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxDesignationActivite.Location = new System.Drawing.Point(145, 28);
            this.txtBoxDesignationActivite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxDesignationActivite.Name = "txtBoxDesignationActivite";
            this.txtBoxDesignationActivite.Size = new System.Drawing.Size(401, 26);
            this.txtBoxDesignationActivite.TabIndex = 0;
            // 
            // dateTimePickerActiviter
            // 
            this.dateTimePickerActiviter.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindSrcActivites, "date", true));
            this.dateTimePickerActiviter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerActiviter.Location = new System.Drawing.Point(84, 185);
            this.dateTimePickerActiviter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerActiviter.Name = "dateTimePickerActiviter";
            this.dateTimePickerActiviter.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerActiviter.TabIndex = 2;
            // 
            // lblPrixActivite
            // 
            this.lblPrixActivite.AutoSize = true;
            this.lblPrixActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPrixActivite.Location = new System.Drawing.Point(12, 340);
            this.lblPrixActivite.Name = "lblPrixActivite";
            this.lblPrixActivite.Size = new System.Drawing.Size(57, 24);
            this.lblPrixActivite.TabIndex = 7;
            this.lblPrixActivite.Text = "Prix : ";
            // 
            // lblNbPlacesMaxActivite
            // 
            this.lblNbPlacesMaxActivite.AutoSize = true;
            this.lblNbPlacesMaxActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNbPlacesMaxActivite.Location = new System.Drawing.Point(12, 265);
            this.lblNbPlacesMaxActivite.Name = "lblNbPlacesMaxActivite";
            this.lblNbPlacesMaxActivite.Size = new System.Drawing.Size(222, 24);
            this.lblNbPlacesMaxActivite.TabIndex = 6;
            this.lblNbPlacesMaxActivite.Text = "Nombre de places max : ";
            // 
            // lblHeureDebutActivite
            // 
            this.lblHeureDebutActivite.AutoSize = true;
            this.lblHeureDebutActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblHeureDebutActivite.Location = new System.Drawing.Point(12, 112);
            this.lblHeureDebutActivite.Name = "lblHeureDebutActivite";
            this.lblHeureDebutActivite.Size = new System.Drawing.Size(158, 24);
            this.lblHeureDebutActivite.TabIndex = 5;
            this.lblHeureDebutActivite.Text = "Heure de début : ";
            // 
            // lblDateActivite
            // 
            this.lblDateActivite.AutoSize = true;
            this.lblDateActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblDateActivite.Location = new System.Drawing.Point(12, 191);
            this.lblDateActivite.Name = "lblDateActivite";
            this.lblDateActivite.Size = new System.Drawing.Size(63, 24);
            this.lblDateActivite.TabIndex = 4;
            this.lblDateActivite.Text = "Date : ";
            // 
            // lblDesignationActivite
            // 
            this.lblDesignationActivite.AutoSize = true;
            this.lblDesignationActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblDesignationActivite.Location = new System.Drawing.Point(13, 32);
            this.lblDesignationActivite.Name = "lblDesignationActivite";
            this.lblDesignationActivite.Size = new System.Drawing.Size(124, 24);
            this.lblDesignationActivite.TabIndex = 3;
            this.lblDesignationActivite.Text = "Désignation : ";
            // 
            // btSupprimerActivite
            // 
            this.btSupprimerActivite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btSupprimerActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btSupprimerActivite.Location = new System.Drawing.Point(105, 455);
            this.btSupprimerActivite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSupprimerActivite.Name = "btSupprimerActivite";
            this.btSupprimerActivite.Size = new System.Drawing.Size(264, 58);
            this.btSupprimerActivite.TabIndex = 7;
            this.btSupprimerActivite.Text = "Supprimer l\'activité";
            this.btSupprimerActivite.UseVisualStyleBackColor = false;
            this.btSupprimerActivite.Click += new System.EventHandler(this.btSupprimerActivite_Click);
            // 
            // dataGridViewInscritsActivite
            // 
            this.dataGridViewInscritsActivite.AllowUserToAddRows = false;
            this.dataGridViewInscritsActivite.AllowUserToDeleteRows = false;
            this.dataGridViewInscritsActivite.AutoGenerateColumns = false;
            this.dataGridViewInscritsActivite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInscritsActivite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numInscriptionDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.cpDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.acompteDataGridViewTextBoxColumn,
            this.idLigueDataGridViewTextBoxColumn,
            this.hotelDataGridViewTextBoxColumn});
            this.dataGridViewInscritsActivite.DataSource = this.bindSrcInscriptions;
            this.dataGridViewInscritsActivite.Location = new System.Drawing.Point(584, 32);
            this.dataGridViewInscritsActivite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewInscritsActivite.MultiSelect = false;
            this.dataGridViewInscritsActivite.Name = "dataGridViewInscritsActivite";
            this.dataGridViewInscritsActivite.ReadOnly = true;
            this.dataGridViewInscritsActivite.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewInscritsActivite.RowTemplate.Height = 24;
            this.dataGridViewInscritsActivite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInscritsActivite.Size = new System.Drawing.Size(641, 330);
            this.dataGridViewInscritsActivite.TabIndex = 1;
            // 
            // numInscriptionDataGridViewTextBoxColumn
            // 
            this.numInscriptionDataGridViewTextBoxColumn.DataPropertyName = "numInscription";
            this.numInscriptionDataGridViewTextBoxColumn.HeaderText = "N° inscription";
            this.numInscriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numInscriptionDataGridViewTextBoxColumn.Name = "numInscriptionDataGridViewTextBoxColumn";
            this.numInscriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.numInscriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomDataGridViewTextBoxColumn.Width = 125;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.prenomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            this.prenomDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresseDataGridViewTextBoxColumn.Width = 125;
            // 
            // cpDataGridViewTextBoxColumn
            // 
            this.cpDataGridViewTextBoxColumn.DataPropertyName = "cp";
            this.cpDataGridViewTextBoxColumn.HeaderText = "Code postal";
            this.cpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cpDataGridViewTextBoxColumn.Name = "cpDataGridViewTextBoxColumn";
            this.cpDataGridViewTextBoxColumn.ReadOnly = true;
            this.cpDataGridViewTextBoxColumn.Width = 125;
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "ville";
            this.villeDataGridViewTextBoxColumn.HeaderText = "Ville";
            this.villeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            this.villeDataGridViewTextBoxColumn.ReadOnly = true;
            this.villeDataGridViewTextBoxColumn.Width = 125;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "Téléphone";
            this.telDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.ReadOnly = true;
            this.telDataGridViewTextBoxColumn.Width = 125;
            // 
            // acompteDataGridViewTextBoxColumn
            // 
            this.acompteDataGridViewTextBoxColumn.DataPropertyName = "acompte";
            this.acompteDataGridViewTextBoxColumn.HeaderText = "Acompte";
            this.acompteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.acompteDataGridViewTextBoxColumn.Name = "acompteDataGridViewTextBoxColumn";
            this.acompteDataGridViewTextBoxColumn.ReadOnly = true;
            this.acompteDataGridViewTextBoxColumn.Width = 125;
            // 
            // idLigueDataGridViewTextBoxColumn
            // 
            this.idLigueDataGridViewTextBoxColumn.DataPropertyName = "Ligue";
            this.idLigueDataGridViewTextBoxColumn.HeaderText = "Ligue";
            this.idLigueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idLigueDataGridViewTextBoxColumn.Name = "idLigueDataGridViewTextBoxColumn";
            this.idLigueDataGridViewTextBoxColumn.ReadOnly = true;
            this.idLigueDataGridViewTextBoxColumn.Width = 125;
            // 
            // hotelDataGridViewTextBoxColumn
            // 
            this.hotelDataGridViewTextBoxColumn.DataPropertyName = "Hotel";
            this.hotelDataGridViewTextBoxColumn.HeaderText = "Hôtel";
            this.hotelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hotelDataGridViewTextBoxColumn.Name = "hotelDataGridViewTextBoxColumn";
            this.hotelDataGridViewTextBoxColumn.ReadOnly = true;
            this.hotelDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindSrcInscriptions
            // 
            this.bindSrcInscriptions.DataSource = typeof(GestionOrganisationCongres.Congressiste);
            // 
            // FrmGestionActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1271, 581);
            this.Controls.Add(this.tabControlActivite);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmGestionActivite";
            this.Text = "Gestion Activité";
            this.Load += new System.EventHandler(this.FrmGestionActivite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcNonInscrits)).EndInit();
            this.tabControlActivite.ResumeLayout(false);
            this.listeActivite.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcActivites)).EndInit();
            this.detailsActivite.ResumeLayout(false);
            this.detailsActivite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInscritsActivite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcInscriptions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlActivite;
        private System.Windows.Forms.TabPage listeActivite;
        private System.Windows.Forms.Button btAjouterActivite;
        private System.Windows.Forms.DataGridView dataGridViewActivite;
        private System.Windows.Forms.TabPage detailsActivite;
        private System.Windows.Forms.Button btValiderActivite;
        private System.Windows.Forms.Button btAnnulerModifActivite;
        private System.Windows.Forms.ComboBox comboBoxHeureActivite;
        private System.Windows.Forms.Label lblInscrits;
        private System.Windows.Forms.Button btSupprimerInscritActivite;
        private System.Windows.Forms.Button btAjouterInscritActivite;
        private System.Windows.Forms.Label lblNonInscrits;
        private System.Windows.Forms.TextBox txtBoxDesignationActivite;
        private System.Windows.Forms.DateTimePicker dateTimePickerActiviter;
        private System.Windows.Forms.Label lblPrixActivite;
        private System.Windows.Forms.Label lblNbPlacesMaxActivite;
        private System.Windows.Forms.Label lblHeureDebutActivite;
        private System.Windows.Forms.Label lblDateActivite;
        private System.Windows.Forms.Label lblDesignationActivite;
        private System.Windows.Forms.Button btSupprimerActivite;
        private System.Windows.Forms.DataGridView dataGridViewInscritsActivite;
        private System.Windows.Forms.BindingSource bindSrcActivites;
        private System.Windows.Forms.TextBox txtBoxNbPlacesMax;
        private System.Windows.Forms.TextBox txtBoxPrix;
        private System.Windows.Forms.Label lblEuro;
//<<<<<<< HEAD
//=======
        //private System.Windows.Forms.TextBox txtBoxNbPlacesMax;
        //private System.Windows.Forms.TextBox txtBoxPrix;
        //private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.BindingSource bindSrcInscriptions;
        private System.Windows.Forms.BindingSource bindSrcNonInscrits;
        private System.Windows.Forms.DataGridViewTextBoxColumn idActiviteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDebutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbPlacesMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numInscriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acompteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLigueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblPlacesDispoValeur;
        private System.Windows.Forms.Label lblPlacesDispo;
        //>>>>>>> 2c348f127734a4d8cadb9d8420acdb701185dc4c
    }
}