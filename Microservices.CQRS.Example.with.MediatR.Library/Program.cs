using Microservices.CQRS.Example.with.MediatR.Library.Manual_CQRS.Handlers.CommandHandlers;
using Microservices.CQRS.Example.with.MediatR.Library.Manual_CQRS.Handlers.QueryHandlers;
using Microservices.CQRS.Example.with.MediatR.Library.Modals;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

#region Manual CQRS
builder.Services.AddSingleton<CreateProductCommandHandler>()
                .AddSingleton<DeleteProductCommandHandler>()
                .AddSingleton<GetAllProductQueryHandler>()
                .AddSingleton<GetByIdProductQueryHandler>();
#endregion
#region MediatR CQRS
builder.Services.AddMediatR(conf => conf.RegisterServicesFromAssembly
    (typeof(ApplicationDBContext).Assembly));
#endregion
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
