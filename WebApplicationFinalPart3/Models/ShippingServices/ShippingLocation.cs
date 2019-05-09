using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationFinalPart3.Models.ShippingServices
{
    public class ShippingLocation : IShippingLocation
    {
        public uint StartZipCode { get; set; }
        public uint DestinationZipCode { get; set; }
    }
}
