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
            this.tabControlSession = new System.Windows.Forms.TabControl();
            this.listeSession = new System.Windows.Forms.TabPage();
            this.btAjouterSession = new System.Windows.Forms.Button();
            this.dataGridViewSession = new System.Windows.Forms.DataGridView();
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
            this.tabControlSession.SuspendLayout();
            this.listeSession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSession)).BeginInit();
            this.detailsSession.SuspendLayout();
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
            this.tabControlSession.Size = new System.Drawing.Size(652, 416);
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
            this.listeSession.Size = new System.Drawing.Size(574, 320);
            this.listeSession.TabIndex = 0;
            this.listeSession.Text = "Liste";
            this.listeSession.UseVisualStyleBackColor = true;
            // 
            // btAjouterSession
            // 
            this.btAjouterSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btAjouterSession.Location = new System.Drawing.Point(210, 288);
            this.btAjouterSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAjouterSession.Name = "btAjouterSession";
            this.btAjouterSession.Size = new System.Drawing.Size(155, 24);
            this.btAjouterSession.TabIndex = 1;
            this.btAjouterSession.Text = "Ajouter une session";
            this.btAjouterSession.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSession
            // 
            this.dataGridViewSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSession.Location = new System.Drawing.Point(2, 5);
            this.dataGridViewSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewSession.Name = "dataGridViewSession";
            this.dataGridViewSession.RowHeadersWidth = 51;
            this.dataGridViewSession.RowTemplate.Height = 24;
            this.dataGridViewSession.Size = new System.Drawing.Size(569, 272);
            this.dataGridViewSession.TabIndex = 0;
            // 
            // detailsSession
            // 
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
            this.detailsSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.detailsSession.Name = "detailsSession";
            this.detailsSession.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.detailsSession.Size = new System.Drawing.Size(644, 390);
            this.detailsSession.TabIndex = 1;
            this.detailsSession.Text = "Détails";
            this.detailsSession.UseVisualStyleBackColor = true;
            // 
            // btValiderModifSession
            // 
            this.btValiderModifSession.BackColor = System.Drawing.Color.LawnGreen;
            this.btValiderModifSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btValiderModifSession.Location = new System.Drawing.Point(51, 325);
            this.btValiderModifSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btValiderModifSession.Name = "btValiderModifSession";
            this.btValiderModifSession.Size = new System.Drawing.Size(76, 39);
            this.btValiderModifSession.TabIndex = 48;
            this.btValiderModifSession.Text = "Valider";
            this.btValiderModifSession.UseVisualStyleBackColor = false;
            // 
            // btAnnulerModifSession
            // 
            this.btAnnulerModifSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btAnnulerModifSession.Location = new System.Drawing.Point(215, 332);
            this.btAnnulerModifSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAnnulerModifSession.Name = "btAnnulerModifSession";
            this.btAnnulerModifSession.Size = new System.Drawing.Size(73, 24);
            this.btAnnulerModifSession.TabIndex = 47;
            this.btAnnulerModifSession.Text = "Annuler";
            this.btAnnulerModifSession.UseVisualStyleBackColor = true;
            // 
            // comboBoxHeureDebut
            // 
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
            this.lblInscrits.Location = new System.Drawing.Point(341, 11);
            this.lblInscrits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInscrits.Name = "lblInscrits";
            this.lblInscrits.Size = new System.Drawing.Size(49, 13);
            this.lblInscrits.TabIndex = 18;
            this.lblInscrits.Text = "Inscrits : ";
            // 
            // btSupprimerInscritSession
            // 
            this.btSupprimerInscritSession.Location = new System.Drawing.Point(421, 334);
            this.btSupprimerInscritSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSupprimerInscritSession.Name = "btSupprimerInscritSession";
            this.btSupprimerInscritSession.Size = new System.Drawing.Size(121, 30);
            this.btSupprimerInscritSession.TabIndex = 11;
            this.btSupprimerInscritSession.Text = "Supprimer un inscrit";
            this.btSupprimerInscritSession.UseVisualStyleBackColor = true;
            // 
            // btAjouterInscritSession
            // 
            this.btAjouterInscritSession.Location = new System.Drawing.Point(572, 282);
            this.btAjouterInscritSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAjouterInscritSession.Name = "btAjouterInscritSession";
            this.btAjouterInscritSession.Size = new System.Drawing.Size(68, 31);
            this.btAjouterInscritSession.TabIndex = 10;
            this.btAjouterInscritSession.Text = "Ajouter";
            this.btAjouterInscritSession.UseVisualStyleBackColor = true;
            // 
            // lblNonInscrits
            // 
            this.lblNonInscrits.AutoSize = true;
            this.lblNonInscrits.Location = new System.Drawing.Point(319, 291);
            this.lblNonInscrits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNonInscrits.Name = "lblNonInscrits";
            this.lblNonInscrits.Size = new System.Drawing.Size(71, 13);
            this.lblNonInscrits.TabIndex = 15;
            this.lblNonInscrits.Text = "Non inscrits : ";
            // 
            // comboBoxNonInscrits
            // 
            this.comboBoxNonInscrits.FormattingEnabled = true;
            this.comboBoxNonInscrits.Location = new System.Drawing.Point(395, 287);
            this.comboBoxNonInscrits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxNonInscrits.Name = "comboBoxNonInscrits";
            this.comboBoxNonInscrits.Size = new System.Drawing.Size(160, 21);
            this.comboBoxNonInscrits.TabIndex = 9;
            this.comboBoxNonInscrits.SelectedIndexChanged += new System.EventHandler(this.comboBoxNonInscrits_SelectedIndexChanged);
            // 
            // txtBoxThemeSession
            // 
            this.txtBoxThemeSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxThemeSession.Location = new System.Drawing.Point(88, 32);
            this.txtBoxThemeSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxThemeSession.Name = "txtBoxThemeSession";
            this.txtBoxThemeSession.Size = new System.Drawing.Size(198, 23);
            this.txtBoxThemeSession.TabIndex = 2;
            // 
            // dateTimePickerSession
            // 
            this.dateTimePickerSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerSession.Location = new System.Drawing.Point(84, 121);
            this.dateTimePickerSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerSession.Name = "dateTimePickerSession";
            this.dateTimePickerSession.Size = new System.Drawing.Size(151, 23);
            this.dateTimePickerSession.TabIndex = 4;
            // 
            // maskedTxtBoxNbPlacesMaxSession
            // 
            this.maskedTxtBoxNbPlacesMaxSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTxtBoxNbPlacesMaxSession.Location = new System.Drawing.Point(188, 167);
            this.maskedTxtBoxNbPlacesMaxSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maskedTxtBoxNbPlacesMaxSession.Mask = "999999";
            this.maskedTxtBoxNbPlacesMaxSession.Name = "maskedTxtBoxNbPlacesMaxSession";
            this.maskedTxtBoxNbPlacesMaxSession.Size = new System.Drawing.Size(108, 23);
            this.maskedTxtBoxNbPlacesMaxSession.TabIndex = 5;
            // 
            // comboBoxSalleSession
            // 
            this.comboBoxSalleSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxSalleSession.FormattingEnabled = true;
            this.comboBoxSalleSession.Location = new System.Drawing.Point(84, 209);
            this.comboBoxSalleSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxSalleSession.Name = "comboBoxSalleSession";
            this.comboBoxSalleSession.Size = new System.Drawing.Size(92, 24);
            this.comboBoxSalleSession.TabIndex = 6;
            // 
            // maskedTxtBoxPrixSession
            // 
            this.maskedTxtBoxPrixSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTxtBoxPrixSession.Location = new System.Drawing.Point(75, 246);
            this.maskedTxtBoxPrixSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maskedTxtBoxPrixSession.Mask = "999999";
            this.maskedTxtBoxPrixSession.Name = "maskedTxtBoxPrixSession";
            this.maskedTxtBoxPrixSession.Size = new System.Drawing.Size(76, 23);
            this.maskedTxtBoxPrixSession.TabIndex = 8;
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
            this.btSupprimerSession.BackColor = System.Drawing.Color.Red;
            this.btSupprimerSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btSupprimerSession.Location = new System.Drawing.Point(12, 325);
            this.btSupprimerSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSupprimerSession.Name = "btSupprimerSession";
            this.btSupprimerSession.Size = new System.Drawing.Size(164, 39);
            this.btSupprimerSession.TabIndex = 12;
            this.btSupprimerSession.Text = "Supprimer la session";
            this.btSupprimerSession.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(344, 35);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(273, 221);
            this.dataGridView2.TabIndex = 1;
            // 
            // FrmGestionSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 437);
            this.Controls.Add(this.tabControlSession);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmGestionSession";
            this.Text = "Gestion Session";
            this.tabControlSession.ResumeLayout(false);
            this.listeSession.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSession)).EndInit();
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
    }
}

