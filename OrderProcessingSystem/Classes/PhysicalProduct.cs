using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OrderProcessingSystem.Interface;

namespace OrderProcessingSystem.Classes
{
    public class PhysicalProduct:Product
    {
        private readonly IPackingSlip _packagingSlip;
        private readonly double _agentCommission;
        public PhysicalProduct(string productName, double price, IPackingSlip packagingSlip,double agentCommission) : base(productName, price)
        {
            _packagingSlip = packagingSlip;
            _agentCommission = agentCommission;
        }

        public override bool DoPayment()
        {
            try
            {
                ValidateAgentCommission(_agentCommission);
                Console.WriteLine("Payment Completed");
                Price = (Price - _agentCommission);
                return _packagingSlip.GenerateSlip(Guid.NewGuid().ToString(), ProductName, Price);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentPrice"></param>
        public void ValidateAgentCommission(double agentPrice)
        {
            if (agentPrice < 0)
            {
                throw new Exception("Agent Commission cannot be negative number");
            }
            else if(agentPrice>Price)
            {
                throw new Exception("Agent Commission Cannot be Greater than Price of Product");
            }
        }
    }
}
