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
            this.trndChtTranByDate = new LiveCharts.WinForms.CartesianChart();
            this.pieChtContExpBrkDwn = new LiveCharts.WinForms.PieChart();
            this.colChtTraSum = new LiveCharts.WinForms.CartesianChart();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // trndChtTranByDate
            // 
            this.trndChtTranByDate.Location = new System.Drawing.Point(116, 498);
            this.trndChtTranByDate.Name = "trndChtTranByDate";
            this.trndChtTranByDate.Size = new System.Drawing.Size(1273, 458);
            this.trndChtTranByDate.TabIndex = 5;
            this.trndChtTranByDate.Text = "cartesianChart1";
            // 
            // pieChtContExpBrkDwn
            // 
            this.pieChtContExpBrkDwn.Location = new System.Drawing.Point(732, 96);
            this.pieChtContExpBrkDwn.Name = "pieChtContExpBrkDwn";
            this.pieChtContExpBrkDwn.Size = new System.Drawing.Size(625, 414);
            this.pieChtContExpBrkDwn.TabIndex = 4;
            this.pieChtContExpBrkDwn.Text = "pieChart1";
            // 
            // colChtTraSum
            // 
            this.colChtTraSum.Location = new System.Drawing.Point(171, 62);
            this.colChtTraSum.Name = "colChtTraSum";
            this.colChtTraSum.Size = new System.Drawing.Size(344, 412);
            this.colChtTraSum.TabIndex = 3;
            this.colChtTraSum.Text = "cartesianChart1";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(1025, 23);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 97;
            this.btnGenerate.Text = "Show";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenRptsClick);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(749, 23);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(261, 22);
            this.dtpToDate.TabIndex = 96;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(682, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 94;
            this.label8.Text = "To Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 93;
            this.label7.Text = "From Date";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(410, 23);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(261, 22);
            this.dtpFromDate.TabIndex = 95;
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 968);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.trndChtTranByDate);
            this.Controls.Add(this.pieChtContExpBrkDwn);
            this.Controls.Add(this.colChtTraSum);
            this.Name = "ReportView";
            this.Text = "ReportView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart trndChtTranByDate;
        private LiveCharts.WinForms.PieChart pieChtContExpBrkDwn;
        private LiveCharts.WinForms.CartesianChart colChtTraSum;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
    }
}