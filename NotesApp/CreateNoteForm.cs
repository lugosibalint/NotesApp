using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class CreateNoteForm : BaseForm
    {
        public CreateNoteForm()
        {
            InitializeComponent();
            cb_types.DataSource = Enum.GetValues(typeof(NoteType));
        }
        public string name { get; set; }
        public NoteType type { get; set; }


        private void btn_create_Click(object sender, EventArgs e)
        {
            if (tb_notename.Text != "" && cb_types.SelectedIndex > -1)
            {
                if (cb_types.SelectedItem is NoteType t)
                {
                    type = t;
                    name = tb_notename.Text;
                    DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
            else
            {
                ShowErrorMessage("Missing data!");
            }


        }
    }
}
