namespace PROJECT_CS
{
    partial class EditData
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.box_search = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.box_parent_phone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.box_parent_status = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.box_parent = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.box_address = new System.Windows.Forms.TextBox();
            this.box_phone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.box_class = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.box_number = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.box_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.box_studentcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 341);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(964, 213);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kanit", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(729, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ค้นหา";
            // 
            // box_search
            // 
            this.box_search.Location = new System.Drawing.Point(776, 311);
            this.box_search.Name = "box_search";
            this.box_search.Size = new System.Drawing.Size(231, 20);
            this.box_search.TabIndex = 2;
            this.box_search.TextChanged += new System.EventHandler(this.txt_SearchName_TextChanged2);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.box_parent_phone);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.box_parent_status);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.box_parent);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.box_address);
            this.groupBox1.Controls.Add(this.box_phone);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.box_class);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.box_number);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.box_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.box_studentcode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Kanit", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(43, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(822, 282);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(392, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 24);
            this.label11.TabIndex = 27;
            this.label11.Text = "มีความเกี่ยวข้องเป็น";
            // 
            // box_parent_phone
            // 
            this.box_parent_phone.Location = new System.Drawing.Point(163, 183);
            this.box_parent_phone.Name = "box_parent_phone";
            this.box_parent_phone.Size = new System.Drawing.Size(197, 30);
            this.box_parent_phone.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 24);
            this.label10.TabIndex = 25;
            this.label10.Text = "เบอร์โทรศัพท์";
            // 
            // box_parent_status
            // 
            this.box_parent_status.Location = new System.Drawing.Point(534, 148);
            this.box_parent_status.Name = "box_parent_status";
            this.box_parent_status.Size = new System.Drawing.Size(145, 30);
            this.box_parent_status.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = "ที่อยู่";
            // 
            // box_parent
            // 
            this.box_parent.Location = new System.Drawing.Point(160, 148);
            this.box_parent.Name = "box_parent";
            this.box_parent.Size = new System.Drawing.Size(212, 30);
            this.box_parent.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 24);
            this.label9.TabIndex = 21;
            this.label9.Text = "ชื่อผู้ปกครอง";
            // 
            // box_address
            // 
            this.box_address.Location = new System.Drawing.Point(105, 219);
            this.box_address.Multiline = true;
            this.box_address.Name = "box_address";
            this.box_address.Size = new System.Drawing.Size(381, 45);
            this.box_address.TabIndex = 20;
            // 
            // box_phone
            // 
            this.box_phone.Location = new System.Drawing.Point(528, 108);
            this.box_phone.Name = "box_phone";
            this.box_phone.Size = new System.Drawing.Size(197, 30);
            this.box_phone.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "เบอร์โทรศัพท์";
            // 
            // box_class
            // 
            this.box_class.Location = new System.Drawing.Point(316, 108);
            this.box_class.Name = "box_class";
            this.box_class.Size = new System.Drawing.Size(107, 30);
            this.box_class.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "ชั้น";
            // 
            // box_number
            // 
            this.box_number.Location = new System.Drawing.Point(105, 108);
            this.box_number.Name = "box_number";
            this.box_number.Size = new System.Drawing.Size(168, 30);
            this.box_number.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "เลขที่";
            // 
            // box_name
            // 
            this.box_name.Location = new System.Drawing.Point(105, 70);
            this.box_name.Name = "box_name";
            this.box_name.Size = new System.Drawing.Size(447, 30);
            this.box_name.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "ชื่อ";
            // 
            // box_studentcode
            // 
            this.box_studentcode.Location = new System.Drawing.Point(155, 35);
            this.box_studentcode.Name = "box_studentcode";
            this.box_studentcode.Size = new System.Drawing.Size(104, 30);
            this.box_studentcode.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "รหัสนักเรียน";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(907, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 46);
            this.button2.TabIndex = 0;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(907, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 46);
            this.button3.TabIndex = 5;
            this.button3.Text = "EDIT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BTN_UPDATE_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(907, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 46);
            this.button4.TabIndex = 6;
            this.button4.Text = "CLEAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.BTN_clear_Click);
            // 
            // EditData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 581);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.box_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditData";
            this.Text = "EditData";
            this.Load += new System.EventHandler(this.Display_Insert_Update_Delete_Search_Image_In_MySQL_Database_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox box_search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox box_class;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox box_number;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox box_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox box_studentcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox box_address;
        private System.Windows.Forms.TextBox box_phone;
        private System.Windows.Forms.TextBox box_parent_status;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox box_parent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox box_parent_phone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}