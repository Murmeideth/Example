using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class Menu : Form
    {
        public int ID = 0;
        public Menu(int ID_log)
        {
            InitializeComponent();
            ID = ID_log;
        }        

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void relog_btn_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void char_btn_Click(object sender, EventArgs e)
        {
            Characters Win = new Characters(ID);
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            Profile Win = new Profile(ID);
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }
    }
}
