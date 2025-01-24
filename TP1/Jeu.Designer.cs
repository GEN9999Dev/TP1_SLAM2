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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.lbl_title.Location = new System.Drawing.Point(301, 24);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(188, 30);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Quizz And Test";
            // 
            // lbl_question_1
            // 
            this.lbl_question_1.AutoSize = true;
            this.lbl_question_1.Location = new System.Drawing.Point(155, 70);
            this.lbl_question_1.Name = "lbl_question_1";
            this.lbl_question_1.Size = new System.Drawing.Size(69, 13);
            this.lbl_question_1.TabIndex = 1;
            this.lbl_question_1.Text = "Questions   1";
            // 
            // txt_question1
            // 
            this.txt_question1.Location = new System.Drawing.Point(140, 86);
            this.txt_question1.Multiline = true;
            this.txt_question1.Name = "txt_question1";
            this.txt_question1.Size = new System.Drawing.Size(426, 59);
            this.txt_question1.TabIndex = 2;
            this.txt_question1.TextChanged += new System.EventHandler(this.txt_question1_TextChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(140, 160);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(426, 229);
            this.checkedListBox1.TabIndex = 3;
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.txt_question1);
            this.Controls.Add(this.lbl_question_1);
            this.Controls.Add(this.lbl_title);
            this.Name = "Jeu";
            this.Text = "Jeu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_question_1;
        private System.Windows.Forms.TextBox txt_question1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}