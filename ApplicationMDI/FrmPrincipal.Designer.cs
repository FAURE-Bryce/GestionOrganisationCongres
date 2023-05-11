namespace ApplicationMDI
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.qUITTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionActivitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionHôtelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionInscritToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qUITTERToolStripMenuItem,
            this.gestionActivitéToolStripMenuItem,
            this.gestionHôtelToolStripMenuItem,
            this.gestionInscritToolStripMenuItem,
            this.gestionSessionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // qUITTERToolStripMenuItem
            // 
            this.qUITTERToolStripMenuItem.Name = "qUITTERToolStripMenuItem";
            this.qUITTERToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.qUITTERToolStripMenuItem.Text = "QUITTER";
            this.qUITTERToolStripMenuItem.Click += new System.EventHandler(this.qUITTERToolStripMenuItem_Click);
            // 
            // gestionActivitéToolStripMenuItem
            // 
            this.gestionActivitéToolStripMenuItem.Name = "gestionActivitéToolStripMenuItem";
            this.gestionActivitéToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.gestionActivitéToolStripMenuItem.Text = "Gestion Activité";
            this.gestionActivitéToolStripMenuItem.Click += new System.EventHandler(this.gestionActivitéToolStripMenuItem_Click);
            // 
            // gestionHôtelToolStripMenuItem
            // 
            this.gestionHôtelToolStripMenuItem.Name = "gestionHôtelToolStripMenuItem";
            this.gestionHôtelToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.gestionHôtelToolStripMenuItem.Text = "Gestion Hôtel";
            this.gestionHôtelToolStripMenuItem.Click += new System.EventHandler(this.gestionHôtelToolStripMenuItem_Click);
            // 
            // gestionInscritToolStripMenuItem
            // 
            this.gestionInscritToolStripMenuItem.Name = "gestionInscritToolStripMenuItem";
            this.gestionInscritToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.gestionInscritToolStripMenuItem.Text = "Gestion Inscription";
            this.gestionInscritToolStripMenuItem.Click += new System.EventHandler(this.gestionInscritToolStripMenuItem_Click);
            // 
            // gestionSessionToolStripMenuItem
            // 
            this.gestionSessionToolStripMenuItem.Name = "gestionSessionToolStripMenuItem";
            this.gestionSessionToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.gestionSessionToolStripMenuItem.Text = "Gestion Session";
            this.gestionSessionToolStripMenuItem.Click += new System.EventHandler(this.gestionSessionToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 411);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Menu Organisation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem qUITTERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionActivitéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionHôtelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionInscritToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionSessionToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

