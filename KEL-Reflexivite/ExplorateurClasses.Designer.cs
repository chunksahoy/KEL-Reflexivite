namespace KEL_Reflexivite
{
    partial class ExplorateurClasses
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
            this.LB_Classes = new System.Windows.Forms.ListBox();
            this.LB_Methodes = new System.Windows.Forms.ListBox();
            this.LB_Constructeurs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_Statut = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LBL_Objet = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerObjetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Classes
            // 
            this.LB_Classes.FormattingEnabled = true;
            this.LB_Classes.Location = new System.Drawing.Point(12, 53);
            this.LB_Classes.Name = "LB_Classes";
            this.LB_Classes.Size = new System.Drawing.Size(137, 186);
            this.LB_Classes.TabIndex = 0;
            this.LB_Classes.SelectedIndexChanged += new System.EventHandler(this.LB_Classes_SelectedIndexChanged);
            // 
            // LB_Methodes
            // 
            this.LB_Methodes.FormattingEnabled = true;
            this.LB_Methodes.Location = new System.Drawing.Point(12, 258);
            this.LB_Methodes.Name = "LB_Methodes";
            this.LB_Methodes.Size = new System.Drawing.Size(556, 147);
            this.LB_Methodes.TabIndex = 1;
            // 
            // LB_Constructeurs
            // 
            this.LB_Constructeurs.FormattingEnabled = true;
            this.LB_Constructeurs.Location = new System.Drawing.Point(289, 53);
            this.LB_Constructeurs.Name = "LB_Constructeurs";
            this.LB_Constructeurs.Size = new System.Drawing.Size(279, 147);
            this.LB_Constructeurs.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Objet:";
            // 
            // LBL_Statut
            // 
            this.LBL_Statut.AutoSize = true;
            this.LBL_Statut.Location = new System.Drawing.Point(327, 203);
            this.LBL_Statut.Name = "LBL_Statut";
            this.LBL_Statut.Size = new System.Drawing.Size(34, 13);
            this.LBL_Statut.TabIndex = 6;
            this.LBL_Statut.Text = "Inerte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Objets";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Méthodes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Constructeurs";
            // 
            // LBL_Objet
            // 
            this.LBL_Objet.AutoSize = true;
            this.LBL_Objet.Location = new System.Drawing.Point(286, 226);
            this.LBL_Objet.Name = "LBL_Objet";
            this.LBL_Objet.Size = new System.Drawing.Size(0, 13);
            this.LBL_Objet.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(580, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerObjetToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // créerObjetToolStripMenuItem
            // 
            this.créerObjetToolStripMenuItem.Name = "créerObjetToolStripMenuItem";
            this.créerObjetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.créerObjetToolStripMenuItem.Text = "Créer Objet";
            this.créerObjetToolStripMenuItem.Click += new System.EventHandler(this.créerObjetToolStripMenuItem_Click);
            // 
            // ExplorateurClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 418);
            this.Controls.Add(this.LBL_Objet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBL_Statut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_Constructeurs);
            this.Controls.Add(this.LB_Methodes);
            this.Controls.Add(this.LB_Classes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ExplorateurClasses";
            this.Load += new System.EventHandler(this.ConstructeurClasses_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Classes;
        private System.Windows.Forms.ListBox LB_Methodes;
        private System.Windows.Forms.ListBox LB_Constructeurs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_Statut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LBL_Objet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerObjetToolStripMenuItem;
    }
}

