using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            combo_difficulte.Items.Add("Facile");
            combo_difficulte.Items.Add("Moyen");
            combo_difficulte.Items.Add("Difficile");
            combo_difficulte.Items.Add("Enfer");
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            if (txt_nom.Text == "")
            {
                MessageBox.Show("Aucun nom n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_prenom.Text == "")
            {
                MessageBox.Show("Aucun prénom n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txt_afficher.Text = "";
                txt_afficher.Text += "La difficulté séléctionnée est " + combo_difficulte.SelectedItem + ".";
                string result = "Bonjour ";
                result += txt_prenom.Text;
                result += " " + txt_nom.Text;
                txt_afficher.Text += result;
            }

        }
        private void combo_difficulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(combo_difficulte.SelectedItem == "Enfer")
            {
                this.BackColor = System.Drawing.ColorTranslator.FromHtml("#ab0800");
                lbl_difficulte.Font = new Font(lbl_difficulte.Font, FontStyle.Bold);
                lbl_nom.Font = new Font(lbl_nom.Font, FontStyle.Bold);
                lbl_prenom.Font = new Font(lbl_prenom.Font, FontStyle.Bold);
                lbl_rep.Font = new Font(lbl_rep.Font, FontStyle.Bold);
            }
            else
            {
                this.BackColor = Color.FromArgb(153, 180, 209);
                lbl_difficulte.Font = new Font(lbl_difficulte.Font, FontStyle.Regular);
                lbl_nom.Font = new Font(lbl_nom.Font, FontStyle.Regular);
                lbl_prenom.Font = new Font(lbl_prenom.Font, FontStyle.Regular);
                lbl_rep.Font = new Font(lbl_rep.Font, FontStyle.Regular);
            }
        }
    }
}
