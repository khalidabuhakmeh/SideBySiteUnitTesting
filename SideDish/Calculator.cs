using System.Numerics;

namespace SideDish;

public partial class Calculator
{
    public T Add<T>(T left, T right)
        where T : INumber<T>
    {
        return left + right;
    }
}
