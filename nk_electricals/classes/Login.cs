using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace nk_electricals.classes
{
    
    class Login
    {
        public int admin_id;
        DbConnection con = new DbConnection();
        DataSet ds = new DataSet();
        public bool admin_login(string username,string password)
        {
            con.openConnection();
            
            con.cmd = new MySqlCommand("select * from admin where username='"+username+"' and password='"+password+"' ", con.conn);
            con.da = new MySqlDataAdapter(con.cmd);
            con.da.Fill(ds);
            int result = ds.Tables[0].Rows.Count;
            if(result == 0)
            {

                ds.Tables[0].Rows.Clear();
                con.closeConnection();
                return false;

            }
            else
            {
                admin_id =int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                ds.Tables[0].Rows.Clear();
                con.closeConnection();
                return true;
            }
            //Console.WriteLine(ds.Tables[0].Rows[0]["username"].ToString());
            Console.ReadLine();
            
        }
    }
}
