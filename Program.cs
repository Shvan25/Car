using System;

class Car
{
    private double Fuel;

    private int Mileage;

    
    public Car()
    {
        Fuel = 50;
        Mileage = 0;
        
    }

    private void Move()
    {
        // Move a kilometer
        Mileage++;
        Fuel -= 0.5;
    }

    public void FillTheCar()
    {
        Fuel = 50;
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

    public void ChangeFuelType(FuelType type)
    {
        FuelType = type;
    }
}