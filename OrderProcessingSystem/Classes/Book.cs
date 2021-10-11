
using OrderProcessingSystem.Interface;

namespace OrderProcessingSystem.Classes
{
    public class Book : PhysicalProduct
    {
        public Book(string productName, double amount, IPackingSlip packagingSlip) : base(productName, amount, packagingSlip)
        {

        }
    }
}
