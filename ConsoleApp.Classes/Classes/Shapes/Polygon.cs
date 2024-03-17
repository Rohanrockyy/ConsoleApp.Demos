using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Classes.Classes.Shapes;

public abstract class Polygon
{
    public double Width { get; set; } //instead of set if we use init,it allows to set value one time and cant change after that
    public abstract double area();  //abstract doesn't have implementation and it requires derived class to put implementation

   /*public virtual string GetShapeName()
    {
        throw new NotImplementedException();
    }*/
}

