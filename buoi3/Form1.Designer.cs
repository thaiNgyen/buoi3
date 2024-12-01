namespace buoi3
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
            this.txtTen = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonform2 = new System.Windows.Forms.Button();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxDuLich = new System.Windows.Forms.CheckBox();
            this.checkBoxPhimAnh = new System.Windows.Forms.CheckBox();
            this.checkBoxTheThao = new System.Windows.Forms.CheckBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButtonNam = new System.Windows.Forms.RadioButton();
            this.btnXuatThongTin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(151, 84);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(289, 26);
            this.txtTen.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonform2);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBoxDuLich);
            this.groupBox1.Controls.Add(this.checkBoxPhimAnh);
            this.groupBox1.Controls.Add(this.checkBoxTheThao);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButtonNam);
            this.groupBox1.Controls.Add(this.btnXuatThongTin);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Location = new System.Drawing.Point(185, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(989, 352);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonform2
            // 
            this.buttonform2.Location = new System.Drawing.Point(295, 252);
            this.buttonform2.Name = "buttonform2";
            this.buttonform2.Size = new System.Drawing.Size(189, 46);
            this.buttonform2.TabIndex = 7;
            this.buttonform2.Text = "Gửi dữ liệu sang form 2";
            this.buttonform2.UseVisualStyleBackColor = true;
            this.buttonform2.Click += new System.EventHandler(this.buttonform2_Click_1);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(615, 87);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(289, 26);
            this.dtpNgaySinh.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sở Thích";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Họ Tên";
            // 
            // checkBoxDuLich
            // 
            this.checkBoxDuLich.AutoSize = true;
            this.checkBoxDuLich.Location = new System.Drawing.Point(866, 165);
            this.checkBoxDuLich.Name = "checkBoxDuLich";
            this.checkBoxDuLich.Size = new System.Drawing.Size(89, 24);
            this.checkBoxDuLich.TabIndex = 4;
            this.checkBoxDuLich.Text = "Du Lịch";
            this.checkBoxDuLich.UseVisualStyleBackColor = true;
            // 
            // checkBoxPhimAnh
            // 
            this.checkBoxPhimAnh.AutoSize = true;
            this.checkBoxPhimAnh.Location = new System.Drawing.Point(743, 165);
            this.checkBoxPhimAnh.Name = "checkBoxPhimAnh";
            this.checkBoxPhimAnh.Size = new System.Drawing.Size(103, 24);
            this.checkBoxPhimAnh.TabIndex = 4;
            this.checkBoxPhimAnh.Text = "Phim Ảnh";
            this.checkBoxPhimAnh.UseVisualStyleBackColor = true;
            // 
            // checkBoxTheThao
            // 
            this.checkBoxTheThao.AutoSize = true;
            this.checkBoxTheThao.Location = new System.Drawing.Point(615, 166);
            this.checkBoxTheThao.Name = "checkBoxTheThao";
            this.checkBoxTheThao.Size = new System.Drawing.Size(102, 24);
            this.checkBoxTheThao.TabIndex = 4;
            this.checkBoxTheThao.Text = "Thể Thao";
            this.checkBoxTheThao.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(306, 165);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(54, 24);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nữ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButtonNam
            // 
            this.radioButtonNam.AutoSize = true;
            this.radioButtonNam.Location = new System.Drawing.Point(182, 165);
            this.radioButtonNam.Name = "radioButtonNam";
            this.radioButtonNam.Size = new System.Drawing.Size(67, 24);
            this.radioButtonNam.TabIndex = 2;
            this.radioButtonNam.TabStop = true;
            this.radioButtonNam.Text = "Nam";
            this.radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // btnXuatThongTin
            // 
            this.btnXuatThongTin.Location = new System.Drawing.Point(709, 252);
            this.btnXuatThongTin.Name = "btnXuatThongTin";
            this.btnXuatThongTin.Size = new System.Drawing.Size(151, 34);
            this.btnXuatThongTin.TabIndex = 1;
            this.btnXuatThongTin.Text = "Xuất Thông Tin";
            this.btnXuatThongTin.UseVisualStyleBackColor = true;
            this.btnXuatThongTin.Click += new System.EventHandler(this.btnXuatThongTin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 569);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxTheThao;
        private System.Windows.Forms.RadioButton radioButtonNam;
        private System.Windows.Forms.Button btnXuatThongTin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxDuLich;
        private System.Windows.Forms.CheckBox checkBoxPhimAnh;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Button buttonform2;
    }
}

