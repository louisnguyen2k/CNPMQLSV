namespace QuanLySV
{
    partial class SuaThongTinGD
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
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtp_ngaysinhcha = new System.Windows.Forms.DateTimePicker();
            this.tb_quoctichcha = new System.Windows.Forms.TextBox();
            this.tb_sdtcha = new System.Windows.Forms.TextBox();
            this.tb_nghenghiepcha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_tencha = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtp_ngaysinhme = new System.Windows.Forms.DateTimePicker();
            this.tb_quoctichme = new System.Windows.Forms.TextBox();
            this.tb_sdtme = new System.Windows.Forms.TextBox();
            this.tb_nghenghiepme = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_tenme = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(125, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin về cha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(147, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thông tin về mẹ";
            // 
            // bt_luu
            // 
            this.bt_luu.BackColor = System.Drawing.Color.White;
            this.bt_luu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_luu.ForeColor = System.Drawing.Color.LimeGreen;
            this.bt_luu.Image = global::QuanLySV.Properties.Resources.edit;
            this.bt_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_luu.Location = new System.Drawing.Point(282, 387);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(210, 60);
            this.bt_luu.TabIndex = 22;
            this.bt_luu.Text = "Lưu thông tin ";
            this.bt_luu.UseVisualStyleBackColor = false;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackColor = System.Drawing.Color.White;
            this.bt_thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.ForeColor = System.Drawing.Color.LimeGreen;
            this.bt_thoat.Image = global::QuanLySV.Properties.Resources.delete;
            this.bt_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_thoat.Location = new System.Drawing.Point(554, 387);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(210, 60);
            this.bt_thoat.TabIndex = 23;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(19, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 69);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(554, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 69);
            this.panel2.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::QuanLySV.Properties.Resources.anh_nen_sua;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dtp_ngaysinhcha);
            this.panel3.Controls.Add(this.tb_quoctichcha);
            this.panel3.Controls.Add(this.tb_sdtcha);
            this.panel3.Controls.Add(this.tb_nghenghiepcha);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tb_tencha);
            this.panel3.Location = new System.Drawing.Point(19, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(473, 281);
            this.panel3.TabIndex = 26;
            // 
            // dtp_ngaysinhcha
            // 
            this.dtp_ngaysinhcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngaysinhcha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaysinhcha.Location = new System.Drawing.Point(216, 64);
            this.dtp_ngaysinhcha.Name = "dtp_ngaysinhcha";
            this.dtp_ngaysinhcha.Size = new System.Drawing.Size(243, 30);
            this.dtp_ngaysinhcha.TabIndex = 21;
            // 
            // tb_quoctichcha
            // 
            this.tb_quoctichcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_quoctichcha.Location = new System.Drawing.Point(216, 217);
            this.tb_quoctichcha.Name = "tb_quoctichcha";
            this.tb_quoctichcha.Size = new System.Drawing.Size(243, 30);
            this.tb_quoctichcha.TabIndex = 20;
            // 
            // tb_sdtcha
            // 
            this.tb_sdtcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sdtcha.Location = new System.Drawing.Point(216, 160);
            this.tb_sdtcha.Name = "tb_sdtcha";
            this.tb_sdtcha.Size = new System.Drawing.Size(243, 30);
            this.tb_sdtcha.TabIndex = 19;
            // 
            // tb_nghenghiepcha
            // 
            this.tb_nghenghiepcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nghenghiepcha.Location = new System.Drawing.Point(216, 115);
            this.tb_nghenghiepcha.Name = "tb_nghenghiepcha";
            this.tb_nghenghiepcha.Size = new System.Drawing.Size(243, 30);
            this.tb_nghenghiepcha.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Quốc tịch:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Nghề nghiệp :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Số điện thoại :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ngày sinh :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Họ và tên:";
            // 
            // tb_tencha
            // 
            this.tb_tencha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tencha.Location = new System.Drawing.Point(216, 19);
            this.tb_tencha.Name = "tb_tencha";
            this.tb_tencha.Size = new System.Drawing.Size(243, 30);
            this.tb_tencha.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::QuanLySV.Properties.Resources.anh_nen_sua;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dtp_ngaysinhme);
            this.panel4.Controls.Add(this.tb_quoctichme);
            this.panel4.Controls.Add(this.tb_sdtme);
            this.panel4.Controls.Add(this.tb_nghenghiepme);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.tb_tenme);
            this.panel4.Location = new System.Drawing.Point(554, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(483, 281);
            this.panel4.TabIndex = 27;
            // 
            // dtp_ngaysinhme
            // 
            this.dtp_ngaysinhme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngaysinhme.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaysinhme.Location = new System.Drawing.Point(227, 64);
            this.dtp_ngaysinhme.Name = "dtp_ngaysinhme";
            this.dtp_ngaysinhme.Size = new System.Drawing.Size(243, 30);
            this.dtp_ngaysinhme.TabIndex = 31;
            // 
            // tb_quoctichme
            // 
            this.tb_quoctichme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_quoctichme.Location = new System.Drawing.Point(227, 217);
            this.tb_quoctichme.Name = "tb_quoctichme";
            this.tb_quoctichme.Size = new System.Drawing.Size(243, 30);
            this.tb_quoctichme.TabIndex = 30;
            // 
            // tb_sdtme
            // 
            this.tb_sdtme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sdtme.Location = new System.Drawing.Point(227, 160);
            this.tb_sdtme.Name = "tb_sdtme";
            this.tb_sdtme.Size = new System.Drawing.Size(243, 30);
            this.tb_sdtme.TabIndex = 29;
            // 
            // tb_nghenghiepme
            // 
            this.tb_nghenghiepme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nghenghiepme.Location = new System.Drawing.Point(227, 115);
            this.tb_nghenghiepme.Name = "tb_nghenghiepme";
            this.tb_nghenghiepme.Size = new System.Drawing.Size(243, 30);
            this.tb_nghenghiepme.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 27;
            this.label8.Text = "Quốc tịch:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "Nghề nghiệp :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "Số điện thoại :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "Ngày sinh:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "Họ và tên:";
            // 
            // tb_tenme
            // 
            this.tb_tenme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tenme.Location = new System.Drawing.Point(227, 19);
            this.tb_tenme.Name = "tb_tenme";
            this.tb_tenme.Size = new System.Drawing.Size(243, 30);
            this.tb_tenme.TabIndex = 22;
            // 
            // SuaThongTinGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLySV.Properties.Resources.anh_nen_sua;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1057, 459);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_luu);
            this.Name = "SuaThongTinGD";
            this.Text = "Sửa thông tin gia đình";
            this.Load += new System.EventHandler(this.SuaThongTinGD_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinhcha;
        private System.Windows.Forms.TextBox tb_quoctichcha;
        private System.Windows.Forms.TextBox tb_sdtcha;
        private System.Windows.Forms.TextBox tb_nghenghiepcha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_tencha;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinhme;
        private System.Windows.Forms.TextBox tb_quoctichme;
        private System.Windows.Forms.TextBox tb_sdtme;
        private System.Windows.Forms.TextBox tb_nghenghiepme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_tenme;
    }
}