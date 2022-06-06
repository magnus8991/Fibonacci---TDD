using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fibonacci;

namespace FibonacciTest;

[TestClass]
public class FibonacciTest
{
    private FibonacciMethod FibonacciMethod { get; set; }
    
    public FibonacciTest()
    {
        FibonacciMethod = new FibonacciMethod();
    }

    [TestMethod]
    public void WhenPositionIsZeroReturnZero()
    {
        var value = FibonacciMethod.GetValue(0);
        Assert.AreEqual(0,value);
    }

    [TestMethod]
    public void WhenPositionIsOneReturnOne()
    {
        var value = FibonacciMethod.GetValue(1);
        Assert.AreEqual(1,value);
    }
}