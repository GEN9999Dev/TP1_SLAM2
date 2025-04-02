using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace TP1.Model
{
    internal class ConnexionBDD
    {
        private string DBServer = "192.168.115.7", DBName = "bdd_QuizzAndTest", DBLogin = "quizzAndTest", DBPassword = "kW8vkqowcHjXNc";
        private MySqlConnection mySqlCo;
        public ConnexionBDD()
        {
            initConnexion();
        }

        public MySqlConnection MySqlCo { get => mySqlCo; set => mySqlCo = value; }


        private void initConnexion()
        {
            MySqlCo = new MySqlConnection("Server=" + DBServer + ";Database=" + DBName + ";User ID=" + DBLogin + ";Password=" + DBPassword);
        }

    }
}
