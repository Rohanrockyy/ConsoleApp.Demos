using ConsoleApp.Classes.Interfaces;

namespace ConsoleApp.Classes.Classes.Shapes;

public class Rectangle : Polygon, I2DShape //public class child class:Parent class,Interface name 
{
    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public double Length { get; set; }
    public override double area()  //override allows us to put in our own implementation
    {
        return Width * Length;
    }

    public double Perimeter()
    {
        throw new NotImplementedException();
    }
    /*public override string GetShapeName()  //as we called rec in main program 
        //override is used to modify or extend the abstract or virtual implementation of inherited class
    {
        return base.GetShapeName();
    }*/
}
