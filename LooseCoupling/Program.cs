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
                if(_testMode)
                {
                    Console.WriteLine("Test Data:");
                    ToDos(new TestToDoService());
                }
                else
                {
                    Console.WriteLine("Real Data:");
                    ToDos(new ToDoService());
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("An exception was thrown: " + e.Message);
            }
            Console.ReadLine();
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


        private static bool _testMode = false;
    }
}
