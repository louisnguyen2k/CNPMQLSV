namespace QuanLySV
{
    partial class ThongKeDiemRenLuyen
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbTKDRL = new System.Windows.Forms.Label();
            this.chartTKDRL = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartTKDRL)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTKDRL
            // 
            this.lbTKDRL.AutoSize = true;
            this.lbTKDRL.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTKDRL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTKDRL.Location = new System.Drawing.Point(230, 29);
            this.lbTKDRL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTKDRL.Name = "lbTKDRL";
            this.lbTKDRL.Size = new System.Drawing.Size(441, 45);
            this.lbTKDRL.TabIndex = 3;
            this.lbTKDRL.Text = "Thống kê điểm rèn luyện";
            // 
            // chartTKDRL
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTKDRL.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTKDRL.Legends.Add(legend1);
            this.chartTKDRL.Location = new System.Drawing.Point(58, 113);
            this.chartTKDRL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartTKDRL.Name = "chartTKDRL";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "SeriesTKDTL";
            this.chartTKDRL.Series.Add(series1);
            this.chartTKDRL.Size = new System.Drawing.Size(810, 514);
            this.chartTKDRL.TabIndex = 2;
            this.chartTKDRL.Text = "chart1";
            // 
            // ThongKeDiemRenLuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLySV.Properties.Resources.backgr_N;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(932, 692);
            this.Controls.Add(this.lbTKDRL);
            this.Controls.Add(this.chartTKDRL);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ThongKeDiemRenLuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê điểm rèn luyện";
            this.Load += new System.EventHandler(this.ThongKeDiemRenLuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTKDRL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTKDRL;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTKDRL;
    }
}