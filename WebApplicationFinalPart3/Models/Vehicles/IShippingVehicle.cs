using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApplicationFinalPart3
{ 
    public interface IShippingVehicle : IMotorVehicle
    {
        uint MaxDistancePerRefuel { get; set; }
        uint MaxWeight { get; }
    }
}