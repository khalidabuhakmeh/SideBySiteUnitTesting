using Xunit;

namespace SideDish;

public partial class Calculator
{
    [Fact]
    public void Can_Add_2_and_2()
    {
        var calculator = new Calculator();
        Assert.Equal(4, calculator.Add(2, 2));
    }
}