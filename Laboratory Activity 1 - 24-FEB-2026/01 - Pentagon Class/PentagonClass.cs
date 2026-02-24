Pentagon p1 = new Pentagon(0);
Pentagon p2 = new Pentagon(5);
Console.WriteLine("Pentagon p1");
p1.Display();
Console.WriteLine("Pentagon p2");
p2.Display();




public class Pentagon
{
    private double side;

    public Pentagon()
    {
        this.side = 0;
    }


    public Pentagon(double side)
    {
        this.side = side;
    }
    public double GetSide(double side)
    {
        return side;
    }
    public double GetPerimeter(double side)
    {
        return 5 * side;
    }

    public double GetArea(double side)
    {
        double factor = 0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5)));
        return factor * Math.Pow(side, 2);
    }

    public void Display()
    {

        Console.WriteLine("------------------------- ");
        Console.WriteLine($"Side length: {GetSide(side):F0}");
        Console.WriteLine($"Perimeter: {GetPerimeter(side):F3}");
        Console.WriteLine($"Area: {GetArea(side):F3}\n");
    }
}

