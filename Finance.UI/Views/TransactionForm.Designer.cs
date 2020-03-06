namespace Finance.UI.Views
{
    partial class TransactionForm
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
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabPgAdd = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbFrequency = new System.Windows.Forms.ComboBox();
            this.ReqFrequence = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chbRecurring = new System.Windows.Forms.CheckBox();
            this.txbDescription = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbContact = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TabPgUpdate = new System.Windows.Forms.TabPage();
            this.tabPgView = new System.Windows.Forms.TabPage();
            this.tabPgPrediction = new System.Windows.Forms.TabPage();
            this.tabCtrl.SuspendLayout();
            this.tabPgAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tabPgAdd);
            this.tabCtrl.Controls.Add(this.TabPgUpdate);
            this.tabCtrl.Controls.Add(this.tabPgView);
            this.tabCtrl.Controls.Add(this.tabPgPrediction);
            this.tabCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrl.Location = new System.Drawing.Point(0, 0);
            this.tabCtrl.Margin = new System.Windows.Forms.Padding(2);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(645, 305);
            this.tabCtrl.TabIndex = 0;
            // 
            // tabPgAdd
            // 
            this.tabPgAdd.Controls.Add(this.btnAdd);
            this.tabPgAdd.Controls.Add(this.cmbFrequency);
            this.tabPgAdd.Controls.Add(this.ReqFrequence);
            this.tabPgAdd.Controls.Add(this.label5);
            this.tabPgAdd.Controls.Add(this.chbRecurring);
            this.tabPgAdd.Controls.Add(this.txbDescription);
            this.tabPgAdd.Controls.Add(this.label11);
            this.tabPgAdd.Controls.Add(this.label10);
            this.tabPgAdd.Controls.Add(this.txbName);
            this.tabPgAdd.Controls.Add(this.txbAmount);
            this.tabPgAdd.Controls.Add(this.label4);
            this.tabPgAdd.Controls.Add(this.cmbContact);
            this.tabPgAdd.Controls.Add(this.label3);
            this.tabPgAdd.Controls.Add(this.dtpDate);
            this.tabPgAdd.Controls.Add(this.label2);
            this.tabPgAdd.Controls.Add(this.cmbType);
            this.tabPgAdd.Controls.Add(this.label1);
            this.tabPgAdd.Location = new System.Drawing.Point(4, 22);
            this.tabPgAdd.Margin = new System.Windows.Forms.Padding(2);
            this.tabPgAdd.Name = "tabPgAdd";
            this.tabPgAdd.Padding = new System.Windows.Forms.Padding(2);
            this.tabPgAdd.Size = new System.Drawing.Size(637, 279);
            this.tabPgAdd.TabIndex = 0;
            this.tabPgAdd.Text = "Add";
            this.tabPgAdd.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(132, 239);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 19);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnClickAddTransaction);
            // 
            // cmbFrequency
            // 
            this.cmbFrequency.FormattingEnabled = true;
            this.cmbFrequency.Location = new System.Drawing.Point(430, 200);
            this.cmbFrequency.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFrequency.Name = "cmbFrequency";
            this.cmbFrequency.Size = new System.Drawing.Size(151, 21);
            this.cmbFrequency.TabIndex = 16;
            // 
            // ReqFrequence
            // 
            this.ReqFrequence.AutoSize = true;
            this.ReqFrequence.Location = new System.Drawing.Point(321, 206);
            this.ReqFrequence.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ReqFrequence.Name = "ReqFrequence";
            this.ReqFrequence.Size = new System.Drawing.Size(63, 13);
            this.ReqFrequence.TabIndex = 15;
            this.ReqFrequence.Text = "Occurrence";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Recurring";
            // 
            // chbRecurring
            // 
            this.chbRecurring.AutoSize = true;
            this.chbRecurring.Location = new System.Drawing.Point(132, 206);
            this.chbRecurring.Margin = new System.Windows.Forms.Padding(2);
            this.chbRecurring.Name = "chbRecurring";
            this.chbRecurring.Size = new System.Drawing.Size(15, 14);
            this.chbRecurring.TabIndex = 13;
            this.chbRecurring.UseVisualStyleBackColor = true;
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(132, 147);
            this.txbDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(450, 38);
            this.txbDescription.TabIndex = 11;
            this.txbDescription.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 150);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 106);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Name";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(132, 106);
            this.txbName.Margin = new System.Windows.Forms.Padding(2);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(151, 20);
            this.txbName.TabIndex = 8;
            // 
            // txbAmount
            // 
            this.txbAmount.Location = new System.Drawing.Point(430, 64);
            this.txbAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txbAmount.Name = "txbAmount";
            this.txbAmount.Size = new System.Drawing.Size(151, 20);
            this.txbAmount.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Amount";
            // 
            // cmbContact
            // 
            this.cmbContact.FormattingEnabled = true;
            this.cmbContact.Location = new System.Drawing.Point(132, 63);
            this.cmbContact.Margin = new System.Windows.Forms.Padding(2);
            this.cmbContact.Name = "cmbContact";
            this.cmbContact.Size = new System.Drawing.Size(151, 21);
            this.cmbContact.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contact";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(430, 20);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(197, 20);
            this.dtpDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Transaction Date";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(132, 20);
            this.cmbType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(151, 21);
            this.cmbType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction Type";
            // 
            // TabPgUpdate
            // 
            this.TabPgUpdate.Location = new System.Drawing.Point(4, 22);
            this.TabPgUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.TabPgUpdate.Name = "TabPgUpdate";
            this.TabPgUpdate.Padding = new System.Windows.Forms.Padding(2);
            this.TabPgUpdate.Size = new System.Drawing.Size(637, 279);
            this.TabPgUpdate.TabIndex = 1;
            this.TabPgUpdate.Text = "Update";
            this.TabPgUpdate.UseVisualStyleBackColor = true;
            // 
            // tabPgView
            // 
            this.tabPgView.Location = new System.Drawing.Point(4, 22);
            this.tabPgView.Margin = new System.Windows.Forms.Padding(2);
            this.tabPgView.Name = "tabPgView";
            this.tabPgView.Size = new System.Drawing.Size(637, 279);
            this.tabPgView.TabIndex = 2;
            this.tabPgView.Text = "View";
            this.tabPgView.UseVisualStyleBackColor = true;
            // 
            // tabPgPrediction
            // 
            this.tabPgPrediction.Location = new System.Drawing.Point(4, 22);
            this.tabPgPrediction.Margin = new System.Windows.Forms.Padding(2);
            this.tabPgPrediction.Name = "tabPgPrediction";
            this.tabPgPrediction.Size = new System.Drawing.Size(637, 279);
            this.tabPgPrediction.TabIndex = 3;
            this.tabPgPrediction.Text = "Prediction";
            this.tabPgPrediction.UseVisualStyleBackColor = true;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 305);
            this.Controls.Add(this.tabCtrl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TransactionForm";
            this.Text = "Transaction";
            this.tabCtrl.ResumeLayout(false);
            this.tabPgAdd.ResumeLayout(false);
            this.tabPgAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tabPgAdd;
        private System.Windows.Forms.TabPage TabPgUpdate;
        private System.Windows.Forms.TabPage tabPgView;
        private System.Windows.Forms.TabPage tabPgPrediction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbFrequency;
        private System.Windows.Forms.Label ReqFrequence;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbRecurring;
        private System.Windows.Forms.RichTextBox txbDescription;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbContact;
        private System.Windows.Forms.Label label3;
    }
}