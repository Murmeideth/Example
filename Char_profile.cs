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
    public partial class Char_profile : Form
    {
        public int ID_char = 0;
        public int ID_user = 0;
        public int inventory = 0;
        bool openInventory = false;
        public int level;
        public Char_profile(int ID_ch, string mode, int ID)
        {
            InitializeComponent();
            if (mode == "chng")
            {
                name_box.Visible = false;
                class_box.Visible = false;
                race_box.Visible = false;
                bio_box.ReadOnly = true;
            }
            else if(mode == "add")
            {
                name_label.Visible = false;
                class_label.Visible = false;
                race_label.Visible = false;
                inventory_btn.Visible = false;
                del_btn.Visible = false;
                bio_box.ReadOnly = false;
                chng_btn.Text = "Добавить";
            }
            getBoxes("select name from classes;", class_box);
            getBoxes("select name from races;", race_box);
            getInventory(ID_ch);
            get_Info(ID_ch);
            ID_char = ID_ch;
            ID_user = ID;
        }
        
        public void getBoxes(string query, ComboBox box)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        box.Items.Add(rd.GetString(0));
                    }
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Произошла непредвиденная ошибка загрузки классов или рас!" + Environment.NewLine + ex.Message);
            }
        }
        public void get_Info(int ID)
        {
            string query = "SELECT characters.char_name, classes.name, races.name, characters.level, characters.char_bio, characters.id_inventory FROM characters JOIN classes ON characters.id_class = classes.id_class JOIN races ON characters.id_race = races.id_race WHERE characters.id_character =" + ID.ToString() + ";";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    name_label.Text = rd.GetString(0);
                    class_label.Text = rd.GetString(1);
                    race_label.Text = rd.GetString(2);
                    level = Convert.ToInt32(rd.GetString(3));
                    bio_box.Text = rd.GetString(4);
                    inventory = Convert.ToInt32(rd.GetString(5));
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Произошла непредвиденная ошибка загрузки информации!" + Environment.NewLine + ex.Message);
            }
        }

        private void chng_btn_Click(object sender, EventArgs e)
        {
            switch (chng_btn.Text)
            {
                case "Добавить":
                    
                    doAction("insert into characters(char_name, id_class, id_race, level, char_bio, id_inventory) values('" + name_box.Text + "', " + (class_box.SelectedIndex + 1).ToString() + ", " + (race_box.SelectedIndex + 1).ToString() + ", 1, '" + bio_box.Text + "', (select max(id_inventory)+1 from inventory));");
                    doAction("insert into char_list values((select id_char_list from users where id_login = " + ID_user.ToString() + "), (select max(id_character) from characters));");
                    doAction("insert into inventory values((select max(id_inventory) from characters), 10);");
                    name_label.Visible = true;
                    class_label.Visible = true;
                    race_label.Visible = true;
                    bio_box.ReadOnly = true;
                    name_box.Visible = false;
                    class_box.Visible = false;
                    race_box.Visible = false;
                    del_btn.Visible = true;
                    chng_btn.Text = "Изменить";
                    inventory_btn.Visible = true;
                    string query = "select max(id_character) from characters;";
                    MySqlConnection conn = DBUtils.GetDBConnection();
                    MySqlCommand cmDB = new MySqlCommand(query, conn);
                    try
                    {
                        conn.Open();
                        ID_char = Convert.ToInt32(cmDB.ExecuteScalar());
                        conn.Close();
                    }
                    catch(Exception ex){
                        MessageBox.Show("Произошла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
                    }
                    get_Info(ID_char);
                    break;
                case "Изменить":
                    chng_btn.Text = "Сохранить";
                    name_label.Visible = false;
                    class_label.Visible = false;
                    race_label.Visible = false;
                    bio_box.ReadOnly = false;
                    name_box.Visible = true;
                    class_box.Visible = true;
                    race_box.Visible = true;
                    del_btn.Visible = false;
                    name_box.Text = name_label.Text;
                    class_box.Text = class_label.Text;
                    race_box.Text = race_label.Text;
                    break;
                case "Сохранить":
                    doAction("update characters set char_name = '" + name_box.Text + "', id_class = " + (class_box.SelectedIndex + 1).ToString() + ", id_race = " + (race_box.SelectedIndex + 1).ToString() + ", char_bio ='" + bio_box.Text + "' where id_character = " + ID_char.ToString() + ";");
                    name_label.Visible = true;
                    class_label.Visible = true;
                    race_label.Visible = true;
                    bio_box.ReadOnly = true;
                    name_box.Visible = false;
                    class_box.Visible = false;
                    race_box.Visible = false;
                    del_btn.Visible = true;
                    chng_btn.Text = "Изменить";
                    get_Info(ID_char);
                    break;
            }
        }

        private void inventory_btn_Click(object sender, EventArgs e)
        {
            switch (openInventory)
            {
                case false:
                    this.Size = new Size(855, 455);
                    openInventory = true;
                    break;
                case true:
                    this.Size = new Size(590, 455);
                    openInventory = false;
                    break;
            }
        }

        public void doAction(string query)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                cmDB.ExecuteReader();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Произошла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }
        public void getInventory(int ID)
        {            
            string query = "select inventory.id_item, items.name as 'Предмет' from inventory join items on inventory.id_item = items.id_item where id_inventory = (select id_inventory from characters where id_character = " + ID.ToString() + ");";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                sda.Fill(dt);
                inventory_box.DataSource = dt;
                inventory_box.ClearSelection();
                inventory_box.Columns[0].Visible = false;
                inventory_box.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                conn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Произошла непредвиденная ошибка загрузки инвентаря!" + Environment.NewLine + ex.Message);
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Уверены, что хотите удалить персонажа?", "Вы уверены?", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                doAction("delete from inventory where id_inventory =(select id_inventory from characters where id_character = " + ID_char + ");");
                doAction("delete from char_list where id_character =" + ID_char + ";");
                doAction("delete from characters where id_character =" + ID_char + ";");
                Owner.Show();
                this.Close();
            }
        }
    }
}
