using MySqlConnector;
using System;
using System.Data;
using System.Drawing.Text;
using System.Windows.Forms;
using TP1.Model;



namespace TP1.Controller
{
    internal class Difficulte
    {
        public DataTable getListeDifficulte()
        {
            DataTable dt = new DataTable();
            DataRow workRow;
            ConnexionBDD conn = new ConnexionBDD();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT IDDIFFICULTE, LABELDIFFICULTE FROM DIFFICULTE;", conn.MySqlCo))
                {
                    conn.MySqlCo.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    workRow = dt.NewRow();
                    workRow[0] = -1;
                    workRow[1] = "";
                    dt.Rows.InsertAt(workRow, 0);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            conn.MySqlCo.Close();
            conn.MySqlCo = null;
            return dt;
        }
    }
}
