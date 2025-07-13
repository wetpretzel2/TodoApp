namespace TodoApp
{
    public class Appointment : Task
    {
        public string Location { get; set; }
        public Appointment(string title, DateTime dueDate, string location) : base(title, dueDate)
        {
            Location = location;
        }
        public override void Display();
    }
}