namespace Finance.UI.Views
{
    partial class MainView
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
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTransaction
            // 
            this.btnTransaction.Location = new System.Drawing.Point(32, 71);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(113, 47);
            this.btnTransaction.TabIndex = 0;
            this.btnTransaction.Text = "Transactions";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnClickOpenTransactionForm);
            // 
            // btnContact
            // 
            this.btnContact.Location = new System.Drawing.Point(190, 71);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(113, 47);
            this.btnContact.TabIndex = 1;
            this.btnContact.Text = "Contacts";
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnClickOpenContactForm);
            // 
            // btnEvent
            // 
            this.btnEvent.Location = new System.Drawing.Point(346, 71);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(113, 47);
            this.btnEvent.TabIndex = 2;
            this.btnEvent.Text = "Events";
            this.btnEvent.UseVisualStyleBackColor = true;
            this.btnEvent.Click += new System.EventHandler(this.btnClickOpenEvenForm);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 191);
            this.Controls.Add(this.btnEvent);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.btnTransaction);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnEvent;
    }
}