namespace TP1.Vue
{
    partial class afficherDonnees
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
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.gbRechercheBDD = new System.Windows.Forms.GroupBox();
            this.comboRechercheDiff = new System.Windows.Forms.ComboBox();
            this.txtRecherchemot = new System.Windows.Forms.TextBox();
            this.lblRechercheDiff = new System.Windows.Forms.Label();
            this.lblRechercheMot = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnAjoutQuestion = new System.Windows.Forms.Button();
            this.btnModifQuestion = new System.Windows.Forms.Button();
            this.btnSuppQuestion = new System.Windows.Forms.Button();
            this.pnlModifQuestion = new System.Windows.Forms.Panel();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.comboModifDiff = new System.Windows.Forms.ComboBox();
            this.lblDiff = new System.Windows.Forms.Label();
            this.lblBonneRep = new System.Windows.Forms.Label();
            this.txtRep5 = new System.Windows.Forms.TextBox();
            this.txtRep4 = new System.Windows.Forms.TextBox();
            this.txtRep3 = new System.Windows.Forms.TextBox();
            this.txtRep2 = new System.Windows.Forms.TextBox();
            this.txtRep1 = new System.Windows.Forms.TextBox();
            this.lblAjoutReponses = new System.Windows.Forms.Label();
            this.txtEnonceQuestion = new System.Windows.Forms.TextBox();
            this.lblEnonceQuestion = new System.Windows.Forms.Label();
            this.lblAJoutModif = new System.Windows.Forms.Label();
            this.rBtn1 = new System.Windows.Forms.RadioButton();
            this.rBtn2 = new System.Windows.Forms.RadioButton();
            this.rBtn3 = new System.Windows.Forms.RadioButton();
            this.rBtn4 = new System.Windows.Forms.RadioButton();
            this.rBtn5 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.gbRechercheBDD.SuspendLayout();
            this.pnlModifQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.AllowUserToAddRows = false;
            this.dgvQuestions.AllowUserToDeleteRows = false;
            this.dgvQuestions.AllowUserToOrderColumns = true;
            this.dgvQuestions.AllowUserToResizeColumns = false;
            this.dgvQuestions.AllowUserToResizeRows = false;
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestions.Location = new System.Drawing.Point(50, 203);
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.ReadOnly = true;
            this.dgvQuestions.RowHeadersVisible = false;
            this.dgvQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuestions.Size = new System.Drawing.Size(829, 456);
            this.dgvQuestions.TabIndex = 0;
            // 
            // gbRechercheBDD
            // 
            this.gbRechercheBDD.Controls.Add(this.comboRechercheDiff);
            this.gbRechercheBDD.Controls.Add(this.txtRecherchemot);
            this.gbRechercheBDD.Controls.Add(this.lblRechercheDiff);
            this.gbRechercheBDD.Controls.Add(this.lblRechercheMot);
            this.gbRechercheBDD.Location = new System.Drawing.Point(462, 25);
            this.gbRechercheBDD.Name = "gbRechercheBDD";
            this.gbRechercheBDD.Size = new System.Drawing.Size(417, 129);
            this.gbRechercheBDD.TabIndex = 1;
            this.gbRechercheBDD.TabStop = false;
            // 
            // comboRechercheDiff
            // 
            this.comboRechercheDiff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRechercheDiff.FormattingEnabled = true;
            this.comboRechercheDiff.Location = new System.Drawing.Point(182, 81);
            this.comboRechercheDiff.Name = "comboRechercheDiff";
            this.comboRechercheDiff.Size = new System.Drawing.Size(176, 21);
            this.comboRechercheDiff.TabIndex = 3;
            this.comboRechercheDiff.SelectedIndexChanged += new System.EventHandler(this.comboRechercheDiff_SelectedIndexChanged);
            // 
            // txtRecherchemot
            // 
            this.txtRecherchemot.Location = new System.Drawing.Point(182, 40);
            this.txtRecherchemot.Name = "txtRecherchemot";
            this.txtRecherchemot.Size = new System.Drawing.Size(176, 20);
            this.txtRecherchemot.TabIndex = 2;
            this.txtRecherchemot.TextChanged += new System.EventHandler(this.txtRecherchemot_TextChanged);
            // 
            // lblRechercheDiff
            // 
            this.lblRechercheDiff.AutoSize = true;
            this.lblRechercheDiff.Location = new System.Drawing.Point(117, 81);
            this.lblRechercheDiff.Name = "lblRechercheDiff";
            this.lblRechercheDiff.Size = new System.Drawing.Size(48, 13);
            this.lblRechercheDiff.TabIndex = 1;
            this.lblRechercheDiff.Text = "Difficulté";
            // 
            // lblRechercheMot
            // 
            this.lblRechercheMot.AutoSize = true;
            this.lblRechercheMot.Location = new System.Drawing.Point(65, 40);
            this.lblRechercheMot.Name = "lblRechercheMot";
            this.lblRechercheMot.Size = new System.Drawing.Size(100, 13);
            this.lblRechercheMot.TabIndex = 0;
            this.lblRechercheMot.Text = "Recherche de mots";
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuitter.Location = new System.Drawing.Point(1338, 2);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(29, 23);
            this.btnQuitter.TabIndex = 15;
            this.btnQuitter.Text = "X";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnAjoutQuestion
            // 
            this.btnAjoutQuestion.Location = new System.Drawing.Point(885, 232);
            this.btnAjoutQuestion.Name = "btnAjoutQuestion";
            this.btnAjoutQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutQuestion.TabIndex = 17;
            this.btnAjoutQuestion.Text = "Ajouter";
            this.btnAjoutQuestion.UseVisualStyleBackColor = true;
            this.btnAjoutQuestion.Click += new System.EventHandler(this.btnAjoutQuestion_Click);
            // 
            // btnModifQuestion
            // 
            this.btnModifQuestion.Location = new System.Drawing.Point(885, 261);
            this.btnModifQuestion.Name = "btnModifQuestion";
            this.btnModifQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnModifQuestion.TabIndex = 18;
            this.btnModifQuestion.Text = "Modifier";
            this.btnModifQuestion.UseVisualStyleBackColor = true;
            this.btnModifQuestion.Click += new System.EventHandler(this.btnModifQuestion_Click);
            // 
            // btnSuppQuestion
            // 
            this.btnSuppQuestion.Location = new System.Drawing.Point(885, 290);
            this.btnSuppQuestion.Name = "btnSuppQuestion";
            this.btnSuppQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnSuppQuestion.TabIndex = 19;
            this.btnSuppQuestion.Text = "Supprimer";
            this.btnSuppQuestion.UseVisualStyleBackColor = true;
            // 
            // pnlModifQuestion
            // 
            this.pnlModifQuestion.Controls.Add(this.rBtn5);
            this.pnlModifQuestion.Controls.Add(this.rBtn4);
            this.pnlModifQuestion.Controls.Add(this.rBtn3);
            this.pnlModifQuestion.Controls.Add(this.rBtn2);
            this.pnlModifQuestion.Controls.Add(this.rBtn1);
            this.pnlModifQuestion.Controls.Add(this.btnAnnuler);
            this.pnlModifQuestion.Controls.Add(this.btnValider);
            this.pnlModifQuestion.Controls.Add(this.comboModifDiff);
            this.pnlModifQuestion.Controls.Add(this.lblDiff);
            this.pnlModifQuestion.Controls.Add(this.lblBonneRep);
            this.pnlModifQuestion.Controls.Add(this.txtRep5);
            this.pnlModifQuestion.Controls.Add(this.txtRep4);
            this.pnlModifQuestion.Controls.Add(this.txtRep3);
            this.pnlModifQuestion.Controls.Add(this.txtRep2);
            this.pnlModifQuestion.Controls.Add(this.txtRep1);
            this.pnlModifQuestion.Controls.Add(this.lblAjoutReponses);
            this.pnlModifQuestion.Controls.Add(this.txtEnonceQuestion);
            this.pnlModifQuestion.Controls.Add(this.lblEnonceQuestion);
            this.pnlModifQuestion.Controls.Add(this.lblAJoutModif);
            this.pnlModifQuestion.Location = new System.Drawing.Point(966, 203);
            this.pnlModifQuestion.Name = "pnlModifQuestion";
            this.pnlModifQuestion.Size = new System.Drawing.Size(364, 456);
            this.pnlModifQuestion.TabIndex = 20;
            this.pnlModifQuestion.Visible = false;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(261, 413);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 21;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(15, 413);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 21;
            this.btnValider.Text = "Ajouter";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // comboModifDiff
            // 
            this.comboModifDiff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboModifDiff.FormattingEnabled = true;
            this.comboModifDiff.Location = new System.Drawing.Point(35, 346);
            this.comboModifDiff.Name = "comboModifDiff";
            this.comboModifDiff.Size = new System.Drawing.Size(215, 21);
            this.comboModifDiff.TabIndex = 4;
            // 
            // lblDiff
            // 
            this.lblDiff.AutoSize = true;
            this.lblDiff.Location = new System.Drawing.Point(3, 321);
            this.lblDiff.Name = "lblDiff";
            this.lblDiff.Size = new System.Drawing.Size(54, 13);
            this.lblDiff.TabIndex = 19;
            this.lblDiff.Text = "Difficulté :";
            // 
            // lblBonneRep
            // 
            this.lblBonneRep.AutoSize = true;
            this.lblBonneRep.Location = new System.Drawing.Point(258, 167);
            this.lblBonneRep.Name = "lblBonneRep";
            this.lblBonneRep.Size = new System.Drawing.Size(85, 13);
            this.lblBonneRep.TabIndex = 13;
            this.lblBonneRep.Text = "Bonne réponse :";
            // 
            // txtRep5
            // 
            this.txtRep5.Location = new System.Drawing.Point(35, 287);
            this.txtRep5.Name = "txtRep5";
            this.txtRep5.Size = new System.Drawing.Size(215, 20);
            this.txtRep5.TabIndex = 12;
            // 
            // txtRep4
            // 
            this.txtRep4.Location = new System.Drawing.Point(35, 261);
            this.txtRep4.Name = "txtRep4";
            this.txtRep4.Size = new System.Drawing.Size(215, 20);
            this.txtRep4.TabIndex = 11;
            // 
            // txtRep3
            // 
            this.txtRep3.Location = new System.Drawing.Point(35, 235);
            this.txtRep3.Name = "txtRep3";
            this.txtRep3.Size = new System.Drawing.Size(215, 20);
            this.txtRep3.TabIndex = 10;
            // 
            // txtRep2
            // 
            this.txtRep2.Location = new System.Drawing.Point(35, 209);
            this.txtRep2.Name = "txtRep2";
            this.txtRep2.Size = new System.Drawing.Size(215, 20);
            this.txtRep2.TabIndex = 9;
            // 
            // txtRep1
            // 
            this.txtRep1.Location = new System.Drawing.Point(35, 183);
            this.txtRep1.Name = "txtRep1";
            this.txtRep1.Size = new System.Drawing.Size(215, 20);
            this.txtRep1.TabIndex = 8;
            // 
            // lblAjoutReponses
            // 
            this.lblAjoutReponses.AutoSize = true;
            this.lblAjoutReponses.Location = new System.Drawing.Point(3, 167);
            this.lblAjoutReponses.Name = "lblAjoutReponses";
            this.lblAjoutReponses.Size = new System.Drawing.Size(133, 13);
            this.lblAjoutReponses.TabIndex = 7;
            this.lblAjoutReponses.Text = "Propositions de questions :";
            // 
            // txtEnonceQuestion
            // 
            this.txtEnonceQuestion.Location = new System.Drawing.Point(73, 63);
            this.txtEnonceQuestion.Multiline = true;
            this.txtEnonceQuestion.Name = "txtEnonceQuestion";
            this.txtEnonceQuestion.Size = new System.Drawing.Size(270, 68);
            this.txtEnonceQuestion.TabIndex = 6;
            // 
            // lblEnonceQuestion
            // 
            this.lblEnonceQuestion.AutoSize = true;
            this.lblEnonceQuestion.Location = new System.Drawing.Point(12, 63);
            this.lblEnonceQuestion.Name = "lblEnonceQuestion";
            this.lblEnonceQuestion.Size = new System.Drawing.Size(55, 13);
            this.lblEnonceQuestion.TabIndex = 5;
            this.lblEnonceQuestion.Text = "Question :";
            // 
            // lblAJoutModif
            // 
            this.lblAJoutModif.Location = new System.Drawing.Point(3, 18);
            this.lblAJoutModif.Name = "lblAJoutModif";
            this.lblAJoutModif.Size = new System.Drawing.Size(358, 19);
            this.lblAJoutModif.TabIndex = 4;
            this.lblAJoutModif.Text = "Ajout/Modification";
            this.lblAJoutModif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rBtn1
            // 
            this.rBtn1.AutoSize = true;
            this.rBtn1.Location = new System.Drawing.Point(290, 186);
            this.rBtn1.Name = "rBtn1";
            this.rBtn1.Size = new System.Drawing.Size(14, 13);
            this.rBtn1.TabIndex = 22;
            this.rBtn1.TabStop = true;
            this.rBtn1.UseVisualStyleBackColor = true;
            // 
            // rBtn2
            // 
            this.rBtn2.AutoSize = true;
            this.rBtn2.Location = new System.Drawing.Point(290, 212);
            this.rBtn2.Name = "rBtn2";
            this.rBtn2.Size = new System.Drawing.Size(14, 13);
            this.rBtn2.TabIndex = 23;
            this.rBtn2.TabStop = true;
            this.rBtn2.UseVisualStyleBackColor = true;
            // 
            // rBtn3
            // 
            this.rBtn3.AutoSize = true;
            this.rBtn3.Location = new System.Drawing.Point(290, 238);
            this.rBtn3.Name = "rBtn3";
            this.rBtn3.Size = new System.Drawing.Size(14, 13);
            this.rBtn3.TabIndex = 24;
            this.rBtn3.TabStop = true;
            this.rBtn3.UseVisualStyleBackColor = true;
            // 
            // rBtn4
            // 
            this.rBtn4.AutoSize = true;
            this.rBtn4.Location = new System.Drawing.Point(290, 264);
            this.rBtn4.Name = "rBtn4";
            this.rBtn4.Size = new System.Drawing.Size(14, 13);
            this.rBtn4.TabIndex = 25;
            this.rBtn4.TabStop = true;
            this.rBtn4.UseVisualStyleBackColor = true;
            // 
            // rBtn5
            // 
            this.rBtn5.AutoSize = true;
            this.rBtn5.Location = new System.Drawing.Point(290, 290);
            this.rBtn5.Name = "rBtn5";
            this.rBtn5.Size = new System.Drawing.Size(14, 13);
            this.rBtn5.TabIndex = 26;
            this.rBtn5.TabStop = true;
            this.rBtn5.UseVisualStyleBackColor = true;
            // 
            // afficherDonnees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 692);
            this.Controls.Add(this.pnlModifQuestion);
            this.Controls.Add(this.btnSuppQuestion);
            this.Controls.Add(this.btnModifQuestion);
            this.Controls.Add(this.btnAjoutQuestion);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.gbRechercheBDD);
            this.Controls.Add(this.dgvQuestions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "afficherDonnees";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            this.gbRechercheBDD.ResumeLayout(false);
            this.gbRechercheBDD.PerformLayout();
            this.pnlModifQuestion.ResumeLayout(false);
            this.pnlModifQuestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.GroupBox gbRechercheBDD;
        private System.Windows.Forms.ComboBox comboRechercheDiff;
        private System.Windows.Forms.TextBox txtRecherchemot;
        private System.Windows.Forms.Label lblRechercheDiff;
        private System.Windows.Forms.Label lblRechercheMot;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnAjoutQuestion;
        private System.Windows.Forms.Button btnModifQuestion;
        private System.Windows.Forms.Button btnSuppQuestion;
        private System.Windows.Forms.Panel pnlModifQuestion;
        private System.Windows.Forms.Label lblAJoutModif;
        private System.Windows.Forms.Label lblEnonceQuestion;
        private System.Windows.Forms.TextBox txtRep5;
        private System.Windows.Forms.TextBox txtRep4;
        private System.Windows.Forms.TextBox txtRep3;
        private System.Windows.Forms.TextBox txtRep2;
        private System.Windows.Forms.TextBox txtRep1;
        private System.Windows.Forms.Label lblAjoutReponses;
        private System.Windows.Forms.TextBox txtEnonceQuestion;
        private System.Windows.Forms.Label lblBonneRep;
        private System.Windows.Forms.Label lblDiff;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ComboBox comboModifDiff;
        private System.Windows.Forms.RadioButton rBtn1;
        private System.Windows.Forms.RadioButton rBtn5;
        private System.Windows.Forms.RadioButton rBtn4;
        private System.Windows.Forms.RadioButton rBtn3;
        private System.Windows.Forms.RadioButton rBtn2;
    }
}