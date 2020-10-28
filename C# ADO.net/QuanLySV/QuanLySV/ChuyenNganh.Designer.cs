namespace QuanLySV
{
    partial class ChuyenNganh
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbTenChuyenNganh = new System.Windows.Forms.TextBox();
            this.tbMaChuyenNganh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvChuyenNganh = new System.Windows.Forms.DataGridView();
            this.btSua = new System.Windows.Forms.Button();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.lbNumRows = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenNganh)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(146, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(425, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thông tin chuyên ngành";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::QuanLySV.Properties.Resources.anh_nen_sua;
            this.groupBox2.Controls.Add(this.tbTenChuyenNganh);
            this.groupBox2.Controls.Add(this.tbMaChuyenNganh);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbbKhoa);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(29, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 204);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // tbTenChuyenNganh
            // 
            this.tbTenChuyenNganh.Location = new System.Drawing.Point(223, 97);
            this.tbTenChuyenNganh.Name = "tbTenChuyenNganh";
            this.tbTenChuyenNganh.Size = new System.Drawing.Size(235, 28);
            this.tbTenChuyenNganh.TabIndex = 14;
            // 
            // tbMaChuyenNganh
            // 
            this.tbMaChuyenNganh.Location = new System.Drawing.Point(223, 39);
            this.tbMaChuyenNganh.Name = "tbMaChuyenNganh";
            this.tbMaChuyenNganh.Size = new System.Drawing.Size(235, 28);
            this.tbMaChuyenNganh.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Khoa:";
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(223, 148);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(235, 30);
            this.cbbKhoa.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên chuyên ngành:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã chuyên ngành:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::QuanLySV.Properties.Resources.anh_nen_sua;
            this.groupBox1.Controls.Add(this.dgvChuyenNganh);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 306);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh chuyên ngành";
            // 
            // dgvChuyenNganh
            // 
            this.dgvChuyenNganh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChuyenNganh.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvChuyenNganh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuyenNganh.Location = new System.Drawing.Point(6, 25);
            this.dgvChuyenNganh.Name = "dgvChuyenNganh";
            this.dgvChuyenNganh.RowHeadersWidth = 62;
            this.dgvChuyenNganh.RowTemplate.Height = 28;
            this.dgvChuyenNganh.Size = new System.Drawing.Size(614, 274);
            this.dgvChuyenNganh.TabIndex = 0;
            this.dgvChuyenNganh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChuyenNganh_CellContentClick);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.White;
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btSua.Image = global::QuanLySV.Properties.Resources.edit;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(530, 173);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(138, 52);
            this.btSua.TabIndex = 13;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Location = new System.Drawing.Point(470, 307);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(185, 26);
            this.tbTimKiem.TabIndex = 15;
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackColor = System.Drawing.Color.White;
            this.btTimKiem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.Image = global::QuanLySV.Properties.Resources.tim_kiem;
            this.btTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimKiem.Location = new System.Drawing.Point(307, 297);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(136, 43);
            this.btTimKiem.TabIndex = 16;
            this.btTimKiem.Text = "   Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = false;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.White;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.Red;
            this.btXoa.Image = global::QuanLySV.Properties.Resources.delete;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(530, 241);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(138, 52);
            this.btXoa.TabIndex = 17;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.White;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.LimeGreen;
            this.btThem.Image = global::QuanLySV.Properties.Resources.add;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(530, 102);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(138, 52);
            this.btThem.TabIndex = 18;
            this.btThem.Text = "   Thêm mới";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // lbNumRows
            // 
            this.lbNumRows.AutoSize = true;
            this.lbNumRows.BackColor = System.Drawing.Color.Transparent;
            this.lbNumRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumRows.ForeColor = System.Drawing.Color.Red;
            this.lbNumRows.Location = new System.Drawing.Point(220, 659);
            this.lbNumRows.Name = "lbNumRows";
            this.lbNumRows.Size = new System.Drawing.Size(63, 25);
            this.lbNumRows.TabIndex = 20;
            this.lbNumRows.Text = "None";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(30, 659);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tổng số kết quả:";
            // 
            // ChuyenNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLySV.Properties.Resources.anh_nen_sua;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(680, 702);
            this.Controls.Add(this.lbNumRows);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "ChuyenNganh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyên ngành";
            this.Load += new System.EventHandler(this.ChuyenNganh_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenNganh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvChuyenNganh;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.TextBox tbTenChuyenNganh;
        private System.Windows.Forms.TextBox tbMaChuyenNganh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label lbNumRows;
        private System.Windows.Forms.Label label5;
    }
}