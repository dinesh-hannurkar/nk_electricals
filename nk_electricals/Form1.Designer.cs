namespace nk_electricals
{
    partial class Form1
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
            this.main_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.login_panel = new System.Windows.Forms.Panel();
            this.lbl_logintitle = new System.Windows.Forms.Label();
            this.bottom_line = new System.Windows.Forms.Panel();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.header = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.main_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.login_panel.SuspendLayout();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.main_panel.Controls.Add(this.panel1);
            this.main_panel.Controls.Add(this.header);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1096, 624);
            this.main_panel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.login_panel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 579);
            this.panel1.TabIndex = 1;
            // 
            // login_panel
            // 
            this.login_panel.BackColor = System.Drawing.Color.White;
            this.login_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_panel.Controls.Add(this.label2);
            this.login_panel.Controls.Add(this.lbl_logintitle);
            this.login_panel.Controls.Add(this.bottom_line);
            this.login_panel.Controls.Add(this.lbl_password);
            this.login_panel.Controls.Add(this.lbl_username);
            this.login_panel.Controls.Add(this.btn_login);
            this.login_panel.Controls.Add(this.txt_password);
            this.login_panel.Controls.Add(this.txt_username);
            this.login_panel.Location = new System.Drawing.Point(365, 63);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(363, 451);
            this.login_panel.TabIndex = 0;
            // 
            // lbl_logintitle
            // 
            this.lbl_logintitle.AutoSize = true;
            this.lbl_logintitle.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logintitle.Location = new System.Drawing.Point(53, 21);
            this.lbl_logintitle.Name = "lbl_logintitle";
            this.lbl_logintitle.Size = new System.Drawing.Size(116, 37);
            this.lbl_logintitle.TabIndex = 5;
            this.lbl_logintitle.Text = "SIGN IN";
            // 
            // bottom_line
            // 
            this.bottom_line.Location = new System.Drawing.Point(58, 17);
            this.bottom_line.Name = "bottom_line";
            this.bottom_line.Size = new System.Drawing.Size(247, 51);
            this.bottom_line.TabIndex = 6;
            this.bottom_line.Paint += new System.Windows.Forms.PaintEventHandler(this.bottom_line_Paint);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(56, 183);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(79, 21);
            this.lbl_password.TabIndex = 4;
            this.lbl_password.Text = "Password";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(56, 119);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(83, 21);
            this.lbl_username.TabIndex = 3;
            this.lbl_username.Text = "Username";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(60, 368);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(245, 32);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "SIGN IN";
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(58, 207);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(245, 29);
            this.txt_password.TabIndex = 1;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(59, 143);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(245, 29);
            this.txt_username.TabIndex = 0;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(80)))), ((int)(((byte)(141)))));
            this.header.Controls.Add(this.minimize);
            this.header.Controls.Add(this.label1);
            this.header.Controls.Add(this.close);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1094, 43);
            this.header.TabIndex = 0;
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.BackgroundImage = global::nk_electricals.Properties.Resources.icons8_negative_25px;
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Location = new System.Drawing.Point(1029, 10);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(22, 22);
            this.minimize.TabIndex = 1;
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "NK ELECTRICALS";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImage = global::nk_electricals.Properties.Resources.close2;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Location = new System.Drawing.Point(1060, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(23, 23);
            this.close.TabIndex = 2;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 624);
            this.Controls.Add(this.main_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.main_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.login_panel.ResumeLayout(false);
            this.login_panel.PerformLayout();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel login_panel;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_logintitle;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel bottom_line;
        private System.Windows.Forms.Label label2;
    }
}

