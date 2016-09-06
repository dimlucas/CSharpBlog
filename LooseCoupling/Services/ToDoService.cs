using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using LooseCoupling.Models;
using Newtonsoft.Json;

namespace LooseCoupling.Services
{
    public class ToDoService : IToDoService
    {
        public async Task<IEnumerable<ToDo>> GetAll()
        {
            using (HttpClient http = new HttpClient())
            {
                var json = await http.GetStringAsync(url);
                return JsonConvert.DeserializeObject<IEnumerable<ToDo>>(json);
            }   
        }

        protected readonly string url = "https://jsonplaceholder.typicode.com/todos";
    }
}
