using System.Drawing;
using System.Windows.Forms;
using System;

namespace Library_Management_System
{
    partial class Issueform
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
            this.searchpanel = new System.Windows.Forms.Panel();
            this.dateTimePickerfirst = new System.Windows.Forms.DateTimePicker();
            this.enddate = new System.Windows.Forms.DateTimePicker();
            this.Bkid_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Issue_btn = new System.Windows.Forms.Button();
            this.userid_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Title_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchpanel
            // 
            this.searchpanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchpanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.searchpanel.Controls.Add(this.dateTimePickerfirst);
            this.searchpanel.Controls.Add(this.enddate);
            this.searchpanel.Controls.Add(this.Bkid_txt);
            this.searchpanel.Controls.Add(this.label5);
            this.searchpanel.Controls.Add(this.label4);
            this.searchpanel.Controls.Add(this.label3);
            this.searchpanel.Controls.Add(this.Issue_btn);
            this.searchpanel.Controls.Add(this.userid_txt);
            this.searchpanel.Controls.Add(this.label2);
            this.searchpanel.Controls.Add(this.Title_txt);
            this.searchpanel.Controls.Add(this.label1);
            this.searchpanel.ForeColor = System.Drawing.SystemColors.Control;
            this.searchpanel.Location = new System.Drawing.Point(199, 65);
            this.searchpanel.Margin = new System.Windows.Forms.Padding(2);
            this.searchpanel.Name = "searchpanel";
            this.searchpanel.Size = new System.Drawing.Size(476, 247);
            this.searchpanel.TabIndex = 1;
            // 
            // dateTimePickerfirst
            // 
            this.dateTimePickerfirst.Checked = false;
            this.dateTimePickerfirst.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerfirst.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerfirst.Location = new System.Drawing.Point(154, 134);
            this.dateTimePickerfirst.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerfirst.Name = "dateTimePickerfirst";
            this.dateTimePickerfirst.Size = new System.Drawing.Size(183, 20);
            this.dateTimePickerfirst.TabIndex = 11;
            this.dateTimePickerfirst.Value = new System.DateTime(2023, 5, 2, 0, 0, 0, 0);
            // 
            // enddate
            // 
            this.enddate.CustomFormat = "yyyy-MM-dd";
            this.enddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.enddate.Location = new System.Drawing.Point(154, 173);
            this.enddate.Margin = new System.Windows.Forms.Padding(2);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(183, 20);
            this.enddate.TabIndex = 0;
            this.enddate.TabStop = false;
            this.enddate.Value = new System.DateTime(2023, 5, 11, 0, 0, 0, 0);
            // 
            // Bkid_txt
            // 
            this.Bkid_txt.Location = new System.Drawing.Point(154, 60);
            this.Bkid_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Bkid_txt.Name = "Bkid_txt";
            this.Bkid_txt.Size = new System.Drawing.Size(183, 20);
            this.Bkid_txt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(67, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Book ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(59, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "End Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(54, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "First Date";
            // 
            // Issue_btn
            // 
            this.Issue_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.Issue_btn.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.Issue_btn.ForeColor = System.Drawing.Color.GhostWhite;
            this.Issue_btn.Location = new System.Drawing.Point(178, 207);
            this.Issue_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Issue_btn.Name = "Issue_btn";
            this.Issue_btn.Size = new System.Drawing.Size(104, 38);
            this.Issue_btn.TabIndex = 4;
            this.Issue_btn.Text = "Issue";
            this.Issue_btn.UseVisualStyleBackColor = false;
            this.Issue_btn.Click += new System.EventHandler(this.Issue_btn_Click);
            // 
            // userid_txt
            // 
            this.userid_txt.Location = new System.Drawing.Point(154, 99);
            this.userid_txt.Margin = new System.Windows.Forms.Padding(2);
            this.userid_txt.Name = "userid_txt";
            this.userid_txt.Size = new System.Drawing.Size(183, 20);
            this.userid_txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(73, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "User ID";
            // 
            // Title_txt
            // 
            this.Title_txt.Location = new System.Drawing.Point(154, 21);
            this.Title_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Title_txt.Name = "Title_txt";
            this.Title_txt.Size = new System.Drawing.Size(183, 20);
            this.Title_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(95, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // Issueform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 378);
            this.Controls.Add(this.searchpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Issueform";
            this.Text = "Issueform";
            this.searchpanel.ResumeLayout(false);
            this.searchpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel searchpanel;
        private Button Issue_btn;
        private TextBox userid_txt;
        private Label label2;
        private TextBox Title_txt;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox Bkid_txt;
        private Label label5;
        private DateTimePicker enddate;
        private DateTimePicker dateTimePickerfirst;
    }
}