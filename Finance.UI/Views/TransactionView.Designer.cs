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
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.directoryEntry2 = new System.DirectoryServices.DirectoryEntry();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.panRecSection = new System.Windows.Forms.Panel();
            this.labFrequence = new System.Windows.Forms.Label();
            this.cmbFrequency = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClearTable = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.chbIsRecurring = new System.Windows.Forms.CheckBox();
            this.txbDescription = new System.Windows.Forms.RichTextBox();
            this.txbTranName = new System.Windows.Forms.TextBox();
            this.txbAmount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbContact = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTranDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTranType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.cmbTranTypeSearch = new System.Windows.Forms.ComboBox();
            this.lblTranType = new System.Windows.Forms.Label();
            this.dgvTranTable = new System.Windows.Forms.DataGridView();
            this.tabLayPanTran = new System.Windows.Forms.TableLayoutPanel();
            this.dtpForecast = new System.Windows.Forms.DateTimePicker();
            this.btnForecast = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panRecSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranTable)).BeginInit();
            this.tabLayPanTran.SuspendLayout();
            this.SuspendLayout();
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(1060, 338);
            this.btnClearForm.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(56, 25);
            this.btnClearForm.TabIndex = 98;
            this.btnClearForm.Text = "Clear";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearFromClick);
            // 
            // panRecSection
            // 
            this.panRecSection.Controls.Add(this.labFrequence);
            this.panRecSection.Controls.Add(this.cmbFrequency);
            this.panRecSection.Location = new System.Drawing.Point(863, 299);
            this.panRecSection.Name = "panRecSection";
            this.panRecSection.Size = new System.Drawing.Size(262, 35);
            this.panRecSection.TabIndex = 97;
            // 
            // labFrequence
            // 
            this.labFrequence.AutoSize = true;
            this.labFrequence.Location = new System.Drawing.Point(2, 5);
            this.labFrequence.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labFrequence.Name = "labFrequence";
            this.labFrequence.Size = new System.Drawing.Size(63, 13);
            this.labFrequence.TabIndex = 34;
            this.labFrequence.Text = "Occurrence";
            // 
            // cmbFrequency
            // 
            this.cmbFrequency.FormattingEnabled = true;
            this.cmbFrequency.Location = new System.Drawing.Point(69, 2);
            this.cmbFrequency.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFrequency.Name = "cmbFrequency";
            this.cmbFrequency.Size = new System.Drawing.Size(183, 21);
            this.cmbFrequency.TabIndex = 35;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(997, 338);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 25);
            this.btnDelete.TabIndex = 96;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDeleteClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(932, 338);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(56, 25);
            this.btnUpdate.TabIndex = 95;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdateClick);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(868, 338);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(56, 25);
            this.btnCreate.TabIndex = 94;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreateClick);
            // 
            // btnClearTable
            // 
            this.btnClearTable.Location = new System.Drawing.Point(784, 27);
            this.btnClearTable.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearTable.Name = "btnClearTable";
            this.btnClearTable.Size = new System.Drawing.Size(56, 21);
            this.btnClearTable.TabIndex = 93;
            this.btnClearTable.Text = "Clear";
            this.btnClearTable.UseVisualStyleBackColor = true;
            this.btnClearTable.Click += new System.EventHandler(this.btnClearTableClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(724, 27);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 21);
            this.btnSearch.TabIndex = 92;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearchClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(866, 282);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 91;
            this.label5.Text = "Recurring";
            // 
            // chbIsRecurring
            // 
            this.chbIsRecurring.AutoSize = true;
            this.chbIsRecurring.Location = new System.Drawing.Point(932, 282);
            this.chbIsRecurring.Margin = new System.Windows.Forms.Padding(2);
            this.chbIsRecurring.Name = "chbIsRecurring";
            this.chbIsRecurring.Size = new System.Drawing.Size(15, 14);
            this.chbIsRecurring.TabIndex = 90;
            this.chbIsRecurring.UseVisualStyleBackColor = true;
            this.chbIsRecurring.CheckedChanged += new System.EventHandler(this.chbIsRecurringCheckedChanged);
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(935, 165);
            this.txbDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(180, 50);
            this.txbDescription.TabIndex = 89;
            this.txbDescription.Text = "";
            // 
            // txbTranName
            // 
            this.txbTranName.Location = new System.Drawing.Point(934, 134);
            this.txbTranName.Margin = new System.Windows.Forms.Padding(2);
            this.txbTranName.Name = "txbTranName";
            this.txbTranName.Size = new System.Drawing.Size(181, 20);
            this.txbTranName.TabIndex = 86;
            // 
            // txbAmount
            // 
            this.txbAmount.Location = new System.Drawing.Point(934, 252);
            this.txbAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txbAmount.Name = "txbAmount";
            this.txbAmount.Size = new System.Drawing.Size(181, 20);
            this.txbAmount.TabIndex = 85;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(866, 169);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 88;
            this.label11.Text = "Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(866, 135);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 87;
            this.label10.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(866, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 84;
            this.label4.Text = "Amount";
            // 
            // cmbContact
            // 
            this.cmbContact.FormattingEnabled = true;
            this.cmbContact.Location = new System.Drawing.Point(935, 102);
            this.cmbContact.Margin = new System.Windows.Forms.Padding(2);
            this.cmbContact.Name = "cmbContact";
            this.cmbContact.Size = new System.Drawing.Size(180, 21);
            this.cmbContact.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(866, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "Contact";
            // 
            // dtpTranDate
            // 
            this.dtpTranDate.Location = new System.Drawing.Point(934, 225);
            this.dtpTranDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTranDate.Name = "dtpTranDate";
            this.dtpTranDate.Size = new System.Drawing.Size(181, 20);
            this.dtpTranDate.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(866, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Date";
            // 
            // cmbTranType
            // 
            this.cmbTranType.FormattingEnabled = true;
            this.cmbTranType.Location = new System.Drawing.Point(934, 72);
            this.cmbTranType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTranType.Name = "cmbTranType";
            this.cmbTranType.Size = new System.Drawing.Size(181, 21);
            this.cmbTranType.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(866, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Type";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(517, 27);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(197, 20);
            this.dtpToDate.TabIndex = 76;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(466, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 73;
            this.label8.Text = "To Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 72;
            this.label7.Text = "From Date";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(262, 27);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(197, 20);
            this.dtpFromDate.TabIndex = 75;
            // 
            // cmbTranTypeSearch
            // 
            this.cmbTranTypeSearch.FormattingEnabled = true;
            this.cmbTranTypeSearch.Location = new System.Drawing.Point(44, 23);
            this.cmbTranTypeSearch.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTranTypeSearch.Name = "cmbTranTypeSearch";
            this.cmbTranTypeSearch.Size = new System.Drawing.Size(151, 21);
            this.cmbTranTypeSearch.TabIndex = 74;
            // 
            // lblTranType
            // 
            this.lblTranType.AutoSize = true;
            this.lblTranType.Location = new System.Drawing.Point(7, 27);
            this.lblTranType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTranType.Name = "lblTranType";
            this.lblTranType.Size = new System.Drawing.Size(31, 13);
            this.lblTranType.TabIndex = 71;
            this.lblTranType.Text = "Type";
            // 
            // dgvTranTable
            // 
            this.dgvTranTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTranTable.Location = new System.Drawing.Point(2, 2);
            this.dgvTranTable.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTranTable.Name = "dgvTranTable";
            this.dgvTranTable.RowHeadersWidth = 51;
            this.dgvTranTable.RowTemplate.Height = 24;
            this.dgvTranTable.Size = new System.Drawing.Size(848, 307);
            this.dgvTranTable.TabIndex = 77;
            this.dgvTranTable.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTranTableRowHeaderMouseClick);
            // 
            // tabLayPanTran
            // 
            this.tabLayPanTran.ColumnCount = 1;
            this.tabLayPanTran.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayPanTran.Controls.Add(this.dgvTranTable, 0, 0);
            this.tabLayPanTran.Location = new System.Drawing.Point(9, 52);
            this.tabLayPanTran.Margin = new System.Windows.Forms.Padding(2);
            this.tabLayPanTran.Name = "tabLayPanTran";
            this.tabLayPanTran.RowCount = 1;
            this.tabLayPanTran.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayPanTran.Size = new System.Drawing.Size(852, 311);
            this.tabLayPanTran.TabIndex = 99;
            // 
            // dtpForecast
            // 
            this.dtpForecast.Location = new System.Drawing.Point(868, 19);
            this.dtpForecast.Margin = new System.Windows.Forms.Padding(2);
            this.dtpForecast.Name = "dtpForecast";
            this.dtpForecast.Size = new System.Drawing.Size(181, 20);
            this.dtpForecast.TabIndex = 100;
            // 
            // btnForecast
            // 
            this.btnForecast.Location = new System.Drawing.Point(1060, 18);
            this.btnForecast.Margin = new System.Windows.Forms.Padding(2);
            this.btnForecast.Name = "btnForecast";
            this.btnForecast.Size = new System.Drawing.Size(56, 22);
            this.btnForecast.TabIndex = 101;
            this.btnForecast.Text = "Forecast";
            this.btnForecast.UseVisualStyleBackColor = true;
            this.btnForecast.Click += new System.EventHandler(this.btnGetForecastClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 103;
            this.label6.Text = "My Transactions";
            // 
            // TransactionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 428);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnForecast);
            this.Controls.Add(this.dtpForecast);
            this.Controls.Add(this.tabLayPanTran);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.panRecSection);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnClearTable);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chbIsRecurring);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.txbTranName);
            this.Controls.Add(this.txbAmount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbContact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpTranDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTranType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.cmbTranTypeSearch);
            this.Controls.Add(this.lblTranType);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TransactionView";
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.TransactionView_Load);
            this.panRecSection.ResumeLayout(false);
            this.panRecSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranTable)).EndInit();
            this.tabLayPanTran.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.DirectoryServices.DirectoryEntry directoryEntry2;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Panel panRecSection;
        private System.Windows.Forms.Label labFrequence;
        private System.Windows.Forms.ComboBox cmbFrequency;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClearTable;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbIsRecurring;
        private System.Windows.Forms.RichTextBox txbDescription;
        private System.Windows.Forms.TextBox txbTranName;
        private System.Windows.Forms.TextBox txbAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbContact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTranDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTranType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.ComboBox cmbTranTypeSearch;
        private System.Windows.Forms.Label lblTranType;
        private System.Windows.Forms.DataGridView dgvTranTable;
        private System.Windows.Forms.TableLayoutPanel tabLayPanTran;
        private System.Windows.Forms.DateTimePicker dtpForecast;
        private System.Windows.Forms.Button btnForecast;
        private System.Windows.Forms.Label label6;
    }
}