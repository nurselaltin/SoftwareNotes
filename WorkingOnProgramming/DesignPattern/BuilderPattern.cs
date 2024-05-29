
namespace WorkingOnProgramming.DesignPattern
{
    //Bir nesne oluşturma sürecini adımlara böler
    //Product - Ürün : Oluşturulacak nesne
    //Builder: Ürünün adım adım oluşturulması için gerekli adımları tanımlar,her ürünün özelliğini belirler
    //ConcreteBuilder: Builder arayüzünü uygular ürünün oluşturulma süreci gerçekleştirilir.
    //Director: Oluşturma sürecini yöneten sınıftır

    //Product
    public class Car
    {
        public string Engine { get; set; }
        public int Seats { get; set; }
    }
    //Builder
    public interface ICarBuilder
    {
        ICarBuilder SetEngine(string engine);
        ICarBuilder SetSeats(int number);
        Car Build();
    }

    //ConcreteBuilder

    public class CarBuilder : ICarBuilder
    {
        private Car _car = new Car();

        public Car Build()
        {
            return _car;
        }

        public ICarBuilder SetEngine(string engine)
        {
            _car.Engine = engine;
            return this;
        }

        public ICarBuilder SetSeats(int number)
        {
            _car.Seats = number;
            return this;
        }
    }


    //Director 
    public class Director
    {
        private ICarBuilder _builder;
        public Director(ICarBuilder builder)
        {
             _builder = builder;
        }

        public Car ConstructSportsCar()
        {
            return _builder.SetEngine("V8")
                           .SetSeats(2)
                           .Build();
        }

        public Car ConstructSUV()
        {
            return _builder.SetEngine("V6")
                           .SetSeats(7)
                           .Build();
        }
    }
}
