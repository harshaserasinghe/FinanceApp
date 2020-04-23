namespace Finance.UI.Views
{
    partial class ReportView
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
            this.tranDetailChart = new LiveCharts.WinForms.CartesianChart();
            this.contExpChart = new LiveCharts.WinForms.PieChart();
            this.tranSumChart = new LiveCharts.WinForms.CartesianChart();
            this.SuspendLayout();
            // 
            // tranDetailChart
            // 
            this.tranDetailChart.Location = new System.Drawing.Point(78, 420);
            this.tranDetailChart.Name = "tranDetailChart";
            this.tranDetailChart.Size = new System.Drawing.Size(1273, 429);
            this.tranDetailChart.TabIndex = 5;
            this.tranDetailChart.Text = "cartesianChart1";
            // 
            // contExpChart
            // 
            this.contExpChart.Location = new System.Drawing.Point(658, 33);
            this.contExpChart.Name = "contExpChart";
            this.contExpChart.Size = new System.Drawing.Size(565, 360);
            this.contExpChart.TabIndex = 4;
            this.contExpChart.Text = "pieChart1";
            // 
            // tranSumChart
            // 
            this.tranSumChart.Location = new System.Drawing.Point(78, 23);
            this.tranSumChart.Name = "tranSumChart";
            this.tranSumChart.Size = new System.Drawing.Size(367, 370);
            this.tranSumChart.TabIndex = 3;
            this.tranSumChart.Text = "cartesianChart1";
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 792);
            this.Controls.Add(this.tranDetailChart);
            this.Controls.Add(this.contExpChart);
            this.Controls.Add(this.tranSumChart);
            this.Name = "ReportView";
            this.Text = "ReportView";
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart tranDetailChart;
        private LiveCharts.WinForms.PieChart contExpChart;
        private LiveCharts.WinForms.CartesianChart tranSumChart;
    }
}