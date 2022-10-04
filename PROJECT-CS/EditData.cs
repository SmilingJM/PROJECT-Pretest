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
using System.Data.SqlClient;
namespace PROJECT_CS
{
    public partial class EditData : Form
    {
        public EditData()
        {
            InitializeComponent();
        }
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=projactcs";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;

        }

        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=projactcs");
        private void Display_Insert_Update_Delete_Search_Image_In_MySQL_Database_Load(object sender, EventArgs e)
        {
            dataload("");
        }

        public void dataload(string valueToSearch)
        {
            
            MySqlCommand command = new MySqlCommand("SELECT * FROM personal_information WHERE CONCAT(student_id,name,number,class,phone,name_parent,parent_status,parent_phone,address) LIKE '%" + valueToSearch + "%'", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView1.RowTemplate.Height = 30;

            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.DataSource = table;

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            
           

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void search_data(string valueToSearch)
        {

        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            box_studentcode.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            box_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            box_number.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            box_class.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            box_phone.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            box_parent.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            box_parent_status.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            box_parent_phone.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            box_address.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }
        private void BTN_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        public void ClearFields()
        {
            box_studentcode.Text = "";
            box_name.Text  = "";
            box_number.Text = "";
            box_class.Text = "";
            box_phone.Text = "";
            box_parent.Text = "";
            box_parent_status.Text = "";
            box_parent_phone.Text = "";
            box_address.Text = "";
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

            MySqlCommand command = new MySqlCommand("UPDATE personal_information SET student_id =@id, name=@na, number=@num, class=@cl, phone=@ph, name_parent=@pa, parent_status=@ps, parent_phone=@pp, address=@ad  WHERE student_id = @id", connection);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = box_studentcode.Text;
            command.Parameters.Add("@na", MySqlDbType.VarChar).Value = box_name.Text;
            command.Parameters.Add("@num", MySqlDbType.VarChar).Value = box_number.Text;
            command.Parameters.Add("@cl", MySqlDbType.VarChar).Value = box_class.Text;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = box_phone.Text;
            command.Parameters.Add("@pa", MySqlDbType.VarChar).Value = box_parent.Text;
            command.Parameters.Add("@ps", MySqlDbType.VarChar).Value = box_parent_status.Text;
            command.Parameters.Add("@pp", MySqlDbType.VarChar).Value = box_parent_phone.Text;
            command.Parameters.Add("@ad", MySqlDbType.VarChar).Value = box_address.Text;
            ExecMyQuery(command, "Data Updated");

        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridView1.CurrentCell.RowIndex;
            int deleteId = Convert.ToInt32(dataGridView1.Rows[selectedRow].Cells["student_id"].Value);

            MySqlConnection conn = databaseConnection();

            String sql = "DELETE FROM personal_information WHERE student_id = '" + deleteId + "'";

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
        
        private void txt_SearchName_TextChanged2(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand  ("SELECT * FROM personal_information WHERE student_id like '" + box_search.Text + "%' || name like '" + box_search.Text + "%' || class like '" + box_search.Text + "%'", conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
