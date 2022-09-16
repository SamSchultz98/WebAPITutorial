using Microsoft.EntityFrameworkCore;
using WebAPITutorial.Models;

var builder = WebApplication.CreateBuilder(args);      //This gives you the builder

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(x => {
    string ConnectionKey = "Prod";  //This is the key for the production string connect (cloud)
#if DEBUG  //This is the way to make the connection string change automatically depending if you're in debug or release mode
ConnectionKey = "Dev";  //This is grayed out because it's not being used
#endif 
    x.UseSqlServer(builder.Configuration.GetConnectionString(ConnectionKey)); });    //This database connection/instance. Make sure you put the actual key name
//For your first migration/Update put the correct keyword for the connection
builder.Services.AddCors();     //Need this in order to UseCors to open up the security 

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors(x =>            //The following opens the secruity all the way open
{
    x.AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod();
});


app.UseAuthorization();

app.MapControllers();

using var scope = app.Services
                     .GetRequiredService<IServiceScopeFactory>()
                     .CreateScope();
//The above updates the server as soon as the application runs. You still have to do the migration
app.Run();
