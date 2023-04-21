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
            this.tabControlActivite = new System.Windows.Forms.TabControl();
            this.listeActivite = new System.Windows.Forms.TabPage();
            this.btAjouterActivite = new System.Windows.Forms.Button();
            this.dataGridViewActiviter = new System.Windows.Forms.DataGridView();
<<<<<<< HEAD
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDebutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbPlacesMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcActivites = new System.Windows.Forms.BindingSource(this.components);
=======
>>>>>>> 2c348f127734a4d8cadb9d8420acdb701185dc4c
            this.detailsActivite = new System.Windows.Forms.TabPage();
            this.lblEuro = new System.Windows.Forms.Label();
            this.txtBoxNbPlacesMax = new System.Windows.Forms.TextBox();
            this.txtBoxPrix = new System.Windows.Forms.TextBox();
            this.btValiderActivite = new System.Windows.Forms.Button();
            this.btAnnulerModifActivite = new System.Windows.Forms.Button();
            this.comboBoxHeureActiviter = new System.Windows.Forms.ComboBox();
            this.lblInscrits = new System.Windows.Forms.Label();
            this.btSupprimerInscritActivite = new System.Windows.Forms.Button();
            this.btAjouterInscritActivite = new System.Windows.Forms.Button();
            this.lblNonInscrits = new System.Windows.Forms.Label();
            this.comboBoxNonInscrits = new System.Windows.Forms.ComboBox();
            this.txtBoxDesignationActiviter = new System.Windows.Forms.TextBox();
            this.dateTimePickerActiviter = new System.Windows.Forms.DateTimePicker();
            this.lblPrixActivite = new System.Windows.Forms.Label();
            this.lblNbPlacesMaxActivite = new System.Windows.Forms.Label();
            this.lblHeureDebutActivite = new System.Windows.Forms.Label();
            this.lblDateActivite = new System.Windows.Forms.Label();
            this.lblDesignationActivite = new System.Windows.Forms.Label();
            this.btSupprimerActivite = new System.Windows.Forms.Button();
            this.dataGridViewInscritsActivite = new System.Windows.Forms.DataGridView();
            this.idActiviteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDebutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbPlacesMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcActivites = new System.Windows.Forms.BindingSource(this.components);
            this.bindSrcInscriptions = new System.Windows.Forms.BindingSource(this.components);
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
            this.tabControlActivite.SuspendLayout();
            this.listeActivite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiviter)).BeginInit();
            this.detailsActivite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInscritsActivite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcActivites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcInscriptions)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlActivite
            // 
            this.tabControlActivite.Controls.Add(this.listeActivite);
            this.tabControlActivite.Controls.Add(this.detailsActivite);
            this.tabControlActivite.Location = new System.Drawing.Point(9, 10);
            this.tabControlActivite.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlActivite.Name = "tabControlActivite";
            this.tabControlActivite.SelectedIndex = 0;
            this.tabControlActivite.Size = new System.Drawing.Size(940, 456);
            this.tabControlActivite.TabIndex = 1;
            // 
            // listeActivite
            // 
            this.listeActivite.Controls.Add(this.btAjouterActivite);
            this.listeActivite.Controls.Add(this.dataGridViewActiviter);
            this.listeActivite.Location = new System.Drawing.Point(4, 22);
            this.listeActivite.Margin = new System.Windows.Forms.Padding(2);
            this.listeActivite.Name = "listeActivite";
            this.listeActivite.Padding = new System.Windows.Forms.Padding(2);
            this.listeActivite.Size = new System.Drawing.Size(932, 430);
            this.listeActivite.TabIndex = 0;
            this.listeActivite.Text = "Liste";
            this.listeActivite.UseVisualStyleBackColor = true;
            // 
            // btAjouterActivite
            // 
            this.btAjouterActivite.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btAjouterActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btAjouterActivite.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btAjouterActivite.Location = new System.Drawing.Point(346, 356);
            this.btAjouterActivite.Margin = new System.Windows.Forms.Padding(2);
            this.btAjouterActivite.Name = "btAjouterActivite";
            this.btAjouterActivite.Size = new System.Drawing.Size(200, 60);
            this.btAjouterActivite.TabIndex = 1;
            this.btAjouterActivite.Text = "Ajouter une activité";
            this.btAjouterActivite.UseVisualStyleBackColor = false;
            // 
            // dataGridViewActiviter
            // 
            this.dataGridViewActiviter.AllowUserToAddRows = false;
            this.dataGridViewActiviter.AllowUserToDeleteRows = false;
            this.dataGridViewActiviter.AutoGenerateColumns = false;
            this.dataGridViewActiviter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewActiviter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActiviter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.designationDataGridViewTextBoxColumn,
            this.prixDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.heureDebutDataGridViewTextBoxColumn,
            this.nbPlacesMaxDataGridViewTextBoxColumn});
            this.dataGridViewActiviter.DataSource = this.bindSrcActivites;
            this.dataGridViewActiviter.Location = new System.Drawing.Point(2, 5);
            this.dataGridViewActiviter.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewActiviter.MultiSelect = false;
            this.dataGridViewActiviter.Name = "dataGridViewActiviter";
            this.dataGridViewActiviter.ReadOnly = true;
            this.dataGridViewActiviter.RowHeadersWidth = 51;
            this.dataGridViewActiviter.RowTemplate.Height = 24;
            this.dataGridViewActiviter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewActiviter.Size = new System.Drawing.Size(927, 338);
            this.dataGridViewActiviter.TabIndex = 0;
            // 
