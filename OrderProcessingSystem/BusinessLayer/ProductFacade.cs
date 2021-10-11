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
        public ProductFacade(string productName, double price, string ownerEmailId)
        {
            _productName = productName;
            _price = price;
            _ownerEmailId = ownerEmailId;
        }
        /// <summary>
        /// PhysicalProduct Product Payment
        /// </summary>
        public bool PhysicalProductPayment()
        {
            Product product =
                new PhysicalProduct(_productName, _price, new Shipping(), StringConstants.AgentCommission);
            return product.DoPayment();
        }
        public bool BookPayment()
        {
            Product product =
                new Book(_productName, _price, new RoyaltyDepartment(), StringConstants.AgentCommission);
            return product.DoPayment();
        }

        public bool MembershipPayment()
        {
            Product product =
                new MemberShip(_productName, _price, _ownerEmailId);
           return product.DoPayment();
        }
        public bool UpgradeMembershipPayment()
        {
            Product product =
                new UpgradeMemberShip(_productName, _price, _ownerEmailId);
            return product.DoPayment();
        }
    }
}
