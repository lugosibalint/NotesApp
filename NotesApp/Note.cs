using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NotesApp
{
    public abstract class Note
    {
        public Note(string user, string name)
        {
            this.id = Guid.NewGuid();
            this.user = user;
            this.name = name;
            this.content = string.Empty;
        }

        public Note(Guid id, string user, string name, string content)
        {
            this.id = id;
            this.user = user;
            this.name = name;
            this.content = content;
        }

        public Guid id { get; set; }
        public string user { get; set; }
        public string name { get; set; }
        public string content { get; set; }
        public abstract string ToTXT();
    }
}
