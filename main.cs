using System;
using Square;
public enum CircleType
{
  Circumscribed,
  Inscribed
}

class Program
{
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
  public static double CalculateRingVolume(double outerRadius, double innerRadius, double height)
  {
    return Math.PI * height * (outerRadius * outerRadius - innerRadius * innerRadius);
  }

  public static double CalculateRingSurfaceArea(double outerRadius, double innerRadius, double height)
  {
    double outerSurfaceArea = 2 * Math.PI * outerRadius * height;
    double innerSurfaceArea = 2 * Math.PI * innerRadius * height;
    double topArea = Math.PI * outerRadius * outerRadius;
    double bottomArea = Math.PI * innerRadius * innerRadius;

    return outerSurfaceArea + innerSurfaceArea + topArea + bottomArea;
  }
  public static void Main(string[] args)
  {
    Console.WriteLine("Задача 11\n");
    Console.Write("Введите радиус внешнего круга: ");
    double outerRad = double.Parse(Console.ReadLine()!);
    Console.Write("Введите радиус внутреннего круга: ");
    double innerRad = double.Parse(Console.ReadLine()!);
    Console.Write("Укажите высоту кольца: ");
    double height = double.Parse(Console.ReadLine()!);
    Console.WriteLine($"Площадь кольца равна: {RingArea(outerRad, innerRad)}");
    Console.WriteLine($"Объём кольца равен: {CalculateRingVolume(outerRad, innerRad, height)}");
    Console.WriteLine($"Площадь поверхности кольца равна: {CalculateRingSurfaceArea(outerRad, innerRad, height)}");
    

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

//11 (с правками)
/*
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


    //18 (c правками)
        Console.WriteLine("Задача 18\n");
    Console.Write("Введите радиус: ");
    double r = double.Parse(Console.ReadLine()!);

    Console.WriteLine("Выберите операцию:\n\t[1] - Площадь сферы\n\t[2] - Площадь шара");
    string userInput = Console.ReadLine();
    switch (userInput)
    {
      case "1":
        Console.WriteLine($"Площадь сферы равна: {SphereArea(r)}");
        break;
      case "2":
        Console.WriteLine($"Площадь окружности равна: {SphericalCapArea(r)}");
        break;
      default:
        Console.WriteLine("Такой операции нет!");
        break;
    }
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