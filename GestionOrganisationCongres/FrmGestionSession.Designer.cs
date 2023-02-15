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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.listSession = new System.Windows.Forms.TabPage();
            this.detailSession = new System.Windows.Forms.TabPage();
            this.dataGridViewSession = new System.Windows.Forms.DataGridView();
            this.btAjouterSession = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btSupprimerSession = new System.Windows.Forms.Button();
            this.lbThemeSession = new System.Windows.Forms.Label();
            this.lbDateSession = new System.Windows.Forms.Label();
            this.lbHeureDebutSession = new System.Windows.Forms.Label();
            this.lbNbPlacesMaxSession = new System.Windows.Forms.Label();
            this.lbPrixSession = new System.Windows.Forms.Label();
            this.lbSalleSession = new System.Windows.Forms.Label();
            this.maskedTxtBoxPrixSession = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxSalleSession = new System.Windows.Forms.ComboBox();
            this.maskedTxtBoxNbPlacesMaxSession = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePickerSession = new System.Windows.Forms.DateTimePicker();
            this.txtBoxThemeSession = new System.Windows.Forms.TextBox();
            this.comboBoxCongrssiste = new System.Windows.Forms.ComboBox();
            this.lbInscris = new System.Windows.Forms.Label();
            this.btAjouterInscritSession = new System.Windows.Forms.Button();
            this.btSupprimerInscritSession = new System.Windows.Forms.Button();
            this.lbAllInscrits = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btValider = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.listSession.SuspendLayout();
            this.detailSession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.listSession);
            this.tabControl1.Controls.Add(this.detailSession);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // listSession
            // 
            this.listSession.Controls.Add(this.btAjouterSession);
            this.listSession.Controls.Add(this.dataGridViewSession);
            this.listSession.Location = new System.Drawing.Point(4, 25);
            this.listSession.Name = "listSession";
            this.listSession.Padding = new System.Windows.Forms.Padding(3);
            this.listSession.Size = new System.Drawing.Size(768, 397);
            this.listSession.TabIndex = 0;
            this.listSession.Text = "Liste";
            this.listSession.UseVisualStyleBackColor = true;
            // 
            // detailSession
            // 
            this.detailSession.Controls.Add(this.btValider);
            this.detailSession.Controls.Add(this.btAnnuler);
            this.detailSession.Controls.Add(this.comboBox1);
            this.detailSession.Controls.Add(this.lbAllInscrits);
            this.detailSession.Controls.Add(this.btSupprimerInscritSession);
            this.detailSession.Controls.Add(this.btAjouterInscritSession);
            this.detailSession.Controls.Add(this.lbInscris);
            this.detailSession.Controls.Add(this.comboBoxCongrssiste);
            this.detailSession.Controls.Add(this.txtBoxThemeSession);
            this.detailSession.Controls.Add(this.dateTimePickerSession);
            this.detailSession.Controls.Add(this.maskedTxtBoxNbPlacesMaxSession);
            this.detailSession.Controls.Add(this.comboBoxSalleSession);
            this.detailSession.Controls.Add(this.maskedTxtBoxPrixSession);
            this.detailSession.Controls.Add(this.lbSalleSession);
            this.detailSession.Controls.Add(this.lbPrixSession);
            this.detailSession.Controls.Add(this.lbNbPlacesMaxSession);
            this.detailSession.Controls.Add(this.lbHeureDebutSession);
            this.detailSession.Controls.Add(this.lbDateSession);
            this.detailSession.Controls.Add(this.lbThemeSession);
            this.detailSession.Controls.Add(this.btSupprimerSession);
            this.detailSession.Controls.Add(this.dataGridView2);
            this.detailSession.Location = new System.Drawing.Point(4, 25);
            this.detailSession.Name = "detailSession";
            this.detailSession.Padding = new System.Windows.Forms.Padding(3);
            this.detailSession.Size = new System.Drawing.Size(768, 397);
            this.detailSession.TabIndex = 1;
            this.detailSession.Text = "Detail";
            this.detailSession.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSession
            // 
            this.dataGridViewSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSession.Location = new System.Drawing.Point(3, 6);
            this.dataGridViewSession.Name = "dataGridViewSession";
            this.dataGridViewSession.RowHeadersWidth = 51;
            this.dataGridViewSession.RowTemplate.Height = 24;
            this.dataGridViewSession.Size = new System.Drawing.Size(759, 335);
            this.dataGridViewSession.TabIndex = 0;
            // 
            // btAjouterSession
            // 
            this.btAjouterSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btAjouterSession.Location = new System.Drawing.Point(280, 355);
            this.btAjouterSession.Name = "btAjouterSession";
            this.btAjouterSession.Size = new System.Drawing.Size(207, 30);
            this.btAjouterSession.TabIndex = 1;
            this.btAjouterSession.Text = "Ajouter Session";
            this.btAjouterSession.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(398, 33);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(364, 272);
            this.dataGridView2.TabIndex = 1;
            // 
            // btSupprimerSession
            // 
            this.btSupprimerSession.BackColor = System.Drawing.Color.Red;
            this.btSupprimerSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btSupprimerSession.Location = new System.Drawing.Point(16, 351);
            this.btSupprimerSession.Name = "btSupprimerSession";
            this.btSupprimerSession.Size = new System.Drawing.Size(165, 30);
            this.btSupprimerSession.TabIndex = 12;
            this.btSupprimerSession.Text = "Supprimer Session";
            this.btSupprimerSession.UseVisualStyleBackColor = false;
            // 
            // lbThemeSession
            // 
            this.lbThemeSession.AutoSize = true;
            this.lbThemeSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbThemeSession.Location = new System.Drawing.Point(26, 16);
            this.lbThemeSession.Name = "lbThemeSession";
            this.lbThemeSession.Size = new System.Drawing.Size(75, 20);
            this.lbThemeSession.TabIndex = 3;
            this.lbThemeSession.Text = "Thème : ";
            // 
            // lbDateSession
            // 
            this.lbDateSession.AutoSize = true;
            this.lbDateSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDateSession.Location = new System.Drawing.Point(26, 103);
            this.lbDateSession.Name = "lbDateSession";
            this.lbDateSession.Size = new System.Drawing.Size(60, 20);
            this.lbDateSession.TabIndex = 4;
            this.lbDateSession.Text = "Date : ";
            // 
            // lbHeureDebutSession
            // 
            this.lbHeureDebutSession.AutoSize = true;
            this.lbHeureDebutSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbHeureDebutSession.Location = new System.Drawing.Point(26, 57);
            this.lbHeureDebutSession.Name = "lbHeureDebutSession";
            this.lbHeureDebutSession.Size = new System.Drawing.Size(139, 20);
            this.lbHeureDebutSession.TabIndex = 5;
            this.lbHeureDebutSession.Text = "Heure de début : ";
            // 
            // lbNbPlacesMaxSession
            // 
            this.lbNbPlacesMaxSession.AutoSize = true;
            this.lbNbPlacesMaxSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNbPlacesMaxSession.Location = new System.Drawing.Point(26, 154);
            this.lbNbPlacesMaxSession.Name = "lbNbPlacesMaxSession";
            this.lbNbPlacesMaxSession.Size = new System.Drawing.Size(196, 20);
            this.lbNbPlacesMaxSession.TabIndex = 6;
            this.lbNbPlacesMaxSession.Text = "Nombre de places max : ";
            // 
            // lbPrixSession
            // 
            this.lbPrixSession.AutoSize = true;
            this.lbPrixSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbPrixSession.Location = new System.Drawing.Point(26, 258);
            this.lbPrixSession.Name = "lbPrixSession";
            this.lbPrixSession.Size = new System.Drawing.Size(53, 20);
            this.lbPrixSession.TabIndex = 7;
            this.lbPrixSession.Text = "Prix : ";
            // 
            // lbSalleSession
            // 
            this.lbSalleSession.AutoSize = true;
            this.lbSalleSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSalleSession.Location = new System.Drawing.Point(26, 206);
            this.lbSalleSession.Name = "lbSalleSession";
            this.lbSalleSession.Size = new System.Drawing.Size(61, 20);
            this.lbSalleSession.TabIndex = 8;
            this.lbSalleSession.Text = "Salle : ";
            // 
            // maskedTxtBoxPrixSession
            // 
            this.maskedTxtBoxPrixSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTxtBoxPrixSession.Location = new System.Drawing.Point(85, 255);
            this.maskedTxtBoxPrixSession.Mask = "999999";
            this.maskedTxtBoxPrixSession.Name = "maskedTxtBoxPrixSession";
            this.maskedTxtBoxPrixSession.Size = new System.Drawing.Size(100, 26);
            this.maskedTxtBoxPrixSession.TabIndex = 8;
            // 
            // comboBoxSalleSession
            // 
            this.comboBoxSalleSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxSalleSession.FormattingEnabled = true;
            this.comboBoxSalleSession.Location = new System.Drawing.Point(93, 203);
            this.comboBoxSalleSession.Name = "comboBoxSalleSession";
            this.comboBoxSalleSession.Size = new System.Drawing.Size(121, 28);
            this.comboBoxSalleSession.TabIndex = 6;
            // 
            // maskedTxtBoxNbPlacesMaxSession
            // 
            this.maskedTxtBoxNbPlacesMaxSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTxtBoxNbPlacesMaxSession.Location = new System.Drawing.Point(228, 151);
            this.maskedTxtBoxNbPlacesMaxSession.Mask = "999999";
            this.maskedTxtBoxNbPlacesMaxSession.Name = "maskedTxtBoxNbPlacesMaxSession";
            this.maskedTxtBoxNbPlacesMaxSession.Size = new System.Drawing.Size(142, 26);
            this.maskedTxtBoxNbPlacesMaxSession.TabIndex = 5;
            // 
            // dateTimePickerSession
            // 
            this.dateTimePickerSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerSession.Location = new System.Drawing.Point(92, 98);
            this.dateTimePickerSession.Name = "dateTimePickerSession";
            this.dateTimePickerSession.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerSession.TabIndex = 4;
            // 
            // txtBoxThemeSession
            // 
            this.txtBoxThemeSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxThemeSession.Location = new System.Drawing.Point(107, 13);
            this.txtBoxThemeSession.Name = "txtBoxThemeSession";
            this.txtBoxThemeSession.Size = new System.Drawing.Size(263, 26);
            this.txtBoxThemeSession.TabIndex = 2;
            // 
            // comboBoxCongrssiste
            // 
            this.comboBoxCongrssiste.FormattingEnabled = true;
            this.comboBoxCongrssiste.Location = new System.Drawing.Point(458, 327);
            this.comboBoxCongrssiste.Name = "comboBoxCongrssiste";
            this.comboBoxCongrssiste.Size = new System.Drawing.Size(212, 24);
            this.comboBoxCongrssiste.TabIndex = 9;
            // 
            // lbInscris
            // 
            this.lbInscris.AutoSize = true;
            this.lbInscris.Location = new System.Drawing.Point(395, 330);
            this.lbInscris.Name = "lbInscris";
            this.lbInscris.Size = new System.Drawing.Size(57, 16);
            this.lbInscris.TabIndex = 15;
            this.lbInscris.Text = "Inscrits : ";
            // 
            // btAjouterInscritSession
            // 
            this.btAjouterInscritSession.Location = new System.Drawing.Point(676, 327);
            this.btAjouterInscritSession.Name = "btAjouterInscritSession";
            this.btAjouterInscritSession.Size = new System.Drawing.Size(86, 23);
            this.btAjouterInscritSession.TabIndex = 10;
            this.btAjouterInscritSession.Text = "Ajouter";
            this.btAjouterInscritSession.UseVisualStyleBackColor = true;
            // 
            // btSupprimerInscritSession
            // 
            this.btSupprimerInscritSession.Location = new System.Drawing.Point(524, 361);
            this.btSupprimerInscritSession.Name = "btSupprimerInscritSession";
            this.btSupprimerInscritSession.Size = new System.Drawing.Size(86, 23);
            this.btSupprimerInscritSession.TabIndex = 11;
            this.btSupprimerInscritSession.Text = "Supprimer";
            this.btSupprimerInscritSession.UseVisualStyleBackColor = true;
            // 
            // lbAllInscrits
            // 
            this.lbAllInscrits.AutoSize = true;
            this.lbAllInscrits.Location = new System.Drawing.Point(395, 13);
            this.lbAllInscrits.Name = "lbAllInscrits";
            this.lbAllInscrits.Size = new System.Drawing.Size(57, 16);
            this.lbAllInscrits.TabIndex = 18;
            this.lbAllInscrits.Text = "Inscrits : ";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(171, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // btValider
            // 
            this.btValider.BackColor = System.Drawing.Color.LawnGreen;
            this.btValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btValider.Location = new System.Drawing.Point(60, 351);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(75, 30);
            this.btValider.TabIndex = 48;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = false;
            // 
            // btAnnuler
            // 
            this.btAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btAnnuler.Location = new System.Drawing.Point(240, 351);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(75, 30);
            this.btAnnuler.TabIndex = 47;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            // 
            // FrmGestionSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmGestionSession";
            this.Text = "Gestion Session";
            this.tabControl1.ResumeLayout(false);
            this.listSession.ResumeLayout(false);
            this.detailSession.ResumeLayout(false);
            this.detailSession.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage listSession;
        private System.Windows.Forms.DataGridView dataGridViewSession;
        private System.Windows.Forms.TabPage detailSession;
        private System.Windows.Forms.Button btAjouterSession;
        private System.Windows.Forms.ComboBox comboBoxSalleSession;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxPrixSession;
        private System.Windows.Forms.Label lbSalleSession;
        private System.Windows.Forms.Label lbPrixSession;
        private System.Windows.Forms.Label lbNbPlacesMaxSession;
        private System.Windows.Forms.Label lbHeureDebutSession;
        private System.Windows.Forms.Label lbDateSession;
        private System.Windows.Forms.Label lbThemeSession;
        private System.Windows.Forms.Button btSupprimerSession;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbAllInscrits;
        private System.Windows.Forms.Button btSupprimerInscritSession;
        private System.Windows.Forms.Button btAjouterInscritSession;
        private System.Windows.Forms.Label lbInscris;
        private System.Windows.Forms.ComboBox comboBoxCongrssiste;
        private System.Windows.Forms.TextBox txtBoxThemeSession;
        private System.Windows.Forms.DateTimePicker dateTimePickerSession;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxNbPlacesMaxSession;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Button btAnnuler;
    }
}

