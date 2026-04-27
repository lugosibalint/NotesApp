namespace NotesApp
{
    partial class NotesForm
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
            this.lb_notes = new System.Windows.Forms.ListBox();
            this.l_yournotes = new System.Windows.Forms.Label();
            this.l_logged = new System.Windows.Forms.Label();
            this.tb_loggedname = new System.Windows.Forms.TextBox();
            this.cb_loggedIn = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_content = new System.Windows.Forms.TextBox();
            this.l_type = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_notes
            // 
            this.lb_notes.FormattingEnabled = true;
            this.lb_notes.ItemHeight = 28;
            this.lb_notes.Location = new System.Drawing.Point(137, 244);
            this.lb_notes.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.lb_notes.Name = "lb_notes";
            this.lb_notes.Size = new System.Drawing.Size(903, 228);
            this.lb_notes.TabIndex = 1;
            this.lb_notes.Visible = false;
            this.lb_notes.SelectedValueChanged += new System.EventHandler(this.lb_notes_SelectedValueChanged);
            // 
            // l_yournotes
            // 
            this.l_yournotes.AutoSize = true;
            this.l_yournotes.Location = new System.Drawing.Point(132, 185);
            this.l_yournotes.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.l_yournotes.Name = "l_yournotes";
            this.l_yournotes.Size = new System.Drawing.Size(108, 28);
            this.l_yournotes.TabIndex = 0;
            this.l_yournotes.Text = "Your Notes";
            // 
            // l_logged
            // 
            this.l_logged.AutoSize = true;
            this.l_logged.Location = new System.Drawing.Point(48, 84);
            this.l_logged.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_logged.Name = "l_logged";
            this.l_logged.Size = new System.Drawing.Size(127, 28);
            this.l_logged.TabIndex = 0;
            this.l_logged.Text = "Logged in as:";
            this.l_logged.Visible = false;
            // 
            // tb_loggedname
            // 
            this.tb_loggedname.Location = new System.Drawing.Point(193, 78);
            this.tb_loggedname.Margin = new System.Windows.Forms.Padding(4);
            this.tb_loggedname.Name = "tb_loggedname";
            this.tb_loggedname.ReadOnly = true;
            this.tb_loggedname.Size = new System.Drawing.Size(190, 34);
            this.tb_loggedname.TabIndex = 0;
            this.tb_loggedname.Visible = false;
            // 
            // cb_loggedIn
            // 
            this.cb_loggedIn.AutoSize = true;
            this.cb_loggedIn.Enabled = false;
            this.cb_loggedIn.Location = new System.Drawing.Point(420, 84);
            this.cb_loggedIn.Margin = new System.Windows.Forms.Padding(4);
            this.cb_loggedIn.Name = "cb_loggedIn";
            this.cb_loggedIn.Size = new System.Drawing.Size(22, 21);
            this.cb_loggedIn.TabIndex = 0;
            this.cb_loggedIn.UseVisualStyleBackColor = true;
            this.cb_loggedIn.CheckedChanged += new System.EventHandler(this.cb_loggedIn_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1178, 35);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openNoteToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 30);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noteToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.newToolStripMenuItem.Text = "New";
            // 
            // noteToolStripMenuItem
            // 
            this.noteToolStripMenuItem.Name = "noteToolStripMenuItem";
            this.noteToolStripMenuItem.Size = new System.Drawing.Size(153, 34);
            this.noteToolStripMenuItem.Text = "Note";
            this.noteToolStripMenuItem.Click += new System.EventHandler(this.noteToolStripMenuItem_Click);
            // 
            // openNoteToolStripMenuItem
            // 
            this.openNoteToolStripMenuItem.Name = "openNoteToolStripMenuItem";
            this.openNoteToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.openNoteToolStripMenuItem.Text = "Open Note";
            this.openNoteToolStripMenuItem.Click += new System.EventHandler(this.openNoteToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(86, 30);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(85, 30);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // tb_content
            // 
            this.tb_content.Location = new System.Drawing.Point(137, 547);
            this.tb_content.Margin = new System.Windows.Forms.Padding(4);
            this.tb_content.Name = "tb_content";
            this.tb_content.ReadOnly = true;
            this.tb_content.Size = new System.Drawing.Size(903, 34);
            this.tb_content.TabIndex = 9;
            this.tb_content.Visible = false;
            // 
            // l_type
            // 
            this.l_type.AutoSize = true;
            this.l_type.Location = new System.Drawing.Point(132, 515);
            this.l_type.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.l_type.Name = "l_type";
            this.l_type.Size = new System.Drawing.Size(53, 28);
            this.l_type.TabIndex = 10;
            this.l_type.Text = "Type";
            // 
            // NotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.l_type);
            this.Controls.Add(this.tb_content);
            this.Controls.Add(this.cb_loggedIn);
            this.Controls.Add(this.tb_loggedname);
            this.Controls.Add(this.l_logged);
            this.Controls.Add(this.l_yournotes);
            this.Controls.Add(this.lb_notes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "NotesForm";
            this.Text = "Notes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NotesForm_FormClosing);
            this.Load += new System.EventHandler(this.NotesForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lb_notes;
        private System.Windows.Forms.Label l_yournotes;
        private System.Windows.Forms.Label l_logged;
        private System.Windows.Forms.TextBox tb_loggedname;
        private System.Windows.Forms.CheckBox cb_loggedIn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.TextBox tb_content;
        private System.Windows.Forms.Label l_type;
    }
}