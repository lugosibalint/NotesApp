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
    public partial class RenameNoteForm : BaseForm
    {
        public RenameNoteForm(string oldname)
        {
            this.oldname = oldname;
            InitializeComponent();
            tb_name.Text = oldname;
        }

        public string newname { get; set; }
        private string oldname { get; set; }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (tb_name.Text != string.Empty)
            {
                newname = tb_name.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else 
            {
                ShowErrorMessage("Missing data");
            }
        }
    }
}
