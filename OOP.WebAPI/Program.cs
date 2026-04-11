using OOP.Domain.SOLID.ISP;
using OOP.Domain.SOLID.LSP;
using OOP.Domain.SOLID.OCP;
using OOP.Domain.SOLID.SRP;
using OOP.Domain.SOLID.DIP;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//SRP
builder.Services.AddScoped<InvoiceCreate>();
builder.Services.AddScoped<InvoicePrint>();

//OCP
builder.Services.AddScoped<RazorPayGateway>();

//LSP
builder.Services.AddScoped<FixedDiscount>();
builder.Services.AddScoped<NoDiscount>();

//ISP
builder.Services.AddScoped<EaseBuzzGateway>();

//DIP
builder.Services.AddScoped<IDIPPaymentGateway, HDFCSmartGateway>();

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
