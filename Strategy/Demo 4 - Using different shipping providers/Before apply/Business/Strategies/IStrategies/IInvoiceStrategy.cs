using Strategy_Pattern_First_Look.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern_First_Look.Business.Strategies.IStrategies
{
    public interface IInvoiceStrategy
    {
        public void Generate(Order order);
    }
}
