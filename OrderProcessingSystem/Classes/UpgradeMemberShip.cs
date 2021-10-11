using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingSystem.Classes
{
    public class UpgradeMemberShip:MemberShip
    {
        public UpgradeMemberShip(string productName, double price, string ownerName) : base(productName, price, ownerName)
        {
        }
        public override bool DoPayment()
        {
            Console.WriteLine("UpgradeMemberShip Payment Completed");
            return true;
        }
    }
}
