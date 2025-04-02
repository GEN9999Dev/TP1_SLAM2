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

namespace TP1.Vue
{
    public partial class afficherDonnees : Form
    {
        private DataView dv;
        public afficherDonnees()
        {
            InitializeComponent();
            QuestionBDD dtListeQuestions = new QuestionBDD();
            dv = new DataView(dtListeQuestions.GetListeQuestionRecherche(0, ""));
            Difficulte dtListeDiff = new Difficulte();
            dgvQuestions.DataSource = dv;
            //Cacher les colonnes qui ne servent à rien pour l’utilisateur
            dgvQuestions.Columns["IDQUESTION"].Visible = false;
            //Gérer la largeur des colonnes
            dgvQuestions.Columns["Enoncé"].Width = 190;
            dgvQuestions.Columns["Réponse 1"].Width = 190;
            dgvQuestions.Columns["Réponse 2"].Width = 190;
            dgvQuestions.Columns["Réponse 3"].Width = 190;
            dgvQuestions.Columns["Réponse 4"].Width = 190;
            dgvQuestions.Columns["Réponse 5"].Width = 190;
            dgvQuestions.Columns["Difficulté"].Width = 190;
            //Attention il faut mettre le nom des alias à la place du nom des colonnes en cas d’utilisation d’alias dans la requête SQL.
            comboRechercheDiff.DataSource = dtListeDiff.getListeDifficulte();
            comboRechercheDiff.DisplayMember = "LABELDIFFICULTE"; //nom de l’alias SQL ou nom de la colonne
            comboRechercheDiff.ValueMember = "IDDIFFICULTE";  //nom de l’alias SQL ou nom de la colonne

        }
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtRecherchemot_TextChanged(object sender, EventArgs e)
        {
            QuestionBDD dt_listeQuestion = new QuestionBDD();
            DataView dv = new DataView(dt_listeQuestion.GetListeQuestionRecherche(comboRechercheDiff.SelectedIndex, txtRecherchemot.Text));
            dgvQuestions.DataSource = dv;
        }

        private void comboRechercheDiff_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuestionBDD dt_listeQuestion = new QuestionBDD();
            DataView dv = new DataView(dt_listeQuestion.GetListeQuestionRecherche(comboRechercheDiff.SelectedIndex, txtRecherchemot.Text));
            dgvQuestions.DataSource = dv;
        }
    }
}
