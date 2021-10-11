using System;
using System.Collections.Generic;
using System.Text;
using OrderProcessingSystem.Classes;
using OrderProcessingSystem.Utilities;

namespace OrderProcessingSystem.BusinessLayer
{
    public class ProductFacade
    {
        private readonly string _productName;
        private readonly double _price;
        private readonly string _ownerEmailId;
        public ProductFacade(string productName, double price, string ownerEmailId, string shippingAddress)
        {
            _productName = productName;
            _price = price;
            _ownerEmailId = ownerEmailId;
        }
        /// <summary>
        /// PhysicalProduct Product Payment
        /// </summary>
        public void PayPhysicalProduct()
        {
            Product product =
                new PhysicalProduct(_productName, _price, new Shipping(), StringConstants.AgentCommission);
            product.DoPayment();
        }
    }
}
