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
    public partial class FormAdmin : Form
    {      
        public FormAdmin()
        {
            
            InitializeComponent();
            
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
            
        }

        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=projactcs";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;

        }
        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=projactcs");
        public void dataload(string valueToSearch)
        {

            MySqlCommand command = new MySqlCommand("SELECT usernumber,nameAM,username FROM user_admin WHERE CONCAT(usernumber,nameAM,username) LIKE '%" + valueToSearch + "%'", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            UserData.RowTemplate.Height = 30;
            UserData.AllowUserToAddRows = false;
            UserData.DataSource = table;
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            UserData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BTN_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        public void ClearFields()
        {
            txtname.Text = "";
            txtusername.Text = "";
            txtpass.Text = "";
            txtconfirm.Text = "";
        }
        public void ExecMyQuery(MySqlCommand mcomd, string myMsg)
        {
            connection.Open();
            if (mcomd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show(myMsg);
            }
            else
            {
                MessageBox.Show("Query Not Executed");
            }
            connection.Close();
            dataload("");
        }
        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txtusername.Text != "" && txtpass.Text != "" && txtconfirm.Text != "")
            {
                if (txtpass.Text == txtconfirm.Text)
                {
                    MySqlCommand command = new MySqlCommand("UPDATE user_admin SET nameAM=@name, username=@un, pass=@ps WHERE usernumber = @id", connection);
                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = noID.Text;
                    command.Parameters.Add("@name", MySqlDbType.VarChar).Value = txtname.Text;
                    command.Parameters.Add("@un", MySqlDbType.VarChar).Value = txtusername.Text;
                    command.Parameters.Add("@ps", MySqlDbType.VarChar).Value = txtpass.Text;
                    ExecMyQuery(command, "Data Updated");
                }
            }
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            noID.Text = UserData.CurrentRow.Cells[0].Value.ToString();
            txtname.Text = UserData.CurrentRow.Cells[1].Value.ToString();
            txtusername.Text = UserData.CurrentRow.Cells[2].Value.ToString();
            txtpass.Text = "";
            txtconfirm.Text = "";
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int selectedRow = UserData.CurrentCell.RowIndex;
            int deleteId = Convert.ToInt32(UserData.Rows[selectedRow].Cells["usernumber"].Value);
            MySqlConnection conn = databaseConnection();
            String sql = "DELETE FROM user_admin WHERE usernumber = '" + deleteId + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            if (rows > 0)
            {
                MessageBox.Show("ลบข้อมูลสำเร็จ");
                dataload("");
            }
        }
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            dataload("");
            LoadTheme();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txtusername.Text != "" && txtpass.Text != "" && txtconfirm.Text != "")
            {
                if (txtpass.Text == txtconfirm.Text)
                {
                    MySqlCommand command = new MySqlCommand("INSERT INTO user_admin(nameAM, username, pass) VALUES( '" + txtname.Text + "','" + txtusername.Text + "', '" + txtpass.Text + "')", connection);
                    ExecMyQuery(command, "Add Data");
                }
            }
        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 44 && (int)e.KeyChar <= 122)
                || (int)e.KeyChar == 8 || (int)e.KeyChar == 13 || (int)e.KeyChar == 46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("ไม่สามารถกรอกรหัสผ่านภาษาไทยได้ !!!", "ผลการตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 161 || (int)e.KeyChar == 8 || (int)e.KeyChar == 13 || (int)e.KeyChar == 46 || (int)e.KeyChar == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;  // OS will not handle this event.
                MessageBox.Show("กรุณากรอกข้อมูลภาษาไทยเท่านั้น !!!", "ผลการตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
