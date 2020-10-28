namespace QuanLySV
{
    partial class GiangVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvGiangVien = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbLienHeGiangVien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbChucVuGiangVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTenGiangVien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSDTGiangVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaGiangVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.lbNumRows = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::QuanLySV.Properties.Resources.anh_nen_sua;
            this.groupBox1.Controls.Add(this.dgvGiangVien);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(964, 318);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh giảng viên";
            // 
            // dgvGiangVien
            // 
            this.dgvGiangVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiangVien.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvGiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiangVien.Location = new System.Drawing.Point(6, 27);
            this.dgvGiangVien.Name = "dgvGiangVien";
            this.dgvGiangVien.RowHeadersWidth = 62;
            this.dgvGiangVien.RowTemplate.Height = 28;
            this.dgvGiangVien.Size = new System.Drawing.Size(952, 284);
            this.dgvGiangVien.TabIndex = 0;
            this.dgvGiangVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiangVien_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(339, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thông tin giảng viên";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::QuanLySV.Properties.Resources.anh_nen_sua;
            this.groupBox2.Controls.Add(this.tbLienHeGiangVien);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbChucVuGiangVien);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbTenGiangVien);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbSDTGiangVien);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbMaGiangVien);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(952, 188);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // tbLienHeGiangVien
            // 
            this.tbLienHeGiangVien.Location = new System.Drawing.Point(196, 145);
            this.tbLienHeGiangVien.Name = "tbLienHeGiangVien";
            this.tbLienHeGiangVien.Size = new System.Drawing.Size(734, 28);
            this.tbLienHeGiangVien.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Thông tin liên hệ:";
            // 
            // tbChucVuGiangVien
            // 
            this.tbChucVuGiangVien.Location = new System.Drawing.Point(626, 95);
            this.tbChucVuGiangVien.Name = "tbChucVuGiangVien";
            this.tbChucVuGiangVien.Size = new System.Drawing.Size(304, 28);
            this.tbChucVuGiangVien.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(451, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Chức vụ:";
            // 
            // tbTenGiangVien
            // 
            this.tbTenGiangVien.Location = new System.Drawing.Point(626, 39);
            this.tbTenGiangVien.Name = "tbTenGiangVien";
            this.tbTenGiangVien.Size = new System.Drawing.Size(304, 28);
            this.tbTenGiangVien.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(451, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tên giảng viên:";
            // 
            // tbSDTGiangVien
            // 
            this.tbSDTGiangVien.Location = new System.Drawing.Point(196, 95);
            this.tbSDTGiangVien.Name = "tbSDTGiangVien";
            this.tbSDTGiangVien.Size = new System.Drawing.Size(249, 28);
            this.tbSDTGiangVien.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "SĐT:";
            // 
            // tbMaGiangVien
            // 
            this.tbMaGiangVien.Location = new System.Drawing.Point(196, 39);
            this.tbMaGiangVien.Name = "tbMaGiangVien";
            this.tbMaGiangVien.Size = new System.Drawing.Size(249, 28);
            this.tbMaGiangVien.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã giảng viên:";
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Location = new System.Drawing.Point(753, 287);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(211, 26);
            this.tbTimKiem.TabIndex = 17;
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.White;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.LimeGreen;
            this.btThem.Image = global::QuanLySV.Properties.Resources.add;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(36, 273);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(130, 52);
            this.btThem.TabIndex = 19;
            this.btThem.Text = "   Thêm mới";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.White;
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btSua.Image = global::QuanLySV.Properties.Resources.edit;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(208, 273);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(130, 52);
            this.btSua.TabIndex = 20;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.White;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.Red;
            this.btXoa.Image = global::QuanLySV.Properties.Resources.delete1;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(385, 273);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(130, 52);
            this.btXoa.TabIndex = 21;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackColor = System.Drawing.Color.White;
            this.btTimKiem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.Image = global::QuanLySV.Properties.Resources.tim_kiem;
            this.btTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimKiem.Location = new System.Drawing.Point(611, 278);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(130, 43);
            this.btTimKiem.TabIndex = 22;
            this.btTimKiem.Text = "    Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = false;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // lbNumRows
            // 
            this.lbNumRows.AutoSize = true;
            this.lbNumRows.BackColor = System.Drawing.Color.Transparent;
            this.lbNumRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumRows.ForeColor = System.Drawing.Color.Red;
            this.lbNumRows.Location = new System.Drawing.Point(196, 652);
            this.lbNumRows.Name = "lbNumRows";
            this.lbNumRows.Size = new System.Drawing.Size(63, 25);
            this.lbNumRows.TabIndex = 24;
            this.lbNumRows.Text = "None";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(7, 652);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Tổng số kết quả:";
            // 
            // GiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLySV.Properties.Resources.anh_nen_sua;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(983, 699);
            this.Controls.Add(this.lbNumRows);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "GiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giảng viên";
            this.Load += new System.EventHandler(this.GiangVien_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvGiangVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbLienHeGiangVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbChucVuGiangVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTenGiangVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSDTGiangVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaGiangVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Label lbNumRows;
        private System.Windows.Forms.Label label7;
    }
}