<<<<<<< HEAD
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.designationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            this.designationDataGridViewTextBoxColumn.ReadOnly = true;
            this.designationDataGridViewTextBoxColumn.Width = 88;
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "prix";
            this.prixDataGridViewTextBoxColumn.HeaderText = "Prix";
            this.prixDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            this.prixDataGridViewTextBoxColumn.ReadOnly = true;
            this.prixDataGridViewTextBoxColumn.Width = 49;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 55;
            // 
            // heureDebutDataGridViewTextBoxColumn
            // 
            this.heureDebutDataGridViewTextBoxColumn.DataPropertyName = "heureDebut";
            this.heureDebutDataGridViewTextBoxColumn.HeaderText = "Heure de début";
            this.heureDebutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.heureDebutDataGridViewTextBoxColumn.Name = "heureDebutDataGridViewTextBoxColumn";
            this.heureDebutDataGridViewTextBoxColumn.ReadOnly = true;
            this.heureDebutDataGridViewTextBoxColumn.Width = 97;
            // 
            // nbPlacesMaxDataGridViewTextBoxColumn
            // 
            this.nbPlacesMaxDataGridViewTextBoxColumn.DataPropertyName = "nbPlacesMax";
            this.nbPlacesMaxDataGridViewTextBoxColumn.HeaderText = "Nombre de places maximum";
            this.nbPlacesMaxDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nbPlacesMaxDataGridViewTextBoxColumn.Name = "nbPlacesMaxDataGridViewTextBoxColumn";
            this.nbPlacesMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.nbPlacesMaxDataGridViewTextBoxColumn.Width = 111;
            // 
            // bindSrcActivites
            // 
            this.bindSrcActivites.DataSource = typeof(GestionOrganisationCongres.Activite);
            // 
