using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;
using TP1.Model;


namespace TP1.Controller
{
    internal class QuestionBDD
    {
        public DataTable GetListeQuestion()
        {
            DataTable dt = new DataTable();

            try
            {
                ConnexionBDD conn = new ConnexionBDD();
                using (MySqlCommand cmd = new MySqlCommand("SELECT IDQUESTION, ENONCEQUESTION as 'Enoncé', REPONSE1QUESTION as 'Réponse 1', REPONSE2QUESTION as 'Réponse 2', REPONSE3QUESTION as 'Réponse 3', REPONSE4QUESTION as 'Réponse 4',REPONSE5QUESTION as  'Réponse 5', LABELDIFFICULTE as 'Difficulté' FROM QUESTION INNER JOIN DIFFICULTE ON QUESTION.IDDIFFICULTE = DIFFICULTE.IDDIFFICULTE;", conn.mySqlCo))
                {
                    conn.MySqlCo.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return dt;
        }

    }
}
