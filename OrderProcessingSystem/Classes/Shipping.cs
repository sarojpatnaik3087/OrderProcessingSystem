using OrderProcessingSystem.Interface;

using System;
using System.Collections.Generic;
using System.Threading;

namespace OrderProcessingSystem.Classes
{
   public class Shipping : IPackingSlip
    {

        public virtual bool GenerateSlip(string transactionId, string productName, double amount, Dictionary<string, string> contentList)
        {
            try
            {
                ValidateParameters(transactionId,productName);
                Console.WriteLine("----------------Generated Packing Slip-----------------------");
                Console.WriteLine("TransactionId: " + transactionId);
                Console.WriteLine("ProductName: " + productName);
                Console.WriteLine("Amount " + amount);
                //Dynamic Content if client wants to add any other entries.
                if (contentList == null) return true;
                foreach (var printingContent in contentList)
                {
                    Console.WriteLine(printingContent.Key + ": " + printingContent.Value);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

            return true;

        }

        private void ValidateParameters(string transactionId, string productName)
        {
            if (string.IsNullOrEmpty(transactionId) || string.IsNullOrEmpty(productName))
            {
                throw new Exception("TransactionId or ProductName are mandatory");
            }
        }
    }
}
