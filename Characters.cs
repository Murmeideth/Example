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
    public partial class Characters : Form
    {
        public int ID = 0;
        public Characters(int ID_log)
        {
            InitializeComponent();
            get_Info(ID_log);
            ID = ID_log;
            Timer timer = new Timer();
            timer.Interval = (10 * 100);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            get_Info(ID);
        }
        public void get_Info(int ID)
        {
            string query = "SELECT char_list.id_character AS '№ п/п', characters.char_name AS 'Имя персонажа', classes.name AS 'Класс', races.name AS 'Раса', characters.level AS 'Уровень', characters.char_bio AS 'Биография' FROM char_list JOIN characters ON characters.id_character = char_list.id_character JOIN classes ON characters.id_class = classes.id_class JOIN races ON characters.id_race = races.id_race WHERE char_list.id_char_list = (SELECT id_char_list FROM users WHERE id_login =" + ID.ToString() + ");";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                sda.Fill(dt);
                char_list.DataSource = dt;
                char_list.ClearSelection();
                char_list.Columns[0].Visible = false;
                conn.Close();
            }
            catch(Exception ex){
                MessageBox.Show("Произошла непредвиденая ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void char_list_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Char_profile Win = new Char_profile(0, "add", ID);
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }

        private void char_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (char_list.Rows.Count > 0)
            {
                Char_profile Win = new Char_profile(Convert.ToInt32(char_list[0, char_list.CurrentRow.Index].Value.ToString()), "chng", ID);
                Win.Owner = this;
                this.Hide();
                Win.Show();
            }
        }
    }
}
