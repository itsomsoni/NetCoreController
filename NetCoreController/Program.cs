using NetCoreController.Controllers;

var builder = WebApplication.CreateBuilder(args);

///builder.Services.AddTransient<HomeController>();
builder.Services.AddControllers(); // will detect all controller.

var app = builder.Build();

//app.UseRouting();

app.MapControllers(); // will call UseRouting & UseEndpoints auto.

//app.UseEndpoints(endpoints =>
//{
//    _ = endpoints.MapControllers();
//});

app.Run();
