namespace QLGiangVienWithEntity.clientUser
{
    partial class HandleFeedBack
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
            this.txtdesp = new System.Windows.Forms.TextBox();
            this.btnsent = new System.Windows.Forms.Button();
            this.author = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txterror = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtdesp
            // 
            this.txtdesp.Location = new System.Drawing.Point(21, 121);
            this.txtdesp.Multiline = true;
            this.txtdesp.Name = "txtdesp";
            this.txtdesp.Size = new System.Drawing.Size(352, 246);
            this.txtdesp.TabIndex = 1;
            // 
            // btnsent
            // 
            this.btnsent.Location = new System.Drawing.Point(21, 373);
            this.btnsent.Name = "btnsent";
            this.btnsent.Size = new System.Drawing.Size(134, 54);
            this.btnsent.TabIndex = 2;
            this.btnsent.Text = "GỬI";
            this.btnsent.UseVisualStyleBackColor = true;
            this.btnsent.Click += new System.EventHandler(this.btnsent_Click);
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author.Location = new System.Drawing.Point(122, 9);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(57, 20);
            this.author.TabIndex = 3;
            this.author.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Người dùng :";
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(239, 373);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(134, 54);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "Hủy";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ghi chú";
            // 
            // txterror
            // 
            this.txterror.AutoSize = true;
            this.txterror.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txterror.Location = new System.Drawing.Point(297, 13);
            this.txterror.Name = "txterror";
            this.txterror.Size = new System.Drawing.Size(76, 16);
            this.txterror.TabIndex = 7;
            this.txterror.Text = "đã báo cáo";
            this.txterror.Visible = false;
            // 
            // HandleFeedBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 450);
            this.Controls.Add(this.txterror);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.author);
            this.Controls.Add(this.btnsent);
            this.Controls.Add(this.txtdesp);
            this.Name = "HandleFeedBack";
            this.Text = "clFeedback";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtdesp;
        private System.Windows.Forms.Button btnsent;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txterror;
    }
}