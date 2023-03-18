using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Square;

public class Square
{
  public double Side { get; }

  public Square(double side)
  {
    Side = side;
  }

  public double Perimeter()
  {
    return 4 * Side;
  }

  public double Area()
  {
    return Side * Side;
  }

  public double Diagonal()
  {
    return Side * Math.Sqrt(2);
  }
  public double CircleRadius(CircleType type)
  {
    switch (type)
    {
      case CircleType.Circumscribed:
        return Side * Math.Sqrt(2) / 2;
      case CircleType.Inscribed:
        return Side / 2;
      default:
        throw new ArgumentException("Invalid circle type");
    }
  }
  public double GetCircleLength(CircleType type)
  {
    double R = CircleRadius(type);
    return type switch
    {
      CircleType.Circumscribed => 2 * Math.PI * R,
      CircleType.Inscribed => 2 * Math.PI * R
    };
  }

  public double CircleArea(CircleType type)
  {
    var radius = CircleRadius(type);
    return Math.PI * radius * radius;
  }

  public double InscribedTriangleArea()
  {
    var radius = CircleRadius(CircleType.Inscribed);
    return 3 * Side * radius;
  }

  public double CircumscribedTriangleArea()
  {
    var radius = CircleRadius(CircleType.Circumscribed);
    return 3 * Side * radius * Math.Sqrt(3) / 2;
  }
}