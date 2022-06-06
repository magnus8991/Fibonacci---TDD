namespace Fibonacci;

public class FibonacciMethod
{
    public int GetValue(int position)
    {
        var previousValue = 0;
        var currentValue = 0;
        for (var i = 0; i <= position; i++)
        {
            var doublePreviousValue = previousValue;
            previousValue = currentValue;
            currentValue = i == 1 ? i : doublePreviousValue + previousValue;
        }
        return currentValue;
    }
}