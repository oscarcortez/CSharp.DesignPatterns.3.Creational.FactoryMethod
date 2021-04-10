using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class VehicleFactory
    {
        public static IVehicle Build(int numberOfWheels)
        {
            switch(numberOfWheels)
            {
                case 1:
                    return new Unicycle();
                    break;
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
}
