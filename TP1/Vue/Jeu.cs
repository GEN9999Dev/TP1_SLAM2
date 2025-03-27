using QuizzAndTest.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using TP1.Model;

namespace TP1
{
    public partial class Jeu : Form
    {
        public int reponseQuestion = 0;
        public int timer_partie;
        Partie partie;

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
            // Ajouter le code permettant l’initialisation du jeu
        }
        private void initForm()
        {
            InitializeComponent();
            List<Question> ListeQuestions = new List<Question>();
            ListeQuestions.Add(new Question("Quelle est la capitale de la France ?", 1, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de l'Espagne ?", 4, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de l'Allemagne ?", 3, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de l'Italie ?", 5, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de l'Angleterre ?", 2, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de la Belgique ?", 1, 1, "Bruxelles", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de la Suisse ?", 2, 1, "Bruxelles", "Berne", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale du Luxembourg ?", 3, 1, "Bruxelles", "Berne", "Luxembourg", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale du Portugal ?", 4, 1, "Bruxelles", "Berne", "Luxembourg", "Lisbonne", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de l'Autriche ?", 5, 1, "Bruxelles", "Berne", "Luxembourg", "Lisbonne", "Vienne"));
            partie = new Partie(ListeQuestions);
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

    }
}
