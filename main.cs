using System;

class Program {
  //11
  public static double CalculatePerimeter(double side) => 4 * side;
  public static double CalculateArea(double side) => side * side;
  public static double CalculateDiagonal(double side) => side * Math.Sqrt(2);
  //18
  public static double SphereArea(double radius) => 4 * Math.PI * Math.Pow(radius, 2);
  public static double SphericalCapArea(double radius) => 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);

  public static void Main (string[] args) {    
    //18
    Console.WriteLine ("Задача 18\n");
    Console.Write("Введите радиус: ");
    double r = double.Parse(Console.ReadLine()!);
    Console.WriteLine($"Площаль квадрата равен: {SphereArea(r)}");
    Console.WriteLine($"Диагональ квадрата равен: {SphericalCapArea(r)}");
    
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