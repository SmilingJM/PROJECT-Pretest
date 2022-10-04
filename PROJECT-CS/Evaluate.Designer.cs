namespace PROJECT_CS
{
    partial class Evaluate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Evaluate));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.All_student = new System.Windows.Forms.TabPage();
            this.lbAll_incorrect = new System.Windows.Forms.Label();
            this.lbAll_guide = new System.Windows.Forms.Label();
            this.lbAll_correct = new System.Windows.Forms.Label();
            this.lbAllSutudent = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.this_Class = new System.Windows.Forms.TabPage();
            this.lb_classincorrect = new System.Windows.Forms.Label();
            this.lb_classguide = new System.Windows.Forms.Label();
            this.lb_classcorrect = new System.Windows.Forms.Label();
            this.lb_Allclass = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lb_Allscore = new System.Windows.Forms.Label();
            this.lb_classsore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.All_student.SuspendLayout();
            this.this_Class.SuspendLayout();
            this.Score.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(51, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(217, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Enabled = false;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(274, 251);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(217, 318);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Enabled = false;
            this.dataGridView3.EnableHeadersVisualStyles = false;
            this.dataGridView3.Location = new System.Drawing.Point(497, 252);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(217, 318);
            this.dataGridView3.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Kanit", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Quiz1",
            "Quiz2",
            "Quiz3",
            "Quiz4",
            "Quiz5",
            "Quiz6",
            "Quiz7",
            "Quiz8",
            "Quiz9",
            "Quiz10"});
            this.comboBox1.Location = new System.Drawing.Point(204, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(381, 51);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Quiz1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(51, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 150);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kanit", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(48, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 43);
            this.label2.TabIndex = 6;
            this.label2.Text = "ข้อสอบ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kanit", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(48, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "ระดับชั้น";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Kanit", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "601",
            "602",
            "603",
            "604",
            "605",
            "606",
            "607",
            "608",
            "609",
            "610"});
            this.comboBox2.Location = new System.Drawing.Point(204, 22);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(381, 51);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.Text = "601";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Kanit", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(99, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "สามารถทำได้";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Kanit", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(268, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "สามารถทำได้โดยใช้ไกด์";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Kanit", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(535, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 33);
            this.label5.TabIndex = 9;
            this.label5.Text = "ไม่สามารถทำได้";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Kanit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(754, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "Print Preview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Kanit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.Location = new System.Drawing.Point(754, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 51);
            this.button2.TabIndex = 11;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.All_student);
            this.tabControl1.Controls.Add(this.this_Class);
            this.tabControl1.Controls.Add(this.Score);
            this.tabControl1.Location = new System.Drawing.Point(754, 230);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(278, 339);
            this.tabControl1.TabIndex = 12;
            // 
            // All_student
            // 
            this.All_student.Controls.Add(this.lbAll_incorrect);
            this.All_student.Controls.Add(this.lbAll_guide);
            this.All_student.Controls.Add(this.lbAll_correct);
            this.All_student.Controls.Add(this.lbAllSutudent);
            this.All_student.Controls.Add(this.label10);
            this.All_student.Controls.Add(this.label11);
            this.All_student.Controls.Add(this.label12);
            this.All_student.Controls.Add(this.label13);
            this.All_student.Location = new System.Drawing.Point(4, 22);
            this.All_student.Name = "All_student";
            this.All_student.Padding = new System.Windows.Forms.Padding(3);
            this.All_student.Size = new System.Drawing.Size(270, 313);
            this.All_student.TabIndex = 0;
            this.All_student.Text = "นักเรียนทั้งหมด";
            this.All_student.UseVisualStyleBackColor = true;
            // 
            // lbAll_incorrect
            // 
            this.lbAll_incorrect.AutoSize = true;
            this.lbAll_incorrect.Font = new System.Drawing.Font("Kanit", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbAll_incorrect.Location = new System.Drawing.Point(16, 236);
            this.lbAll_incorrect.Name = "lbAll_incorrect";
            this.lbAll_incorrect.Size = new System.Drawing.Size(17, 24);
            this.lbAll_incorrect.TabIndex = 18;
            this.lbAll_incorrect.Text = "-";
            // 
            // lbAll_guide
            // 
            this.lbAll_guide.AutoSize = true;
            this.lbAll_guide.Font = new System.Drawing.Font("Kanit", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbAll_guide.Location = new System.Drawing.Point(16, 164);
            this.lbAll_guide.Name = "lbAll_guide";
            this.lbAll_guide.Size = new System.Drawing.Size(17, 24);
            this.lbAll_guide.TabIndex = 17;
            this.lbAll_guide.Text = "-";
            // 
            // lbAll_correct
            // 
            this.lbAll_correct.AutoSize = true;
            this.lbAll_correct.Font = new System.Drawing.Font("Kanit", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbAll_correct.Location = new System.Drawing.Point(16, 92);
            this.lbAll_correct.Name = "lbAll_correct";
            this.lbAll_correct.Size = new System.Drawing.Size(17, 24);
            this.lbAll_correct.TabIndex = 16;
            this.lbAll_correct.Text = "-";
            // 
            // lbAllSutudent
            // 
            this.lbAllSutudent.AutoSize = true;
            this.lbAllSutudent.Font = new System.Drawing.Font("Kanit", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbAllSutudent.Location = new System.Drawing.Point(16, 27);
            this.lbAllSutudent.Name = "lbAllSutudent";
            this.lbAllSutudent.Size = new System.Drawing.Size(17, 24);
            this.lbAllSutudent.TabIndex = 15;
            this.lbAllSutudent.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Kanit", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.Location = new System.Drawing.Point(3, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 24);
            this.label10.TabIndex = 14;
            this.label10.Text = "จำนวนนักเรียนที่ทำไม่ได้";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Kanit", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label11.Location = new System.Drawing.Point(3, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 24);
            this.label11.TabIndex = 13;
            this.label11.Text = "จำนวนนักเรียนที่ทำได้โดยไกด์";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Kanit", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label12.Location = new System.Drawing.Point(3, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 24);
            this.label12.TabIndex = 12;
            this.label12.Text = "จำนวนนักเรียนที่ทำได้";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Kanit", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label13.Location = new System.Drawing.Point(3, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 24);
            this.label13.TabIndex = 11;
            this.label13.Text = "จำนวนนักเรียนทั้งหมด";
            // 
            // this_Class
            // 
            this.this_Class.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.this_Class.Controls.Add(this.lb_classincorrect);
            this.this_Class.Controls.Add(this.lb_classguide);
            this.this_Class.Controls.Add(this.lb_classcorrect);
            this.this_Class.Controls.Add(this.lb_Allclass);
            this.this_Class.Controls.Add(this.label9);
            this.this_Class.Controls.Add(this.label8);
            this.this_Class.Controls.Add(this.label7);
            this.this_Class.Controls.Add(this.label6);
            this.this_Class.Location = new System.Drawing.Point(4, 22);
            this.this_Class.Name = "this_Class";
            this.this_Class.Padding = new System.Windows.Forms.Padding(3);
            this.this_Class.Size = new System.Drawing.Size(270, 313);
            this.this_Class.TabIndex = 1;
            this.this_Class.Text = "นักเรียนเฉพาะห้อง";
            this.this_Class.UseVisualStyleBackColor = true;
            // 
            // lb_classincorrect
            // 
            this.lb_classincorrect.AutoSize = true;
            this.lb_classincorrect.Font = new System.Drawing.Font("Kanit", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb_classincorrect.Location = new System.Drawing.Point(19, 236);
            this.lb_classincorrect.Name = "lb_classincorrect";
            this.lb_classincorrect.Size = new System.Drawing.Size(17, 24);
            this.lb_classincorrect.TabIndex = 19;
            this.lb_classincorrect.Text = "-";
            // 
            // lb_classguide
            // 
            this.lb_classguide.AutoSize = true;
            this.lb_classguide.Font = new System.Drawing.Font("Kanit", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb_classguide.Location = new System.Drawing.Point(19, 164);
            this.lb_classguide.Name = "lb_classguide";
            this.lb_classguide.Size = new System.Drawing.Size(17, 24);
            this.lb_classguide.TabIndex = 18;
            this.lb_classguide.Text = "-";
            // 
            // lb_classcorrect
            // 
            this.lb_classcorrect.AutoSize = true;
            this.lb_classcorrect.Font = new System.Drawing.Font("Kanit", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb_classcorrect.Location = new System.Drawing.Point(19, 92);
            this.lb_classcorrect.Name = "lb_classcorrect";
            this.lb_classcorrect.Size = new System.Drawing.Size(17, 24);
            this.lb_classcorrect.TabIndex = 17;
            this.lb_classcorrect.Text = "-";
            // 
            // lb_Allclass
            // 
            this.lb_Allclass.AutoSize = true;
            this.lb_Allclass.Font = new System.Drawing.Font("Kanit", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb_Allclass.Location = new System.Drawing.Point(19, 27);
            this.lb_Allclass.Name = "lb_Allclass";
            this.lb_Allclass.Size = new System.Drawing.Size(17, 24);
            this.lb_Allclass.TabIndex = 16;
            this.lb_Allclass.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Kanit", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(6, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "จำนวนนักเรียนที่ทำไม่ได้";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Kanit", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(3, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "จำนวนนักเรียนที่ทำได้โดยไกด์";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Kanit", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(3, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "จำนวนนักเรียนที่ทำได้";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Kanit", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "จำนวนนักเรียนทั้งหมด";
            // 
            // Score
            // 
            this.Score.Controls.Add(this.lb_classsore);
            this.Score.Controls.Add(this.lb_Allscore);
            this.Score.Controls.Add(this.label15);
            this.Score.Controls.Add(this.label14);
            this.Score.Location = new System.Drawing.Point(4, 22);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(270, 313);
            this.Score.TabIndex = 2;
            this.Score.Text = "คะแนนเฉลี่ย";
            this.Score.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Kanit", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 24);
            this.label14.TabIndex = 12;
            this.label14.Text = "คะแนนเฉลี่ยทั้งหมด";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Kanit", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label15.Location = new System.Drawing.Point(3, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 24);
            this.label15.TabIndex = 13;
            this.label15.Text = "คะแนนเฉลี่ยของห้อง";
            // 
            // lb_Allscore
            // 
            this.lb_Allscore.AutoSize = true;
            this.lb_Allscore.Font = new System.Drawing.Font("Kanit", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb_Allscore.Location = new System.Drawing.Point(17, 24);
            this.lb_Allscore.Name = "lb_Allscore";
            this.lb_Allscore.Size = new System.Drawing.Size(17, 24);
            this.lb_Allscore.TabIndex = 17;
            this.lb_Allscore.Text = "-";
            // 
            // lb_classsore
            // 
            this.lb_classsore.AutoSize = true;
            this.lb_classsore.Font = new System.Drawing.Font("Kanit", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb_classsore.Location = new System.Drawing.Point(17, 89);
            this.lb_classsore.Name = "lb_classsore";
            this.lb_classsore.Size = new System.Drawing.Size(17, 24);
            this.lb_classsore.TabIndex = 18;
            this.lb_classsore.Text = "-";
            // 
            // Evaluate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 581);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Evaluate";
            this.Text = "Evaluate";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.All_student.ResumeLayout(false);
            this.All_student.PerformLayout();
            this.this_Class.ResumeLayout(false);
            this.this_Class.PerformLayout();
            this.Score.ResumeLayout(false);
            this.Score.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage All_student;
        private System.Windows.Forms.TabPage this_Class;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbAll_guide;
        private System.Windows.Forms.Label lbAll_correct;
        private System.Windows.Forms.Label lbAllSutudent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbAll_incorrect;
        private System.Windows.Forms.Label lb_classincorrect;
        private System.Windows.Forms.Label lb_classguide;
        private System.Windows.Forms.Label lb_classcorrect;
        private System.Windows.Forms.Label lb_Allclass;
        private System.Windows.Forms.TabPage Score;
        private System.Windows.Forms.Label lb_classsore;
        private System.Windows.Forms.Label lb_Allscore;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}