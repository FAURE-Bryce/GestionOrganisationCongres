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
            this.tabControlActiviter = new System.Windows.Forms.TabControl();
            this.listSession = new System.Windows.Forms.TabPage();
            this.btAjouterActivite = new System.Windows.Forms.Button();
            this.dataGridViewActiviter = new System.Windows.Forms.DataGridView();
            this.detailSession = new System.Windows.Forms.TabPage();
            this.btValider = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.comboBoxHeureActiviter = new System.Windows.Forms.ComboBox();
            this.lbAllInscrits = new System.Windows.Forms.Label();
            this.btSupprimerInscritActiviter = new System.Windows.Forms.Button();
            this.btAjouterInscritActivite = new System.Windows.Forms.Button();
            this.lbInscrits = new System.Windows.Forms.Label();
            this.comboBoxCongrssiste = new System.Windows.Forms.ComboBox();
            this.txtBoxDesignationActiviter = new System.Windows.Forms.TextBox();
            this.dateTimePickerActiviter = new System.Windows.Forms.DateTimePicker();
            this.maskedTxtBoxNbPlacesMaxActiviter = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtBoxPrixActiviter = new System.Windows.Forms.MaskedTextBox();
            this.lbPrixSession = new System.Windows.Forms.Label();
            this.lbNbPlacesMaxActivite = new System.Windows.Forms.Label();
            this.lbHeureDebutActivite = new System.Windows.Forms.Label();
            this.lbDateActivite = new System.Windows.Forms.Label();
            this.lbDesignationSession = new System.Windows.Forms.Label();
            this.btSupprimerActiviter = new System.Windows.Forms.Button();
            this.dataGridViewInscritsActivite = new System.Windows.Forms.DataGridView();
            this.tabControlActiviter.SuspendLayout();
            this.listSession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiviter)).BeginInit();
            this.detailSession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInscritsActivite)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlActiviter
            // 
            this.tabControlActiviter.Controls.Add(this.listSession);
            this.tabControlActiviter.Controls.Add(this.detailSession);
            this.tabControlActiviter.Location = new System.Drawing.Point(9, 10);
            this.tabControlActiviter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControlActiviter.Name = "tabControlActiviter";
            this.tabControlActiviter.SelectedIndex = 0;
            this.tabControlActiviter.Size = new System.Drawing.Size(582, 346);
            this.tabControlActiviter.TabIndex = 1;
            // 
            // listSession
            // 
            this.listSession.Controls.Add(this.btAjouterActivite);
            this.listSession.Controls.Add(this.dataGridViewActiviter);
            this.listSession.Location = new System.Drawing.Point(4, 22);
            this.listSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listSession.Name = "listSession";
            this.listSession.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listSession.Size = new System.Drawing.Size(574, 320);
            this.listSession.TabIndex = 0;
            this.listSession.Text = "Liste";
            this.listSession.UseVisualStyleBackColor = true;
            // 
            // btAjouterActivite
            // 
            this.btAjouterActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btAjouterActivite.Location = new System.Drawing.Point(210, 288);
            this.btAjouterActivite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAjouterActivite.Name = "btAjouterActivite";
            this.btAjouterActivite.Size = new System.Drawing.Size(155, 24);
            this.btAjouterActivite.TabIndex = 1;
            this.btAjouterActivite.Text = "Ajouter Activiter";
            this.btAjouterActivite.UseVisualStyleBackColor = true;
            // 
            // dataGridViewActiviter
            // 
            this.dataGridViewActiviter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActiviter.Location = new System.Drawing.Point(2, 5);
            this.dataGridViewActiviter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewActiviter.Name = "dataGridViewActiviter";
            this.dataGridViewActiviter.RowHeadersWidth = 51;
            this.dataGridViewActiviter.RowTemplate.Height = 24;
            this.dataGridViewActiviter.Size = new System.Drawing.Size(569, 272);
            this.dataGridViewActiviter.TabIndex = 0;
            // 
            // detailSession
            // 
            this.detailSession.Controls.Add(this.btValider);
            this.detailSession.Controls.Add(this.btAnnuler);
            this.detailSession.Controls.Add(this.comboBoxHeureActiviter);
            this.detailSession.Controls.Add(this.lbAllInscrits);
            this.detailSession.Controls.Add(this.btSupprimerInscritActiviter);
            this.detailSession.Controls.Add(this.btAjouterInscritActivite);
            this.detailSession.Controls.Add(this.lbInscrits);
            this.detailSession.Controls.Add(this.comboBoxCongrssiste);
            this.detailSession.Controls.Add(this.txtBoxDesignationActiviter);
            this.detailSession.Controls.Add(this.dateTimePickerActiviter);
            this.detailSession.Controls.Add(this.maskedTxtBoxNbPlacesMaxActiviter);
            this.detailSession.Controls.Add(this.maskedTxtBoxPrixActiviter);
            this.detailSession.Controls.Add(this.lbPrixSession);
            this.detailSession.Controls.Add(this.lbNbPlacesMaxActivite);
            this.detailSession.Controls.Add(this.lbHeureDebutActivite);
            this.detailSession.Controls.Add(this.lbDateActivite);
            this.detailSession.Controls.Add(this.lbDesignationSession);
            this.detailSession.Controls.Add(this.btSupprimerActiviter);
            this.detailSession.Controls.Add(this.dataGridViewInscritsActivite);
            this.detailSession.Location = new System.Drawing.Point(4, 22);
            this.detailSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.detailSession.Name = "detailSession";
            this.detailSession.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.detailSession.Size = new System.Drawing.Size(574, 320);
            this.detailSession.TabIndex = 1;
            this.detailSession.Text = "Detail";
            this.detailSession.UseVisualStyleBackColor = true;
            // 
            // btValider
            // 
            this.btValider.BackColor = System.Drawing.Color.LawnGreen;
            this.btValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btValider.Location = new System.Drawing.Point(45, 285);
            this.btValider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(56, 24);
            this.btValider.TabIndex = 48;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = false;
            // 
            // btAnnuler
            // 
            this.btAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btAnnuler.Location = new System.Drawing.Point(180, 285);
            this.btAnnuler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(56, 24);
            this.btAnnuler.TabIndex = 47;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            // 
            // comboBoxHeureActiviter
            // 
            this.comboBoxHeureActiviter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxHeureActiviter.FormattingEnabled = true;
            this.comboBoxHeureActiviter.Location = new System.Drawing.Point(128, 44);
            this.comboBoxHeureActiviter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxHeureActiviter.Name = "comboBoxHeureActiviter";
            this.comboBoxHeureActiviter.Size = new System.Drawing.Size(92, 24);
            this.comboBoxHeureActiviter.TabIndex = 3;
            // 
            // lbAllInscrits
            // 
            this.lbAllInscrits.AutoSize = true;
            this.lbAllInscrits.Location = new System.Drawing.Point(296, 11);
            this.lbAllInscrits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAllInscrits.Name = "lbAllInscrits";
            this.lbAllInscrits.Size = new System.Drawing.Size(49, 13);
            this.lbAllInscrits.TabIndex = 18;
            this.lbAllInscrits.Text = "Inscrits : ";
            // 
            // btSupprimerInscritActiviter
            // 
            this.btSupprimerInscritActiviter.Location = new System.Drawing.Point(393, 293);
            this.btSupprimerInscritActiviter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSupprimerInscritActiviter.Name = "btSupprimerInscritActiviter";
            this.btSupprimerInscritActiviter.Size = new System.Drawing.Size(64, 19);
            this.btSupprimerInscritActiviter.TabIndex = 11;
            this.btSupprimerInscritActiviter.Text = "Supprimer";
            this.btSupprimerInscritActiviter.UseVisualStyleBackColor = true;
            // 
            // btAjouterInscritActivite
            // 
            this.btAjouterInscritActivite.Location = new System.Drawing.Point(507, 266);
            this.btAjouterInscritActivite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAjouterInscritActivite.Name = "btAjouterInscritActivite";
            this.btAjouterInscritActivite.Size = new System.Drawing.Size(64, 19);
            this.btAjouterInscritActivite.TabIndex = 10;
            this.btAjouterInscritActivite.Text = "Ajouter";
            this.btAjouterInscritActivite.UseVisualStyleBackColor = true;
            // 
            // lbInscrits
            // 
            this.lbInscrits.AutoSize = true;
            this.lbInscrits.Location = new System.Drawing.Point(296, 268);
            this.lbInscrits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbInscrits.Name = "lbInscrits";
            this.lbInscrits.Size = new System.Drawing.Size(49, 13);
            this.lbInscrits.TabIndex = 15;
            this.lbInscrits.Text = "Inscrits : ";
            // 
            // comboBoxCongrssiste
            // 
            this.comboBoxCongrssiste.FormattingEnabled = true;
            this.comboBoxCongrssiste.Location = new System.Drawing.Point(344, 266);
            this.comboBoxCongrssiste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCongrssiste.Name = "comboBoxCongrssiste";
            this.comboBoxCongrssiste.Size = new System.Drawing.Size(160, 21);
            this.comboBoxCongrssiste.TabIndex = 9;
            // 
            // txtBoxDesignationActiviter
            // 
            this.txtBoxDesignationActiviter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxDesignationActiviter.Location = new System.Drawing.Point(109, 11);
            this.txtBoxDesignationActiviter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxDesignationActiviter.Name = "txtBoxDesignationActiviter";
            this.txtBoxDesignationActiviter.Size = new System.Drawing.Size(170, 23);
            this.txtBoxDesignationActiviter.TabIndex = 2;
            // 
            // dateTimePickerActiviter
            // 
            this.dateTimePickerActiviter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerActiviter.Location = new System.Drawing.Point(69, 80);
            this.dateTimePickerActiviter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerActiviter.Name = "dateTimePickerActiviter";
            this.dateTimePickerActiviter.Size = new System.Drawing.Size(151, 23);
            this.dateTimePickerActiviter.TabIndex = 4;
            // 
            // maskedTxtBoxNbPlacesMaxActiviter
            // 
            this.maskedTxtBoxNbPlacesMaxActiviter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTxtBoxNbPlacesMaxActiviter.Location = new System.Drawing.Point(171, 123);
            this.maskedTxtBoxNbPlacesMaxActiviter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maskedTxtBoxNbPlacesMaxActiviter.Mask = "999999";
            this.maskedTxtBoxNbPlacesMaxActiviter.Name = "maskedTxtBoxNbPlacesMaxActiviter";
            this.maskedTxtBoxNbPlacesMaxActiviter.Size = new System.Drawing.Size(108, 23);
            this.maskedTxtBoxNbPlacesMaxActiviter.TabIndex = 5;
            // 
            // maskedTxtBoxPrixActiviter
            // 
            this.maskedTxtBoxPrixActiviter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTxtBoxPrixActiviter.Location = new System.Drawing.Point(64, 154);
            this.maskedTxtBoxPrixActiviter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maskedTxtBoxPrixActiviter.Mask = "999999";
            this.maskedTxtBoxPrixActiviter.Name = "maskedTxtBoxPrixActiviter";
            this.maskedTxtBoxPrixActiviter.Size = new System.Drawing.Size(76, 23);
            this.maskedTxtBoxPrixActiviter.TabIndex = 8;
            // 
            // lbPrixSession
            // 
            this.lbPrixSession.AutoSize = true;
            this.lbPrixSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbPrixSession.Location = new System.Drawing.Point(20, 156);
            this.lbPrixSession.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrixSession.Name = "lbPrixSession";
            this.lbPrixSession.Size = new System.Drawing.Size(43, 17);
            this.lbPrixSession.TabIndex = 7;
            this.lbPrixSession.Text = "Prix : ";
            // 
            // lbNbPlacesMaxActivite
            // 
            this.lbNbPlacesMaxActivite.AutoSize = true;
            this.lbNbPlacesMaxActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNbPlacesMaxActivite.Location = new System.Drawing.Point(20, 125);
            this.lbNbPlacesMaxActivite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNbPlacesMaxActivite.Name = "lbNbPlacesMaxActivite";
            this.lbNbPlacesMaxActivite.Size = new System.Drawing.Size(164, 17);
            this.lbNbPlacesMaxActivite.TabIndex = 6;
            this.lbNbPlacesMaxActivite.Text = "Nombre de places max : ";
            // 
            // lbHeureDebutActivite
            // 
            this.lbHeureDebutActivite.AutoSize = true;
            this.lbHeureDebutActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbHeureDebutActivite.Location = new System.Drawing.Point(20, 46);
            this.lbHeureDebutActivite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHeureDebutActivite.Name = "lbHeureDebutActivite";
            this.lbHeureDebutActivite.Size = new System.Drawing.Size(119, 17);
            this.lbHeureDebutActivite.TabIndex = 5;
            this.lbHeureDebutActivite.Text = "Heure de début : ";
            // 
            // lbDateActivite
            // 
            this.lbDateActivite.AutoSize = true;
            this.lbDateActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDateActivite.Location = new System.Drawing.Point(20, 84);
            this.lbDateActivite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDateActivite.Name = "lbDateActivite";
            this.lbDateActivite.Size = new System.Drawing.Size(50, 17);
            this.lbDateActivite.TabIndex = 4;
            this.lbDateActivite.Text = "Date : ";
            // 
            // lbDesignationSession
            // 
            this.lbDesignationSession.AutoSize = true;
            this.lbDesignationSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDesignationSession.Location = new System.Drawing.Point(20, 13);
            this.lbDesignationSession.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDesignationSession.Name = "lbDesignationSession";
            this.lbDesignationSession.Size = new System.Drawing.Size(95, 17);
            this.lbDesignationSession.TabIndex = 3;
            this.lbDesignationSession.Text = "Designation : ";
            // 
            // btSupprimerActiviter
            // 
            this.btSupprimerActiviter.BackColor = System.Drawing.Color.Red;
            this.btSupprimerActiviter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btSupprimerActiviter.Location = new System.Drawing.Point(12, 285);
            this.btSupprimerActiviter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSupprimerActiviter.Name = "btSupprimerActiviter";
            this.btSupprimerActiviter.Size = new System.Drawing.Size(124, 24);
            this.btSupprimerActiviter.TabIndex = 12;
            this.btSupprimerActiviter.Text = "Supprimer Session";
            this.btSupprimerActiviter.UseVisualStyleBackColor = false;
            // 
            // dataGridViewInscritsActivite
            // 
            this.dataGridViewInscritsActivite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInscritsActivite.Location = new System.Drawing.Point(298, 27);
            this.dataGridViewInscritsActivite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewInscritsActivite.Name = "dataGridViewInscritsActivite";
            this.dataGridViewInscritsActivite.RowHeadersWidth = 51;
            this.dataGridViewInscritsActivite.RowTemplate.Height = 24;
            this.dataGridViewInscritsActivite.Size = new System.Drawing.Size(273, 221);
            this.dataGridViewInscritsActivite.TabIndex = 1;
            // 
            // FrmGestionActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tabControlActiviter);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmGestionActivite";
            this.Text = "Gestion Activité";
            this.tabControlActiviter.ResumeLayout(false);
            this.listSession.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiviter)).EndInit();
            this.detailSession.ResumeLayout(false);
            this.detailSession.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInscritsActivite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlActiviter;
        private System.Windows.Forms.TabPage listSession;
        private System.Windows.Forms.Button btAjouterActivite;
        private System.Windows.Forms.DataGridView dataGridViewActiviter;
        private System.Windows.Forms.TabPage detailSession;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.ComboBox comboBoxHeureActiviter;
        private System.Windows.Forms.Label lbAllInscrits;
        private System.Windows.Forms.Button btSupprimerInscritActiviter;
        private System.Windows.Forms.Button btAjouterInscritActivite;
        private System.Windows.Forms.Label lbInscrits;
        private System.Windows.Forms.ComboBox comboBoxCongrssiste;
        private System.Windows.Forms.TextBox txtBoxDesignationActiviter;
        private System.Windows.Forms.DateTimePicker dateTimePickerActiviter;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxNbPlacesMaxActiviter;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxPrixActiviter;
        private System.Windows.Forms.Label lbPrixSession;
        private System.Windows.Forms.Label lbNbPlacesMaxActivite;
        private System.Windows.Forms.Label lbHeureDebutActivite;
        private System.Windows.Forms.Label lbDateActivite;
        private System.Windows.Forms.Label lbDesignationSession;
        private System.Windows.Forms.Button btSupprimerActiviter;
        private System.Windows.Forms.DataGridView dataGridViewInscritsActivite;
    }
}