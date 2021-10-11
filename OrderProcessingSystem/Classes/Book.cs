
using OrderProcessingSystem.Interface;

namespace OrderProcessingSystem.Classes
{
    public class Book : PhysicalProduct
    {
        public Book(string productName, double amount, IPackingSlip packagingSlip,double agentCommission) : base(productName, amount, packagingSlip,agentCommission)
        {

        }
    }
}
