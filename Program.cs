var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/GetCliente/", () => Results.Ok(new Cliente("Tiago", "tiago@gmail.com", 20)));

app.Run();
