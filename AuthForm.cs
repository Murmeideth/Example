using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Example
{
    partial class Authtorizathion : Form
    {
        public Authtorizathion()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string query = "SELECT id_login FROM login WHERE login ='" + name_box.Text + "' and login_pass = '" + pass_box.Text + "';";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                int result = 0;
                result = Convert.ToInt32(cmDB.ExecuteScalar());
                if (result > 1)
                {
                    Menu Win = new Menu(result);
                    Win.Owner = this;
                    name_box.Clear();
                    pass_box.Clear();
                    this.Hide();
                    Win.Show();
                    
                }
                else
                    MessageBox.Show("Возникла ошибка авторизации!");
                conn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }
    }
}
