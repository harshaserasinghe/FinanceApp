using System;

namespace Finance.UI.Views
{
    partial class TransactionView
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
            this.tabPgManage = new System.Windows.Forms.TabPage();
            this.cmbFrequency = new System.Windows.Forms.ComboBox();
            this.ReqFrequence = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chbIsRecurring = new System.Windows.Forms.CheckBox();
            this.txbDescription = new System.Windows.Forms.RichTextBox();
            this.txbTranManager = new System.Windows.Forms.TextBox();
            this.txbAmount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbContact = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTranDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTranTypeManage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTran = new System.Windows.Forms.DataGridView();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.cmbTranTypeSearch = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabPgReport = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabPgManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTran)).BeginInit();
            this.tabCtrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPgManage
            // 
            this.tabPgManage.Controls.Add(this.btnDelete);
            this.tabPgManage.Controls.Add(this.btnUpdate);
            this.tabPgManage.Controls.Add(this.btnCreate);
            this.tabPgManage.Controls.Add(this.btnRefresh);
            this.tabPgManage.Controls.Add(this.btnSearch);
            this.tabPgManage.Controls.Add(this.cmbFrequency);
            this.tabPgManage.Controls.Add(this.ReqFrequence);
            this.tabPgManage.Controls.Add(this.label5);
            this.tabPgManage.Controls.Add(this.chbIsRecurring);
            this.tabPgManage.Controls.Add(this.txbDescription);
            this.tabPgManage.Controls.Add(this.txbTranManager);
            this.tabPgManage.Controls.Add(this.txbAmount);
            this.tabPgManage.Controls.Add(this.label11);
            this.tabPgManage.Controls.Add(this.label10);
            this.tabPgManage.Controls.Add(this.label4);
            this.tabPgManage.Controls.Add(this.cmbContact);
            this.tabPgManage.Controls.Add(this.label3);
            this.tabPgManage.Controls.Add(this.dtpTranDate);
            this.tabPgManage.Controls.Add(this.label2);
            this.tabPgManage.Controls.Add(this.cmbTranTypeManage);
            this.tabPgManage.Controls.Add(this.label1);
            this.tabPgManage.Controls.Add(this.dgvTran);
            this.tabPgManage.Controls.Add(this.dtpToDate);
            this.tabPgManage.Controls.Add(this.label8);
            this.tabPgManage.Controls.Add(this.label7);
            this.tabPgManage.Controls.Add(this.dtpFromDate);
            this.tabPgManage.Controls.Add(this.cmbTranTypeSearch);
            this.tabPgManage.Controls.Add(this.label6);
            this.tabPgManage.Location = new System.Drawing.Point(4, 25);
            this.tabPgManage.Name = "tabPgManage";
            this.tabPgManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgManage.Size = new System.Drawing.Size(1500, 461);
            this.tabPgManage.TabIndex = 4;
            this.tabPgManage.Text = "Manage";
            this.tabPgManage.UseVisualStyleBackColor = true;
            // 
            // cmbFrequency
            // 
            this.cmbFrequency.FormattingEnabled = true;
            this.cmbFrequency.Location = new System.Drawing.Point(1242, 346);
            this.cmbFrequency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFrequency.Name = "cmbFrequency";
            this.cmbFrequency.Size = new System.Drawing.Size(239, 24);
            this.cmbFrequency.TabIndex = 35;
            // 
            // ReqFrequence
            // 
            this.ReqFrequence.AutoSize = true;
            this.ReqFrequence.Location = new System.Drawing.Point(1151, 346);
            this.ReqFrequence.Name = "ReqFrequence";
            this.ReqFrequence.Size = new System.Drawing.Size(82, 17);
            this.ReqFrequence.TabIndex = 34;
            this.ReqFrequence.Text = "Occurrence";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1151, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Recurring";
            // 
            // chbIsRecurring
            // 
            this.chbIsRecurring.AutoSize = true;
            this.chbIsRecurring.Location = new System.Drawing.Point(1239, 317);
            this.chbIsRecurring.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbIsRecurring.Name = "chbIsRecurring";
            this.chbIsRecurring.Size = new System.Drawing.Size(18, 17);
            this.chbIsRecurring.TabIndex = 32;
            this.chbIsRecurring.UseVisualStyleBackColor = true;
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(1242, 174);
            this.txbDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(239, 61);
            this.txbDescription.TabIndex = 31;
            this.txbDescription.Text = "";
            // 
            // txbTranManager
            // 
            this.txbTranManager.Location = new System.Drawing.Point(1241, 134);
            this.txbTranManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTranManager.Name = "txbTranManager";
            this.txbTranManager.Size = new System.Drawing.Size(240, 22);
            this.txbTranManager.TabIndex = 28;
            // 
            // txbAmount
            // 
            this.txbAmount.Location = new System.Drawing.Point(1241, 280);
            this.txbAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbAmount.Name = "txbAmount";
            this.txbAmount.Size = new System.Drawing.Size(240, 22);
            this.txbAmount.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1151, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 30;
            this.label11.Text = "Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1151, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1151, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Amount";
            // 
            // cmbContact
            // 
            this.cmbContact.FormattingEnabled = true;
            this.cmbContact.Location = new System.Drawing.Point(1242, 97);
            this.cmbContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbContact.Name = "cmbContact";
            this.cmbContact.Size = new System.Drawing.Size(239, 24);
            this.cmbContact.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1151, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Contact";
            // 
            // dtpTranDate
            // 
            this.dtpTranDate.Location = new System.Drawing.Point(1241, 246);
            this.dtpTranDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpTranDate.Name = "dtpTranDate";
            this.dtpTranDate.Size = new System.Drawing.Size(240, 22);
            this.dtpTranDate.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1151, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Date";
            // 
            // cmbTranTypeManage
            // 
            this.cmbTranTypeManage.FormattingEnabled = true;
            this.cmbTranTypeManage.Location = new System.Drawing.Point(1241, 59);
            this.cmbTranTypeManage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTranTypeManage.Name = "cmbTranTypeManage";
            this.cmbTranTypeManage.Size = new System.Drawing.Size(240, 24);
            this.cmbTranTypeManage.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1151, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Type";
            // 
            // dgvTran
            // 
            this.dgvTran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTran.Location = new System.Drawing.Point(13, 62);
            this.dgvTran.Name = "dgvTran";
            this.dgvTran.RowHeadersWidth = 51;
            this.dgvTran.RowTemplate.Height = 24;
            this.dgvTran.Size = new System.Drawing.Size(1110, 376);
            this.dgvTran.TabIndex = 17;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(691, 22);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(261, 22);
            this.dtpToDate.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(624, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "To Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(267, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "From Date";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(352, 22);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(261, 22);
            this.dtpFromDate.TabIndex = 14;
            // 
            // cmbTranTypeSearch
            // 
            this.cmbTranTypeSearch.FormattingEnabled = true;
            this.cmbTranTypeSearch.Location = new System.Drawing.Point(61, 17);
            this.cmbTranTypeSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTranTypeSearch.Name = "cmbTranTypeSearch";
            this.cmbTranTypeSearch.Size = new System.Drawing.Size(200, 24);
            this.cmbTranTypeSearch.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Type";
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tabPgManage);
            this.tabCtrl.Controls.Add(this.tabPgReport);
            this.tabCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrl.Location = new System.Drawing.Point(0, 0);
            this.tabCtrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(1508, 490);
            this.tabCtrl.TabIndex = 0;
            // 
            // tabPgReport
            // 
            this.tabPgReport.Location = new System.Drawing.Point(4, 25);
            this.tabPgReport.Name = "tabPgReport";
            this.tabPgReport.Size = new System.Drawing.Size(1475, 460);
            this.tabPgReport.TabIndex = 5;
            this.tabPgReport.Text = "Reports";
            this.tabPgReport.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(967, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnClickGetTran);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1048, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 37;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnClickClearTran);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1323, 386);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnClickUpdateTran);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(1241, 386);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 38;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnClickDeleteTran);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1406, 386);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnClickDeleteTran);
            // 
            // TransactionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 490);
            this.Controls.Add(this.tabCtrl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TransactionView";
            this.Text = "Transaction";
            this.tabPgManage.ResumeLayout(false);
            this.tabPgManage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTran)).EndInit();
            this.tabCtrl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void btnClickClearTran(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TabPage tabPgManage;
        private System.Windows.Forms.ComboBox cmbFrequency;
        private System.Windows.Forms.Label ReqFrequence;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbIsRecurring;
        private System.Windows.Forms.RichTextBox txbDescription;
        private System.Windows.Forms.TextBox txbTranManager;
        private System.Windows.Forms.TextBox txbAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbContact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTranDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTranTypeManage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTran;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.ComboBox cmbTranTypeSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tabPgReport;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
    }
}