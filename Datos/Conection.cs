using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conection
    {
        private string conStr = ConfigurationManager.AppSettings["db"];
        public MySqlConnection GetCon()
        {
            return new MySqlConnection(conStr); 
        }
    } 
}
