using lab4;

var context = new MyDbContext();

var result = context.Clients.ToList();