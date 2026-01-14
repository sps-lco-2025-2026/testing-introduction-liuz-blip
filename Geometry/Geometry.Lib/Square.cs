namespace Geometry.Lib;

public class Square
{
    readonly double _side;

    public Square(double side)
    {
        _side = side;
    }

    public double Area => _side * _side;
    public double Perimeter => _side * 4;

}
