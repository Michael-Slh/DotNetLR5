using Lab05;
using Lab05.Logic;

var registry = new OrdersRegistry();

registry.AddOrder(new Order { Name = "  ", Surname = "Salikhov" });
registry.AddOrder(new Order { Name = null, Surname = "Salikhov" });
registry.AddOrder(new Order { Name = "Michael", Surname = "Salikhov" });
registry.AddOrder(new Order { Name = "Michael123", Surname = "Salikhov" });

foreach (var order in registry.GetAllOrders())
{
    Console.WriteLine(order);
}
Console.WriteLine();

registry.ConsiderAll();

foreach (var order in registry.GetAllOrders())
{
    Console.WriteLine(order);
}
Console.WriteLine();

registry.ClearFinishedOrders();

foreach (var order in registry.GetAllOrders())
{
    Console.WriteLine(order);
}
Console.WriteLine();

registry.ConsiderAll();

foreach (var order in registry.GetAllOrders())
{
    Console.WriteLine(order);
}
Console.WriteLine();