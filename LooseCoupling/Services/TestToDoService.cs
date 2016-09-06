using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LooseCoupling.Models;

namespace LooseCoupling.Services
{
    public class TestToDoService : IToDoService
    {
        public Task<IEnumerable<ToDo>> GetAll()
        {
            List<ToDo> todos = new List<ToDo>()
            {
                new ToDo() { Id = 1, Title = "Wash your car", Completed = false },
                new ToDo() { Id = 2, Title = "Cleen your room", Completed = true },
                new ToDo() { Id = 3, Title = "Write a blog post", Completed = false }
            };
            return new Task<IEnumerable<ToDo>>(() => todos);
        }
    }
}
