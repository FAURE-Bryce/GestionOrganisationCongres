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
            this.ListParticipationCongrssiste = new System.Windows.Forms.TabPage();
            this.lbMontantTotal = new System.Windows.Forms.Label();
            this.lbRestePayer = new System.Windows.Forms.Label();
            this.lbMontantTotalValue = new System.Windows.Forms.Label();
            this.lbRestePayerValeur = new System.Windows.Forms.Label();
            this.dataGridViewActiviteCongressiste = new System.Windows.Forms.DataGridView();
            this.lbActivite = new System.Windows.Forms.Label();
            this.btSupprimerInscriptionCongrssiste = new System.Windows.Forms.Button();
            this.btAjouterInscriptionCongrssiste = new System.Windows.Forms.Button();
            this.lbAjouterActiviteCongressiste = new System.Windows.Forms.Label();
            this.comboBoxActiviteCongressiste = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbAjouterSessionCongressiste = new System.Windows.Forms.Label();
            this.ActiviteCongressiste = new System.Windows.Forms.ComboBox();
            this.lbSession = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.ListCongressiste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListCongressiste)).BeginInit();
            this.DetailCongressiste.SuspendLayout();
            this.ListParticipationCongrssiste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiviteCongressiste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ListCongressiste);
            this.tabControl1.Controls.Add(this.DetailCongressiste);
            this.tabControl1.Controls.Add(this.ListParticipationCongrssiste);
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
            this.ListCongressiste.Text = "List Congressiste";
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
            this.DetailCongressiste.Text = "Detail Congressiste";
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
            // ListParticipationCongrssiste
            // 
            this.ListParticipationCongrssiste.Controls.Add(this.button1);
            this.ListParticipationCongrssiste.Controls.Add(this.button2);
            this.ListParticipationCongrssiste.Controls.Add(this.lbAjouterSessionCongressiste);
            this.ListParticipationCongrssiste.Controls.Add(this.ActiviteCongressiste);
            this.ListParticipationCongrssiste.Controls.Add(this.lbSession);
            this.ListParticipationCongrssiste.Controls.Add(this.dataGridView1);
            this.ListParticipationCongrssiste.Controls.Add(this.btSupprimerInscriptionCongrssiste);
            this.ListParticipationCongrssiste.Controls.Add(this.btAjouterInscriptionCongrssiste);
            this.ListParticipationCongrssiste.Controls.Add(this.lbAjouterActiviteCongressiste);
            this.ListParticipationCongrssiste.Controls.Add(this.comboBoxActiviteCongressiste);
            this.ListParticipationCongrssiste.Controls.Add(this.lbActivite);
            this.ListParticipationCongrssiste.Controls.Add(this.dataGridViewActiviteCongressiste);
            this.ListParticipationCongrssiste.Location = new System.Drawing.Point(4, 25);
            this.ListParticipationCongrssiste.Name = "ListParticipationCongrssiste";
            this.ListParticipationCongrssiste.Size = new System.Drawing.Size(768, 397);
            this.ListParticipationCongrssiste.TabIndex = 2;
            this.ListParticipationCongrssiste.Text = "Participation";
            this.ListParticipationCongrssiste.UseVisualStyleBackColor = true;
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
            // dataGridViewActiviteCongressiste
            // 
            this.dataGridViewActiviteCongressiste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActiviteCongressiste.Location = new System.Drawing.Point(17, 33);
            this.dataGridViewActiviteCongressiste.Name = "dataGridViewActiviteCongressiste";
            this.dataGridViewActiviteCongressiste.RowHeadersWidth = 51;
            this.dataGridViewActiviteCongressiste.RowTemplate.Height = 24;
            this.dataGridViewActiviteCongressiste.Size = new System.Drawing.Size(343, 275);
            this.dataGridViewActiviteCongressiste.TabIndex = 0;
            // 
            // lbActivite
            // 
            this.lbActivite.AutoSize = true;
            this.lbActivite.Location = new System.Drawing.Point(14, 14);
            this.lbActivite.Name = "lbActivite";
            this.lbActivite.Size = new System.Drawing.Size(66, 16);
            this.lbActivite.TabIndex = 1;
            this.lbActivite.Text = "Activités : ";
            // 
            // btSupprimerInscriptionCongrssiste
            // 
            this.btSupprimerInscriptionCongrssiste.Location = new System.Drawing.Point(69, 356);
            this.btSupprimerInscriptionCongrssiste.Name = "btSupprimerInscriptionCongrssiste";
            this.btSupprimerInscriptionCongrssiste.Size = new System.Drawing.Size(86, 23);
            this.btSupprimerInscriptionCongrssiste.TabIndex = 18;
            this.btSupprimerInscriptionCongrssiste.Text = "Supprimer";
            this.btSupprimerInscriptionCongrssiste.UseVisualStyleBackColor = true;
            // 
            // btAjouterInscriptionCongrssiste
            // 
            this.btAjouterInscriptionCongrssiste.Location = new System.Drawing.Point(196, 356);
            this.btAjouterInscriptionCongrssiste.Name = "btAjouterInscriptionCongrssiste";
            this.btAjouterInscriptionCongrssiste.Size = new System.Drawing.Size(86, 23);
            this.btAjouterInscriptionCongrssiste.TabIndex = 17;
            this.btAjouterInscriptionCongrssiste.Text = "Ajouter";
            this.btAjouterInscriptionCongrssiste.UseVisualStyleBackColor = true;
            // 
            // lbAjouterActiviteCongressiste
            // 
            this.lbAjouterActiviteCongressiste.AutoSize = true;
            this.lbAjouterActiviteCongressiste.Location = new System.Drawing.Point(45, 325);
            this.lbAjouterActiviteCongressiste.Name = "lbAjouterActiviteCongressiste";
            this.lbAjouterActiviteCongressiste.Size = new System.Drawing.Size(104, 16);
            this.lbAjouterActiviteCongressiste.TabIndex = 19;
            this.lbAjouterActiviteCongressiste.Text = "Ajouter Activité : ";
            // 
            // comboBoxActiviteCongressiste
            // 
            this.comboBoxActiviteCongressiste.FormattingEnabled = true;
            this.comboBoxActiviteCongressiste.Location = new System.Drawing.Point(161, 322);
            this.comboBoxActiviteCongressiste.Name = "comboBoxActiviteCongressiste";
            this.comboBoxActiviteCongressiste.Size = new System.Drawing.Size(167, 24);
            this.comboBoxActiviteCongressiste.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(591, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lbAjouterSessionCongressiste
            // 
            this.lbAjouterSessionCongressiste.AutoSize = true;
            this.lbAjouterSessionCongressiste.Location = new System.Drawing.Point(440, 325);
            this.lbAjouterSessionCongressiste.Name = "lbAjouterSessionCongressiste";
            this.lbAjouterSessionCongressiste.Size = new System.Drawing.Size(110, 16);
            this.lbAjouterSessionCongressiste.TabIndex = 25;
            this.lbAjouterSessionCongressiste.Text = "Ajouter Session : ";
            // 
            // ActiviteCongressiste
            // 
            this.ActiviteCongressiste.FormattingEnabled = true;
            this.ActiviteCongressiste.Location = new System.Drawing.Point(556, 322);
            this.ActiviteCongressiste.Name = "ActiviteCongressiste";
            this.ActiviteCongressiste.Size = new System.Drawing.Size(167, 24);
            this.ActiviteCongressiste.TabIndex = 22;
            // 
            // lbSession
            // 
            this.lbSession.AutoSize = true;
            this.lbSession.Location = new System.Drawing.Point(409, 14);
            this.lbSession.Name = "lbSession";
            this.lbSession.Size = new System.Drawing.Size(65, 16);
            this.lbSession.TabIndex = 21;
            this.lbSession.Text = "Session : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(412, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(343, 275);
            this.dataGridView1.TabIndex = 20;
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
            this.ListParticipationCongrssiste.ResumeLayout(false);
            this.ListParticipationCongrssiste.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiviteCongressiste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DetailCongressiste;
        private System.Windows.Forms.TabPage ListParticipationCongrssiste;
        private System.Windows.Forms.TabPage ListCongressiste;
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
        private System.Windows.Forms.DataGridView dataGridViewActiviteCongressiste;
        private System.Windows.Forms.Label lbActivite;
        private System.Windows.Forms.Button btSupprimerInscriptionCongrssiste;
        private System.Windows.Forms.Button btAjouterInscriptionCongrssiste;
        private System.Windows.Forms.Label lbAjouterActiviteCongressiste;
        private System.Windows.Forms.ComboBox comboBoxActiviteCongressiste;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbAjouterSessionCongressiste;
        private System.Windows.Forms.ComboBox ActiviteCongressiste;
        private System.Windows.Forms.Label lbSession;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}