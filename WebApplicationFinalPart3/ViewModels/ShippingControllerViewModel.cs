using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationFinalPart3;

namespace WebApplicationFinalPart3.ViewModels
{
    public class ShippingControllerViewModel
    {
        public List<string> DDLOfVehicles;
        public uint ShippingZipCode { get; set; }
        public ShippingControllerViewModel()
        {
            this.DDLOfVehicles = new List<string>() {"Air Express", "SnailService", "Uncle Truck"};
        }

       
    }
}
