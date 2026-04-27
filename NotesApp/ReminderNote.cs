using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp
{
    internal class ReminderNote : Note
    {
        public ReminderNote(string user, string name, NoteType type) : base(user, name, type)
        {
            this.date = DateTime.Now;
        }

        public ReminderNote(Guid id, string user, string name, NoteType type, string content, DateTime date) : base(id, user, name, type, content)
        {
            this.date = date;
        }

        public DateTime date { get; set; }
        public override string ToTXT()
        {
            return $"{id.ToString()};{user};{name};{type.ToString()};{content};{date.ToString()}";
        }
    }
}
