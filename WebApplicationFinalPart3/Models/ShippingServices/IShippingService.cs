using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApplicationFinalPart3;

namespace WebApplicationFinalPart3
{
    public interface IShippingService
    {
        IShippingLocation ShippingLocation { get; }

        uint ShippingDistance { get; }

        uint NumRefuels { get; }
        IDeliveryService DeliveryService { get; set; }
    }

}