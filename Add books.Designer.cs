using System.Drawing;
using System.Windows.Forms;

namespace Library_Management_System
{
    partial class Add_books
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Add_to = new System.Windows.Forms.Button();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.qnt_txt = new System.Windows.Forms.TextBox();
            this.Title_txt = new System.Windows.Forms.TextBox();
            this.author_txt = new System.Windows.Forms.TextBox();
            this.section_txt = new System.Windows.Forms.TextBox();
            this.edition_txt = new System.Windows.Forms.TextBox();
            this.ID_text = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(97, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(76, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edition";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(120, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(76, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Author";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(88, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Title";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(85, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(76, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "section";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.Add_to);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.price_txt);
            this.panel1.Controls.Add(this.qnt_txt);
            this.panel1.Controls.Add(this.Title_txt);
            this.panel1.Controls.Add(this.author_txt);
            this.panel1.Controls.Add(this.section_txt);
            this.panel1.Controls.Add(this.edition_txt);
            this.panel1.Controls.Add(this.ID_text);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(124, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 380);
            this.panel1.TabIndex = 0;
            // 
            // Add_to
            // 
            this.Add_to.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Add_to.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.Add_to.ForeColor = System.Drawing.Color.Chartreuse;
            this.Add_to.Location = new System.Drawing.Point(239, 345);
            this.Add_to.Name = "Add_to";
            this.Add_to.Size = new System.Drawing.Size(104, 35);
            this.Add_to.TabIndex = 15;
            this.Add_to.Text = "Add ";
            this.Add_to.UseVisualStyleBackColor = false;
            this.Add_to.Click += new System.EventHandler(this.Add_to_Click);
            // 
            // price_txt
            // 
            this.price_txt.Location = new System.Drawing.Point(181, 319);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(248, 20);
            this.price_txt.TabIndex = 12;
            // 
            // qnt_txt
            // 
            this.qnt_txt.Location = new System.Drawing.Point(181, 270);
            this.qnt_txt.Name = "qnt_txt";
            this.qnt_txt.Size = new System.Drawing.Size(248, 20);
            this.qnt_txt.TabIndex = 11;
            // 
            // Title_txt
            // 
            this.Title_txt.Location = new System.Drawing.Point(181, 75);
            this.Title_txt.Name = "Title_txt";
            this.Title_txt.Size = new System.Drawing.Size(248, 20);
            this.Title_txt.TabIndex = 10;
            // 
            // author_txt
            // 
            this.author_txt.Location = new System.Drawing.Point(181, 124);
            this.author_txt.Name = "author_txt";
            this.author_txt.Size = new System.Drawing.Size(248, 20);
            this.author_txt.TabIndex = 9;
            // 
            // section_txt
            // 
            this.section_txt.Location = new System.Drawing.Point(181, 173);
            this.section_txt.Name = "section_txt";
            this.section_txt.Size = new System.Drawing.Size(248, 20);
            this.section_txt.TabIndex = 8;
            // 
            // edition_txt
            // 
            this.edition_txt.Location = new System.Drawing.Point(181, 222);
            this.edition_txt.Name = "edition_txt";
            this.edition_txt.Size = new System.Drawing.Size(248, 20);
            this.edition_txt.TabIndex = 7;
            // 
            // ID_text
            // 
            this.ID_text.Location = new System.Drawing.Point(181, 27);
            this.ID_text.Name = "ID_text";
            this.ID_text.Size = new System.Drawing.Size(248, 20);
            this.ID_text.TabIndex = 6;
            // 
            // Add_books
            // 
            this.AcceptButton = this.Add_to;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(814, 455);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_books";
            this.Text = "Add_books";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Add_to;
        private System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.TextBox qnt_txt;
        private System.Windows.Forms.TextBox Title_txt;
        private System.Windows.Forms.TextBox author_txt;
        private System.Windows.Forms.TextBox section_txt;
        private System.Windows.Forms.TextBox edition_txt;
        private System.Windows.Forms.TextBox ID_text;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}