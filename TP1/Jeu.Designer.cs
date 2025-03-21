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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_question_1 = new System.Windows.Forms.Label();
            this.txt_question1 = new System.Windows.Forms.TextBox();
            this.groupRep = new System.Windows.Forms.GroupBox();
            this.checkRep5 = new System.Windows.Forms.CheckBox();
            this.checkRep4 = new System.Windows.Forms.CheckBox();
            this.checkRep3 = new System.Windows.Forms.CheckBox();
            this.checkRep2 = new System.Windows.Forms.CheckBox();
            this.checkRep1 = new System.Windows.Forms.CheckBox();
            this.btn_validerRep = new System.Windows.Forms.Button();
            this.txt_Boxtemps = new System.Windows.Forms.TextBox();
            this.lbl_temps = new System.Windows.Forms.Label();
            this.picRep = new System.Windows.Forms.PictureBox();
            this.txt_difficulte = new System.Windows.Forms.TextBox();
            this.txt_nom_prenom = new System.Windows.Forms.TextBox();
            this.lbl_difficulté = new System.Windows.Forms.Label();
            this.lbl_nom_prenom = new System.Windows.Forms.Label();
            this.groupRep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRep)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.lbl_title.Location = new System.Drawing.Point(292, 34);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(188, 30);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Quizz And Test";
            // 
            // lbl_question_1
            // 
            this.lbl_question_1.AutoSize = true;
            this.lbl_question_1.Location = new System.Drawing.Point(146, 80);
            this.lbl_question_1.Name = "lbl_question_1";
            this.lbl_question_1.Size = new System.Drawing.Size(58, 13);
            this.lbl_question_1.TabIndex = 1;
            this.lbl_question_1.Text = "Question 1";
            // 
            // txt_question1
            // 
            this.txt_question1.Enabled = false;
            this.txt_question1.Location = new System.Drawing.Point(131, 96);
            this.txt_question1.Multiline = true;
            this.txt_question1.Name = "txt_question1";
            this.txt_question1.Size = new System.Drawing.Size(554, 59);
            this.txt_question1.TabIndex = 2;
            // 
            // groupRep
            // 
            this.groupRep.Controls.Add(this.checkRep5);
            this.groupRep.Controls.Add(this.checkRep4);
            this.groupRep.Controls.Add(this.checkRep3);
            this.groupRep.Controls.Add(this.checkRep2);
            this.groupRep.Controls.Add(this.checkRep1);
            this.groupRep.Location = new System.Drawing.Point(131, 182);
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
            // btn_validerRep
            // 
            this.btn_validerRep.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_validerRep.Location = new System.Drawing.Point(342, 505);
            this.btn_validerRep.Name = "btn_validerRep";
            this.btn_validerRep.Size = new System.Drawing.Size(75, 23);
            this.btn_validerRep.TabIndex = 4;
            this.btn_validerRep.Text = "Valider";
            this.btn_validerRep.UseVisualStyleBackColor = false;
            this.btn_validerRep.Click += new System.EventHandler(this.btn_validerRep_Click);
            // 
            // txt_Boxtemps
            // 
            this.txt_Boxtemps.Enabled = false;
            this.txt_Boxtemps.Location = new System.Drawing.Point(770, 58);
            this.txt_Boxtemps.Multiline = true;
            this.txt_Boxtemps.Name = "txt_Boxtemps";
            this.txt_Boxtemps.Size = new System.Drawing.Size(249, 25);
            this.txt_Boxtemps.TabIndex = 5;
            // 
            // lbl_temps
            // 
            this.lbl_temps.AutoSize = true;
            this.lbl_temps.Location = new System.Drawing.Point(767, 34);
            this.lbl_temps.Name = "lbl_temps";
            this.lbl_temps.Size = new System.Drawing.Size(62, 13);
            this.lbl_temps.TabIndex = 7;
            this.lbl_temps.Text = "Temps total";
            // 
            // picRep
            // 
            this.picRep.Image = global::TP1.Properties.Resources.Interrogation;
            this.picRep.Location = new System.Drawing.Point(770, 137);
            this.picRep.Name = "picRep";
            this.picRep.Size = new System.Drawing.Size(240, 199);
            this.picRep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRep.TabIndex = 6;
            this.picRep.TabStop = false;
            // 
            // txt_difficulte
            // 
            this.txt_difficulte.Enabled = false;
            this.txt_difficulte.Location = new System.Drawing.Point(770, 503);
            this.txt_difficulte.Multiline = true;
            this.txt_difficulte.Name = "txt_difficulte";
            this.txt_difficulte.Size = new System.Drawing.Size(249, 25);
            this.txt_difficulte.TabIndex = 8;
            this.txt_difficulte.Text = difficulte;
            // 
            // txt_nom_prenom
            // 
            this.txt_nom_prenom.Enabled = false;
            this.txt_nom_prenom.Location = new System.Drawing.Point(770, 472);
            this.txt_nom_prenom.Multiline = true;
            this.txt_nom_prenom.Name = "txt_nom_prenom";
            this.txt_nom_prenom.Size = new System.Drawing.Size(249, 25);
            this.txt_nom_prenom.TabIndex = 9;
            this.txt_nom_prenom.Text = prenomJoueur + " " + nomJoueur;
            // 
            // lbl_difficulté
            // 
            this.lbl_difficulté.AutoSize = true;
            this.lbl_difficulté.Location = new System.Drawing.Point(671, 506);
            this.lbl_difficulté.Name = "lbl_difficulté";
            this.lbl_difficulté.Size = new System.Drawing.Size(54, 13);
            this.lbl_difficulté.TabIndex = 10;
            this.lbl_difficulté.Text = "Difficulté :";
            // 
            // lbl_nom_prenom
            // 
            this.lbl_nom_prenom.AutoSize = true;
            this.lbl_nom_prenom.Location = new System.Drawing.Point(671, 475);
            this.lbl_nom_prenom.Name = "lbl_nom_prenom";
            this.lbl_nom_prenom.Size = new System.Drawing.Size(35, 13);
            this.lbl_nom_prenom.TabIndex = 11;
            this.lbl_nom_prenom.Text = "Nom :";
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1048, 561);
            this.Controls.Add(this.lbl_nom_prenom);
            this.Controls.Add(this.lbl_difficulté);
            this.Controls.Add(this.txt_nom_prenom);
            this.Controls.Add(this.txt_difficulte);
            this.Controls.Add(this.lbl_temps);
            this.Controls.Add(this.picRep);
            this.Controls.Add(this.txt_Boxtemps);
            this.Controls.Add(this.btn_validerRep);
            this.Controls.Add(this.groupRep);
            this.Controls.Add(this.txt_question1);
            this.Controls.Add(this.lbl_question_1);
            this.Controls.Add(this.lbl_title);
            this.Name = "Jeu";
            this.Text = "Jeu";
            this.groupRep.ResumeLayout(false);
            this.groupRep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_question_1;
        private System.Windows.Forms.TextBox txt_question1;
        private System.Windows.Forms.GroupBox groupRep;
        private System.Windows.Forms.CheckBox checkRep5;
        private System.Windows.Forms.CheckBox checkRep4;
        private System.Windows.Forms.CheckBox checkRep3;
        private System.Windows.Forms.CheckBox checkRep2;
        private System.Windows.Forms.CheckBox checkRep1;
        private System.Windows.Forms.Button btn_validerRep;
        private System.Windows.Forms.TextBox txt_Boxtemps;
        private System.Windows.Forms.PictureBox picRep;
        private System.Windows.Forms.Label lbl_temps;
        private System.Windows.Forms.TextBox txt_difficulte;
        private System.Windows.Forms.TextBox txt_nom_prenom;
        private System.Windows.Forms.Label lbl_difficulté;
        private System.Windows.Forms.Label lbl_nom_prenom;
    }
}