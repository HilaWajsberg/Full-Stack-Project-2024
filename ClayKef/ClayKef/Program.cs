using DataAccessLayer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

DBActions actions = new DBActions(builder.Configuration);
var connString = actions.GetConnectionString("ClayKefDB");


app.MapGet("/", () => "Hello World!");

app.Run();
