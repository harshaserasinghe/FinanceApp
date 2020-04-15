namespace Finance.UI.Views
{
    partial class ContactView
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbContName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbBusinessType = new System.Windows.Forms.TextBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.txbPhoneNumber = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClearTable = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbContNameSearch = new System.Windows.Forms.TextBox();
            this.dgvContTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(680, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txbContName
            // 
            this.txbContName.Location = new System.Drawing.Point(770, 55);
            this.txbContName.Name = "txbContName";
            this.txbContName.Size = new System.Drawing.Size(240, 22);
            this.txbContName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(680, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Business";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(680, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(680, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone";
            // 
            // txbBusinessType
            // 
            this.txbBusinessType.Location = new System.Drawing.Point(770, 83);
            this.txbBusinessType.Name = "txbBusinessType";
            this.txbBusinessType.Size = new System.Drawing.Size(240, 22);
            this.txbBusinessType.TabIndex = 7;
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(770, 116);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(240, 22);
            this.txbAddress.TabIndex = 8;
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.Location = new System.Drawing.Point(770, 147);
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.Size = new System.Drawing.Size(240, 22);
            this.txbPhoneNumber.TabIndex = 9;
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(934, 184);
            this.btnClearForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(75, 23);
            this.btnClearForm.TabIndex = 46;
            this.btnClearForm.Text = "Clear";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearFromClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(850, 184);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDeleteClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(764, 184);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 44;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdateClick);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(679, 184);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 43;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreateClick);
            // 
            // btnClearTable
            // 
            this.btnClearTable.Location = new System.Drawing.Point(545, 20);
            this.btnClearTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearTable.Name = "btnClearTable";
            this.btnClearTable.Size = new System.Drawing.Size(75, 23);
            this.btnClearTable.TabIndex = 48;
            this.btnClearTable.Text = "Clear";
            this.btnClearTable.UseVisualStyleBackColor = true;
            this.btnClearTable.Click += new System.EventHandler(this.btnClearTableClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(464, 20);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearchClick);
            // 
            // txbContNameSearch
            // 
            this.txbContNameSearch.Location = new System.Drawing.Point(12, 21);
            this.txbContNameSearch.Name = "txbContNameSearch";
            this.txbContNameSearch.Size = new System.Drawing.Size(446, 22);
            this.txbContNameSearch.TabIndex = 49;
            // 
            // dgvContTable
            // 
            this.dgvContTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContTable.Location = new System.Drawing.Point(12, 57);
            this.dgvContTable.Name = "dgvContTable";
            this.dgvContTable.RowHeadersWidth = 51;
            this.dgvContTable.RowTemplate.Height = 24;
            this.dgvContTable.Size = new System.Drawing.Size(608, 282);
            this.dgvContTable.TabIndex = 50;
            this.dgvContTable.SelectionChanged += new System.EventHandler(this.dgvContTableSelectionChange);
            // 
            // ContactView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 351);
            this.Controls.Add(this.dgvContTable);
            this.Controls.Add(this.txbContNameSearch);
            this.Controls.Add(this.btnClearTable);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txbPhoneNumber);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.txbBusinessType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbContName);
            this.Controls.Add(this.label1);
            this.Name = "ContactView";
            this.Text = "ContactForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbContName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbBusinessType;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.TextBox txbPhoneNumber;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClearTable;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbContNameSearch;
        private System.Windows.Forms.DataGridView dgvContTable;
    }
}