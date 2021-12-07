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
    public partial class Profile : Form
    {
        public int ID = 0;
        public Profile(int ID_log)
        {
            InitializeComponent();
            name_box.Visible = false;
            password_box.Visible = false;
            getInfo(ID_log);
            ID = ID_log;
        }

        public void getInfo(int ID)
        {
            string query = "SELECT users.user_name, login.login, login.login_pass, users.reg_date from users join login on users.id_login = login.id_login where users.id_login =" + ID + ";";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                    while (rd.Read())
                    {
                        greet_label.Text = "Добро пожаловать, " + rd.GetString(0) + ".";
                        login_label.Text = rd.GetString(1);
                        password_label.Text = rd.GetString(2);
                        date_label.Text = rd.GetString(3);
                    }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void chng_btn_Click(object sender, EventArgs e)
        {
            if (chng_btn.Text == "Изменить")
            {
                name_box.Visible = true;
                name_box.Text = login_label.Text;
                login_label.Visible = false;
                password_box.Visible = true;
                password_box.Text = password_label.Text;
                password_label.Visible = false;
                chng_btn.Text = "Сохранить";
            }
            else if(chng_btn.Text == "Сохранить")
            {
                string query = "update login set login ='" + name_box.Text + "', login_pass ='" + password_box.Text + "' where id_login = " + ID.ToString() + ";";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                try
                {
                    conn.Open();
                    cmDB.ExecuteReader();
                    conn.Close();
                    name_box.Visible = false;
                    password_box.Visible = false;
                    login_label.Visible = true;
                    password_label.Visible = true;
                    chng_btn.Text = "Изменить";
                    getInfo(ID);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
                }
            }
        }
    }
}
