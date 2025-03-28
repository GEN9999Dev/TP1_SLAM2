namespace TP1.Model
{
    partial class MenuPrincipal
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlSf = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tsJeu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsJeuDemarrer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsScore = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGestionQuestions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGestionQuestionAffichage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsInterrogation = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pnlSf
            // 
            this.pnlSf.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlSf.Location = new System.Drawing.Point(0, 27);
            this.pnlSf.Name = "pnlSf";
            this.pnlSf.Size = new System.Drawing.Size(1489, 696);
            this.pnlSf.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsJeu,
            this.tsScore,
            this.tsGestionQuestions,
            this.tsInterrogation});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // tsJeu
            // 
            this.tsJeu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsJeuDemarrer});
            this.tsJeu.Name = "tsJeu";
            this.tsJeu.Size = new System.Drawing.Size(36, 20);
            this.tsJeu.Text = "Jeu";
            // 
            // tsJeuDemarrer
            // 
            this.tsJeuDemarrer.Name = "tsJeuDemarrer";
            this.tsJeuDemarrer.Size = new System.Drawing.Size(123, 22);
            this.tsJeuDemarrer.Text = "Démarrer";
            this.tsJeuDemarrer.Click += new System.EventHandler(this.démarrerToolStripMenuItem_Click_1);
            // 
            // tsScore
            // 
            this.tsScore.Name = "tsScore";
            this.tsScore.Size = new System.Drawing.Size(48, 20);
            this.tsScore.Text = "Score";
            // 
            // tsGestionQuestions
            // 
            this.tsGestionQuestions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsGestionQuestionAffichage});
            this.tsGestionQuestions.Name = "tsGestionQuestions";
            this.tsGestionQuestions.Size = new System.Drawing.Size(134, 20);
            this.tsGestionQuestions.Text = "Gestion des questions";
            // 
            // tsGestionQuestionAffichage
            // 
            this.tsGestionQuestionAffichage.Name = "tsGestionQuestionAffichage";
            this.tsGestionQuestionAffichage.Size = new System.Drawing.Size(180, 22);
            this.tsGestionQuestionAffichage.Text = "Affichage";
            this.tsGestionQuestionAffichage.Click += new System.EventHandler(this.tsGestionQuestionAffichage_Click);
            // 
            // tsInterrogation
            // 
            this.tsInterrogation.Name = "tsInterrogation";
            this.tsInterrogation.Size = new System.Drawing.Size(24, 20);
            this.tsInterrogation.Text = "?";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 716);
            this.Controls.Add(this.pnlSf);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "MenuPrincipal";
            this.Text = "QuizzNTest";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.Panel pnlSf;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tsJeu;
        private System.Windows.Forms.ToolStripMenuItem tsJeuDemarrer;
        private System.Windows.Forms.ToolStripMenuItem tsScore;
        private System.Windows.Forms.ToolStripMenuItem tsGestionQuestions;
        private System.Windows.Forms.ToolStripMenuItem tsGestionQuestionAffichage;
        private System.Windows.Forms.ToolStripMenuItem tsInterrogation;
    }
}