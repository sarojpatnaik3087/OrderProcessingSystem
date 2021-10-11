using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingSystem.Classes
{
    public class MemberShip:Product
    {
        public MemberShip(string productName, double price, string ownerName) : base(productName, price, ownerName)
        {
        }

        public override bool DoPayment()
        {
           Console.WriteLine("MemberShip Payment Completed");
           return true;
        }
    }
}
