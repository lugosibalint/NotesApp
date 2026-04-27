using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp
{
    internal class TaskNote : Note
    {
        public TaskNote(string user, string name) : base(user, name)
        {
            this.done = false;
        }

        public TaskNote(Guid id, string user, string name, string content, bool done) : base(id, user, name, content)
        {
            this.done = done;
        }

        public bool done { get; set; }

        public override string ToTXT()
        {
            return $"{id.ToString()};{user};{name};{this.GetType().ToString()};{content};{done.ToString()}";
        }
    }
}
