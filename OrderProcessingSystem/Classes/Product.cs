using OrderProcessingSystem.Interface;

namespace OrderProcessingSystem.Classes
{
    public abstract class Product : IPayment
    {
        protected string ProductName { get; set; }
        protected double Price { get; set; }
        protected string OwnerName { get; set; }

        protected Product(string productName, double price, string ownerName)
        {

            ProductName = productName;
            Price = price;
            OwnerName = ownerName;
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
