using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApplicationFinalPart3
{
    public class AirExpress : DeliveryService
    {
        public AirExpress(IShippingVehicle vehicle) : base(vehicle)
        {

            this.costPerRefuel = 2000;
        }
    }
}