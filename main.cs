using System;

class Program {
  //11
  public static double CalculatePerimeter(double side) => 4 * side;
  public static double CalculateArea(double side) => side * side;
  public static double CalculateDiagonal(double side) => side * Math.Sqrt(2);
  //18
  public static double SphereArea(double radius) => 4 * Math.PI * Math.Pow(radius, 2);
  public static double SphericalCapArea(double radius) => 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);
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

  public static void Main (string[] args) {
    //17
    Console.WriteLine ("Задача 11\n");
    Console.Write("Введите радиус внешнего круга: ");
    double outerRad= double.Parse(Console.ReadLine()!);
    Console.Write("Введите радиус внутреннего круга: ");
    double innerRad= double.Parse(Console.ReadLine()!);
    Console.WriteLine($"Площадь кольца равна: {RingArea(outerRad, innerRad)}");
  }
}

    // 11
    
    /*
    Console.WriteLine ("Задача 11\n");
    Console.Write("Введите сторону квадрата: ");
    double side= double.Parse(Console.ReadLine()!);
    Console.WriteLine($"Периметр квадрата равен: {CalculatePerimeter(side)}");
    Console.WriteLine($"Площаль квадрата равен: {CalculateArea(side)}");
    Console.WriteLine($"Диагональ квадрата равен: {CalculateDiagonal(side)}");
    */


/*
    //18
    Console.WriteLine ("Задача 18\n");
    Console.Write("Введите радиус: ");
    double r = double.Parse(Console.ReadLine()!);
    Console.WriteLine($"Площадь сферы равна: {SphereArea(r)}");
    Console.WriteLine($"Площадь окружности равна: {SphericalCapArea(r)}");
*/