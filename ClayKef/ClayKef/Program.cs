using DAL.DALApi;
using DAL.DALImplementation;
using DAL.Models;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

DBActions actions = new DBActions(builder.Configuration);
var connString = actions.GetConnectionString("ClayKefDB");
builder.Services.AddDbContext<ClayKefContext>(opt => opt.UseSqlServer(connString));
builder.Services.AddScoped<ICourseRepo, CourseRepo>();


app.MapGet("/", () => "Hello World!");

app.Run();
