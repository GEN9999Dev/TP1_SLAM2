using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TP1.Model;

namespace TP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboDifficulte.Items.Add("Facile");
            comboDifficulte.Items.Add("Moyen");
            comboDifficulte.Items.Add("Difficile");
            comboDifficulte.Items.Add("Enfer");
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            if (txtNom.Text == "")
            {
                MessageBox.Show("Aucun nom n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txtPrenom.Text == "")
            {
                MessageBox.Show("Aucun prénom n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(comboDifficulte.SelectedIndex <= -1)
            {
                MessageBox.Show("Aucune difficulté n'est rentrée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Jeu J = new Jeu(txtNom.Text, txtPrenom.Text, comboDifficulte.SelectedItem.ToString());
                (System.Windows.Forms.Application.OpenForms["menuPrincipal"] as MenuPrincipal).openChildForm(J);
                this.Hide();

            }

        }
        private void combo_difficulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboDifficulte.SelectedItem.ToString() == "Enfer")
            {
                this.BackColor = System.Drawing.ColorTranslator.FromHtml("#ab0800");
                lblDifficulte.Font = new Font(lblDifficulte.Font, FontStyle.Bold);
                lblNom.Font = new Font(lblNom.Font, FontStyle.Bold);
                lblPrenom.Font = new Font(lblPrenom.Font, FontStyle.Bold);
            }
            else
            {
                this.BackColor = Color.FromArgb(153, 180, 209);
                lblDifficulte.Font = new Font(lblDifficulte.Font, FontStyle.Regular);
                lblNom.Font = new Font(lblNom.Font, FontStyle.Regular);
                lblPrenom.Font = new Font(lblPrenom.Font, FontStyle.Regular);
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
