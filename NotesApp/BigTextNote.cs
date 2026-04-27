using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp
{
    internal class BigTextNote : Note
    {
        public BigTextNote(string user, string name, NoteType type) : base(user, name, type)
        {
        }

        public BigTextNote(Guid id, string user, string name, NoteType type, string content) : base(id, user, name, type, content)
        {
        }
        public override string ToTXT()
        {
            return $"{id.ToString()};{user};{name};{type.ToString()};{content}";
        }
    }
}
