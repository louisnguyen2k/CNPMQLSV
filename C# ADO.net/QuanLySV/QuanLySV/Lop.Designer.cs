namespace QuanLySV
{
    partial class Lop
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
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.lbNumRows = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbChuyenNganh = new System.Windows.Forms.ComboBox();
            this.cbbGiaoVien = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTenLop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaLop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::QuanLySV.Properties.Resources.anh_nen_sua;
            this.groupBox1.Controls.Add(this.dgvLop);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 379);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách các lớp";
            // 
            // dgvLop
            // 
            this.dgvLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLop.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Location = new System.Drawing.Point(6, 25);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.RowHeadersWidth = 62;
            this.dgvLop.RowTemplate.Height = 28;
            this.dgvLop.Size = new System.Drawing.Size(750, 348);
            this.dgvLop.TabIndex = 0;
            this.dgvLop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLop_CellContentClick);
            // 
            // lbNumRows
            // 
            this.lbNumRows.AutoSize = true;
            this.lbNumRows.BackColor = System.Drawing.Color.Transparent;
            this.lbNumRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumRows.ForeColor = System.Drawing.Color.Red;
            this.lbNumRows.Location = new System.Drawing.Point(209, 672);
            this.lbNumRows.Name = "lbNumRows";
            this.lbNumRows.Size = new System.Drawing.Size(63, 25);
            this.lbNumRows.TabIndex = 15;
            this.lbNumRows.Text = "None";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(19, 672);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tổng số kết quả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(356, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 41);
            this.label3.TabIndex = 16;
            this.label3.Text = "Thông tin các lớp";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::QuanLySV.Properties.Resources.anh_nen_sua;
            this.groupBox2.Controls.Add(this.cbbChuyenNganh);
            this.groupBox2.Controls.Add(this.cbbGiaoVien);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbTenLop);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbMaLop);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(940, 152);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // cbbChuyenNganh
            // 
            this.cbbChuyenNganh.FormattingEnabled = true;
            this.cbbChuyenNganh.Location = new System.Drawing.Point(630, 96);
            this.cbbChuyenNganh.Name = "cbbChuyenNganh";
            this.cbbChuyenNganh.Size = new System.Drawing.Size(261, 30);
            this.cbbChuyenNganh.TabIndex = 20;
            // 
            // cbbGiaoVien
            // 
            this.cbbGiaoVien.FormattingEnabled = true;
            this.cbbGiaoVien.Location = new System.Drawing.Point(630, 39);
            this.cbbGiaoVien.Name = "cbbGiaoVien";
            this.cbbGiaoVien.Size = new System.Drawing.Size(261, 30);
            this.cbbGiaoVien.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(423, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Chuyên ngành:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(423, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giáo viên phụ trách:";
            // 
            // tbTenLop
            // 
            this.tbTenLop.Location = new System.Drawing.Point(135, 96);
            this.tbTenLop.Name = "tbTenLop";
            this.tbTenLop.Size = new System.Drawing.Size(251, 28);
            this.tbTenLop.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên lớp:";
            // 
            // tbMaLop
            // 
            this.tbMaLop.Location = new System.Drawing.Point(135, 38);
            this.tbMaLop.Name = "tbMaLop";
            this.tbMaLop.Size = new System.Drawing.Size(251, 28);
            this.tbMaLop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã lớp:";
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackColor = System.Drawing.Color.White;
            this.btTimKiem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.Image = global::QuanLySV.Properties.Resources.tim_kiem;
            this.btTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimKiem.Location = new System.Drawing.Point(400, 240);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(138, 43);
            this.btTimKiem.TabIndex = 19;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = false;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Location = new System.Drawing.Point(566, 249);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(208, 26);
            this.tbTimKiem.TabIndex = 18;
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.White;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.LimeGreen;
            this.btThem.Image = global::QuanLySV.Properties.Resources.add;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(804, 344);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(149, 66);
            this.btThem.TabIndex = 22;
            this.btThem.Text = "Thêm mới";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.White;
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btSua.Image = global::QuanLySV.Properties.Resources.edit;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(804, 460);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(149, 66);
            this.btSua.TabIndex = 23;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.White;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.Red;
            this.btXoa.Image = global::QuanLySV.Properties.Resources.delete1;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(804, 577);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(149, 66);
            this.btXoa.TabIndex = 24;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // Lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLySV.Properties.Resources.anh_nen_sua;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(969, 710);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbNumRows);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "Lop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lớp";
            this.Load += new System.EventHandler(this.Lop_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.Label lbNumRows;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTenLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbChuyenNganh;
        private System.Windows.Forms.ComboBox cbbGiaoVien;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
    }
}