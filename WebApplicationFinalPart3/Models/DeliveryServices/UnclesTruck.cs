using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApplicationFinalPart3
{
    public class UnclesTruck : DeliveryService
    {
        public UnclesTruck(IShippingVehicle vehicle) : base(vehicle)
        {
            
            this.costPerRefuel = 200;
        }
    }
}