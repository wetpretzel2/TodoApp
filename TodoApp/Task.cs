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
