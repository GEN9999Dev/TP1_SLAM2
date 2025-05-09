using QuizzAndTest.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using TP1.Controller;
using TP1.Model;

namespace TP1.Vue
{
    public partial class Jeu : Form
    {
        #region attributs
        public int reponseQuestion = 0;
        public int timer_partie;
        Partie partie;
        #endregion

        public Jeu(string nomJoueur, string prenomJoueur, string difficulte)
        {
            initForm();
            txtDIfficulte.Text = difficulte;
            txtNomPrenom.Text = prenomJoueur + " " + nomJoueur;
            timer_partie = 0;
        }

        private void Init()
        {
            InitializeComponent();
        }
        private void initForm()
        {
            InitializeComponent();
            QuestionBDD ListeQuestions = new QuestionBDD();
            partie = new Partie(ListeQuestions.getListeQuestion());
            txtTempsTotal.Text = "0 sec";
            partie.gestionTimer(txtTempsTotal, pbTemps, txtQuestion, checkRep1, checkRep2, checkRep3, checkRep4, checkRep5, this, groupRep, picRep, pbTemps, lblQuestion);
            partie.changerQuestion(txtQuestion, checkRep1, checkRep2, checkRep3, checkRep4, checkRep5, this, groupRep, picRep, pbTemps, lblQuestion);
        }

        private void btn_validerRep_Click(object sender, System.EventArgs e)
        {
            partie.validerReponse(reponseQuestion, picRep);
            partie.numeroQuestion++;

            partie.changerQuestion(txtQuestion, checkRep1, checkRep2, checkRep3, checkRep4, checkRep5, this, groupRep, picRep, pbTemps, lblQuestion);
            lblQuestion.Text = "Question " + (partie.numeroQuestion+1);
            reponseQuestion = 0;
        }

        private void checkRep1_Click(object sender, System.EventArgs e)
        {
            //Boucle permettant de décocher toutes les cases à cocher du formulaire
            foreach (var box in groupRep.Controls.OfType<CheckBox>())
            {
                box.Checked = false;
            }
            ((CheckBox)sender).Checked = true;
            reponseQuestion = Convert.ToInt32(((CheckBox)sender).Name.Substring(8, 1));
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
