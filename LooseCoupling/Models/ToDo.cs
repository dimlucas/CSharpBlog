using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooseCoupling.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string  Title { get; set; }
        public bool Completed { get; set; }

        public override string ToString()
        {
            string completed = Completed ? "COMPLETE" : "INCOMPLETE";
            return String.Format("{0}. {1} {2}", Id, Title, completed);
        }
    }
}

