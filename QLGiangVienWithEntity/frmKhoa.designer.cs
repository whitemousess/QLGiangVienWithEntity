namespace QLGiangVienWithEntity
{
    partial class frmKhoa
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
            this.quanlykhoacuagiangvien = new System.Windows.Forms.Button();
            this.txtmakhoa = new System.Windows.Forms.TextBox();
            this.txttenkhoa = new System.Windows.Forms.TextBox();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thembt = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tenkhoa = new System.Windows.Forms.Label();
            this.lammoi = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.makhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhoas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnshow = new System.Windows.Forms.Button();
            this.txterror = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // quanlykhoacuagiangvien
            // 
            this.quanlykhoacuagiangvien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.quanlykhoacuagiangvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanlykhoacuagiangvien.Location = new System.Drawing.Point(212, 4);
            this.quanlykhoacuagiangvien.Margin = new System.Windows.Forms.Padding(2);
            this.quanlykhoacuagiangvien.Name = "quanlykhoacuagiangvien";
            this.quanlykhoacuagiangvien.Size = new System.Drawing.Size(369, 60);
            this.quanlykhoacuagiangvien.TabIndex = 0;
            this.quanlykhoacuagiangvien.Text = "QUẢN LÝ KHOA CỦA GIẢNG VIÊN";
            this.quanlykhoacuagiangvien.UseVisualStyleBackColor = true;
            // 
            // txtmakhoa
            // 
            this.txtmakhoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmakhoa.Location = new System.Drawing.Point(115, 94);
            this.txtmakhoa.Margin = new System.Windows.Forms.Padding(2);
            this.txtmakhoa.Multiline = true;
            this.txtmakhoa.Name = "txtmakhoa";
            this.txtmakhoa.Size = new System.Drawing.Size(535, 28);
            this.txtmakhoa.TabIndex = 2;
            // 
            // txttenkhoa
            // 
            this.txttenkhoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txttenkhoa.Location = new System.Drawing.Point(115, 138);
            this.txttenkhoa.Margin = new System.Windows.Forms.Padding(2);
            this.txttenkhoa.Multiline = true;
            this.txttenkhoa.Name = "txttenkhoa";
            this.txttenkhoa.Size = new System.Drawing.Size(535, 28);
            this.txttenkhoa.TabIndex = 3;
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataMember = "Khoa";
            // 
            // thembt
            // 
            this.thembt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.thembt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thembt.Location = new System.Drawing.Point(696, 127);
            this.thembt.Margin = new System.Windows.Forms.Padding(2);
            this.thembt.Name = "thembt";
            this.thembt.Size = new System.Drawing.Size(76, 39);
            this.thembt.TabIndex = 6;
            this.thembt.Text = "Thêm ";
            this.thembt.UseVisualStyleBackColor = true;
            this.thembt.Click += new System.EventHandler(this.thembt_Click);
            // 
            // sua
            // 
            this.sua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sua.Location = new System.Drawing.Point(696, 174);
            this.sua.Margin = new System.Windows.Forms.Padding(2);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(76, 39);
            this.sua.TabIndex = 7;
            this.sua.Text = "Sửa ";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // xoa
            // 
            this.xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.Location = new System.Drawing.Point(696, 219);
            this.xoa.Margin = new System.Windows.Forms.Padding(2);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(76, 39);
            this.xoa.TabIndex = 8;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã khoa :";
            // 
            // tenkhoa
            // 
            this.tenkhoa.AutoSize = true;
            this.tenkhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenkhoa.Location = new System.Drawing.Point(9, 144);
            this.tenkhoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tenkhoa.Name = "tenkhoa";
            this.tenkhoa.Size = new System.Drawing.Size(76, 17);
            this.tenkhoa.TabIndex = 11;
            this.tenkhoa.Text = "Tên khoa :";
            // 
            // lammoi
            // 
            this.lammoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lammoi.Location = new System.Drawing.Point(696, 262);
            this.lammoi.Margin = new System.Windows.Forms.Padding(2);
            this.lammoi.Name = "lammoi";
            this.lammoi.Size = new System.Drawing.Size(76, 43);
            this.lammoi.TabIndex = 14;
            this.lammoi.Text = "Làm  mới";
            this.lammoi.UseVisualStyleBackColor = true;
            this.lammoi.Click += new System.EventHandler(this.lammoi_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoGenerateColumns = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makhoa,
            this.tenkhoas});
            this.dgv.DataSource = this.khoaBindingSource;
            this.dgv.Location = new System.Drawing.Point(12, 184);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(654, 355);
            this.dgv.TabIndex = 5;
            this.dgv.Visible = false;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoa_CellContentClick);
            // 
            // makhoa
            // 
            this.makhoa.DataPropertyName = "makhoa";
            this.makhoa.HeaderText = "Mã Khoa";
            this.makhoa.Name = "makhoa";
            // 
            // tenkhoas
            // 
            this.tenkhoas.DataPropertyName = "tenkhoa";
            this.tenkhoas.HeaderText = "Tên Khoa";
            this.tenkhoas.Name = "tenkhoas";
            // 
            // btnshow
            // 
            this.btnshow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.Location = new System.Drawing.Point(696, 78);
            this.btnshow.Margin = new System.Windows.Forms.Padding(2);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(76, 39);
            this.btnshow.TabIndex = 15;
            this.btnshow.Text = "Hiển Thị";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // txterror
            // 
            this.txterror.AutoSize = true;
            this.txterror.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txterror.ForeColor = System.Drawing.Color.Red;
            this.txterror.Location = new System.Drawing.Point(121, 71);
            this.txterror.Name = "txterror";
            this.txterror.Size = new System.Drawing.Size(0, 15);
            this.txterror.TabIndex = 16;
            // 
            // frmKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 550);
            this.Controls.Add(this.txterror);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.lammoi);
            this.Controls.Add(this.tenkhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.thembt);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txttenkhoa);
            this.Controls.Add(this.txtmakhoa);
            this.Controls.Add(this.quanlykhoacuagiangvien);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmKhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Khoa";
            this.Load += new System.EventHandler(this.QLGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button quanlykhoacuagiangvien;
        private System.Windows.Forms.TextBox txtmakhoa;
        private System.Windows.Forms.TextBox txttenkhoa;
        private System.Windows.Forms.Button thembt;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tenkhoa;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private System.Windows.Forms.Button lammoi;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhoas;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Label txterror;
    }
}

