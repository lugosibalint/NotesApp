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
        public Note(string user, string name, NoteType type)
        {
            this.id = Guid.NewGuid();
            this.user = user;
            this.name = name;
            this.type = type;
            this.content = string.Empty;
        }

        public Note(Guid id, string user, string name, NoteType type, string content)
        {
            this.id = id;
            this.user = user;
            this.name = name;
            this.type = type;
            this.content = content;
        }

        public Guid id { get; set; }
        public string user { get; set; }
        public string name { get; set; }
        public NoteType type { get; set; }
        public string content { get; set; }
        public abstract string ToTXT();
        public string ToListBox()
        {
            return $"{name}\t{type.ToString()}";
        }
    }
}
