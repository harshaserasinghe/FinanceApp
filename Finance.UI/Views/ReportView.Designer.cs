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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // trndChtTranByDate
            // 
            this.trndChtTranByDate.Location = new System.Drawing.Point(27, 419);
            this.trndChtTranByDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trndChtTranByDate.Name = "trndChtTranByDate";
            this.trndChtTranByDate.Size = new System.Drawing.Size(1252, 358);
            this.trndChtTranByDate.TabIndex = 5;
            this.trndChtTranByDate.Text = "cartesianChart1";
            // 
            // pieChtContExpBrkDwn
            // 
            this.pieChtContExpBrkDwn.Location = new System.Drawing.Point(673, 70);
            this.pieChtContExpBrkDwn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pieChtContExpBrkDwn.Name = "pieChtContExpBrkDwn";
            this.pieChtContExpBrkDwn.Size = new System.Drawing.Size(469, 336);
            this.pieChtContExpBrkDwn.TabIndex = 4;
            this.pieChtContExpBrkDwn.Text = "pieChart1";
            // 
            // colChtTraSum
            // 
            this.colChtTraSum.Location = new System.Drawing.Point(210, 70);
            this.colChtTraSum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.colChtTraSum.Name = "colChtTraSum";
            this.colChtTraSum.Size = new System.Drawing.Size(258, 335);
            this.colChtTraSum.TabIndex = 3;
            this.colChtTraSum.Text = "cartesianChart1";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(769, 19);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(56, 19);
            this.btnGenerate.TabIndex = 97;
            this.btnGenerate.Text = "Show";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenRptsClick);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(562, 19);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(197, 20);
            this.dtpToDate.TabIndex = 96;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(512, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 94;
            this.label8.Text = "To Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 93;
            this.label7.Text = "From Date";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(308, 19);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(197, 20);
            this.dtpFromDate.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 98;
            this.label1.Text = "My Reports";
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 786);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.trndChtTranByDate);
            this.Controls.Add(this.pieChtContExpBrkDwn);
            this.Controls.Add(this.colChtTraSum);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReportView";
            this.Text = "ReportView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Label label1;
    }
}