namespace Finance.UI
{
    partial class FinanceForm
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
            this.TabContFinance = new System.Windows.Forms.TabControl();
            this.TabPageTran = new System.Windows.Forms.TabPage();
            this.TabContTran = new System.Windows.Forms.TabControl();
            this.TabPageTranAdd = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txbTranName = new System.Windows.Forms.TextBox();
            this.btnTranAdd = new System.Windows.Forms.Button();
            this.cmbRecTranFreq = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbTranDesc = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chbRecTran = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbTranAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbContact = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTranDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTranType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TabPageTranUpdate = new System.Windows.Forms.TabPage();
            this.cmbTranTypeSearch = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTranSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpTranToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTranFromDate = new System.Windows.Forms.DateTimePicker();
            this.dgvTran = new System.Windows.Forms.DataGridView();
            this.TabPageEvent = new System.Windows.Forms.TabPage();
            this.TabPageContact = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.TabPageTranView = new System.Windows.Forms.TabPage();
            this.TabContFinance.SuspendLayout();
            this.TabPageTran.SuspendLayout();
            this.TabContTran.SuspendLayout();
            this.TabPageTranAdd.SuspendLayout();
            this.TabPageTranUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTran)).BeginInit();
            this.TabPageContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabContFinance
            // 
            this.TabContFinance.Controls.Add(this.TabPageTran);
            this.TabContFinance.Controls.Add(this.TabPageEvent);
            this.TabContFinance.Controls.Add(this.TabPageContact);
            this.TabContFinance.Location = new System.Drawing.Point(3, 4);
            this.TabContFinance.Margin = new System.Windows.Forms.Padding(4);
            this.TabContFinance.Name = "TabContFinance";
            this.TabContFinance.SelectedIndex = 0;
            this.TabContFinance.Size = new System.Drawing.Size(1019, 786);
            this.TabContFinance.TabIndex = 0;
            // 
            // TabPageTran
            // 
            this.TabPageTran.Controls.Add(this.TabContTran);
            this.TabPageTran.Location = new System.Drawing.Point(4, 25);
            this.TabPageTran.Margin = new System.Windows.Forms.Padding(4);
            this.TabPageTran.Name = "TabPageTran";
            this.TabPageTran.Padding = new System.Windows.Forms.Padding(4);
            this.TabPageTran.Size = new System.Drawing.Size(1011, 757);
            this.TabPageTran.TabIndex = 0;
            this.TabPageTran.Text = "Transactions";
            this.TabPageTran.UseVisualStyleBackColor = true;
            this.TabPageTran.UseWaitCursor = true;
            // 
            // TabContTran
            // 
            this.TabContTran.Controls.Add(this.TabPageTranAdd);
            this.TabContTran.Controls.Add(this.TabPageTranUpdate);
            this.TabContTran.Controls.Add(this.TabPageTranView);
            this.TabContTran.Location = new System.Drawing.Point(7, 7);
            this.TabContTran.Name = "TabContTran";
            this.TabContTran.SelectedIndex = 0;
            this.TabContTran.Size = new System.Drawing.Size(993, 460);
            this.TabContTran.TabIndex = 26;
            this.TabContTran.UseWaitCursor = true;
            
            // 
            // TabPageTranAdd
            // 
            this.TabPageTranAdd.Controls.Add(this.label7);
            this.TabPageTranAdd.Controls.Add(this.txbTranName);
            this.TabPageTranAdd.Controls.Add(this.btnTranAdd);
            this.TabPageTranAdd.Controls.Add(this.cmbRecTranFreq);
            this.TabPageTranAdd.Controls.Add(this.label8);
            this.TabPageTranAdd.Controls.Add(this.txbTranDesc);
            this.TabPageTranAdd.Controls.Add(this.label6);
            this.TabPageTranAdd.Controls.Add(this.chbRecTran);
            this.TabPageTranAdd.Controls.Add(this.label5);
            this.TabPageTranAdd.Controls.Add(this.txbTranAmount);
            this.TabPageTranAdd.Controls.Add(this.label4);
            this.TabPageTranAdd.Controls.Add(this.cmbContact);
            this.TabPageTranAdd.Controls.Add(this.label3);
            this.TabPageTranAdd.Controls.Add(this.dtpTranDate);
            this.TabPageTranAdd.Controls.Add(this.label2);
            this.TabPageTranAdd.Controls.Add(this.cmbTranType);
            this.TabPageTranAdd.Controls.Add(this.label1);
            this.TabPageTranAdd.Location = new System.Drawing.Point(4, 25);
            this.TabPageTranAdd.Name = "TabPageTranAdd";
            this.TabPageTranAdd.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageTranAdd.Size = new System.Drawing.Size(985, 431);
            this.TabPageTranAdd.TabIndex = 0;
            this.TabPageTranAdd.Text = "Add";
            this.TabPageTranAdd.UseVisualStyleBackColor = true;
            this.TabPageTranAdd.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 140);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "Name";
            this.label7.UseWaitCursor = true;
            // 
            // txbTranName
            // 
            this.txbTranName.Location = new System.Drawing.Point(162, 136);
            this.txbTranName.Margin = new System.Windows.Forms.Padding(4);
            this.txbTranName.Name = "txbTranName";
            this.txbTranName.Size = new System.Drawing.Size(265, 22);
            this.txbTranName.TabIndex = 40;
            this.txbTranName.UseWaitCursor = true;
            // 
            // btnTranAdd
            // 
            this.btnTranAdd.Location = new System.Drawing.Point(162, 385);
            this.btnTranAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnTranAdd.Name = "btnTranAdd";
            this.btnTranAdd.Size = new System.Drawing.Size(100, 28);
            this.btnTranAdd.TabIndex = 39;
            this.btnTranAdd.Text = "Add";
            this.btnTranAdd.UseVisualStyleBackColor = true;
            this.btnTranAdd.UseWaitCursor = true;
            this.btnTranAdd.Click += new System.EventHandler(this.AddTransaction);
            // 
            // cmbRecTranFreq
            // 
            this.cmbRecTranFreq.FormattingEnabled = true;
            this.cmbRecTranFreq.Location = new System.Drawing.Point(162, 334);
            this.cmbRecTranFreq.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRecTranFreq.Name = "cmbRecTranFreq";
            this.cmbRecTranFreq.Size = new System.Drawing.Size(160, 24);
            this.cmbRecTranFreq.TabIndex = 38;
            this.cmbRecTranFreq.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 334);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Rec Frequence";
            this.label8.UseWaitCursor = true;
            // 
            // txbTranDesc
            // 
            this.txbTranDesc.Location = new System.Drawing.Point(162, 191);
            this.txbTranDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txbTranDesc.Name = "txbTranDesc";
            this.txbTranDesc.Size = new System.Drawing.Size(617, 59);
            this.txbTranDesc.TabIndex = 36;
            this.txbTranDesc.Text = "";
            this.txbTranDesc.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 195);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Description";
            this.label6.UseWaitCursor = true;
            // 
            // chbRecTran
            // 
            this.chbRecTran.AutoSize = true;
            this.chbRecTran.Location = new System.Drawing.Point(162, 282);
            this.chbRecTran.Margin = new System.Windows.Forms.Padding(4);
            this.chbRecTran.Name = "chbRecTran";
            this.chbRecTran.Size = new System.Drawing.Size(18, 17);
            this.chbRecTran.TabIndex = 34;
            this.chbRecTran.UseVisualStyleBackColor = true;
            this.chbRecTran.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 285);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Recurring";
            this.label5.UseWaitCursor = true;
            // 
            // txbTranAmount
            // 
            this.txbTranAmount.Location = new System.Drawing.Point(514, 78);
            this.txbTranAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txbTranAmount.Name = "txbTranAmount";
            this.txbTranAmount.Size = new System.Drawing.Size(265, 22);
            this.txbTranAmount.TabIndex = 32;
            this.txbTranAmount.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Amount";
            this.label4.UseWaitCursor = true;
            // 
            // cmbContact
            // 
            this.cmbContact.FormattingEnabled = true;
            this.cmbContact.Location = new System.Drawing.Point(162, 77);
            this.cmbContact.Margin = new System.Windows.Forms.Padding(4);
            this.cmbContact.Name = "cmbContact";
            this.cmbContact.Size = new System.Drawing.Size(160, 24);
            this.cmbContact.TabIndex = 30;
            this.cmbContact.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Contact";
            this.label3.UseWaitCursor = true;
            // 
            // dtpTranDate
            // 
            this.dtpTranDate.Location = new System.Drawing.Point(514, 14);
            this.dtpTranDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTranDate.Name = "dtpTranDate";
            this.dtpTranDate.Size = new System.Drawing.Size(265, 22);
            this.dtpTranDate.TabIndex = 28;
            this.dtpTranDate.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Transaction Date";
            this.label2.UseWaitCursor = true;
            // 
            // cmbTranType
            // 
            this.cmbTranType.FormattingEnabled = true;
            this.cmbTranType.Location = new System.Drawing.Point(162, 13);
            this.cmbTranType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTranType.Name = "cmbTranType";
            this.cmbTranType.Size = new System.Drawing.Size(160, 24);
            this.cmbTranType.TabIndex = 26;
            this.cmbTranType.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Transaction Type";
            this.label1.UseWaitCursor = true;
            // 
            // TabPageTranUpdate
            // 
            this.TabPageTranUpdate.Controls.Add(this.cmbTranTypeSearch);
            this.TabPageTranUpdate.Controls.Add(this.label10);
            this.TabPageTranUpdate.Controls.Add(this.btnTranSearch);
            this.TabPageTranUpdate.Controls.Add(this.label9);
            this.TabPageTranUpdate.Controls.Add(this.dtpTranToDate);
            this.TabPageTranUpdate.Controls.Add(this.dtpTranFromDate);
            this.TabPageTranUpdate.Controls.Add(this.dgvTran);
            this.TabPageTranUpdate.Location = new System.Drawing.Point(4, 25);
            this.TabPageTranUpdate.Name = "TabPageTranUpdate";
            this.TabPageTranUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageTranUpdate.Size = new System.Drawing.Size(985, 431);
            this.TabPageTranUpdate.TabIndex = 1;
            this.TabPageTranUpdate.Text = "Update";
            this.TabPageTranUpdate.UseVisualStyleBackColor = true;
            this.TabPageTranUpdate.UseWaitCursor = true;
            // 
            // cmbTranTypeSearch
            // 
            this.cmbTranTypeSearch.FormattingEnabled = true;
            this.cmbTranTypeSearch.Location = new System.Drawing.Point(681, 11);
            this.cmbTranTypeSearch.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTranTypeSearch.Name = "cmbTranTypeSearch";
            this.cmbTranTypeSearch.Size = new System.Drawing.Size(160, 24);
            this.cmbTranTypeSearch.TabIndex = 31;
            this.cmbTranTypeSearch.UseWaitCursor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(347, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "To";
            this.label10.UseWaitCursor = true;
            // 
            // btnTranSearch
            // 
            this.btnTranSearch.Location = new System.Drawing.Point(859, 7);
            this.btnTranSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnTranSearch.Name = "btnTranSearch";
            this.btnTranSearch.Size = new System.Drawing.Size(100, 28);
            this.btnTranSearch.TabIndex = 30;
            this.btnTranSearch.Text = "Search";
            this.btnTranSearch.UseVisualStyleBackColor = true;
            this.btnTranSearch.UseWaitCursor = true;
            this.btnTranSearch.Click += new System.EventHandler(this.SearchTransaction);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "From";
            this.label9.UseWaitCursor = true;
            // 
            // dtpTranToDate
            // 
            this.dtpTranToDate.Location = new System.Drawing.Point(392, 13);
            this.dtpTranToDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTranToDate.Name = "dtpTranToDate";
            this.dtpTranToDate.Size = new System.Drawing.Size(265, 22);
            this.dtpTranToDate.TabIndex = 28;
            this.dtpTranToDate.UseWaitCursor = true;
            // 
            // dtpTranFromDate
            // 
            this.dtpTranFromDate.Location = new System.Drawing.Point(59, 14);
            this.dtpTranFromDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTranFromDate.Name = "dtpTranFromDate";
            this.dtpTranFromDate.Size = new System.Drawing.Size(265, 22);
            this.dtpTranFromDate.TabIndex = 27;
            this.dtpTranFromDate.UseWaitCursor = true;
            // 
            // dgvTran
            // 
            this.dgvTran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTran.Location = new System.Drawing.Point(-4, 76);
            this.dgvTran.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTran.Name = "dgvTran";
            this.dgvTran.RowHeadersWidth = 51;
            this.dgvTran.Size = new System.Drawing.Size(993, 348);
            this.dgvTran.TabIndex = 26;
            this.dgvTran.UseWaitCursor = true;
            // 
            // TabPageEvent
            // 
            this.TabPageEvent.Location = new System.Drawing.Point(4, 25);
            this.TabPageEvent.Margin = new System.Windows.Forms.Padding(4);
            this.TabPageEvent.Name = "TabPageEvent";
            this.TabPageEvent.Padding = new System.Windows.Forms.Padding(4);
            this.TabPageEvent.Size = new System.Drawing.Size(1011, 757);
            this.TabPageEvent.TabIndex = 1;
            this.TabPageEvent.Text = "Events";
            this.TabPageEvent.UseVisualStyleBackColor = true;
            // 
            // TabPageContact
            // 
            this.TabPageContact.Controls.Add(this.button1);
            this.TabPageContact.Location = new System.Drawing.Point(4, 25);
            this.TabPageContact.Margin = new System.Windows.Forms.Padding(4);
            this.TabPageContact.Name = "TabPageContact";
            this.TabPageContact.Padding = new System.Windows.Forms.Padding(4);
            this.TabPageContact.Size = new System.Drawing.Size(1011, 757);
            this.TabPageContact.TabIndex = 2;
            this.TabPageContact.Text = "Contacts";
            this.TabPageContact.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TabPageTranView
            // 
            this.TabPageTranView.Location = new System.Drawing.Point(4, 25);
            this.TabPageTranView.Name = "TabPageTranView";
            this.TabPageTranView.Size = new System.Drawing.Size(985, 431);
            this.TabPageTranView.TabIndex = 2;
            this.TabPageTranView.Text = "View";
            this.TabPageTranView.UseVisualStyleBackColor = true;
            // 
            // FinanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 805);
            this.Controls.Add(this.TabContFinance);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FinanceForm";
            this.Text = "Finance App";
            this.TabContFinance.ResumeLayout(false);
            this.TabPageTran.ResumeLayout(false);
            this.TabContTran.ResumeLayout(false);
            this.TabPageTranAdd.ResumeLayout(false);
            this.TabPageTranAdd.PerformLayout();
            this.TabPageTranUpdate.ResumeLayout(false);
            this.TabPageTranUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTran)).EndInit();
            this.TabPageContact.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabContFinance;
        private System.Windows.Forms.TabPage TabPageTran;
        private System.Windows.Forms.TabPage TabPageEvent;
        private System.Windows.Forms.TabPage TabPageContact;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl TabContTran;
        private System.Windows.Forms.TabPage TabPageTranAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbTranName;
        private System.Windows.Forms.Button btnTranAdd;
        private System.Windows.Forms.ComboBox cmbRecTranFreq;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txbTranDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chbRecTran;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbTranAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbContact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTranDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTranType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage TabPageTranUpdate;
        private System.Windows.Forms.ComboBox cmbTranTypeSearch;
        private System.Windows.Forms.Button btnTranSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpTranToDate;
        private System.Windows.Forms.DateTimePicker dtpTranFromDate;
        private System.Windows.Forms.DataGridView dgvTran;
        private System.Windows.Forms.TabPage TabPageTranView;
    }
}

