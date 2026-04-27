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
    public partial class AuthForm : BaseForm
    {
        public AuthForm()
        {
            InitializeComponent();
            ImportUsers();
        }
        public User u { get; set; }
        List<User> users = new List<User>();
        private void ImportUsers()
        {
            if (File.Exists("users.txt"))
            {
                StreamReader sr = new StreamReader("users.txt");
                while (!sr.EndOfStream)
                {
                    string[] s = sr.ReadLine().Split('\t');
                    User u = new User(s[0], s[1], s[2]);
                    users.Add(u);
                }
                sr.Close();
            }
            
        }
        private void btn_register_Click(object sender, EventArgs e)
        {
            if (tb_regName.Text != "" && tb_regUsername.Text != "" && tb_regPassword.Text != "")
            {
                int i = 0;
                bool talal = false;
                while (!talal && i < users.Count)
                {
                    if (tb_regUsername.Text == users[i].username)
                    {
                        talal = true;
                    }
                    else
                    {
                        i++;
                    }
                }

                if (!talal)
                {
                    if (tb_regUsername.Text.Length > 2)
                    {

                        if (tb_regPassword.Text == tb_regPassword2.Text)
                        {
                            if (tb_regPassword.Text.Length > 4)
                            {
                                User u = new User(tb_regName.Text, tb_regUsername.Text, tb_regPassword.Text);
                                users.Add(u);
                                StreamWriter sw = new StreamWriter("users.txt", true);
                                sw.WriteLine(u.ToString());
                                sw.Close();
                                MessageBox.Show("Registration succesful!", "Succes");
                            }
                            else
                            {
                                ShowErrorMessage("Password is too short!");
                            }
                        }
                        else
                        {
                            ShowErrorMessage("Passwords do not match!");
                        }
                    }
                    else
                    {
                        ShowErrorMessage("Username is too short!");
                    }
                }
                else
                {
                    ShowErrorMessage("This username is already taken!");
                }
            }
            else
            {
                ShowErrorMessage("Missing data!");
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tb_logUsername.Text != "" && tb_logPassword.Text != "")
            {
                int i = 0;
                bool talal = false;
                while (!talal && i < users.Count)
                {
                    if (tb_logUsername.Text == users[i].username)
                    {
                        talal = true;
                    }
                    else
                    {
                        i++;
                    }
                }

                if (talal)
                {
                    if (users[i].password == tb_logPassword.Text)
                    {
                        this.u = users[i];
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        
                    }
                    else
                    {
                        ShowErrorMessage("Wrong password!");
                    }
                }
                else
                {
                    ShowErrorMessage("Wrong username!");
                }
            }
            else
            {
                ShowErrorMessage("Missing data!");
            }
        }

        private void AuthForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("remembered.txt");
            if (cb_rem.Checked)
            {
                sw.WriteLine($"{tb_logUsername.Text};{tb_logPassword.Text}");
            }
            else
            {
                sw.WriteLine("none");
            }
            sw.Close();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("remembered.txt"))
            {
                StreamReader sr = new StreamReader("remembered.txt");
                string line = sr.ReadLine();
                if (line != "none")
                {
                    string[] splitted = line.Split(';');
                    tb_logUsername.Text = splitted[0];
                    tb_logPassword.Text = splitted[1];
                    cb_rem.Checked = true;
                }
                sr.Close();
            }
        }
    }
}
