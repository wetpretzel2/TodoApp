namespace TodoApp
{
    internal class Chore : Task
    {
        public TimeSpan RecurrenceInterval { get; set; }

        public Chore(string title, DateTime dueDate, TimeSpan recurrenceInterval) : base(title, dueDate)
        {
            RecurrenceInterval = recurrenceInterval;
        }
        public override void Display()
        {
            Console.WriteLine($"Chore: {TaskTitle}, Due: {DueDate}, Recurrence: {RecurrenceInterval}, Completed: {IsCompleted}");
        }
    }
}

