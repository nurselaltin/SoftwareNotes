// See https://aka.ms/new-console-template for more information
using System.Text;
using WorkingOnProgramming.DesignPattern;

Console.WriteLine("Hello, World!");
ICarBuilder builder = new CarBuilder();
Director director = new Director(builder);

Car sportsCar = director.ConstructSportsCar();
Console.WriteLine(sportsCar.Engine);

Car suv = director.ConstructSUV();
Console.WriteLine(suv);

Console.ReadLine();


