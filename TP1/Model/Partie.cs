using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public class Partie
    {
        public int score;
        public int difficulte;
        public int nombreQuestions;
        public List<Question> listeQuestions;
        public int numeroBonneReponse;
        public int numeroQuestion;
        private List<int> reponseAleatoire;

        public Partie(List<Question> listeQuestions)
        {
            this.score = 0;
            this.difficulte = 0;
            this.nombreQuestions = listeQuestions.Count();
            this.listeQuestions = listeQuestions;
            this.numeroQuestion = 0;
        }
        public void calculerScore(bool bonneRep)
        {
            if (bonneRep)
            {
                score++;
            }
        }
        private void changerImg(PictureBox PbImage, bool BonneReponse, bool raz)
        {
            if (raz == false)
            {
                if (BonneReponse)
                {
                    PbImage.Image = TP1.Properties.Resources.vrai;
                }
                else
                {
                    PbImage.Image =TP1.Properties.Resources.faux;
                }
            }
        }
        public void validerReponse(int reponse, PictureBox PbImage)
        {
            if (reponse == numeroBonneReponse)
            {
                calculerScore(true);
                changerImg(PbImage, true, false);
            }
            else
            {
                changerImg(PbImage, false, false);
                calculerScore(false);
            }
        }
        private void aleatoireReponse(TextBox txt_affichage, GroupBox gd_reponse)
        {
            int bonneReponse = listeQuestions[numeroQuestion].reponse;
            txt_affichage.Text = listeQuestions[numeroQuestion].enonce;
            List<int> reponseAleatoire = new List<int>() { 1, 2, 3, 4, 5 };
            Random rnd = new Random();

            for (int i = 1; i <= 5; i++)
            {
                int randIndex = rnd.Next(reponseAleatoire.Count);
                int random = reponseAleatoire[randIndex];
                reponseAleatoire.Remove(random);
                string reponse = "";

                //Réaliser un switch permettant d’affecter à reponse la proposition sélectionnée de manière aléatoire
                switch (random)
                {
                    case 1:
                        reponse = listeQuestions[numeroQuestion].proposition1;break;
                    case 2:
                        reponse = listeQuestions[numeroQuestion].proposition2; break;
                    case 3:
                        reponse = listeQuestions[numeroQuestion].proposition3; break;
                    case 4:
                        reponse = listeQuestions[numeroQuestion].proposition4; break;
                    case 5:
                        reponse = listeQuestions[numeroQuestion].proposition5; break;

                }
                getCheckBox(i, gd_reponse).Text = reponse;
                if (bonneReponse == random)
                {
                    numeroBonneReponse = i;
                }
            }
        }
        private CheckBox getCheckBox(int indice, GroupBox gd_reponse)
        {
            foreach (Control c in gd_reponse.Controls)
            {
                if (c.GetType() == typeof(CheckBox) && c.Name == "checkRep" + indice.ToString())
                {
                    return ((CheckBox)c);
                }
            }
            return null;
        }


        public void changerQuestion(TextBox txt_affichage, CheckBox ckb_reponse1
            , CheckBox ckb_reponse2, CheckBox ckb_reponse3, CheckBox ckb_reponse4
            , CheckBox ckb_reponse5, Form formulaire, GroupBox gd_reponse, PictureBox PbImage)
        {
            if (listeQuestions.Count() >= numeroQuestion+1)
            {
                aleatoireReponse(txt_affichage, gd_reponse);
                ckb_reponse1.Checked = false;
                ckb_reponse2.Checked = false;
                ckb_reponse3.Checked = false;
                ckb_reponse4.Checked = false;
                ckb_reponse5.Checked = false;
            }
            else
            {
                finDePartie(PbImage, formulaire);
            }
        }
        public void finDePartie(PictureBox PbImage, Form FormActif)
        {
            DialogResult msg = new DialogResult();
            msg = MessageBox.Show("Votre score est de " + score + ".\r\n Voulez vous rejouer", "Fin de la partie"
            , MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if (msg == DialogResult.Yes)
            {
                score = 0;
                numeroQuestion = 0;
                PbImage.Image = TP1.Properties.Resources.Interrogation;
            }
            else
            {
                Form1 Accueil = new Form1();
                Accueil.Show();
                FormActif.Close();
            }
        }

    }
}