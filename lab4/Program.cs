using lab4;
using lab4.NorthwindContext;

var context = new MyDbContext();

context.Database.BeginTransaction();

var client = new Client()
{
    Name = "Franciszek Kowalski",
    Adress = "Szeroka Bielsko",
    Balance = 150

};

context.Clients.Add(client);

context.SaveChanges();
context.Database.CommitTransaction();
var result = context.Clients
    .Where(Client => Client.Balance == 0)
    .ToArray();

foreach(var item in result)
{
    Console.WriteLine(item.Name);
}

var ctx = new NorthwindContext();
var regions = ctx.Regions.ToArray();
foreach(var region in regions)
    Console.WriteLine(region.RegionDescription);