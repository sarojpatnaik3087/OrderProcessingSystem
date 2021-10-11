using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingSystem.Classes
{
    public class RoyaltyDepartment : Shipping
    {
        public override bool GenerateSlip(string transactionId, string productName, double amount, Dictionary<string, string> contentList)
        {
            try
            {
                base.GenerateSlip(transactionId, productName, amount, contentList);
                Console.WriteLine("Generating Duplicate Packing Slip For RoyaltyDepartment");
                base.GenerateSlip(transactionId, productName, amount, contentList);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

            return true;

        }
    }
}
