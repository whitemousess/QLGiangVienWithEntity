namespace QLGiangVienWithEntity
{
    partial class frmGV
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
            this.anh = new System.Windows.Forms.PictureBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.maGiV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anhthe = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.MaGV = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Lable1 = new System.Windows.Forms.Label();
            this.HVT = new System.Windows.Forms.TextBox();
            this.SDT = new System.Windows.Forms.TextBox();
            this.txtHVT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.Label();
            this.txtGT = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtGC = new System.Windows.Forms.Label();
            this.GC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DC = new System.Windows.Forms.TextBox();
            this.NS = new System.Windows.Forms.DateTimePicker();
            this.btnload = new System.Windows.Forms.Button();
            this.GT = new System.Windows.Forms.ComboBox();
            this.txterror = new System.Windows.Forms.Label();
            this.btnref = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.anh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // anh
            // 
            this.anh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.anh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.anh.Location = new System.Drawing.Point(733, 50);
            this.anh.Margin = new System.Windows.Forms.Padding(2);
            this.anh.Name = "anh";
            this.anh.Size = new System.Drawing.Size(197, 290);
            this.anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anh.TabIndex = 48;
            this.anh.TabStop = false;
            this.anh.Click += new System.EventHandler(this.anh_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maGiV,
            this.hoten,
            this.sodt,
            this.gioitinh,
            this.ngaysinh,
            this.diachi,
            this.ghichu,
            this.anhthe});
            this.dgv.Location = new System.Drawing.Point(11, 361);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(940, 48);
            this.dgv.TabIndex = 31;
            this.dgv.Visible = false;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // maGiV
            // 
            this.maGiV.DataPropertyName = "magv";
            this.maGiV.HeaderText = "Mã Giáo Viên";
            this.maGiV.Name = "maGiV";
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Tên giáo viên";
            this.hoten.Name = "hoten";
            // 
            // sodt
            // 
            this.sodt.DataPropertyName = "sdt";
            this.sodt.HeaderText = "Số điện thoại";
            this.sodt.Name = "sodt";
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới Tính";
            this.gioitinh.Name = "gioitinh";
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "namsinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.Name = "ngaysinh";
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.Name = "ghichu";
            // 
            // anhthe
            // 
            this.anhthe.DataPropertyName = "hinhanh";
            this.anhthe.HeaderText = "Ảnh";
            this.anhthe.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.anhthe.Name = "anhthe";
            this.anhthe.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.anhthe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Quản Lý Giáo Viên";
            // 
            // MaGV
            // 
            this.MaGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaGV.Location = new System.Drawing.Point(149, 59);
            this.MaGV.Margin = new System.Windows.Forms.Padding(2);
            this.MaGV.Name = "MaGV";
            this.MaGV.Size = new System.Drawing.Size(354, 20);
            this.MaGV.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(557, 108);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 39);
            this.button2.TabIndex = 29;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Lable1
            // 
            this.Lable1.AutoSize = true;
            this.Lable1.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.Lable1.Location = new System.Drawing.Point(59, 58);
            this.Lable1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lable1.Name = "Lable1";
            this.Lable1.Size = new System.Drawing.Size(90, 17);
            this.Lable1.TabIndex = 30;
            this.Lable1.Text = "Mã Giáo Viên";
            // 
            // HVT
            // 
            this.HVT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HVT.Location = new System.Drawing.Point(149, 91);
            this.HVT.Margin = new System.Windows.Forms.Padding(2);
            this.HVT.Name = "HVT";
            this.HVT.Size = new System.Drawing.Size(354, 20);
            this.HVT.TabIndex = 1;
            // 
            // SDT
            // 
            this.SDT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SDT.Location = new System.Drawing.Point(149, 119);
            this.SDT.Margin = new System.Windows.Forms.Padding(2);
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(354, 20);
            this.SDT.TabIndex = 2;
            // 
            // txtHVT
            // 
            this.txtHVT.AutoSize = true;
            this.txtHVT.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtHVT.Location = new System.Drawing.Point(69, 92);
            this.txtHVT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtHVT.Name = "txtHVT";
            this.txtHVT.Size = new System.Drawing.Size(75, 17);
            this.txtHVT.TabIndex = 34;
            this.txtHVT.Text = "Họ Và Tên";
            // 
            // txtSDT
            // 
            this.txtSDT.AutoSize = true;
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtSDT.Location = new System.Drawing.Point(59, 123);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(84, 17);
            this.txtSDT.TabIndex = 35;
            this.txtSDT.Text = "Số điện thoại";
            // 
            // txtGT
            // 
            this.txtGT.AutoSize = true;
            this.txtGT.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtGT.Location = new System.Drawing.Point(73, 154);
            this.txtGT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtGT.Name = "txtGT";
            this.txtGT.Size = new System.Drawing.Size(57, 17);
            this.txtGT.TabIndex = 36;
            this.txtGT.Text = "Giới tính";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(557, 154);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 39);
            this.button1.TabIndex = 38;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(557, 209);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 39);
            this.button3.TabIndex = 39;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtGC
            // 
            this.txtGC.AutoSize = true;
            this.txtGC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGC.Location = new System.Drawing.Point(73, 189);
            this.txtGC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtGC.Name = "txtGC";
            this.txtGC.Size = new System.Drawing.Size(59, 19);
            this.txtGC.TabIndex = 41;
            this.txtGC.Text = "Ghi Chú";
            // 
            // GC
            // 
            this.GC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GC.Location = new System.Drawing.Point(149, 187);
            this.GC.Margin = new System.Windows.Forms.Padding(2);
            this.GC.Name = "GC";
            this.GC.Size = new System.Drawing.Size(354, 20);
            this.GC.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 45;
            this.label2.Text = "Năm sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 261);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 46;
            this.label3.Text = "Địa chỉ";
            // 
            // DC
            // 
            this.DC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DC.Location = new System.Drawing.Point(149, 256);
            this.DC.Margin = new System.Windows.Forms.Padding(2);
            this.DC.Name = "DC";
            this.DC.Size = new System.Drawing.Size(354, 20);
            this.DC.TabIndex = 4;
            // 
            // NS
            // 
            this.NS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NS.Location = new System.Drawing.Point(149, 224);
            this.NS.Margin = new System.Windows.Forms.Padding(2);
            this.NS.Name = "NS";
            this.NS.Size = new System.Drawing.Size(122, 20);
            this.NS.TabIndex = 49;
            // 
            // btnload
            // 
            this.btnload.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnload.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnload.Location = new System.Drawing.Point(557, 59);
            this.btnload.Margin = new System.Windows.Forms.Padding(2);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(99, 39);
            this.btnload.TabIndex = 50;
            this.btnload.Text = "Hiển thị";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // GT
            // 
            this.GT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GT.FormattingEnabled = true;
            this.GT.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.GT.Location = new System.Drawing.Point(149, 153);
            this.GT.Name = "GT";
            this.GT.Size = new System.Drawing.Size(121, 21);
            this.GT.TabIndex = 51;
            // 
            // txterror
            // 
            this.txterror.AutoSize = true;
            this.txterror.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txterror.ForeColor = System.Drawing.Color.Red;
            this.txterror.Location = new System.Drawing.Point(66, 31);
            this.txterror.Name = "txterror";
            this.txterror.Size = new System.Drawing.Size(0, 15);
            this.txterror.TabIndex = 52;
            // 
            // btnref
            // 
            this.btnref.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnref.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnref.Location = new System.Drawing.Point(557, 261);
            this.btnref.Margin = new System.Windows.Forms.Padding(2);
            this.btnref.Name = "btnref";
            this.btnref.Size = new System.Drawing.Size(99, 39);
            this.btnref.TabIndex = 53;
            this.btnref.Text = "Làm Mới";
            this.btnref.UseVisualStyleBackColor = true;
            this.btnref.Click += new System.EventHandler(this.btnref_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnref);
            this.groupBox1.Controls.Add(this.txterror);
            this.groupBox1.Controls.Add(this.GT);
            this.groupBox1.Controls.Add(this.btnload);
            this.groupBox1.Controls.Add(this.NS);
            this.groupBox1.Controls.Add(this.DC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.GC);
            this.groupBox1.Controls.Add(this.txtGC);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtGT);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtHVT);
            this.groupBox1.Controls.Add(this.SDT);
            this.groupBox1.Controls.Add(this.HVT);
            this.groupBox1.Controls.Add(this.Lable1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.MaGV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 340);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // frmGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(958, 420);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.anh);
            this.Controls.Add(this.dgv);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Giảng Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.anh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox anh;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGiV;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodt;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        private System.Windows.Forms.DataGridViewImageColumn anhthe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MaGV;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Lable1;
        private System.Windows.Forms.TextBox HVT;
        private System.Windows.Forms.TextBox SDT;
        private System.Windows.Forms.Label txtHVT;
        private System.Windows.Forms.Label txtSDT;
        private System.Windows.Forms.Label txtGT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label txtGC;
        private System.Windows.Forms.TextBox GC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DC;
        private System.Windows.Forms.DateTimePicker NS;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.ComboBox GT;
        private System.Windows.Forms.Label txterror;
        private System.Windows.Forms.Button btnref;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

