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
using System.Drawing.Imaging;
using System.IO;

namespace PROJECT_CS
{
    public partial class FormTestNew : Form
    {
        int Ex1, Ex2, Ex3, Ex4, Ex5, Ex6, Ex7, Ex8, Ex9, Ex10, score = 0;

        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=projactcs; ";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void submit_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM examination1";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);
            var AS = ds.Tables[0].Rows[0].ItemArray.ToList();
            var AS2 = ds.Tables[0].Rows[1].ItemArray.ToList();
            var AS3 = ds.Tables[0].Rows[2].ItemArray.ToList();
            var AS4 = ds.Tables[0].Rows[3].ItemArray.ToList();
            var AS5 = ds.Tables[0].Rows[4].ItemArray.ToList();
            var AS6 = ds.Tables[0].Rows[5].ItemArray.ToList();
            var AS7 = ds.Tables[0].Rows[6].ItemArray.ToList();
            var AS8 = ds.Tables[0].Rows[7].ItemArray.ToList();
            var AS9 = ds.Tables[0].Rows[8].ItemArray.ToList();
            var AS10 = ds.Tables[0].Rows[9].ItemArray.ToList();

            if (Ex1 < 2 && answer1.Text != AS[2].ToString())
            {
                Ex1 = Ex1 + 1;
            }
            else score = score + 1;
            if (Ex2 < 2 && answer2.Text != AS2[2].ToString())
            {
                Ex2 = Ex2 + 1;
            }
            else score = score + 1;
            if (Ex3 < 2 && answer3.Text != AS3[2].ToString())
            {
                Ex3 = Ex3 + 1;
            }
            else score = score + 1;
            if (Ex4 < 2 && answer4.Text != AS4[2].ToString())
            {
                Ex4 = Ex4 + 1;
            }
            else score = score + 1;
            if (Ex5 < 2 && answer5.Text != AS5[2].ToString())
            {
                Ex5 = Ex5 + 1;
            }
            else score = score + 1;
            if (Ex6 < 2 && answer6.Text != AS6[2].ToString())
            {
                Ex6 = Ex6 + 1;
            }
            else score = score + 1;
            if (Ex7 < 2 && answer7.Text != AS7[2].ToString())
            {
                Ex7 = Ex7 + 1;
            }
            else score = score + 1;
            if (Ex8 < 2 && answer8.Text != AS8[2].ToString())
            {
                Ex8 = Ex8 + 1;
            }
            else score = score + 1;
            if (Ex9 < 2 && answer9.Text != AS9[2].ToString())
            {
                Ex9 = Ex9 + 1;
            }
            else score = score + 1;
            if (Ex10 < 2 && answer10.Text != AS10[2].ToString())
            {
                Ex10 = Ex10 + 1;
            }
            else score = score + 1;
            //ตรวจสอบการบันทึกซ้ำ


            if (txt_studentcode.Text != "" || txt_studentcode.Text != " " || txt_name.Text != "" || txt_name.Text != " " || txt_surname.Text != "" || txt_surname.Text != " " || txt_number.Text != "" || txt_number.Text != " " || txt_class.Text != "" || txt_class.Text != " " || txt_phone.Text != "" || txt_phone.Text != "" || txt_parent.Text != "" || txt_parent.Text != " " || txt_parent_status.Text != "" || txt_parent_status.Text != " " || txt_parent_phone.Text != "" || txt_parent_phone.Text != " " || txt_address.Text != "" || txt_address.Text != " ")
            {
                if (txt_studentcode.TextLength == 5 && txt_phone.TextLength == 10 && txt_parent_phone.TextLength == 10)
                {
                    MySqlDataAdapter check = new MySqlDataAdapter("SELECT COUNT(*) FROM scoreboard WHERE student_id = '" + txt_studentcode.Text + "'", conn);
                    DataTable login = new DataTable();
                    check.Fill(login);
                    conn.Close();
                    if (login.Rows[0][0].ToString() == "1")
                    {
                        MessageBox.Show("บันทำไม่สำเร็จ เพราะมีข้อมูลแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        conn.Open();
                        String sql = "INSERT INTO scoreboard (student_id,name,class,Quiz1,Quiz2,Quiz3,Quiz4,Quiz5,Quiz6,Quiz7,Quiz8,Quiz9,Quiz10,score) VALUES ('"+txt_studentcode.Text +"', '"+ txt_name.Text + " " + txt_surname.Text + "', '" + txt_class.Text + "', '" + Ex1 + "', '" + Ex2 + "','" + Ex3 + "','" + Ex4 + "','" + Ex5 + "','" + Ex6 + "','" + Ex7 + "','" + Ex8 + "','" + Ex9 + "','" + Ex10 + "','" + score + "')";
                        String sql2 = "INSERT INTO personal_information (student_id,name,number,class,phone,name_parent,parent_status,parent_phone,address) VALUES ('" + txt_studentcode.Text + "', '" + txt_name.Text + " " + txt_surname.Text + "', '" + txt_number.Text + "', '" + txt_class.Text + "','" + txt_phone.Text + "','" + txt_parent.Text + "','" + txt_parent_status.Text + "','" + txt_parent_phone.Text + "','" + txt_address.Text + "')";
                        MySqlCommand cmd2 = new MySqlCommand(sql, conn);
                        MySqlCommand cmd3 = new MySqlCommand(sql2, conn);
                        MessageBox.Show("บันทึกสำเร็จ", "แจ้งเตือน");
                        int rows = cmd2.ExecuteNonQuery();
                        int rows2 = cmd3.ExecuteNonQuery();

                    }

                }
            }
        }


