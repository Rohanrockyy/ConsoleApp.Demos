using ConsoleApp.Classes.Classes.Shapes;

namespace ConsoleApp.Classes;

public class Square : Polygon
{
    public Square(double width) 
    {
        Width = width;
    }

    public override double area()
    {
        //Math.Pow(Width, 2); same as width * width
        return Width*Width;
    }
}
