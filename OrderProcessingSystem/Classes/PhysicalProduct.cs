using System;
using System.Collections.Generic;
using System.Text;
using OrderProcessingSystem.Interface;

namespace OrderProcessingSystem.Classes
{
    public class PhysicalProduct:Product
    {
        private readonly IPackingSlip _packagingSlip;
        public PhysicalProduct(string productName, double amount, IPackingSlip packagingSlip) : base(productName, amount)
        {
            _packagingSlip = packagingSlip;
        }

        public override bool DoPayment()
        {
            Console.WriteLine("Payment Completed");
            return _packagingSlip.GenerateSlip(Guid.NewGuid().ToString(), ProductName, Amount, new Dictionary<string, string>());
        }
    }
}
