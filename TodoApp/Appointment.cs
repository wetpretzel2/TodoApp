using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    public class Appointment : Task
    {
        public string Location { get; set; }
        public Appointment(string title, DateTime dueDate, string location): base(title, dueDate)
        {
            Location = location;
        }
        public override void Display();
    }
}