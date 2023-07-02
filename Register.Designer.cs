using System.Drawing;
using System.Windows.Forms;

namespace Library_Management_System
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.signup_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.typ_txt = new System.Windows.Forms.ComboBox();
            this.adr_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Usernametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.headerpanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.headerpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(349, 436);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // signup_btn
            // 
            this.signup_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signup_btn.BackColor = System.Drawing.Color.Blue;
            this.signup_btn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signup_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signup_btn.Location = new System.Drawing.Point(124, 390);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(126, 37);
            this.signup_btn.TabIndex = 76;
            this.signup_btn.Text = "Sign Up";
            this.signup_btn.UseVisualStyleBackColor = false;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(37, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 18);
            this.label8.TabIndex = 75;
            this.label8.Text = "Type :";
            // 
            // typ_txt
            // 
            this.typ_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typ_txt.FormattingEnabled = true;
            this.typ_txt.Items.AddRange(new object[] {
            "Student",
            "Librarian"});
            this.typ_txt.Location = new System.Drawing.Point(140, 344);
            this.typ_txt.Name = "typ_txt";
            this.typ_txt.Size = new System.Drawing.Size(145, 21);
            this.typ_txt.TabIndex = 74;
            // 
            // adr_txt
            // 
            this.adr_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adr_txt.Location = new System.Drawing.Point(140, 285);
            this.adr_txt.Name = "adr_txt";
            this.adr_txt.Size = new System.Drawing.Size(145, 20);
            this.adr_txt.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(34, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 18);
            this.label7.TabIndex = 72;
            this.label7.Text = "Address :";
            // 
            // phone_txt
            // 
            this.phone_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phone_txt.Location = new System.Drawing.Point(140, 232);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(145, 20);
            this.phone_txt.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(32, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 70;
            this.label6.Text = "Phone :";
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Passwordtxt.Location = new System.Drawing.Point(140, 177);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.PasswordChar = '*';
            this.Passwordtxt.Size = new System.Drawing.Size(145, 20);
            this.Passwordtxt.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(21, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 68;
            this.label5.Text = "Password :";
            // 
            // email_txt
            // 
            this.email_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.email_txt.Location = new System.Drawing.Point(140, 135);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(145, 20);
            this.email_txt.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(32, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 66;
            this.label4.Text = "Email :";
            // 
            // Usernametxt
            // 
            this.Usernametxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Usernametxt.Location = new System.Drawing.Point(140, 86);
            this.Usernametxt.Name = "Usernametxt";
            this.Usernametxt.Size = new System.Drawing.Size(145, 20);
            this.Usernametxt.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 64;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(77, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 23);
            this.label1.TabIndex = 63;
            this.label1.Text = "Create an account";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FloralWhite;
            this.label9.Location = new System.Drawing.Point(420, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(359, 31);
            this.label9.TabIndex = 1;
            this.label9.Text = "Library Management System";
            // 
            // headerpanel
            // 
            this.headerpanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.headerpanel.Controls.Add(this.label9);
            this.headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpanel.Location = new System.Drawing.Point(0, 0);
            this.headerpanel.Margin = new System.Windows.Forms.Padding(2);
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.Size = new System.Drawing.Size(1029, 49);
            this.headerpanel.TabIndex = 77;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::Library_Management_System.Properties.Resources.HOW_DO_YOU_DESIGN_A_LIBRARY_MANAGEMENT_SYSTEM_min1;
            this.ClientSize = new System.Drawing.Size(1029, 533);
            this.Controls.Add(this.headerpanel);
            this.Controls.Add(this.signup_btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.typ_txt);
            this.Controls.Add(this.adr_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Usernametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Register";
            this.Text = "Sign Up";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.headerpanel.ResumeLayout(false);
            this.headerpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private Button signup_btn;
        private Label label8;
        private ComboBox typ_txt;
        private TextBox adr_txt;
        private Label label7;
        private TextBox phone_txt;
        private Label label6;
        private TextBox Passwordtxt;
        private Label label5;
        private TextBox email_txt;
        private Label label4;
        private TextBox Usernametxt;
        private Label label2;
        private Label label1;
        private Label label9;
        private Panel headerpanel;
    }
}