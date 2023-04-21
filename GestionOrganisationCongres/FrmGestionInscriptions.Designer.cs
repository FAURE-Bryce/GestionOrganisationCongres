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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ListeCongressistes = new System.Windows.Forms.TabPage();
            this.btAjouterCongressiste = new System.Windows.Forms.Button();
            this.dataGridViewListCongressiste = new System.Windows.Forms.DataGridView();
            this.DetailsCongressiste = new System.Windows.Forms.TabPage();
            this.lbRestePayerValeur = new System.Windows.Forms.Label();
            this.lbMontantTotalValue = new System.Windows.Forms.Label();
            this.lblRestePayer = new System.Windows.Forms.Label();
            this.lblMontantTotal = new System.Windows.Forms.Label();
            this.btValiderModifCongressiste = new System.Windows.Forms.Button();
            this.btAnnulerModifCongressiste = new System.Windows.Forms.Button();
            this.maskedTxtBoxAcompteCongressiste = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxLigueCongressiste = new System.Windows.Forms.ComboBox();
            this.txtBoxVilleCongressiste = new System.Windows.Forms.TextBox();
            this.txtBoxAdresseCongressiste = new System.Windows.Forms.TextBox();
            this.txtBoxPrenomCongressiste = new System.Windows.Forms.TextBox();
            this.lblHotelCongressiste = new System.Windows.Forms.Label();
            this.lblLigueCongressiste = new System.Windows.Forms.Label();
            this.lblAcompteCongressiste = new System.Windows.Forms.Label();
            this.comboBoxHotelCongressiste = new System.Windows.Forms.ComboBox();
            this.txtBoxNomCongressiste = new System.Windows.Forms.TextBox();
            this.maskedTxtBoxCpCongressiste = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtBoxTelCongressiste = new System.Windows.Forms.MaskedTextBox();
            this.lblCpCongressiste = new System.Windows.Forms.Label();
            this.lblTelCongressiste = new System.Windows.Forms.Label();
            this.lblVilleCongressiste = new System.Windows.Forms.Label();
            this.lblPrenomCongressiste = new System.Windows.Forms.Label();
            this.lblAdresseCongressiste = new System.Windows.Forms.Label();
            this.lblNomCongressiste = new System.Windows.Forms.Label();
            this.btSupprimerCongressiste = new System.Windows.Forms.Button();
            this.ListeParticipations = new System.Windows.Forms.TabPage();
            this.btSupprimerSessionCongressiste = new System.Windows.Forms.Button();
            this.btAjouterSessionCongressiste = new System.Windows.Forms.Button();
            this.lbAjouterSessionCongressiste = new System.Windows.Forms.Label();
            this.comboBoxAjouterSessionCongressiste = new System.Windows.Forms.ComboBox();
            this.lblSession = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btSupprimerActiviteCongressiste = new System.Windows.Forms.Button();
            this.btAjouterActiviteCongressiste = new System.Windows.Forms.Button();
            this.lbAjouterActiviteCongressiste = new System.Windows.Forms.Label();
            this.comboBoxAjouterActiviteCongressiste = new System.Windows.Forms.ComboBox();
            this.lblActivite = new System.Windows.Forms.Label();
            this.dataGridViewActiviteCongressiste = new System.Windows.Forms.DataGridView();
            this.bindSrcInscriptions = new System.Windows.Forms.BindingSource(this.components);
            this.numInscriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acompteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idHotelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLigueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activitesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.ListeCongressistes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListCongressiste)).BeginInit();
            this.DetailsCongressiste.SuspendLayout();
            this.ListeParticipations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiviteCongressiste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcInscriptions)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ListeCongressistes);
            this.tabControl1.Controls.Add(this.DetailsCongressiste);
            this.tabControl1.Controls.Add(this.ListeParticipations);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(582, 346);
            this.tabControl1.TabIndex = 0;
            // 
            // ListeCongressistes
            // 
            this.ListeCongressistes.Controls.Add(this.btAjouterCongressiste);
            this.ListeCongressistes.Controls.Add(this.dataGridViewListCongressiste);
            this.ListeCongressistes.Location = new System.Drawing.Point(4, 22);
            this.ListeCongressistes.Margin = new System.Windows.Forms.Padding(2);
            this.ListeCongressistes.Name = "ListeCongressistes";
            this.ListeCongressistes.Size = new System.Drawing.Size(574, 320);
            this.ListeCongressistes.TabIndex = 4;
            this.ListeCongressistes.Text = "Liste";
            this.ListeCongressistes.UseVisualStyleBackColor = true;
            // 
            // btAjouterCongressiste
            // 
            this.btAjouterCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btAjouterCongressiste.Location = new System.Drawing.Point(178, 294);
            this.btAjouterCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.btAjouterCongressiste.Name = "btAjouterCongressiste";
            this.btAjouterCongressiste.Size = new System.Drawing.Size(155, 24);
            this.btAjouterCongressiste.TabIndex = 3;
            this.btAjouterCongressiste.Text = "Ajouter un congressiste";
            this.btAjouterCongressiste.UseVisualStyleBackColor = true;
            // 
            // dataGridViewListCongressiste
            // 
            this.dataGridViewListCongressiste.AllowUserToAddRows = false;
            this.dataGridViewListCongressiste.AllowUserToDeleteRows = false;
            this.dataGridViewListCongressiste.AutoGenerateColumns = false;
            this.dataGridViewListCongressiste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListCongressiste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numInscriptionDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.cpDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.acompteDataGridViewTextBoxColumn,
            this.idHotelDataGridViewTextBoxColumn,
            this.idLigueDataGridViewTextBoxColumn,
            this.hotelDataGridViewTextBoxColumn,
            this.activitesDataGridViewTextBoxColumn,
            this.sessionsDataGridViewTextBoxColumn});
            this.dataGridViewListCongressiste.DataSource = this.bindSrcInscriptions;
            this.dataGridViewListCongressiste.Location = new System.Drawing.Point(4, 7);
            this.dataGridViewListCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewListCongressiste.Name = "dataGridViewListCongressiste";
            this.dataGridViewListCongressiste.ReadOnly = true;
            this.dataGridViewListCongressiste.RowHeadersWidth = 51;
            this.dataGridViewListCongressiste.RowTemplate.Height = 24;
            this.dataGridViewListCongressiste.Size = new System.Drawing.Size(569, 272);
            this.dataGridViewListCongressiste.TabIndex = 2;
            // 
            // DetailsCongressiste
            // 
            this.DetailsCongressiste.Controls.Add(this.lbRestePayerValeur);
            this.DetailsCongressiste.Controls.Add(this.lbMontantTotalValue);
            this.DetailsCongressiste.Controls.Add(this.lblRestePayer);
            this.DetailsCongressiste.Controls.Add(this.lblMontantTotal);
            this.DetailsCongressiste.Controls.Add(this.btValiderModifCongressiste);
            this.DetailsCongressiste.Controls.Add(this.btAnnulerModifCongressiste);
            this.DetailsCongressiste.Controls.Add(this.maskedTxtBoxAcompteCongressiste);
            this.DetailsCongressiste.Controls.Add(this.comboBoxLigueCongressiste);
            this.DetailsCongressiste.Controls.Add(this.txtBoxVilleCongressiste);
            this.DetailsCongressiste.Controls.Add(this.txtBoxAdresseCongressiste);
            this.DetailsCongressiste.Controls.Add(this.txtBoxPrenomCongressiste);
            this.DetailsCongressiste.Controls.Add(this.lblHotelCongressiste);
            this.DetailsCongressiste.Controls.Add(this.lblLigueCongressiste);
            this.DetailsCongressiste.Controls.Add(this.lblAcompteCongressiste);
            this.DetailsCongressiste.Controls.Add(this.comboBoxHotelCongressiste);
            this.DetailsCongressiste.Controls.Add(this.txtBoxNomCongressiste);
            this.DetailsCongressiste.Controls.Add(this.maskedTxtBoxCpCongressiste);
            this.DetailsCongressiste.Controls.Add(this.maskedTxtBoxTelCongressiste);
            this.DetailsCongressiste.Controls.Add(this.lblCpCongressiste);
            this.DetailsCongressiste.Controls.Add(this.lblTelCongressiste);
            this.DetailsCongressiste.Controls.Add(this.lblVilleCongressiste);
            this.DetailsCongressiste.Controls.Add(this.lblPrenomCongressiste);
            this.DetailsCongressiste.Controls.Add(this.lblAdresseCongressiste);
            this.DetailsCongressiste.Controls.Add(this.lblNomCongressiste);
            this.DetailsCongressiste.Controls.Add(this.btSupprimerCongressiste);
            this.DetailsCongressiste.Location = new System.Drawing.Point(4, 22);
            this.DetailsCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.DetailsCongressiste.Name = "DetailsCongressiste";
            this.DetailsCongressiste.Padding = new System.Windows.Forms.Padding(2);
            this.DetailsCongressiste.Size = new System.Drawing.Size(574, 320);
            this.DetailsCongressiste.TabIndex = 1;
            this.DetailsCongressiste.Text = "Détails";
            this.DetailsCongressiste.UseVisualStyleBackColor = true;
            // 
            // lbRestePayerValeur
            // 
            this.lbRestePayerValeur.AutoSize = true;
            this.lbRestePayerValeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbRestePayerValeur.Location = new System.Drawing.Point(105, 231);
            this.lbRestePayerValeur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRestePayerValeur.Name = "lbRestePayerValeur";
            this.lbRestePayerValeur.Size = new System.Drawing.Size(13, 17);
            this.lbRestePayerValeur.TabIndex = 49;
            this.lbRestePayerValeur.Text = "-";
            // 
            // lbMontantTotalValue
            // 
            this.lbMontantTotalValue.AutoSize = true;
            this.lbMontantTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbMontantTotalValue.Location = new System.Drawing.Point(104, 206);
            this.lbMontantTotalValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMontantTotalValue.Name = "lbMontantTotalValue";
            this.lbMontantTotalValue.Size = new System.Drawing.Size(13, 17);
            this.lbMontantTotalValue.TabIndex = 48;
            this.lbMontantTotalValue.Text = "-";
            // 
            // lblRestePayer
            // 
            this.lblRestePayer.AutoSize = true;
            this.lblRestePayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRestePayer.Location = new System.Drawing.Point(4, 231);
            this.lblRestePayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRestePayer.Name = "lblRestePayer";
            this.lblRestePayer.Size = new System.Drawing.Size(109, 17);
            this.lblRestePayer.TabIndex = 47;
            this.lblRestePayer.Text = "Reste à payer : ";
            // 
            // lblMontantTotal
            // 
            this.lblMontantTotal.AutoSize = true;
            this.lblMontantTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMontantTotal.Location = new System.Drawing.Point(4, 206);
            this.lblMontantTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMontantTotal.Name = "lblMontantTotal";
            this.lblMontantTotal.Size = new System.Drawing.Size(107, 17);
            this.lblMontantTotal.TabIndex = 46;
            this.lblMontantTotal.Text = "Montant Total : ";
            // 
            // btValiderModifCongressiste
            // 
            this.btValiderModifCongressiste.BackColor = System.Drawing.Color.LawnGreen;
            this.btValiderModifCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btValiderModifCongressiste.Location = new System.Drawing.Point(73, 267);
            this.btValiderModifCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.btValiderModifCongressiste.Name = "btValiderModifCongressiste";
            this.btValiderModifCongressiste.Size = new System.Drawing.Size(72, 24);
            this.btValiderModifCongressiste.TabIndex = 45;
            this.btValiderModifCongressiste.Text = "Valider";
            this.btValiderModifCongressiste.UseVisualStyleBackColor = false;
            // 
            // btAnnulerModifCongressiste
            // 
            this.btAnnulerModifCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btAnnulerModifCongressiste.Location = new System.Drawing.Point(417, 267);
            this.btAnnulerModifCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.btAnnulerModifCongressiste.Name = "btAnnulerModifCongressiste";
            this.btAnnulerModifCongressiste.Size = new System.Drawing.Size(76, 24);
            this.btAnnulerModifCongressiste.TabIndex = 44;
            this.btAnnulerModifCongressiste.Text = "Annuler";
            this.btAnnulerModifCongressiste.UseVisualStyleBackColor = true;
            // 
            // maskedTxtBoxAcompteCongressiste
            // 
            this.maskedTxtBoxAcompteCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTxtBoxAcompteCongressiste.Location = new System.Drawing.Point(234, 174);
            this.maskedTxtBoxAcompteCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTxtBoxAcompteCongressiste.Mask = "99999";
            this.maskedTxtBoxAcompteCongressiste.Name = "maskedTxtBoxAcompteCongressiste";
            this.maskedTxtBoxAcompteCongressiste.Size = new System.Drawing.Size(46, 23);
            this.maskedTxtBoxAcompteCongressiste.TabIndex = 43;
            // 
            // comboBoxLigueCongressiste
            // 
            this.comboBoxLigueCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxLigueCongressiste.FormattingEnabled = true;
            this.comboBoxLigueCongressiste.Location = new System.Drawing.Point(234, 224);
            this.comboBoxLigueCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxLigueCongressiste.Name = "comboBoxLigueCongressiste";
            this.comboBoxLigueCongressiste.Size = new System.Drawing.Size(108, 24);
            this.comboBoxLigueCongressiste.TabIndex = 42;
            // 
            // txtBoxVilleCongressiste
            // 
            this.txtBoxVilleCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxVilleCongressiste.Location = new System.Drawing.Point(234, 95);
            this.txtBoxVilleCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxVilleCongressiste.Name = "txtBoxVilleCongressiste";
            this.txtBoxVilleCongressiste.Size = new System.Drawing.Size(198, 23);
            this.txtBoxVilleCongressiste.TabIndex = 41;
            // 
            // txtBoxAdresseCongressiste
            // 
            this.txtBoxAdresseCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxAdresseCongressiste.Location = new System.Drawing.Point(234, 69);
            this.txtBoxAdresseCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxAdresseCongressiste.Name = "txtBoxAdresseCongressiste";
            this.txtBoxAdresseCongressiste.Size = new System.Drawing.Size(198, 23);
            this.txtBoxAdresseCongressiste.TabIndex = 40;
            // 
            // txtBoxPrenomCongressiste
            // 
            this.txtBoxPrenomCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxPrenomCongressiste.Location = new System.Drawing.Point(234, 43);
            this.txtBoxPrenomCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxPrenomCongressiste.Name = "txtBoxPrenomCongressiste";
            this.txtBoxPrenomCongressiste.Size = new System.Drawing.Size(198, 23);
            this.txtBoxPrenomCongressiste.TabIndex = 39;
            // 
            // lblHotelCongressiste
            // 
            this.lblHotelCongressiste.AutoSize = true;
            this.lblHotelCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHotelCongressiste.Location = new System.Drawing.Point(182, 202);
            this.lblHotelCongressiste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHotelCongressiste.Name = "lblHotelCongressiste";
            this.lblHotelCongressiste.Size = new System.Drawing.Size(53, 17);
            this.lblHotelCongressiste.TabIndex = 38;
            this.lblHotelCongressiste.Text = "Hôtel : ";
            // 
            // lblLigueCongressiste
            // 
            this.lblLigueCongressiste.AutoSize = true;
            this.lblLigueCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLigueCongressiste.Location = new System.Drawing.Point(181, 227);
            this.lblLigueCongressiste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLigueCongressiste.Name = "lblLigueCongressiste";
            this.lblLigueCongressiste.Size = new System.Drawing.Size(55, 17);
            this.lblLigueCongressiste.TabIndex = 37;
            this.lblLigueCongressiste.Text = "Ligue : ";
            // 
            // lblAcompteCongressiste
            // 
            this.lblAcompteCongressiste.AutoSize = true;
            this.lblAcompteCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAcompteCongressiste.Location = new System.Drawing.Point(162, 176);
            this.lblAcompteCongressiste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcompteCongressiste.Name = "lblAcompteCongressiste";
            this.lblAcompteCongressiste.Size = new System.Drawing.Size(75, 17);
            this.lblAcompteCongressiste.TabIndex = 36;
            this.lblAcompteCongressiste.Text = "Acompte : ";
            // 
            // comboBoxHotelCongressiste
            // 
            this.comboBoxHotelCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxHotelCongressiste.FormattingEnabled = true;
            this.comboBoxHotelCongressiste.Location = new System.Drawing.Point(234, 200);
            this.comboBoxHotelCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxHotelCongressiste.Name = "comboBoxHotelCongressiste";
            this.comboBoxHotelCongressiste.Size = new System.Drawing.Size(108, 24);
            this.comboBoxHotelCongressiste.TabIndex = 22;
            // 
            // txtBoxNomCongressiste
            // 
            this.txtBoxNomCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxNomCongressiste.Location = new System.Drawing.Point(234, 17);
            this.txtBoxNomCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxNomCongressiste.Name = "txtBoxNomCongressiste";
            this.txtBoxNomCongressiste.Size = new System.Drawing.Size(198, 23);
            this.txtBoxNomCongressiste.TabIndex = 20;
            // 
            // maskedTxtBoxCpCongressiste
            // 
            this.maskedTxtBoxCpCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTxtBoxCpCongressiste.Location = new System.Drawing.Point(234, 123);
            this.maskedTxtBoxCpCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTxtBoxCpCongressiste.Mask = "99999";
            this.maskedTxtBoxCpCongressiste.Name = "maskedTxtBoxCpCongressiste";
            this.maskedTxtBoxCpCongressiste.Size = new System.Drawing.Size(46, 23);
            this.maskedTxtBoxCpCongressiste.TabIndex = 25;
            // 
            // maskedTxtBoxTelCongressiste
            // 
            this.maskedTxtBoxTelCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTxtBoxTelCongressiste.Location = new System.Drawing.Point(234, 149);
            this.maskedTxtBoxTelCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTxtBoxTelCongressiste.Mask = "9999999999";
            this.maskedTxtBoxTelCongressiste.Name = "maskedTxtBoxTelCongressiste";
            this.maskedTxtBoxTelCongressiste.Size = new System.Drawing.Size(76, 23);
            this.maskedTxtBoxTelCongressiste.TabIndex = 30;
            // 
            // lblCpCongressiste
            // 
            this.lblCpCongressiste.AutoSize = true;
            this.lblCpCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCpCongressiste.Location = new System.Drawing.Point(146, 125);
            this.lblCpCongressiste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCpCongressiste.Name = "lblCpCongressiste";
            this.lblCpCongressiste.Size = new System.Drawing.Size(95, 17);
            this.lblCpCongressiste.TabIndex = 31;
            this.lblCpCongressiste.Text = "Code postal : ";
            // 
            // lblTelCongressiste
            // 
            this.lblTelCongressiste.AutoSize = true;
            this.lblTelCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTelCongressiste.Location = new System.Drawing.Point(154, 151);
            this.lblTelCongressiste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelCongressiste.Name = "lblTelCongressiste";
            this.lblTelCongressiste.Size = new System.Drawing.Size(88, 17);
            this.lblTelCongressiste.TabIndex = 29;
            this.lblTelCongressiste.Text = "Téléphone : ";
            // 
            // lblVilleCongressiste
            // 
            this.lblVilleCongressiste.AutoSize = true;
            this.lblVilleCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVilleCongressiste.Location = new System.Drawing.Point(188, 98);
            this.lblVilleCongressiste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVilleCongressiste.Name = "lblVilleCongressiste";
            this.lblVilleCongressiste.Size = new System.Drawing.Size(46, 17);
            this.lblVilleCongressiste.TabIndex = 27;
            this.lblVilleCongressiste.Text = "Ville : ";
            // 
            // lblPrenomCongressiste
            // 
            this.lblPrenomCongressiste.AutoSize = true;
            this.lblPrenomCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPrenomCongressiste.Location = new System.Drawing.Point(173, 46);
            this.lblPrenomCongressiste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrenomCongressiste.Name = "lblPrenomCongressiste";
            this.lblPrenomCongressiste.Size = new System.Drawing.Size(69, 17);
            this.lblPrenomCongressiste.TabIndex = 26;
            this.lblPrenomCongressiste.Text = "Prénom : ";
            // 
            // lblAdresseCongressiste
            // 
            this.lblAdresseCongressiste.AutoSize = true;
            this.lblAdresseCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAdresseCongressiste.Location = new System.Drawing.Point(167, 72);
            this.lblAdresseCongressiste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdresseCongressiste.Name = "lblAdresseCongressiste";
            this.lblAdresseCongressiste.Size = new System.Drawing.Size(72, 17);
            this.lblAdresseCongressiste.TabIndex = 24;
            this.lblAdresseCongressiste.Text = "Adresse : ";
            // 
            // lblNomCongressiste
            // 
            this.lblNomCongressiste.AutoSize = true;
            this.lblNomCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNomCongressiste.Location = new System.Drawing.Point(188, 20);
            this.lblNomCongressiste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomCongressiste.Name = "lblNomCongressiste";
            this.lblNomCongressiste.Size = new System.Drawing.Size(49, 17);
            this.lblNomCongressiste.TabIndex = 21;
            this.lblNomCongressiste.Text = "Nom : ";
            // 
            // btSupprimerCongressiste
            // 
            this.btSupprimerCongressiste.BackColor = System.Drawing.Color.Red;
            this.btSupprimerCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btSupprimerCongressiste.Location = new System.Drawing.Point(184, 267);
            this.btSupprimerCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.btSupprimerCongressiste.Name = "btSupprimerCongressiste";
            this.btSupprimerCongressiste.Size = new System.Drawing.Size(189, 24);
            this.btSupprimerCongressiste.TabIndex = 35;
            this.btSupprimerCongressiste.Text = "Supprimer le congressiste";
            this.btSupprimerCongressiste.UseVisualStyleBackColor = false;
            // 
            // ListeParticipations
            // 
            this.ListeParticipations.Controls.Add(this.btSupprimerSessionCongressiste);
            this.ListeParticipations.Controls.Add(this.btAjouterSessionCongressiste);
            this.ListeParticipations.Controls.Add(this.lbAjouterSessionCongressiste);
            this.ListeParticipations.Controls.Add(this.comboBoxAjouterSessionCongressiste);
            this.ListeParticipations.Controls.Add(this.lblSession);
            this.ListeParticipations.Controls.Add(this.dataGridView1);
            this.ListeParticipations.Controls.Add(this.btSupprimerActiviteCongressiste);
            this.ListeParticipations.Controls.Add(this.btAjouterActiviteCongressiste);
            this.ListeParticipations.Controls.Add(this.lbAjouterActiviteCongressiste);
            this.ListeParticipations.Controls.Add(this.comboBoxAjouterActiviteCongressiste);
            this.ListeParticipations.Controls.Add(this.lblActivite);
            this.ListeParticipations.Controls.Add(this.dataGridViewActiviteCongressiste);
            this.ListeParticipations.Location = new System.Drawing.Point(4, 22);
            this.ListeParticipations.Margin = new System.Windows.Forms.Padding(2);
            this.ListeParticipations.Name = "ListeParticipations";
            this.ListeParticipations.Size = new System.Drawing.Size(574, 320);
            this.ListeParticipations.TabIndex = 2;
            this.ListeParticipations.Text = "Participation";
            this.ListeParticipations.UseVisualStyleBackColor = true;
            // 
            // btSupprimerSessionCongressiste
            // 
            this.btSupprimerSessionCongressiste.Location = new System.Drawing.Point(309, 289);
            this.btSupprimerSessionCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.btSupprimerSessionCongressiste.Name = "btSupprimerSessionCongressiste";
            this.btSupprimerSessionCongressiste.Size = new System.Drawing.Size(113, 19);
            this.btSupprimerSessionCongressiste.TabIndex = 24;
            this.btSupprimerSessionCongressiste.Text = "Supprimer la session";
            this.btSupprimerSessionCongressiste.UseVisualStyleBackColor = true;
            // 
            // btAjouterSessionCongressiste
            // 
            this.btAjouterSessionCongressiste.Location = new System.Drawing.Point(443, 289);
            this.btAjouterSessionCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.btAjouterSessionCongressiste.Name = "btAjouterSessionCongressiste";
            this.btAjouterSessionCongressiste.Size = new System.Drawing.Size(100, 19);
            this.btAjouterSessionCongressiste.TabIndex = 23;
            this.btAjouterSessionCongressiste.Text = "Ajouter la session";
            this.btAjouterSessionCongressiste.UseVisualStyleBackColor = true;
            // 
            // lbAjouterSessionCongressiste
            // 
            this.lbAjouterSessionCongressiste.AutoSize = true;
            this.lbAjouterSessionCongressiste.Location = new System.Drawing.Point(307, 265);
            this.lbAjouterSessionCongressiste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAjouterSessionCongressiste.Name = "lbAjouterSessionCongressiste";
            this.lbAjouterSessionCongressiste.Size = new System.Drawing.Size(108, 13);
            this.lbAjouterSessionCongressiste.TabIndex = 25;
            this.lbAjouterSessionCongressiste.Text = "Ajouter une session : ";
            // 
            // comboBoxAjouterSessionCongressiste
            // 
            this.comboBoxAjouterSessionCongressiste.FormattingEnabled = true;
            this.comboBoxAjouterSessionCongressiste.Location = new System.Drawing.Point(417, 262);
            this.comboBoxAjouterSessionCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAjouterSessionCongressiste.Name = "comboBoxAjouterSessionCongressiste";
            this.comboBoxAjouterSessionCongressiste.Size = new System.Drawing.Size(126, 21);
            this.comboBoxAjouterSessionCongressiste.TabIndex = 22;
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Location = new System.Drawing.Point(307, 11);
            this.lblSession.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(58, 13);
            this.lblSession.TabIndex = 21;
            this.lblSession.Text = "Sessions : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(309, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(257, 223);
            this.dataGridView1.TabIndex = 20;
            // 
            // btSupprimerActiviteCongressiste
            // 
            this.btSupprimerActiviteCongressiste.Location = new System.Drawing.Point(13, 289);
            this.btSupprimerActiviteCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.btSupprimerActiviteCongressiste.Name = "btSupprimerActiviteCongressiste";
            this.btSupprimerActiviteCongressiste.Size = new System.Drawing.Size(128, 19);
            this.btSupprimerActiviteCongressiste.TabIndex = 18;
            this.btSupprimerActiviteCongressiste.Text = "Supprimer l\'activité";
            this.btSupprimerActiviteCongressiste.UseVisualStyleBackColor = true;
            // 
            // btAjouterActiviteCongressiste
            // 
            this.btAjouterActiviteCongressiste.Location = new System.Drawing.Point(147, 289);
            this.btAjouterActiviteCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.btAjouterActiviteCongressiste.Name = "btAjouterActiviteCongressiste";
            this.btAjouterActiviteCongressiste.Size = new System.Drawing.Size(100, 19);
            this.btAjouterActiviteCongressiste.TabIndex = 17;
            this.btAjouterActiviteCongressiste.Text = "Ajouter l\'activité";
            this.btAjouterActiviteCongressiste.UseVisualStyleBackColor = true;
            // 
            // lbAjouterActiviteCongressiste
            // 
            this.lbAjouterActiviteCongressiste.AutoSize = true;
            this.lbAjouterActiviteCongressiste.Location = new System.Drawing.Point(10, 264);
            this.lbAjouterActiviteCongressiste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAjouterActiviteCongressiste.Name = "lbAjouterActiviteCongressiste";
            this.lbAjouterActiviteCongressiste.Size = new System.Drawing.Size(107, 13);
            this.lbAjouterActiviteCongressiste.TabIndex = 19;
            this.lbAjouterActiviteCongressiste.Text = "Ajouter une activité : ";
            // 
            // comboBoxAjouterActiviteCongressiste
            // 
            this.comboBoxAjouterActiviteCongressiste.FormattingEnabled = true;
            this.comboBoxAjouterActiviteCongressiste.Location = new System.Drawing.Point(121, 262);
            this.comboBoxAjouterActiviteCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAjouterActiviteCongressiste.Name = "comboBoxAjouterActiviteCongressiste";
            this.comboBoxAjouterActiviteCongressiste.Size = new System.Drawing.Size(126, 21);
            this.comboBoxAjouterActiviteCongressiste.TabIndex = 16;
            // 
            // lblActivite
            // 
            this.lblActivite.AutoSize = true;
            this.lblActivite.Location = new System.Drawing.Point(10, 11);
            this.lblActivite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActivite.Name = "lblActivite";
            this.lblActivite.Size = new System.Drawing.Size(56, 13);
            this.lblActivite.TabIndex = 1;
            this.lblActivite.Text = "Activités : ";
            // 
            // dataGridViewActiviteCongressiste
            // 
            this.dataGridViewActiviteCongressiste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActiviteCongressiste.Location = new System.Drawing.Point(13, 27);
            this.dataGridViewActiviteCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewActiviteCongressiste.Name = "dataGridViewActiviteCongressiste";
            this.dataGridViewActiviteCongressiste.RowHeadersWidth = 51;
            this.dataGridViewActiviteCongressiste.RowTemplate.Height = 24;
            this.dataGridViewActiviteCongressiste.Size = new System.Drawing.Size(257, 223);
            this.dataGridViewActiviteCongressiste.TabIndex = 0;
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
            // idHotelDataGridViewTextBoxColumn
            // 
            this.idHotelDataGridViewTextBoxColumn.DataPropertyName = "idHotel";
            this.idHotelDataGridViewTextBoxColumn.HeaderText = "idHotel";
            this.idHotelDataGridViewTextBoxColumn.Name = "idHotelDataGridViewTextBoxColumn";
            this.idHotelDataGridViewTextBoxColumn.ReadOnly = true;
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
            // activitesDataGridViewTextBoxColumn
            // 
            this.activitesDataGridViewTextBoxColumn.DataPropertyName = "Activites";
            this.activitesDataGridViewTextBoxColumn.HeaderText = "Activites";
            this.activitesDataGridViewTextBoxColumn.Name = "activitesDataGridViewTextBoxColumn";
            this.activitesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sessionsDataGridViewTextBoxColumn
            // 
            this.sessionsDataGridViewTextBoxColumn.DataPropertyName = "Sessions";
            this.sessionsDataGridViewTextBoxColumn.HeaderText = "Sessions";
            this.sessionsDataGridViewTextBoxColumn.Name = "sessionsDataGridViewTextBoxColumn";
            this.sessionsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmGestionInscriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmGestionInscriptions";
            this.Text = "Gestion Inscriptions";
            this.Load += new System.EventHandler(this.FrmGestionInscriptions_Load);
            this.tabControl1.ResumeLayout(false);
            this.ListeCongressistes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListCongressiste)).EndInit();
            this.DetailsCongressiste.ResumeLayout(false);
            this.DetailsCongressiste.PerformLayout();
            this.ListeParticipations.ResumeLayout(false);
            this.ListeParticipations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiviteCongressiste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcInscriptions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DetailsCongressiste;
        private System.Windows.Forms.TabPage ListeParticipations;
        private System.Windows.Forms.TabPage ListeCongressistes;
        private System.Windows.Forms.Button btAjouterCongressiste;
        private System.Windows.Forms.DataGridView dataGridViewListCongressiste;
        private System.Windows.Forms.ComboBox comboBoxHotelCongressiste;
        private System.Windows.Forms.TextBox txtBoxNomCongressiste;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxCpCongressiste;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxTelCongressiste;
        private System.Windows.Forms.Label lblCpCongressiste;
        private System.Windows.Forms.Label lblTelCongressiste;
        private System.Windows.Forms.Label lblVilleCongressiste;
        private System.Windows.Forms.Label lblPrenomCongressiste;
        private System.Windows.Forms.Label lblAdresseCongressiste;
        private System.Windows.Forms.Label lblNomCongressiste;
        private System.Windows.Forms.Button btSupprimerCongressiste;
        private System.Windows.Forms.Label lblHotelCongressiste;
        private System.Windows.Forms.Label lblLigueCongressiste;
        private System.Windows.Forms.Label lblAcompteCongressiste;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxAcompteCongressiste;
        private System.Windows.Forms.ComboBox comboBoxLigueCongressiste;
        private System.Windows.Forms.TextBox txtBoxVilleCongressiste;
        private System.Windows.Forms.TextBox txtBoxAdresseCongressiste;
        private System.Windows.Forms.TextBox txtBoxPrenomCongressiste;
        private System.Windows.Forms.Button btValiderModifCongressiste;
        private System.Windows.Forms.Button btAnnulerModifCongressiste;
        private System.Windows.Forms.Label lbRestePayerValeur;
        private System.Windows.Forms.Label lbMontantTotalValue;
        private System.Windows.Forms.Label lblRestePayer;
        private System.Windows.Forms.Label lblMontantTotal;
        private System.Windows.Forms.DataGridView dataGridViewActiviteCongressiste;
        private System.Windows.Forms.Label lblActivite;
        private System.Windows.Forms.Button btSupprimerActiviteCongressiste;
        private System.Windows.Forms.Button btAjouterActiviteCongressiste;
        private System.Windows.Forms.Label lbAjouterActiviteCongressiste;
        private System.Windows.Forms.ComboBox comboBoxAjouterActiviteCongressiste;
        private System.Windows.Forms.Button btSupprimerSessionCongressiste;
        private System.Windows.Forms.Button btAjouterSessionCongressiste;
        private System.Windows.Forms.Label lbAjouterSessionCongressiste;
        private System.Windows.Forms.ComboBox comboBoxAjouterSessionCongressiste;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindSrcInscriptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn numInscriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acompteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHotelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLigueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activitesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionsDataGridViewTextBoxColumn;
    }
}