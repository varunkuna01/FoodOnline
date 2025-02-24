using System.Data;
using OnlineFood1;

Operations operations = new Operations();
OrderContext context = new OrderContext();
Order order1 = new Order();
bool exit=false;
//hello new

while(!exit)
{
    Console.WriteLine("Select the operation to perform :");
    Console.WriteLine("1.Insert");
    Console.WriteLine("2.Update");
    Console.WriteLine("3.Delete");
    Console.WriteLine("4.Read");
    Console.WriteLine("5.Exit");
    int num = int.Parse(Console.ReadLine());

    switch (num)

        ///
    {
        case 1: //Insert
            Console.WriteLine("Enter order ID :");
            order1.OrderID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Customer ID :");
            order1.CustomerID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Restaurant ID :");
            order1.RestaurantID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Status :");
            order1.Status = Console.ReadLine();

            Console.WriteLine("Enter Total Amount :");
            order1.TotalAmount = decimal.Parse(Console.ReadLine());

            operations.InsertOrder(order1);

            break;

        case 2: //Update
            Console.WriteLine("Enter order ID :");
            order1.OrderID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Customer ID :");
            order1.CustomerID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Restaurant ID :");
            order1.RestaurantID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Status :");
            order1.Status = Console.ReadLine();

            Console.WriteLine("Enter Total Amount :");
            order1.TotalAmount = decimal.Parse(Console.ReadLine());

            operations.UpdateOrder(order1);
            break;

        case 3: //Delete
            Console.WriteLine("Enter order ID :");
            int ID = int.Parse(Console.ReadLine());

            operations. DeleteOrder(ID);

            break;

        case 4: //Read

            List<Order> list = operations.ViewOrder();
            foreach (Order p in list)
            {
                Console.WriteLine($"{p.OrderID} {p.CustomerID} {p.RestaurantID} {p.Status} {p.TotalAmount}");
            }
            break;

        case 5: //Exit
            return;

    }
}













