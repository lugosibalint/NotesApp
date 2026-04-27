namespace NotesApp
{
    partial class CreateNoteForm
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
            this.btn_create = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_notename = new System.Windows.Forms.TextBox();
            this.cb_types = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(118, 303);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(261, 49);
            this.btn_create.TabIndex = 9;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // tb_notename
            // 
            this.tb_notename.Location = new System.Drawing.Point(118, 25);
            this.tb_notename.Name = "tb_notename";
            this.tb_notename.Size = new System.Drawing.Size(430, 26);
            this.tb_notename.TabIndex = 6;
            // 
            // cb_types
            // 
            this.cb_types.FormattingEnabled = true;
            this.cb_types.Location = new System.Drawing.Point(118, 172);
            this.cb_types.Name = "cb_types";
            this.cb_types.Size = new System.Drawing.Size(156, 28);
            this.cb_types.TabIndex = 5;
            // 
            // CreateNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 397);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_notename);
            this.Controls.Add(this.cb_types);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateNoteForm";
            this.Text = "Create a new note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_notename;
        private System.Windows.Forms.ComboBox cb_types;
    }
}