namespace QuanLySV
{
    partial class BacDaoTao
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
            this.dgvBacDaoTao = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbThoiGianDaoTao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLoaiHinhDaoTao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTenBacDaoTao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaBacDaoTao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbContent = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbNumRows = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBacDaoTao)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBacDaoTao
            // 
            this.dgvBacDaoTao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBacDaoTao.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvBacDaoTao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBacDaoTao.Location = new System.Drawing.Point(6, 25);
            this.dgvBacDaoTao.Name = "dgvBacDaoTao";
            this.dgvBacDaoTao.RowHeadersWidth = 62;
            this.dgvBacDaoTao.RowTemplate.Height = 28;
            this.dgvBacDaoTao.Size = new System.Drawing.Size(859, 327);
            this.dgvBacDaoTao.TabIndex = 0;
            this.dgvBacDaoTao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBacDaoTao_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::QuanLySV.Properties.Resources.anh_nen_sua;
            this.groupBox1.Controls.Add(this.dgvBacDaoTao);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(871, 358);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách các bậc đào tạo";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::QuanLySV.Properties.Resources.anh_nen_sua;
            this.groupBox2.Controls.Add(this.tbThoiGianDaoTao);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbLoaiHinhDaoTao);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbTenBacDaoTao);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbMaBacDaoTao);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(28, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(859, 159);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // tbThoiGianDaoTao
            // 
            this.tbThoiGianDaoTao.Location = new System.Drawing.Point(619, 94);
            this.tbThoiGianDaoTao.Name = "tbThoiGianDaoTao";
            this.tbThoiGianDaoTao.Size = new System.Drawing.Size(219, 28);
            this.tbThoiGianDaoTao.TabIndex = 7;
            this.tbThoiGianDaoTao.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(459, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thời gian đào tạo:";
            // 
            // tbLoaiHinhDaoTao
            // 
            this.tbLoaiHinhDaoTao.Location = new System.Drawing.Point(619, 34);
            this.tbLoaiHinhDaoTao.Name = "tbLoaiHinhDaoTao";
            this.tbLoaiHinhDaoTao.Size = new System.Drawing.Size(219, 28);
            this.tbLoaiHinhDaoTao.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(459, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loại hình đào tạo:";
            // 
            // tbTenBacDaoTao
            // 
            this.tbTenBacDaoTao.Location = new System.Drawing.Point(190, 94);
            this.tbTenBacDaoTao.Name = "tbTenBacDaoTao";
            this.tbTenBacDaoTao.Size = new System.Drawing.Size(219, 28);
            this.tbTenBacDaoTao.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(27, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên bậc đào tạo:";
            // 
            // tbMaBacDaoTao
            // 
            this.tbMaBacDaoTao.Location = new System.Drawing.Point(190, 34);
            this.tbMaBacDaoTao.Name = "tbMaBacDaoTao";
            this.tbMaBacDaoTao.Size = new System.Drawing.Size(219, 28);
            this.tbMaBacDaoTao.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã bậc đào tạo:";
            // 
            // lbContent
            // 
            this.lbContent.AutoSize = true;
            this.lbContent.BackColor = System.Drawing.Color.Transparent;
            this.lbContent.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContent.ForeColor = System.Drawing.Color.Red;
            this.lbContent.Location = new System.Drawing.Point(299, 22);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(453, 45);
            this.lbContent.TabIndex = 3;
            this.lbContent.Text = "Thông tin các bậc đào tạo";
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.White;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.LimeGreen;
            this.btThem.Image = global::QuanLySV.Properties.Resources.add;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(934, 331);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(145, 59);
            this.btThem.TabIndex = 4;
            this.btThem.Text = "   Thêm mới";
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
            this.btSua.Location = new System.Drawing.Point(934, 447);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(145, 59);
            this.btSua.TabIndex = 5;
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
            this.btXoa.Location = new System.Drawing.Point(934, 566);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(145, 59);
            this.btXoa.TabIndex = 6;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimKiem.Location = new System.Drawing.Point(888, 94);
            this.tbTimKiem.Multiline = true;
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(211, 36);
            this.tbTimKiem.TabIndex = 8;
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackColor = System.Drawing.Color.White;
            this.btTimKiem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.Image = global::QuanLySV.Properties.Resources.tim_kiem;
            this.btTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimKiem.Location = new System.Drawing.Point(713, 87);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(143, 48);
            this.btTimKiem.TabIndex = 9;
            this.btTimKiem.Text = "   Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = false;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(23, 667);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tổng số kết quả:";
            // 
            // lbNumRows
            // 
            this.lbNumRows.AutoSize = true;
            this.lbNumRows.BackColor = System.Drawing.Color.Transparent;
            this.lbNumRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumRows.ForeColor = System.Drawing.Color.Red;
            this.lbNumRows.Location = new System.Drawing.Point(213, 667);
            this.lbNumRows.Name = "lbNumRows";
            this.lbNumRows.Size = new System.Drawing.Size(63, 25);
            this.lbNumRows.TabIndex = 11;
            this.lbNumRows.Text = "None";
            // 
            // BacDaoTao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLySV.Properties.Resources.anh_nen_sua;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1102, 708);
            this.Controls.Add(this.lbNumRows);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BacDaoTao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bậc đào tạo";
            this.Load += new System.EventHandler(this.BacDaoTao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBacDaoTao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBacDaoTao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbThoiGianDaoTao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLoaiHinhDaoTao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTenBacDaoTao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaBacDaoTao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbNumRows;
    }
}