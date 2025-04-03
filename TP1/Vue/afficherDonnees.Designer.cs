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
            this.gbAjoutQuestion = new System.Windows.Forms.GroupBox();
            this.btnAjoutQuestion = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.gbRechercheBDD.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.AllowUserToAddRows = false;
            this.dgvQuestions.AllowUserToDeleteRows = false;
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestions.Location = new System.Drawing.Point(50, 203);
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.ReadOnly = true;
            this.dgvQuestions.Size = new System.Drawing.Size(829, 394);
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
            // gbAjoutQuestion
            // 
            this.gbAjoutQuestion.Location = new System.Drawing.Point(981, 203);
            this.gbAjoutQuestion.Name = "gbAjoutQuestion";
            this.gbAjoutQuestion.Size = new System.Drawing.Size(377, 394);
            this.gbAjoutQuestion.TabIndex = 16;
            this.gbAjoutQuestion.TabStop = false;
            // 
            // btnAjoutQuestion
            // 
            this.btnAjoutQuestion.Location = new System.Drawing.Point(885, 232);
            this.btnAjoutQuestion.Name = "btnAjoutQuestion";
            this.btnAjoutQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutQuestion.TabIndex = 17;
            this.btnAjoutQuestion.Text = "Ajouter";
            this.btnAjoutQuestion.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(885, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(885, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // afficherDonnees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 692);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAjoutQuestion);
            this.Controls.Add(this.gbAjoutQuestion);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.gbRechercheBDD);
            this.Controls.Add(this.dgvQuestions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "afficherDonnees";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            this.gbRechercheBDD.ResumeLayout(false);
            this.gbRechercheBDD.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbAjoutQuestion;
        private System.Windows.Forms.Button btnAjoutQuestion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}