namespace TodoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();

            int userChoice = 0;

            while (userChoice != 5)
            {
                // Menu display
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("\t \tToDo ");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Please select an option: ");
                Console.WriteLine("1. Add new appointment");
                Console.WriteLine("2. Add a new job");
                Console.WriteLine("3. Add a new shopping list item");
                Console.WriteLine("4. Display all tasks");
                Console.WriteLine("5. Exit");

                if (!int.TryParse(Console.ReadLine(), out userChoice))
                {
                    userChoice = 0;
                }
                Console.WriteLine();

                //switch statement to handle user input
                switch (userChoice)
                {
                    case 1:
                        AddAppointment(tasks);
                        break;
                    case 2:
                        AddJob(tasks);
                        break;
                    case 3:
                        // logic to add a new shopping list item
                        break;
                    case 4:
                        //logic to display all tasks
                        break;
                    case 5:
                        //logic to exit the application
                        break;
                    default:
                        Console.WriteLine("Invalid input! Please try again.");
                        break;
                }
            }
        }
        private static void AddAppointment(List<Task> tasks)
        {
            Console.WriteLine("Please enter the appointment title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Please enter the due date (yyyy-mm-dd): ");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime dueDate))
            {
                Console.WriteLine("Invalid date format. Please try again.");
                return;
            }
            Console.WriteLine("Appointment location: ");
            string location = Console.ReadLine();
            tasks.Add(new Appointment(title, dueDate, location));
        }

        private static void AddJob(List<Task> tasks)
        {
            Console.WriteLine("Please enter the job title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Please enter the due date (yyyy-mm-dd): ");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime dueDate))
            {
                Console.WriteLine("Invalid date format. Please try again.");
                return;
            }
            Console.WriteLine("Enter days between repeats:  ");
            if (!int.TryParse(Console.ReadLine(), out int days))
            {
                Console.WriteLine("Invalid input for recurrence interval. Please try again.");
                return;
            }
            TimeSpan recurrenceInterval = TimeSpan.FromDays(days);
            if (recurrenceInterval.TotalDays <= 0)
            {
                Console.WriteLine("Recurrence interval must be greater than zero. Please try again.");
                return;
            }
            tasks.Add(new Chore(title, dueDate, recurrenceInterval));
        }
    }
}
