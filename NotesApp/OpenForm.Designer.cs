namespace NotesApp
{
    partial class OpenForm
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
            this.tb_content = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.dtp_term = new System.Windows.Forms.DateTimePicker();
            this.cb_done = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tb_content
            // 
            this.tb_content.Location = new System.Drawing.Point(14, 17);
            this.tb_content.Multiline = true;
            this.tb_content.Name = "tb_content";
            this.tb_content.Size = new System.Drawing.Size(775, 353);
            this.tb_content.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(796, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(104, 55);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dtp_term
            // 
            this.dtp_term.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_term.Location = new System.Drawing.Point(213, 455);
            this.dtp_term.Name = "dtp_term";
            this.dtp_term.Size = new System.Drawing.Size(308, 26);
            this.dtp_term.TabIndex = 1;
            this.dtp_term.Visible = false;
            // 
            // cb_done
            // 
            this.cb_done.AutoSize = true;
            this.cb_done.Location = new System.Drawing.Point(14, 457);
            this.cb_done.Name = "cb_done";
            this.cb_done.Size = new System.Drawing.Size(74, 24);
            this.cb_done.TabIndex = 2;
            this.cb_done.Text = "Done";
            this.cb_done.UseVisualStyleBackColor = true;
            this.cb_done.Visible = false;
            // 
            // OpenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 668);
            this.Controls.Add(this.cb_done);
            this.Controls.Add(this.dtp_term);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_content);
            this.Name = "OpenForm";
            this.Text = "Open";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OpenForm_FormClosing);
            this.Load += new System.EventHandler(this.OpenForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_content;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DateTimePicker dtp_term;
        private System.Windows.Forms.CheckBox cb_done;
    }
}