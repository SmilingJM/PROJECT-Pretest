namespace PROJECT_CS
{
    partial class StudentScore
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_name_input = new System.Windows.Forms.Label();
            this.label_number = new System.Windows.Forms.Label();
            this.label_class = new System.Windows.Forms.Label();
            this.label_number_input = new System.Windows.Forms.Label();
            this.label_class_input = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_score_input = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 581);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label_class_input);
            this.panel2.Controls.Add(this.label_number_input);
            this.panel2.Controls.Add(this.label_class);
            this.panel2.Controls.Add(this.label_number);
            this.panel2.Controls.Add(this.label_name_input);
            this.panel2.Controls.Add(this.label_name);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(82, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(868, 468);
            this.panel2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox1.Location = new System.Drawing.Point(100, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kanit", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "ค้นหา";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Kanit", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label_name.Location = new System.Drawing.Point(26, 99);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(59, 51);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "ชื่อ";
            // 
            // label_name_input
            // 
            this.label_name_input.AutoSize = true;
            this.label_name_input.Font = new System.Drawing.Font("Kanit", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label_name_input.Location = new System.Drawing.Point(91, 99);
            this.label_name_input.Name = "label_name_input";
            this.label_name_input.Size = new System.Drawing.Size(362, 51);
            this.label_name_input.TabIndex = 3;
            this.label_name_input.Text = "____________________";
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Font = new System.Drawing.Font("Kanit", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label_number.Location = new System.Drawing.Point(26, 172);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(89, 51);
            this.label_number.TabIndex = 4;
            this.label_number.Text = "เลขที่";
            // 
            // label_class
            // 
            this.label_class.AutoSize = true;
            this.label_class.Font = new System.Drawing.Font("Kanit", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label_class.Location = new System.Drawing.Point(23, 247);
            this.label_class.Name = "label_class";
            this.label_class.Size = new System.Drawing.Size(127, 51);
            this.label_class.TabIndex = 5;
            this.label_class.Text = "ระดับชั้น";
            // 
            // label_number_input
            // 
            this.label_number_input.AutoSize = true;
            this.label_number_input.Font = new System.Drawing.Font("Kanit", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label_number_input.Location = new System.Drawing.Point(125, 172);
            this.label_number_input.Name = "label_number_input";
            this.label_number_input.Size = new System.Drawing.Size(328, 51);
            this.label_number_input.TabIndex = 6;
            this.label_number_input.Text = "__________________";
            // 
            // label_class_input
            // 
            this.label_class_input.AutoSize = true;
            this.label_class_input.Font = new System.Drawing.Font("Kanit", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label_class_input.Location = new System.Drawing.Point(156, 247);
            this.label_class_input.Name = "label_class_input";
            this.label_class_input.Size = new System.Drawing.Size(294, 51);
            this.label_class_input.TabIndex = 7;
            this.label_class_input.Text = "________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kanit", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(629, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 51);
            this.label2.TabIndex = 8;
            this.label2.Text = "คะแนน";
            // 
            // label_score_input
            // 
            this.label_score_input.AutoSize = true;
            this.label_score_input.Font = new System.Drawing.Font("Kanit", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label_score_input.Location = new System.Drawing.Point(28, 0);
            this.label_score_input.Name = "label_score_input";
            this.label_score_input.Size = new System.Drawing.Size(109, 151);
            this.label_score_input.TabIndex = 9;
            this.label_score_input.Text = "-";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(586, 172);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(189, 169);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label_score_input);
            this.panel4.Location = new System.Drawing.Point(13, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(165, 151);
            this.panel4.TabIndex = 11;
            // 
            // StudentScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 581);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentScore";
            this.Text = "StudentScore";
            this.Load += new System.EventHandler(this.StudentScore_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_name_input;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_score_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_class_input;
        private System.Windows.Forms.Label label_number_input;
        private System.Windows.Forms.Label label_class;
        private System.Windows.Forms.Label label_number;
    }
}