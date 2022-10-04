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
using System.IO;
using System.Drawing.Imaging;


namespace PROJECT_CS
{
    public partial class EditExam : Form
    {
   
        public EditExam()
        {
            InitializeComponent();
            textBoxID.Enabled = false;
        }
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=projactcs; ";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=projactcs;");


        private void Display_Insert_Update_Delete_Search_Image_In_MySQL_Database_Load(object sender, EventArgs e)
        {
            Showdata("");
        }

        public void Showdata(string valueToSearch)
        {

            MySqlCommand command = new MySqlCommand("SELECT * FROM examination1 WHERE CONCAT(id, exam, answer, guideline) LIKE '%" + valueToSearch + "%'", databaseConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.RowTemplate.Height = 60;

            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.DataSource = table;

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dataGridView1.Columns[4];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void BTN_CHOOSE_IMAGE_Click(object sender, EventArgs e)
        {

            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }

        }

       

      
        
        private void dataGridView1_Click(object sender, EventArgs e)
        {

            Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[4].Value;

            MemoryStream ms = new MemoryStream(img);

            pictureBox1.Image = Image.FromStream(ms);

            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxExam.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxAnswer.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxGuideline.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
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
            Showdata("");
        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            MySqlCommand command = new MySqlCommand("UPDATE examination1 SET exam=@ex, answer=@ans, guideline=@gl, exam_image=@img WHERE id = @id", connection);

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBoxID.Text;
            command.Parameters.Add("@ex", MySqlDbType.VarChar).Value = textBoxExam.Text;
            command.Parameters.Add("@ans", MySqlDbType.VarChar).Value = textBoxAnswer.Text;
            command.Parameters.Add("@gl", MySqlDbType.VarChar).Value = textBoxGuideline.Text;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            ExecMyQuery(command, "Data Updated");

        }


        private void BTN_clear_Click(object sender, EventArgs e)
        {
        ClearFields();
        }

        public void ClearFields()
        {
        
        textBoxExam.Text = "";
        textBoxAnswer.Text = "";
        textBoxGuideline.Text = "";
        pictureBox1.Image = null;

        }

        
    }
}
