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

namespace PROJECT_CS
{
    public partial class Evaluate2 : Form
    {
        public Evaluate2()
        {
            InitializeComponent();
        }
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=projactcs";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;

        }
        
        public void dataload_1(string valueToSearch)
        {
            
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand($"SELECT * FROM scoreboard WHERE 1 ", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            string count_Allstudent = "SELECT COUNT(*) FROM scoreboard WHERE 1 ";
            MySqlCommand cmd = new MySqlCommand(count_Allstudent, conn);
            Int32 Allstudent = Convert.ToInt32(cmd.ExecuteScalar());
            dataGridView1.RowTemplate.Height = 25;
            
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = table;
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txt_All.Text = Allstudent.ToString();

        }
        public void dataload_2(string valueToSearch)
        {

            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand($"SELECT * FROM scoreboard WHERE score >= 7 ", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            string count_Allstudent = "SELECT COUNT(*) FROM scoreboard WHERE 1";
            MySqlCommand cmd = new MySqlCommand(count_Allstudent, conn);
            Int32 Allstudent = Convert.ToInt32(cmd.ExecuteScalar());
            string count_studentPass = "SELECT COUNT(*) FROM scoreboard WHERE score >= 7 ";
            MySqlCommand cmd2 = new MySqlCommand(count_studentPass, conn);
            Int32 studentPass = Convert.ToInt32(cmd2.ExecuteScalar());
            
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = table;
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txt_pass.Text = studentPass.ToString();
            txt_pass_percentage.Text = (studentPass * 100) / Allstudent + "."+(studentPass * 100) % Allstudent;

        }

        public void dataload_3(string valueToSearch)
        {

            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand($"SELECT * FROM scoreboard WHERE score >= 7 && Quiz1 != 1 && Quiz2 != 1 && Quiz3 != 1 && Quiz4 != 1 && Quiz5 != 1 && Quiz6 != 1 && Quiz7 != 1 && Quiz8 != 1 && Quiz9 != 1 && Quiz10 != 1", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            string count_Allstudent = "SELECT COUNT(*) FROM scoreboard WHERE 1";
            MySqlCommand cmd = new MySqlCommand(count_Allstudent, conn);
            Int32 Allstudent = Convert.ToInt32(cmd.ExecuteScalar());
            string count_studentPass = $"SELECT COUNT(*) FROM scoreboard WHERE score >= 7 && Quiz1 != 1 && Quiz2 != 1 && Quiz3 != 1 && Quiz4 != 1 && Quiz5 != 1 && Quiz6 != 1 && Quiz7 != 1 && Quiz8 != 1 && Quiz9 != 1 && Quiz10 != 1";
            MySqlCommand cmd3 = new MySqlCommand(count_studentPass, conn);
            Int32 studentPass = Convert.ToInt32(cmd3.ExecuteScalar());
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = table;
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txt_pass_noguide.Text = studentPass.ToString();
            txt_pass_noguide2.Text = (studentPass * 100) / Allstudent + "." + (studentPass * 100) % Allstudent;

        }
        public void dataload_4(string valueToSearch)
        {

            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM scoreboard WHERE score >= 7 && CONCAT (Quiz1,Quiz2,Quiz3,Quiz4,Quiz5,Quiz6,Quiz7,Quiz8,Quiz9,Quiz10) LIKE '%" + "1" + "%'", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            string count_Allstudent = "SELECT COUNT(*) FROM scoreboard WHERE 1";
            MySqlCommand cmd = new MySqlCommand(count_Allstudent, conn);
            Int32 Allstudent = Convert.ToInt32(cmd.ExecuteScalar());
            string count_studentPass = "SELECT COUNT(*) FROM scoreboard WHERE score >= 7 && CONCAT (Quiz1,Quiz2,Quiz3,Quiz4,Quiz5,Quiz6,Quiz7,Quiz8,Quiz9,Quiz10) LIKE '%" + "1" + "%'";
            MySqlCommand cmd4 = new MySqlCommand(count_studentPass, conn);
            Int32 studentPass = Convert.ToInt32(cmd4.ExecuteScalar());
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = table;
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txt_pass_guide.Text = studentPass.ToString();
            txt_pass_guide2.Text = (studentPass * 100) / Allstudent + "." + (studentPass * 100) % Allstudent;

        }
        private void Evaluate2_Load(object sender, EventArgs e)
        {
            dataload_1("");
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            dataload_4("");
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            dataload_3("");
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            dataload_2("");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            dataload_1("");
        }

        
    }
}
