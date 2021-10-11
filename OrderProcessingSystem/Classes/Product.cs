using OrderProcessingSystem.Interface;

namespace OrderProcessingSystem.Classes
{
    public abstract class Product : IPayment
    {
        protected string ProductName { get; set; }
        protected double Amount { get; set; }
        protected string OwnerName { get; set; }

        protected Product(string productName, double amount, string ownerName)
        {

            ProductName = productName;
            Amount = amount;
            OwnerName = ownerName;
        }
        protected Product(string productName, double amount)
        {
            ProductName = productName;
            Amount = amount;
        }
        /// <summary>
        /// Payment Method To Complete Payment
        /// Child classes need to implement this method for Payment
        /// </summary>
        /// <returns></returns>
        public abstract bool DoPayment();

    }
}
