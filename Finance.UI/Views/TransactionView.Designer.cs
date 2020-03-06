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
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabPgAdd = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbFrequency = new System.Windows.Forms.ComboBox();
            this.ReqFrequence = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chbIsRecurring = new System.Windows.Forms.CheckBox();
            this.txbDescription = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbTranName = new System.Windows.Forms.TextBox();
            this.txbAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbContact = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTranDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTranType = new System.Windows.Forms.ComboBox();
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
            this.tabCtrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(860, 375);
            this.tabCtrl.TabIndex = 0;
            // 
            // tabPgAdd
            // 
            this.tabPgAdd.Controls.Add(this.btnAdd);
            this.tabPgAdd.Controls.Add(this.cmbFrequency);
            this.tabPgAdd.Controls.Add(this.ReqFrequence);
            this.tabPgAdd.Controls.Add(this.label5);
            this.tabPgAdd.Controls.Add(this.chbIsRecurring);
            this.tabPgAdd.Controls.Add(this.txbDescription);
            this.tabPgAdd.Controls.Add(this.label11);
            this.tabPgAdd.Controls.Add(this.label10);
            this.tabPgAdd.Controls.Add(this.txbTranName);
            this.tabPgAdd.Controls.Add(this.txbAmount);
            this.tabPgAdd.Controls.Add(this.label4);
            this.tabPgAdd.Controls.Add(this.cmbContact);
            this.tabPgAdd.Controls.Add(this.label3);
            this.tabPgAdd.Controls.Add(this.dtpTranDate);
            this.tabPgAdd.Controls.Add(this.label2);
            this.tabPgAdd.Controls.Add(this.cmbTranType);
            this.tabPgAdd.Controls.Add(this.label1);
            this.tabPgAdd.Location = new System.Drawing.Point(4, 25);
            this.tabPgAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPgAdd.Name = "tabPgAdd";
            this.tabPgAdd.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPgAdd.Size = new System.Drawing.Size(852, 346);
            this.tabPgAdd.TabIndex = 0;
            this.tabPgAdd.Text = "Add";
            this.tabPgAdd.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(176, 294);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnClickAddTransaction);
            // 
            // cmbFrequency
            // 
            this.cmbFrequency.FormattingEnabled = true;
            this.cmbFrequency.Location = new System.Drawing.Point(573, 246);
            this.cmbFrequency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFrequency.Name = "cmbFrequency";
            this.cmbFrequency.Size = new System.Drawing.Size(200, 24);
            this.cmbFrequency.TabIndex = 16;
            // 
            // ReqFrequence
            // 
            this.ReqFrequence.AutoSize = true;
            this.ReqFrequence.Location = new System.Drawing.Point(428, 254);
            this.ReqFrequence.Name = "ReqFrequence";
            this.ReqFrequence.Size = new System.Drawing.Size(82, 17);
            this.ReqFrequence.TabIndex = 15;
            this.ReqFrequence.Text = "Occurrence";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Recurring";
            // 
            // chbRecurring
            // 
            this.chbIsRecurring.AutoSize = true;
            this.chbIsRecurring.Location = new System.Drawing.Point(176, 254);
            this.chbIsRecurring.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbIsRecurring.Name = "chbRecurring";
            this.chbIsRecurring.Size = new System.Drawing.Size(18, 17);
            this.chbIsRecurring.TabIndex = 13;
            this.chbIsRecurring.UseVisualStyleBackColor = true;
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(176, 181);
            this.txbDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(599, 46);
            this.txbDescription.TabIndex = 11;
            this.txbDescription.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Name";
            // 
            // txbName
            // 
            this.txbTranName.Location = new System.Drawing.Point(176, 130);
            this.txbTranName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTranName.Name = "txbName";
            this.txbTranName.Size = new System.Drawing.Size(200, 22);
            this.txbTranName.TabIndex = 8;
            // 
            // txbAmount
            // 
            this.txbAmount.Location = new System.Drawing.Point(573, 79);
            this.txbAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbAmount.Name = "txbAmount";
            this.txbAmount.Size = new System.Drawing.Size(200, 22);
            this.txbAmount.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Amount";
            // 
            // cmbContact
            // 
            this.cmbContact.FormattingEnabled = true;
            this.cmbContact.Location = new System.Drawing.Point(176, 78);
            this.cmbContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbContact.Name = "cmbContact";
            this.cmbContact.Size = new System.Drawing.Size(200, 24);
            this.cmbContact.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contact";
            // 
            // dtpTranDate
            // 
            this.dtpTranDate.Location = new System.Drawing.Point(573, 25);
            this.dtpTranDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpTranDate.Name = "dtpTranDate";
            this.dtpTranDate.Size = new System.Drawing.Size(261, 22);
            this.dtpTranDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Transaction Date";
            // 
            // cmbTranType
            // 
            this.cmbTranType.FormattingEnabled = true;
            this.cmbTranType.Location = new System.Drawing.Point(176, 25);
            this.cmbTranType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTranType.Name = "cmbTranType";
            this.cmbTranType.Size = new System.Drawing.Size(200, 24);
            this.cmbTranType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction Type";
            // 
            // TabPgUpdate
            // 
            this.TabPgUpdate.Location = new System.Drawing.Point(4, 25);
            this.TabPgUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabPgUpdate.Name = "TabPgUpdate";
            this.TabPgUpdate.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabPgUpdate.Size = new System.Drawing.Size(852, 346);
            this.TabPgUpdate.TabIndex = 1;
            this.TabPgUpdate.Text = "Update";
            this.TabPgUpdate.UseVisualStyleBackColor = true;
            // 
            // tabPgView
            // 
            this.tabPgView.Location = new System.Drawing.Point(4, 25);
            this.tabPgView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPgView.Name = "tabPgView";
            this.tabPgView.Size = new System.Drawing.Size(852, 346);
            this.tabPgView.TabIndex = 2;
            this.tabPgView.Text = "View";
            this.tabPgView.UseVisualStyleBackColor = true;
            // 
            // tabPgPrediction
            // 
            this.tabPgPrediction.Location = new System.Drawing.Point(4, 25);
            this.tabPgPrediction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPgPrediction.Name = "tabPgPrediction";
            this.tabPgPrediction.Size = new System.Drawing.Size(852, 346);
            this.tabPgPrediction.TabIndex = 3;
            this.tabPgPrediction.Text = "Prediction";
            this.tabPgPrediction.UseVisualStyleBackColor = true;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 375);
            this.Controls.Add(this.tabCtrl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ComboBox cmbTranType;
        private System.Windows.Forms.DateTimePicker dtpTranDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbFrequency;
        private System.Windows.Forms.Label ReqFrequence;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbIsRecurring;
        private System.Windows.Forms.RichTextBox txbDescription;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbTranName;
        private System.Windows.Forms.TextBox txbAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbContact;
        private System.Windows.Forms.Label label3;
    }
}