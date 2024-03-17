using ConsoleApp.Classes.Classes.Shapes;
using ConsoleApp.Classes.Interfaces;

namespace ConsoleApp.Classes;

public class Cuboid : Polygon , I3DShape, I2DShape
{
    public Cuboid(double l,double h,double w)
    {
        Length = l;
        Width = w;
        Height = h;
    }
    public double Length {  get; set; }
    public double Height {  get; set; }
    public override double area()
    {
        return 2*(Length*Height) + (Length*Width) + (Height*Width);
    }

    public double Perimeter()
    {
        return 4*(Length+Width+Height);
    }

    public double Volume()
    {
        return (Length * Width * Height);
    }
}
