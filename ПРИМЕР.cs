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
using GemBox.Spreadsheet;
using GemBox.Spreadsheet.WinFormsUtilities;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            InitializeComponent();
            try
            {
                MySqlConnection conn = new MySqlConnection("Server=89.108.81.205;Database=test;User=test1;Password=00000000;");
                conn.Open();
                fetchData("select * from t1;", dataGridView1);
                fetchData("select * from t2;", dataGridView2);
                conn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //заполнение dataGridView по запросу с указанием таблицы
        public void fetchData(string query, DataGridView table)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("Server=89.108.81.205;Database=test;User=test1;Password=00000000;");
                MySqlDataAdapter ada = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                conn.Open();
                ada.Fill(dt);
                table.DataSource = dt;
                table.ClearSelection();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }    
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            fetchData("select * from t1 where c1 like '%" + textBox1.Text + "%';", dataGridView1);
        }
        //фильтрация
        public void filter(string query)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 1:
                    query += " where c2 = 'Склад № 1'";
                    break;
                case 2:

                    break;
            }
            fetchData(query, dataGridView1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter("");
        }
        //вывод в excel
        private void button1_Click(object sender, EventArgs e)
        {
            var openSaveDialog = new SaveFileDialog();
            openSaveDialog.Filter = "XLSX (.xlsx)|*.xlsx";
            if(openSaveDialog.ShowDialog() == DialogResult.OK)
            {
                var workbook = new ExcelFile();
                var worksheet = workbook.Worksheets.Add("Лист 1");

                DataGridViewConverter.ImportFromDataGridView(
                    worksheet,
                    this.dataGridView1,
                    new ImportFromDataGridViewOptions()
                    {
                        ColumnHeaders = true
                    });
                workbook.Save(openSaveDialog.FileName);
            }
        }


    }
}
