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
            this.idActiviteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDebutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbPlacesMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.congressistesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcActivites = new System.Windows.Forms.BindingSource(this.components);
            this.detailsActivite = new System.Windows.Forms.TabPage();
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
            this.maskedTxtBoxNbPlacesMaxActiviter = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtBoxPrixActiviter = new System.Windows.Forms.MaskedTextBox();
            this.lblPrixActivite = new System.Windows.Forms.Label();
            this.lblNbPlacesMaxActivite = new System.Windows.Forms.Label();
            this.lblHeureDebutActivite = new System.Windows.Forms.Label();
            this.lblDateActivite = new System.Windows.Forms.Label();
            this.lblDesignationActivite = new System.Windows.Forms.Label();
            this.btSupprimerActivite = new System.Windows.Forms.Button();
            this.dataGridViewInscritsActivite = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControlActivite.SuspendLayout();
            this.listeActivite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiviter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcActivites)).BeginInit();
            this.detailsActivite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInscritsActivite)).BeginInit();
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
            this.tabControlActivite.Size = new System.Drawing.Size(582, 371);
            this.tabControlActivite.TabIndex = 1;
            // 
            // listeActivite
            // 
            this.listeActivite.Controls.Add(this.button1);
            this.listeActivite.Controls.Add(this.btAjouterActivite);
            this.listeActivite.Controls.Add(this.dataGridViewActiviter);
            this.listeActivite.Location = new System.Drawing.Point(4, 22);
            this.listeActivite.Margin = new System.Windows.Forms.Padding(2);
            this.listeActivite.Name = "listeActivite";
            this.listeActivite.Padding = new System.Windows.Forms.Padding(2);
            this.listeActivite.Size = new System.Drawing.Size(574, 345);
            this.listeActivite.TabIndex = 0;
            this.listeActivite.Text = "Liste";
            this.listeActivite.UseVisualStyleBackColor = true;
            // 
            // btAjouterActivite
            // 
            this.btAjouterActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btAjouterActivite.Location = new System.Drawing.Point(196, 293);
            this.btAjouterActivite.Margin = new System.Windows.Forms.Padding(2);
            this.btAjouterActivite.Name = "btAjouterActivite";
            this.btAjouterActivite.Size = new System.Drawing.Size(155, 36);
            this.btAjouterActivite.TabIndex = 1;
            this.btAjouterActivite.Text = "Ajouter une activité";
            this.btAjouterActivite.UseVisualStyleBackColor = true;
            // 
            // dataGridViewActiviter
            // 
            this.dataGridViewActiviter.AllowUserToAddRows = false;
            this.dataGridViewActiviter.AllowUserToDeleteRows = false;
            this.dataGridViewActiviter.AutoGenerateColumns = false;
            this.dataGridViewActiviter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActiviter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idActiviteDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn,
            this.prixDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.heureDebutDataGridViewTextBoxColumn,
            this.nbPlacesMaxDataGridViewTextBoxColumn,
            this.congressistesDataGridViewTextBoxColumn});
            this.dataGridViewActiviter.DataSource = this.bindSrcActivites;
            this.dataGridViewActiviter.Location = new System.Drawing.Point(2, 5);
            this.dataGridViewActiviter.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewActiviter.Name = "dataGridViewActiviter";
            this.dataGridViewActiviter.ReadOnly = true;
            this.dataGridViewActiviter.RowHeadersWidth = 51;
            this.dataGridViewActiviter.RowTemplate.Height = 24;
            this.dataGridViewActiviter.Size = new System.Drawing.Size(569, 272);
            this.dataGridViewActiviter.TabIndex = 0;
            // 
            // idActiviteDataGridViewTextBoxColumn
            // 
            this.idActiviteDataGridViewTextBoxColumn.DataPropertyName = "idActivite";
            this.idActiviteDataGridViewTextBoxColumn.HeaderText = "idActivite";
            this.idActiviteDataGridViewTextBoxColumn.Name = "idActiviteDataGridViewTextBoxColumn";
            this.idActiviteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "designation";
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            this.designationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "prix";
            this.prixDataGridViewTextBoxColumn.HeaderText = "prix";
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            this.prixDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // heureDebutDataGridViewTextBoxColumn
            // 
            this.heureDebutDataGridViewTextBoxColumn.DataPropertyName = "heureDebut";
            this.heureDebutDataGridViewTextBoxColumn.HeaderText = "heureDebut";
            this.heureDebutDataGridViewTextBoxColumn.Name = "heureDebutDataGridViewTextBoxColumn";
            this.heureDebutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nbPlacesMaxDataGridViewTextBoxColumn
            // 
            this.nbPlacesMaxDataGridViewTextBoxColumn.DataPropertyName = "nbPlacesMax";
            this.nbPlacesMaxDataGridViewTextBoxColumn.HeaderText = "nbPlacesMax";
            this.nbPlacesMaxDataGridViewTextBoxColumn.Name = "nbPlacesMaxDataGridViewTextBoxColumn";
            this.nbPlacesMaxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // congressistesDataGridViewTextBoxColumn
            // 
            this.congressistesDataGridViewTextBoxColumn.DataPropertyName = "Congressistes";
            this.congressistesDataGridViewTextBoxColumn.HeaderText = "Congressistes";
            this.congressistesDataGridViewTextBoxColumn.Name = "congressistesDataGridViewTextBoxColumn";
            this.congressistesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindSrcActivites
            // 
            this.bindSrcActivites.DataSource = typeof(GestionOrganisationCongres.Activite);
            // 
            // detailsActivite
            // 
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
            this.detailsActivite.Controls.Add(this.maskedTxtBoxNbPlacesMaxActiviter);
            this.detailsActivite.Controls.Add(this.maskedTxtBoxPrixActiviter);
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
            this.detailsActivite.Size = new System.Drawing.Size(574, 345);
            this.detailsActivite.TabIndex = 1;
            this.detailsActivite.Text = "Détails";
            this.detailsActivite.UseVisualStyleBackColor = true;
            // 
            // btValiderActivite
            // 
            this.btValiderActivite.BackColor = System.Drawing.Color.LawnGreen;
            this.btValiderActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btValiderActivite.Location = new System.Drawing.Point(58, 285);
            this.btValiderActivite.Margin = new System.Windows.Forms.Padding(2);
            this.btValiderActivite.Name = "btValiderActivite";
            this.btValiderActivite.Size = new System.Drawing.Size(70, 24);
            this.btValiderActivite.TabIndex = 48;
            this.btValiderActivite.Text = "Valider";
            this.btValiderActivite.UseVisualStyleBackColor = false;
            // 
            // btAnnulerModifActivite
            // 
            this.btAnnulerModifActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btAnnulerModifActivite.Location = new System.Drawing.Point(180, 285);
            this.btAnnulerModifActivite.Margin = new System.Windows.Forms.Padding(2);
            this.btAnnulerModifActivite.Name = "btAnnulerModifActivite";
            this.btAnnulerModifActivite.Size = new System.Drawing.Size(69, 24);
            this.btAnnulerModifActivite.TabIndex = 47;
            this.btAnnulerModifActivite.Text = "Annuler";
            this.btAnnulerModifActivite.UseVisualStyleBackColor = true;
            // 
            // comboBoxHeureActiviter
            // 
            this.comboBoxHeureActiviter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxHeureActiviter.FormattingEnabled = true;
            this.comboBoxHeureActiviter.Location = new System.Drawing.Point(128, 44);
            this.comboBoxHeureActiviter.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxHeureActiviter.Name = "comboBoxHeureActiviter";
            this.comboBoxHeureActiviter.Size = new System.Drawing.Size(92, 24);
            this.comboBoxHeureActiviter.TabIndex = 3;
            // 
            // lblInscrits
            // 
            this.lblInscrits.AutoSize = true;
            this.lblInscrits.Location = new System.Drawing.Point(296, 11);
            this.lblInscrits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInscrits.Name = "lblInscrits";
            this.lblInscrits.Size = new System.Drawing.Size(49, 13);
            this.lblInscrits.TabIndex = 18;
            this.lblInscrits.Text = "Inscrits : ";
            // 
            // btSupprimerInscritActivite
            // 
            this.btSupprimerInscritActivite.Location = new System.Drawing.Point(393, 293);
            this.btSupprimerInscritActivite.Margin = new System.Windows.Forms.Padding(2);
            this.btSupprimerInscritActivite.Name = "btSupprimerInscritActivite";
            this.btSupprimerInscritActivite.Size = new System.Drawing.Size(111, 28);
            this.btSupprimerInscritActivite.TabIndex = 11;
            this.btSupprimerInscritActivite.Text = "Supprimer un inscrit";
            this.btSupprimerInscritActivite.UseVisualStyleBackColor = true;
            // 
            // btAjouterInscritActivite
            // 
            this.btAjouterInscritActivite.Location = new System.Drawing.Point(507, 266);
            this.btAjouterInscritActivite.Margin = new System.Windows.Forms.Padding(2);
            this.btAjouterInscritActivite.Name = "btAjouterInscritActivite";
            this.btAjouterInscritActivite.Size = new System.Drawing.Size(64, 32);
            this.btAjouterInscritActivite.TabIndex = 10;
            this.btAjouterInscritActivite.Text = "Ajouter";
            this.btAjouterInscritActivite.UseVisualStyleBackColor = true;
            // 
            // lblNonInscrits
            // 
            this.lblNonInscrits.AutoSize = true;
            this.lblNonInscrits.Location = new System.Drawing.Point(269, 269);
            this.lblNonInscrits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNonInscrits.Name = "lblNonInscrits";
            this.lblNonInscrits.Size = new System.Drawing.Size(71, 13);
            this.lblNonInscrits.TabIndex = 15;
            this.lblNonInscrits.Text = "Non inscrits : ";
            // 
            // comboBoxNonInscrits
            // 
            this.comboBoxNonInscrits.FormattingEnabled = true;
            this.comboBoxNonInscrits.Location = new System.Drawing.Point(344, 266);
            this.comboBoxNonInscrits.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxNonInscrits.Name = "comboBoxNonInscrits";
            this.comboBoxNonInscrits.Size = new System.Drawing.Size(160, 21);
            this.comboBoxNonInscrits.TabIndex = 9;
            // 
            // txtBoxDesignationActiviter
            // 
            this.txtBoxDesignationActiviter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxDesignationActiviter.Location = new System.Drawing.Point(109, 11);
            this.txtBoxDesignationActiviter.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxDesignationActiviter.Name = "txtBoxDesignationActiviter";
            this.txtBoxDesignationActiviter.Size = new System.Drawing.Size(170, 23);
            this.txtBoxDesignationActiviter.TabIndex = 2;
            // 
            // dateTimePickerActiviter
            // 
            this.dateTimePickerActiviter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerActiviter.Location = new System.Drawing.Point(69, 80);
            this.dateTimePickerActiviter.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerActiviter.Name = "dateTimePickerActiviter";
            this.dateTimePickerActiviter.Size = new System.Drawing.Size(151, 23);
            this.dateTimePickerActiviter.TabIndex = 4;
            // 
            // maskedTxtBoxNbPlacesMaxActiviter
            // 
            this.maskedTxtBoxNbPlacesMaxActiviter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTxtBoxNbPlacesMaxActiviter.Location = new System.Drawing.Point(171, 123);
            this.maskedTxtBoxNbPlacesMaxActiviter.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTxtBoxNbPlacesMaxActiviter.Mask = "999999";
            this.maskedTxtBoxNbPlacesMaxActiviter.Name = "maskedTxtBoxNbPlacesMaxActiviter";
            this.maskedTxtBoxNbPlacesMaxActiviter.Size = new System.Drawing.Size(108, 23);
            this.maskedTxtBoxNbPlacesMaxActiviter.TabIndex = 5;
            // 
            // maskedTxtBoxPrixActiviter
            // 
            this.maskedTxtBoxPrixActiviter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTxtBoxPrixActiviter.Location = new System.Drawing.Point(64, 154);
            this.maskedTxtBoxPrixActiviter.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTxtBoxPrixActiviter.Mask = "999999";
            this.maskedTxtBoxPrixActiviter.Name = "maskedTxtBoxPrixActiviter";
            this.maskedTxtBoxPrixActiviter.Size = new System.Drawing.Size(76, 23);
            this.maskedTxtBoxPrixActiviter.TabIndex = 8;
            // 
            // lblPrixActivite
            // 
            this.lblPrixActivite.AutoSize = true;
            this.lblPrixActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPrixActivite.Location = new System.Drawing.Point(20, 156);
            this.lblPrixActivite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrixActivite.Name = "lblPrixActivite";
            this.lblPrixActivite.Size = new System.Drawing.Size(43, 17);
            this.lblPrixActivite.TabIndex = 7;
            this.lblPrixActivite.Text = "Prix : ";
            // 
            // lblNbPlacesMaxActivite
            // 
            this.lblNbPlacesMaxActivite.AutoSize = true;
            this.lblNbPlacesMaxActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNbPlacesMaxActivite.Location = new System.Drawing.Point(9, 126);
            this.lblNbPlacesMaxActivite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNbPlacesMaxActivite.Name = "lblNbPlacesMaxActivite";
            this.lblNbPlacesMaxActivite.Size = new System.Drawing.Size(164, 17);
            this.lblNbPlacesMaxActivite.TabIndex = 6;
            this.lblNbPlacesMaxActivite.Text = "Nombre de places max : ";
            // 
            // lblHeureDebutActivite
            // 
            this.lblHeureDebutActivite.AutoSize = true;
            this.lblHeureDebutActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHeureDebutActivite.Location = new System.Drawing.Point(9, 47);
            this.lblHeureDebutActivite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeureDebutActivite.Name = "lblHeureDebutActivite";
            this.lblHeureDebutActivite.Size = new System.Drawing.Size(119, 17);
            this.lblHeureDebutActivite.TabIndex = 5;
            this.lblHeureDebutActivite.Text = "Heure de début : ";
            // 
            // lblDateActivite
            // 
            this.lblDateActivite.AutoSize = true;
            this.lblDateActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDateActivite.Location = new System.Drawing.Point(20, 84);
            this.lblDateActivite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateActivite.Name = "lblDateActivite";
            this.lblDateActivite.Size = new System.Drawing.Size(50, 17);
            this.lblDateActivite.TabIndex = 4;
            this.lblDateActivite.Text = "Date : ";
            // 
            // lblDesignationActivite
            // 
            this.lblDesignationActivite.AutoSize = true;
            this.lblDesignationActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDesignationActivite.Location = new System.Drawing.Point(20, 13);
            this.lblDesignationActivite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesignationActivite.Name = "lblDesignationActivite";
            this.lblDesignationActivite.Size = new System.Drawing.Size(95, 17);
            this.lblDesignationActivite.TabIndex = 3;
            this.lblDesignationActivite.Text = "Désignation : ";
            // 
            // btSupprimerActivite
            // 
            this.btSupprimerActivite.BackColor = System.Drawing.Color.Red;
            this.btSupprimerActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btSupprimerActivite.Location = new System.Drawing.Point(12, 285);
            this.btSupprimerActivite.Margin = new System.Windows.Forms.Padding(2);
            this.btSupprimerActivite.Name = "btSupprimerActivite";
            this.btSupprimerActivite.Size = new System.Drawing.Size(161, 24);
            this.btSupprimerActivite.TabIndex = 12;
            this.btSupprimerActivite.Text = "Supprimer l\'activité";
            this.btSupprimerActivite.UseVisualStyleBackColor = false;
            // 
            // dataGridViewInscritsActivite
            // 
            this.dataGridViewInscritsActivite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInscritsActivite.Location = new System.Drawing.Point(298, 27);
            this.dataGridViewInscritsActivite.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewInscritsActivite.Name = "dataGridViewInscritsActivite";
            this.dataGridViewInscritsActivite.RowHeadersWidth = 51;
            this.dataGridViewInscritsActivite.RowTemplate.Height = 24;
            this.dataGridViewInscritsActivite.Size = new System.Drawing.Size(273, 221);
            this.dataGridViewInscritsActivite.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(441, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmGestionActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 392);
            this.Controls.Add(this.tabControlActivite);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmGestionActivite";
            this.Text = "Gestion Activité";
            this.Load += new System.EventHandler(this.FrmGestionActivite_Load);
            this.tabControlActivite.ResumeLayout(false);
            this.listeActivite.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiviter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcActivites)).EndInit();
            this.detailsActivite.ResumeLayout(false);
            this.detailsActivite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInscritsActivite)).EndInit();
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
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxNbPlacesMaxActiviter;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxPrixActiviter;
        private System.Windows.Forms.Label lblPrixActivite;
        private System.Windows.Forms.Label lblNbPlacesMaxActivite;
        private System.Windows.Forms.Label lblHeureDebutActivite;
        private System.Windows.Forms.Label lblDateActivite;
        private System.Windows.Forms.Label lblDesignationActivite;
        private System.Windows.Forms.Button btSupprimerActivite;
        private System.Windows.Forms.DataGridView dataGridViewInscritsActivite;
        private System.Windows.Forms.BindingSource bindSrcActivites;
        private System.Windows.Forms.DataGridViewTextBoxColumn idActiviteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDebutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbPlacesMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn congressistesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}