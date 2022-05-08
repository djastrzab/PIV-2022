using lab5;


Console.WriteLine("hello world");

var context = new MyDbContext();

context.Database.EnsureCreated();

context.Clients.Add(
    new Client
    {
        Name = "Jan Kowalski"
    }
    );
context.SaveChanges();
