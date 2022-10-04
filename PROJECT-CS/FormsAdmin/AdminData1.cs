using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_CS.FormsAdmin
{
    public partial class AdminData1 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public AdminData1()
        {
            InitializeComponent();
            random = new Random();
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[tempIndex];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (currentButton != (Button)btnSender)
            {
                DisableButton();
                Color color = SelectThemeColor();
                currentButton = (Button)btnSender;
                currentButton.BackColor = color;
                currentButton.ForeColor = Color.White;
                currentButton.Font = new System.Drawing.Font("MiPancake", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
                panelMenu.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);

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
                    previousBtn.Font = new System.Drawing.Font("MiPancake", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));

                }
            }
        }
        private void hide_data()
        {
            dataGridView1.Hide();
            dataGridView2.Hide();
            dataGridView3.Hide();
            dataGridView4.Hide();
            dataGridView5.Hide();
            dataGridView6.Hide();
            dataGridView7.Hide();
            dataGridView8.Hide();
            dataGridView9.Hide();
            dataGridView10.Hide();
        }
        private void btnNumber1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            hide_data();
            dataGridView1.Show();
        }

        private void btnNumber2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            hide_data();
            dataGridView2.Show();
        }

        private void btnNumber3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            hide_data();
            dataGridView3.Show();
        }

        private void btnNumber4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            hide_data();
            dataGridView4.Show();
        }

        private void btnNumber5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            hide_data();
            dataGridView5.Show();
        }

        private void btnNumber6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            hide_data();
            dataGridView6.Show();
        }

        private void btnNumber7_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            hide_data();
            dataGridView7.Show();
        }

        private void btnNumber8_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            hide_data();
            dataGridView8.Show();
        }

        private void btnNumber9_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            hide_data();
            dataGridView9.Show();
        }

        private void btnNumber10_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            hide_data();
            dataGridView10.Show();
        }

        
    }
}
