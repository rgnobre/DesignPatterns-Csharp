using Strategy_Pattern_First_Look.Business.Models;
using Strategy_Pattern_First_Look.Business.Strategies.IStrategies;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Strategy_Pattern_First_Look.Business.Strategies.Shipping
{
    public class DHLShippingStrategy : IShippingStrategy
    {
        public void Ship(Order order)
        {
            using (var client = new HttpClient())
            {
                //TODO: Implement DHL Shipping Integration

                Console.WriteLine("Order is shipped with DHL");
            }
        }
    }
}
