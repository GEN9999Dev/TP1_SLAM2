namespace TP1
{
    partial class Form1
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
            this.txt_afficher = new System.Windows.Forms.TextBox();
            this.lbl_rep = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.combo_difficulte = new System.Windows.Forms.ComboBox();
            this.lbl_difficulte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_afficher
            // 
            this.txt_afficher.Location = new System.Drawing.Point(215, 54);
            this.txt_afficher.Name = "txt_afficher";
            this.txt_afficher.Size = new System.Drawing.Size(334, 20);
            this.txt_afficher.TabIndex = 0;
            // 
            // lbl_rep
            // 
            this.lbl_rep.AutoSize = true;
            this.lbl_rep.Location = new System.Drawing.Point(129, 57);
            this.lbl_rep.Name = "lbl_rep";
            this.lbl_rep.Size = new System.Drawing.Size(56, 13);
            this.lbl_rep.TabIndex = 1;
            this.lbl_rep.Text = "Réponse :";
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(322, 258);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 2;
            this.btn_valider.Text = "Push Me";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(150, 108);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(35, 13);
            this.lbl_nom.TabIndex = 4;
            this.lbl_nom.Text = "Nom :";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(291, 105);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(173, 20);
            this.txt_nom.TabIndex = 3;
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.Location = new System.Drawing.Point(150, 155);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(49, 13);
            this.lbl_prenom.TabIndex = 6;
            this.lbl_prenom.Text = "Prénom :";
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(291, 152);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(173, 20);
            this.txt_prenom.TabIndex = 5;
            // 
            // combo_difficulte
            // 
            this.combo_difficulte.Location = new System.Drawing.Point(294, 197);
            this.combo_difficulte.Name = "combo_difficulte";
            this.combo_difficulte.Size = new System.Drawing.Size(121, 21);
            this.combo_difficulte.TabIndex = 8;
            this.combo_difficulte.SelectedIndexChanged += new System.EventHandler(this.combo_difficulte_SelectedIndexChanged);
            // 
            // lbl_difficulte
            // 
            this.lbl_difficulte.AutoSize = true;
            this.lbl_difficulte.Location = new System.Drawing.Point(150, 205);
            this.lbl_difficulte.Name = "lbl_difficulte";
            this.lbl_difficulte.Size = new System.Drawing.Size(54, 13);
            this.lbl_difficulte.TabIndex = 9;
            this.lbl_difficulte.Text = "Difficulté :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_difficulte);
            this.Controls.Add(this.combo_difficulte);
            this.Controls.Add(this.lbl_prenom);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.lbl_rep);
            this.Controls.Add(this.txt_afficher);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_afficher;
        private System.Windows.Forms.Label lbl_rep;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.ComboBox combo_difficulte;
        private System.Windows.Forms.Label lbl_difficulte;
    }
}

