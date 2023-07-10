namespace QLGiangVienWithEntity
{
    partial class frmMonDay
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.monday = new System.Windows.Forms.Label();
            this.trinhdo = new System.Windows.Forms.Label();
            this.txttenmon = new System.Windows.Forms.TextBox();
            this.txttrinhdo = new System.Windows.Forms.TextBox();
            this.dgvMonDay = new System.Windows.Forms.DataGridView();
            this.mamon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tengv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bangcap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmamon = new System.Windows.Forms.TextBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.txtmagv = new System.Windows.Forms.ComboBox();
            this.txterror = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonDay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(147, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ MÔN DẠY CỦA GIẢNG VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(11, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã giáo viên:";
            // 
            // monday
            // 
            this.monday.AutoSize = true;
            this.monday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.monday.Location = new System.Drawing.Point(11, 167);
            this.monday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.monday.Name = "monday";
            this.monday.Size = new System.Drawing.Size(64, 17);
            this.monday.TabIndex = 3;
            this.monday.Text = "Tên Môn";
            // 
            // trinhdo
            // 
            this.trinhdo.AutoSize = true;
            this.trinhdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.trinhdo.Location = new System.Drawing.Point(11, 215);
            this.trinhdo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.trinhdo.Name = "trinhdo";
            this.trinhdo.Size = new System.Drawing.Size(65, 17);
            this.trinhdo.TabIndex = 4;
            this.trinhdo.Text = "Trình độ:";
            // 
            // txttenmon
            // 
            this.txttenmon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txttenmon.Location = new System.Drawing.Point(112, 166);
            this.txttenmon.Margin = new System.Windows.Forms.Padding(2);
            this.txttenmon.Name = "txttenmon";
            this.txttenmon.Size = new System.Drawing.Size(395, 20);
            this.txttenmon.TabIndex = 17;
            // 
            // txttrinhdo
            // 
            this.txttrinhdo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txttrinhdo.Location = new System.Drawing.Point(112, 214);
            this.txttrinhdo.Margin = new System.Windows.Forms.Padding(2);
            this.txttrinhdo.Name = "txttrinhdo";
            this.txttrinhdo.Size = new System.Drawing.Size(395, 20);
            this.txttrinhdo.TabIndex = 18;
            // 
            // dgvMonDay
            // 
            this.dgvMonDay.AllowUserToAddRows = false;
            this.dgvMonDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMonDay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonDay.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMonDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMonDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonDay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mamon,
            this.magv,
            this.tengv,
            this.tenmon,
            this.bangcap});
            this.dgvMonDay.Location = new System.Drawing.Point(14, 285);
            this.dgvMonDay.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMonDay.Name = "dgvMonDay";
            this.dgvMonDay.RowHeadersVisible = false;
            this.dgvMonDay.RowHeadersWidth = 51;
            this.dgvMonDay.RowTemplate.Height = 24;
            this.dgvMonDay.Size = new System.Drawing.Size(706, 222);
            this.dgvMonDay.TabIndex = 9;
            this.dgvMonDay.Visible = false;
            this.dgvMonDay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonday_CellContentClick);
            // 
            // mamon
            // 
            this.mamon.DataPropertyName = "mamon";
            this.mamon.HeaderText = "Mã Môn";
            this.mamon.Name = "mamon";
            // 
            // magv
            // 
            this.magv.DataPropertyName = "magv";
            this.magv.HeaderText = "Mã Giáo Viên";
            this.magv.Name = "magv";
            // 
            // tengv
            // 
            this.tengv.DataPropertyName = "tengv";
            this.tengv.HeaderText = "Tên Giáo Viên";
            this.tengv.Name = "tengv";
            // 
            // tenmon
            // 
            this.tenmon.DataPropertyName = "tenmon";
            this.tenmon.HeaderText = "Tên Môn";
            this.tenmon.Name = "tenmon";
            // 
            // bangcap
            // 
            this.bangcap.DataPropertyName = "trinhdo";
            this.bangcap.HeaderText = "Trình độ";
            this.bangcap.Name = "bangcap";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(614, 100);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(78, 34);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Location = new System.Drawing.Point(614, 138);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(78, 34);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(614, 188);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(78, 34);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLamMoi.Location = new System.Drawing.Point(614, 236);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(78, 34);
            this.btnLamMoi.TabIndex = 13;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(11, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mã môn học:";
            // 
            // txtmamon
            // 
            this.txtmamon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmamon.Location = new System.Drawing.Point(112, 79);
            this.txtmamon.Margin = new System.Windows.Forms.Padding(2);
            this.txtmamon.Name = "txtmamon";
            this.txtmamon.Size = new System.Drawing.Size(395, 20);
            this.txtmamon.TabIndex = 16;
            // 
            // btnshow
            // 
            this.btnshow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnshow.Location = new System.Drawing.Point(614, 57);
            this.btnshow.Margin = new System.Windows.Forms.Padding(2);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(78, 34);
            this.btnshow.TabIndex = 17;
            this.btnshow.Text = "Hiển Thị";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // txtmagv
            // 
            this.txtmagv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmagv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtmagv.FormattingEnabled = true;
            this.txtmagv.Location = new System.Drawing.Point(112, 125);
            this.txtmagv.Name = "txtmagv";
            this.txtmagv.Size = new System.Drawing.Size(395, 21);
            this.txtmagv.TabIndex = 18;
            // 
            // txterror
            // 
            this.txterror.AutoSize = true;
            this.txterror.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txterror.ForeColor = System.Drawing.Color.Red;
            this.txterror.Location = new System.Drawing.Point(30, 34);
            this.txterror.Name = "txterror";
            this.txterror.Size = new System.Drawing.Size(0, 15);
            this.txterror.TabIndex = 19;
            // 
            // frmMonDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 518);
            this.Controls.Add(this.txterror);
            this.Controls.Add(this.txtmagv);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.txtmamon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvMonDay);
            this.Controls.Add(this.txttrinhdo);
            this.Controls.Add(this.txttenmon);
            this.Controls.Add(this.trinhdo);
            this.Controls.Add(this.monday);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMonDay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Môn dạy";
            this.Load += new System.EventHandler(this.frmMonDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label monday;
        private System.Windows.Forms.Label trinhdo;
        private System.Windows.Forms.TextBox txttenmon;
        private System.Windows.Forms.TextBox txttrinhdo;
        private System.Windows.Forms.DataGridView dgvMonDay;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monphutrachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trinhdoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamonhocDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmamon;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.ComboBox txtmagv;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamon;
        private System.Windows.Forms.DataGridViewTextBoxColumn magv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tengv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn bangcap;
        private System.Windows.Forms.Label txterror;
    }
}

