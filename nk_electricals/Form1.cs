using MySql.Data.MySqlClient;
using nk_electricals.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace nk_electricals
{
    public partial class Form1 : Form
    {
        Login obj = new Login();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            bool response=obj.admin_login(username, password);

            if(username=="" || password=="")
            {
                MessageBox.Show("Fields should not be empty");
            }
            else
            {
                if (response == true)
                {
                    Console.WriteLine("Login success");
                    MessageBox.Show("Login success." + obj.admin_id);
                }
                else
                {
                    Console.WriteLine("Username/password wrong");
                    MessageBox.Show("Invalid username/password."+obj.admin_id);
                }
            }
            

            
        }
    }
}
