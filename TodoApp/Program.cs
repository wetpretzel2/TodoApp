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
                        // logic to add a new appointment
                        break;
                    case 2:
                        // logic to add a new job
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
    }
}
