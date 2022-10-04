using PROJECT_CS.FormsMain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_CS
{
    
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;



        public Form1()
        {
            InitializeComponent();
            random = new Random();
            btnShowdata.Enabled = false;
            btnUser.Enabled = false;
            btnEditExam.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

        }
        public void enable_menu()
        {
            btnHome.Text = "Logout";
            btnShowdata.Enabled = true;
            btnUser.Enabled = true;
            btnEditExam.Enabled=true;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex == index)
            {
                index= random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[tempIndex];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Kanit", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font= new System.Drawing.Font("Kanit", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));

                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm!=null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;

        }
     
       
        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormLogin(this), sender);
            if (btnHome.Text == "Login")
            {
                
            }
            
            else
            {
                btnHome.Text = "Login";
                btnShowdata.Enabled = false;
                btnUser.Enabled = false;
                btnEditExam.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
            
        }

      

        private void btnUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAdmin(), sender);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTestNew(), sender);
        }

        private void btnEditExam_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EditExam(), sender);
        }

        private void btnShowdata_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EditData(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StudentScore(), sender);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Evaluate(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Evaluate2(), sender);
        }
    }
}
