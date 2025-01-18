// See https://aka.ms/new-console-template for more information

using System.Formats.Asn1;
using System.Numerics;

namespace FormasApp { 

public abstract class Shape
{
    public double ancho;
    public double alto;

    protected Shape (double Ancho, double Alto)
    {
        this.ancho = Ancho;
        this.alto = Alto;
    }

    public abstract double CalculateSurface();
}

public class Triangle : Shape
    
{
    public Triangle (double Ancho, double Alto) : base (Ancho, Alto) { }
    public override double CalculateSurface()
    {
        return (ancho * alto) / 2;
    }
}

public class Rectangle : Shape
{
    public Rectangle(double Ancho, double Alto) : base(Ancho, Alto) { } 
    public override double CalculateSurface()
    {
        return ancho * alto; 
    }
}

public class Circle : Shape
{
    public Circle(double radio) : base(radio, radio) {}
    public override double CalculateSurface()
    {
       return Math.PI * (ancho * alto);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape[] formas = new Shape[] {
            new Rectangle(2, 5),
            new Triangle(3, 6),
            new Circle(8)
        };

        double[] areas = new double[formas.Length];

            for (int i = 0; i < areas.Length; i++)
            {
                areas[i] = formas[i].CalculateSurface();
            }
            Console.WriteLine("Area de las figuras:");
            foreach (double area in areas)
            {
                Console.WriteLine(area);
            }
    }
}
}
