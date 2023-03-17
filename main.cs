using System;

class Program {
  public static double CalculatePerimeter(double side) => 4 * side;
  public static double CalculateArea(double side) => side * side;
  public static double CalculateDiagonal(double side) => side * Math.Sqrt(2);
  
  public static void Main (string[] args) {
    Console.WriteLine ("Задача 11\n");
    Console.Write("Введите сторону квадрата: ");
    double side= double.Parse(Console.ReadLine()!);
    Console.WriteLine($"Периметр квадрата равен: {CalculatePerimeter(side)}");
    Console.WriteLine($"Периметр квадрата равен: {CalculateArea(side)}");
    Console.WriteLine($"Периметр квадрата равен: {CalculateDiagonal(side)}");
    
    
  }
}