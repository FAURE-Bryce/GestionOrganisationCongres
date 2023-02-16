namespace GestionOrganisationCongres
{
    partial class FrmGestionInscriptions
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ListCongressiste = new System.Windows.Forms.TabPage();
            this.btAjouterCongressiste = new System.Windows.Forms.Button();
            this.dataGridViewListCongressiste = new System.Windows.Forms.DataGridView();
            this.DetailCongressiste = new System.Windows.Forms.TabPage();
            this.btValider = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.maskedTxtBoxAcompteCongressiste = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxLigueCongressiste = new System.Windows.Forms.ComboBox();
            this.textBoxVilleCongressiste = new System.Windows.Forms.TextBox();
            this.textBoxAdresseCongressiste = new System.Windows.Forms.TextBox();
            this.textBoxPrenomCongressiste = new System.Windows.Forms.TextBox();
            this.lbHotelCongressiste = new System.Windows.Forms.Label();
            this.lbLigueCongressiste = new System.Windows.Forms.Label();
            this.lbAcompteCongressiste = new System.Windows.Forms.Label();
            this.comboBoxHotelCongressiste = new System.Windows.Forms.ComboBox();
            this.txtBoxNomCongressiste = new System.Windows.Forms.TextBox();
            this.maskedTxtBoxCpCongressiste = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtBoxTelCongressiste = new System.Windows.Forms.MaskedTextBox();
            this.lbCpCongressiste = new System.Windows.Forms.Label();
            this.lbTelCongressiste = new System.Windows.Forms.Label();
            this.lbVilleCongressiste = new System.Windows.Forms.Label();
            this.lbPrenomCongressiste = new System.Windows.Forms.Label();
            this.lbAdresseCongressiste = new System.Windows.Forms.Label();
            this.lbNomCongressiste = new System.Windows.Forms.Label();
            this.btSupprimerCongressiste = new System.Windows.Forms.Button();
            this.ListInscritsSession = new System.Windows.Forms.TabPage();
            this.DetailInscriptionsSession = new System.Windows.Forms.TabPage();
            this.DetailInscriptionsActivites = new System.Windows.Forms.TabPage();
            this.ListInscriptionsActivites = new System.Windows.Forms.TabPage();
            this.lbMontantTotal = new System.Windows.Forms.Label();
            this.lbRestePayer = new System.Windows.Forms.Label();
            this.lbMontantTotalValue = new System.Windows.Forms.Label();
            this.lbRestePayerValeur = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.ListCongressiste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListCongressiste)).BeginInit();
            this.DetailCongressiste.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ListCongressiste);
            this.tabControl1.Controls.Add(this.DetailCongressiste);
            this.tabControl1.Controls.Add(this.ListInscritsSession);
            this.tabControl1.Controls.Add(this.DetailInscriptionsSession);
            this.tabControl1.Controls.Add(this.DetailInscriptionsActivites);
            this.tabControl1.Controls.Add(this.ListInscriptionsActivites);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // ListCongressiste
            // 
            this.ListCongressiste.Controls.Add(this.btAjouterCongressiste);
            this.ListCongressiste.Controls.Add(this.dataGridViewListCongressiste);
            this.ListCongressiste.Location = new System.Drawing.Point(4, 25);
            this.ListCongressiste.Name = "ListCongressiste";
            this.ListCongressiste.Size = new System.Drawing.Size(768, 397);
            this.ListCongressiste.TabIndex = 4;
            this.ListCongressiste.Text = "List Congre";
            this.ListCongressiste.UseVisualStyleBackColor = true;
            // 
            // btAjouterCongressiste
            // 
            this.btAjouterCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btAjouterCongressiste.Location = new System.Drawing.Point(282, 358);
            this.btAjouterCongressiste.Name = "btAjouterCongressiste";
            this.btAjouterCongressiste.Size = new System.Drawing.Size(207, 30);
            this.btAjouterCongressiste.TabIndex = 3;
            this.btAjouterCongressiste.Text = "Ajouter Congressiste";
            this.btAjouterCongressiste.UseVisualStyleBackColor = true;
            // 
            // dataGridViewListCongressiste
            // 
            this.dataGridViewListCongressiste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListCongressiste.Location = new System.Drawing.Point(5, 9);
            this.dataGridViewListCongressiste.Name = "dataGridViewListCongressiste";
            this.dataGridViewListCongressiste.RowHeadersWidth = 51;
            this.dataGridViewListCongressiste.RowTemplate.Height = 24;
            this.dataGridViewListCongressiste.Size = new System.Drawing.Size(759, 335);
            this.dataGridViewListCongressiste.TabIndex = 2;
            // 
            // DetailCongressiste
            // 
            this.DetailCongressiste.Controls.Add(this.lbRestePayerValeur);
            this.DetailCongressiste.Controls.Add(this.lbMontantTotalValue);
            this.DetailCongressiste.Controls.Add(this.lbRestePayer);
            this.DetailCongressiste.Controls.Add(this.lbMontantTotal);
            this.DetailCongressiste.Controls.Add(this.btValider);
            this.DetailCongressiste.Controls.Add(this.btAnnuler);
            this.DetailCongressiste.Controls.Add(this.maskedTxtBoxAcompteCongressiste);
            this.DetailCongressiste.Controls.Add(this.comboBoxLigueCongressiste);
            this.DetailCongressiste.Controls.Add(this.textBoxVilleCongressiste);
            this.DetailCongressiste.Controls.Add(this.textBoxAdresseCongressiste);
            this.DetailCongressiste.Controls.Add(this.textBoxPrenomCongressiste);
            this.DetailCongressiste.Controls.Add(this.lbHotelCongressiste);
            this.DetailCongressiste.Controls.Add(this.lbLigueCongressiste);
            this.DetailCongressiste.Controls.Add(this.lbAcompteCongressiste);
            this.DetailCongressiste.Controls.Add(this.comboBoxHotelCongressiste);
            this.DetailCongressiste.Controls.Add(this.txtBoxNomCongressiste);
            this.DetailCongressiste.Controls.Add(this.maskedTxtBoxCpCongressiste);
            this.DetailCongressiste.Controls.Add(this.maskedTxtBoxTelCongressiste);
            this.DetailCongressiste.Controls.Add(this.lbCpCongressiste);
            this.DetailCongressiste.Controls.Add(this.lbTelCongressiste);
            this.DetailCongressiste.Controls.Add(this.lbVilleCongressiste);
            this.DetailCongressiste.Controls.Add(this.lbPrenomCongressiste);
            this.DetailCongressiste.Controls.Add(this.lbAdresseCongressiste);
            this.DetailCongressiste.Controls.Add(this.lbNomCongressiste);
            this.DetailCongressiste.Controls.Add(this.btSupprimerCongressiste);
            this.DetailCongressiste.Location = new System.Drawing.Point(4, 25);
            this.DetailCongressiste.Name = "DetailCongressiste";
            this.DetailCongressiste.Padding = new System.Windows.Forms.Padding(3);
            this.DetailCongressiste.Size = new System.Drawing.Size(768, 397);
            this.DetailCongressiste.TabIndex = 1;
            this.DetailCongressiste.Text = "Detail Congre";
            this.DetailCongressiste.UseVisualStyleBackColor = true;
            // 
            // btValider
            // 
            this.btValider.BackColor = System.Drawing.Color.LawnGreen;
            this.btValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btValider.Location = new System.Drawing.Point(276, 329);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(75, 30);
            this.btValider.TabIndex = 45;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = false;
            // 
            // btAnnuler
            // 
            this.btAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btAnnuler.Location = new System.Drawing.Point(500, 329);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(75, 30);
            this.btAnnuler.TabIndex = 44;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            // 
            // maskedTxtBoxAcompteCongressiste
            // 
            this.maskedTxtBoxAcompteCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTxtBoxAcompteCongressiste.Location = new System.Drawing.Point(312, 214);
            this.maskedTxtBoxAcompteCongressiste.Mask = "99999";
            this.maskedTxtBoxAcompteCongressiste.Name = "maskedTxtBoxAcompteCongressiste";
            this.maskedTxtBoxAcompteCongressiste.Size = new System.Drawing.Size(60, 26);
            this.maskedTxtBoxAcompteCongressiste.TabIndex = 43;
            // 
            // comboBoxLigueCongressiste
            // 
            this.comboBoxLigueCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxLigueCongressiste.FormattingEnabled = true;
            this.comboBoxLigueCongressiste.Location = new System.Drawing.Point(312, 276);
            this.comboBoxLigueCongressiste.Name = "comboBoxLigueCongressiste";
            this.comboBoxLigueCongressiste.Size = new System.Drawing.Size(143, 28);
            this.comboBoxLigueCongressiste.TabIndex = 42;
            // 
            // textBoxVilleCongressiste
            // 
            this.textBoxVilleCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxVilleCongressiste.Location = new System.Drawing.Point(312, 117);
            this.textBoxVilleCongressiste.Name = "textBoxVilleCongressiste";
            this.textBoxVilleCongressiste.Size = new System.Drawing.Size(263, 26);
            this.textBoxVilleCongressiste.TabIndex = 41;
            // 
            // textBoxAdresseCongressiste
            // 
            this.textBoxAdresseCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxAdresseCongressiste.Location = new System.Drawing.Point(312, 85);
            this.textBoxAdresseCongressiste.Name = "textBoxAdresseCongressiste";
            this.textBoxAdresseCongressiste.Size = new System.Drawing.Size(263, 26);
            this.textBoxAdresseCongressiste.TabIndex = 40;
            // 
            // textBoxPrenomCongressiste
            // 
            this.textBoxPrenomCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxPrenomCongressiste.Location = new System.Drawing.Point(312, 53);
            this.textBoxPrenomCongressiste.Name = "textBoxPrenomCongressiste";
            this.textBoxPrenomCongressiste.Size = new System.Drawing.Size(263, 26);
            this.textBoxPrenomCongressiste.TabIndex = 39;
            // 
            // lbHotelCongressiste
            // 
            this.lbHotelCongressiste.AutoSize = true;
            this.lbHotelCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbHotelCongressiste.Location = new System.Drawing.Point(242, 249);
            this.lbHotelCongressiste.Name = "lbHotelCongressiste";
            this.lbHotelCongressiste.Size = new System.Drawing.Size(64, 20);
            this.lbHotelCongressiste.TabIndex = 38;
            this.lbHotelCongressiste.Text = "Hotel : ";
            // 
            // lbLigueCongressiste
            // 
            this.lbLigueCongressiste.AutoSize = true;
            this.lbLigueCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbLigueCongressiste.Location = new System.Drawing.Point(241, 279);
            this.lbLigueCongressiste.Name = "lbLigueCongressiste";
            this.lbLigueCongressiste.Size = new System.Drawing.Size(65, 20);
            this.lbLigueCongressiste.TabIndex = 37;
            this.lbLigueCongressiste.Text = "Ligue : ";
            // 
            // lbAcompteCongressiste
            // 
            this.lbAcompteCongressiste.AutoSize = true;
            this.lbAcompteCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbAcompteCongressiste.Location = new System.Drawing.Point(216, 217);
            this.lbAcompteCongressiste.Name = "lbAcompteCongressiste";
            this.lbAcompteCongressiste.Size = new System.Drawing.Size(90, 20);
            this.lbAcompteCongressiste.TabIndex = 36;
            this.lbAcompteCongressiste.Text = "Acompte : ";
            // 
            // comboBoxHotelCongressiste
            // 
            this.comboBoxHotelCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxHotelCongressiste.FormattingEnabled = true;
            this.comboBoxHotelCongressiste.Location = new System.Drawing.Point(312, 246);
            this.comboBoxHotelCongressiste.Name = "comboBoxHotelCongressiste";
            this.comboBoxHotelCongressiste.Size = new System.Drawing.Size(143, 28);
            this.comboBoxHotelCongressiste.TabIndex = 22;
            // 
            // txtBoxNomCongressiste
            // 
            this.txtBoxNomCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxNomCongressiste.Location = new System.Drawing.Point(312, 21);
            this.txtBoxNomCongressiste.Name = "txtBoxNomCongressiste";
            this.txtBoxNomCongressiste.Size = new System.Drawing.Size(263, 26);
            this.txtBoxNomCongressiste.TabIndex = 20;
            // 
            // maskedTxtBoxCpCongressiste
            // 
            this.maskedTxtBoxCpCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTxtBoxCpCongressiste.Location = new System.Drawing.Point(312, 151);
            this.maskedTxtBoxCpCongressiste.Mask = "99999";
            this.maskedTxtBoxCpCongressiste.Name = "maskedTxtBoxCpCongressiste";
            this.maskedTxtBoxCpCongressiste.Size = new System.Drawing.Size(60, 26);
            this.maskedTxtBoxCpCongressiste.TabIndex = 25;
            // 
            // maskedTxtBoxTelCongressiste
            // 
            this.maskedTxtBoxTelCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTxtBoxTelCongressiste.Location = new System.Drawing.Point(312, 183);
            this.maskedTxtBoxTelCongressiste.Mask = "9999999999";
            this.maskedTxtBoxTelCongressiste.Name = "maskedTxtBoxTelCongressiste";
            this.maskedTxtBoxTelCongressiste.Size = new System.Drawing.Size(100, 26);
            this.maskedTxtBoxTelCongressiste.TabIndex = 30;
            // 
            // lbCpCongressiste
            // 
            this.lbCpCongressiste.AutoSize = true;
            this.lbCpCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCpCongressiste.Location = new System.Drawing.Point(194, 154);
            this.lbCpCongressiste.Name = "lbCpCongressiste";
            this.lbCpCongressiste.Size = new System.Drawing.Size(113, 20);
            this.lbCpCongressiste.TabIndex = 31;
            this.lbCpCongressiste.Text = "Code postal : ";
            // 
            // lbTelCongressiste
            // 
            this.lbTelCongressiste.AutoSize = true;
            this.lbTelCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTelCongressiste.Location = new System.Drawing.Point(205, 186);
            this.lbTelCongressiste.Name = "lbTelCongressiste";
            this.lbTelCongressiste.Size = new System.Drawing.Size(101, 20);
            this.lbTelCongressiste.TabIndex = 29;
            this.lbTelCongressiste.Text = "Téléphone : ";
            // 
            // lbVilleCongressiste
            // 
            this.lbVilleCongressiste.AutoSize = true;
            this.lbVilleCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbVilleCongressiste.Location = new System.Drawing.Point(251, 120);
            this.lbVilleCongressiste.Name = "lbVilleCongressiste";
            this.lbVilleCongressiste.Size = new System.Drawing.Size(56, 20);
            this.lbVilleCongressiste.TabIndex = 27;
            this.lbVilleCongressiste.Text = "Ville : ";
            // 
            // lbPrenomCongressiste
            // 
            this.lbPrenomCongressiste.AutoSize = true;
            this.lbPrenomCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbPrenomCongressiste.Location = new System.Drawing.Point(231, 56);
            this.lbPrenomCongressiste.Name = "lbPrenomCongressiste";
            this.lbPrenomCongressiste.Size = new System.Drawing.Size(82, 20);
            this.lbPrenomCongressiste.TabIndex = 26;
            this.lbPrenomCongressiste.Text = "Prenom : ";
            // 
            // lbAdresseCongressiste
            // 
            this.lbAdresseCongressiste.AutoSize = true;
            this.lbAdresseCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbAdresseCongressiste.Location = new System.Drawing.Point(223, 88);
            this.lbAdresseCongressiste.Name = "lbAdresseCongressiste";
            this.lbAdresseCongressiste.Size = new System.Drawing.Size(86, 20);
            this.lbAdresseCongressiste.TabIndex = 24;
            this.lbAdresseCongressiste.Text = "Adresse : ";
            // 
            // lbNomCongressiste
            // 
            this.lbNomCongressiste.AutoSize = true;
            this.lbNomCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNomCongressiste.Location = new System.Drawing.Point(250, 24);
            this.lbNomCongressiste.Name = "lbNomCongressiste";
            this.lbNomCongressiste.Size = new System.Drawing.Size(59, 20);
            this.lbNomCongressiste.TabIndex = 21;
            this.lbNomCongressiste.Text = "Nom : ";
            // 
            // btSupprimerCongressiste
            // 
            this.btSupprimerCongressiste.BackColor = System.Drawing.Color.Red;
            this.btSupprimerCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btSupprimerCongressiste.Location = new System.Drawing.Point(299, 329);
            this.btSupprimerCongressiste.Name = "btSupprimerCongressiste";
            this.btSupprimerCongressiste.Size = new System.Drawing.Size(218, 30);
            this.btSupprimerCongressiste.TabIndex = 35;
            this.btSupprimerCongressiste.Text = "Supprimer Congressiste";
            this.btSupprimerCongressiste.UseVisualStyleBackColor = false;
            // 
            // ListInscritsSession
            // 
            this.ListInscritsSession.Location = new System.Drawing.Point(4, 25);
            this.ListInscritsSession.Name = "ListInscritsSession";
            this.ListInscritsSession.Size = new System.Drawing.Size(768, 397);
            this.ListInscritsSession.TabIndex = 2;
            this.ListInscritsSession.Text = "List Inscrits Session";
            this.ListInscritsSession.UseVisualStyleBackColor = true;
            // 
            // DetailInscriptionsSession
            // 
            this.DetailInscriptionsSession.Location = new System.Drawing.Point(4, 25);
            this.DetailInscriptionsSession.Name = "DetailInscriptionsSession";
            this.DetailInscriptionsSession.Size = new System.Drawing.Size(768, 397);
            this.DetailInscriptionsSession.TabIndex = 5;
            this.DetailInscriptionsSession.Text = "Detail Inscriptions Session";
            this.DetailInscriptionsSession.UseVisualStyleBackColor = true;
            // 
            // DetailInscriptionsActivites
            // 
            this.DetailInscriptionsActivites.Location = new System.Drawing.Point(4, 25);
            this.DetailInscriptionsActivites.Name = "DetailInscriptionsActivites";
            this.DetailInscriptionsActivites.Size = new System.Drawing.Size(768, 397);
            this.DetailInscriptionsActivites.TabIndex = 3;
            this.DetailInscriptionsActivites.Text = "Detail Inscriptions Acti";
            this.DetailInscriptionsActivites.UseVisualStyleBackColor = true;
            // 
            // ListInscriptionsActivites
            // 
            this.ListInscriptionsActivites.Location = new System.Drawing.Point(4, 25);
            this.ListInscriptionsActivites.Name = "ListInscriptionsActivites";
            this.ListInscriptionsActivites.Padding = new System.Windows.Forms.Padding(3);
            this.ListInscriptionsActivites.Size = new System.Drawing.Size(768, 397);
            this.ListInscriptionsActivites.TabIndex = 0;
            this.ListInscriptionsActivites.Text = "List Inscriptions Acti";
            this.ListInscriptionsActivites.UseVisualStyleBackColor = true;
            // 
            // lbMontantTotal
            // 
            this.lbMontantTotal.AutoSize = true;
            this.lbMontantTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbMontantTotal.Location = new System.Drawing.Point(6, 254);
            this.lbMontantTotal.Name = "lbMontantTotal";
            this.lbMontantTotal.Size = new System.Drawing.Size(126, 20);
            this.lbMontantTotal.TabIndex = 46;
            this.lbMontantTotal.Text = "Montant Total : ";
            // 
            // lbRestePayer
            // 
            this.lbRestePayer.AutoSize = true;
            this.lbRestePayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbRestePayer.Location = new System.Drawing.Point(6, 284);
            this.lbRestePayer.Name = "lbRestePayer";
            this.lbRestePayer.Size = new System.Drawing.Size(128, 20);
            this.lbRestePayer.TabIndex = 47;
            this.lbRestePayer.Text = "Reste à payer : ";
            // 
            // lbMontantTotalValue
            // 
            this.lbMontantTotalValue.AutoSize = true;
            this.lbMontantTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbMontantTotalValue.Location = new System.Drawing.Point(138, 254);
            this.lbMontantTotalValue.Name = "lbMontantTotalValue";
            this.lbMontantTotalValue.Size = new System.Drawing.Size(15, 20);
            this.lbMontantTotalValue.TabIndex = 48;
            this.lbMontantTotalValue.Text = "-";
            // 
            // lbRestePayerValeur
            // 
            this.lbRestePayerValeur.AutoSize = true;
            this.lbRestePayerValeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbRestePayerValeur.Location = new System.Drawing.Point(140, 284);
            this.lbRestePayerValeur.Name = "lbRestePayerValeur";
            this.lbRestePayerValeur.Size = new System.Drawing.Size(15, 20);
            this.lbRestePayerValeur.TabIndex = 49;
            this.lbRestePayerValeur.Text = "-";
            // 
            // FrmGestionInscriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmGestionInscriptions";
            this.Text = "Gestion Inscriptions";
            this.tabControl1.ResumeLayout(false);
            this.ListCongressiste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListCongressiste)).EndInit();
            this.DetailCongressiste.ResumeLayout(false);
            this.DetailCongressiste.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ListInscriptionsActivites;
        private System.Windows.Forms.TabPage DetailCongressiste;
        private System.Windows.Forms.TabPage ListInscritsSession;
        private System.Windows.Forms.TabPage DetailInscriptionsActivites;
        private System.Windows.Forms.TabPage ListCongressiste;
        private System.Windows.Forms.TabPage DetailInscriptionsSession;
        private System.Windows.Forms.Button btAjouterCongressiste;
        private System.Windows.Forms.DataGridView dataGridViewListCongressiste;
        private System.Windows.Forms.ComboBox comboBoxHotelCongressiste;
        private System.Windows.Forms.TextBox txtBoxNomCongressiste;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxCpCongressiste;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxTelCongressiste;
        private System.Windows.Forms.Label lbCpCongressiste;
        private System.Windows.Forms.Label lbTelCongressiste;
        private System.Windows.Forms.Label lbVilleCongressiste;
        private System.Windows.Forms.Label lbPrenomCongressiste;
        private System.Windows.Forms.Label lbAdresseCongressiste;
        private System.Windows.Forms.Label lbNomCongressiste;
        private System.Windows.Forms.Button btSupprimerCongressiste;
        private System.Windows.Forms.Label lbHotelCongressiste;
        private System.Windows.Forms.Label lbLigueCongressiste;
        private System.Windows.Forms.Label lbAcompteCongressiste;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxAcompteCongressiste;
        private System.Windows.Forms.ComboBox comboBoxLigueCongressiste;
        private System.Windows.Forms.TextBox textBoxVilleCongressiste;
        private System.Windows.Forms.TextBox textBoxAdresseCongressiste;
        private System.Windows.Forms.TextBox textBoxPrenomCongressiste;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Label lbRestePayerValeur;
        private System.Windows.Forms.Label lbMontantTotalValue;
        private System.Windows.Forms.Label lbRestePayer;
        private System.Windows.Forms.Label lbMontantTotal;
    }
}