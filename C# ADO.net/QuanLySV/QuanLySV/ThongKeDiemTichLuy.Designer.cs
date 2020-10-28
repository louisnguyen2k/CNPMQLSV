namespace QuanLySV
{
    partial class ThongKeDiemTichLuy
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
            this.chartTKDTL = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartTKDTL)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTKDTL
            // 
            this.chartTKDTL.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea1.Name = "ChartArea1";
            this.chartTKDTL.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTKDTL.Legends.Add(legend1);
            this.chartTKDTL.Location = new System.Drawing.Point(58, 97);
            this.chartTKDTL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartTKDTL.Name = "chartTKDTL";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "SeriesTKDTL";
            this.chartTKDTL.Series.Add(series1);
            this.chartTKDTL.Size = new System.Drawing.Size(812, 513);
            this.chartTKDTL.TabIndex = 0;
            this.chartTKDTL.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(300, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống kê điểm tích lũy";
            // 
            // ThongKeDiemTichLuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLySV.Properties.Resources.backgr_N;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(932, 692);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartTKDTL);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ThongKeDiemTichLuy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê điểm tích lũy";
            this.Load += new System.EventHandler(this.ThongKeDiemTichLuy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTKDTL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTKDTL;
        private System.Windows.Forms.Label label1;
    }
}