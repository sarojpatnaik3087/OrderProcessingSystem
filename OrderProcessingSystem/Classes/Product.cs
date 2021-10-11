using OrderProcessingSystem.Interface;

namespace OrderProcessingSystem.Classes
{
    public abstract class Product : IPayment
    {
        protected string ProductName { get; set; }
        protected double Price { get; set; }
        protected string OwnerEmailId { get; set; }

        protected Product(string productName, double price, string ownerEmailId)
        {

            ProductName = productName;
            Price = price;
            OwnerEmailId = ownerEmailId;
        }
        protected Product(string productName, double amount)
        {
            ProductName = productName;
            Price = amount;
        }
        /// <summary>
        /// Payment Method To Complete Payment
        /// Child classes need to implement this method for Payment
        /// </summary>
        /// <returns></returns>
        public abstract bool DoPayment();

    }
}
