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
            this.FinanceTabControl = new System.Windows.Forms.TabControl();
            this.TransactionTab = new System.Windows.Forms.TabPage();
            this.cmbTranTypeSearch = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbTranName = new System.Windows.Forms.TextBox();
            this.btnTranAdd = new System.Windows.Forms.Button();
            this.btnTranSearch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpTranToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTranFromDate = new System.Windows.Forms.DateTimePicker();
            this.dgvTran = new System.Windows.Forms.DataGridView();
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
            this.EventTab = new System.Windows.Forms.TabPage();
            this.ContactTab = new System.Windows.Forms.TabPage();
            this.FinanceTabControl.SuspendLayout();
            this.TransactionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTran)).BeginInit();
            this.SuspendLayout();
            // 
            // FinanceTabControl
            // 
            this.FinanceTabControl.Controls.Add(this.TransactionTab);
            this.FinanceTabControl.Controls.Add(this.EventTab);
            this.FinanceTabControl.Controls.Add(this.ContactTab);
            this.FinanceTabControl.Location = new System.Drawing.Point(2, 3);
            this.FinanceTabControl.Name = "FinanceTabControl";
            this.FinanceTabControl.SelectedIndex = 0;
            this.FinanceTabControl.Size = new System.Drawing.Size(764, 639);
            this.FinanceTabControl.TabIndex = 0;
            // 
            // TransactionTab
            // 
            this.TransactionTab.Controls.Add(this.cmbTranTypeSearch);
            this.TransactionTab.Controls.Add(this.label7);
            this.TransactionTab.Controls.Add(this.txbTranName);
            this.TransactionTab.Controls.Add(this.btnTranAdd);
            this.TransactionTab.Controls.Add(this.btnTranSearch);
            this.TransactionTab.Controls.Add(this.label10);
            this.TransactionTab.Controls.Add(this.label9);
            this.TransactionTab.Controls.Add(this.dtpTranToDate);
            this.TransactionTab.Controls.Add(this.dtpTranFromDate);
            this.TransactionTab.Controls.Add(this.dgvTran);
            this.TransactionTab.Controls.Add(this.cmbRecTranFreq);
            this.TransactionTab.Controls.Add(this.label8);
            this.TransactionTab.Controls.Add(this.txbTranDesc);
            this.TransactionTab.Controls.Add(this.label6);
            this.TransactionTab.Controls.Add(this.chbRecTran);
            this.TransactionTab.Controls.Add(this.label5);
            this.TransactionTab.Controls.Add(this.txbTranAmount);
            this.TransactionTab.Controls.Add(this.label4);
            this.TransactionTab.Controls.Add(this.cmbContact);
            this.TransactionTab.Controls.Add(this.label3);
            this.TransactionTab.Controls.Add(this.dtpTranDate);
            this.TransactionTab.Controls.Add(this.label2);
            this.TransactionTab.Controls.Add(this.cmbTranType);
            this.TransactionTab.Controls.Add(this.label1);
            this.TransactionTab.Location = new System.Drawing.Point(4, 22);
            this.TransactionTab.Name = "TransactionTab";
            this.TransactionTab.Padding = new System.Windows.Forms.Padding(3);
            this.TransactionTab.Size = new System.Drawing.Size(756, 613);
            this.TransactionTab.TabIndex = 0;
            this.TransactionTab.Text = "Transactions";
            this.TransactionTab.UseVisualStyleBackColor = true;
            this.TransactionTab.UseWaitCursor = true;
            // 
            // cmbTranTypeSearch
            // 
            this.cmbTranTypeSearch.FormattingEnabled = true;
            this.cmbTranTypeSearch.Location = new System.Drawing.Point(520, 388);
            this.cmbTranTypeSearch.Name = "cmbTranTypeSearch";
            this.cmbTranTypeSearch.Size = new System.Drawing.Size(121, 21);
            this.cmbTranTypeSearch.TabIndex = 25;
            this.cmbTranTypeSearch.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Name";
            this.label7.UseWaitCursor = true;
            // 
            // txbTranName
            // 
            this.txbTranName.Location = new System.Drawing.Point(142, 121);
            this.txbTranName.Name = "txbTranName";
            this.txbTranName.Size = new System.Drawing.Size(200, 20);
            this.txbTranName.TabIndex = 23;
            this.txbTranName.UseWaitCursor = true;
            // 
            // btnTranAdd
            // 
            this.btnTranAdd.Location = new System.Drawing.Point(142, 323);
            this.btnTranAdd.Name = "btnTranAdd";
            this.btnTranAdd.Size = new System.Drawing.Size(75, 23);
            this.btnTranAdd.TabIndex = 22;
            this.btnTranAdd.Text = "Add";
            this.btnTranAdd.UseVisualStyleBackColor = true;
            this.btnTranAdd.UseWaitCursor = true;
            this.btnTranAdd.Click += new System.EventHandler(this.AddTransaction);
            // 
            // btnTranSearch
            // 
            this.btnTranSearch.Location = new System.Drawing.Point(653, 385);
            this.btnTranSearch.Name = "btnTranSearch";
            this.btnTranSearch.Size = new System.Drawing.Size(75, 23);
            this.btnTranSearch.TabIndex = 21;
            this.btnTranSearch.Text = "Search";
            this.btnTranSearch.UseVisualStyleBackColor = true;
            this.btnTranSearch.UseWaitCursor = true;
            this.btnTranSearch.Click += new System.EventHandler(this.SearchTransaction);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(269, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "To";
            this.label10.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "From";
            this.label9.UseWaitCursor = true;
            // 
            // dtpTranToDate
            // 
            this.dtpTranToDate.Location = new System.Drawing.Point(303, 390);
            this.dtpTranToDate.Name = "dtpTranToDate";
            this.dtpTranToDate.Size = new System.Drawing.Size(200, 20);
            this.dtpTranToDate.TabIndex = 18;
            this.dtpTranToDate.UseWaitCursor = true;
            // 
            // dtpTranFromDate
            // 
            this.dtpTranFromDate.Location = new System.Drawing.Point(53, 391);
            this.dtpTranFromDate.Name = "dtpTranFromDate";
            this.dtpTranFromDate.Size = new System.Drawing.Size(200, 20);
            this.dtpTranFromDate.TabIndex = 17;
            this.dtpTranFromDate.UseWaitCursor = true;
            // 
            // dgvTran
            // 
            this.dgvTran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTran.Location = new System.Drawing.Point(6, 441);
            this.dgvTran.Name = "dgvTran";
            this.dgvTran.RowHeadersWidth = 51;
            this.dgvTran.Size = new System.Drawing.Size(745, 150);
            this.dgvTran.TabIndex = 16;
            this.dgvTran.UseWaitCursor = true;
            this.dgvTran.SelectionChanged += new System.EventHandler(this.SelectedRow);
            // 
            // cmbRecTranFreq
            // 
            this.cmbRecTranFreq.FormattingEnabled = true;
            this.cmbRecTranFreq.Location = new System.Drawing.Point(142, 282);
            this.cmbRecTranFreq.Name = "cmbRecTranFreq";
            this.cmbRecTranFreq.Size = new System.Drawing.Size(121, 21);
            this.cmbRecTranFreq.TabIndex = 15;
            this.cmbRecTranFreq.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Rec Frequence";
            this.label8.UseWaitCursor = true;
            // 
            // txbTranDesc
            // 
            this.txbTranDesc.Location = new System.Drawing.Point(142, 166);
            this.txbTranDesc.Name = "txbTranDesc";
            this.txbTranDesc.Size = new System.Drawing.Size(464, 49);
            this.txbTranDesc.TabIndex = 11;
            this.txbTranDesc.Text = "";
            this.txbTranDesc.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Description";
            this.label6.UseWaitCursor = true;
            // 
            // chbRecTran
            // 
            this.chbRecTran.AutoSize = true;
            this.chbRecTran.Location = new System.Drawing.Point(142, 240);
            this.chbRecTran.Name = "chbRecTran";
            this.chbRecTran.Size = new System.Drawing.Size(15, 14);
            this.chbRecTran.TabIndex = 9;
            this.chbRecTran.UseVisualStyleBackColor = true;
            this.chbRecTran.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Recurring";
            this.label5.UseWaitCursor = true;
            // 
            // txbTranAmount
            // 
            this.txbTranAmount.Location = new System.Drawing.Point(406, 74);
            this.txbTranAmount.Name = "txbTranAmount";
            this.txbTranAmount.Size = new System.Drawing.Size(200, 20);
            this.txbTranAmount.TabIndex = 7;
            this.txbTranAmount.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Amount";
            this.label4.UseWaitCursor = true;
            // 
            // cmbContact
            // 
            this.cmbContact.FormattingEnabled = true;
            this.cmbContact.Location = new System.Drawing.Point(142, 73);
            this.cmbContact.Name = "cmbContact";
            this.cmbContact.Size = new System.Drawing.Size(121, 21);
            this.cmbContact.TabIndex = 5;
            this.cmbContact.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contact";
            this.label3.UseWaitCursor = true;
            // 
            // dtpTranDate
            // 
            this.dtpTranDate.Location = new System.Drawing.Point(406, 22);
            this.dtpTranDate.Name = "dtpTranDate";
            this.dtpTranDate.Size = new System.Drawing.Size(200, 20);
            this.dtpTranDate.TabIndex = 3;
            this.dtpTranDate.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Transaction Date";
            this.label2.UseWaitCursor = true;
            // 
            // cmbTranType
            // 
            this.cmbTranType.FormattingEnabled = true;
            this.cmbTranType.Location = new System.Drawing.Point(142, 21);
            this.cmbTranType.Name = "cmbTranType";
            this.cmbTranType.Size = new System.Drawing.Size(121, 21);
            this.cmbTranType.TabIndex = 1;
            this.cmbTranType.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction Type";
            this.label1.UseWaitCursor = true;
            // 
            // EventTab
            // 
            this.EventTab.Location = new System.Drawing.Point(4, 22);
            this.EventTab.Name = "EventTab";
            this.EventTab.Padding = new System.Windows.Forms.Padding(3);
            this.EventTab.Size = new System.Drawing.Size(756, 613);
            this.EventTab.TabIndex = 1;
            this.EventTab.Text = "Events";
            this.EventTab.UseVisualStyleBackColor = true;
            // 
            // ContactTab
            // 
            this.ContactTab.Location = new System.Drawing.Point(4, 22);
            this.ContactTab.Name = "ContactTab";
            this.ContactTab.Padding = new System.Windows.Forms.Padding(3);
            this.ContactTab.Size = new System.Drawing.Size(756, 613);
            this.ContactTab.TabIndex = 2;
            this.ContactTab.Text = "Contacts";
            this.ContactTab.UseVisualStyleBackColor = true;
            // 
            // FinanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 654);
            this.Controls.Add(this.FinanceTabControl);
            this.Name = "FinanceForm";
            this.Text = "Finance App";
            this.FinanceTabControl.ResumeLayout(false);
            this.TransactionTab.ResumeLayout(false);
            this.TransactionTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTran)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl FinanceTabControl;
        private System.Windows.Forms.TabPage TransactionTab;
        private System.Windows.Forms.TabPage EventTab;
        private System.Windows.Forms.TabPage ContactTab;
        private System.Windows.Forms.TextBox txbTranAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbContact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTranDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTranType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txbTranDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chbRecTran;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbRecTranFreq;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvTran;
        private System.Windows.Forms.DateTimePicker dtpTranToDate;
        private System.Windows.Forms.DateTimePicker dtpTranFromDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTranAdd;
        private System.Windows.Forms.Button btnTranSearch;
        private System.Windows.Forms.TextBox txbTranName;
        private System.Windows.Forms.ComboBox cmbTranTypeSearch;
        private System.Windows.Forms.Label label7;
    }
}

