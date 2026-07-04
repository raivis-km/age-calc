var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<CalculatorService>();

var app = builder.Build();

app.MapGet("/add", (decimal a, decimal b, CalculatorService calculator) => calculator.Add(a, b));
app.MapGet("/subtract", (decimal a, decimal b, CalculatorService calculator) => calculator.Subtract(a, b));
app.MapGet("/multiply", (decimal a, decimal b, CalculatorService calculator) => calculator.Multiply(a, b));
app.MapGet("/divide", (decimal a, decimal b, CalculatorService calculator) => calculator.Divide(a, b));

app.Run();