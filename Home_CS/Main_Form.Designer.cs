namespace Home_CS
{
    partial class main_form
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
            this.submit_button = new System.Windows.Forms.Button();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.login_groupbox = new System.Windows.Forms.GroupBox();
            this.login_showpassword_checkbox = new System.Windows.Forms.CheckBox();
            this.register_button = new System.Windows.Forms.Button();
            this.register_groupbox = new System.Windows.Forms.GroupBox();
            this.cancel_register_button = new System.Windows.Forms.Button();
            this.submit_register_button = new System.Windows.Forms.Button();
            this.show_password_checbox2 = new System.Windows.Forms.CheckBox();
            this.show_password_checbox1 = new System.Windows.Forms.CheckBox();
            this.register_age_textbox = new System.Windows.Forms.TextBox();
            this.register_password_textbox2 = new System.Windows.Forms.TextBox();
            this.register_firstname_textbox = new System.Windows.Forms.TextBox();
            this.register_lastname_textbox = new System.Windows.Forms.TextBox();
            this.register_password_textbox1 = new System.Windows.Forms.TextBox();
            this.register_username_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.register_username_label = new System.Windows.Forms.Label();
            this.login_groupbox.SuspendLayout();
            this.register_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // submit_button
            // 
            this.submit_button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.submit_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submit_button.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.submit_button.Location = new System.Drawing.Point(149, 318);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(105, 42);
            this.submit_button.TabIndex = 4;
            this.submit_button.Text = "Login";
            this.submit_button.UseVisualStyleBackColor = false;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // password_textbox
            // 
            this.password_textbox.BackColor = System.Drawing.SystemColors.Window;
            this.password_textbox.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.password_textbox.Location = new System.Drawing.Point(260, 220);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(337, 33);
            this.password_textbox.TabIndex = 3;
            this.password_textbox.TextChanged += new System.EventHandler(this.password_textbox_TextChanged);
            // 
            // username_textbox
            // 
            this.username_textbox.BackColor = System.Drawing.SystemColors.Window;
            this.username_textbox.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_textbox.Location = new System.Drawing.Point(260, 172);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(337, 33);
            this.username_textbox.TabIndex = 2;
            this.username_textbox.TextChanged += new System.EventHandler(this.username_textbox_TextChanged);
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(144, 220);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(73, 25);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "Password";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(144, 172);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(73, 25);
            this.username_label.TabIndex = 0;
            this.username_label.Text = "Username";
            this.username_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // login_groupbox
            // 
            this.login_groupbox.Controls.Add(this.login_showpassword_checkbox);
            this.login_groupbox.Controls.Add(this.register_button);
            this.login_groupbox.Controls.Add(this.submit_button);
            this.login_groupbox.Controls.Add(this.username_label);
            this.login_groupbox.Controls.Add(this.password_textbox);
            this.login_groupbox.Controls.Add(this.password_label);
            this.login_groupbox.Controls.Add(this.username_textbox);
            this.login_groupbox.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_groupbox.ForeColor = System.Drawing.SystemColors.Info;
            this.login_groupbox.Location = new System.Drawing.Point(12, 14);
            this.login_groupbox.Name = "login_groupbox";
            this.login_groupbox.Size = new System.Drawing.Size(681, 493);
            this.login_groupbox.TabIndex = 1;
            this.login_groupbox.TabStop = false;
            this.login_groupbox.Text = "Login";
            this.login_groupbox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // login_showpassword_checkbox
            // 
            this.login_showpassword_checkbox.AutoSize = true;
            this.login_showpassword_checkbox.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_showpassword_checkbox.Location = new System.Drawing.Point(150, 258);
            this.login_showpassword_checkbox.Name = "login_showpassword_checkbox";
            this.login_showpassword_checkbox.Size = new System.Drawing.Size(130, 29);
            this.login_showpassword_checkbox.TabIndex = 6;
            this.login_showpassword_checkbox.Text = "Show Password";
            this.login_showpassword_checkbox.UseVisualStyleBackColor = false;
            this.login_showpassword_checkbox.CheckedChanged += new System.EventHandler(this.login_showpassword_checkbox_CheckedChanged);
            // 
            // register_button
            // 
            this.register_button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.register_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.register_button.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.register_button.Location = new System.Drawing.Point(260, 318);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(105, 42);
            this.register_button.TabIndex = 5;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = false;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // register_groupbox
            // 
            this.register_groupbox.Controls.Add(this.cancel_register_button);
            this.register_groupbox.Controls.Add(this.submit_register_button);
            this.register_groupbox.Controls.Add(this.show_password_checbox2);
            this.register_groupbox.Controls.Add(this.show_password_checbox1);
            this.register_groupbox.Controls.Add(this.register_age_textbox);
            this.register_groupbox.Controls.Add(this.register_password_textbox2);
            this.register_groupbox.Controls.Add(this.register_firstname_textbox);
            this.register_groupbox.Controls.Add(this.register_lastname_textbox);
            this.register_groupbox.Controls.Add(this.register_password_textbox1);
            this.register_groupbox.Controls.Add(this.register_username_textbox);
            this.register_groupbox.Controls.Add(this.label5);
            this.register_groupbox.Controls.Add(this.label4);
            this.register_groupbox.Controls.Add(this.label3);
            this.register_groupbox.Controls.Add(this.label2);
            this.register_groupbox.Controls.Add(this.label1);
            this.register_groupbox.Controls.Add(this.register_username_label);
            this.register_groupbox.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_groupbox.ForeColor = System.Drawing.SystemColors.Info;
            this.register_groupbox.Location = new System.Drawing.Point(12, 14);
            this.register_groupbox.Name = "register_groupbox";
            this.register_groupbox.Size = new System.Drawing.Size(681, 493);
            this.register_groupbox.TabIndex = 6;
            this.register_groupbox.TabStop = false;
            this.register_groupbox.Text = "Register";
            // 
            // cancel_register_button
            // 
            this.cancel_register_button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cancel_register_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel_register_button.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_register_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancel_register_button.Location = new System.Drawing.Point(335, 385);
            this.cancel_register_button.Name = "cancel_register_button";
            this.cancel_register_button.Size = new System.Drawing.Size(91, 35);
            this.cancel_register_button.TabIndex = 15;
            this.cancel_register_button.Text = "Cancel";
            this.cancel_register_button.UseVisualStyleBackColor = false;
            this.cancel_register_button.Click += new System.EventHandler(this.cancel_register_button_Click);
            // 
            // submit_register_button
            // 
            this.submit_register_button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.submit_register_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submit_register_button.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_register_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.submit_register_button.Location = new System.Drawing.Point(149, 385);
            this.submit_register_button.Name = "submit_register_button";
            this.submit_register_button.Size = new System.Drawing.Size(91, 35);
            this.submit_register_button.TabIndex = 14;
            this.submit_register_button.Text = "Register";
            this.submit_register_button.UseVisualStyleBackColor = false;
            this.submit_register_button.Click += new System.EventHandler(this.submit_register_button_Click);
            // 
            // show_password_checbox2
            // 
            this.show_password_checbox2.AutoSize = true;
            this.show_password_checbox2.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_password_checbox2.Location = new System.Drawing.Point(389, 223);
            this.show_password_checbox2.Name = "show_password_checbox2";
            this.show_password_checbox2.Size = new System.Drawing.Size(65, 29);
            this.show_password_checbox2.TabIndex = 13;
            this.show_password_checbox2.Text = "Show";
            this.show_password_checbox2.UseVisualStyleBackColor = true;
            this.show_password_checbox2.CheckedChanged += new System.EventHandler(this.show_password_checbox2_CheckedChanged);
            // 
            // show_password_checbox1
            // 
            this.show_password_checbox1.AutoSize = true;
            this.show_password_checbox1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_password_checbox1.Location = new System.Drawing.Point(149, 220);
            this.show_password_checbox1.Name = "show_password_checbox1";
            this.show_password_checbox1.Size = new System.Drawing.Size(65, 29);
            this.show_password_checbox1.TabIndex = 12;
            this.show_password_checbox1.Text = "Show";
            this.show_password_checbox1.UseVisualStyleBackColor = true;
            this.show_password_checbox1.CheckedChanged += new System.EventHandler(this.show_password_checbox1_CheckedChanged);
            // 
            // register_age_textbox
            // 
            this.register_age_textbox.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_age_textbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.register_age_textbox.Location = new System.Drawing.Point(547, 282);
            this.register_age_textbox.Name = "register_age_textbox";
            this.register_age_textbox.Size = new System.Drawing.Size(100, 33);
            this.register_age_textbox.TabIndex = 11;
            // 
            // register_password_textbox2
            // 
            this.register_password_textbox2.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_password_textbox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.register_password_textbox2.Location = new System.Drawing.Point(547, 179);
            this.register_password_textbox2.Name = "register_password_textbox2";
            this.register_password_textbox2.PasswordChar = '*';
            this.register_password_textbox2.Size = new System.Drawing.Size(100, 33);
            this.register_password_textbox2.TabIndex = 10;
            // 
            // register_firstname_textbox
            // 
            this.register_firstname_textbox.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_firstname_textbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.register_firstname_textbox.Location = new System.Drawing.Point(547, 108);
            this.register_firstname_textbox.Name = "register_firstname_textbox";
            this.register_firstname_textbox.Size = new System.Drawing.Size(100, 33);
            this.register_firstname_textbox.TabIndex = 9;
            // 
            // register_lastname_textbox
            // 
            this.register_lastname_textbox.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_lastname_textbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.register_lastname_textbox.Location = new System.Drawing.Point(241, 279);
            this.register_lastname_textbox.Name = "register_lastname_textbox";
            this.register_lastname_textbox.Size = new System.Drawing.Size(100, 33);
            this.register_lastname_textbox.TabIndex = 8;
            // 
            // register_password_textbox1
            // 
            this.register_password_textbox1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_password_textbox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.register_password_textbox1.Location = new System.Drawing.Point(241, 172);
            this.register_password_textbox1.Name = "register_password_textbox1";
            this.register_password_textbox1.PasswordChar = '*';
            this.register_password_textbox1.Size = new System.Drawing.Size(100, 33);
            this.register_password_textbox1.TabIndex = 7;
            // 
            // register_username_textbox
            // 
            this.register_username_textbox.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_username_textbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.register_username_textbox.Location = new System.Drawing.Point(241, 111);
            this.register_username_textbox.Name = "register_username_textbox";
            this.register_username_textbox.Size = new System.Drawing.Size(100, 33);
            this.register_username_textbox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(384, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(384, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(384, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Re-enter Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // register_username_label
            // 
            this.register_username_label.AutoSize = true;
            this.register_username_label.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_username_label.Location = new System.Drawing.Point(144, 111);
            this.register_username_label.Name = "register_username_label";
            this.register_username_label.Size = new System.Drawing.Size(73, 25);
            this.register_username_label.TabIndex = 0;
            this.register_username_label.Text = "Username";
            this.register_username_label.Click += new System.EventHandler(this.register_username_label_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(716, 523);
            this.Controls.Add(this.register_groupbox);
            this.Controls.Add(this.login_groupbox);
            this.Font = new System.Drawing.Font("Adobe Devanagari", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "main_form";
            this.Text = "Home V1.0";
            this.Load += new System.EventHandler(this.Login_Load);
            this.login_groupbox.ResumeLayout(false);
            this.login_groupbox.PerformLayout();
            this.register_groupbox.ResumeLayout(false);
            this.register_groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.GroupBox login_groupbox;
        private System.Windows.Forms.GroupBox register_groupbox;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Label register_username_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox show_password_checbox2;
        private System.Windows.Forms.CheckBox show_password_checbox1;
        private System.Windows.Forms.TextBox register_age_textbox;
        private System.Windows.Forms.TextBox register_password_textbox2;
        private System.Windows.Forms.TextBox register_firstname_textbox;
        private System.Windows.Forms.TextBox register_lastname_textbox;
        private System.Windows.Forms.TextBox register_password_textbox1;
        private System.Windows.Forms.TextBox register_username_textbox;
        private System.Windows.Forms.Button cancel_register_button;
        private System.Windows.Forms.Button submit_register_button;
        private System.Windows.Forms.CheckBox login_showpassword_checkbox;
    }
}

