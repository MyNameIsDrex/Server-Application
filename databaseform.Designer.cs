namespace Server_Application
{
    partial class databaseform
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
            upload_panel = new Panel();
            upload_button = new Button();
            filepath_label = new Label();
            browse_button = new Button();
            filepath_textbox = new TextBox();
            fetch_panel = new Panel();
            label2 = new Label();
            from_textbox = new TextBox();
            button1 = new Button();
            select_label = new Label();
            select_textbox = new TextBox();
            uploadfile_dialog = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            editToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem1 = new ToolStripMenuItem();
            upload_panel.SuspendLayout();
            fetch_panel.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // upload_panel
            // 
            upload_panel.Controls.Add(upload_button);
            upload_panel.Controls.Add(filepath_label);
            upload_panel.Controls.Add(browse_button);
            upload_panel.Controls.Add(filepath_textbox);
            upload_panel.Location = new Point(12, 46);
            upload_panel.Name = "upload_panel";
            upload_panel.Size = new Size(324, 103);
            upload_panel.TabIndex = 0;
            // 
            // upload_button
            // 
            upload_button.Location = new Point(5, 66);
            upload_button.Name = "upload_button";
            upload_button.Size = new Size(94, 29);
            upload_button.TabIndex = 3;
            upload_button.Text = "Upload";
            upload_button.UseVisualStyleBackColor = true;
            upload_button.Click += upload_button_Click;
            // 
            // filepath_label
            // 
            filepath_label.AutoSize = true;
            filepath_label.Location = new Point(5, 5);
            filepath_label.Margin = new Padding(5);
            filepath_label.Name = "filepath_label";
            filepath_label.Size = new Size(155, 20);
            filepath_label.TabIndex = 2;
            filepath_label.Text = "Enter filepath for data";
            // 
            // browse_button
            // 
            browse_button.Location = new Point(252, 33);
            browse_button.Name = "browse_button";
            browse_button.Size = new Size(67, 29);
            browse_button.TabIndex = 1;
            browse_button.Text = "Browse";
            browse_button.UseVisualStyleBackColor = true;
            browse_button.Click += browse_button_Click;
            // 
            // filepath_textbox
            // 
            filepath_textbox.Location = new Point(5, 33);
            filepath_textbox.Name = "filepath_textbox";
            filepath_textbox.Size = new Size(241, 27);
            filepath_textbox.TabIndex = 0;
            // 
            // fetch_panel
            // 
            fetch_panel.Controls.Add(label2);
            fetch_panel.Controls.Add(from_textbox);
            fetch_panel.Controls.Add(button1);
            fetch_panel.Controls.Add(select_label);
            fetch_panel.Controls.Add(select_textbox);
            fetch_panel.Location = new Point(12, 152);
            fetch_panel.Name = "fetch_panel";
            fetch_panel.Size = new Size(324, 238);
            fetch_panel.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 68);
            label2.Margin = new Padding(5);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 5;
            label2.Text = "From (string)";
            // 
            // from_textbox
            // 
            from_textbox.Location = new Point(5, 96);
            from_textbox.Name = "from_textbox";
            from_textbox.Size = new Size(241, 27);
            from_textbox.TabIndex = 4;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.Location = new Point(5, 201);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Upload";
            button1.UseVisualStyleBackColor = true;
            // 
            // select_label
            // 
            select_label.AutoSize = true;
            select_label.Location = new Point(5, 5);
            select_label.Margin = new Padding(5);
            select_label.Name = "select_label";
            select_label.Size = new Size(100, 20);
            select_label.TabIndex = 2;
            select_label.Text = "Select (string)";
            // 
            // select_textbox
            // 
            select_textbox.Location = new Point(5, 33);
            select_textbox.Name = "select_textbox";
            select_textbox.Size = new Size(241, 27);
            select_textbox.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, editToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, exitToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(46, 24);
            editToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(224, 26);
            newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(224, 26);
            openToolStripMenuItem.Text = "Open";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem1
            // 
            editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            editToolStripMenuItem1.Size = new Size(49, 24);
            editToolStripMenuItem1.Text = "Edit";
            // 
            // databaseform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(fetch_panel);
            Controls.Add(upload_panel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "databaseform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Database";
            Load += database_Load;
            upload_panel.ResumeLayout(false);
            upload_panel.PerformLayout();
            fetch_panel.ResumeLayout(false);
            fetch_panel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel upload_panel;
        private Button browse_button;
        private TextBox filepath_textbox;
        private Label filepath_label;
        private Button upload_button;
        private Panel fetch_panel;
        private Button button1;
        private Label select_label;
        private TextBox select_textbox;
        private Label label2;
        private TextBox from_textbox;
        private OpenFileDialog uploadfile_dialog;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem1;
    }
}