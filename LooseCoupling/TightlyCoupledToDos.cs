using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LooseCoupling.Models;
using LooseCoupling.Services;

namespace LooseCoupling
{
    public class TightlyCoupledToDos
    {
        public TightlyCoupledToDos()
        {
            _service = new ToDoService();
        }

        public async Task<IEnumerable<ToDo>> All()
        {
            IEnumerable<ToDo> todos = await _service.GetAll();
            return todos.ToList<ToDo>();
        }

        private ToDoService _service;
    }
}