        private void button10_Click(object sender, EventArgs e)
        {
            Ex10 = Ex10 + 1;
            button10.Hide();
        }

        private void txt_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txt_Thai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar >= 161 || (int)e.KeyChar == 8 || (int)e.KeyChar == 13 || (int)e.KeyChar == 46 || (int)e.KeyChar == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;  // OS will not handle this event.
                MessageBox.Show("กรุณากรอกข้อมูลภาษาไทยเท่านั้น !!!", "ผลการตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }

        private void txt_class_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) )
            {
                e.Handled = true;
            }
        }

        private void answer1_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (e.KeyChar == (char)Keys.Space)
                {
                    e.Handled = true;
                }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Ex1 = Ex1 + 1;
            button1.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Ex9 = Ex9 + 1;
            button9.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Ex8 = Ex8 + 1;
            button8.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Ex7 = Ex7 + 1;
            button7.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ex6 = Ex6 + 1;
            button6.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ex5 = Ex5 + 1;
            button5.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ex4 = Ex4 + 1;
            button4.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ex3 = Ex3 + 1;
            button3.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ex2 = Ex2 + 1;
            button2.Hide();
        }

        public FormTestNew()
        {
            InitializeComponent();
            Qbox1.Enabled = false;
            Qbox2.Enabled = false;
            Qbox3.Enabled = false;
            Qbox4.Enabled = false;
            Qbox5.Enabled = false;
            Qbox6.Enabled = false;
            Qbox7.Enabled = false;
            Qbox8.Enabled = false;
            Qbox9.Enabled = false;
            Qbox10.Enabled = false;
            Gbox1.Enabled = false;
            Gbox2.Enabled = false;
            Gbox3.Enabled = false;
            Gbox4.Enabled = false;
            Gbox5.Enabled = false;
            Gbox6.Enabled = false;
            Gbox7.Enabled = false;
            Gbox8.Enabled = false;
            Gbox9.Enabled = false;
            Gbox10.Enabled = false;
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            DataSet image = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM examination1";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);
            MySqlCommand cmd2;
            cmd2 = conn.CreateCommand();
            cmd2.CommandText = "SELECT exam_image FROM examination1";
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd);
            da2.Fill(image);
            List<PictureBox> box = new List<PictureBox>
            {
                pictureBox1,pictureBox2,pictureBox3,pictureBox4,pictureBox5,pictureBox6,pictureBox7,pictureBox8,pictureBox9,pictureBox10
            };
            int i=0;
            byte[] getimage = new byte[0];
            foreach(DataRow A in image.Tables[0].Rows)
            {
                getimage = (byte[])A["exam_image"];
                MemoryStream B = new MemoryStream(getimage);
                box[i].Image = Image.FromStream(B);
                i = i+ 1;
            }

            var Q1 = ds.Tables[0].Rows[0].ItemArray.ToList();
            Qbox1.Text = Q1[1].ToString();
            Gbox1.Text = Q1[3].ToString();
            var Q2 = ds.Tables[0].Rows[1].ItemArray.ToList();
            Qbox2.Text = Q2[1].ToString();
            Gbox2.Text = Q2[3].ToString();
            var Q3 = ds.Tables[0].Rows[2].ItemArray.ToList();
            Qbox3.Text = Q3[1].ToString();
            Gbox3.Text = Q3[3].ToString();
            var Q4 = ds.Tables[0].Rows[3].ItemArray.ToList();
            Qbox4.Text = Q4[1].ToString();
            Gbox4.Text = Q4[3].ToString();
            var Q5 = ds.Tables[0].Rows[4].ItemArray.ToList();
            Qbox5.Text = Q5[1].ToString();
            Gbox5.Text = Q5[3].ToString();
            var Q6 = ds.Tables[0].Rows[5].ItemArray.ToList();
            Qbox6.Text = Q6[1].ToString();
            Gbox6.Text = Q6[3].ToString();
            var Q7 = ds.Tables[0].Rows[6].ItemArray.ToList();
            Qbox7.Text = Q7[1].ToString();
            Gbox7.Text = Q7[3].ToString();
            var Q8 = ds.Tables[0].Rows[7].ItemArray.ToList();
            Qbox8.Text = Q8[1].ToString();
            Gbox8.Text = Q8[3].ToString();
            var Q9 = ds.Tables[0].Rows[8].ItemArray.ToList();
            Qbox9.Text = Q9[1].ToString();
            Gbox9.Text = Q9[3].ToString();
            var Q10= ds.Tables[0].Rows[9].ItemArray.ToList();
            Qbox10.Text = Q10[1].ToString();
            Gbox10.Text = Q10[3].ToString();
            
        }


    }

    
}
