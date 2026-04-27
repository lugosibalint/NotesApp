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
    public partial class NotesForm : BaseForm
    {
        public NotesForm()
        {
            InitializeComponent();
        }
        public User u { get; set; }
        List<Note> notes = new List<Note>();
        private List<Note> GetCurrentUserNotes()
        {
            return notes.Where(j => j.user == u.username).ToList();
        }
        public void ImportData()
        {
            if (File.Exists("data.txt"))
            {
                notes.Clear();
                StreamReader sr = new StreamReader("data.txt");
                while (!sr.EndOfStream)
                {
                    string[] s = sr.ReadLine().Split(';');
                    Note n = null;
                    switch ((NoteType)Enum.Parse(typeof(NoteType), s[3]))
                    {
                        case NoteType.BigText:
                            n = new BigTextNote(Guid.Parse(s[0]), s[1], s[2], (NoteType)Enum.Parse(typeof(NoteType), s[3]), s[4]);
                            break;
                        case NoteType.Task:
                            n = new TaskNote(Guid.Parse(s[0]), s[1], s[2], (NoteType)Enum.Parse(typeof(NoteType), s[3]), s[4], bool.Parse(s[5]));
                            break;
                        case NoteType.Reminder:
                            n = new ReminderNote(Guid.Parse(s[0]), s[1], s[2], (NoteType)Enum.Parse(typeof(NoteType), s[3]), s[4], DateTime.Parse(s[5]));
                            break;
                    }
                    notes.Add(n);
                    
                }
                sr.Close();
                BindingSource bs = new BindingSource();
                bs.DataSource = GetCurrentUserNotes();
                lb_notes.DataSource = bs;
                lb_notes.DisplayMember = "name";
            }
        }
        public void ExportData()
        {
            StreamWriter sw = new StreamWriter("data.txt");
            foreach (var item in notes)
            {
                sw.WriteLine($"{item.ToTXT()}");
            }
            sw.Close();
        }
        private void ReloadData()
        {
            ExportData();
            ImportData();
        }
        private void LogIn()
        {
            AuthForm af = new AuthForm();
            if (af.ShowDialog() == DialogResult.OK)
            {
                u = af.u;
                ImportData();
                cb_loggedIn.Checked = true;
            }
            else
            {
                this.Close();
            }
        }
        private void LogoutOrExit(FormClosingEventArgs e)
        {
            DialogResult result;
            if (e == null)
            {
                result = DialogResult.Yes;
            }
            else
            {
                if (cb_loggedIn.Checked)
                {
                    ExitForm ef = new ExitForm();
                    result = ef.ShowDialog();
                }
                else
                {
                    result = DialogResult.No;
                }
            }

            switch (result)
            {
                case DialogResult.Yes:
                    if (e != null) e.Cancel = true;
                    cb_loggedIn.Checked = false;
                    LogIn();
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }

        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReloadData();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lb_notes.SelectedIndex > -1)
            {
                if (lb_notes.SelectedItem is Note selected)
                {
                    DialogResult response = MessageBox.Show($"Are you sure to delete: '{selected.name}'?", "Delete", MessageBoxButtons.YesNo);
                    if (response == DialogResult.Yes)
                    {
                        notes.Remove(selected);
                        ReloadData();
                    }
                }    
            }
            else
            {
                ShowErrorMessage("There are no note selected");
            }
        }
        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lb_notes.SelectedIndex > -1)
            {
                
                if (lb_notes.SelectedItem is Note selected)
                {
                    RenameNoteForm rnf = new RenameNoteForm(selected.name);
                    if (rnf.ShowDialog() == DialogResult.OK)
                    {
                        selected.name = rnf.newname;
                        ReloadData();
                    }
                }
            }
            else
            {
                ShowErrorMessage("There are no note selected");
            }

        }
        private void openNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (lb_notes.SelectedIndex > -1)
            {

                if (lb_notes.SelectedItem is Note selected)
                {
                    OpenForm of = new OpenForm(selected);
                    if (of.ShowDialog() == DialogResult.OK)
                    {
                        selected.content = of.n.content;
                        ReloadData();
                    }
                }
            }
            else
            {
                ShowErrorMessage("There are no note selected");
            }

        }

        private void noteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNoteForm cnf = new CreateNoteForm();
            if (cnf.ShowDialog() == DialogResult.OK)
            {
                Note n = null;
                switch (cnf.type)
                {
                    case NoteType.BigText:
                        n = new BigTextNote(u.username, cnf.name, NoteType.BigText);
                        break;
                    case NoteType.Task:
                        n = new TaskNote(u.username, cnf.name, NoteType.Task);
                        break;
                    case NoteType.Reminder:
                        n = new ReminderNote(u.username, cnf.name, NoteType.Reminder);
                        break;
                }

                notes.Add(n);
                ReloadData();
            }
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogoutOrExit(null);
        }
        private void cb_loggedIn_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_loggedIn.Checked)
            {
                cb_loggedIn.Visible = true;
                l_logged.Visible = true;
                l_yournotes.Visible = true;
                tb_loggedname.Visible = true;
                tb_loggedname.Text = u.name;
                tb_content.Visible = true;
                lb_notes.Visible = true;
            }
            else
            {
                cb_loggedIn.Visible = false;
                l_logged.Visible = false;
                l_yournotes.Visible=false;
                tb_loggedname.Visible = false;
                tb_loggedname.Text = string.Empty;
                tb_content.Visible = false;
                tb_content.Text = string.Empty;
                lb_notes.DataSource = null;
                lb_notes.Visible = false;
                notes.Clear();
            }
        }

        private void NotesForm_Load(object sender, EventArgs e)
        {
            LogIn();
        }

        private void NotesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogoutOrExit(e);
        }

        private void lb_notes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lb_notes.SelectedItem is Note selected)
            {
                tb_content.Text = $"{selected.type.ToString()}->\t{selected.content.Replace("###NEWLINE###", "\t")}";
            }
            
        }
    }
}