=======
>>>>>>> 2c348f127734a4d8cadb9d8420acdb701185dc4c
            // detailsActivite
            // 
            this.detailsActivite.Controls.Add(this.lblEuro);
            this.detailsActivite.Controls.Add(this.txtBoxNbPlacesMax);
            this.detailsActivite.Controls.Add(this.txtBoxPrix);
            this.detailsActivite.Controls.Add(this.btValiderActivite);
            this.detailsActivite.Controls.Add(this.btAnnulerModifActivite);
            this.detailsActivite.Controls.Add(this.comboBoxHeureActiviter);
            this.detailsActivite.Controls.Add(this.lblInscrits);
            this.detailsActivite.Controls.Add(this.btSupprimerInscritActivite);
            this.detailsActivite.Controls.Add(this.btAjouterInscritActivite);
            this.detailsActivite.Controls.Add(this.lblNonInscrits);
            this.detailsActivite.Controls.Add(this.comboBoxNonInscrits);
            this.detailsActivite.Controls.Add(this.txtBoxDesignationActiviter);
            this.detailsActivite.Controls.Add(this.dateTimePickerActiviter);
            this.detailsActivite.Controls.Add(this.lblPrixActivite);
            this.detailsActivite.Controls.Add(this.lblNbPlacesMaxActivite);
            this.detailsActivite.Controls.Add(this.lblHeureDebutActivite);
            this.detailsActivite.Controls.Add(this.lblDateActivite);
            this.detailsActivite.Controls.Add(this.lblDesignationActivite);
            this.detailsActivite.Controls.Add(this.btSupprimerActivite);
            this.detailsActivite.Controls.Add(this.dataGridViewInscritsActivite);
            this.detailsActivite.Location = new System.Drawing.Point(4, 22);
            this.detailsActivite.Margin = new System.Windows.Forms.Padding(2);
            this.detailsActivite.Name = "detailsActivite";
            this.detailsActivite.Padding = new System.Windows.Forms.Padding(2);
            this.detailsActivite.Size = new System.Drawing.Size(932, 430);
            this.detailsActivite.TabIndex = 1;
            this.detailsActivite.Text = "Détails";
            this.detailsActivite.UseVisualStyleBackColor = true;
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblEuro.Location = new System.Drawing.Point(145, 276);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(16, 18);
            this.lblEuro.TabIndex = 52;
            this.lblEuro.Text = "€";
            // 
            // txtBoxNbPlacesMax
            // 
            this.txtBoxNbPlacesMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcActivites, "nbPlacesMax", true));
            this.txtBoxNbPlacesMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxNbPlacesMax.Location = new System.Drawing.Point(187, 210);
            this.txtBoxNbPlacesMax.Name = "txtBoxNbPlacesMax";
            this.txtBoxNbPlacesMax.Size = new System.Drawing.Size(100, 23);
            this.txtBoxNbPlacesMax.TabIndex = 50;
            // 
            // txtBoxPrix
            // 
            this.txtBoxPrix.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcActivites, "prix", true));
            this.txtBoxPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxPrix.Location = new System.Drawing.Point(58, 273);
            this.txtBoxPrix.Name = "txtBoxPrix";
            this.txtBoxPrix.Size = new System.Drawing.Size(81, 23);
            this.txtBoxPrix.TabIndex = 49;
            // 
            // btValiderActivite
            // 
            this.btValiderActivite.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btValiderActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btValiderActivite.Location = new System.Drawing.Point(251, 358);
            this.btValiderActivite.Margin = new System.Windows.Forms.Padding(2);
            this.btValiderActivite.Name = "btValiderActivite";
            this.btValiderActivite.Size = new System.Drawing.Size(105, 52);
            this.btValiderActivite.TabIndex = 48;
            this.btValiderActivite.Text = "Valider";
            this.btValiderActivite.UseVisualStyleBackColor = false;
            // 
            // btAnnulerModifActivite
            // 
            this.btAnnulerModifActivite.BackColor = System.Drawing.Color.LightPink;
            this.btAnnulerModifActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btAnnulerModifActivite.Location = new System.Drawing.Point(23, 367);
            this.btAnnulerModifActivite.Margin = new System.Windows.Forms.Padding(2);
            this.btAnnulerModifActivite.Name = "btAnnulerModifActivite";
            this.btAnnulerModifActivite.Size = new System.Drawing.Size(116, 44);
            this.btAnnulerModifActivite.TabIndex = 47;
            this.btAnnulerModifActivite.Text = "Annuler";
            this.btAnnulerModifActivite.UseVisualStyleBackColor = false;
            // 
            // comboBoxHeureActiviter
            // 
            this.comboBoxHeureActiviter.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcActivites, "heureDebut", true));
            this.comboBoxHeureActiviter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxHeureActiviter.FormattingEnabled = true;
            this.comboBoxHeureActiviter.Location = new System.Drawing.Point(132, 84);
            this.comboBoxHeureActiviter.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxHeureActiviter.Name = "comboBoxHeureActiviter";
            this.comboBoxHeureActiviter.Size = new System.Drawing.Size(92, 24);
            this.comboBoxHeureActiviter.TabIndex = 3;
            // 
            // lblInscrits
            // 
            this.lblInscrits.AutoSize = true;
            this.lblInscrits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscrits.Location = new System.Drawing.Point(435, 7);
            this.lblInscrits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInscrits.Name = "lblInscrits";
            this.lblInscrits.Size = new System.Drawing.Size(64, 17);
            this.lblInscrits.TabIndex = 18;
            this.lblInscrits.Text = "Inscrits : ";
            // 
            // btSupprimerInscritActivite
            // 
            this.btSupprimerInscritActivite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btSupprimerInscritActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupprimerInscritActivite.Location = new System.Drawing.Point(577, 367);
            this.btSupprimerInscritActivite.Margin = new System.Windows.Forms.Padding(2);
            this.btSupprimerInscritActivite.Name = "btSupprimerInscritActivite";
            this.btSupprimerInscritActivite.Size = new System.Drawing.Size(222, 47);
            this.btSupprimerInscritActivite.TabIndex = 11;
            this.btSupprimerInscritActivite.Text = "Supprimer un inscrit";
            this.btSupprimerInscritActivite.UseVisualStyleBackColor = false;
            // 
            // btAjouterInscritActivite
            // 
            this.btAjouterInscritActivite.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btAjouterInscritActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjouterInscritActivite.Location = new System.Drawing.Point(840, 323);
            this.btAjouterInscritActivite.Margin = new System.Windows.Forms.Padding(2);
            this.btAjouterInscritActivite.Name = "btAjouterInscritActivite";
            this.btAjouterInscritActivite.Size = new System.Drawing.Size(88, 32);
            this.btAjouterInscritActivite.TabIndex = 10;
            this.btAjouterInscritActivite.Text = "Ajouter";
