namespace QUANLYSINHVIEN
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgSinhVien = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtDiemVHHD = new System.Windows.Forms.TextBox();
            this.txtDiemVHCD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtDiemVLHN = new System.Windows.Forms.TextBox();
            this.txtDiemDien = new System.Windows.Forms.TextBox();
            this.txtDiemQuangHoc = new System.Windows.Forms.TextBox();
            this.txtDiemCoHoc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtDiemSQL = new System.Windows.Forms.TextBox();
            this.txtDiemC = new System.Windows.Forms.TextBox();
            this.txtDiemPascal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.checkGender = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.lưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuFileKhácToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuNhữngNgườiĐangĐượcChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBoCapNhat = new System.Windows.Forms.ToolStripButton();
            this.btnCapNhat = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnBSVan = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBSVL = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBSCNTT = new System.Windows.Forms.ToolStripMenuItem();
            this.bdsSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDKHOA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSinhVien)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgSinhVien);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 400);
            this.panel1.TabIndex = 0;
            // 
            // dtgSinhVien
            // 
            this.dtgSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FullName,
            this.DateOfBirth,
            this.Gender,
            this.IDKHOA});
            this.dtgSinhVien.Location = new System.Drawing.Point(3, 53);
            this.dtgSinhVien.Name = "dtgSinhVien";
            this.dtgSinhVien.Size = new System.Drawing.Size(366, 329);
            this.dtgSinhVien.TabIndex = 3;
            this.dtgSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSinhVien_CellContentClick_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtNgaySinh);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.checkGender);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.toolStrip2);
            this.panel2.Location = new System.Drawing.Point(375, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 357);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Location = new System.Drawing.Point(17, 154);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 200);
            this.panel3.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "ĐTB:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(318, 158);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtDiemVHHD);
            this.tabPage1.Controls.Add(this.txtDiemVHCD);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(310, 132);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Văn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtDiemVHHD
            // 
            this.txtDiemVHHD.Location = new System.Drawing.Point(78, 52);
            this.txtDiemVHHD.Name = "txtDiemVHHD";
            this.txtDiemVHHD.Size = new System.Drawing.Size(114, 20);
            this.txtDiemVHHD.TabIndex = 3;
            this.txtDiemVHHD.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtDiemVHCD
            // 
            this.txtDiemVHCD.Location = new System.Drawing.Point(78, 15);
            this.txtDiemVHCD.Name = "txtDiemVHCD";
            this.txtDiemVHCD.Size = new System.Drawing.Size(114, 20);
            this.txtDiemVHCD.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Văn học HĐ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Văn học CĐ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtDiemVLHN);
            this.tabPage2.Controls.Add(this.txtDiemDien);
            this.tabPage2.Controls.Add(this.txtDiemQuangHoc);
            this.tabPage2.Controls.Add(this.txtDiemCoHoc);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(310, 132);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vật lý";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtDiemVLHN
            // 
            this.txtDiemVLHN.Location = new System.Drawing.Point(90, 95);
            this.txtDiemVLHN.Name = "txtDiemVLHN";
            this.txtDiemVLHN.Size = new System.Drawing.Size(114, 20);
            this.txtDiemVLHN.TabIndex = 8;
            // 
            // txtDiemDien
            // 
            this.txtDiemDien.Location = new System.Drawing.Point(90, 69);
            this.txtDiemDien.Name = "txtDiemDien";
            this.txtDiemDien.Size = new System.Drawing.Size(114, 20);
            this.txtDiemDien.TabIndex = 7;
            // 
            // txtDiemQuangHoc
            // 
            this.txtDiemQuangHoc.Location = new System.Drawing.Point(90, 40);
            this.txtDiemQuangHoc.Name = "txtDiemQuangHoc";
            this.txtDiemQuangHoc.Size = new System.Drawing.Size(114, 20);
            this.txtDiemQuangHoc.TabIndex = 6;
            // 
            // txtDiemCoHoc
            // 
            this.txtDiemCoHoc.Location = new System.Drawing.Point(90, 14);
            this.txtDiemCoHoc.Name = "txtDiemCoHoc";
            this.txtDiemCoHoc.Size = new System.Drawing.Size(114, 20);
            this.txtDiemCoHoc.TabIndex = 5;
            this.txtDiemCoHoc.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Vật lý hạt nhân";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Điện";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Quang học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cơ học";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtDiemSQL);
            this.tabPage3.Controls.Add(this.txtDiemC);
            this.tabPage3.Controls.Add(this.txtDiemPascal);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(310, 132);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "CNTT";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtDiemSQL
            // 
            this.txtDiemSQL.Location = new System.Drawing.Point(61, 84);
            this.txtDiemSQL.Name = "txtDiemSQL";
            this.txtDiemSQL.Size = new System.Drawing.Size(114, 20);
            this.txtDiemSQL.TabIndex = 8;
            // 
            // txtDiemC
            // 
            this.txtDiemC.Location = new System.Drawing.Point(61, 48);
            this.txtDiemC.Name = "txtDiemC";
            this.txtDiemC.Size = new System.Drawing.Size(114, 20);
            this.txtDiemC.TabIndex = 7;
            // 
            // txtDiemPascal
            // 
            this.txtDiemPascal.Location = new System.Drawing.Point(61, 15);
            this.txtDiemPascal.Name = "txtDiemPascal";
            this.txtDiemPascal.Size = new System.Drawing.Size(114, 20);
            this.txtDiemPascal.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(5, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "SQL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "C#";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Pascal";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(17, 107);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.txtNgaySinh.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày sinh";
            // 
            // checkGender
            // 
            this.checkGender.AutoSize = true;
            this.checkGender.Location = new System.Drawing.Point(17, 67);
            this.checkGender.Name = "checkGender";
            this.checkGender.Size = new System.Drawing.Size(91, 17);
            this.checkGender.TabIndex = 3;
            this.checkGender.Text = "Giới tính Nam";
            this.checkGender.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(17, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(271, 20);
            this.txtName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ tên";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(398, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(97, 22);
            this.toolStripLabel2.Text = "Thông tin chi tiết";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripDropDownButton1,
            this.btnBoCapNhat,
            this.btnCapNhat,
            this.btnXoa,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(776, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(64, 22);
            this.toolStripLabel1.Text = "File dữ liệu";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::QUANLYSINHVIEN.Properties.Resources.icons8_create_16;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::QUANLYSINHVIEN.Properties.Resources.icons8_yellow_file_16;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lưuToolStripMenuItem,
            this.lưuFileKhácToolStripMenuItem,
            this.lưuNhữngNgườiĐangĐượcChọnToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::QUANLYSINHVIEN.Properties.Resources.save;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // lưuToolStripMenuItem
            // 
            this.lưuToolStripMenuItem.Name = "lưuToolStripMenuItem";
            this.lưuToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.lưuToolStripMenuItem.Text = "Lưu";
            // 
            // lưuFileKhácToolStripMenuItem
            // 
            this.lưuFileKhácToolStripMenuItem.Name = "lưuFileKhácToolStripMenuItem";
            this.lưuFileKhácToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.lưuFileKhácToolStripMenuItem.Text = "Lưu file khác";
            // 
            // lưuNhữngNgườiĐangĐượcChọnToolStripMenuItem
            // 
            this.lưuNhữngNgườiĐangĐượcChọnToolStripMenuItem.Name = "lưuNhữngNgườiĐangĐượcChọnToolStripMenuItem";
            this.lưuNhữngNgườiĐangĐượcChọnToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.lưuNhữngNgườiĐangĐượcChọnToolStripMenuItem.Text = "Lưu những người đang được chọn";
            // 
            // btnBoCapNhat
            // 
            this.btnBoCapNhat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnBoCapNhat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnBoCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnBoCapNhat.Image")));
            this.btnBoCapNhat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBoCapNhat.Name = "btnBoCapNhat";
            this.btnBoCapNhat.Size = new System.Drawing.Size(74, 22);
            this.btnBoCapNhat.Text = "Bỏ cập nhật";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCapNhat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(59, 22);
            this.btnCapNhat.Text = "Cập nhật";
            // 
            // btnXoa
            // 
            this.btnXoa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnXoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(31, 22);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBSVan,
            this.btnBSVL,
            this.btnBSCNTT});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(63, 22);
            this.toolStripDropDownButton2.Text = "Bổ sung";
            this.toolStripDropDownButton2.Click += new System.EventHandler(this.toolStripDropDownButton2_Click);
            // 
            // btnBSVan
            // 
            this.btnBSVan.Name = "btnBSVan";
            this.btnBSVan.Size = new System.Drawing.Size(119, 22);
            this.btnBSVan.Text = "SV Văn";
            this.btnBSVan.Click += new System.EventHandler(this.sVVănToolStripMenuItem_Click);
            // 
            // btnBSVL
            // 
            this.btnBSVL.Name = "btnBSVL";
            this.btnBSVL.Size = new System.Drawing.Size(119, 22);
            this.btnBSVL.Text = "SV Vật lý";
            this.btnBSVL.Click += new System.EventHandler(this.btnBSVL_Click);
            // 
            // btnBSCNTT
            // 
            this.btnBSCNTT.Name = "btnBSCNTT";
            this.btnBSCNTT.Size = new System.Drawing.Size(119, 22);
            this.btnBSCNTT.Text = "SV CNTT";
            this.btnBSCNTT.Click += new System.EventHandler(this.btnBSCNTT_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID.Width = 30;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Họ tên";
            this.FullName.Name = "FullName";
            this.FullName.Width = 130;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.DataPropertyName = "DateOfBirth";
            this.DateOfBirth.HeaderText = "Ngày sinh";
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Width = 70;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Giới tính";
            this.Gender.Name = "Gender";
            this.Gender.Width = 50;
            // 
            // IDKHOA
            // 
            this.IDKHOA.DataPropertyName = "IDKHOA";
            this.IDKHOA.HeaderText = "ID Khoa";
            this.IDKHOA.Name = "IDKHOA";
            this.IDKHOA.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Quản lý sinh viên";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSinhVien)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem lưuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuFileKhácToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuNhữngNgườiĐangĐượcChọnToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnBoCapNhat;
        private System.Windows.Forms.ToolStripButton btnCapNhat;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem btnBSVan;
        private System.Windows.Forms.ToolStripMenuItem btnBSVL;
        private System.Windows.Forms.ToolStripMenuItem btnBSCNTT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkGender;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker txtNgaySinh;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtDiemVHHD;
        private System.Windows.Forms.TextBox txtDiemVHCD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtDiemVLHN;
        private System.Windows.Forms.TextBox txtDiemDien;
        private System.Windows.Forms.TextBox txtDiemQuangHoc;
        private System.Windows.Forms.TextBox txtDiemCoHoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiemSQL;
        private System.Windows.Forms.TextBox txtDiemC;
        private System.Windows.Forms.TextBox txtDiemPascal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource bdsSinhVien;
        private System.Windows.Forms.DataGridView dtgSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDKHOA;
    }
}

