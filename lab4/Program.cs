using lab4;

var context = new MyDbContext();

var client = new Client()
{
    Name = "Franciszek Kowalski",
    Adress = "Szeroka Bielsko",
    Balance = 150

};

context.Clients.Add(client);

context.SaveChanges();

var result = context.Clients
    .Where(Client => Client.Balance == 0)
    .ToArray();

foreach(var item in result)
{
    Console.WriteLine(item.Name);
}