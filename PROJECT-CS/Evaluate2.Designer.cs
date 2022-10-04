namespace PROJECT_CS
{
    partial class Evaluate2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupbox = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_All = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_pass_percentage = new System.Windows.Forms.Label();
            this.txt_pass_noguide = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_pass_noguide2 = new System.Windows.Forms.Label();
            this.txt_pass_guide = new System.Windows.Forms.Label();
            this.txt_pass_guide2 = new System.Windows.Forms.Label();
            this.groupbox.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupbox
            // 
            this.groupbox.Controls.Add(this.tabPage1);
            this.groupbox.Controls.Add(this.tabPage2);
            this.groupbox.Controls.Add(this.tabPage4);
            this.groupbox.Controls.Add(this.tabPage3);
            this.groupbox.Location = new System.Drawing.Point(49, 12);
            this.groupbox.Name = "groupbox";
            this.groupbox.SelectedIndex = 0;
            this.groupbox.Size = new System.Drawing.Size(934, 223);
            this.groupbox.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_All);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(926, 197);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "จำนวนนักเรียนที่ทำข้อสอบทั้งหมด";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txt_All
            // 
            this.txt_All.AutoSize = true;
            this.txt_All.Font = new System.Drawing.Font("Kanit", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_All.Location = new System.Drawing.Point(130, 70);
            this.txt_All.Name = "txt_All";
            this.txt_All.Size = new System.Drawing.Size(73, 102);
            this.txt_All.TabIndex = 1;
            this.txt_All.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kanit", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "จำนวนนักเรียนที่ทำข้อสอบทั้งหมด";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_pass_percentage);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txt_pass);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(926, 197);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "จำนวนนักเรียนที่ผ่านการทดสอบ";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Kanit", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(615, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 38);
            this.label7.TabIndex = 3;
            this.label7.Text = "คิดเป็นร้อยละ\r\n";
            // 
            // txt_pass
            // 
            this.txt_pass.AutoSize = true;
            this.txt_pass.Font = new System.Drawing.Font("Kanit", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_pass.Location = new System.Drawing.Point(130, 70);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(73, 102);
            this.txt_pass.TabIndex = 2;
            this.txt_pass.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kanit", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "จำนวนนักเรียนที่ผ่านการทดสอบ";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txt_pass_noguide2);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.txt_pass_noguide);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(926, 197);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "จำนวนนักเรียนที่ผ่านโดยไม่ใช้ไกด์";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kanit", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(6, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "จำนวนนักเรียนที่ผ่านโดยไม่ใช้ไกด์\r\n";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txt_pass_guide2);
            this.tabPage3.Controls.Add(this.txt_pass_guide);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(926, 197);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "จำนวนนักเรียนที่ผ่านโดยใช้ไกด์";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Kanit", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(6, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 38);
            this.label4.TabIndex = 2;
            this.label4.Text = "จำนวนนักเรียนที่ผ่านโดยใช้ไกด์\r\n";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(930, 277);
            this.dataGridView1.TabIndex = 1;
            // 
            // txt_pass_percentage
            // 
            this.txt_pass_percentage.AutoSize = true;
            this.txt_pass_percentage.Font = new System.Drawing.Font("Kanit", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_pass_percentage.Location = new System.Drawing.Point(651, 70);
            this.txt_pass_percentage.Name = "txt_pass_percentage";
            this.txt_pass_percentage.Size = new System.Drawing.Size(73, 102);
            this.txt_pass_percentage.TabIndex = 4;
            this.txt_pass_percentage.Text = "-";
            // 
            // txt_pass_noguide
            // 
            this.txt_pass_noguide.AutoSize = true;
            this.txt_pass_noguide.Font = new System.Drawing.Font("Kanit", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_pass_noguide.Location = new System.Drawing.Point(130, 70);
            this.txt_pass_noguide.Name = "txt_pass_noguide";
            this.txt_pass_noguide.Size = new System.Drawing.Size(73, 102);
            this.txt_pass_noguide.TabIndex = 3;
            this.txt_pass_noguide.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Kanit", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.Location = new System.Drawing.Point(615, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 38);
            this.label10.TabIndex = 4;
            this.label10.Text = "คิดเป็นร้อยละ\r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Kanit", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label11.Location = new System.Drawing.Point(615, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 38);
            this.label11.TabIndex = 5;
            this.label11.Text = "คิดเป็นร้อยละ\r\n";
            // 
            // txt_pass_noguide2
            // 
            this.txt_pass_noguide2.AutoSize = true;
            this.txt_pass_noguide2.Font = new System.Drawing.Font("Kanit", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_pass_noguide2.Location = new System.Drawing.Point(651, 70);
            this.txt_pass_noguide2.Name = "txt_pass_noguide2";
            this.txt_pass_noguide2.Size = new System.Drawing.Size(73, 102);
            this.txt_pass_noguide2.TabIndex = 5;
            this.txt_pass_noguide2.Text = "-";
            // 
            // txt_pass_guide
            // 
            this.txt_pass_guide.AutoSize = true;
            this.txt_pass_guide.Font = new System.Drawing.Font("Kanit", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_pass_guide.Location = new System.Drawing.Point(130, 70);
            this.txt_pass_guide.Name = "txt_pass_guide";
            this.txt_pass_guide.Size = new System.Drawing.Size(73, 102);
            this.txt_pass_guide.TabIndex = 6;
            this.txt_pass_guide.Text = "-";
            // 
            // txt_pass_guide2
            // 
            this.txt_pass_guide2.AutoSize = true;
            this.txt_pass_guide2.Font = new System.Drawing.Font("Kanit", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_pass_guide2.Location = new System.Drawing.Point(651, 70);
            this.txt_pass_guide2.Name = "txt_pass_guide2";
            this.txt_pass_guide2.Size = new System.Drawing.Size(73, 102);
            this.txt_pass_guide2.TabIndex = 7;
            this.txt_pass_guide2.Text = "-";
            // 
            // Evaluate2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 581);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Evaluate2";
            this.Text = "Evaluate2";
            this.Load += new System.EventHandler(this.Evaluate2_Load);
            this.groupbox.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl groupbox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label txt_All;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txt_pass;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt_pass_percentage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txt_pass_noguide;
        private System.Windows.Forms.Label txt_pass_noguide2;
        private System.Windows.Forms.Label txt_pass_guide2;
        private System.Windows.Forms.Label txt_pass_guide;
        private System.Windows.Forms.Label label11;
    }
}