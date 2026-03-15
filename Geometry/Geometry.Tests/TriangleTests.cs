using Microsoft.VisualStudio.TestTools.UnitTesting;
using Geometry.Lib; // This is crucial! It tells the test to use your code.

namespace Geometry.Tests;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void TestIsEquilateral_Valid()
    {
        Triangle tri = new Triangle(5, 5, 5);
        bool result = tri.IsEquilateral();
        Assert.IsTrue(result, "A triangle with sides 5,5,5 should be equilateral.");
    }

    [TestMethod]
    public void TestIsImpossibleTriangle()
    {
        Triangle tri = new Triangle(1, 2, 10);
        bool result = tri.IsValid();
        Assert.IsFalse(result, "A 1, 2, 10 triangle should be invalid.");
    }

    [TestMethod]
    public void TestIsCongruent()
    {
        Triangle tri1 = new Triangle(3,4,5);
        Triangle tri2 = new Triangle(3,4,5);

        tri1.IsCongruent(tri2);
    }

    [TestMethod]
    public void TestIsIsosceles()
    {
        Triangle tri = new Triangle(2,2,2);
        tri.IsIsosceles();
    }

    [TestMethod]
    public void TestIsValid()
    {
        Triangle tri = new Triangle(1,1,2);
        tri.IsValid();
    }
}
