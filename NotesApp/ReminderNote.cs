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
        public ReminderNote(string user, string name) : base(user, name)
        {
            this.date = DateTime.Now;
        }

        public ReminderNote(Guid id, string user, string name, string content, DateTime date) : base(id, user, name, content)
        {
            this.date = date;
        }

        public DateTime date { get; set; }
        public override string ToTXT()
        {
            return $"{id.ToString()};{user};{name};{this.GetType().ToString()};{content};{date.ToString()}";
        }
    }
}
