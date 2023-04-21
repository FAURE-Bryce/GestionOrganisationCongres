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
            this.idHotelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixChambreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.congressistesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcHotels = new System.Windows.Forms.BindingSource(this.components);
            this.detailsHotels = new System.Windows.Forms.TabPage();
            this.txtBoxAdresseHotel = new System.Windows.Forms.TextBox();
            this.txtBoxVilleHotel = new System.Windows.Forms.TextBox();
            this.btValiderModifHotel = new System.Windows.Forms.Button();
            this.btAnnulerModifHotel = new System.Windows.Forms.Button();
            this.txtBoxNomHotel = new System.Windows.Forms.TextBox();
            this.comboBoxNbEtoileHotel = new System.Windows.Forms.ComboBox();
            this.lblPrixHotel = new System.Windows.Forms.Label();
            this.lblNbEtoileHotel = new System.Windows.Forms.Label();
            this.lblCpHotel = new System.Windows.Forms.Label();
            this.lblAdresseHotel = new System.Windows.Forms.Label();
            this.lblVilleHotel = new System.Windows.Forms.Label();
            this.lblNomHotel = new System.Windows.Forms.Label();
            this.btSupprimerHotel = new System.Windows.Forms.Button();
            this.maskedTxtBoxPrixHotel = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtBoxCpHotel = new System.Windows.Forms.MaskedTextBox();
            this.tabControlHotel.SuspendLayout();
            this.listeHotel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcHotels)).BeginInit();
            this.detailsHotels.SuspendLayout();
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
            this.tabControlHotel.Size = new System.Drawing.Size(582, 346);
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
            this.listeHotel.Size = new System.Drawing.Size(574, 320);
            this.listeHotel.TabIndex = 0;
            this.listeHotel.Text = "Liste";
            this.listeHotel.UseVisualStyleBackColor = true;
            // 
            // btAjouterHotel
            // 
            this.btAjouterHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btAjouterHotel.Location = new System.Drawing.Point(210, 288);
            this.btAjouterHotel.Margin = new System.Windows.Forms.Padding(2);
            this.btAjouterHotel.Name = "btAjouterHotel";
            this.btAjouterHotel.Size = new System.Drawing.Size(155, 24);
            this.btAjouterHotel.TabIndex = 1;
            this.btAjouterHotel.Text = "Ajouter un hôtel";
            this.btAjouterHotel.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHotel
            // 
            this.dataGridViewHotel.AllowUserToAddRows = false;
            this.dataGridViewHotel.AllowUserToDeleteRows = false;
            this.dataGridViewHotel.AutoGenerateColumns = false;
            this.dataGridViewHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHotel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idHotelDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.cpDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.prixChambreDataGridViewTextBoxColumn,
            this.idCategDataGridViewTextBoxColumn,
            this.congressistesDataGridViewTextBoxColumn});
            this.dataGridViewHotel.DataSource = this.bindSrcHotels;
            this.dataGridViewHotel.Location = new System.Drawing.Point(2, 5);
            this.dataGridViewHotel.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewHotel.Name = "dataGridViewHotel";
            this.dataGridViewHotel.ReadOnly = true;
            this.dataGridViewHotel.RowHeadersWidth = 51;
            this.dataGridViewHotel.RowTemplate.Height = 24;
            this.dataGridViewHotel.Size = new System.Drawing.Size(569, 272);
            this.dataGridViewHotel.TabIndex = 0;
            // 
            // idHotelDataGridViewTextBoxColumn
            // 
            this.idHotelDataGridViewTextBoxColumn.DataPropertyName = "idHotel";
            this.idHotelDataGridViewTextBoxColumn.HeaderText = "idHotel";
            this.idHotelDataGridViewTextBoxColumn.Name = "idHotelDataGridViewTextBoxColumn";
            this.idHotelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
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
            // prixChambreDataGridViewTextBoxColumn
            // 
            this.prixChambreDataGridViewTextBoxColumn.DataPropertyName = "prixChambre";
            this.prixChambreDataGridViewTextBoxColumn.HeaderText = "prixChambre";
            this.prixChambreDataGridViewTextBoxColumn.Name = "prixChambreDataGridViewTextBoxColumn";
            this.prixChambreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idCategDataGridViewTextBoxColumn
            // 
            this.idCategDataGridViewTextBoxColumn.DataPropertyName = "idCateg";
            this.idCategDataGridViewTextBoxColumn.HeaderText = "idCateg";
            this.idCategDataGridViewTextBoxColumn.Name = "idCategDataGridViewTextBoxColumn";
            this.idCategDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // congressistesDataGridViewTextBoxColumn
            // 
            this.congressistesDataGridViewTextBoxColumn.DataPropertyName = "Congressistes";
            this.congressistesDataGridViewTextBoxColumn.HeaderText = "Congressistes";
            this.congressistesDataGridViewTextBoxColumn.Name = "congressistesDataGridViewTextBoxColumn";
            this.congressistesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindSrcHotels
            // 
            this.bindSrcHotels.DataSource = typeof(GestionOrganisationCongres.Hotel);
            // 
            // detailsHotels
            // 
            this.detailsHotels.Controls.Add(this.txtBoxAdresseHotel);
            this.detailsHotels.Controls.Add(this.txtBoxVilleHotel);
            this.detailsHotels.Controls.Add(this.btValiderModifHotel);
            this.detailsHotels.Controls.Add(this.btAnnulerModifHotel);
            this.detailsHotels.Controls.Add(this.txtBoxNomHotel);
            this.detailsHotels.Controls.Add(this.maskedTxtBoxCpHotel);
            this.detailsHotels.Controls.Add(this.comboBoxNbEtoileHotel);
            this.detailsHotels.Controls.Add(this.maskedTxtBoxPrixHotel);
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
            this.detailsHotels.Size = new System.Drawing.Size(574, 320);
            this.detailsHotels.TabIndex = 1;
            this.detailsHotels.Text = "Détails";
            this.detailsHotels.UseVisualStyleBackColor = true;
            // 
            // txtBoxAdresseHotel
            // 
            this.txtBoxAdresseHotel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHotels, "adresse", true));
            this.txtBoxAdresseHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxAdresseHotel.Location = new System.Drawing.Point(222, 49);
            this.txtBoxAdresseHotel.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxAdresseHotel.Name = "txtBoxAdresseHotel";
            this.txtBoxAdresseHotel.Size = new System.Drawing.Size(198, 23);
            this.txtBoxAdresseHotel.TabIndex = 50;
            // 
            // txtBoxVilleHotel
            // 
            this.txtBoxVilleHotel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHotels, "ville", true));
            this.txtBoxVilleHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxVilleHotel.Location = new System.Drawing.Point(200, 86);
            this.txtBoxVilleHotel.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxVilleHotel.Name = "txtBoxVilleHotel";
            this.txtBoxVilleHotel.Size = new System.Drawing.Size(198, 23);
            this.txtBoxVilleHotel.TabIndex = 49;
            // 
            // btValiderModifHotel
            // 
            this.btValiderModifHotel.BackColor = System.Drawing.Color.LawnGreen;
            this.btValiderModifHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btValiderModifHotel.Location = new System.Drawing.Point(197, 292);
            this.btValiderModifHotel.Margin = new System.Windows.Forms.Padding(2);
            this.btValiderModifHotel.Name = "btValiderModifHotel";
            this.btValiderModifHotel.Size = new System.Drawing.Size(65, 24);
            this.btValiderModifHotel.TabIndex = 48;
            this.btValiderModifHotel.Text = "Valider";
            this.btValiderModifHotel.UseVisualStyleBackColor = false;
            // 
            // btAnnulerModifHotel
            // 
            this.btAnnulerModifHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btAnnulerModifHotel.Location = new System.Drawing.Point(324, 293);
            this.btAnnulerModifHotel.Margin = new System.Windows.Forms.Padding(2);
            this.btAnnulerModifHotel.Name = "btAnnulerModifHotel";
            this.btAnnulerModifHotel.Size = new System.Drawing.Size(74, 24);
            this.btAnnulerModifHotel.TabIndex = 47;
            this.btAnnulerModifHotel.Text = "Annuler";
            this.btAnnulerModifHotel.UseVisualStyleBackColor = true;
            // 
            // txtBoxNomHotel
            // 
            this.txtBoxNomHotel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHotels, "nom", true));
            this.txtBoxNomHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxNomHotel.Location = new System.Drawing.Point(214, 15);
            this.txtBoxNomHotel.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxNomHotel.Name = "txtBoxNomHotel";
            this.txtBoxNomHotel.Size = new System.Drawing.Size(198, 23);
            this.txtBoxNomHotel.TabIndex = 2;
            // 
            // comboBoxNbEtoileHotel
            // 
            this.comboBoxNbEtoileHotel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHotels, "idCateg", true));
            this.comboBoxNbEtoileHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxNbEtoileHotel.FormattingEnabled = true;
            this.comboBoxNbEtoileHotel.Location = new System.Drawing.Point(277, 212);
            this.comboBoxNbEtoileHotel.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxNbEtoileHotel.Name = "comboBoxNbEtoileHotel";
            this.comboBoxNbEtoileHotel.Size = new System.Drawing.Size(92, 24);
            this.comboBoxNbEtoileHotel.TabIndex = 6;
            // 
            // lblPrixHotel
            // 
            this.lblPrixHotel.AutoSize = true;
            this.lblPrixHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPrixHotel.Location = new System.Drawing.Point(153, 172);
            this.lblPrixHotel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrixHotel.Name = "lblPrixHotel";
            this.lblPrixHotel.Size = new System.Drawing.Size(43, 17);
            this.lblPrixHotel.TabIndex = 8;
            this.lblPrixHotel.Text = "Prix : ";
            // 
            // lblNbEtoileHotel
            // 
            this.lblNbEtoileHotel.AutoSize = true;
            this.lblNbEtoileHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNbEtoileHotel.Location = new System.Drawing.Point(153, 214);
            this.lblNbEtoileHotel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNbEtoileHotel.Name = "lblNbEtoileHotel";
            this.lblNbEtoileHotel.Size = new System.Drawing.Size(133, 17);
            this.lblNbEtoileHotel.TabIndex = 7;
            this.lblNbEtoileHotel.Text = "Nombres d\'étoiles : ";
            // 
            // lblCpHotel
            // 
            this.lblCpHotel.AutoSize = true;
            this.lblCpHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCpHotel.Location = new System.Drawing.Point(153, 130);
            this.lblCpHotel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCpHotel.Name = "lblCpHotel";
            this.lblCpHotel.Size = new System.Drawing.Size(95, 17);
            this.lblCpHotel.TabIndex = 6;
            this.lblCpHotel.Text = "Code postal : ";
            // 
            // lblAdresseHotel
            // 
            this.lblAdresseHotel.AutoSize = true;
            this.lblAdresseHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAdresseHotel.Location = new System.Drawing.Point(153, 51);
            this.lblAdresseHotel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdresseHotel.Name = "lblAdresseHotel";
            this.lblAdresseHotel.Size = new System.Drawing.Size(72, 17);
            this.lblAdresseHotel.TabIndex = 5;
            this.lblAdresseHotel.Text = "Adresse : ";
            // 
            // lblVilleHotel
            // 
            this.lblVilleHotel.AutoSize = true;
            this.lblVilleHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVilleHotel.Location = new System.Drawing.Point(153, 89);
            this.lblVilleHotel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVilleHotel.Name = "lblVilleHotel";
            this.lblVilleHotel.Size = new System.Drawing.Size(46, 17);
            this.lblVilleHotel.TabIndex = 4;
            this.lblVilleHotel.Text = "Ville : ";
            // 
            // lblNomHotel
            // 
            this.lblNomHotel.AutoSize = true;
            this.lblNomHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNomHotel.Location = new System.Drawing.Point(153, 18);
            this.lblNomHotel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomHotel.Name = "lblNomHotel";
            this.lblNomHotel.Size = new System.Drawing.Size(49, 17);
            this.lblNomHotel.TabIndex = 3;
            this.lblNomHotel.Text = "Nom : ";
            // 
            // btSupprimerHotel
            // 
            this.btSupprimerHotel.BackColor = System.Drawing.Color.Red;
            this.btSupprimerHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btSupprimerHotel.Location = new System.Drawing.Point(156, 293);
            this.btSupprimerHotel.Margin = new System.Windows.Forms.Padding(2);
            this.btSupprimerHotel.Name = "btSupprimerHotel";
            this.btSupprimerHotel.Size = new System.Drawing.Size(138, 24);
            this.btSupprimerHotel.TabIndex = 12;
            this.btSupprimerHotel.Text = "Supprimer l\'hôtel";
            this.btSupprimerHotel.UseVisualStyleBackColor = false;
            // 
            // maskedTxtBoxPrixHotel
            // 
            this.maskedTxtBoxPrixHotel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHotels, "prixChambre", true));
            this.maskedTxtBoxPrixHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTxtBoxPrixHotel.Location = new System.Drawing.Point(197, 170);
            this.maskedTxtBoxPrixHotel.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTxtBoxPrixHotel.Mask = "999999";
            this.maskedTxtBoxPrixHotel.Name = "maskedTxtBoxPrixHotel";
            this.maskedTxtBoxPrixHotel.Size = new System.Drawing.Size(76, 23);
            this.maskedTxtBoxPrixHotel.TabIndex = 8;
            // 
            // maskedTxtBoxCpHotel
            // 
            this.maskedTxtBoxCpHotel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcHotels, "cp", true));
            this.maskedTxtBoxCpHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTxtBoxCpHotel.Location = new System.Drawing.Point(252, 127);
            this.maskedTxtBoxCpHotel.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTxtBoxCpHotel.Mask = "99999";
            this.maskedTxtBoxCpHotel.Name = "maskedTxtBoxCpHotel";
            this.maskedTxtBoxCpHotel.Size = new System.Drawing.Size(45, 23);
            this.maskedTxtBoxCpHotel.TabIndex = 5;
            // 
            // FrmGestionHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlHotel;
        private System.Windows.Forms.TabPage listeHotel;
        private System.Windows.Forms.Button btAjouterHotel;
        private System.Windows.Forms.DataGridView dataGridViewHotel;
        private System.Windows.Forms.TabPage detailsHotels;
        private System.Windows.Forms.Button btValiderModifHotel;
        private System.Windows.Forms.Button btAnnulerModifHotel;
        private System.Windows.Forms.TextBox txtBoxNomHotel;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idHotelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixChambreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn congressistesDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxCpHotel;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxPrixHotel;
    }
}