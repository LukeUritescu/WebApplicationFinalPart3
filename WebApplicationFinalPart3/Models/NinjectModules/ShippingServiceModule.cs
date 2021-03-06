﻿using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationFinalPart3;

namespace WebApplicationFinalPart3.NinjectModules
{
    public class ShippingServiceModule : NinjectModule
    {
       
        public ShippingServiceModule()
        {
            
        }

        public override void Load()
        {
            this.Bind<IDeliveryService>().To<UnclesTruck>();
            this.Bind<IShippingService>().To<DefaultShippingService>();
            this.Bind<IShippingVehicle>().To<Truck>();
        }
    }
}
