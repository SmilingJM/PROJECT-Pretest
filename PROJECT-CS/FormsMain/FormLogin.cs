using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT_CS.Includes;
using MySql.Data.MySqlClient;


namespace PROJECT_CS.Forms
{
    public partial class FormLogin: Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=projactcs; ";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        Form1 frm;
        public FormLogin(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
      
        

        private void btn_login_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            MySqlDataAdapter sql = new MySqlDataAdapter("SELECT COUNT(*) FROM user_admin WHERE username = '" + txt_username.Text + "' AND pass = '" + txt_password.Text + "'", conn);
            DataTable login = new DataTable();
            sql.Fill(login);
            // config.singleResult(sql);
            if (login.Rows[0][0].ToString() == "1")
              {
                    frm.enable_menu();
                    MessageBox.Show("เข้าสู่ระบบสำเร็จ");
                    this.Close();
              }
            else
              {
                  MessageBox.Show("เข้าสู่ระบบไม่สำเร็จ", "login failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              }
        }
        private void FormHome_Load(object sender, EventArgs e)
        {
            LoadTheme();
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
            panel2.BackColor = ThemeColor.SecondaryColor;
            label1.ForeColor = ThemeColor.PrimaryColor;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void txt_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 44 && (int)e.KeyChar <= 122)
                || (int)e.KeyChar == 8 || (int)e.KeyChar == 13 || (int)e.KeyChar == 46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("ไม่สามารถกรอกข้อมูลภาษาไทยได้ !!!", "ผลการตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
