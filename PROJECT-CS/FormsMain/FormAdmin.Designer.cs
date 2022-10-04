namespace PROJECT_CS.Forms
{
    partial class FormAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GroupBox11 = new System.Windows.Forms.GroupBox();
            this.noID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtconfirm = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMUdel = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.GroupBox12 = new System.Windows.Forms.GroupBox();
            this.UserData = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GroupBox11.SuspendLayout();
            this.GroupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox11
            // 
            this.GroupBox11.BackColor = System.Drawing.Color.White;
            this.GroupBox11.Controls.Add(this.noID);
            this.GroupBox11.Controls.Add(this.label4);
            this.GroupBox11.Controls.Add(this.label3);
            this.GroupBox11.Controls.Add(this.label2);
            this.GroupBox11.Controls.Add(this.txtconfirm);
            this.GroupBox11.Controls.Add(this.txtpass);
            this.GroupBox11.Controls.Add(this.txtusername);
            this.GroupBox11.Controls.Add(this.label1);
            this.GroupBox11.Controls.Add(this.btnMUdel);
            this.GroupBox11.Controls.Add(this.txtname);
            this.GroupBox11.Controls.Add(this.btn_update);
            this.GroupBox11.Controls.Add(this.Button6);
            this.GroupBox11.Controls.Add(this.btnsave);
            this.GroupBox11.Location = new System.Drawing.Point(193, 27);
            this.GroupBox11.Name = "GroupBox11";
            this.GroupBox11.Size = new System.Drawing.Size(648, 261);
            this.GroupBox11.TabIndex = 8;
            this.GroupBox11.TabStop = false;
            this.GroupBox11.Text = "Add New User";
            // 
            // noID
            // 
            this.noID.AutoSize = true;
            this.noID.Font = new System.Drawing.Font("Kanit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.noID.Location = new System.Drawing.Point(36, 16);
            this.noID.Name = "noID";
            this.noID.Size = new System.Drawing.Size(29, 30);
            this.noID.TabIndex = 24;
            this.noID.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Kanit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(36, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 30);
            this.label4.TabIndex = 23;
            this.label4.Text = "Confirm Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kanit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(36, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 30);
            this.label3.TabIndex = 22;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kanit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(36, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 30);
            this.label2.TabIndex = 21;
            this.label2.Text = "Username";
            // 
            // txtconfirm
            // 
            this.txtconfirm.Font = new System.Drawing.Font("Kanit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtconfirm.Location = new System.Drawing.Point(225, 207);
            this.txtconfirm.Name = "txtconfirm";
            this.txtconfirm.Size = new System.Drawing.Size(218, 36);
            this.txtconfirm.TabIndex = 20;
            this.txtconfirm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpass_KeyPress);
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Kanit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtpass.Location = new System.Drawing.Point(225, 157);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(218, 36);
            this.txtpass.TabIndex = 19;
            this.txtpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpass_KeyPress);
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Kanit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtusername.Location = new System.Drawing.Point(225, 111);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(218, 36);
            this.txtusername.TabIndex = 18;
            this.txtusername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusername_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kanit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(36, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "ชื่อผู้ใช้งาน";
            // 
            // btnMUdel
            // 
            this.btnMUdel.Location = new System.Drawing.Point(527, 177);
            this.btnMUdel.Name = "btnMUdel";
            this.btnMUdel.Size = new System.Drawing.Size(75, 40);
            this.btnMUdel.TabIndex = 15;
            this.btnMUdel.Text = "Delete";
            this.btnMUdel.UseVisualStyleBackColor = true;
            this.btnMUdel.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Kanit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtname.Location = new System.Drawing.Point(225, 61);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(218, 36);
            this.txtname.TabIndex = 13;
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(527, 85);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 40);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Edit";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.BTN_UPDATE_Click);
            // 
            // Button6
            // 
            this.Button6.Location = new System.Drawing.Point(527, 131);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(75, 40);
            this.Button6.TabIndex = 7;
            this.Button6.Text = "New";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.BTN_clear_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(527, 39);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 40);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "Add";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // GroupBox12
            // 
            this.GroupBox12.BackColor = System.Drawing.Color.White;
            this.GroupBox12.Controls.Add(this.UserData);
            this.GroupBox12.Location = new System.Drawing.Point(88, 294);
            this.GroupBox12.Name = "GroupBox12";
            this.GroupBox12.Size = new System.Drawing.Size(836, 247);
            this.GroupBox12.TabIndex = 7;
            this.GroupBox12.TabStop = false;
            this.GroupBox12.Text = "List Of Users";
            // 
            // UserData
            // 
            this.UserData.AllowUserToAddRows = false;
            this.UserData.AllowUserToDeleteRows = false;
            this.UserData.AllowUserToResizeColumns = false;
            this.UserData.AllowUserToResizeRows = false;
            this.UserData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserData.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.UserData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserData.DefaultCellStyle = dataGridViewCellStyle14;
            this.UserData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.UserData.GridColor = System.Drawing.Color.Black;
            this.UserData.Location = new System.Drawing.Point(3, 16);
            this.UserData.Name = "UserData";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserData.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.UserData.RowHeadersVisible = false;
            this.UserData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserData.Size = new System.Drawing.Size(830, 228);
            this.UserData.TabIndex = 0;
            this.UserData.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GroupBox11);
            this.panel1.Controls.Add(this.GroupBox12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 581);
            this.panel1.TabIndex = 10;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 581);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.GroupBox11.ResumeLayout(false);
            this.GroupBox11.PerformLayout();
            this.GroupBox12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        internal System.Windows.Forms.GroupBox GroupBox11;
        internal System.Windows.Forms.Button btnMUdel;
        internal System.Windows.Forms.TextBox txtname;
        internal System.Windows.Forms.Button btn_update;
        internal System.Windows.Forms.Button btnsave;
        internal System.Windows.Forms.GroupBox GroupBox12;
        internal System.Windows.Forms.DataGridView UserData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtconfirm;
        internal System.Windows.Forms.TextBox txtpass;
        internal System.Windows.Forms.TextBox txtusername;
        internal System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Label noID;
    }
}