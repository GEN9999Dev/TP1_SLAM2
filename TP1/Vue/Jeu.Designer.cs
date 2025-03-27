namespace TP1
{
    partial class Jeu
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.groupRep = new System.Windows.Forms.GroupBox();
            this.checkRep5 = new System.Windows.Forms.CheckBox();
            this.checkRep4 = new System.Windows.Forms.CheckBox();
            this.checkRep3 = new System.Windows.Forms.CheckBox();
            this.checkRep2 = new System.Windows.Forms.CheckBox();
            this.checkRep1 = new System.Windows.Forms.CheckBox();
            this.btnValiderRep = new System.Windows.Forms.Button();
            this.txtTempsTotal = new System.Windows.Forms.TextBox();
            this.lblTempsTotal = new System.Windows.Forms.Label();
            this.picRep = new System.Windows.Forms.PictureBox();
            this.txtDIfficulte = new System.Windows.Forms.TextBox();
            this.txtNomPrenom = new System.Windows.Forms.TextBox();
            this.lbldifficulte = new System.Windows.Forms.Label();
            this.lblNomPrenom = new System.Windows.Forms.Label();
            this.pbTemps = new System.Windows.Forms.ProgressBar();
            this.lblPbTemps = new System.Windows.Forms.Label();
            this.groupRep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRep)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.lblTitle.Location = new System.Drawing.Point(420, 48);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(188, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quizz And Test";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(274, 94);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(58, 13);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Question 1";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Enabled = false;
            this.txtQuestion.Location = new System.Drawing.Point(259, 110);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(554, 59);
            this.txtQuestion.TabIndex = 2;
            // 
            // groupRep
            // 
            this.groupRep.Controls.Add(this.checkRep5);
            this.groupRep.Controls.Add(this.checkRep4);
            this.groupRep.Controls.Add(this.checkRep3);
            this.groupRep.Controls.Add(this.checkRep2);
            this.groupRep.Controls.Add(this.checkRep1);
            this.groupRep.Location = new System.Drawing.Point(259, 196);
            this.groupRep.Name = "groupRep";
            this.groupRep.Size = new System.Drawing.Size(554, 281);
            this.groupRep.TabIndex = 3;
            this.groupRep.TabStop = false;
            this.groupRep.Text = "Réponses possibles";
            // 
            // checkRep5
            // 
            this.checkRep5.AutoSize = true;
            this.checkRep5.Location = new System.Drawing.Point(6, 234);
            this.checkRep5.Name = "checkRep5";
            this.checkRep5.Size = new System.Drawing.Size(78, 17);
            this.checkRep5.TabIndex = 4;
            this.checkRep5.Text = "Réponse 5";
            this.checkRep5.UseVisualStyleBackColor = true;
            this.checkRep5.Click += new System.EventHandler(this.checkRep1_Click);
            // 
            // checkRep4
            // 
            this.checkRep4.AutoSize = true;
            this.checkRep4.Location = new System.Drawing.Point(6, 186);
            this.checkRep4.Name = "checkRep4";
            this.checkRep4.Size = new System.Drawing.Size(78, 17);
            this.checkRep4.TabIndex = 3;
            this.checkRep4.Text = "Réponse 4";
            this.checkRep4.UseVisualStyleBackColor = true;
            this.checkRep4.Click += new System.EventHandler(this.checkRep1_Click);
            // 
            // checkRep3
            // 
            this.checkRep3.AutoSize = true;
            this.checkRep3.Location = new System.Drawing.Point(6, 137);
            this.checkRep3.Name = "checkRep3";
            this.checkRep3.Size = new System.Drawing.Size(78, 17);
            this.checkRep3.TabIndex = 2;
            this.checkRep3.Text = "Réponse 3";
            this.checkRep3.UseVisualStyleBackColor = true;
            this.checkRep3.Click += new System.EventHandler(this.checkRep1_Click);
            // 
            // checkRep2
            // 
            this.checkRep2.AutoSize = true;
            this.checkRep2.Location = new System.Drawing.Point(6, 87);
            this.checkRep2.Name = "checkRep2";
            this.checkRep2.Size = new System.Drawing.Size(78, 17);
            this.checkRep2.TabIndex = 1;
            this.checkRep2.Text = "Réponse 2";
            this.checkRep2.UseVisualStyleBackColor = true;
            this.checkRep2.Click += new System.EventHandler(this.checkRep1_Click);
            // 
            // checkRep1
            // 
            this.checkRep1.AutoSize = true;
            this.checkRep1.Location = new System.Drawing.Point(6, 33);
            this.checkRep1.Name = "checkRep1";
            this.checkRep1.Size = new System.Drawing.Size(78, 17);
            this.checkRep1.TabIndex = 0;
            this.checkRep1.Text = "Réponse 1";
            this.checkRep1.UseVisualStyleBackColor = true;
            this.checkRep1.Click += new System.EventHandler(this.checkRep1_Click);
            // 
            // btnValiderRep
            // 
            this.btnValiderRep.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnValiderRep.Location = new System.Drawing.Point(470, 519);
            this.btnValiderRep.Name = "btnValiderRep";
            this.btnValiderRep.Size = new System.Drawing.Size(75, 23);
            this.btnValiderRep.TabIndex = 4;
            this.btnValiderRep.Text = "Valider";
            this.btnValiderRep.UseVisualStyleBackColor = false;
            this.btnValiderRep.Click += new System.EventHandler(this.btn_validerRep_Click);
            // 
            // txtTempsTotal
            // 
            this.txtTempsTotal.Enabled = false;
            this.txtTempsTotal.Location = new System.Drawing.Point(1085, 72);
            this.txtTempsTotal.Multiline = true;
            this.txtTempsTotal.Name = "txtTempsTotal";
            this.txtTempsTotal.Size = new System.Drawing.Size(249, 25);
            this.txtTempsTotal.TabIndex = 5;
            // 
            // lblTempsTotal
            // 
            this.lblTempsTotal.AutoSize = true;
            this.lblTempsTotal.Location = new System.Drawing.Point(1082, 48);
            this.lblTempsTotal.Name = "lblTempsTotal";
            this.lblTempsTotal.Size = new System.Drawing.Size(62, 13);
            this.lblTempsTotal.TabIndex = 7;
            this.lblTempsTotal.Text = "Temps total";
            // 
            // picRep
            // 
            this.picRep.Image = global::TP1.Properties.Resources.Interrogation;
            this.picRep.Location = new System.Drawing.Point(1085, 151);
            this.picRep.Name = "picRep";
            this.picRep.Size = new System.Drawing.Size(240, 199);
            this.picRep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRep.TabIndex = 6;
            this.picRep.TabStop = false;
            // 
            // txtDIfficulte
            // 
            this.txtDIfficulte.Enabled = false;
            this.txtDIfficulte.Location = new System.Drawing.Point(1085, 517);
            this.txtDIfficulte.Multiline = true;
            this.txtDIfficulte.Name = "txtDIfficulte";
            this.txtDIfficulte.Size = new System.Drawing.Size(249, 25);
            this.txtDIfficulte.TabIndex = 8;
            // 
            // txtNomPrenom
            // 
            this.txtNomPrenom.Enabled = false;
            this.txtNomPrenom.Location = new System.Drawing.Point(1085, 486);
            this.txtNomPrenom.Multiline = true;
            this.txtNomPrenom.Name = "txtNomPrenom";
            this.txtNomPrenom.Size = new System.Drawing.Size(249, 25);
            this.txtNomPrenom.TabIndex = 9;
            // 
            // lbldifficulte
            // 
            this.lbldifficulte.AutoSize = true;
            this.lbldifficulte.Location = new System.Drawing.Point(986, 520);
            this.lbldifficulte.Name = "lbldifficulte";
            this.lbldifficulte.Size = new System.Drawing.Size(54, 13);
            this.lbldifficulte.TabIndex = 10;
            this.lbldifficulte.Text = "Difficulté :";
            // 
            // lblNomPrenom
            // 
            this.lblNomPrenom.AutoSize = true;
            this.lblNomPrenom.Location = new System.Drawing.Point(986, 489);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(35, 13);
            this.lblNomPrenom.TabIndex = 11;
            this.lblNomPrenom.Text = "Nom :";
            // 
            // pbTemps
            // 
            this.pbTemps.Location = new System.Drawing.Point(1085, 396);
            this.pbTemps.Name = "pbTemps";
            this.pbTemps.Size = new System.Drawing.Size(235, 29);
            this.pbTemps.TabIndex = 12;
            // 
            // lblPbTemps
            // 
            this.lblPbTemps.AutoSize = true;
            this.lblPbTemps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblPbTemps.Location = new System.Drawing.Point(1082, 364);
            this.lblPbTemps.Name = "lblPbTemps";
            this.lblPbTemps.Size = new System.Drawing.Size(202, 17);
            this.lblPbTemps.TabIndex = 13;
            this.lblPbTemps.Text = "Temps restant pour répondre :";
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1473, 657);
            this.Controls.Add(this.lblPbTemps);
            this.Controls.Add(this.pbTemps);
            this.Controls.Add(this.lblNomPrenom);
            this.Controls.Add(this.lbldifficulte);
            this.Controls.Add(this.txtNomPrenom);
            this.Controls.Add(this.txtDIfficulte);
            this.Controls.Add(this.lblTempsTotal);
            this.Controls.Add(this.picRep);
            this.Controls.Add(this.txtTempsTotal);
            this.Controls.Add(this.btnValiderRep);
            this.Controls.Add(this.groupRep);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Jeu";
            this.Text = "Jeu";
            this.groupRep.ResumeLayout(false);
            this.groupRep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.GroupBox groupRep;
        private System.Windows.Forms.CheckBox checkRep5;
        private System.Windows.Forms.CheckBox checkRep4;
        private System.Windows.Forms.CheckBox checkRep3;
        private System.Windows.Forms.CheckBox checkRep2;
        private System.Windows.Forms.CheckBox checkRep1;
        private System.Windows.Forms.Button btnValiderRep;
        private System.Windows.Forms.TextBox txtTempsTotal;
        private System.Windows.Forms.PictureBox picRep;
        private System.Windows.Forms.Label lblTempsTotal;
        private System.Windows.Forms.TextBox txtDIfficulte;
        private System.Windows.Forms.TextBox txtNomPrenom;
        private System.Windows.Forms.Label lbldifficulte;
        private System.Windows.Forms.Label lblNomPrenom;
        private System.Windows.Forms.ProgressBar pbTemps;
        private System.Windows.Forms.Label lblPbTemps;
    }
}