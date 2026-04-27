using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp
{
    public class User
    {
        public User(string name, string username, string password)
        {
            this.name = name;
            this.username = username;
            this.password = password;
        }

        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public override string ToString()
        {
            return $"{name}\t{username}\t{password}";
        }
        
    }
    
}
