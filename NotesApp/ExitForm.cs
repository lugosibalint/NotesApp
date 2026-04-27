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
    public partial class ExitForm : BaseForm
    {
        public ExitForm()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

    }
}
