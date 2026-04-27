using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp
{
    internal class TaskNote : Note
    {
        public TaskNote(string user, string name, NoteType type) : base(user, name, type)
        {
            this.done = false;
        }

        public TaskNote(Guid id, string user, string name, NoteType type, string content, bool done) : base(id, user, name, type, content)
        {
            this.done = done;
        }

        public bool done { get; set; }

        public override string ToTXT()
        {
            return $"{id.ToString()};{user};{name};{type.ToString()};{content};{done.ToString()}";
        }
    }
}
