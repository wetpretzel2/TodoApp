using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    public abstract class Task
    {
        public string TaskTitle { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }

        public abstract void Display();

    }
}
