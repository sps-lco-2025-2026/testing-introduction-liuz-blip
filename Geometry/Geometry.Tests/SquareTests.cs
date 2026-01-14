namespace Geometry.Tests;

// add new project reference 
using Geometry.Lib;

// use the test tab on the right 
[TestClass]
public sealed class SquareTests
{
    [TestMethod]
    public void TestOnce()
    {
        Square sq = new(5.8);
        Assert.AreEqual(sq.Area, 33.64);
        Assert.AreEqual(sq.Perimeter, 23.2);
    }   

    [TestMethod]
    [DataRow(5.0, 25.0, 20.0)]
    [DataRow(15.0, 225.0, 60.0)]
    [DataRow(10.0, 100.0, 40.0)]
    public void TestMany(double d, double a, double p)
    {
        Square sq = new(d);
        Assert.AreEqual(sq.Area, a);
        Assert.AreEqual(sq.Perimeter, p);
    }   
}
