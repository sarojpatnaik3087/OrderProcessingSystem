using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingSystem.Classes
{
    public class UpgradeMemberShip:MemberShip
    {
        public UpgradeMemberShip(string productName, double price, string ownerEmailId) : base(productName, price, ownerEmailId)
        {
        }
        public override bool DoPayment()
        {
            Console.WriteLine("UpgradeMemberShip Payment Completed");
            SendEmail("Membership Upgraded Successfully", OwnerEmailId);
            return true;
        }
    }
}
