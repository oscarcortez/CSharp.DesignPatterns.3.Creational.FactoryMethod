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
