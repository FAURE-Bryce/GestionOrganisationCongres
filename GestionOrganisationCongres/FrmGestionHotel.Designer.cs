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
            this.components = new System.ComponentModel.Container();
            this.tabControlHotel = new System.Windows.Forms.TabControl();
            this.listeHotel = new System.Windows.Forms.TabPage();
            this.btAjouterHotel = new System.Windows.Forms.Button();
            this.dataGridViewHotel = new System.Windows.Forms.DataGridView();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixChambreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcHotels = new System.Windows.Forms.BindingSource(this.components);
            this.detailsHotels = new System.Windows.Forms.TabPage();
            this.maskedTextBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtBoxPrixHotel = new System.Windows.Forms.TextBox();
            this.lblEuro = new System.Windows.Forms.Label();
            this.txtBoxAdresseHotel = new System.Windows.Forms.TextBox();
            this.txtBoxVilleHotel = new System.Windows.Forms.TextBox();
            this.btValiderHotel = new System.Windows.Forms.Button();
            this.btAnnulerAjoutHotel = new System.Windows.Forms.Button();
            this.txtBoxNomHotel = new System.Windows.Forms.TextBox();
            this.maskedTxtBoxCpHotel = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxNbEtoileHotel = new System.Windows.Forms.ComboBox();
            this.bindSrcCategorie = new System.Windows.Forms.BindingSource(this.components);
            this.lblPrixHotel = new System.Windows.Forms.Label();
            this.lblNbEtoileHotel = new System.Windows.Forms.Label();
            this.lblCpHotel = new System.Windows.Forms.Label();
            this.lblAdresseHotel = new System.Windows.Forms.Label();
            this.lblVilleHotel = new System.Windows.Forms.Label();
            this.lblNomHotel = new System.Windows.Forms.Label();
            this.btSupprimerHotel = new System.Windows.Forms.Button();
            this.tabControlHotel.SuspendLayout();
            this.listeHotel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcHotels)).BeginInit();
            this.detailsHotels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcCategorie)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlHotel
            // 
            this.tabControlHotel.Controls.Add(this.listeHotel);
            this.tabControlHotel.Controls.Add(this.detailsHotels);
            this.tabControlHotel.Location = new System.Drawing.Point(9, 10);
            this.tabControlHotel.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlHotel.Name = "tabControlHotel";
            this.tabControlHotel.SelectedIndex = 0;
            this.tabControlHotel.Size = new System.Drawing.Size(823, 493);
            this.tabControlHotel.TabIndex = 1;
            // 
            // listeHotel
            // 
            this.listeHotel.Controls.Add(this.btAjouterHotel);
            this.listeHotel.Controls.Add(this.dataGridViewHotel);
            this.listeHotel.Location = new System.Drawing.Point(4, 22);
            this.listeHotel.Margin = new System.Windows.Forms.Padding(2);
            this.listeHotel.Name = "listeHotel";
            this.listeHotel.Padding = new System.Windows.Forms.Padding(2);
            this.listeHotel.Size = new System.Drawing.Size(815, 467);
            this.listeHotel.TabIndex = 0;
            this.listeHotel.Text = "Liste";
            this.listeHotel.UseVisualStyleBackColor = true;
            // 
            // btAjouterHotel
            // 
            this.btAjouterHotel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btAjouterHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btAjouterHotel.Location = new System.Drawing.Point(284, 402);
            this.btAjouterHotel.Margin = new System.Windows.Forms.Padding(2);
            this.btAjouterHotel.Name = "btAjouterHotel";
            this.btAjouterHotel.Size = new System.Drawing.Size(190, 45);
            this.btAjouterHotel.TabIndex = 1;
            this.btAjouterHotel.Text = "Ajouter un hôtel";
            this.btAjouterHotel.UseVisualStyleBackColor = false;
            this.btAjouterHotel.Click += new System.EventHandler(this.btAjouterHotel_Click);
            // 
            // dataGridViewHotel
            // 
            this.dataGridViewHotel.AllowUserToAddRows = false;
            this.dataGridViewHotel.AllowUserToDeleteRows = false;
            this.dataGridViewHotel.AutoGenerateColumns = false;
            this.dataGridViewHotel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHotel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.cpDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.prixChambreDataGridViewTextBoxColumn,
            this.idCategDataGridViewTextBoxColumn});
            this.dataGridViewHotel.DataSource = this.bindSrcHotels;
            this.dataGridViewHotel.Location = new System.Drawing.Point(2, 4);
            this.dataGridViewHotel.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewHotel.MultiSelect = false;
            this.dataGridViewHotel.Name = "dataGridViewHotel";
            this.dataGridViewHotel.ReadOnly = true;
            this.dataGridViewHotel.RowHeadersWidth = 51;
            this.dataGridViewHotel.RowTemplate.Height = 24;
            this.dataGridViewHotel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHotel.Size = new System.Drawing.Size(809, 376);
            this.dataGridViewHotel.TabIndex = 0;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomDataGridViewTextBoxColumn.Width = 54;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresseDataGridViewTextBoxColumn.Width = 70;
            // 
            // cpDataGridViewTextBoxColumn
            // 
            this.cpDataGridViewTextBoxColumn.DataPropertyName = "cp";
            this.cpDataGridViewTextBoxColumn.HeaderText = "Code postal";
            this.cpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cpDataGridViewTextBoxColumn.Name = "cpDataGridViewTextBoxColumn";
            this.cpDataGridViewTextBoxColumn.ReadOnly = true;
            this.cpDataGridViewTextBoxColumn.Width = 81;
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "ville";
            this.villeDataGridViewTextBoxColumn.HeaderText = "Ville";
            this.villeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            this.villeDataGridViewTextBoxColumn.ReadOnly = true;
            this.villeDataGridViewTextBoxColumn.Width = 51;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "N° de téléphone";
            this.telDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prixChambreDataGridViewTextBoxColumn
            // 
            this.prixChambreDataGridViewTextBoxColumn.DataPropertyName = "prixChambre";
            this.prixChambreDataGridViewTextBoxColumn.HeaderText = "Prix / Chambre";
            this.prixChambreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prixChambreDataGridViewTextBoxColumn.Name = "prixChambreDataGridViewTextBoxColumn";
            this.prixChambreDataGridViewTextBoxColumn.ReadOnly = true;
            this.prixChambreDataGridViewTextBoxColumn.Width = 94;
            // 
            // idCategDataGridViewTextBoxColumn
            // 
            this.idCategDataGridViewTextBoxColumn.DataPropertyName = "idCateg";
            this.idCategDataGridViewTextBoxColumn.HeaderText = "Nombre d\'étoiles";
            this.idCategDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idCategDataGridViewTextBoxColumn.Name = "idCategDataGridViewTextBoxColumn";
            this.idCategDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCategDataGridViewTextBoxColumn.Width = 101;
            // 
            // bindSrcHotels
            // 
            this.bindSrcHotels.DataSource = typeof(GestionOrganisationCongres.Hotel);
            // 
            // detailsHotels
            // 
            this.detailsHotels.Controls.Add(this.maskedTextBoxTel);
            this.detailsHotels.Controls.Add(this.lblTel);
            this.detailsHotels.Controls.Add(this.txtBoxPrixHotel);
            this.detailsHotels.Controls.Add(this.lblEuro);
            this.detailsHotels.Controls.Add(this.txtBoxAdresseHotel);
            this.detailsHotels.Controls.Add(this.txtBoxVilleHotel);
            this.detailsHotels.Controls.Add(this.btValiderHotel);
            this.detailsHotels.Controls.Add(this.btAnnulerAjoutHotel);
            this.detailsHotels.Controls.Add(this.txtBoxNomHotel);
            this.detailsHotels.Controls.Add(this.maskedTxtBoxCpHotel);
            this.detailsHotels.Controls.Add(this.comboBoxNbEtoileHotel);
            this.detailsHotels.Controls.Add(this.lblPrixHotel);
            this.detailsHotels.Controls.Add(this.lblNbEtoileHotel);
            this.detailsHotels.Controls.Add(this.lblCpHotel);
            this.detailsHotels.Controls.Add(this.lblAdresseHotel);
            this.detailsHotels.Controls.Add(this.lblVilleHotel);
            this.detailsHotels.Controls.Add(this.lblNomHotel);
            this.detailsHotels.Controls.Add(this.btSupprimerHotel);
            this.detailsHotels.Location = new System.Drawing.Point(4, 22);
            this.detailsHotels.Margin = new System.Windows.Forms.Padding(2);
            this.detailsHotels.Name = "detailsHotels";
            this.detailsHotels.Padding = new System.Windows.Forms.Padding(2);
            this.detailsHotels.Size = new System.Drawing.Size(815, 467);
            this.detailsHotels.TabIndex = 1;
            this.detailsHotels.Text = "Détails";
            this.detailsHotels.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxTel
            // 
            this.maskedTextBoxTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHotels, "tel", true));
            this.maskedTextBoxTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTextBoxTel.Location = new System.Drawing.Point(230, 220);
            this.maskedTextBoxTel.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBoxTel.Mask = "9999999999";
            this.maskedTextBoxTel.Name = "maskedTextBoxTel";
            this.maskedTextBoxTel.Size = new System.Drawing.Size(90, 23);
            this.maskedTextBoxTel.TabIndex = 4;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTel.Location = new System.Drawing.Point(130, 223);
            this.lblTel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(96, 20);
            this.lblTel.TabIndex = 53;
            this.lblTel.Text = "Téléphone : ";
            // 
            // txtBoxPrixHotel
            // 
            this.txtBoxPrixHotel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHotels, "prixChambre", true));
            this.txtBoxPrixHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxPrixHotel.Location = new System.Drawing.Point(185, 271);
            this.txtBoxPrixHotel.Name = "txtBoxPrixHotel";
            this.txtBoxPrixHotel.Size = new System.Drawing.Size(85, 23);
            this.txtBoxPrixHotel.TabIndex = 5;
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro.Location = new System.Drawing.Point(276, 274);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(18, 20);
            this.lblEuro.TabIndex = 51;
            this.lblEuro.Text = "€";
            // 
            // txtBoxAdresseHotel
            // 
            this.txtBoxAdresseHotel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHotels, "adresse", true));
            this.txtBoxAdresseHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxAdresseHotel.Location = new System.Drawing.Point(222, 76);
            this.txtBoxAdresseHotel.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxAdresseHotel.Name = "txtBoxAdresseHotel";
            this.txtBoxAdresseHotel.Size = new System.Drawing.Size(198, 23);
            this.txtBoxAdresseHotel.TabIndex = 1;
            // 
            // txtBoxVilleHotel
            // 
            this.txtBoxVilleHotel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHotels, "ville", true));
            this.txtBoxVilleHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxVilleHotel.Location = new System.Drawing.Point(188, 128);
            this.txtBoxVilleHotel.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxVilleHotel.Name = "txtBoxVilleHotel";
            this.txtBoxVilleHotel.Size = new System.Drawing.Size(198, 23);
            this.txtBoxVilleHotel.TabIndex = 2;
            // 
            // btValiderHotel
            // 
            this.btValiderHotel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btValiderHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btValiderHotel.Location = new System.Drawing.Point(567, 388);
            this.btValiderHotel.Margin = new System.Windows.Forms.Padding(2);
            this.btValiderHotel.Name = "btValiderHotel";
            this.btValiderHotel.Size = new System.Drawing.Size(93, 48);
            this.btValiderHotel.TabIndex = 48;
            this.btValiderHotel.Text = "Valider";
            this.btValiderHotel.UseVisualStyleBackColor = false;
            this.btValiderHotel.Click += new System.EventHandler(this.btValiderHotel_Click);
            // 
            // btAnnulerAjoutHotel
            // 
            this.btAnnulerAjoutHotel.BackColor = System.Drawing.Color.LightPink;
            this.btAnnulerAjoutHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btAnnulerAjoutHotel.Location = new System.Drawing.Point(80, 388);
            this.btAnnulerAjoutHotel.Margin = new System.Windows.Forms.Padding(2);
            this.btAnnulerAjoutHotel.Name = "btAnnulerAjoutHotel";
            this.btAnnulerAjoutHotel.Size = new System.Drawing.Size(108, 49);
            this.btAnnulerAjoutHotel.TabIndex = 47;
            this.btAnnulerAjoutHotel.Text = "Annuler";
            this.btAnnulerAjoutHotel.UseVisualStyleBackColor = false;
            this.btAnnulerAjoutHotel.Click += new System.EventHandler(this.btAnnulerAjoutHotel_Click);
            // 
            // txtBoxNomHotel
            // 
            this.txtBoxNomHotel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHotels, "nom", true));
            this.txtBoxNomHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxNomHotel.Location = new System.Drawing.Point(192, 27);
            this.txtBoxNomHotel.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxNomHotel.Name = "txtBoxNomHotel";
            this.txtBoxNomHotel.Size = new System.Drawing.Size(274, 23);
            this.txtBoxNomHotel.TabIndex = 0;
            // 
            // maskedTxtBoxCpHotel
            // 
            this.maskedTxtBoxCpHotel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHotels, "cp", true));
            this.maskedTxtBoxCpHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTxtBoxCpHotel.Location = new System.Drawing.Point(244, 174);
            this.maskedTxtBoxCpHotel.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTxtBoxCpHotel.Mask = "99999";
            this.maskedTxtBoxCpHotel.Name = "maskedTxtBoxCpHotel";
            this.maskedTxtBoxCpHotel.Size = new System.Drawing.Size(65, 23);
            this.maskedTxtBoxCpHotel.TabIndex = 3;
            // 
            // comboBoxNbEtoileHotel
            // 
            this.comboBoxNbEtoileHotel.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindSrcHotels, "Categorie", true));
            this.comboBoxNbEtoileHotel.DataSource = this.bindSrcCategorie;
            this.comboBoxNbEtoileHotel.DisplayMember = "nbEtoiles";
            this.comboBoxNbEtoileHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxNbEtoileHotel.FormattingEnabled = true;
            this.comboBoxNbEtoileHotel.Location = new System.Drawing.Point(285, 309);
            this.comboBoxNbEtoileHotel.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxNbEtoileHotel.Name = "comboBoxNbEtoileHotel";
            this.comboBoxNbEtoileHotel.Size = new System.Drawing.Size(92, 24);
            this.comboBoxNbEtoileHotel.TabIndex = 6;
            // 
            // bindSrcCategorie
            // 
            this.bindSrcCategorie.DataSource = typeof(GestionOrganisationCongres.Categorie);
            // 
            // lblPrixHotel
            // 
            this.lblPrixHotel.AutoSize = true;
            this.lblPrixHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrixHotel.Location = new System.Drawing.Point(134, 271);
            this.lblPrixHotel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrixHotel.Name = "lblPrixHotel";
            this.lblPrixHotel.Size = new System.Drawing.Size(46, 20);
            this.lblPrixHotel.TabIndex = 8;
            this.lblPrixHotel.Text = "Prix : ";
            // 
            // lblNbEtoileHotel
            // 
            this.lblNbEtoileHotel.AutoSize = true;
            this.lblNbEtoileHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNbEtoileHotel.Location = new System.Drawing.Point(134, 313);
            this.lblNbEtoileHotel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNbEtoileHotel.Name = "lblNbEtoileHotel";
            this.lblNbEtoileHotel.Size = new System.Drawing.Size(147, 20);
            this.lblNbEtoileHotel.TabIndex = 7;
            this.lblNbEtoileHotel.Text = "Nombres d\'étoiles : ";
            // 
            // lblCpHotel
            // 
            this.lblCpHotel.AutoSize = true;
            this.lblCpHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCpHotel.Location = new System.Drawing.Point(134, 177);
            this.lblCpHotel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCpHotel.Name = "lblCpHotel";
            this.lblCpHotel.Size = new System.Drawing.Size(106, 20);
            this.lblCpHotel.TabIndex = 6;
            this.lblCpHotel.Text = "Code postal : ";
            // 
            // lblAdresseHotel
            // 
            this.lblAdresseHotel.AutoSize = true;
            this.lblAdresseHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAdresseHotel.Location = new System.Drawing.Point(134, 76);
            this.lblAdresseHotel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdresseHotel.Name = "lblAdresseHotel";
            this.lblAdresseHotel.Size = new System.Drawing.Size(80, 20);
            this.lblAdresseHotel.TabIndex = 5;
            this.lblAdresseHotel.Text = "Adresse : ";
            // 
            // lblVilleHotel
            // 
            this.lblVilleHotel.AutoSize = true;
            this.lblVilleHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblVilleHotel.Location = new System.Drawing.Point(134, 128);
            this.lblVilleHotel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVilleHotel.Name = "lblVilleHotel";
            this.lblVilleHotel.Size = new System.Drawing.Size(50, 20);
            this.lblVilleHotel.TabIndex = 4;
            this.lblVilleHotel.Text = "Ville : ";
            // 
            // lblNomHotel
            // 
            this.lblNomHotel.AutoSize = true;
            this.lblNomHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNomHotel.Location = new System.Drawing.Point(134, 27);
            this.lblNomHotel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomHotel.Name = "lblNomHotel";
            this.lblNomHotel.Size = new System.Drawing.Size(54, 20);
            this.lblNomHotel.TabIndex = 3;
            this.lblNomHotel.Text = "Nom : ";
            // 
            // btSupprimerHotel
            // 
            this.btSupprimerHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btSupprimerHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btSupprimerHotel.Location = new System.Drawing.Point(277, 388);
            this.btSupprimerHotel.Margin = new System.Windows.Forms.Padding(2);
            this.btSupprimerHotel.Name = "btSupprimerHotel";
            this.btSupprimerHotel.Size = new System.Drawing.Size(189, 49);
            this.btSupprimerHotel.TabIndex = 12;
            this.btSupprimerHotel.Text = "Supprimer l\'hôtel";
            this.btSupprimerHotel.UseVisualStyleBackColor = false;
            this.btSupprimerHotel.Click += new System.EventHandler(this.btSupprimerHotel_Click);
            // 
            // FrmGestionHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(843, 514);
            this.Controls.Add(this.tabControlHotel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmGestionHotel";
            this.Text = "Gestion Hôtel";
            this.Load += new System.EventHandler(this.FrmGestionHotel_Load);
            this.tabControlHotel.ResumeLayout(false);
            this.listeHotel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcHotels)).EndInit();
            this.detailsHotels.ResumeLayout(false);
            this.detailsHotels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcCategorie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlHotel;
        private System.Windows.Forms.TabPage listeHotel;
        private System.Windows.Forms.Button btAjouterHotel;
        private System.Windows.Forms.DataGridView dataGridViewHotel;
        private System.Windows.Forms.TabPage detailsHotels;
        private System.Windows.Forms.Button btValiderHotel;
        private System.Windows.Forms.Button btAnnulerAjoutHotel;
        private System.Windows.Forms.TextBox txtBoxNomHotel;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxCpHotel;
        private System.Windows.Forms.ComboBox comboBoxNbEtoileHotel;
        private System.Windows.Forms.Label lblPrixHotel;
        private System.Windows.Forms.Label lblNbEtoileHotel;
        private System.Windows.Forms.Label lblCpHotel;
        private System.Windows.Forms.Label lblAdresseHotel;
        private System.Windows.Forms.Label lblVilleHotel;
        private System.Windows.Forms.Label lblNomHotel;
        private System.Windows.Forms.Button btSupprimerHotel;
        private System.Windows.Forms.TextBox txtBoxAdresseHotel;
        private System.Windows.Forms.TextBox txtBoxVilleHotel;
        private System.Windows.Forms.BindingSource bindSrcHotels;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixChambreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.TextBox txtBoxPrixHotel;
        private System.Windows.Forms.BindingSource bindSrcCategorie;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTel;
        private System.Windows.Forms.Label lblTel;
    }
}