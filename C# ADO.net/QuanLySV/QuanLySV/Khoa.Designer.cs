namespace QuanLySV
{
    partial class Khoa
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
            this.dgvKhoa = new System.Windows.Forms.DataGridView();
            this.tbMaKhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbTenKhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.lbNumRows = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::QuanLySV.Properties.Resources.anh_nen_sua;
            this.groupBox1.Controls.Add(this.dgvKhoa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 246);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khoa";
            // 
            // dgvKhoa
            // 
            this.dgvKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhoa.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoa.Location = new System.Drawing.Point(6, 25);
            this.dgvKhoa.Name = "dgvKhoa";
            this.dgvKhoa.RowHeadersWidth = 62;
            this.dgvKhoa.RowTemplate.Height = 28;
            this.dgvKhoa.Size = new System.Drawing.Size(460, 215);
            this.dgvKhoa.TabIndex = 0;
            this.dgvKhoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoa_CellContentClick);
            // 
            // tbMaKhoa
            // 
            this.tbMaKhoa.Location = new System.Drawing.Point(135, 39);
            this.tbMaKhoa.Name = "tbMaKhoa";
            this.tbMaKhoa.Size = new System.Drawing.Size(317, 28);
            this.tbMaKhoa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã khoa:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::QuanLySV.Properties.Resources.anh_nen_sua;
            this.groupBox2.Controls.Add(this.tbTenKhoa);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbMaKhoa);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(495, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 152);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // tbTenKhoa
            // 
            this.tbTenKhoa.Location = new System.Drawing.Point(135, 95);
            this.tbTenKhoa.Name = "tbTenKhoa";
            this.tbTenKhoa.Size = new System.Drawing.Size(317, 28);
            this.tbTenKhoa.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên khoa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(399, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 51);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thông tin khoa";
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackColor = System.Drawing.Color.White;
            this.btTimKiem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.Image = global::QuanLySV.Properties.Resources.tim_kiem;
            this.btTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimKiem.Location = new System.Drawing.Point(12, 87);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(140, 44);
            this.btTimKiem.TabIndex = 8;
            this.btTimKiem.Text = "   Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = false;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimKiem.Location = new System.Drawing.Point(175, 95);
            this.tbTimKiem.Multiline = true;
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(283, 34);
            this.tbTimKiem.TabIndex = 9;
            // 
            // lbNumRows
            // 
            this.lbNumRows.AutoSize = true;
            this.lbNumRows.BackColor = System.Drawing.Color.Transparent;
            this.lbNumRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumRows.ForeColor = System.Drawing.Color.Red;
            this.lbNumRows.Location = new System.Drawing.Point(197, 405);
            this.lbNumRows.Name = "lbNumRows";
            this.lbNumRows.Size = new System.Drawing.Size(63, 25);
            this.lbNumRows.TabIndex = 13;
            this.lbNumRows.Text = "None";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tổng số kết quả:";
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.White;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.LimeGreen;
            this.btThem.Image = global::QuanLySV.Properties.Resources.add;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(495, 336);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(143, 60);
            this.btThem.TabIndex = 5;
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
            this.btSua.Location = new System.Drawing.Point(676, 336);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(143, 60);
            this.btSua.TabIndex = 6;
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
            this.btXoa.Location = new System.Drawing.Point(848, 336);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(143, 60);
            this.btXoa.TabIndex = 7;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // Khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLySV.Properties.Resources.anh_nen_sua;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1021, 452);
            this.Controls.Add(this.lbNumRows);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Khoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khoa";
            this.Load += new System.EventHandler(this.Khoa_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKhoa;
        private System.Windows.Forms.TextBox tbMaKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbTenKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Label lbNumRows;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
    }
}