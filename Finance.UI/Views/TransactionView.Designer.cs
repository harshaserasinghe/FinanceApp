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
            this.label6 = new System.Windows.Forms.Label();
            this.dgvTranTable = new System.Windows.Forms.DataGridView();
            this.tabLayPanTran = new System.Windows.Forms.TableLayoutPanel();
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
            this.btnClearForm.Location = new System.Drawing.Point(1415, 393);
            this.btnClearForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(75, 23);
            this.btnClearForm.TabIndex = 98;
            this.btnClearForm.Text = "Clear";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearFromClick);
            // 
            // panRecSection
            // 
            this.panRecSection.Controls.Add(this.labFrequence);
            this.panRecSection.Controls.Add(this.cmbFrequency);
            this.panRecSection.Location = new System.Drawing.Point(1153, 344);
            this.panRecSection.Margin = new System.Windows.Forms.Padding(4);
            this.panRecSection.Name = "panRecSection";
            this.panRecSection.Size = new System.Drawing.Size(349, 43);
            this.panRecSection.TabIndex = 97;
            // 
            // labFrequence
            // 
            this.labFrequence.AutoSize = true;
            this.labFrequence.Location = new System.Drawing.Point(3, 6);
            this.labFrequence.Name = "labFrequence";
            this.labFrequence.Size = new System.Drawing.Size(82, 17);
            this.labFrequence.TabIndex = 34;
            this.labFrequence.Text = "Occurrence";
            // 
            // cmbFrequency
            // 
            this.cmbFrequency.FormattingEnabled = true;
            this.cmbFrequency.Location = new System.Drawing.Point(92, 2);
            this.cmbFrequency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFrequency.Name = "cmbFrequency";
            this.cmbFrequency.Size = new System.Drawing.Size(243, 24);
            this.cmbFrequency.TabIndex = 35;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1331, 393);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 96;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDeleteClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1245, 393);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 95;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdateClick);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(1160, 393);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 94;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreateClick);
            // 
            // btnClearTable
            // 
            this.btnClearTable.Location = new System.Drawing.Point(1046, 22);
            this.btnClearTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearTable.Name = "btnClearTable";
            this.btnClearTable.Size = new System.Drawing.Size(75, 23);
            this.btnClearTable.TabIndex = 93;
            this.btnClearTable.Text = "Clear";
            this.btnClearTable.UseVisualStyleBackColor = true;
            this.btnClearTable.Click += new System.EventHandler(this.btnClearTableClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(965, 22);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 92;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearchClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1157, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 91;
            this.label5.Text = "Recurring";
            // 
            // chbIsRecurring
            // 
            this.chbIsRecurring.AutoSize = true;
            this.chbIsRecurring.Location = new System.Drawing.Point(1245, 324);
            this.chbIsRecurring.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbIsRecurring.Name = "chbIsRecurring";
            this.chbIsRecurring.Size = new System.Drawing.Size(18, 17);
            this.chbIsRecurring.TabIndex = 90;
            this.chbIsRecurring.UseVisualStyleBackColor = true;
            this.chbIsRecurring.CheckedChanged += new System.EventHandler(this.chbIsRecurringCheckedChanged);
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(1249, 180);
            this.txbDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(239, 61);
            this.txbDescription.TabIndex = 89;
            this.txbDescription.Text = "";
            // 
            // txbTranName
            // 
            this.txbTranName.Location = new System.Drawing.Point(1248, 141);
            this.txbTranName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTranName.Name = "txbTranName";
            this.txbTranName.Size = new System.Drawing.Size(240, 22);
            this.txbTranName.TabIndex = 86;
            // 
            // txbAmount
            // 
            this.txbAmount.Location = new System.Drawing.Point(1248, 287);
            this.txbAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbAmount.Name = "txbAmount";
            this.txbAmount.Size = new System.Drawing.Size(240, 22);
            this.txbAmount.TabIndex = 85;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1157, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 88;
            this.label11.Text = "Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1157, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 87;
            this.label10.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1157, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 84;
            this.label4.Text = "Amount";
            // 
            // cmbContact
            // 
            this.cmbContact.FormattingEnabled = true;
            this.cmbContact.Location = new System.Drawing.Point(1249, 104);
            this.cmbContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbContact.Name = "cmbContact";
            this.cmbContact.Size = new System.Drawing.Size(239, 24);
            this.cmbContact.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1157, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 82;
            this.label3.Text = "Contact";
            // 
            // dtpTranDate
            // 
            this.dtpTranDate.Location = new System.Drawing.Point(1248, 253);
            this.dtpTranDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpTranDate.Name = "dtpTranDate";
            this.dtpTranDate.Size = new System.Drawing.Size(240, 22);
            this.dtpTranDate.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1157, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 80;
            this.label2.Text = "Date";
            // 
            // cmbTranType
            // 
            this.cmbTranType.FormattingEnabled = true;
            this.cmbTranType.Location = new System.Drawing.Point(1248, 66);
            this.cmbTranType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTranType.Name = "cmbTranType";
            this.cmbTranType.Size = new System.Drawing.Size(240, 24);
            this.cmbTranType.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1157, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 78;
            this.label1.Text = "Type";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(689, 22);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(261, 22);
            this.dtpToDate.TabIndex = 76;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(622, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 73;
            this.label8.Text = "To Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 72;
            this.label7.Text = "From Date";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(350, 22);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(261, 22);
            this.dtpFromDate.TabIndex = 75;
            // 
            // cmbTranTypeSearch
            // 
            this.cmbTranTypeSearch.FormattingEnabled = true;
            this.cmbTranTypeSearch.Location = new System.Drawing.Point(59, 17);
            this.cmbTranTypeSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTranTypeSearch.Name = "cmbTranTypeSearch";
            this.cmbTranTypeSearch.Size = new System.Drawing.Size(200, 24);
            this.cmbTranTypeSearch.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 71;
            this.label6.Text = "Type";
            // 
            // dgvTranTable
            // 
            this.dgvTranTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTranTable.Location = new System.Drawing.Point(3, 2);
            this.dgvTranTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTranTable.Name = "dgvTranTable";
            this.dgvTranTable.RowHeadersWidth = 51;
            this.dgvTranTable.RowTemplate.Height = 24;
            this.dgvTranTable.Size = new System.Drawing.Size(1103, 348);
            this.dgvTranTable.TabIndex = 77;
            this.dgvTranTable.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTranTableRowHeaderMouseClick);
            // 
            // tabLayPanTran
            // 
            this.tabLayPanTran.ColumnCount = 1;
            this.tabLayPanTran.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayPanTran.Controls.Add(this.dgvTranTable, 0, 0);
            this.tabLayPanTran.Location = new System.Drawing.Point(12, 64);
            this.tabLayPanTran.Name = "tabLayPanTran";
            this.tabLayPanTran.RowCount = 1;
            this.tabLayPanTran.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabLayPanTran.Size = new System.Drawing.Size(1109, 352);
            this.tabLayPanTran.TabIndex = 99;
            // 
            // TransactionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 447);
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
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TransactionView";
            this.Text = "Transaction";
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvTranTable;
        private System.Windows.Forms.TableLayoutPanel tabLayPanTran;
    }
}