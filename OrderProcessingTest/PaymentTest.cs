using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OrderProcessingSystem.Classes;
using OrderProcessingSystem.Interface;

namespace OrderProcessingTest
{
    class PaymentTest
    {
        private  IPayment Payment { get; set; }
        private IPackingSlip PackingSlip { get; set; }
        private string TransactionId { get; set; }
        private string ProductName { get; set; }
        private double Amount { get; set; }

        [SetUp]
        public void Setup()
        {
            TransactionId = Guid.NewGuid().ToString();
            ProductName = "Book";
            Amount =100.23;
            PackingSlip = new RoyaltyDepartment();
            Payment = new Book(TransactionId,Amount,PackingSlip);
        }
        [Test]
        public void Should_Complete_Payment()
        {
            var isPaymentCompleted = Payment.DoPayment();
            Assert.True(isPaymentCompleted);
        }
    }
}
