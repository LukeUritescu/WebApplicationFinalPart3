using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationFinalPart3.ViewModels;
using WebApplicationFinalPart3.Models;
using WebApplicationFinalPart3.Models.ShippingServices;

namespace WebApplicationFinalPart3.Controllers
{
    public class ShippingController : Controller
    {
        ShippingControllerViewModel model;
        // GET: Shipping
        public ShippingController()
        {
            model = new ShippingControllerViewModel();
            
        }

        public ActionResult Index()
        {
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CalculateShipping(IFormCollection collection)
        {
            try
            {
                uint zipCode = 0;
                uint.TryParse(collection["FromZip"].ToString(), out zipCode);
                ////I couldn't figure out how to send the selected item from the ddl to the controller if it was set as an object
                ////I decided to make the DLL a string and use if/else to have it do what I wanted
                
                if (collection["ShippingMethods"].ToString() == model.DDLOfVehicles[0])
                {
                    DefaultShippingService defaultShip = new DefaultShippingService(new AirExpress(new Plane()), new List<IProduct>(), new ShippingLocation());
                    defaultShip.ShippingLocation.DestinationZipCode = zipCode;
                    return View(defaultShip);
                }
                else if (collection["ShippingMethods"].ToString() == model.DDLOfVehicles[1])
                {
                    DefaultShippingService defaultShip = new DefaultShippingService(new SnailService(new ShippingSnail()), new List<IProduct>(), new ShippingLocation());
                    defaultShip.ShippingLocation.DestinationZipCode = zipCode;
                    return View(defaultShip);
                }

                else if (collection["ShippingMethods"].ToString() == model.DDLOfVehicles[2])
                {
                    DefaultShippingService defaultShip = new DefaultShippingService(new UnclesTruck(new Truck()), new List<IProduct>(), new ShippingLocation());
                    defaultShip.ShippingLocation.DestinationZipCode = zipCode;
                    return View(defaultShip);
                }
                else
                {
                    DefaultShippingService defaultShip = new DefaultShippingService(new AirExpress(new Plane()), new List<IProduct>(), new ShippingLocation());
                    defaultShip.ShippingLocation.DestinationZipCode = zipCode;
                    return View(defaultShip);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Shipping/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Shipping/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Shipping/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Shipping/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Shipping/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Shipping/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Shipping/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

//if (collection["ShippingMethods"].ToString() == model.DDLOfVehicles[0])
//{
//    DefaultShippingService defaultShip = new DefaultShippingService(new AirExpress(new Plane()), new List<IProduct>());
//    defaultShip.ShippingLocation.DestinationZipCode = zipCode;
//    return View(defaultShip);
//}
//else if (collection["ShippingMethods"].ToString() == model.DDLOfVehicles[1])
//{
//    DefaultShippingService defaultShip = new DefaultShippingService(new SnailService(new ShippingSnail()), new List<IProduct>());
//    defaultShip.ShippingLocation.DestinationZipCode = zipCode;
//    return View(defaultShip);
//}

//else if (collection["ShippingMethods"].ToString() == model.DDLOfVehicles[2])
//{
//    DefaultShippingService defaultShip = new DefaultShippingService(new UnclesTruck(new Truck()), new List<IProduct>());
//    defaultShip.ShippingLocation.DestinationZipCode = zipCode;
//    return View(defaultShip);
//}
//else
//{
//    DefaultShippingService defaultShip = new DefaultShippingService(new AirExpress(new Plane()), new List<IProduct>());
//    defaultShip.ShippingLocation.DestinationZipCode = zipCode;
//    return View(defaultShip);
//}