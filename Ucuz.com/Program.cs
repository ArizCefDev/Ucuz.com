using AutoMapper;
using Business.Abstract;
using Business.Concrete;
using Business.Congig;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// DB Context
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(opt=>
opt.UseSqlServer(builder.Configuration.GetConnectionString("DataConnection")
));

//DTO with AutoMapper
var mappingConfig = new MapperConfiguration(mc =>
{
	mc.AddProfile(new MapperProfile());
});
builder.Services.AddSingleton(mappingConfig.CreateMapper());

//Services
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IAboutService, AboutService>();
builder.Services.AddScoped<IMessageService, MessageService>();
builder.Services.AddScoped<IContactService, ContactService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();
