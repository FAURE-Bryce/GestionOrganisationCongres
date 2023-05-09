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
            this.bindSrcInscriptions = new System.Windows.Forms.BindingSource(this.components);
            this.DetailsCongressiste = new System.Windows.Forms.TabPage();
            this.lblEuro2 = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
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
            this.bindSrcHotels = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.ListeCongressistes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListCongressiste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcInscriptions)).BeginInit();
            this.DetailsCongressiste.SuspendLayout();
            this.ListeParticipations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiviteCongressiste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcHotels)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(891, 490);
            this.tabControl1.TabIndex = 0;
            // 
            // ListeCongressistes
            // 
            this.ListeCongressistes.Controls.Add(this.btAjouterCongressiste);
            this.ListeCongressistes.Controls.Add(this.dataGridViewListCongressiste);
            this.ListeCongressistes.Location = new System.Drawing.Point(4, 22);
            this.ListeCongressistes.Margin = new System.Windows.Forms.Padding(2);
            this.ListeCongressistes.Name = "ListeCongressistes";
            this.ListeCongressistes.Size = new System.Drawing.Size(883, 464);
            this.ListeCongressistes.TabIndex = 4;
            this.ListeCongressistes.Text = "Liste";
            this.ListeCongressistes.UseVisualStyleBackColor = true;
            // 
            // btAjouterCongressiste
            // 
            this.btAjouterCongressiste.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btAjouterCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btAjouterCongressiste.Location = new System.Drawing.Point(315, 388);
            this.btAjouterCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.btAjouterCongressiste.Name = "btAjouterCongressiste";
            this.btAjouterCongressiste.Size = new System.Drawing.Size(205, 56);
            this.btAjouterCongressiste.TabIndex = 3;
            this.btAjouterCongressiste.Text = "Ajouter un congressiste";
            this.btAjouterCongressiste.UseVisualStyleBackColor = false;
            // 
            // dataGridViewListCongressiste
            // 
            this.dataGridViewListCongressiste.AllowUserToAddRows = false;
            this.dataGridViewListCongressiste.AllowUserToDeleteRows = false;
            this.dataGridViewListCongressiste.AutoGenerateColumns = false;
            this.dataGridViewListCongressiste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
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
            this.idLigueDataGridViewTextBoxColumn,
            this.hotelDataGridViewTextBoxColumn});
            this.dataGridViewListCongressiste.DataSource = this.bindSrcInscriptions;
            this.dataGridViewListCongressiste.Location = new System.Drawing.Point(4, 7);
            this.dataGridViewListCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewListCongressiste.MultiSelect = false;
            this.dataGridViewListCongressiste.Name = "dataGridViewListCongressiste";
            this.dataGridViewListCongressiste.ReadOnly = true;
            this.dataGridViewListCongressiste.RowHeadersWidth = 51;
            this.dataGridViewListCongressiste.RowTemplate.Height = 24;
            this.dataGridViewListCongressiste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListCongressiste.Size = new System.Drawing.Size(877, 357);
            this.dataGridViewListCongressiste.TabIndex = 2;
            // 
            // bindSrcInscriptions
            // 
            this.bindSrcInscriptions.DataSource = typeof(GestionOrganisationCongres.Congressiste);
            // 
            // DetailsCongressiste
            // 
            this.DetailsCongressiste.Controls.Add(this.lblEuro2);
            this.DetailsCongressiste.Controls.Add(this.lblEuro);
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
            this.DetailsCongressiste.Size = new System.Drawing.Size(883, 464);
            this.DetailsCongressiste.TabIndex = 1;
            this.DetailsCongressiste.Text = "Détails";
            this.DetailsCongressiste.UseVisualStyleBackColor = true;
            // 
            // lblEuro2
            // 
            this.lblEuro2.AutoSize = true;
            this.lblEuro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro2.Location = new System.Drawing.Point(775, 202);
            this.lblEuro2.Name = "lblEuro2";
            this.lblEuro2.Size = new System.Drawing.Size(16, 18);
            this.lblEuro2.TabIndex = 51;
            this.lblEuro2.Text = "€";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro.Location = new System.Drawing.Point(782, 115);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(16, 18);
            this.lblEuro.TabIndex = 50;
            this.lblEuro.Text = "€";
            // 
            // lbRestePayerValeur
            // 
            this.lbRestePayerValeur.AutoSize = true;
            this.lbRestePayerValeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbRestePayerValeur.Location = new System.Drawing.Point(756, 199);
            this.lbRestePayerValeur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRestePayerValeur.Name = "lbRestePayerValeur";
            this.lbRestePayerValeur.Size = new System.Drawing.Size(14, 20);
            this.lbRestePayerValeur.TabIndex = 49;
            this.lbRestePayerValeur.Text = "-";
            // 
            // lbMontantTotalValue
            // 
            this.lbMontantTotalValue.AutoSize = true;
            this.lbMontantTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbMontantTotalValue.Location = new System.Drawing.Point(763, 113);
            this.lbMontantTotalValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMontantTotalValue.Name = "lbMontantTotalValue";
            this.lbMontantTotalValue.Size = new System.Drawing.Size(14, 20);
            this.lbMontantTotalValue.TabIndex = 48;
            this.lbMontantTotalValue.Text = "-";
            // 
            // lblRestePayer
            // 
            this.lblRestePayer.AutoSize = true;
            this.lblRestePayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblRestePayer.Location = new System.Drawing.Point(641, 200);
            this.lblRestePayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRestePayer.Name = "lblRestePayer";
            this.lblRestePayer.Size = new System.Drawing.Size(111, 18);
            this.lblRestePayer.TabIndex = 47;
            this.lblRestePayer.Text = "Reste à payer : ";
            // 
            // lblMontantTotal
            // 
            this.lblMontantTotal.AutoSize = true;
            this.lblMontantTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMontantTotal.Location = new System.Drawing.Point(640, 113);
            this.lblMontantTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMontantTotal.Name = "lblMontantTotal";
            this.lblMontantTotal.Size = new System.Drawing.Size(119, 20);
            this.lblMontantTotal.TabIndex = 46;
            this.lblMontantTotal.Text = "Montant Total : ";
            // 
            // btValiderModifCongressiste
            // 
            this.btValiderModifCongressiste.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btValiderModifCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btValiderModifCongressiste.Location = new System.Drawing.Point(593, 372);
            this.btValiderModifCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.btValiderModifCongressiste.Name = "btValiderModifCongressiste";
            this.btValiderModifCongressiste.Size = new System.Drawing.Size(106, 44);
            this.btValiderModifCongressiste.TabIndex = 45;
            this.btValiderModifCongressiste.Text = "Valider";
            this.btValiderModifCongressiste.UseVisualStyleBackColor = false;
            // 
            // btAnnulerModifCongressiste
            // 
            this.btAnnulerModifCongressiste.BackColor = System.Drawing.Color.LightPink;
            this.btAnnulerModifCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btAnnulerModifCongressiste.Location = new System.Drawing.Point(135, 372);
            this.btAnnulerModifCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.btAnnulerModifCongressiste.Name = "btAnnulerModifCongressiste";
            this.btAnnulerModifCongressiste.Size = new System.Drawing.Size(102, 44);
            this.btAnnulerModifCongressiste.TabIndex = 44;
            this.btAnnulerModifCongressiste.Text = "Annuler";
            this.btAnnulerModifCongressiste.UseVisualStyleBackColor = false;
            // 
            // maskedTxtBoxAcompteCongressiste
            // 
            this.maskedTxtBoxAcompteCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTxtBoxAcompteCongressiste.Location = new System.Drawing.Point(256, 226);
            this.maskedTxtBoxAcompteCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTxtBoxAcompteCongressiste.Mask = "99999";
            this.maskedTxtBoxAcompteCongressiste.Name = "maskedTxtBoxAcompteCongressiste";
            this.maskedTxtBoxAcompteCongressiste.Size = new System.Drawing.Size(76, 23);
            this.maskedTxtBoxAcompteCongressiste.TabIndex = 43;
            // 
            // comboBoxLigueCongressiste
            // 
            this.comboBoxLigueCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxLigueCongressiste.FormattingEnabled = true;
            this.comboBoxLigueCongressiste.Location = new System.Drawing.Point(234, 303);
            this.comboBoxLigueCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxLigueCongressiste.Name = "comboBoxLigueCongressiste";
            this.comboBoxLigueCongressiste.Size = new System.Drawing.Size(240, 24);
            this.comboBoxLigueCongressiste.TabIndex = 42;
            // 
            // txtBoxVilleCongressiste
            // 
            this.txtBoxVilleCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxVilleCongressiste.Location = new System.Drawing.Point(223, 113);
            this.txtBoxVilleCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxVilleCongressiste.Name = "txtBoxVilleCongressiste";
            this.txtBoxVilleCongressiste.Size = new System.Drawing.Size(198, 23);
            this.txtBoxVilleCongressiste.TabIndex = 41;
            // 
            // txtBoxAdresseCongressiste
            // 
            this.txtBoxAdresseCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxAdresseCongressiste.Location = new System.Drawing.Point(251, 73);
            this.txtBoxAdresseCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxAdresseCongressiste.Name = "txtBoxAdresseCongressiste";
            this.txtBoxAdresseCongressiste.Size = new System.Drawing.Size(223, 23);
            this.txtBoxAdresseCongressiste.TabIndex = 40;
            // 
            // txtBoxPrenomCongressiste
            // 
            this.txtBoxPrenomCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxPrenomCongressiste.Location = new System.Drawing.Point(478, 13);
            this.txtBoxPrenomCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxPrenomCongressiste.Name = "txtBoxPrenomCongressiste";
            this.txtBoxPrenomCongressiste.Size = new System.Drawing.Size(198, 23);
            this.txtBoxPrenomCongressiste.TabIndex = 39;
            // 
            // lblHotelCongressiste
            // 
            this.lblHotelCongressiste.AutoSize = true;
            this.lblHotelCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblHotelCongressiste.Location = new System.Drawing.Point(173, 265);
            this.lblHotelCongressiste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHotelCongressiste.Name = "lblHotelCongressiste";
            this.lblHotelCongressiste.Size = new System.Drawing.Size(55, 18);
            this.lblHotelCongressiste.TabIndex = 38;
            this.lblHotelCongressiste.Text = "Hôtel : ";
            // 
            // lblLigueCongressiste
            // 
            this.lblLigueCongressiste.AutoSize = true;
            this.lblLigueCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblLigueCongressiste.Location = new System.Drawing.Point(173, 304);
            this.lblLigueCongressiste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLigueCongressiste.Name = "lblLigueCongressiste";
            this.lblLigueCongressiste.Size = new System.Drawing.Size(55, 18);
            this.lblLigueCongressiste.TabIndex = 37;
            this.lblLigueCongressiste.Text = "Ligue : ";
            // 
            // lblAcompteCongressiste
            // 
            this.lblAcompteCongressiste.AutoSize = true;
            this.lblAcompteCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblAcompteCongressiste.Location = new System.Drawing.Point(173, 227);
            this.lblAcompteCongressiste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcompteCongressiste.Name = "lblAcompteCongressiste";
            this.lblAcompteCongressiste.Size = new System.Drawing.Size(79, 18);
            this.lblAcompteCongressiste.TabIndex = 36;
            this.lblAcompteCongressiste.Text = "Acompte : ";
            // 
            // comboBoxHotelCongressiste
            // 
            this.comboBoxHotelCongressiste.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindSrcInscriptions, "Hotel", true));
            this.comboBoxHotelCongressiste.DataSource = this.bindSrcHotels;
            this.comboBoxHotelCongressiste.DisplayMember = "idHotel";
            this.comboBoxHotelCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxHotelCongressiste.FormattingEnabled = true;
            this.comboBoxHotelCongressiste.Location = new System.Drawing.Point(234, 264);
            this.comboBoxHotelCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxHotelCongressiste.Name = "comboBoxHotelCongressiste";
            this.comboBoxHotelCongressiste.Size = new System.Drawing.Size(240, 24);
            this.comboBoxHotelCongressiste.TabIndex = 22;
            // 
            // txtBoxNomCongressiste
            // 
            this.txtBoxNomCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxNomCongressiste.Location = new System.Drawing.Point(135, 16);
            this.txtBoxNomCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxNomCongressiste.Name = "txtBoxNomCongressiste";
            this.txtBoxNomCongressiste.Size = new System.Drawing.Size(198, 23);
            this.txtBoxNomCongressiste.TabIndex = 20;
            // 
            // maskedTxtBoxCpCongressiste
            // 
            this.maskedTxtBoxCpCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTxtBoxCpCongressiste.Location = new System.Drawing.Point(277, 149);
            this.maskedTxtBoxCpCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTxtBoxCpCongressiste.Mask = "99999";
            this.maskedTxtBoxCpCongressiste.Name = "maskedTxtBoxCpCongressiste";
            this.maskedTxtBoxCpCongressiste.Size = new System.Drawing.Size(74, 23);
            this.maskedTxtBoxCpCongressiste.TabIndex = 25;
            // 
            // maskedTxtBoxTelCongressiste
            // 
            this.maskedTxtBoxTelCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTxtBoxTelCongressiste.Location = new System.Drawing.Point(266, 187);
            this.maskedTxtBoxTelCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTxtBoxTelCongressiste.Mask = "9999999999";
            this.maskedTxtBoxTelCongressiste.Name = "maskedTxtBoxTelCongressiste";
            this.maskedTxtBoxTelCongressiste.Size = new System.Drawing.Size(146, 23);
            this.maskedTxtBoxTelCongressiste.TabIndex = 30;
            // 
            // lblCpCongressiste
            // 
            this.lblCpCongressiste.AutoSize = true;
            this.lblCpCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCpCongressiste.Location = new System.Drawing.Point(173, 150);
            this.lblCpCongressiste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCpCongressiste.Name = "lblCpCongressiste";
            this.lblCpCongressiste.Size = new System.Drawing.Size(100, 18);
            this.lblCpCongressiste.TabIndex = 31;
            this.lblCpCongressiste.Text = "Code postal : ";
            // 
            // lblTelCongressiste
            // 
            this.lblTelCongressiste.AutoSize = true;
            this.lblTelCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTelCongressiste.Location = new System.Drawing.Point(173, 188);
            this.lblTelCongressiste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelCongressiste.Name = "lblTelCongressiste";
            this.lblTelCongressiste.Size = new System.Drawing.Size(89, 18);
            this.lblTelCongressiste.TabIndex = 29;
            this.lblTelCongressiste.Text = "Téléphone : ";
            // 
            // lblVilleCongressiste
            // 
            this.lblVilleCongressiste.AutoSize = true;
            this.lblVilleCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblVilleCongressiste.Location = new System.Drawing.Point(173, 115);
            this.lblVilleCongressiste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVilleCongressiste.Name = "lblVilleCongressiste";
            this.lblVilleCongressiste.Size = new System.Drawing.Size(46, 18);
            this.lblVilleCongressiste.TabIndex = 27;
            this.lblVilleCongressiste.Text = "Ville : ";
            // 
            // lblPrenomCongressiste
            // 
            this.lblPrenomCongressiste.AutoSize = true;
            this.lblPrenomCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPrenomCongressiste.Location = new System.Drawing.Point(401, 18);
            this.lblPrenomCongressiste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrenomCongressiste.Name = "lblPrenomCongressiste";
            this.lblPrenomCongressiste.Size = new System.Drawing.Size(73, 18);
            this.lblPrenomCongressiste.TabIndex = 26;
            this.lblPrenomCongressiste.Text = "Prénom : ";
            // 
            // lblAdresseCongressiste
            // 
            this.lblAdresseCongressiste.AutoSize = true;
            this.lblAdresseCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblAdresseCongressiste.Location = new System.Drawing.Point(173, 74);
            this.lblAdresseCongressiste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdresseCongressiste.Name = "lblAdresseCongressiste";
            this.lblAdresseCongressiste.Size = new System.Drawing.Size(74, 18);
            this.lblAdresseCongressiste.TabIndex = 24;
            this.lblAdresseCongressiste.Text = "Adresse : ";
            // 
            // lblNomCongressiste
            // 
            this.lblNomCongressiste.AutoSize = true;
            this.lblNomCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNomCongressiste.Location = new System.Drawing.Point(71, 18);
            this.lblNomCongressiste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomCongressiste.Name = "lblNomCongressiste";
            this.lblNomCongressiste.Size = new System.Drawing.Size(53, 18);
            this.lblNomCongressiste.TabIndex = 21;
            this.lblNomCongressiste.Text = "Nom : ";
            // 
            // btSupprimerCongressiste
            // 
            this.btSupprimerCongressiste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btSupprimerCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btSupprimerCongressiste.Location = new System.Drawing.Point(316, 362);
            this.btSupprimerCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.btSupprimerCongressiste.Name = "btSupprimerCongressiste";
            this.btSupprimerCongressiste.Size = new System.Drawing.Size(195, 65);
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
            this.ListeParticipations.Size = new System.Drawing.Size(883, 464);
            this.ListeParticipations.TabIndex = 2;
            this.ListeParticipations.Text = "Participation";
            this.ListeParticipations.UseVisualStyleBackColor = true;
            // 
            // btSupprimerSessionCongressiste
            // 
            this.btSupprimerSessionCongressiste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btSupprimerSessionCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupprimerSessionCongressiste.Location = new System.Drawing.Point(471, 390);
            this.btSupprimerSessionCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.btSupprimerSessionCongressiste.Name = "btSupprimerSessionCongressiste";
            this.btSupprimerSessionCongressiste.Size = new System.Drawing.Size(130, 56);
            this.btSupprimerSessionCongressiste.TabIndex = 24;
            this.btSupprimerSessionCongressiste.Text = "Supprimer la session";
            this.btSupprimerSessionCongressiste.UseVisualStyleBackColor = false;
            // 
            // btAjouterSessionCongressiste
            // 
            this.btAjouterSessionCongressiste.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btAjouterSessionCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjouterSessionCongressiste.Location = new System.Drawing.Point(713, 303);
            this.btAjouterSessionCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.btAjouterSessionCongressiste.Name = "btAjouterSessionCongressiste";
            this.btAjouterSessionCongressiste.Size = new System.Drawing.Size(114, 56);
            this.btAjouterSessionCongressiste.TabIndex = 23;
            this.btAjouterSessionCongressiste.Text = "Ajouter la session";
            this.btAjouterSessionCongressiste.UseVisualStyleBackColor = false;
            // 
            // lbAjouterSessionCongressiste
            // 
            this.lbAjouterSessionCongressiste.AutoSize = true;
            this.lbAjouterSessionCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAjouterSessionCongressiste.Location = new System.Drawing.Point(468, 270);
            this.lbAjouterSessionCongressiste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAjouterSessionCongressiste.Name = "lbAjouterSessionCongressiste";
            this.lbAjouterSessionCongressiste.Size = new System.Drawing.Size(145, 17);
            this.lbAjouterSessionCongressiste.TabIndex = 25;
            this.lbAjouterSessionCongressiste.Text = "Ajouter une session : ";
            // 
            // comboBoxAjouterSessionCongressiste
            // 
            this.comboBoxAjouterSessionCongressiste.FormattingEnabled = true;
            this.comboBoxAjouterSessionCongressiste.Location = new System.Drawing.Point(617, 268);
            this.comboBoxAjouterSessionCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAjouterSessionCongressiste.Name = "comboBoxAjouterSessionCongressiste";
            this.comboBoxAjouterSessionCongressiste.Size = new System.Drawing.Size(255, 21);
            this.comboBoxAjouterSessionCongressiste.TabIndex = 22;
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSession.Location = new System.Drawing.Point(636, 8);
            this.lblSession.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(77, 17);
            this.lblSession.TabIndex = 21;
            this.lblSession.Text = "Sessions : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(461, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(411, 223);
            this.dataGridView1.TabIndex = 20;
            // 
            // btSupprimerActiviteCongressiste
            // 
            this.btSupprimerActiviteCongressiste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btSupprimerActiviteCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupprimerActiviteCongressiste.Location = new System.Drawing.Point(13, 389);
            this.btSupprimerActiviteCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.btSupprimerActiviteCongressiste.Name = "btSupprimerActiviteCongressiste";
            this.btSupprimerActiviteCongressiste.Size = new System.Drawing.Size(138, 57);
            this.btSupprimerActiviteCongressiste.TabIndex = 18;
            this.btSupprimerActiviteCongressiste.Text = "Supprimer l\'activité";
            this.btSupprimerActiviteCongressiste.UseVisualStyleBackColor = false;
            // 
            // btAjouterActiviteCongressiste
            // 
            this.btAjouterActiviteCongressiste.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btAjouterActiviteCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjouterActiviteCongressiste.Location = new System.Drawing.Point(227, 303);
            this.btAjouterActiviteCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.btAjouterActiviteCongressiste.Name = "btAjouterActiviteCongressiste";
            this.btAjouterActiviteCongressiste.Size = new System.Drawing.Size(123, 56);
            this.btAjouterActiviteCongressiste.TabIndex = 17;
            this.btAjouterActiviteCongressiste.Text = "Ajouter l\'activité";
            this.btAjouterActiviteCongressiste.UseVisualStyleBackColor = false;
            // 
            // lbAjouterActiviteCongressiste
            // 
            this.lbAjouterActiviteCongressiste.AutoSize = true;
            this.lbAjouterActiviteCongressiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAjouterActiviteCongressiste.Location = new System.Drawing.Point(10, 269);
            this.lbAjouterActiviteCongressiste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAjouterActiviteCongressiste.Name = "lbAjouterActiviteCongressiste";
            this.lbAjouterActiviteCongressiste.Size = new System.Drawing.Size(141, 17);
            this.lbAjouterActiviteCongressiste.TabIndex = 19;
            this.lbAjouterActiviteCongressiste.Text = "Ajouter une activité : ";
            // 
            // comboBoxAjouterActiviteCongressiste
            // 
            this.comboBoxAjouterActiviteCongressiste.FormattingEnabled = true;
            this.comboBoxAjouterActiviteCongressiste.Location = new System.Drawing.Point(174, 269);
            this.comboBoxAjouterActiviteCongressiste.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAjouterActiviteCongressiste.Name = "comboBoxAjouterActiviteCongressiste";
            this.comboBoxAjouterActiviteCongressiste.Size = new System.Drawing.Size(233, 21);
            this.comboBoxAjouterActiviteCongressiste.TabIndex = 16;
            // 
            // lblActivite
            // 
            this.lblActivite.AutoSize = true;
            this.lblActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivite.Location = new System.Drawing.Point(171, 8);
            this.lblActivite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActivite.Name = "lblActivite";
            this.lblActivite.Size = new System.Drawing.Size(72, 17);
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
            this.dataGridViewActiviteCongressiste.Size = new System.Drawing.Size(394, 223);
            this.dataGridViewActiviteCongressiste.TabIndex = 0;
            // 
            // numInscriptionDataGridViewTextBoxColumn
            // 
            this.numInscriptionDataGridViewTextBoxColumn.DataPropertyName = "numInscription";
            this.numInscriptionDataGridViewTextBoxColumn.HeaderText = "N° d\'inscription";
            this.numInscriptionDataGridViewTextBoxColumn.Name = "numInscriptionDataGridViewTextBoxColumn";
            this.numInscriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.numInscriptionDataGridViewTextBoxColumn.Width = 102;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomDataGridViewTextBoxColumn.Width = 54;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            this.prenomDataGridViewTextBoxColumn.Width = 68;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresseDataGridViewTextBoxColumn.Width = 70;
            // 
            // cpDataGridViewTextBoxColumn
            // 
            this.cpDataGridViewTextBoxColumn.DataPropertyName = "cp";
            this.cpDataGridViewTextBoxColumn.HeaderText = "Code postal";
            this.cpDataGridViewTextBoxColumn.Name = "cpDataGridViewTextBoxColumn";
            this.cpDataGridViewTextBoxColumn.ReadOnly = true;
            this.cpDataGridViewTextBoxColumn.Width = 88;
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "ville";
            this.villeDataGridViewTextBoxColumn.HeaderText = "Ville";
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            this.villeDataGridViewTextBoxColumn.ReadOnly = true;
            this.villeDataGridViewTextBoxColumn.Width = 51;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "N° de téléphone";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // acompteDataGridViewTextBoxColumn
            // 
            this.acompteDataGridViewTextBoxColumn.DataPropertyName = "acompte";
            this.acompteDataGridViewTextBoxColumn.HeaderText = "Acompte versé";
            this.acompteDataGridViewTextBoxColumn.Name = "acompteDataGridViewTextBoxColumn";
            this.acompteDataGridViewTextBoxColumn.ReadOnly = true;
            this.acompteDataGridViewTextBoxColumn.Width = 95;
            // 
            // idLigueDataGridViewTextBoxColumn
            // 
            this.idLigueDataGridViewTextBoxColumn.DataPropertyName = "Ligue";
            this.idLigueDataGridViewTextBoxColumn.HeaderText = "Ligue";
            this.idLigueDataGridViewTextBoxColumn.Name = "idLigueDataGridViewTextBoxColumn";
            this.idLigueDataGridViewTextBoxColumn.ReadOnly = true;
            this.idLigueDataGridViewTextBoxColumn.Width = 58;
            // 
            // hotelDataGridViewTextBoxColumn
            // 
            this.hotelDataGridViewTextBoxColumn.DataPropertyName = "Hotel";
            this.hotelDataGridViewTextBoxColumn.HeaderText = "Hotel";
            this.hotelDataGridViewTextBoxColumn.Name = "hotelDataGridViewTextBoxColumn";
            this.hotelDataGridViewTextBoxColumn.ReadOnly = true;
            this.hotelDataGridViewTextBoxColumn.Width = 57;
            // 
            // bindSrcHotels
            // 
            this.bindSrcHotels.DataSource = typeof(GestionOrganisationCongres.Hotel);
            // 
            // FrmGestionInscriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 520);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmGestionInscriptions";
            this.Text = "Gestion Inscriptions";
            this.Load += new System.EventHandler(this.FrmGestionInscriptions_Load);
            this.tabControl1.ResumeLayout(false);
            this.ListeCongressistes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListCongressiste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcInscriptions)).EndInit();
            this.DetailsCongressiste.ResumeLayout(false);
            this.DetailsCongressiste.PerformLayout();
            this.ListeParticipations.ResumeLayout(false);
            this.ListeParticipations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiviteCongressiste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcHotels)).EndInit();
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
        private System.Windows.Forms.Label lblEuro2;
        private System.Windows.Forms.Label lblEuro;
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
        private System.Windows.Forms.BindingSource bindSrcHotels;
    }
}