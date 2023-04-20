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
            this.button1 = new System.Windows.Forms.Button();
            this.btAjouterActivite = new System.Windows.Forms.Button();
            this.dataGridViewActiviter = new System.Windows.Forms.DataGridView();
            this.idActiviteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDebutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbPlacesMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabControlActivite.Location = new System.Drawing.Point(12, 12);
            this.tabControlActivite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlActivite.Name = "tabControlActivite";
            this.tabControlActivite.SelectedIndex = 0;
            this.tabControlActivite.Size = new System.Drawing.Size(776, 457);
            this.tabControlActivite.TabIndex = 1;
            // 
            // listeActivite
            // 
            this.listeActivite.Controls.Add(this.button1);
            this.listeActivite.Controls.Add(this.btAjouterActivite);
            this.listeActivite.Controls.Add(this.dataGridViewActiviter);
            this.listeActivite.Location = new System.Drawing.Point(4, 25);
            this.listeActivite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listeActivite.Name = "listeActivite";
            this.listeActivite.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listeActivite.Size = new System.Drawing.Size(768, 428);
            this.listeActivite.TabIndex = 0;
            this.listeActivite.Text = "Liste";
            this.listeActivite.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(588, 363);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "test 2";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btAjouterActivite
            // 
            this.btAjouterActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btAjouterActivite.Location = new System.Drawing.Point(261, 361);
            this.btAjouterActivite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAjouterActivite.Name = "btAjouterActivite";
            this.btAjouterActivite.Size = new System.Drawing.Size(207, 44);
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
            this.nbPlacesMaxDataGridViewTextBoxColumn});
            this.dataGridViewActiviter.DataSource = this.bindSrcActivites;
            this.dataGridViewActiviter.Location = new System.Drawing.Point(3, 6);
            this.dataGridViewActiviter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewActiviter.Name = "dataGridViewActiviter";
            this.dataGridViewActiviter.ReadOnly = true;
            this.dataGridViewActiviter.RowHeadersWidth = 51;
            this.dataGridViewActiviter.RowTemplate.Height = 24;
            this.dataGridViewActiviter.Size = new System.Drawing.Size(759, 335);
            this.dataGridViewActiviter.TabIndex = 0;
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
            this.detailsActivite.Location = new System.Drawing.Point(4, 25);
            this.detailsActivite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.detailsActivite.Name = "detailsActivite";
            this.detailsActivite.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.detailsActivite.Size = new System.Drawing.Size(768, 428);
            this.detailsActivite.TabIndex = 1;
            this.detailsActivite.Text = "Détails";
            this.detailsActivite.UseVisualStyleBackColor = true;
            // 
            // btValiderActivite
            // 
            this.btValiderActivite.BackColor = System.Drawing.Color.LawnGreen;
            this.btValiderActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btValiderActivite.Location = new System.Drawing.Point(77, 351);
            this.btValiderActivite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btValiderActivite.Name = "btValiderActivite";
            this.btValiderActivite.Size = new System.Drawing.Size(93, 30);
            this.btValiderActivite.TabIndex = 48;
            this.btValiderActivite.Text = "Valider";
            this.btValiderActivite.UseVisualStyleBackColor = false;
            // 
            // btAnnulerModifActivite
            // 
            this.btAnnulerModifActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btAnnulerModifActivite.Location = new System.Drawing.Point(240, 351);
            this.btAnnulerModifActivite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAnnulerModifActivite.Name = "btAnnulerModifActivite";
            this.btAnnulerModifActivite.Size = new System.Drawing.Size(92, 30);
            this.btAnnulerModifActivite.TabIndex = 47;
            this.btAnnulerModifActivite.Text = "Annuler";
            this.btAnnulerModifActivite.UseVisualStyleBackColor = true;
            // 
            // comboBoxHeureActiviter
            // 
            this.comboBoxHeureActiviter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxHeureActiviter.FormattingEnabled = true;
            this.comboBoxHeureActiviter.Location = new System.Drawing.Point(171, 54);
            this.comboBoxHeureActiviter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxHeureActiviter.Name = "comboBoxHeureActiviter";
            this.comboBoxHeureActiviter.Size = new System.Drawing.Size(121, 28);
            this.comboBoxHeureActiviter.TabIndex = 3;
            // 
            // lblInscrits
            // 
            this.lblInscrits.AutoSize = true;
            this.lblInscrits.Location = new System.Drawing.Point(395, 14);
            this.lblInscrits.Name = "lblInscrits";
            this.lblInscrits.Size = new System.Drawing.Size(57, 16);
            this.lblInscrits.TabIndex = 18;
            this.lblInscrits.Text = "Inscrits : ";
            // 
            // btSupprimerInscritActivite
            // 
            this.btSupprimerInscritActivite.Location = new System.Drawing.Point(524, 361);
            this.btSupprimerInscritActivite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSupprimerInscritActivite.Name = "btSupprimerInscritActivite";
            this.btSupprimerInscritActivite.Size = new System.Drawing.Size(148, 34);
            this.btSupprimerInscritActivite.TabIndex = 11;
            this.btSupprimerInscritActivite.Text = "Supprimer un inscrit";
            this.btSupprimerInscritActivite.UseVisualStyleBackColor = true;
            // 
            // btAjouterInscritActivite
            // 
            this.btAjouterInscritActivite.Location = new System.Drawing.Point(676, 327);
            this.btAjouterInscritActivite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAjouterInscritActivite.Name = "btAjouterInscritActivite";
            this.btAjouterInscritActivite.Size = new System.Drawing.Size(85, 39);
            this.btAjouterInscritActivite.TabIndex = 10;
            this.btAjouterInscritActivite.Text = "Ajouter";
            this.btAjouterInscritActivite.UseVisualStyleBackColor = true;
            // 
            // lblNonInscrits
            // 
            this.lblNonInscrits.AutoSize = true;
            this.lblNonInscrits.Location = new System.Drawing.Point(359, 331);
            this.lblNonInscrits.Name = "lblNonInscrits";
            this.lblNonInscrits.Size = new System.Drawing.Size(85, 16);
            this.lblNonInscrits.TabIndex = 15;
            this.lblNonInscrits.Text = "Non inscrits : ";
            // 
            // comboBoxNonInscrits
            // 
            this.comboBoxNonInscrits.FormattingEnabled = true;
            this.comboBoxNonInscrits.Location = new System.Drawing.Point(459, 327);
            this.comboBoxNonInscrits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxNonInscrits.Name = "comboBoxNonInscrits";
            this.comboBoxNonInscrits.Size = new System.Drawing.Size(212, 24);
            this.comboBoxNonInscrits.TabIndex = 9;
            // 
            // txtBoxDesignationActiviter
            // 
            this.txtBoxDesignationActiviter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxDesignationActiviter.Location = new System.Drawing.Point(145, 14);
            this.txtBoxDesignationActiviter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxDesignationActiviter.Name = "txtBoxDesignationActiviter";
            this.txtBoxDesignationActiviter.Size = new System.Drawing.Size(225, 26);
            this.txtBoxDesignationActiviter.TabIndex = 2;
            // 
            // dateTimePickerActiviter
            // 
            this.dateTimePickerActiviter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerActiviter.Location = new System.Drawing.Point(92, 98);
            this.dateTimePickerActiviter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerActiviter.Name = "dateTimePickerActiviter";
            this.dateTimePickerActiviter.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerActiviter.TabIndex = 4;
            // 
            // maskedTxtBoxNbPlacesMaxActiviter
            // 
            this.maskedTxtBoxNbPlacesMaxActiviter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTxtBoxNbPlacesMaxActiviter.Location = new System.Drawing.Point(228, 151);
            this.maskedTxtBoxNbPlacesMaxActiviter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTxtBoxNbPlacesMaxActiviter.Mask = "999999";
            this.maskedTxtBoxNbPlacesMaxActiviter.Name = "maskedTxtBoxNbPlacesMaxActiviter";
            this.maskedTxtBoxNbPlacesMaxActiviter.Size = new System.Drawing.Size(143, 26);
            this.maskedTxtBoxNbPlacesMaxActiviter.TabIndex = 5;
            // 
            // maskedTxtBoxPrixActiviter
            // 
            this.maskedTxtBoxPrixActiviter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTxtBoxPrixActiviter.Location = new System.Drawing.Point(85, 190);
            this.maskedTxtBoxPrixActiviter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTxtBoxPrixActiviter.Mask = "999999";
            this.maskedTxtBoxPrixActiviter.Name = "maskedTxtBoxPrixActiviter";
            this.maskedTxtBoxPrixActiviter.Size = new System.Drawing.Size(100, 26);
            this.maskedTxtBoxPrixActiviter.TabIndex = 8;
            // 
            // lblPrixActivite
            // 
            this.lblPrixActivite.AutoSize = true;
            this.lblPrixActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPrixActivite.Location = new System.Drawing.Point(27, 192);
            this.lblPrixActivite.Name = "lblPrixActivite";
            this.lblPrixActivite.Size = new System.Drawing.Size(53, 20);
            this.lblPrixActivite.TabIndex = 7;
            this.lblPrixActivite.Text = "Prix : ";
            // 
            // lblNbPlacesMaxActivite
            // 
            this.lblNbPlacesMaxActivite.AutoSize = true;
            this.lblNbPlacesMaxActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNbPlacesMaxActivite.Location = new System.Drawing.Point(12, 155);
            this.lblNbPlacesMaxActivite.Name = "lblNbPlacesMaxActivite";
            this.lblNbPlacesMaxActivite.Size = new System.Drawing.Size(196, 20);
            this.lblNbPlacesMaxActivite.TabIndex = 6;
            this.lblNbPlacesMaxActivite.Text = "Nombre de places max : ";
            // 
            // lblHeureDebutActivite
            // 
            this.lblHeureDebutActivite.AutoSize = true;
            this.lblHeureDebutActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHeureDebutActivite.Location = new System.Drawing.Point(12, 58);
            this.lblHeureDebutActivite.Name = "lblHeureDebutActivite";
            this.lblHeureDebutActivite.Size = new System.Drawing.Size(139, 20);
            this.lblHeureDebutActivite.TabIndex = 5;
            this.lblHeureDebutActivite.Text = "Heure de début : ";
            // 
            // lblDateActivite
            // 
            this.lblDateActivite.AutoSize = true;
            this.lblDateActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDateActivite.Location = new System.Drawing.Point(27, 103);
            this.lblDateActivite.Name = "lblDateActivite";
            this.lblDateActivite.Size = new System.Drawing.Size(60, 20);
            this.lblDateActivite.TabIndex = 4;
            this.lblDateActivite.Text = "Date : ";
            // 
            // lblDesignationActivite
            // 
            this.lblDesignationActivite.AutoSize = true;
            this.lblDesignationActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDesignationActivite.Location = new System.Drawing.Point(27, 16);
            this.lblDesignationActivite.Name = "lblDesignationActivite";
            this.lblDesignationActivite.Size = new System.Drawing.Size(113, 20);
            this.lblDesignationActivite.TabIndex = 3;
            this.lblDesignationActivite.Text = "Désignation : ";
            // 
            // btSupprimerActivite
            // 
            this.btSupprimerActivite.BackColor = System.Drawing.Color.Red;
            this.btSupprimerActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btSupprimerActivite.Location = new System.Drawing.Point(16, 351);
            this.btSupprimerActivite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSupprimerActivite.Name = "btSupprimerActivite";
            this.btSupprimerActivite.Size = new System.Drawing.Size(215, 30);
            this.btSupprimerActivite.TabIndex = 12;
            this.btSupprimerActivite.Text = "Supprimer l\'activité";
            this.btSupprimerActivite.UseVisualStyleBackColor = false;
            // 
            // dataGridViewInscritsActivite
            // 
            this.dataGridViewInscritsActivite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInscritsActivite.Location = new System.Drawing.Point(397, 33);
            this.dataGridViewInscritsActivite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewInscritsActivite.Name = "dataGridViewInscritsActivite";
            this.dataGridViewInscritsActivite.RowHeadersWidth = 51;
            this.dataGridViewInscritsActivite.RowTemplate.Height = 24;
            this.dataGridViewInscritsActivite.Size = new System.Drawing.Size(364, 272);
            this.dataGridViewInscritsActivite.TabIndex = 1;
            // 
            // FrmGestionActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.tabControlActivite);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idActiviteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDebutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbPlacesMaxDataGridViewTextBoxColumn;
    }
}