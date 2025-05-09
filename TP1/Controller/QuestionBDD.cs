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
        public static DataTable GetListeQuestionRecherche(int rechercheDiff, string rechercheMot, bool bonneRep)
        {
            string rqtSql = "SELECT IDQUESTION, ENONCEQUESTION as 'Enoncé', REPONSE1QUESTION as 'Réponse 1', REPONSE2QUESTION as 'Réponse 2', REPONSE3QUESTION as 'Réponse 3', REPONSE4QUESTION as 'Réponse 4',REPONSE5QUESTION as  'Réponse 5', BONREPQUESTION AS 'Bonne réponse'";
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
            ConnexionBDD conn = new ConnexionBDD();
            #region try
            try
            {
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

        public List<Question> getListeQuestion()
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

        public static void creerQuestion(string enonceQuestion, string rep1, string rep2, string rep3, string rep4, string rep5, string bonneRep, string idDiff)
        {
            string query = @"INSERT INTO QUESTION

                            (ENONCEQUESTION, REPONSE1QUESTION, REPONSE2QUESTION, REPONSE3QUESTION, REPONSE4QUESTION, REPONSE5QUESTION, BONREPQUESTION, IDDIFFICULTE)
                            VALUES (@enonceQuestion, @rep1, @rep2, @rep3, @rep4, @rep5, @bonneRep, @idDiff);";
            ConnexionBDD conn = new ConnexionBDD();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn.MySqlCo))
                {
                    conn.MySqlCo.Open();
                    cmd.Parameters.AddWithValue("@enonceQuestion", enonceQuestion);
                    cmd.Parameters.AddWithValue("@rep1", rep1);
                    cmd.Parameters.AddWithValue("@rep2", rep2);
                    cmd.Parameters.AddWithValue("@rep3", rep3);
                    cmd.Parameters.AddWithValue("@rep4", rep4);
                    cmd.Parameters.AddWithValue("@rep5", rep5);
                    cmd.Parameters.AddWithValue("@bonneRep", bonneRep);
                    cmd.Parameters.AddWithValue("@idDiff", idDiff);
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        public static void modifierQuestion(string idQuestion, string enonceQuestion, string rep1, string rep2, string rep3, string rep4, string rep5, string bonneRep, string idDiff)
        {
            string query = @"UPDATE QUESTION SET (ENONCEQUESTION, REPONSE1QUESTION, REPONSE2QUESTION, REPONSE3QUESTION, REPONSE4QUESTION, REPONSE5QUESTION, BONREPQUESTION, IDDIFFICULTE)
                             = (@enonceQuestion, @rep1, @rep2, @rep3, @rep4, @rep5, @bonneRep, @idDiff)
                            WHERE IDQUESTION = @idQuestion;";
            ConnexionBDD conn = new ConnexionBDD();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn.MySqlCo))
                {
                    conn.MySqlCo.Open();
                    cmd.Parameters.AddWithValue("@enonceQuestion", enonceQuestion);
                    cmd.Parameters.AddWithValue("@rep1", rep1);
                    cmd.Parameters.AddWithValue("@rep2", rep2);
                    cmd.Parameters.AddWithValue("@rep3", rep3);
                    cmd.Parameters.AddWithValue("@rep4", rep4);
                    cmd.Parameters.AddWithValue("@rep5", rep5);
                    cmd.Parameters.AddWithValue("@bonneRep", bonneRep);
                    cmd.Parameters.AddWithValue("@idDiff", idDiff);
                    cmd.Parameters.AddWithValue("@idQuestion", idQuestion);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }
    }
}