<<<<<<< HEAD
            this.btAjouterInscritActivite.UseVisualStyleBackColor = false;
=======
            this.btAjouterInscritActivite.UseVisualStyleBackColor = true;
>>>>>>> 2c348f127734a4d8cadb9d8420acdb701185dc4c
            // 
            // lblNonInscrits
            // 
            this.lblNonInscrits.AutoSize = true;
            this.lblNonInscrits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNonInscrits.Location = new System.Drawing.Point(422, 333);
            this.lblNonInscrits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNonInscrits.Name = "lblNonInscrits";
            this.lblNonInscrits.Size = new System.Drawing.Size(94, 17);
            this.lblNonInscrits.TabIndex = 15;
            this.lblNonInscrits.Text = "Non inscrits : ";
            // 
            // comboBoxNonInscrits
            // 
            this.comboBoxNonInscrits.FormattingEnabled = true;
            this.comboBoxNonInscrits.Location = new System.Drawing.Point(520, 332);
            this.comboBoxNonInscrits.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxNonInscrits.Name = "comboBoxNonInscrits";
            this.comboBoxNonInscrits.Size = new System.Drawing.Size(300, 21);
            this.comboBoxNonInscrits.TabIndex = 9;
            // 
            // txtBoxDesignationActiviter
            // 
            this.txtBoxDesignationActiviter.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcActivites, "designation", true));
            this.txtBoxDesignationActiviter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxDesignationActiviter.Location = new System.Drawing.Point(109, 23);
            this.txtBoxDesignationActiviter.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxDesignationActiviter.Name = "txtBoxDesignationActiviter";
            this.txtBoxDesignationActiviter.Size = new System.Drawing.Size(302, 23);
            this.txtBoxDesignationActiviter.TabIndex = 2;
            // 
            // dateTimePickerActiviter
            // 
            this.dateTimePickerActiviter.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindSrcActivites, "date", true));
            this.dateTimePickerActiviter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerActiviter.Location = new System.Drawing.Point(63, 150);
            this.dateTimePickerActiviter.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerActiviter.Name = "dateTimePickerActiviter";
            this.dateTimePickerActiviter.Size = new System.Drawing.Size(151, 23);
            this.dateTimePickerActiviter.TabIndex = 4;
            // 
            // lblPrixActivite
            // 
            this.lblPrixActivite.AutoSize = true;
            this.lblPrixActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPrixActivite.Location = new System.Drawing.Point(9, 276);
            this.lblPrixActivite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrixActivite.Name = "lblPrixActivite";
            this.lblPrixActivite.Size = new System.Drawing.Size(45, 18);
            this.lblPrixActivite.TabIndex = 7;
            this.lblPrixActivite.Text = "Prix : ";
            // 
            // lblNbPlacesMaxActivite
            // 
            this.lblNbPlacesMaxActivite.AutoSize = true;
            this.lblNbPlacesMaxActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNbPlacesMaxActivite.Location = new System.Drawing.Point(9, 215);
            this.lblNbPlacesMaxActivite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNbPlacesMaxActivite.Name = "lblNbPlacesMaxActivite";
            this.lblNbPlacesMaxActivite.Size = new System.Drawing.Size(173, 18);
            this.lblNbPlacesMaxActivite.TabIndex = 6;
            this.lblNbPlacesMaxActivite.Text = "Nombre de places max : ";
            // 
            // lblHeureDebutActivite
            // 
            this.lblHeureDebutActivite.AutoSize = true;
            this.lblHeureDebutActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblHeureDebutActivite.Location = new System.Drawing.Point(9, 91);
            this.lblHeureDebutActivite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeureDebutActivite.Name = "lblHeureDebutActivite";
            this.lblHeureDebutActivite.Size = new System.Drawing.Size(120, 18);
            this.lblHeureDebutActivite.TabIndex = 5;
            this.lblHeureDebutActivite.Text = "Heure de début : ";
            // 
            // lblDateActivite
            // 
            this.lblDateActivite.AutoSize = true;
            this.lblDateActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblDateActivite.Location = new System.Drawing.Point(9, 155);
            this.lblDateActivite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateActivite.Name = "lblDateActivite";
            this.lblDateActivite.Size = new System.Drawing.Size(51, 18);
            this.lblDateActivite.TabIndex = 4;
            this.lblDateActivite.Text = "Date : ";
            // 
            // lblDesignationActivite
            // 
            this.lblDesignationActivite.AutoSize = true;
            this.lblDesignationActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblDesignationActivite.Location = new System.Drawing.Point(10, 26);
            this.lblDesignationActivite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesignationActivite.Name = "lblDesignationActivite";
            this.lblDesignationActivite.Size = new System.Drawing.Size(98, 18);
            this.lblDesignationActivite.TabIndex = 3;
            this.lblDesignationActivite.Text = "Désignation : ";
            // 
            // btSupprimerActivite
            // 
            this.btSupprimerActivite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btSupprimerActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btSupprimerActivite.Location = new System.Drawing.Point(209, 354);
            this.btSupprimerActivite.Margin = new System.Windows.Forms.Padding(2);
            this.btSupprimerActivite.Name = "btSupprimerActivite";
            this.btSupprimerActivite.Size = new System.Drawing.Size(192, 60);
            this.btSupprimerActivite.TabIndex = 12;
            this.btSupprimerActivite.Text = "Supprimer l\'activité";
            this.btSupprimerActivite.UseVisualStyleBackColor = false;
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
            this.dataGridViewInscritsActivite.Location = new System.Drawing.Point(438, 26);
            this.dataGridViewInscritsActivite.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewInscritsActivite.Name = "dataGridViewInscritsActivite";
            this.dataGridViewInscritsActivite.ReadOnly = true;
            this.dataGridViewInscritsActivite.RowHeadersWidth = 51;
            this.dataGridViewInscritsActivite.RowTemplate.Height = 24;
            this.dataGridViewInscritsActivite.Size = new System.Drawing.Size(481, 293);
            this.dataGridViewInscritsActivite.TabIndex = 1;
            // 
            // idActiviteDataGridViewTextBoxColumn
            // 
            this.idActiviteDataGridViewTextBoxColumn.DataPropertyName = "idActivite";
            this.idActiviteDataGridViewTextBoxColumn.HeaderText = "idActivite";
            this.idActiviteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idActiviteDataGridViewTextBoxColumn.Name = "idActiviteDataGridViewTextBoxColumn";
            this.idActiviteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idActiviteDataGridViewTextBoxColumn.Width = 125;
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "designation";
            this.designationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            this.designationDataGridViewTextBoxColumn.ReadOnly = true;
            this.designationDataGridViewTextBoxColumn.Width = 125;
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "prix";
            this.prixDataGridViewTextBoxColumn.HeaderText = "prix";
            this.prixDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            this.prixDataGridViewTextBoxColumn.ReadOnly = true;
            this.prixDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // heureDebutDataGridViewTextBoxColumn
            // 
            this.heureDebutDataGridViewTextBoxColumn.DataPropertyName = "heureDebut";
            this.heureDebutDataGridViewTextBoxColumn.HeaderText = "heureDebut";
            this.heureDebutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.heureDebutDataGridViewTextBoxColumn.Name = "heureDebutDataGridViewTextBoxColumn";
            this.heureDebutDataGridViewTextBoxColumn.ReadOnly = true;
            this.heureDebutDataGridViewTextBoxColumn.Width = 125;
            // 
            // nbPlacesMaxDataGridViewTextBoxColumn
            // 
            this.nbPlacesMaxDataGridViewTextBoxColumn.DataPropertyName = "nbPlacesMax";
            this.nbPlacesMaxDataGridViewTextBoxColumn.HeaderText = "nbPlacesMax";
            this.nbPlacesMaxDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nbPlacesMaxDataGridViewTextBoxColumn.Name = "nbPlacesMaxDataGridViewTextBoxColumn";
            this.nbPlacesMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.nbPlacesMaxDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindSrcActivites
            // 
            this.bindSrcActivites.DataSource = typeof(GestionOrganisationCongres.Activite);
            this.bindSrcActivites.CurrentChanged += new System.EventHandler(this.bindSrcActivites_CurrentChanged);
            // 
            // bindSrcInscriptions
            // 
            this.bindSrcInscriptions.DataSource = typeof(GestionOrganisationCongres.Congressiste);
            // 
            // numInscriptionDataGridViewTextBoxColumn
            // 
            this.numInscriptionDataGridViewTextBoxColumn.DataPropertyName = "numInscription";
            this.numInscriptionDataGridViewTextBoxColumn.HeaderText = "numInscription";
            this.numInscriptionDataGridViewTextBoxColumn.Name = "numInscriptionDataGridViewTextBoxColumn";
            this.numInscriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpDataGridViewTextBoxColumn
            // 
            this.cpDataGridViewTextBoxColumn.DataPropertyName = "cp";
            this.cpDataGridViewTextBoxColumn.HeaderText = "cp";
            this.cpDataGridViewTextBoxColumn.Name = "cpDataGridViewTextBoxColumn";
            this.cpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "ville";
            this.villeDataGridViewTextBoxColumn.HeaderText = "ville";
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            this.villeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "tel";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // acompteDataGridViewTextBoxColumn
            // 
            this.acompteDataGridViewTextBoxColumn.DataPropertyName = "acompte";
            this.acompteDataGridViewTextBoxColumn.HeaderText = "acompte";
            this.acompteDataGridViewTextBoxColumn.Name = "acompteDataGridViewTextBoxColumn";
            this.acompteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idLigueDataGridViewTextBoxColumn
            // 
            this.idLigueDataGridViewTextBoxColumn.DataPropertyName = "idLigue";
            this.idLigueDataGridViewTextBoxColumn.HeaderText = "idLigue";
            this.idLigueDataGridViewTextBoxColumn.Name = "idLigueDataGridViewTextBoxColumn";
            this.idLigueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hotelDataGridViewTextBoxColumn
            // 
            this.hotelDataGridViewTextBoxColumn.DataPropertyName = "Hotel";
            this.hotelDataGridViewTextBoxColumn.HeaderText = "Hotel";
            this.hotelDataGridViewTextBoxColumn.Name = "hotelDataGridViewTextBoxColumn";
            this.hotelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmGestionActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 472);
            this.Controls.Add(this.tabControlActivite);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmGestionActivite";
            this.Text = "Gestion Activité";
            this.Load += new System.EventHandler(this.FrmGestionActivite_Load);
            this.tabControlActivite.ResumeLayout(false);
            this.listeActivite.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiviter)).EndInit();
            this.detailsActivite.ResumeLayout(false);
            this.detailsActivite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInscritsActivite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcActivites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcInscriptions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlActivite;
        private System.Windows.Forms.TabPage listeActivite;
        private System.Windows.Forms.Button btAjouterActivite;
        private System.Windows.Forms.DataGridView dataGridViewActiviter;
        private System.Windows.Forms.TabPage detailsActivite;
        private System.Windows.Forms.Button btValiderActivite;
        private System.Windows.Forms.Button btAnnulerModifActivite;
        private System.Windows.Forms.ComboBox comboBoxHeureActiviter;
        private System.Windows.Forms.Label lblInscrits;
        private System.Windows.Forms.Button btSupprimerInscritActivite;
        private System.Windows.Forms.Button btAjouterInscritActivite;
        private System.Windows.Forms.Label lblNonInscrits;
        private System.Windows.Forms.ComboBox comboBoxNonInscrits;
        private System.Windows.Forms.TextBox txtBoxDesignationActiviter;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDebutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbPlacesMaxDataGridViewTextBoxColumn;
<<<<<<< HEAD
=======
        private System.Windows.Forms.TextBox txtBoxNbPlacesMax;
        private System.Windows.Forms.TextBox txtBoxPrix;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.BindingSource bindSrcInscriptions;
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
>>>>>>> 2c348f127734a4d8cadb9d8420acdb701185dc4c
    }
}