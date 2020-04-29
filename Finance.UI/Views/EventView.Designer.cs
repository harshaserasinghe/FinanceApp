namespace Finance.UI.Views
{
    partial class EventView
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
            this.cmbEvntTypeSearch = new System.Windows.Forms.ComboBox();
            this.lblEventTypeSearch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEvntStartSearch = new System.Windows.Forms.DateTimePicker();
            this.dtpEvntEndSearch = new System.Windows.Forms.DateTimePicker();
            this.pnlEvntParent = new System.Windows.Forms.Panel();
            this.pnlEvntFormItems = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpEvntEndTime = new System.Windows.Forms.DateTimePicker();
            this.pnlEvntContact = new System.Windows.Forms.Panel();
            this.cmbEvntContact = new System.Windows.Forms.ComboBox();
            this.lblEvntContact = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbEvntType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbEvntName = new System.Windows.Forms.TextBox();
            this.dtpEvntStartTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbEvntDescription = new System.Windows.Forms.TextBox();
            this.btnEvntClear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEvntDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEvntUpdate = new System.Windows.Forms.Button();
            this.dtpEventStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnEvntAdd = new System.Windows.Forms.Button();
            this.dtpEvntEndDate = new System.Windows.Forms.DateTimePicker();
            this.pnlEvntOccourence = new System.Windows.Forms.Panel();
            this.cmbEvntOccurrence = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chbIsEvntRecurring = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvEvntTable = new System.Windows.Forms.DataGridView();
            this.btnEvntSearchClear = new System.Windows.Forms.Button();
            this.btnEvntSearch = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlEvntParent.SuspendLayout();
            this.pnlEvntFormItems.SuspendLayout();
            this.pnlEvntContact.SuspendLayout();
            this.pnlEvntOccourence.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvntTable)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEvntTypeSearch
            // 
            this.cmbEvntTypeSearch.FormattingEnabled = true;
            this.cmbEvntTypeSearch.Location = new System.Drawing.Point(49, 21);
            this.cmbEvntTypeSearch.Name = "cmbEvntTypeSearch";
            this.cmbEvntTypeSearch.Size = new System.Drawing.Size(121, 21);
            this.cmbEvntTypeSearch.TabIndex = 0;
            // 
            // lblEventTypeSearch
            // 
            this.lblEventTypeSearch.AutoSize = true;
            this.lblEventTypeSearch.Location = new System.Drawing.Point(12, 24);
            this.lblEventTypeSearch.Name = "lblEventTypeSearch";
            this.lblEventTypeSearch.Size = new System.Drawing.Size(31, 13);
            this.lblEventTypeSearch.TabIndex = 1;
            this.lblEventTypeSearch.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "From Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To Date";
            // 
            // dtpEvntStartSearch
            // 
            this.dtpEvntStartSearch.Location = new System.Drawing.Point(255, 20);
            this.dtpEvntStartSearch.Name = "dtpEvntStartSearch";
            this.dtpEvntStartSearch.Size = new System.Drawing.Size(200, 20);
            this.dtpEvntStartSearch.TabIndex = 4;
            // 
            // dtpEvntEndSearch
            // 
            this.dtpEvntEndSearch.Location = new System.Drawing.Point(512, 20);
            this.dtpEvntEndSearch.Name = "dtpEvntEndSearch";
            this.dtpEvntEndSearch.Size = new System.Drawing.Size(200, 20);
            this.dtpEvntEndSearch.TabIndex = 5;
            // 
            // pnlEvntParent
            // 
            this.pnlEvntParent.Controls.Add(this.label13);
            this.pnlEvntParent.Controls.Add(this.pnlEvntFormItems);
            this.pnlEvntParent.Controls.Add(this.panel1);
            this.pnlEvntParent.Controls.Add(this.btnEvntSearchClear);
            this.pnlEvntParent.Controls.Add(this.btnEvntSearch);
            this.pnlEvntParent.Controls.Add(this.dtpEvntEndSearch);
            this.pnlEvntParent.Controls.Add(this.dtpEvntStartSearch);
            this.pnlEvntParent.Controls.Add(this.cmbEvntTypeSearch);
            this.pnlEvntParent.Controls.Add(this.label2);
            this.pnlEvntParent.Controls.Add(this.lblEventTypeSearch);
            this.pnlEvntParent.Controls.Add(this.label1);
            this.pnlEvntParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEvntParent.Location = new System.Drawing.Point(0, 0);
            this.pnlEvntParent.Name = "pnlEvntParent";
            this.pnlEvntParent.Size = new System.Drawing.Size(1483, 528);
            this.pnlEvntParent.TabIndex = 6;
            // 
            // pnlEvntFormItems
            // 
            this.pnlEvntFormItems.Controls.Add(this.label3);
            this.pnlEvntFormItems.Controls.Add(this.dtpEvntEndTime);
            this.pnlEvntFormItems.Controls.Add(this.pnlEvntContact);
            this.pnlEvntFormItems.Controls.Add(this.label12);
            this.pnlEvntFormItems.Controls.Add(this.cmbEvntType);
            this.pnlEvntFormItems.Controls.Add(this.label11);
            this.pnlEvntFormItems.Controls.Add(this.label4);
            this.pnlEvntFormItems.Controls.Add(this.label10);
            this.pnlEvntFormItems.Controls.Add(this.txbEvntName);
            this.pnlEvntFormItems.Controls.Add(this.dtpEvntStartTime);
            this.pnlEvntFormItems.Controls.Add(this.label5);
            this.pnlEvntFormItems.Controls.Add(this.label9);
            this.pnlEvntFormItems.Controls.Add(this.txbEvntDescription);
            this.pnlEvntFormItems.Controls.Add(this.btnEvntClear);
            this.pnlEvntFormItems.Controls.Add(this.label6);
            this.pnlEvntFormItems.Controls.Add(this.btnEvntDelete);
            this.pnlEvntFormItems.Controls.Add(this.label7);
            this.pnlEvntFormItems.Controls.Add(this.btnEvntUpdate);
            this.pnlEvntFormItems.Controls.Add(this.dtpEventStartDate);
            this.pnlEvntFormItems.Controls.Add(this.btnEvntAdd);
            this.pnlEvntFormItems.Controls.Add(this.dtpEvntEndDate);
            this.pnlEvntFormItems.Controls.Add(this.pnlEvntOccourence);
            this.pnlEvntFormItems.Controls.Add(this.chbIsEvntRecurring);
            this.pnlEvntFormItems.Location = new System.Drawing.Point(1130, 48);
            this.pnlEvntFormItems.Name = "pnlEvntFormItems";
            this.pnlEvntFormItems.Size = new System.Drawing.Size(337, 406);
            this.pnlEvntFormItems.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Type";
            // 
            // dtpEvntEndTime
            // 
            this.dtpEvntEndTime.CustomFormat = "HH:mm";
            this.dtpEvntEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEvntEndTime.Location = new System.Drawing.Point(244, 249);
            this.dtpEvntEndTime.Name = "dtpEvntEndTime";
            this.dtpEvntEndTime.ShowUpDown = true;
            this.dtpEvntEndTime.Size = new System.Drawing.Size(52, 20);
            this.dtpEvntEndTime.TabIndex = 31;
            // 
            // pnlEvntContact
            // 
            this.pnlEvntContact.Controls.Add(this.cmbEvntContact);
            this.pnlEvntContact.Controls.Add(this.lblEvntContact);
            this.pnlEvntContact.Location = new System.Drawing.Point(38, 40);
            this.pnlEvntContact.Name = "pnlEvntContact";
            this.pnlEvntContact.Size = new System.Drawing.Size(258, 31);
            this.pnlEvntContact.TabIndex = 10;
            this.pnlEvntContact.Visible = false;
            // 
            // cmbEvntContact
            // 
            this.cmbEvntContact.FormattingEnabled = true;
            this.cmbEvntContact.Location = new System.Drawing.Point(72, 6);
            this.cmbEvntContact.Name = "cmbEvntContact";
            this.cmbEvntContact.Size = new System.Drawing.Size(186, 21);
            this.cmbEvntContact.TabIndex = 1;
            // 
            // lblEvntContact
            // 
            this.lblEvntContact.AutoSize = true;
            this.lblEvntContact.Location = new System.Drawing.Point(4, 9);
            this.lblEvntContact.Name = "lblEvntContact";
            this.lblEvntContact.Size = new System.Drawing.Size(44, 13);
            this.lblEvntContact.TabIndex = 0;
            this.lblEvntContact.Text = "Contact";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(209, 253);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Time";
            // 
            // cmbEvntType
            // 
            this.cmbEvntType.FormattingEnabled = true;
            this.cmbEvntType.Location = new System.Drawing.Point(110, 9);
            this.cmbEvntType.Name = "cmbEvntType";
            this.cmbEvntType.Size = new System.Drawing.Size(186, 21);
            this.cmbEvntType.TabIndex = 11;
            this.cmbEvntType.SelectedValueChanged += new System.EventHandler(this.cmbEvntType_SelectedValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(74, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(74, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Date";
            // 
            // txbEvntName
            // 
            this.txbEvntName.Location = new System.Drawing.Point(110, 83);
            this.txbEvntName.Name = "txbEvntName";
            this.txbEvntName.Size = new System.Drawing.Size(186, 20);
            this.txbEvntName.TabIndex = 13;
            // 
            // dtpEvntStartTime
            // 
            this.dtpEvntStartTime.CustomFormat = "HH:mm";
            this.dtpEvntStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEvntStartTime.Location = new System.Drawing.Point(244, 202);
            this.dtpEvntStartTime.Name = "dtpEvntStartTime";
            this.dtpEvntStartTime.ShowUpDown = true;
            this.dtpEvntStartTime.Size = new System.Drawing.Size(52, 20);
            this.dtpEvntStartTime.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(209, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Time";
            // 
            // txbEvntDescription
            // 
            this.txbEvntDescription.Location = new System.Drawing.Point(110, 123);
            this.txbEvntDescription.Multiline = true;
            this.txbEvntDescription.Name = "txbEvntDescription";
            this.txbEvntDescription.Size = new System.Drawing.Size(186, 61);
            this.txbEvntDescription.TabIndex = 15;
            // 
            // btnEvntClear
            // 
            this.btnEvntClear.Location = new System.Drawing.Point(255, 371);
            this.btnEvntClear.Name = "btnEvntClear";
            this.btnEvntClear.Size = new System.Drawing.Size(53, 24);
            this.btnEvntClear.TabIndex = 25;
            this.btnEvntClear.Text = "Clear";
            this.btnEvntClear.UseVisualStyleBackColor = true;
            this.btnEvntClear.Click += new System.EventHandler(this.btnEvntClear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Start:";
            // 
            // btnEvntDelete
            // 
            this.btnEvntDelete.Location = new System.Drawing.Point(186, 371);
            this.btnEvntDelete.Name = "btnEvntDelete";
            this.btnEvntDelete.Size = new System.Drawing.Size(62, 24);
            this.btnEvntDelete.TabIndex = 24;
            this.btnEvntDelete.Text = "Delete";
            this.btnEvntDelete.UseVisualStyleBackColor = true;
            this.btnEvntDelete.Click += new System.EventHandler(this.btnEvntDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "End:";
            // 
            // btnEvntUpdate
            // 
            this.btnEvntUpdate.Location = new System.Drawing.Point(110, 371);
            this.btnEvntUpdate.Name = "btnEvntUpdate";
            this.btnEvntUpdate.Size = new System.Drawing.Size(69, 24);
            this.btnEvntUpdate.TabIndex = 23;
            this.btnEvntUpdate.Text = "Update";
            this.btnEvntUpdate.UseVisualStyleBackColor = true;
            this.btnEvntUpdate.Click += new System.EventHandler(this.btnEvntUpdate_Click);
            // 
            // dtpEventStartDate
            // 
            this.dtpEventStartDate.CustomFormat = "";
            this.dtpEventStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEventStartDate.Location = new System.Drawing.Point(110, 203);
            this.dtpEventStartDate.Name = "dtpEventStartDate";
            this.dtpEventStartDate.RightToLeftLayout = true;
            this.dtpEventStartDate.Size = new System.Drawing.Size(89, 20);
            this.dtpEventStartDate.TabIndex = 18;
            // 
            // btnEvntAdd
            // 
            this.btnEvntAdd.Location = new System.Drawing.Point(36, 371);
            this.btnEvntAdd.Name = "btnEvntAdd";
            this.btnEvntAdd.Size = new System.Drawing.Size(67, 24);
            this.btnEvntAdd.TabIndex = 22;
            this.btnEvntAdd.Text = "Create";
            this.btnEvntAdd.UseVisualStyleBackColor = true;
            this.btnEvntAdd.Click += new System.EventHandler(this.btnEvntAdd_Click);
            // 
            // dtpEvntEndDate
            // 
            this.dtpEvntEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEvntEndDate.Location = new System.Drawing.Point(108, 249);
            this.dtpEvntEndDate.Name = "dtpEvntEndDate";
            this.dtpEvntEndDate.Size = new System.Drawing.Size(91, 20);
            this.dtpEvntEndDate.TabIndex = 19;
            // 
            // pnlEvntOccourence
            // 
            this.pnlEvntOccourence.Controls.Add(this.cmbEvntOccurrence);
            this.pnlEvntOccourence.Controls.Add(this.label8);
            this.pnlEvntOccourence.Location = new System.Drawing.Point(38, 300);
            this.pnlEvntOccourence.Name = "pnlEvntOccourence";
            this.pnlEvntOccourence.Size = new System.Drawing.Size(258, 51);
            this.pnlEvntOccourence.TabIndex = 21;
            this.pnlEvntOccourence.Visible = false;
            // 
            // cmbEvntOccurrence
            // 
            this.cmbEvntOccurrence.FormattingEnabled = true;
            this.cmbEvntOccurrence.Location = new System.Drawing.Point(71, 13);
            this.cmbEvntOccurrence.Name = "cmbEvntOccurrence";
            this.cmbEvntOccurrence.Size = new System.Drawing.Size(187, 21);
            this.cmbEvntOccurrence.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Occurrence";
            // 
            // chbIsEvntRecurring
            // 
            this.chbIsEvntRecurring.Location = new System.Drawing.Point(40, 278);
            this.chbIsEvntRecurring.Name = "chbIsEvntRecurring";
            this.chbIsEvntRecurring.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbIsEvntRecurring.Size = new System.Drawing.Size(83, 27);
            this.chbIsEvntRecurring.TabIndex = 20;
            this.chbIsEvntRecurring.Text = "Recurring";
            this.chbIsEvntRecurring.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbIsEvntRecurring.UseVisualStyleBackColor = true;
            this.chbIsEvntRecurring.CheckedChanged += new System.EventHandler(this.chbIsEvntRecurring_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvEvntTable);
            this.panel1.Location = new System.Drawing.Point(15, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 406);
            this.panel1.TabIndex = 8;
            // 
            // dgvEvntTable
            // 
            this.dgvEvntTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvntTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEvntTable.Location = new System.Drawing.Point(0, 0);
            this.dgvEvntTable.Name = "dgvEvntTable";
            this.dgvEvntTable.Size = new System.Drawing.Size(1087, 406);
            this.dgvEvntTable.TabIndex = 0;
            this.dgvEvntTable.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEvntTable_RowHeaderMouseClick);
            // 
            // btnEvntSearchClear
            // 
            this.btnEvntSearchClear.Location = new System.Drawing.Point(812, 19);
            this.btnEvntSearchClear.Name = "btnEvntSearchClear";
            this.btnEvntSearchClear.Size = new System.Drawing.Size(75, 23);
            this.btnEvntSearchClear.TabIndex = 7;
            this.btnEvntSearchClear.Text = "Clear";
            this.btnEvntSearchClear.UseVisualStyleBackColor = true;
            this.btnEvntSearchClear.Click += new System.EventHandler(this.btnEvntSearchClear_Click);
            // 
            // btnEvntSearch
            // 
            this.btnEvntSearch.Location = new System.Drawing.Point(731, 19);
            this.btnEvntSearch.Name = "btnEvntSearch";
            this.btnEvntSearch.Size = new System.Drawing.Size(75, 23);
            this.btnEvntSearch.TabIndex = 6;
            this.btnEvntSearch.Text = "Search";
            this.btnEvntSearch.UseVisualStyleBackColor = true;
            this.btnEvntSearch.Click += new System.EventHandler(this.btnEvntSearch_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "My Events";
            // 
            // EventView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 528);
            this.Controls.Add(this.pnlEvntParent);
            this.Name = "EventView";
            this.Text = "EventForm";
            this.pnlEvntParent.ResumeLayout(false);
            this.pnlEvntParent.PerformLayout();
            this.pnlEvntFormItems.ResumeLayout(false);
            this.pnlEvntFormItems.PerformLayout();
            this.pnlEvntContact.ResumeLayout(false);
            this.pnlEvntContact.PerformLayout();
            this.pnlEvntOccourence.ResumeLayout(false);
            this.pnlEvntOccourence.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvntTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEvntTypeSearch;
        private System.Windows.Forms.Label lblEventTypeSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEvntStartSearch;
        private System.Windows.Forms.DateTimePicker dtpEvntEndSearch;
        private System.Windows.Forms.Panel pnlEvntParent;
        private System.Windows.Forms.Button btnEvntSearchClear;
        private System.Windows.Forms.Button btnEvntSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvEvntTable;
        private System.Windows.Forms.ComboBox cmbEvntType;
        private System.Windows.Forms.Panel pnlEvntContact;
        private System.Windows.Forms.ComboBox cmbEvntContact;
        private System.Windows.Forms.Label lblEvntContact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbEvntName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbEvntDescription;
        private System.Windows.Forms.DateTimePicker dtpEvntEndDate;
        private System.Windows.Forms.DateTimePicker dtpEventStartDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chbIsEvntRecurring;
        private System.Windows.Forms.Panel pnlEvntOccourence;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEvntClear;
        private System.Windows.Forms.Button btnEvntDelete;
        private System.Windows.Forms.Button btnEvntUpdate;
        private System.Windows.Forms.Button btnEvntAdd;
        private System.Windows.Forms.ComboBox cmbEvntOccurrence;
        private System.Windows.Forms.DateTimePicker dtpEvntEndTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpEvntStartTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlEvntFormItems;
        private System.Windows.Forms.Label label13;
    }
}