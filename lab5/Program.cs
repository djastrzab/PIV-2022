using Microsoft.EntityFrameworkCore;
using lab5;



Console.WriteLine("hello world");

var context = new MyDbContext();

context.Database.EnsureCreated();

/*
context.Clients.Add(
    new Client
    {
        Name = "Jan Kowalski"
    }
    );

var myClient = new Client()
{
    Name = "Paweł Kowalski"
};

myClient.Orders.Add(new Order()
{
    Price = 10
});

context.Clients.Add(myClient);
*/

foreach (var item in context.Clients.Include(x=> x.Orders).ToList())
{
    Console.WriteLine(item.Name);
}


context.SaveChanges();
