namespace QuanLySV
{
    partial class DanhSachSV
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
            this.lbNumRows = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSSinhVien = new System.Windows.Forms.DataGridView();
            this.btChiTiet = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNumRows
            // 
            this.lbNumRows.AutoSize = true;
            this.lbNumRows.BackColor = System.Drawing.Color.Transparent;
            this.lbNumRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumRows.ForeColor = System.Drawing.Color.Red;
            this.lbNumRows.Location = new System.Drawing.Point(238, 655);
            this.lbNumRows.Name = "lbNumRows";
            this.lbNumRows.Size = new System.Drawing.Size(63, 25);
            this.lbNumRows.TabIndex = 35;
            this.lbNumRows.Text = "None";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(28, 655);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "Tổng số sinh viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(450, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 46);
            this.label3.TabIndex = 33;
            this.label3.Text = "Danh sách sinh viên";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::QuanLySV.Properties.Resources.anh_nen_sua;
            this.groupBox1.Controls.Add(this.dgvDSSinhVien);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1185, 446);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sinh viên";
            // 
            // dgvDSSinhVien
            // 
            this.dgvDSSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSSinhVien.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDSSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSinhVien.Location = new System.Drawing.Point(6, 25);
            this.dgvDSSinhVien.Name = "dgvDSSinhVien";
            this.dgvDSSinhVien.RowHeadersWidth = 62;
            this.dgvDSSinhVien.RowTemplate.Height = 28;
            this.dgvDSSinhVien.Size = new System.Drawing.Size(1173, 415);
            this.dgvDSSinhVien.TabIndex = 0;
            this.dgvDSSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSinhVien_CellClick);
            // 
            // btChiTiet
            // 
            this.btChiTiet.BackColor = System.Drawing.Color.White;
            this.btChiTiet.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChiTiet.ForeColor = System.Drawing.Color.Red;
            this.btChiTiet.Image = global::QuanLySV.Properties.Resources.Status_32x32;
            this.btChiTiet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btChiTiet.Location = new System.Drawing.Point(1057, 121);
            this.btChiTiet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btChiTiet.Name = "btChiTiet";
            this.btChiTiet.Size = new System.Drawing.Size(156, 65);
            this.btChiTiet.TabIndex = 36;
            this.btChiTiet.Text = "       Chi tiết";
            this.btChiTiet.UseVisualStyleBackColor = false;
            this.btChiTiet.Click += new System.EventHandler(this.btChiTiet_Click);
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackColor = System.Drawing.Color.White;
            this.btTimKiem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.Image = global::QuanLySV.Properties.Resources.tim_kiem;
            this.btTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimKiem.Location = new System.Drawing.Point(34, 134);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(146, 43);
            this.btTimKiem.TabIndex = 38;
            this.btTimKiem.Text = "     Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = false;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Location = new System.Drawing.Point(193, 134);
            this.tbTimKiem.Multiline = true;
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(310, 41);
            this.tbTimKiem.TabIndex = 37;
            // 
            // DanhSachSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLySV.Properties.Resources.anh_nen_sua;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1236, 692);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.btChiTiet);
            this.Controls.Add(this.lbNumRows);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "DanhSachSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách sinh viên";
            this.Load += new System.EventHandler(this.DanhSachSV_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumRows;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSSinhVien;
        private System.Windows.Forms.Button btChiTiet;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.TextBox tbTimKiem;
    }
}