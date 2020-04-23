﻿using System;

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
            this.btnTran = new System.Windows.Forms.Button();
            this.btnCont = new System.Windows.Forms.Button();
            this.btnEvnt = new System.Windows.Forms.Button();
            this.btnRpt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTran
            // 
            this.btnTran.Location = new System.Drawing.Point(82, 58);
            this.btnTran.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTran.Name = "btnTran";
            this.btnTran.Size = new System.Drawing.Size(85, 38);
            this.btnTran.TabIndex = 0;
            this.btnTran.Text = "Transactions";
            this.btnTran.UseVisualStyleBackColor = true;
            this.btnTran.Click += new System.EventHandler(this.btnClickOpenTransactionForm);
            // 
            // btnCont
            // 
            this.btnCont.Location = new System.Drawing.Point(200, 58);
            this.btnCont.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCont.Name = "btnCont";
            this.btnCont.Size = new System.Drawing.Size(85, 38);
            this.btnCont.TabIndex = 1;
            this.btnCont.Text = "Contacts";
            this.btnCont.UseVisualStyleBackColor = true;
            this.btnCont.Click += new System.EventHandler(this.btnClickOpenContactForm);
            // 
            // btnEvnt
            // 
            this.btnEvnt.Location = new System.Drawing.Point(82, 115);
            this.btnEvnt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEvnt.Name = "btnEvnt";
            this.btnEvnt.Size = new System.Drawing.Size(85, 38);
            this.btnEvnt.TabIndex = 2;
            this.btnEvnt.Text = "Events";
            this.btnEvnt.UseVisualStyleBackColor = true;
            this.btnEvnt.Click += new System.EventHandler(this.btnClickOpenEvenForm);
            // 
            // btnRpt
            // 
            this.btnRpt.Location = new System.Drawing.Point(200, 115);
            this.btnRpt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRpt.Name = "btnRpt";
            this.btnRpt.Size = new System.Drawing.Size(85, 38);
            this.btnRpt.TabIndex = 3;
            this.btnRpt.Text = "Report";
            this.btnRpt.UseVisualStyleBackColor = true;
            this.btnRpt.Click += new System.EventHandler(this.btnClickOpenReportForm);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 232);
            this.Controls.Add(this.btnRpt);
            this.Controls.Add(this.btnEvnt);
            this.Controls.Add(this.btnCont);
            this.Controls.Add(this.btnTran);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainView";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTran;
        private System.Windows.Forms.Button btnCont;
        private System.Windows.Forms.Button btnEvnt;
        private System.Windows.Forms.Button btnRpt;
    }
}