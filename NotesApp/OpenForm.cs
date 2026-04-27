using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class OpenForm : BaseForm
    {
        public OpenForm(Note n)
        {
            this.n = n;
            InitializeComponent();
            Text = n.name;
        }

        public Note n { get; set; }
        private bool isDirty { get; set; }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ApplyTypeSettings(true);
            isDirty = false;
            this.Close();
        }

        private void OpenForm_Load(object sender, EventArgs e)
        {
            ApplyTypeSettings(false);
            tb_content.Text = n.content.Replace("###NEWLINE###", "\r\n");
            tb_content.TextChanged += (s, ev) => isDirty = true;
            cb_done.CheckedChanged += (s, ev) => isDirty = true;
            dtp_term.ValueChanged += (s, ev) => isDirty = true;
        }

        private void OpenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isDirty && DialogResult != DialogResult.OK)
            {
                var result = MessageBox.Show("There are unsaved changes. Save them?", "Exit", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    ApplyTypeSettings(true);
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
        private void ApplyTypeSettings(bool isSaving)
        {
            switch (n)
            {
                case TaskNote tn:
                    if (!isSaving)
                    {
                        cb_done.Visible = true; 
                        cb_done.Checked = tn.done;
                    }
                    else
                    {
                        tn.done = cb_done.Checked;
                    }
                    break;

                case ReminderNote rn:
                    if (!isSaving)
                    {
                        dtp_term.Visible = true; 
                        dtp_term.Value = rn.date;
                    }
                    else
                    {
                        rn.date = dtp_term.Value;
                    }
                    break;

                case BigTextNote bn:
                    if (!isSaving) tb_content.Height = 400;
                    break;
            }
            if (isSaving)
            {
                n.content = tb_content.Text.Replace("\r\n", "###NEWLINE###").Replace("\n", "###NEWLINE###");
            }
            else
            {
                tb_content.Text = n.content.Replace("###NEWLINE###", "\r\n");
            }
        }
    }
}
