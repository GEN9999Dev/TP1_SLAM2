using QuizzAndTest.Model;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1.Model;

namespace TP1.Controller { 
    public class Partie
    {
        #region Attributs
        public int score;
        public string difficulte;
        public List<Question>questionsBDD, questions;
        public int numeroQuestion;
        public int nombreQuestions;
        public int reponseValidQuestion;
        public string nomJoueur;
        public string prenomJoueur;
        public double dureePartie;
        public int dureeTQuestion;
        public Timer timer;
        private SousFormulaire SF;
        #endregion

        #region Constructeur
        public Partie(List<Question> ListeQuestions)
        {
            score = 0;
            difficulte = "";
            numeroQuestion = 0;
            questionsBDD = ListeQuestions;
            questions = new List<Question>();
            listeAleatoireQuestion();
            nombreQuestions = questions.Count;
        }
        #endregion
        public void validerReponse(int reponse, PictureBox PbImage)
        {
            if (reponse == reponseValidQuestion)
            {
                calculerScore(true);
                changerImg(PbImage, true, false);
            }
            else
            {
                calculerScore(false);
                changerImg(PbImage, false, false);
            }
        }

        private void calculerScore(bool BonneReponse)
        {
            if (BonneReponse)
            {
                score++;
            }
        }

        private void changerImg(PictureBox PbImage, bool BonneReponse, bool raz)
        {
            if (!raz)
            {
                if (BonneReponse)
                {
                    PbImage.Image = TP1.Properties.Resources.vrai;
                }
                else
                {
                    PbImage.Image = TP1.Properties.Resources.faux;
                }
            }
            else
            {
                PbImage.Image = TP1.Properties.Resources.Interrogation;
            }
        }

        public void finDePartie(TextBox txt_affichage, CheckBox ckb_reponse1, CheckBox ckb_reponse2, CheckBox ckb_reponse3, CheckBox ckb_reponse4, CheckBox ckb_reponse5, Form formulaire, GroupBox gd_reponse, PictureBox PbImage, ProgressBar pbTemps, Label lblQuestion)
        {
            DialogResult msg;
            timer.Stop();
            msg = MessageBox.Show("Votre score est de " + score + ".\r\n vous avez fini la partie en " + Convert.ToInt32(dureePartie)+ " secondes.\r\n Voulez vous rejouer", "Fin de la partie"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if (msg == DialogResult.Yes)
            {
                score = 0;
                numeroQuestion = 0;
                dureePartie = 0;
                listeAleatoireQuestion();
                changerQuestion(txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, formulaire, gd_reponse, PbImage, pbTemps, lblQuestion);
                changerImg(PbImage, true, true);
                timer.Start();
            }
            else
            {
                formulaire.Hide();
            }


        }
        
        public void changerQuestion(TextBox txt_affichage, CheckBox ckb_reponse1, CheckBox ckb_reponse2, CheckBox ckb_reponse3, CheckBox ckb_reponse4, CheckBox ckb_reponse5, Form formulaire, GroupBox gd_reponse, PictureBox PbImage, ProgressBar pbTemps, Label lblQuestion)
        {

            if (nombreQuestions > numeroQuestion)
            {
                pbTemps.Value = 0;
                aleatoireReponse(txt_affichage, gd_reponse);
                ckb_reponse1.Checked = false;
                ckb_reponse2.Checked = false;
                ckb_reponse3.Checked = false;
                ckb_reponse4.Checked = false;
                ckb_reponse5.Checked = false;
            }
            else
            {
                finDePartie(txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, formulaire, gd_reponse, PbImage, pbTemps, lblQuestion);
            }
        }

        private void aleatoireReponse(TextBox txt_affichage, GroupBox gd_reponse)
        {
            int bonneReponse = questions[numeroQuestion].reponse;
            txt_affichage.Text = questions[numeroQuestion].enonce;
            List<int> reponseAleatoire = new List<int>() { 1, 2, 3, 4, 5 };
            Random rnd = new Random();

            for (int i = 1; i <= 5; i++)
            {
                int randIndex = rnd.Next(reponseAleatoire.Count);
                int random = reponseAleatoire[randIndex];
                reponseAleatoire.Remove(random);
                string reponse = "";
                switch (random)
                {
                    case 1:
                        reponse = questions[numeroQuestion].proposition1;
                        break;
                    case 2:
                        reponse = questions[numeroQuestion].proposition2;
                        break;
                    case 3:
                        reponse = questions[numeroQuestion].proposition3;
                        break;
                    case 4:
                        reponse = questions[numeroQuestion].proposition4;
                        break;
                    case 5:
                        reponse = questions[numeroQuestion].proposition5;
                        break;
                }
                getTextBox(i, gd_reponse).Text = reponse;
                if (bonneReponse == random)
                {
                    reponseValidQuestion = i;
                }


            }

        }
        private CheckBox getTextBox(int indice, GroupBox gd_reponse)
        {
            foreach (Control c in gd_reponse.Controls)
            {
                if (c.GetType() == typeof(CheckBox))
                {
                    if (c.Name == ("checkRep" + indice.ToString()))
                    {
                        return ((CheckBox)c);
                    }

                }

            }
            return null;

        }
        #region Timer
        public void gestionTimer(TextBox txt_timer, ProgressBar pb_dureeRepQuestion, TextBox txt_affichage, CheckBox ckb_reponse1, CheckBox ckb_reponse2, CheckBox ckb_reponse3, CheckBox ckb_reponse4, CheckBox ckb_reponse5, Form formulaire, GroupBox gd_reponse, PictureBox PbImage, ProgressBar pbTemps, Label lblQuestion)
        {
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += (sender, e) => Timer_Tick(sender, e, txt_timer, pb_dureeRepQuestion, txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, formulaire, gd_reponse, PbImage, pbTemps, lblQuestion);

            timer.Start();
        }

        public void Timer_Tick(object sender, EventArgs e, TextBox txt_timer, ProgressBar pb_dureeRepQuestion, TextBox txt_affichage, CheckBox ckb_reponse1, CheckBox ckb_reponse2, CheckBox ckb_reponse3, CheckBox ckb_reponse4, CheckBox ckb_reponse5, Form formulaire, GroupBox gd_reponse, PictureBox PbImage, ProgressBar pbTemps, Label numQuestion)
        {
            dureePartie+=0.1;
            dureeTQuestion++;
            pb_dureeRepQuestion.Increment(1);
            pb_dureeRepQuestion.Maximum = 150;
            txt_timer.Text = Convert.ToInt32((dureePartie)).ToString() + " sec";
            if (pb_dureeRepQuestion.Value == 150)
            {
                validerReponse(0, PbImage);
                numeroQuestion++;
                numQuestion.Text = "Question " + (numeroQuestion + 1).ToString();
                changerQuestion(txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, formulaire, gd_reponse, PbImage, pbTemps, numQuestion);
                dureeTQuestion = 0;
            }
        }
        #endregion
        private void listeAleatoireQuestion()
        {
            //Purge de la liste des questions
            questions.Clear();
            //Création d’un tableau contenant les valeurs représentant l’ensemble des questionsBDD
            List<int> reponseAleatoire = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                int randIndex = rnd.Next(reponseAleatoire.Count);
                int random = reponseAleatoire[randIndex];
                reponseAleatoire.Remove(random);
                //Ajout des questionsBDD dans la liste aléatoire des questionsBDD
                questions.Add(questionsBDD[random]);
            }
        }

    }
}
