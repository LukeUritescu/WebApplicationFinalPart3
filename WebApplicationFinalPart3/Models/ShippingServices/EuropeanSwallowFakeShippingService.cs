using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationFinalPart3.ShippingServices
{
    public class EuropeanSwallowFakeShippingService : DefaultShippingService
    {

        public EuropeanSwallowFakeShippingService(IDeliveryService Service, List<IProduct> Products, IShippingLocation Location) : base(Service, Products, Location)
        {
            this.Products = Products;
            this.ShippingLocation.StartZipCode = 6450;
        }

    }
}
