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
    public partial class StudentScore : Form
    {
        public StudentScore()
        {
            InitializeComponent();
        }
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=projactcs";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand commandinfo = new MySqlCommand("SELECT * FROM personal_information WHERE student_id like '" + textBox1.Text + "%' ", conn);
            string count_info = "SELECT COUNT(*) FROM personal_information WHERE student_id like '" + textBox1.Text + "%' ";
            MySqlCommand cmd = new MySqlCommand(count_info, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(commandinfo);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            
            
            if (count > 0)
            {
                var INFO = ds.Tables[0].Rows[0].ItemArray.ToList();
                label_name_input.Text = INFO[1].ToString();
                label_number_input.Text = INFO[2].ToString();
                label_class_input.Text = INFO[3].ToString();
                
            }
            else
            {
                label_name_input.Text = "ไม่พบข้อมูล";
                label_number_input.Text = "ไม่พบข้อมูล";
                label_class_input.Text = "ไม่พบข้อมูล";
            }
            conn.Close();
            conn.Open();
            MySqlCommand command2 = new MySqlCommand("SELECT * FROM scoreboard WHERE student_id like '" + textBox1.Text + "%' ", conn);
            string count_info2 = "SELECT COUNT(*) FROM personal_information WHERE student_id like '" + textBox1.Text + "%' ";
            MySqlCommand cmd2 = new MySqlCommand(count_info2, conn);
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(command2);
            DataSet ds2 = new DataSet();
            adapter1.Fill(ds2);
            
            Int32 count2 = Convert.ToInt32(cmd2.ExecuteScalar());
            
            if (count2 > 0)
            {
                var Score = ds2.Tables[0].Rows[0].ItemArray.ToList();
                label_score_input.Text = Score[12].ToString();
            }
            else
            {
                label_score_input.Text = "";
            }

        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

                }
            }
            panel1.BackColor = ThemeColor.SecondaryColor;
            panel3.BackColor = ThemeColor.PrimaryColor;
            
        }

        private void StudentScore_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
