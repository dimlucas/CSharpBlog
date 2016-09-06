using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LooseCoupling.Models;

namespace LooseCoupling.Services
{
    public interface IToDoService
    {
        Task<IEnumerable<ToDo>> GetAll();
    }
}
