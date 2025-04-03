using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using TP1.Model;


namespace TP1.Controller
{
    internal class QuestionBDD
    {
        public DataTable GetListeQuestionRecherche(int rechercheDiff, string rechercheMot, bool bonneRep)
        {
            string rqtSql = "SELECT IDQUESTION, ENONCEQUESTION as 'Enoncé', REPONSE1QUESTION as 'Réponse 1', REPONSE2QUESTION as 'Réponse 2', REPONSE3QUESTION as 'Réponse 3', REPONSE4QUESTION as 'Réponse 4',REPONSE5QUESTION as  'Réponse 5'";
            if (bonneRep)
            {
                rqtSql += ", IDDIFFICULTE as 'Difficulté', BONREPQUESTION as 'Bonne réponse' FROM QUESTION";
            }
            else
            {
                rqtSql += ", LABELDIFFICULTE as 'Difficulté' FROM QUESTION INNER JOIN DIFFICULTE ON QUESTION.IDDIFFICULTE = DIFFICULTE.IDDIFFICULTE";
            }
            if (rechercheDiff > 0 || rechercheMot != "")
            {
                rqtSql += " WHERE ";
                if (rechercheMot != "")
                {
                    rqtSql += "QUESTION.ENONCEQUESTION LIKE @rechercheMot";
                }
                if (rechercheDiff > 0)
                {
                    if (rechercheMot != "")
                    {
                        rqtSql += " AND ";
                    }
                    rqtSql += "DIFFICULTE.IDDIFFICULTE = @difficulte";
                }
            }
            rqtSql += ";";
            DataTable dt;
            dt = new DataTable();
            #region try
            try
            {
                ConnexionBDD conn = new ConnexionBDD();
                using (MySqlCommand query = new MySqlCommand(rqtSql, conn.MySqlCo))
                {
                    conn.MySqlCo.Open();
                    query.Parameters.AddWithValue("@rechercheMot", "%" + rechercheMot + "%");
                    query.Parameters.AddWithValue("@difficulte", rechercheDiff);
                    MySqlDataReader reader = query.ExecuteReader();
                    dt.Load(reader);

                }
            }
            #endregion
            #region catch
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            #endregion
            return dt;
        }

        public List<Question> getListeQuestion(ConnexionBDD conn)
        {
            //Déclaration d'une nouvelle liste
            List<Question> ListeQuestions = new List<Question>();
            //Récupération des donneés dans la dataTable
            DataTable dt = GetListeQuestionRecherche(0, "", true);
            //Remplir une liste avec une datatable
            foreach (DataRow row in dt.Rows)
            {
                ListeQuestions.Add(new Question(row["Enoncé"].ToString(), Convert.ToInt32(row["Bonne réponse"]), Convert.ToInt32(row["Difficulté"]), row["Réponse 1"].ToString(), row["Réponse 2"].ToString(), row["Réponse 3"].ToString(), row["Réponse 4"].ToString(), row["Réponse 5"].ToString()));
            }
            return ListeQuestions;

        }

    }
}
