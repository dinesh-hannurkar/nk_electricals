using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace nk_electricals
{

    class DbConnection
    {
        string server, db_name, username, password;
        public MySqlConnection conn; //connction obj
        public MySqlCommand cmd;//write qry using this
        public MySqlDataAdapter da; //select query or fetching record
        public DbConnection()
        {
            intialize();
        }
        public void intialize()
        {
            server = "localhost";
            db_name = "nk_electric";
            username = "root";
            password = "";

            string conn_string = "SERVER=" + server + "; DATABASE=" + db_name + "; UID=" + username + "; PASSWORD=" + password + ";";
            conn = new MySqlConnection(conn_string);

        }



        public bool openConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException e)
            {
                switch (e.Number)
                {
                    case 0:
                        Console.WriteLine("Cant connect to db");
                        break;
                    case 1045:
                        Console.WriteLine("invalid username/password for database");
                        break;

                }
                return false;
            }
        }



        public bool closeConnection()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);

                return false;
            }
        }


    }
}
