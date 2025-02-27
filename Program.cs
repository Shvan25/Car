using System;

using System;

    class Car
{
    public int Mileage;
    public Car()
    {
        Mileage = 0;
    }
    public virtual void Move()
    {
        Console.WriteLine("Вызван метод Move класса Car");
        Mileage++;
    }
}
enum FuelType
{
    Gas = 0,
    Electricity
}
class HybridCar : Car
{
    public FuelType FuelType;

    public double Gas;

    public double Electricity;

    public HybridCar()
    {
        Electricity = 50;
        Gas = 50;
    }
    public override void Move()
    {
        Console.WriteLine("Вызван метод Move класса HybridCar");
        Mileage++;

        switch (FuelType)
        {
            case FuelType.Gas:
                Gas -= 0.5;
                break;
            case FuelType.Electricity:
                Electricity -= 0.5; break;
        }
    }
    public void ChangeFuelType(FuelType type)
    {
        FuelType = type;
    }
}
class Programm
{

    public static void Main(string[] args)
    {
        Car car = new Car();
        HybridCar hybridcar = new HybridCar();

        car.Move();
        hybridcar.Move();
        ((Car)hybridcar).Move();
    }
}