using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class ToDo
    {
        //name, startdate, end date, iscompleted => Properties
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Iscompleted { get; set; }
        //functions: create(), edit(), delete(), viewtodos()

        private ToDo[] _todos = new ToDo[10];
        public void ViewToDos()
        {
            foreach (var singleToDo in _todos)
            {
                if(singleToDo != null)
                {
                    Console.WriteLine($"Name: {singleToDo.Name} | " + $"Started on: {singleToDo.StartDate} |" + $"Ends on: {singleToDo.EndDate} |" + $"Is completed on: {singleToDo.Iscompleted}");
                }
               
            }
        }

        public void ViewToDos(string pName)
        {
            foreach (var singleToDo in _todos)
            {
                if (singleToDo.Name == pName)
                {
                    Console.WriteLine($"Name: {singleToDo.Name} | " + $"Started on: {singleToDo.StartDate} |" + $"Ends on: {singleToDo.EndDate} |" + $"Is completed on: {singleToDo.Iscompleted}");

                    break;
                }
            }
        }

        public void Create(int pPosition)
        {
            if (pPosition > 9)
            {
                throw new Exception("Please Enter a value between 0-9");
            }
            _todos[pPosition] = new ToDo() { Name = this.Name, StartDate = this.StartDate, EndDate = this.EndDate, Iscompleted = this.Iscompleted };

            Console.WriteLine("ToDO is created successfully");
        }

        public void Edit()
        {

        }

        public void delete()
        {

        }

    }
}
