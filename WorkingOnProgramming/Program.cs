// See https://aka.ms/new-console-template for more information
using System.Text;
using WorkingOnProgramming.DesignPattern;
using WorkingOnProgramming.DesignPattern.Structural;

Console.WriteLine("Hello, World!");

#region Creational - Builder
//ICarBuilder builder = new CarBuilder();
//Director director = new Director(builder);

//Car sportsCar = director.ConstructSportsCar();
//Console.WriteLine(sportsCar.Engine);

//Car suv = director.ConstructSUV();
//Console.WriteLine(suv);
#endregion

#region Structural - Adapter

ICardReaderAdapter adapter = new XBankCardReaderAdapter();
var res = adapter.ReadCardData();
Console.WriteLine(res);
#endregion


Console.ReadLine();


