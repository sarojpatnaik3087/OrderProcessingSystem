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
            
        }
        [Test]
        public void Should_Complete_Payment()
        {
            Payment = new Book(TransactionId, Amount, PackingSlip, 20);
            var isPaymentCompleted = Payment.DoPayment();
            Assert.True(isPaymentCompleted);
        }
        [Test]
        public void Should_Not_Complete_Payment_If_AgentCommission_Is_Negative()
        {
            Payment = new Book(TransactionId, Amount, PackingSlip, -100);
            var isPaymentCompleted = Payment.DoPayment();
            Assert.False(isPaymentCompleted);
        }
    }
}
