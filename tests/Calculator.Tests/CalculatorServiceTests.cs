// tests/Calculator.Tests/CalculatorServiceTests.cs
public class CalculatorServiceTests
{
    private readonly CalculatorService _svc = new();

    [Fact]
    public void Add_ReturnsSum()
    {
        var result = _svc.Add(2, 3);
        Assert.Equal(5, result);
    }
}
