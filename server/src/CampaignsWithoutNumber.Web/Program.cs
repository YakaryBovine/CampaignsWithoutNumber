var builder = WebApplication.CreateBuilder(args);

builder.Services
  .AddSwaggerGen()
  .AddInfrastructure()
  .AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
  app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();