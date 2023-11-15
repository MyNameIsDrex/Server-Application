namespace Server_Application
{
    partial class Application
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            username_label = new Label();
            panel1 = new Panel();
            username_input = new TextBox();
            button_login = new Button();
            panel2 = new Panel();
            password_input = new TextBox();
            password_label = new Label();
            signin_checkbox = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.Location = new Point(8, 8);
            username_label.Margin = new Padding(8);
            username_label.Name = "username_label";
            username_label.Size = new Size(75, 20);
            username_label.TabIndex = 0;
            username_label.Text = "Username";
            // 
            // panel1
            // 
            panel1.Controls.Add(username_input);
            panel1.Controls.Add(username_label);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(222, 70);
            panel1.TabIndex = 1;
            // 
            // username_input
            // 
            username_input.Location = new Point(8, 39);
            username_input.MaxLength = 20;
            username_input.Name = "username_input";
            username_input.Size = new Size(194, 27);
            username_input.TabIndex = 1;
            // 
            // button_login
            // 
            button_login.Location = new Point(345, 210);
            button_login.Name = "button_login";
            button_login.Size = new Size(94, 29);
            button_login.TabIndex = 2;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(password_input);
            panel2.Controls.Add(password_label);
            panel2.Location = new Point(12, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(222, 70);
            panel2.TabIndex = 2;
            // 
            // password_input
            // 
            password_input.Location = new Point(8, 39);
            password_input.MaxLength = 30;
            password_input.Name = "password_input";
            password_input.Size = new Size(194, 27);
            password_input.TabIndex = 1;
            password_input.UseSystemPasswordChar = true;
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Location = new Point(8, 8);
            password_label.Margin = new Padding(8);
            password_label.Name = "password_label";
            password_label.Size = new Size(70, 20);
            password_label.TabIndex = 0;
            password_label.Text = "Password";
            // 
            // signin_checkbox
            // 
            signin_checkbox.AutoSize = true;
            signin_checkbox.Location = new Point(20, 164);
            signin_checkbox.Name = "signin_checkbox";
            signin_checkbox.Size = new Size(154, 24);
            signin_checkbox.TabIndex = 3;
            signin_checkbox.Text = "Keep me signed in";
            signin_checkbox.UseVisualStyleBackColor = true;
            // 
            // Application
            // 
            AcceptButton = button_login;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 251);
            Controls.Add(signin_checkbox);
            Controls.Add(panel2);
            Controls.Add(button_login);
            Controls.Add(panel1);
            Name = "Application";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Application";
            Load += Application_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label username_label;
        private Panel panel1;
        private Button button_login;
        private TextBox username_input;
        private Panel panel2;
        private TextBox password_input;
        private Label password_label;
        private CheckBox signin_checkbox;
    }
}