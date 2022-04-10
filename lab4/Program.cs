using lab4;

var context = new MyDbContext();

var client = new Client()
{
    Name = "Jan Kowalski",
    Adress = "Szeroka Bielsko",
    Balance =0

};

context.Clients.Add(client);

context.SaveChanges();

var result = context.Clients.ToList();

foreach(var item in result)
{
    Console.WriteLine(item.Name);
}