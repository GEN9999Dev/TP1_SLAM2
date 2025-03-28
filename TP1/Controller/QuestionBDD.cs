using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1.Model;
using MySqlConnector;

namespace TP1.Controller
{
    internal class QuestionBDD
    {
        public DataTable GetListeQuestion()
        {
            DataTable dt = new DataTable();
            ConnexionBDD conn = new ConnexionBDD();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("//Votre requête SQL ici de préférence jointure + alias ", conn.mySqlCo))
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
            conn.MySqlCo.Close();
            conn.MySqlCo = null;
            return dt;
        }

    }
}
