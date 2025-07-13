namespace TodoApp
{
    internal class ShoppingItem : Task
    {
        public int Quantity { get; set; }

        public ShoppingItem(string title, DateTime dueDate, int quantity) : base(title, dueDate)
        {
            Quantity = quantity;
        }
        public override void Display()
        {
            Console.WriteLine($"Shopping Item: {TaskTitle}, Due: {DueDate}, Quantity: {Quantity}");

        }
    }
}
