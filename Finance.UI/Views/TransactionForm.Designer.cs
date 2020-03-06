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
            this.TransactionTabControl = new System.Windows.Forms.TabControl();
            this.AddTabPage = new System.Windows.Forms.TabPage();
            this.AddTransaction = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ReqFrequence = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Recurring = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Contact = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TranDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TranType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateTabPage = new System.Windows.Forms.TabPage();
            this.ViewTabPage = new System.Windows.Forms.TabPage();
            this.Prediction = new System.Windows.Forms.TabPage();
            this.TransactionTabControl.SuspendLayout();
            this.AddTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TransactionTabControl
            // 
            this.TransactionTabControl.Controls.Add(this.AddTabPage);
            this.TransactionTabControl.Controls.Add(this.UpdateTabPage);
            this.TransactionTabControl.Controls.Add(this.ViewTabPage);
            this.TransactionTabControl.Controls.Add(this.Prediction);
            this.TransactionTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransactionTabControl.Location = new System.Drawing.Point(0, 0);
            this.TransactionTabControl.Name = "TransactionTabControl";
            this.TransactionTabControl.SelectedIndex = 0;
            this.TransactionTabControl.Size = new System.Drawing.Size(860, 375);
            this.TransactionTabControl.TabIndex = 0;
            // 
            // AddTabPage
            // 
            this.AddTabPage.Controls.Add(this.AddTransaction);
            this.AddTabPage.Controls.Add(this.comboBox1);
            this.AddTabPage.Controls.Add(this.ReqFrequence);
            this.AddTabPage.Controls.Add(this.label5);
            this.AddTabPage.Controls.Add(this.Recurring);
            this.AddTabPage.Controls.Add(this.richTextBox1);
            this.AddTabPage.Controls.Add(this.label11);
            this.AddTabPage.Controls.Add(this.label10);
            this.AddTabPage.Controls.Add(this.textBox1);
            this.AddTabPage.Controls.Add(this.Amount);
            this.AddTabPage.Controls.Add(this.label4);
            this.AddTabPage.Controls.Add(this.Contact);
            this.AddTabPage.Controls.Add(this.label3);
            this.AddTabPage.Controls.Add(this.TranDate);
            this.AddTabPage.Controls.Add(this.label2);
            this.AddTabPage.Controls.Add(this.TranType);
            this.AddTabPage.Controls.Add(this.label1);
            this.AddTabPage.Location = new System.Drawing.Point(4, 25);
            this.AddTabPage.Name = "AddTabPage";
            this.AddTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AddTabPage.Size = new System.Drawing.Size(852, 346);
            this.AddTabPage.TabIndex = 0;
            this.AddTabPage.Text = "Add";
            this.AddTabPage.UseVisualStyleBackColor = true;
            // 
            // AddTransaction
            // 
            this.AddTransaction.Location = new System.Drawing.Point(176, 294);
            this.AddTransaction.Name = "AddTransaction";
            this.AddTransaction.Size = new System.Drawing.Size(75, 23);
            this.AddTransaction.TabIndex = 17;
            this.AddTransaction.Text = "Add";
            this.AddTransaction.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(574, 246);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 16;
            // 
            // ReqFrequence
            // 
            this.ReqFrequence.AutoSize = true;
            this.ReqFrequence.Location = new System.Drawing.Point(428, 253);
            this.ReqFrequence.Name = "ReqFrequence";
            this.ReqFrequence.Size = new System.Drawing.Size(82, 17);
            this.ReqFrequence.TabIndex = 15;
            this.ReqFrequence.Text = "Occurrence";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Recurring";
            // 
            // Recurring
            // 
            this.Recurring.AutoSize = true;
            this.Recurring.Location = new System.Drawing.Point(176, 253);
            this.Recurring.Name = "Recurring";
            this.Recurring.Size = new System.Drawing.Size(18, 17);
            this.Recurring.TabIndex = 13;
            this.Recurring.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(176, 181);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(598, 46);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 8;
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(574, 79);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(200, 22);
            this.Amount.TabIndex = 7;
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
            // Contact
            // 
            this.Contact.FormattingEnabled = true;
            this.Contact.Location = new System.Drawing.Point(176, 77);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(200, 24);
            this.Contact.TabIndex = 5;
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
            // TranDate
            // 
            this.TranDate.Location = new System.Drawing.Point(574, 25);
            this.TranDate.Name = "TranDate";
            this.TranDate.Size = new System.Drawing.Size(261, 22);
            this.TranDate.TabIndex = 3;
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
            // TranType
            // 
            this.TranType.FormattingEnabled = true;
            this.TranType.Location = new System.Drawing.Point(176, 24);
            this.TranType.Name = "TranType";
            this.TranType.Size = new System.Drawing.Size(200, 24);
            this.TranType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction Type";
            // 
            // UpdateTabPage
            // 
            this.UpdateTabPage.Location = new System.Drawing.Point(4, 25);
            this.UpdateTabPage.Name = "UpdateTabPage";
            this.UpdateTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.UpdateTabPage.Size = new System.Drawing.Size(852, 346);
            this.UpdateTabPage.TabIndex = 1;
            this.UpdateTabPage.Text = "Update";
            this.UpdateTabPage.UseVisualStyleBackColor = true;
            // 
            // ViewTabPage
            // 
            this.ViewTabPage.Location = new System.Drawing.Point(4, 25);
            this.ViewTabPage.Name = "ViewTabPage";
            this.ViewTabPage.Size = new System.Drawing.Size(852, 346);
            this.ViewTabPage.TabIndex = 2;
            this.ViewTabPage.Text = "View";
            this.ViewTabPage.UseVisualStyleBackColor = true;
            // 
            // Prediction
            // 
            this.Prediction.Location = new System.Drawing.Point(4, 25);
            this.Prediction.Name = "Prediction";
            this.Prediction.Size = new System.Drawing.Size(852, 346);
            this.Prediction.TabIndex = 3;
            this.Prediction.Text = "PredictionTabPage";
            this.Prediction.UseVisualStyleBackColor = true;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 375);
            this.Controls.Add(this.TransactionTabControl);
            this.Name = "TransactionForm";
            this.Text = "Transaction";
            this.TransactionTabControl.ResumeLayout(false);
            this.AddTabPage.ResumeLayout(false);
            this.AddTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TransactionTabControl;
        private System.Windows.Forms.TabPage AddTabPage;
        private System.Windows.Forms.TabPage UpdateTabPage;
        private System.Windows.Forms.TabPage ViewTabPage;
        private System.Windows.Forms.TabPage Prediction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TranType;
        private System.Windows.Forms.DateTimePicker TranDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddTransaction;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label ReqFrequence;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox Recurring;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Contact;
        private System.Windows.Forms.Label label3;
    }
}