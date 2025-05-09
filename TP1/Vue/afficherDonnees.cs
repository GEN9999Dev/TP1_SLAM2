using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1.Controller;
using TP1.Model;

namespace TP1.Vue
{
    public partial class afficherDonnees : Form
    {
        private DataView dv;
        private bool creerQuestion = false;
        private string idQuestion = "";
        public afficherDonnees()
        {
            InitializeComponent();
            dv = new DataView(QuestionBDD.GetListeQuestionRecherche(0, "", false));
            dgvQuestions.DataSource = dv; 
            //Cacher les colonnes qui ne servent à rien pour l’utilisateur
            dgvQuestions.Columns["IDQUESTION"].Visible = false;
            dgvQuestions.Columns["Bonne réponse"].Visible = false;
            //Gérer la largeur des colonnes
            dgvQuestions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQuestions.Columns["Enoncé"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvQuestions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //Attention il faut mettre le nom des alias à la place du nom des colonnes en cas d’utilisation d’alias dans la requête SQL.
            Difficulte dtListeDiff = new Difficulte();
            comboRechercheDiff.DataSource = dtListeDiff.getListeDifficulte(true);
            comboRechercheDiff.DisplayMember = "LABELDIFFICULTE"; //nom de l’alias SQL ou nom de la colonne
            comboRechercheDiff.ValueMember = "IDDIFFICULTE";  //nom de l’alias SQL ou nom de la colonne
            comboModifDiff.DataSource = dtListeDiff.getListeDifficulte(false);
            comboModifDiff.DisplayMember = "LABELDIFFICULTE"; //nom de l’alias SQL ou nom de la colonne
            comboModifDiff.ValueMember = "IDDIFFICULTE";  //nom de l’alias SQL ou nom de la colonne

        }
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtRecherchemot_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(QuestionBDD.GetListeQuestionRecherche(comboRechercheDiff.SelectedIndex, txtRecherchemot.Text, false));
            dgvQuestions.DataSource = dv;
        }

        private void comboRechercheDiff_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(QuestionBDD.GetListeQuestionRecherche(comboRechercheDiff.SelectedIndex, txtRecherchemot.Text, false));
            dgvQuestions.DataSource = dv;
        }
        private void btnAjoutQuestion_Click(object sender, EventArgs e)
        {
            creerQuestion = true;
            pnlModifQuestion.Visible = true;
            lblAJoutModif.Text = "Ajouter une question :";
            btnValider.Text = "Ajouter";

            foreach (var champ in pnlModifQuestion.Controls)
            {
                if (champ.GetType() == typeof(TextBox))
                {
                    ((TextBox)champ).Text = ""; // Réinitialiser les champs de texte
                }
                else if (champ.GetType() == typeof(RadioButton))
                {
                    ((RadioButton)champ).Checked = false; // Décocher les boutons radio
                }
                else if (champ.GetType() == typeof(ComboBox))
                {
                    ((ComboBox)champ).SelectedIndex = -1; // Réinitialiser la sélection de la ComboBox
                }
            }
        }

        private bool isUpdating = false; // Flag pour bloquer la récursion

        private void ChkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Si déjà en train d'exécuter, ne faites rien
            if (isUpdating) return;

            isUpdating = true; // Activer le flag pour bloquer la récursion

            CheckBox clickedCheckBox = sender as CheckBox;

            if (clickedCheckBox != null && clickedCheckBox.Checked)
            {
                // Décoche les autres cases
                foreach (var box in pnlModifQuestion.Controls.OfType<CheckBox>())
                {
                    if (box != clickedCheckBox)
                    {
                        box.Checked = false;
                    }
                }
            }

            isUpdating = false; // Désactiver le flag après l'exécution
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string nom = "";
            string idSelectionne = null;

            foreach (Control ctrl in pnlModifQuestion.Controls)
            {
                if (ctrl is RadioButton rbtn && rbtn.Checked)
                {
                    // Supposons que le nom est sous la forme "rBtn1", "rBtn2", etc.
                    nom = rbtn.Name; // Ex: "rBtn3"
                    idSelectionne = nom.Substring("rBtn".Length); // Récupère "3"
                    break; // On sort de la boucle, un seul bouton peut être coché
                }
            }
            if(idSelectionne == null)
            {
                MessageBox.Show("Veuillez cocher une bonne réponse.");
                return;
            }
            if(creerQuestion)
                QuestionBDD.creerQuestion(txtEnonceQuestion.Text, txtRep1.Text, txtRep2.Text, txtRep3.Text, txtRep4.Text, txtRep5.Text, idSelectionne, comboModifDiff.SelectedValue.ToString());
            else
                QuestionBDD.modifierQuestion(idQuestion, txtEnonceQuestion.Text, txtRep1.Text, txtRep2.Text, txtRep3.Text, txtRep4.Text, txtRep5.Text, idSelectionne, comboModifDiff.SelectedValue.ToString());

            pnlModifQuestion.Visible = false;
            dgvQuestions.DataSource = QuestionBDD.GetListeQuestionRecherche(0, "", false);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            pnlModifQuestion.Visible = false;
        }

        private void btnModifQuestion_Click(object sender, EventArgs e)
        {
            creerQuestion = false;
            pnlModifQuestion.Visible = true;
            lblAJoutModif.Text = "Modifier la question :";
            btnValider.Text = "Enregistrer";
            idQuestion = dgvQuestions.CurrentRow.Cells["IDQUESTION"].Value.ToString();
            txtEnonceQuestion.Text = dgvQuestions.CurrentRow.Cells["Enoncé"].Value.ToString();
            txtRep1.Text = dgvQuestions.CurrentRow.Cells["Réponse 1"].Value.ToString();
            txtRep2.Text = dgvQuestions.CurrentRow.Cells["Réponse 2"].Value.ToString();
            txtRep3.Text = dgvQuestions.CurrentRow.Cells["Réponse 3"].Value.ToString();
            txtRep4.Text = dgvQuestions.CurrentRow.Cells["Réponse 4"].Value.ToString();
            txtRep5.Text = dgvQuestions.CurrentRow.Cells["Réponse 5"].Value.ToString();
            string bonneRep = dgvQuestions.CurrentRow.Cells["Bonne réponse"].Value.ToString();
            foreach (var rBtn in pnlModifQuestion.Controls.OfType<RadioButton>())
            {
                if (rBtn.Name == "rBtn" + bonneRep)
                {
                    rBtn.Checked = true;
                }
            }
            string diff = dgvQuestions.CurrentRow.Cells["Difficulté"].Value.ToString();
            comboModifDiff.SelectedItem = diff;
        }
    }
}
