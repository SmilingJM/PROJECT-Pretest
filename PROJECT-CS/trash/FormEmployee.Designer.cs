namespace PROJECT_CS.Forms
{
    partial class FormEmployee
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnempupdate = new System.Windows.Forms.Button();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.GroupBox10 = new System.Windows.Forms.GroupBox();
            this.txtworkstatus = new System.Windows.Forms.ComboBox();
            this.Label37 = new System.Windows.Forms.Label();
            this.Label36 = new System.Windows.Forms.Label();
            this.Label35 = new System.Windows.Forms.Label();
            this.Label34 = new System.Windows.Forms.Label();
            this.Label33 = new System.Windows.Forms.Label();
            this.txtposition = new System.Windows.Forms.TextBox();
            this.txtdrate = new System.Windows.Forms.TextBox();
            this.dtpdhired = new System.Windows.Forms.DateTimePicker();
            this.txtpmethod = new System.Windows.Forms.ComboBox();
            this.GroupBox9 = new System.Windows.Forms.GroupBox();
            this.txtbplace = new System.Windows.Forms.RichTextBox();
            this.txtaddress = new System.Windows.Forms.RichTextBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.dtpdbirth = new System.Windows.Forms.DateTimePicker();
            this.Label22 = new System.Windows.Forms.Label();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.Label23 = new System.Windows.Forms.Label();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.Label24 = new System.Windows.Forms.Label();
            this.txtmname = new System.Windows.Forms.TextBox();
            this.rdofemale = new System.Windows.Forms.RadioButton();
            this.txtemerg = new System.Windows.Forms.TextBox();
            this.rdomale = new System.Windows.Forms.RadioButton();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.Label27 = new System.Windows.Forms.Label();
            this.txtstatus = new System.Windows.Forms.ComboBox();
            this.Label28 = new System.Windows.Forms.Label();
            this.Label29 = new System.Windows.Forms.Label();
            this.Label30 = new System.Windows.Forms.Label();
            this.Label31 = new System.Windows.Forms.Label();
            this.btnempnew = new System.Windows.Forms.Button();
            this.btnempsave = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgemplist = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.Label46 = new System.Windows.Forms.Label();
            this.txtempsearch = new System.Windows.Forms.TextBox();
            this.kryptonTextBox5 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox14 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox4 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GroupBox10.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgemplist)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 584);
            this.panel1.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(31, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(991, 523);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnempupdate);
            this.tabPage1.Controls.Add(this.txtcode);
            this.tabPage1.Controls.Add(this.Label20);
            this.tabPage1.Controls.Add(this.GroupBox10);
            this.tabPage1.Controls.Add(this.GroupBox9);
            this.tabPage1.Controls.Add(this.btnempnew);
            this.tabPage1.Controls.Add(this.btnempsave);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(983, 497);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "กรอกข้อมูลพนักงาน";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MiPancake", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(444, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 109);
            this.label2.TabIndex = 33;
            this.label2.Text = "ข้อมูล";
            // 
            // btnempupdate
            // 
            this.btnempupdate.Location = new System.Drawing.Point(486, 448);
            this.btnempupdate.Name = "btnempupdate";
            this.btnempupdate.Size = new System.Drawing.Size(75, 32);
            this.btnempupdate.TabIndex = 32;
            this.btnempupdate.Text = "Update";
            this.btnempupdate.UseVisualStyleBackColor = true;
            this.btnempupdate.Click += new System.EventHandler(this.btnempupdate_Click);
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(196, 99);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(200, 20);
            this.txtcode.TabIndex = 26;
            this.txtcode.TextChanged += new System.EventHandler(this.txtcode_TextChanged);
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(117, 102);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(71, 13);
            this.Label20.TabIndex = 28;
            this.Label20.Text = "Assign code :";
            // 
            // GroupBox10
            // 
            this.GroupBox10.Controls.Add(this.txtworkstatus);
            this.GroupBox10.Controls.Add(this.Label37);
            this.GroupBox10.Controls.Add(this.Label36);
            this.GroupBox10.Controls.Add(this.Label35);
            this.GroupBox10.Controls.Add(this.Label34);
            this.GroupBox10.Controls.Add(this.Label33);
            this.GroupBox10.Controls.Add(this.txtposition);
            this.GroupBox10.Controls.Add(this.txtdrate);
            this.GroupBox10.Controls.Add(this.dtpdhired);
            this.GroupBox10.Controls.Add(this.txtpmethod);
            this.GroupBox10.Location = new System.Drawing.Point(111, 320);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.Size = new System.Drawing.Size(785, 111);
            this.GroupBox10.TabIndex = 31;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "ข้อมูลการทำงาน";
            // 
            // txtworkstatus
            // 
            this.txtworkstatus.FormattingEnabled = true;
            this.txtworkstatus.Items.AddRange(new object[] {
            "ปฏิบัติงาน",
            "ลาออก",
            "เกษียณ"});
            this.txtworkstatus.Location = new System.Drawing.Point(349, 48);
            this.txtworkstatus.Name = "txtworkstatus";
            this.txtworkstatus.Size = new System.Drawing.Size(154, 21);
            this.txtworkstatus.TabIndex = 8;
            // 
            // Label37
            // 
            this.Label37.AutoSize = true;
            this.Label37.Location = new System.Drawing.Point(19, 22);
            this.Label37.Name = "Label37";
            this.Label37.Size = new System.Drawing.Size(71, 13);
            this.Label37.TabIndex = 7;
            this.Label37.Text = "รายได้ต่อวัน :";
            // 
            // Label36
            // 
            this.Label36.AutoSize = true;
            this.Label36.Location = new System.Drawing.Point(293, 22);
            this.Label36.Name = "Label36";
            this.Label36.Size = new System.Drawing.Size(53, 13);
            this.Label36.TabIndex = 6;
            this.Label36.Text = "ตำแหน่ง :";
            // 
            // Label35
            // 
            this.Label35.AutoSize = true;
            this.Label35.Location = new System.Drawing.Point(303, 51);
            this.Label35.Name = "Label35";
            this.Label35.Size = new System.Drawing.Size(44, 13);
            this.Label35.TabIndex = 5;
            this.Label35.Text = "สถานะ :";
            // 
            // Label34
            // 
            this.Label34.AutoSize = true;
            this.Label34.Location = new System.Drawing.Point(6, 51);
            this.Label34.Name = "Label34";
            this.Label34.Size = new System.Drawing.Size(84, 13);
            this.Label34.TabIndex = 4;
            this.Label34.Text = "วิธีการชำระเงิน :";
            // 
            // Label33
            // 
            this.Label33.AutoSize = true;
            this.Label33.Location = new System.Drawing.Point(545, 22);
            this.Label33.Name = "Label33";
            this.Label33.Size = new System.Drawing.Size(50, 13);
            this.Label33.TabIndex = 3;
            this.Label33.Text = "วันที่จ้าง :";
            // 
            // txtposition
            // 
            this.txtposition.Location = new System.Drawing.Point(347, 19);
            this.txtposition.Name = "txtposition";
            this.txtposition.Size = new System.Drawing.Size(156, 20);
            this.txtposition.TabIndex = 2;
            // 
            // txtdrate
            // 
            this.txtdrate.Location = new System.Drawing.Point(96, 19);
            this.txtdrate.MaxLength = 3;
            this.txtdrate.Name = "txtdrate";
            this.txtdrate.Size = new System.Drawing.Size(154, 20);
            this.txtdrate.TabIndex = 2;
            // 
            // dtpdhired
            // 
            this.dtpdhired.CustomFormat = "yyyy-MM-dd";
            this.dtpdhired.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdhired.Location = new System.Drawing.Point(601, 19);
            this.dtpdhired.Name = "dtpdhired";
            this.dtpdhired.Size = new System.Drawing.Size(154, 20);
            this.dtpdhired.TabIndex = 1;
            // 
            // txtpmethod
            // 
            this.txtpmethod.FormattingEnabled = true;
            this.txtpmethod.Items.AddRange(new object[] {
            "รายสัปดาห์",
            "รายเดือน"});
            this.txtpmethod.Location = new System.Drawing.Point(96, 48);
            this.txtpmethod.Name = "txtpmethod";
            this.txtpmethod.Size = new System.Drawing.Size(154, 21);
            this.txtpmethod.TabIndex = 0;
            // 
            // GroupBox9
            // 
            this.GroupBox9.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox9.Controls.Add(this.txtbplace);
            this.GroupBox9.Controls.Add(this.txtaddress);
            this.GroupBox9.Controls.Add(this.Label21);
            this.GroupBox9.Controls.Add(this.dtpdbirth);
            this.GroupBox9.Controls.Add(this.Label22);
            this.GroupBox9.Controls.Add(this.txtlname);
            this.GroupBox9.Controls.Add(this.Label23);
            this.GroupBox9.Controls.Add(this.txtcontact);
            this.GroupBox9.Controls.Add(this.txtage);
            this.GroupBox9.Controls.Add(this.txtfname);
            this.GroupBox9.Controls.Add(this.Label24);
            this.GroupBox9.Controls.Add(this.txtmname);
            this.GroupBox9.Controls.Add(this.rdofemale);
            this.GroupBox9.Controls.Add(this.txtemerg);
            this.GroupBox9.Controls.Add(this.rdomale);
            this.GroupBox9.Controls.Add(this.Label25);
            this.GroupBox9.Controls.Add(this.Label26);
            this.GroupBox9.Controls.Add(this.Label27);
            this.GroupBox9.Controls.Add(this.txtstatus);
            this.GroupBox9.Controls.Add(this.Label28);
            this.GroupBox9.Controls.Add(this.Label29);
            this.GroupBox9.Controls.Add(this.Label30);
            this.GroupBox9.Controls.Add(this.Label31);
            this.GroupBox9.Location = new System.Drawing.Point(111, 125);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new System.Drawing.Size(791, 189);
            this.GroupBox9.TabIndex = 30;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "ข้อมูลส่วนบุคคล";
            // 
            // txtbplace
            // 
            this.txtbplace.Location = new System.Drawing.Point(85, 127);
            this.txtbplace.Name = "txtbplace";
            this.txtbplace.Size = new System.Drawing.Size(166, 54);
            this.txtbplace.TabIndex = 17;
            this.txtbplace.Text = "";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(85, 61);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(166, 54);
            this.txtaddress.TabIndex = 17;
            this.txtaddress.Text = "";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(22, 130);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(59, 13);
            this.Label21.TabIndex = 14;
            this.Label21.Text = "สถานที่เกิด";
            // 
            // dtpdbirth
            // 
            this.dtpdbirth.CustomFormat = "yyyy-MM-dd";
            this.dtpdbirth.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpdbirth.Location = new System.Drawing.Point(626, 95);
            this.dtpdbirth.Name = "dtpdbirth";
            this.dtpdbirth.Size = new System.Drawing.Size(145, 20);
            this.dtpdbirth.TabIndex = 12;
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(580, 98);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(40, 13);
            this.Label22.TabIndex = 11;
            this.Label22.Text = "วันเกิด";
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(353, 32);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(178, 20);
            this.txtlname.TabIndex = 0;
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Location = new System.Drawing.Point(321, 135);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(25, 13);
            this.Label23.TabIndex = 9;
            this.Label23.Text = "อายุ";
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(353, 59);
            this.txtcontact.MaxLength = 11;
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(178, 20);
            this.txtcontact.TabIndex = 0;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(353, 131);
            this.txtage.MaxLength = 2;
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(58, 20);
            this.txtage.TabIndex = 8;
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(85, 32);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(165, 20);
            this.txtfname.TabIndex = 0;
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(319, 98);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(28, 13);
            this.Label24.TabIndex = 7;
            this.Label24.Text = "เพศ";
            // 
            // txtmname
            // 
            this.txtmname.Location = new System.Drawing.Point(626, 32);
            this.txtmname.Name = "txtmname";
            this.txtmname.Size = new System.Drawing.Size(156, 20);
            this.txtmname.TabIndex = 0;
            // 
            // rdofemale
            // 
            this.rdofemale.AutoSize = true;
            this.rdofemale.Location = new System.Drawing.Point(406, 98);
            this.rdofemale.Name = "rdofemale";
            this.rdofemale.Size = new System.Drawing.Size(46, 17);
            this.rdofemale.TabIndex = 6;
            this.rdofemale.TabStop = true;
            this.rdofemale.Text = "หญิง";
            this.rdofemale.UseVisualStyleBackColor = true;
            // 
            // txtemerg
            // 
            this.txtemerg.Location = new System.Drawing.Point(626, 131);
            this.txtemerg.MaxLength = 11;
            this.txtemerg.Name = "txtemerg";
            this.txtemerg.Size = new System.Drawing.Size(155, 20);
            this.txtemerg.TabIndex = 0;
            // 
            // rdomale
            // 
            this.rdomale.AutoSize = true;
            this.rdomale.Location = new System.Drawing.Point(352, 98);
            this.rdomale.Name = "rdomale";
            this.rdomale.Size = new System.Drawing.Size(44, 17);
            this.rdomale.TabIndex = 6;
            this.rdomale.TabStop = true;
            this.rdomale.Text = "ชาย";
            this.rdomale.UseVisualStyleBackColor = true;
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Location = new System.Drawing.Point(275, 62);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(72, 13);
            this.Label25.TabIndex = 1;
            this.Label25.Text = "เบอร์โทรศัพท์";
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Location = new System.Drawing.Point(53, 35);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(20, 13);
            this.Label26.TabIndex = 1;
            this.Label26.Text = "ชื่อ";
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Location = new System.Drawing.Point(583, 61);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(38, 13);
            this.Label27.TabIndex = 1;
            this.Label27.Text = "สถานะ";
            // 
            // txtstatus
            // 
            this.txtstatus.FormattingEnabled = true;
            this.txtstatus.Items.AddRange(new object[] {
            "แต่งงานแล้ว",
            "โสด"});
            this.txtstatus.Location = new System.Drawing.Point(626, 58);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(121, 21);
            this.txtstatus.TabIndex = 2;
            // 
            // Label28
            // 
            this.Label28.AutoSize = true;
            this.Label28.Location = new System.Drawing.Point(301, 35);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(46, 13);
            this.Label28.TabIndex = 1;
            this.Label28.Text = "นามสกุล";
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.Location = new System.Drawing.Point(50, 64);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(27, 13);
            this.Label29.TabIndex = 1;
            this.Label29.Text = "ที่อยู่";
            // 
            // Label30
            // 
            this.Label30.AutoSize = true;
            this.Label30.Location = new System.Drawing.Point(526, 134);
            this.Label30.Name = "Label30";
            this.Label30.Size = new System.Drawing.Size(94, 13);
            this.Label30.TabIndex = 1;
            this.Label30.Text = "เบอร์ติดต่อฉุกเฉิน";
            // 
            // Label31
            // 
            this.Label31.AutoSize = true;
            this.Label31.Location = new System.Drawing.Point(583, 35);
            this.Label31.Name = "Label31";
            this.Label31.Size = new System.Drawing.Size(39, 13);
            this.Label31.TabIndex = 1;
            this.Label31.Text = "ชื่อเล่น";
            // 
            // btnempnew
            // 
            this.btnempnew.Location = new System.Drawing.Point(567, 448);
            this.btnempnew.Name = "btnempnew";
            this.btnempnew.Size = new System.Drawing.Size(75, 32);
            this.btnempnew.TabIndex = 27;
            this.btnempnew.Text = "New";
            this.btnempnew.UseVisualStyleBackColor = true;
            this.btnempnew.Click += new System.EventHandler(this.btnempnew_Click);
            // 
            // btnempsave
            // 
            this.btnempsave.Location = new System.Drawing.Point(405, 448);
            this.btnempsave.Name = "btnempsave";
            this.btnempsave.Size = new System.Drawing.Size(75, 32);
            this.btnempsave.TabIndex = 29;
            this.btnempsave.Text = "Save";
            this.btnempsave.UseVisualStyleBackColor = true;
            this.btnempsave.Click += new System.EventHandler(this.btnempsave_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btn_edit);
            this.tabPage2.Controls.Add(this.btndelete);
            this.tabPage2.Controls.Add(this.Label46);
            this.tabPage2.Controls.Add(this.txtempsearch);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(983, 497);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ข้อมูลพนักงาน";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgemplist);
            this.panel2.Location = new System.Drawing.Point(72, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(862, 381);
            this.panel2.TabIndex = 31;
            // 
            // dtgemplist
            // 
            this.dtgemplist.AllowUserToAddRows = false;
            this.dtgemplist.AllowUserToDeleteRows = false;
            this.dtgemplist.AllowUserToResizeColumns = false;
            this.dtgemplist.AllowUserToResizeRows = false;
            this.dtgemplist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgemplist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgemplist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgemplist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgemplist.Location = new System.Drawing.Point(12, 18);
            this.dtgemplist.Name = "dtgemplist";
            this.dtgemplist.RowHeadersVisible = false;
            this.dtgemplist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgemplist.ShowCellToolTips = false;
            this.dtgemplist.Size = new System.Drawing.Size(836, 348);
            this.dtgemplist.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "ข้อมูลพนักงานในระบบ";
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(660, 62);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(129, 34);
            this.btn_edit.TabIndex = 29;
            this.btn_edit.Text = "แก้ไข";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(795, 62);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(129, 34);
            this.btndelete.TabIndex = 28;
            this.btndelete.Text = "ลบข้อมูล";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Label46
            // 
            this.Label46.AutoSize = true;
            this.Label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Label46.Location = new System.Drawing.Point(170, 69);
            this.Label46.Name = "Label46";
            this.Label46.Size = new System.Drawing.Size(59, 18);
            this.Label46.TabIndex = 27;
            this.Label46.Text = "ค้นหา  :";
            // 
            // txtempsearch
            // 
            this.txtempsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempsearch.Location = new System.Drawing.Point(235, 68);
            this.txtempsearch.Name = "txtempsearch";
            this.txtempsearch.Size = new System.Drawing.Size(391, 22);
            this.txtempsearch.TabIndex = 26;
            this.txtempsearch.TextChanged += new System.EventHandler(this.txtempsearch_TextChanged);
            // 
            // kryptonTextBox5
            // 
            this.kryptonTextBox5.Location = new System.Drawing.Point(258, 502);
            this.kryptonTextBox5.Name = "kryptonTextBox5";
            this.kryptonTextBox5.Size = new System.Drawing.Size(431, 29);
            this.kryptonTextBox5.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox5.StateCommon.Border.Rounding = 10;
            this.kryptonTextBox5.StateCommon.Border.Width = 0;
            this.kryptonTextBox5.TabIndex = 9;
            this.kryptonTextBox5.Text = "kryptonTextBox5";
            // 
            // kryptonTextBox14
            // 
            this.kryptonTextBox14.Location = new System.Drawing.Point(258, 502);
            this.kryptonTextBox14.Name = "kryptonTextBox14";
            this.kryptonTextBox14.Size = new System.Drawing.Size(431, 29);
            this.kryptonTextBox14.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox14.StateCommon.Border.Rounding = 10;
            this.kryptonTextBox14.StateCommon.Border.Width = 0;
            this.kryptonTextBox14.TabIndex = 9;
            this.kryptonTextBox14.Text = "kryptonTextBox14";
            // 
            // kryptonTextBox4
            // 
            this.kryptonTextBox4.Location = new System.Drawing.Point(258, 502);
            this.kryptonTextBox4.Name = "kryptonTextBox4";
            this.kryptonTextBox4.Size = new System.Drawing.Size(431, 29);
            this.kryptonTextBox4.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox4.StateCommon.Border.Rounding = 10;
            this.kryptonTextBox4.StateCommon.Border.Width = 0;
            this.kryptonTextBox4.TabIndex = 9;
            this.kryptonTextBox4.Text = "kryptonTextBox4";
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 581);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmployee";
            this.Text = "FormTest";
            this.Load += new System.EventHandler(this.frm_Employees_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.GroupBox10.ResumeLayout(false);
            this.GroupBox10.PerformLayout();
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox9.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgemplist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox14;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button btnempupdate;
        internal System.Windows.Forms.TextBox txtcode;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.GroupBox GroupBox10;
        internal System.Windows.Forms.ComboBox txtworkstatus;
        internal System.Windows.Forms.Label Label37;
        internal System.Windows.Forms.Label Label36;
        internal System.Windows.Forms.Label Label35;
        internal System.Windows.Forms.Label Label34;
        internal System.Windows.Forms.Label Label33;
        internal System.Windows.Forms.TextBox txtposition;
        internal System.Windows.Forms.TextBox txtdrate;
        internal System.Windows.Forms.DateTimePicker dtpdhired;
        internal System.Windows.Forms.ComboBox txtpmethod;
        internal System.Windows.Forms.GroupBox GroupBox9;
        internal System.Windows.Forms.RichTextBox txtbplace;
        internal System.Windows.Forms.RichTextBox txtaddress;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.DateTimePicker dtpdbirth;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.TextBox txtlname;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.TextBox txtcontact;
        internal System.Windows.Forms.TextBox txtage;
        internal System.Windows.Forms.TextBox txtfname;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.TextBox txtmname;
        internal System.Windows.Forms.RadioButton rdofemale;
        internal System.Windows.Forms.TextBox txtemerg;
        internal System.Windows.Forms.RadioButton rdomale;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.Label Label27;
        internal System.Windows.Forms.ComboBox txtstatus;
        internal System.Windows.Forms.Label Label28;
        internal System.Windows.Forms.Label Label29;
        internal System.Windows.Forms.Label Label30;
        internal System.Windows.Forms.Label Label31;
        internal System.Windows.Forms.Button btnempnew;
        internal System.Windows.Forms.Button btnempsave;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btn_edit;
        internal System.Windows.Forms.Button btndelete;
        internal System.Windows.Forms.Label Label46;
        internal System.Windows.Forms.TextBox txtempsearch;
        internal System.Windows.Forms.DataGridView dtgemplist;
        private System.Windows.Forms.Panel panel2;
    }
}