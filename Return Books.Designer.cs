using System.Drawing;
using System.Windows.Forms;

namespace Library_Management_System
{
    partial class Return_Books
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.return_btn = new System.Windows.Forms.Button();
            this.IDBook_txt = new System.Windows.Forms.TextBox();
            this.iduser_txt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(173, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(170, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID Book";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.return_btn);
            this.panel1.Controls.Add(this.IDBook_txt);
            this.panel1.Controls.Add(this.iduser_txt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(90, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 380);
            this.panel1.TabIndex = 1;
            // 
            // return_btn
            // 
            this.return_btn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.return_btn.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.return_btn.ForeColor = System.Drawing.Color.Black;
            this.return_btn.Location = new System.Drawing.Point(282, 233);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(104, 36);
            this.return_btn.TabIndex = 15;
            this.return_btn.Text = "Return";
            this.return_btn.UseVisualStyleBackColor = false;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // IDBook_txt
            // 
            this.IDBook_txt.Location = new System.Drawing.Point(265, 173);
            this.IDBook_txt.Name = "IDBook_txt";
            this.IDBook_txt.Size = new System.Drawing.Size(156, 20);
            this.IDBook_txt.TabIndex = 10;
            // 
            // iduser_txt
            // 
            this.iduser_txt.Location = new System.Drawing.Point(265, 120);
            this.iduser_txt.Name = "iduser_txt";
            this.iduser_txt.Size = new System.Drawing.Size(156, 20);
            this.iduser_txt.TabIndex = 6;
            this.iduser_txt.TextChanged += new System.EventHandler(this.iduser_txt_TextChanged);
            // 
            // Return_Books
            // 
            this.AcceptButton = this.return_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(814, 434);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Return_Books";
            this.Text = "Return_Books";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.TextBox IDBook_txt;
        private System.Windows.Forms.TextBox iduser_txt;
        private Label label4;
        private Label label1;
        private Label label2;
    }
}