using DAL.DALApi;
using DAL.DALImplementation;
using DAL.Models;
using DAL;
using Microsoft.EntityFrameworkCore;
using BLL;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<BLLManager>();

/*DBActions actions = new DBActions(builder.Configuration);
var connString = actions.GetConnectionString("ClayKefDB");
builder.Services.AddDbContext<ClayKefContext>(opt => opt.UseSqlServer(connString));
builder.Services.AddScoped<ICourseRepo, CourseRepo>();
*/
builder.Services.AddControllers();
var app = builder.Build();
app.MapControllers();
app.MapGet("/", () => "Hello World!");

app.Run();
