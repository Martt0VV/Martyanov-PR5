using System;

public enum CircleType
{
  Circumscribed,
  Inscribed
}

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

class Program
{

  public static void Main(string[] args)
  {
    Console.WriteLine("Задача 11 (С правками)\n");
    Console.Write("Введите сторону квадрата: ");
    var sq = new Square(double.Parse(Console.ReadLine()!));
    Console.WriteLine("Выберите тип окружности:\n\t[1] - Вписаная окружность\n\t[2] - Описанная окружногсть");
    string userInput = Console.ReadLine();
    switch (userInput)
    {
      case "1":
        Console.WriteLine($"Площадь вписанной окружности: {sq.CircleArea(CircleType.Inscribed)}");
        Console.WriteLine($"Длинна вписанной окружности: {sq.GetCircleLength(CircleType.Inscribed)}");
        Console.WriteLine($"Площадь треугольника: {sq.InscribedTriangleArea()}");
        break;
      case "2":
        Console.WriteLine($"Площадь вписанной окружности: {sq.CircleArea(CircleType.Circumscribed)}");
        Console.WriteLine($"Длина вписанной окружности: {sq.GetCircleLength(CircleType.Circumscribed)}");
        Console.WriteLine($"Площадь треугольника: {sq.CircumscribedTriangleArea()}");
        break;
      default:
        Console.WriteLine("Неккоректный ввод");
        break;
    }
    Console.WriteLine($"Периметр квадрата равен: {sq.Perimeter()}");
    Console.WriteLine($"Площаль квадрата равен: {sq.Area()}");
    Console.WriteLine($"Диагональ квадрата равен: {sq.Diagonal()}");

  }
}


// 11
/*
public static double CalculatePerimeter(double side) => 4 * side;
public static double CalculateArea(double side) => side * side;
public static double CalculateDiagonal(double side) => side * Math.Sqrt(2);

Console.WriteLine ("Задача 11\n");
Console.Write("Введите сторону квадрата: ");
double side= double.Parse(Console.ReadLine()!);
Console.WriteLine($"Периметр квадрата равен: {CalculatePerimeter(side)}");
Console.WriteLine($"Площаль квадрата равен: {CalculateArea(side)}");
Console.WriteLine($"Диагональ квадрата равен: {CalculateDiagonal(side)}");
*/


/*
    //18
    public static double SphereArea(double radius) => 4 * Math.PI * Math.Pow(radius, 2);
    public static double SphericalCapArea(double radius) => 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);

    Console.WriteLine ("Задача 18\n");
    Console.Write("Введите радиус: ");
    double r = double.Parse(Console.ReadLine()!);
    Console.WriteLine($"Площадь сферы равна: {SphereArea(r)}");
    Console.WriteLine($"Площадь окружности равна: {SphericalCapArea(r)}");
*/
/*
    //17

    public static double RingArea(double outerRadius, double innerRadius)
    {
      if (outerRadius <= 0 || innerRadius <= 0)
      {
        throw new ArgumentException("Radius should be positive.");
      }

      if (innerRadius >= outerRadius)
      {
        throw new ArgumentException("Inner radius should be less than outer radius.");
      }
    return Math.PI * (outerRadius * outerRadius - innerRadius * innerRadius);
    }


    Console.WriteLine ("Задача 11\n");
    Console.Write("Введите радиус внешнего круга: ");
    double outerRad= double.Parse(Console.ReadLine()!);
    Console.Write("Введите радиус внутреннего круга: ");
    double innerRad= double.Parse(Console.ReadLine()!);
    Console.WriteLine($"Площадь кольца равна: {RingArea(outerRad, innerRad)}");
*/