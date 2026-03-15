namespace Geometry.Lib;



public class Triangle
{
    private double sideA, sideB, sideC, angleA, angleB, angleC;
    public double SideA
    {
        get { return sideA; }
        set { if (value > 0) { sideA = value; } }
    }
    public double SideB
    {
        get { return sideB; }
        set { if (value > 0) { sideB = value; } }
    }
    public double SideC
    {
        get { return sideC; }
        set { if (value > 0) { sideC = value; } }
    }
    public double AngleA
    {
        get { return angleA; }
        set { if (value > 0) { angleA = value; } }
    }
    public double AngleB
    {
        get { return angleB; }
        set { if (value > 0) { angleB = value; } }
    }
    public double AngleC
    {
        get { return angleC; }
        set { if (value > 0) { angleC = value; } }
    }



    public Triangle(double a, double b, double c)
    {
        SideA = a;
        SideB = b;
        SideC = c;
    }

    public bool IsValid()
    {
        return SideA + SideB > SideC && SideA + SideC > SideB && SideB + SideC > SideA;
    }

    public bool IsRightAngled()
    {
        if (AngleA == 90 || AngleB == 90 || AngleC == 90) { return true; }
        else if (SideA * SideA + SideB * SideB == SideC * SideC || SideA * SideA + SideC * SideC == SideB * SideB || SideB * SideB + SideC * SideC == SideA * SideA) { return true; }
        else { return false; }
    }

    public bool IsEquilateral()
    {
        return SideA == SideB && SideA == SideC;
    }

    public bool IsIsosceles()
    {
        if (SideA == SideB && SideA != SideC) { return true; }
        else if (SideA == SideC && SideA != SideB) { return true; }
        else if (SideB == SideC && SideB != SideA) { return true; }
        return false;
    }

    public double Area()
    {
        double s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public List<double> ThreeSides()
    {
        return [SideA, SideB, SideC];
    }

    public List<double> ThreeAngles()
    {
        return [AngleA, AngleB, AngleC];
    }

    public bool IsCongruent(Triangle tri)
    {
        // SSS
        if (SideA == tri.SideA && SideB == tri.SideB && SideC == tri.SideC) { return true; }

        // SAS
        if (SideA == tri.SideA && SideB == tri.SideB && AngleC == tri.AngleC) { return true; }
        else if (SideA == tri.SideA && SideC == tri.SideC && AngleB == tri.AngleB) { return true; }
        else if (SideB == tri.SideB && SideC == tri.SideC && AngleA == tri.AngleA) { return true; }

        // AAS
        if (AngleA == tri.AngleA && AngleB == tri.AngleB && SideA == tri.SideA) { return true; }
        else if (AngleA == tri.AngleA && AngleB == tri.AngleB && SideB == tri.SideB) { return true; }
        else if (AngleA == tri.AngleA && AngleC == tri.AngleC && SideA == tri.SideA) { return true; }
        else if (AngleA == tri.AngleA && AngleC == tri.AngleC && SideA == tri.SideC) { return true; }
        else if (AngleB == tri.AngleA && AngleC == tri.AngleC && SideB == tri.SideB) { return true; }
        else if (AngleB == tri.AngleA && AngleC == tri.AngleC && SideC == tri.SideC) { return true; }

        // ASA
        if (AngleA == tri.AngleA && AngleB == tri.AngleB && SideC == tri.SideC) { return true; }
        else if (AngleA == tri.AngleA && AngleC == tri.AngleC && SideB == tri.SideB) { return true; }
        else if (AngleB == tri.AngleB && AngleC == tri.AngleC && SideA == tri.SideA) { return true; }

        return false;
    }

}
