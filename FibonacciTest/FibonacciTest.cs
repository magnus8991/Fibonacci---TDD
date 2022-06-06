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

    [TestMethod]
    public void WhenPositionIsTwoReturnOne()
    {
        var value = FibonacciMethod.GetValue(2);
        Assert.AreEqual(1,value);
    }

    [TestMethod]
    public void WhenPositionIsThreeReturnTwo()
    {
        var value = FibonacciMethod.GetValue(3);
        Assert.AreEqual(2,value);
    }

    [TestMethod]
    public void WhenPositionIsFourReturnThree()
    {
        var value = FibonacciMethod.GetValue(4);
        Assert.AreEqual(3,value);
    }

    [TestMethod]
    public void WhenPositionIsFiveReturnFive()
    {
        var value = FibonacciMethod.GetValue(5);
        Assert.AreEqual(5,value);
    }

    [TestMethod]
    public void WhenPositionIsEightReturnTwentyOne()
    {
        var value = FibonacciMethod.GetValue(8);
        Assert.AreEqual(21,value);
    }

    [TestMethod]
    public void WhenPositionIsTwelveReturnOneHundredFortyFour()
    {
        var value = FibonacciMethod.GetValue(12);
        Assert.AreEqual(144,value);
    }
}