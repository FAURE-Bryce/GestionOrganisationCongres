namespace GestionOrganisationCongres
{
    partial class FrmGestionHotel
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
            this.tabControlHotel = new System.Windows.Forms.TabControl();
            this.listSession = new System.Windows.Forms.TabPage();
            this.btAjouterHotel = new System.Windows.Forms.Button();
            this.dataGridViewHotel = new System.Windows.Forms.DataGridView();
            this.detailSession = new System.Windows.Forms.TabPage();
            this.btValider = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.txtBoxNomHotel = new System.Windows.Forms.TextBox();
            this.maskedTxtBoxCpHotel = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxNbEtoileHotel = new System.Windows.Forms.ComboBox();
            this.maskedTxtBoxPrixHotel = new System.Windows.Forms.MaskedTextBox();
            this.lbPrixHotel = new System.Windows.Forms.Label();
            this.lbNbEtoileHotel = new System.Windows.Forms.Label();
            this.lbCpHotel = new System.Windows.Forms.Label();
            this.lbAdresseHotel = new System.Windows.Forms.Label();
            this.lbVilleHotel = new System.Windows.Forms.Label();
            this.lbNomHotel = new System.Windows.Forms.Label();
            this.btSupprimerHotel = new System.Windows.Forms.Button();
            this.textBoxVilleHotel = new System.Windows.Forms.TextBox();
            this.textBoxAdresseHotel = new System.Windows.Forms.TextBox();
            this.tabControlHotel.SuspendLayout();
            this.listSession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotel)).BeginInit();
            this.detailSession.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlHotel
            // 
            this.tabControlHotel.Controls.Add(this.listSession);
            this.tabControlHotel.Controls.Add(this.detailSession);
            this.tabControlHotel.Location = new System.Drawing.Point(12, 12);
            this.tabControlHotel.Name = "tabControlHotel";
            this.tabControlHotel.SelectedIndex = 0;
            this.tabControlHotel.Size = new System.Drawing.Size(776, 426);
            this.tabControlHotel.TabIndex = 1;
            // 
            // listSession
            // 
            this.listSession.Controls.Add(this.btAjouterHotel);
            this.listSession.Controls.Add(this.dataGridViewHotel);
            this.listSession.Location = new System.Drawing.Point(4, 25);
            this.listSession.Name = "listSession";
            this.listSession.Padding = new System.Windows.Forms.Padding(3);
            this.listSession.Size = new System.Drawing.Size(768, 397);
            this.listSession.TabIndex = 0;
            this.listSession.Text = "Liste";
            this.listSession.UseVisualStyleBackColor = true;
            // 
            // btAjouterHotel
            // 
            this.btAjouterHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btAjouterHotel.Location = new System.Drawing.Point(280, 355);
            this.btAjouterHotel.Name = "btAjouterHotel";
            this.btAjouterHotel.Size = new System.Drawing.Size(207, 30);
            this.btAjouterHotel.TabIndex = 1;
            this.btAjouterHotel.Text = "Ajouter Hôtel";
            this.btAjouterHotel.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHotel
            // 
            this.dataGridViewHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHotel.Location = new System.Drawing.Point(3, 6);
            this.dataGridViewHotel.Name = "dataGridViewHotel";
            this.dataGridViewHotel.RowHeadersWidth = 51;
            this.dataGridViewHotel.RowTemplate.Height = 24;
            this.dataGridViewHotel.Size = new System.Drawing.Size(759, 335);
            this.dataGridViewHotel.TabIndex = 0;
            // 
            // detailSession
            // 
            this.detailSession.Controls.Add(this.textBoxAdresseHotel);
            this.detailSession.Controls.Add(this.textBoxVilleHotel);
            this.detailSession.Controls.Add(this.btValider);
            this.detailSession.Controls.Add(this.btAnnuler);
            this.detailSession.Controls.Add(this.txtBoxNomHotel);
            this.detailSession.Controls.Add(this.maskedTxtBoxCpHotel);
            this.detailSession.Controls.Add(this.comboBoxNbEtoileHotel);
            this.detailSession.Controls.Add(this.maskedTxtBoxPrixHotel);
            this.detailSession.Controls.Add(this.lbPrixHotel);
            this.detailSession.Controls.Add(this.lbNbEtoileHotel);
            this.detailSession.Controls.Add(this.lbCpHotel);
            this.detailSession.Controls.Add(this.lbAdresseHotel);
            this.detailSession.Controls.Add(this.lbVilleHotel);
            this.detailSession.Controls.Add(this.lbNomHotel);
            this.detailSession.Controls.Add(this.btSupprimerHotel);
            this.detailSession.Location = new System.Drawing.Point(4, 25);
            this.detailSession.Name = "detailSession";
            this.detailSession.Padding = new System.Windows.Forms.Padding(3);
            this.detailSession.Size = new System.Drawing.Size(768, 397);
            this.detailSession.TabIndex = 1;
            this.detailSession.Text = "Detail";
            this.detailSession.UseVisualStyleBackColor = true;
            // 
            // btValider
            // 
            this.btValider.BackColor = System.Drawing.Color.LawnGreen;
            this.btValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btValider.Location = new System.Drawing.Point(252, 361);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(75, 30);
            this.btValider.TabIndex = 48;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = false;
            // 
            // btAnnuler
            // 
            this.btAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btAnnuler.Location = new System.Drawing.Point(432, 361);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(75, 30);
            this.btAnnuler.TabIndex = 47;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            // 
            // txtBoxNomHotel
            // 
            this.txtBoxNomHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxNomHotel.Location = new System.Drawing.Point(285, 19);
            this.txtBoxNomHotel.Name = "txtBoxNomHotel";
            this.txtBoxNomHotel.Size = new System.Drawing.Size(263, 26);
            this.txtBoxNomHotel.TabIndex = 2;
            // 
            // maskedTxtBoxCpHotel
            // 
            this.maskedTxtBoxCpHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTxtBoxCpHotel.Location = new System.Drawing.Point(314, 160);
            this.maskedTxtBoxCpHotel.Mask = "99999";
            this.maskedTxtBoxCpHotel.Name = "maskedTxtBoxCpHotel";
            this.maskedTxtBoxCpHotel.Size = new System.Drawing.Size(59, 26);
            this.maskedTxtBoxCpHotel.TabIndex = 5;
            // 
            // comboBoxNbEtoileHotel
            // 
            this.comboBoxNbEtoileHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxNbEtoileHotel.FormattingEnabled = true;
            this.comboBoxNbEtoileHotel.Location = new System.Drawing.Point(369, 261);
            this.comboBoxNbEtoileHotel.Name = "comboBoxNbEtoileHotel";
            this.comboBoxNbEtoileHotel.Size = new System.Drawing.Size(121, 28);
            this.comboBoxNbEtoileHotel.TabIndex = 6;
            // 
            // maskedTxtBoxPrixHotel
            // 
            this.maskedTxtBoxPrixHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTxtBoxPrixHotel.Location = new System.Drawing.Point(263, 209);
            this.maskedTxtBoxPrixHotel.Mask = "999999";
            this.maskedTxtBoxPrixHotel.Name = "maskedTxtBoxPrixHotel";
            this.maskedTxtBoxPrixHotel.Size = new System.Drawing.Size(100, 26);
            this.maskedTxtBoxPrixHotel.TabIndex = 8;
            // 
            // lbPrixHotel
            // 
            this.lbPrixHotel.AutoSize = true;
            this.lbPrixHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbPrixHotel.Location = new System.Drawing.Point(204, 212);
            this.lbPrixHotel.Name = "lbPrixHotel";
            this.lbPrixHotel.Size = new System.Drawing.Size(53, 20);
            this.lbPrixHotel.TabIndex = 8;
            this.lbPrixHotel.Text = "Prix : ";
            // 
            // lbNbEtoileHotel
            // 
            this.lbNbEtoileHotel.AutoSize = true;
            this.lbNbEtoileHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNbEtoileHotel.Location = new System.Drawing.Point(204, 264);
            this.lbNbEtoileHotel.Name = "lbNbEtoileHotel";
            this.lbNbEtoileHotel.Size = new System.Drawing.Size(159, 20);
            this.lbNbEtoileHotel.TabIndex = 7;
            this.lbNbEtoileHotel.Text = "Nombres d\'étoiles : ";
            // 
            // lbCpHotel
            // 
            this.lbCpHotel.AutoSize = true;
            this.lbCpHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCpHotel.Location = new System.Drawing.Point(204, 160);
            this.lbCpHotel.Name = "lbCpHotel";
            this.lbCpHotel.Size = new System.Drawing.Size(113, 20);
            this.lbCpHotel.TabIndex = 6;
            this.lbCpHotel.Text = "Code postal : ";
            // 
            // lbAdresseHotel
            // 
            this.lbAdresseHotel.AutoSize = true;
            this.lbAdresseHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbAdresseHotel.Location = new System.Drawing.Point(204, 63);
            this.lbAdresseHotel.Name = "lbAdresseHotel";
            this.lbAdresseHotel.Size = new System.Drawing.Size(86, 20);
            this.lbAdresseHotel.TabIndex = 5;
            this.lbAdresseHotel.Text = "Adresse : ";
            // 
            // lbVilleHotel
            // 
            this.lbVilleHotel.AutoSize = true;
            this.lbVilleHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbVilleHotel.Location = new System.Drawing.Point(204, 109);
            this.lbVilleHotel.Name = "lbVilleHotel";
            this.lbVilleHotel.Size = new System.Drawing.Size(56, 20);
            this.lbVilleHotel.TabIndex = 4;
            this.lbVilleHotel.Text = "Ville : ";
            // 
            // lbNomHotel
            // 
            this.lbNomHotel.AutoSize = true;
            this.lbNomHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNomHotel.Location = new System.Drawing.Point(204, 22);
            this.lbNomHotel.Name = "lbNomHotel";
            this.lbNomHotel.Size = new System.Drawing.Size(59, 20);
            this.lbNomHotel.TabIndex = 3;
            this.lbNomHotel.Text = "Nom : ";
            // 
            // btSupprimerHotel
            // 
            this.btSupprimerHotel.BackColor = System.Drawing.Color.Red;
            this.btSupprimerHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btSupprimerHotel.Location = new System.Drawing.Point(208, 361);
            this.btSupprimerHotel.Name = "btSupprimerHotel";
            this.btSupprimerHotel.Size = new System.Drawing.Size(165, 30);
            this.btSupprimerHotel.TabIndex = 12;
            this.btSupprimerHotel.Text = "Supprimer Session";
            this.btSupprimerHotel.UseVisualStyleBackColor = false;
            // 
            // textBoxVilleHotel
            // 
            this.textBoxVilleHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxVilleHotel.Location = new System.Drawing.Point(266, 106);
            this.textBoxVilleHotel.Name = "textBoxVilleHotel";
            this.textBoxVilleHotel.Size = new System.Drawing.Size(263, 26);
            this.textBoxVilleHotel.TabIndex = 49;
            // 
            // textBoxAdresseHotel
            // 
            this.textBoxAdresseHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxAdresseHotel.Location = new System.Drawing.Point(296, 60);
            this.textBoxAdresseHotel.Name = "textBoxAdresseHotel";
            this.textBoxAdresseHotel.Size = new System.Drawing.Size(263, 26);
            this.textBoxAdresseHotel.TabIndex = 50;
            // 
            // FrmGestionHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlHotel);
            this.Name = "FrmGestionHotel";
            this.Text = "Gestion Hôtel";
            this.tabControlHotel.ResumeLayout(false);
            this.listSession.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotel)).EndInit();
            this.detailSession.ResumeLayout(false);
            this.detailSession.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlHotel;
        private System.Windows.Forms.TabPage listSession;
        private System.Windows.Forms.Button btAjouterHotel;
        private System.Windows.Forms.DataGridView dataGridViewHotel;
        private System.Windows.Forms.TabPage detailSession;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.TextBox txtBoxNomHotel;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxCpHotel;
        private System.Windows.Forms.ComboBox comboBoxNbEtoileHotel;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxPrixHotel;
        private System.Windows.Forms.Label lbPrixHotel;
        private System.Windows.Forms.Label lbNbEtoileHotel;
        private System.Windows.Forms.Label lbCpHotel;
        private System.Windows.Forms.Label lbAdresseHotel;
        private System.Windows.Forms.Label lbVilleHotel;
        private System.Windows.Forms.Label lbNomHotel;
        private System.Windows.Forms.Button btSupprimerHotel;
        private System.Windows.Forms.TextBox textBoxAdresseHotel;
        private System.Windows.Forms.TextBox textBoxVilleHotel;
    }
}