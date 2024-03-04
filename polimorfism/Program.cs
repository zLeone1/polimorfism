using System;

public interface IVehicle
{
    void start();
}

public class Car : IVehicle
{
    public void start()
    {
        Console.WriteLine("The Car is starting...");
    }
}

public class Motocycle : IVehicle
{
    public void start()
    {
        Console.WriteLine("The motocycle is starting...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IVehicle miAuto = new Car();
        IVehicle miMoto = new Motocycle();

        miAuto.start();
        miMoto.start();
    }
}
