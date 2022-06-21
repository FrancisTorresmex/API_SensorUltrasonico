var builder = WebApplication.CreateBuilder(args);

string policy = "MyPolicy";

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers(); //añadir uso de controladores

//Agregar CORS
builder.Services.AddCors(options => {
    options.AddPolicy(name: policy, builder =>
    {
        builder.WithOrigins("*"); //todos los sitios se permiten OJO aqui, porque define la seguirdad, en este caso se permite la conexión de x lugar
        builder.WithHeaders("*"); //permite el http post osea insercciones de datos de cualquier sitio
        builder.WithMethods("*"); //permite el http put y delete de cualquier sitio
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseCors(policy); //usar CORS

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
