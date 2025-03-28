using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1;
using TP1.Model;

namespace QuizzAndTest.Model
{
    public class Partie
    {
        public int score;
        public string difficulte;
        public List<Question> questions;
        public int numeroQuestion;
        public int nombreQuestions;
        public int reponseValidQuestion;
        public string nomJoueur;
        public string prenomJoueur;
        public int dureePartie;
        public int dureeTQuestion;
        public Timer timer;
        private SousFormulaire SF;


        public Partie(List<Question> ListeQuestions)
        {
            score = 0;
            difficulte = "";
            numeroQuestion = 0;
            questions = ListeQuestions;
            nombreQuestions = questions.Count;
        }

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
            msg = MessageBox.Show("Votre score est de " + score + ".\r\n vous avez fini la partie en " + dureePartie + " secondes.\r\n Voulez vous rejouer", "Fin de la partie"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if (msg == DialogResult.Yes)
            {
                score = 0;
                numeroQuestion = 0;
                dureePartie = 0;
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

        public void gestionTimer(TextBox txt_timer, ProgressBar pb_dureeRepQuestion, TextBox txt_affichage, CheckBox ckb_reponse1, CheckBox ckb_reponse2, CheckBox ckb_reponse3, CheckBox ckb_reponse4, CheckBox ckb_reponse5, Form formulaire, GroupBox gd_reponse, PictureBox PbImage, ProgressBar pbTemps, Label lblQuestion)
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (sender, e) => Timer_Tick(sender, e, txt_timer, pb_dureeRepQuestion, txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, formulaire, gd_reponse, PbImage, pbTemps, lblQuestion);

            timer.Start();
        }

        public void Timer_Tick(object sender, EventArgs e, TextBox txt_timer, ProgressBar pb_dureeRepQuestion, TextBox txt_affichage, CheckBox ckb_reponse1, CheckBox ckb_reponse2, CheckBox ckb_reponse3, CheckBox ckb_reponse4, CheckBox ckb_reponse5, Form formulaire, GroupBox gd_reponse, PictureBox PbImage, ProgressBar pbTemps, Label numQuestion)
        {
            dureePartie++;
            dureeTQuestion++;
            pb_dureeRepQuestion.Increment(1);
            pb_dureeRepQuestion.Maximum = 15;
            txt_timer.Text = dureePartie.ToString() + " sec";
            if (pb_dureeRepQuestion.Value == 15)
            {
                validerReponse(0, PbImage);
                numeroQuestion++;
                numQuestion.Text = "Question " + (numeroQuestion + 1).ToString();
                changerQuestion(txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, formulaire, gd_reponse, PbImage, pbTemps, numQuestion);
                dureeTQuestion = 0;
            }
        }


    }
}
