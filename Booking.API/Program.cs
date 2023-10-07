using Booking.API.AutoMappers;
using Booking.Context.Contracts;
using Booking.Repositories.Contracts.ReadInterfaces;
using Booking.Repositories.ReadRepositories;
using Booking.Servises.AutoMappers;
using Booking.Servises.Contracts.ReadServicesContracts;
using Booking.Servises.ReadServices;
using Booking.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IBookingRoomService, BookingRoomService>();
builder.Services.AddScoped<IBookingRoomReadRepository, BookingRoomReadRepository>();

builder.Services.AddScoped<IGuestService, GuestService>();
builder.Services.AddScoped<IGuestReadRepository, GuestReadRepository>();

builder.Services.AddScoped<IRoomService, RoomService>();
builder.Services.AddScoped<IRoomReadRepository, RoomReadRepository>();

builder.Services.AddScoped<IServiceService, ServiceService>();
builder.Services.AddScoped<IServiceReadRepository, ServiceReadRepository>();

builder.Services.AddScoped<IServiceRenderedService, ServiceRenderedService>();
builder.Services.AddScoped<IServiceRenderedReadRepository, ServiceRenderedReadRepository>();

builder.Services.AddScoped<ITypeRoomService, TypeRoomService>();
builder.Services.AddScoped<ITypeRoomReadRepository, TypeRoomReadRepository>();

builder.Services.AddSingleton<IBookingContext, BookingContext>();

builder.Services.AddAutoMapper(typeof(APIMappers), typeof(ServiceMapper));

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
