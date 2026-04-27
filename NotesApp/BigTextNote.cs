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
        public BigTextNote(string user, string name) : base(user, name)
        {
        }

        public BigTextNote(Guid id, string user, string name, string content) : base(id, user, name, content)
        {
        }
        public override string ToTXT()
        {
            return $"{id.ToString()};{user};{name};{this.GetType().ToString()};{content}";
        }
    }
}
