using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    public abstract class Task
    {
        public string TaskTitle { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
        protected Task(string title, DateTime dueDate)
        {
            TaskTitle = title;
            DueDate = dueDate;
            IsCompleted = false;
        }

        public abstract void Display();

    }
}
