using System.Collections.Generic;

namespace OrderProcessingSystem.Interface
{
    public interface IPackingSlip
    {

        /// <summary>
        /// Generic Packing Slip Method
        /// ContentList is Dynamic If client wants to add more dynamic content.
        /// Returns False If Slip is not generated
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="productName"></param>
        /// <param name="amount"></param>
        /// <param name="contentList"></param>
        /// <returns>Bool</returns>
        bool GenerateSlip(string transactionId, string productName, double amount, Dictionary<string, string> contentList=default);
    }
}
