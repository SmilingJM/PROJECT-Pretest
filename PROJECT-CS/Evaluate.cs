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
    public partial class Evaluate : Form
    {
        public Evaluate()
        {
            InitializeComponent();
        }
        private int numberOfItemsPrintedSoFar = 0;
        private int numberOfItemsPrintedSoFar2 = 0;
        private int numberOfItemsPrintedSoFar3 = 0;
        private int numberOfItemsPerPage = 0;
        

        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=projactcs";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;

        }
       
        public void dataload_1(string valueToSearch, string valueToSearch2)
        {
            MySqlConnection conn = databaseConnection();
            MySqlCommand command = new MySqlCommand($"SELECT student_id,name FROM scoreboard WHERE {valueToSearch} = 0 AND class = {valueToSearch2} ", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = table;
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }
        public void dataload_2(string valueToSearch, string valueToSearch2)
        {
            MySqlCommand command = new MySqlCommand($"SELECT student_id,name FROM scoreboard WHERE {valueToSearch} = 1 AND class = {valueToSearch2} ", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView2.RowTemplate.Height = 30;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.DataSource = table;
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void dataload_3(string valueToSearch, string valueToSearch2)
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand($"SELECT student_id,name FROM scoreboard WHERE {valueToSearch} = 2 AND class = {valueToSearch2} ", connection);
            
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView3.RowTemplate.Height = 30;
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.DataSource = table;
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }

        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=projactcs");
       
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand command1 = new MySqlCommand($"SELECT * FROM scoreboard WHERE {comboBox1.Text} = 0 AND class = {comboBox2.Text} ", conn);
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(command1);
            DataSet ds1 = new DataSet();
            adapter1.Fill(ds1);
            conn.Close();
            conn.Open();
            MySqlCommand command2 = new MySqlCommand($"SELECT * FROM scoreboard WHERE {comboBox1.Text} = 1 AND class = {comboBox2.Text} ", conn);
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(command2);
            DataSet ds2 = new DataSet();
            adapter2.Fill(ds2);
            conn.Close();
            conn.Open();
            MySqlCommand command3 = new MySqlCommand($"SELECT * FROM scoreboard WHERE {comboBox1.Text} = 2 AND class = {comboBox2.Text} ", conn);
            MySqlDataAdapter adapter3 = new MySqlDataAdapter(command3);
            DataSet ds3 = new DataSet();
            adapter3.Fill(ds3);
            string count_info = $"SELECT COUNT(*) FROM scoreboard WHERE {comboBox1.Text} = 0 AND class = {comboBox2.Text} ";
            MySqlCommand cmd = new MySqlCommand(count_info, conn);
            Int32 count1 = Convert.ToInt32(cmd.ExecuteScalar());           
            string count_info2 = $"SELECT COUNT(*) FROM scoreboard WHERE {comboBox1.Text} = 1 AND class = {comboBox2.Text} ";
            MySqlCommand cmd2 = new MySqlCommand(count_info2, conn);
            Int32 count2 = Convert.ToInt32(cmd2.ExecuteScalar());
            string count_info3 = $"SELECT COUNT(*) FROM scoreboard WHERE {comboBox1.Text} = 2 AND class = {comboBox2.Text} ";
            MySqlCommand cmd3 = new MySqlCommand(count_info3, conn);
            Int32 count3 = Convert.ToInt32(cmd3.ExecuteScalar());
            e.Graphics.DrawString("ผลการประเมินศักยภาพของนักเรียนระดับชั้น "+comboBox2.Text, new Font("kanit", 20, FontStyle.Regular), Brushes.Black, new Point(140, 20));
            e.Graphics.DrawString("Date: "+ DateTime.Now, new Font("kanit",12,FontStyle.Regular),Brushes.Blue, new Point(635,1145));
            e.Graphics.DrawString(comboBox1.Text , new Font("kanit", 16, FontStyle.Regular), Brushes.Black, new Point(50, 100));
            e.Graphics.DrawString("--------------------------------------------------------", new Font("kanit", 20, FontStyle.Regular), Brushes.Black, new Point(40, 120));
            e.Graphics.DrawString("นักเรียนที่กลุ่ม1", new Font("kanit", 14, FontStyle.Regular), Brushes.Black, new Point(50, 150));
            e.Graphics.DrawString("นักเรียนที่กลุ่ม2", new Font("kanit", 14, FontStyle.Regular), Brushes.Black, new Point(325, 150));
            e.Graphics.DrawString("นักเรียนที่กลุ่ม3", new Font("kanit", 14, FontStyle.Regular), Brushes.Black, new Point(600, 150));
            e.Graphics.DrawString("--------------------------------------------------------", new Font("kanit", 20, FontStyle.Regular), Brushes.Black, new Point(40, 160));
            
            int yPos1 = 190;
            int yPos2 = 190;
            int yPos3 = 190;

            for (int i = numberOfItemsPrintedSoFar; i < count1; i++)
            {
                if (numberOfItemsPerPage <= 25)
                {
                    numberOfItemsPrintedSoFar++;

                    if (numberOfItemsPrintedSoFar <= count1)
                    {
                        var item1 = ds1.Tables[0].Rows[i].ItemArray.ToList();
                        e.Graphics.DrawString(item1[1].ToString(), new Font("kanit", 14, FontStyle.Regular), Brushes.Black, new Point(50, yPos1));
                        yPos1 += 30;
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }
                }
                
            }
            for (int j = numberOfItemsPrintedSoFar2; j < count2; j++)
            {
                if (numberOfItemsPerPage <= 25)
                {
                    numberOfItemsPrintedSoFar2++;

                    if (numberOfItemsPrintedSoFar2 <= count2)
                    {
                        var item2 = ds2.Tables[0].Rows[j].ItemArray.ToList();
                        e.Graphics.DrawString(item2[1].ToString(), new Font("kanit", 14, FontStyle.Regular), Brushes.Black, new Point(325, yPos2));
                        yPos2 += 30;
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }
                }

            }
            for (int k = numberOfItemsPrintedSoFar3; k < count3; k++)
            {
                if (numberOfItemsPerPage <= 25)
                {
                    numberOfItemsPrintedSoFar3++;

                    if (numberOfItemsPrintedSoFar3 <= count3)
                    {
                        var item3 = ds3.Tables[0].Rows[k].ItemArray.ToList();
                        e.Graphics.DrawString(item3[1].ToString(), new Font("kanit", 14, FontStyle.Regular), Brushes.Black, new Point(600, yPos3));
                        yPos3 += 30;
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }
                }

            }

            if (yPos1 > yPos2 && yPos1 > yPos3)
            {
                e.Graphics.DrawString("--------------------------------------------------------", new Font("kanit", 20, FontStyle.Regular), Brushes.Black, new Point(40, yPos1));
            }
            if (yPos2 > yPos1 && yPos2 > yPos3)
            {
                e.Graphics.DrawString("--------------------------------------------------------", new Font("kanit", 20, FontStyle.Regular), Brushes.Black, new Point(40, yPos2));
            }
            if (yPos3 > yPos2 && yPos3 > yPos1)
            {
                e.Graphics.DrawString("--------------------------------------------------------", new Font("kanit", 20, FontStyle.Regular), Brushes.Black, new Point(40, yPos3));
            }



            // reset the variables
            
            numberOfItemsPrintedSoFar = 0;
            numberOfItemsPrintedSoFar2 = 0;
            numberOfItemsPrintedSoFar3 = 0;

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "")
            {
                dataload_1(comboBox1.Text, comboBox2.Text);
                dataload_2(comboBox1.Text, comboBox2.Text);
                dataload_3(comboBox1.Text, comboBox2.Text);
                tabControl1.TabPages[1].Text = "นักเรียนห้อง " + comboBox2.Text;
                label15.Text = "คะแนนเฉลี่ยของห้อง " + comboBox2.Text;
                evaluate();
            }
        }

        private void evaluate()
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            string count_Allstudent = "SELECT COUNT(*) FROM scoreboard WHERE 1 ";
            MySqlCommand cmd = new MySqlCommand(count_Allstudent, conn);
            Int32 Allstudent = Convert.ToInt32(cmd.ExecuteScalar());
            string count_Allcorrect = $"SELECT COUNT(*) FROM scoreboard WHERE {comboBox1.Text} = 0 ";
            MySqlCommand cmd2 = new MySqlCommand(count_Allcorrect, conn);
            Int32 Allcorrect = Convert.ToInt32(cmd2.ExecuteScalar());
            string count_Allguide = $"SELECT COUNT(*) FROM scoreboard WHERE {comboBox1.Text} = 1 ";
            MySqlCommand cmd3 = new MySqlCommand(count_Allguide, conn);
            Int32 Allguide = Convert.ToInt32(cmd3.ExecuteScalar());
            string count_Allincorrect = $"SELECT COUNT(*) FROM scoreboard WHERE {comboBox1.Text} = 2 ";
            MySqlCommand cmd4 = new MySqlCommand(count_Allincorrect, conn);
            Int32 Allincorrect = Convert.ToInt32(cmd4.ExecuteScalar());
            string count_classstudent = $"SELECT COUNT(*) FROM scoreboard WHERE class = {comboBox2.Text} ";
            MySqlCommand cmd5 = new MySqlCommand(count_classstudent, conn);
            Int32 Allclass = Convert.ToInt32(cmd5.ExecuteScalar());
            string count_info = $"SELECT COUNT(*) FROM scoreboard WHERE {comboBox1.Text} = 0 AND class = {comboBox2.Text} ";
            MySqlCommand cmd6 = new MySqlCommand(count_info, conn);
            Int32 count1 = Convert.ToInt32(cmd6.ExecuteScalar());
            string count_info2 = $"SELECT COUNT(*) FROM scoreboard WHERE {comboBox1.Text} = 1 AND class = {comboBox2.Text} ";
            MySqlCommand cmd7 = new MySqlCommand(count_info2, conn);
            Int32 count2 = Convert.ToInt32(cmd7.ExecuteScalar());
            string count_info3 = $"SELECT COUNT(*) FROM scoreboard WHERE {comboBox1.Text} = 2 AND class = {comboBox2.Text} ";
            MySqlCommand cmd8 = new MySqlCommand(count_info3, conn);
            Int32 count3 = Convert.ToInt32(cmd8.ExecuteScalar());

            lbAllSutudent.Text = Allstudent + " คน    คิดเป็นร้อยละ " + (Allstudent * 100) / Allstudent;
            lbAll_correct.Text = Allcorrect + " คน    คิดเป็นร้อยละ " + (Allcorrect * 100) / Allstudent +"."+ (Allcorrect * 100) % Allstudent;
            lbAll_guide.Text = Allguide + " คน    คิดเป็นร้อยละ " + (Allguide * 100) / Allstudent + "." + (Allguide * 100) % Allstudent;
            lbAll_incorrect.Text = Allincorrect + " คน    คิดเป็นร้อยละ " + (Allincorrect * 100) / Allstudent + "." + (Allincorrect * 100) % Allstudent;
            if (Allclass > 0)
            {
                lb_Allclass.Text = Allclass + " คน    คิดเป็นร้อยละ " + (Allclass * 100) / Allclass;
                lb_classcorrect.Text = count1 + " คน    คิดเป็นร้อยละ " + (count1 * 100) / Allclass + "." + (count1 * 100) % Allclass;
                lb_classguide.Text = count2 + " คน    คิดเป็นร้อยละ " + (count2 * 100) / Allclass + "." + (count2 * 100) % Allclass;
                lb_classincorrect.Text = count3 + " คน    คิดเป็นร้อยละ " + (count3 * 100) / Allclass + "." + (count3 * 100) % Allclass;
            }
            else
            {
                lb_Allclass.Text = "-";
                lb_classcorrect.Text = "-";
                lb_classguide.Text = "-";
                lb_classincorrect.Text = "-";
            }
            //
            //
            //
            
            string sql = "SELECT score FROM scoreboard WHERE 1 ";
            MySqlCommand cmd9 = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd9.ExecuteReader();
            int score1 =0;
            while (reader.Read())
            {
                score1 += reader.GetInt32(0);
            }
            lb_Allscore.Text = "เฉลี่ย " + Convert.ToString(score1 / Allstudent) + "." +(score1 % Allstudent);
            conn.Close();
            conn.Open();
            string sql2 = $"SELECT score FROM scoreboard WHERE class = {comboBox2.Text} ";
            MySqlCommand cmd10 = new MySqlCommand(sql2, conn);
            MySqlDataReader reader2 = cmd10.ExecuteReader();
            int score2 = 0;
            while (reader2.Read())
            {
                score2 += reader2.GetInt32(0);
            }
            lb_classsore.Text = "เฉลี่ย "+Convert.ToString(score2 / Allstudent) + "." + (score2 % Allstudent);

        }

    }
}
