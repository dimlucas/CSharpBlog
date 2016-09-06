using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LooseCoupling.Services;
using LooseCoupling.Models;

namespace LooseCoupling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Console.WriteLine("*** Data from the Web ***");
                //ToDos(new ToDoService());
                Console.WriteLine("*** Local Data ***");
                ToDos(new TestToDoService());
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("An exception was thrown: " + e.Message);
            }
        }


        static async void ToDos(IToDoService service)
        {
            LooselyCoupledToDos vm = new LooselyCoupledToDos(service);
            var todos = await vm.All();
            foreach(var todo in todos)
            {
                Console.WriteLine(todo);
            }
        }

    }
}
