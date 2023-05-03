using AutoMapper;
using Bll;
using Dal;
using Entity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IProductBll, ProductBll>();
builder.Services.AddScoped<IProductDal, ProductDal>();
builder.Services.AddScoped<IOrderBll, OrderBll>();
builder.Services.AddScoped<IOrderDal,OrderDal>();
builder.Services.AddDbContext<Delivery>();

var mapconfig = new MapperConfiguration(x =>
{
    x.AddProfile(new MapperProfile());
});
IMapper map = mapconfig.CreateMapper();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
