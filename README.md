# CSharp.DesignPatterns.3.Creational.FactoryMethod

1. Se debe crear una clase factory que en un metodo (constructor) recibiendo una variable se decida cual clase instanciar
```csharp
public static class VehicleFactory
{
    public static IVehicle Build(int numberOfWheels)
    {
        switch(numberOfWheels)
        {
            case 1:
                return new Unicycle();
            case 2:
            case 3:
                return new Motorbike();
            case 4:
                return new Car();
            default:
                return new Truck();
        }
    }
}
```
2. Para que esto funcione se debe crear primero la interface: IVehicle para que pueda mutar (cambiar su comportamiento)
```csharp
public interface IVehicle
{
}
```
3. Se crea las clases que hereden de la interface: Car, MotorBike, Truck, Unicycle
```csharp
public class Car : IVehicle
{
}

public class Motorbike : IVehicle
{
}

public class Truck : IVehicle
{
}

public class Unicycle : IVehicle
{
}
```
4. Aqui vemos como se usa el metodo que decide cual instancia crear en el factory, con getype vemos cual instancia se creo
```csharp
IVehicle vehicle = VehicleFactory.Build(int.Parse(wheels));
Console.WriteLine($" You built a {vehicle.GetType().Name}");
```
