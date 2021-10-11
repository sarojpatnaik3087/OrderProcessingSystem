using NUnit.Framework;

using OrderProcessingSystem.Classes;
using OrderProcessingSystem.Interface;

using System;
using System.Collections.Generic;

namespace OrderProcessingTest
{
    class PackingSlipTest
    {
        private string TransactionId { get; set; }
        private string ProductName { get; set; }
        private double Amount { get; set; }
        private Dictionary<string, string> ContentList { get; set; }
        private IPackingSlip PackingSlip { get; set; }
        [SetUp]
        public void Setup()
        {
            TransactionId = Guid.NewGuid().ToString();
            ProductName = "TV";
            Amount = 2333.35;
            PackingSlip = new Shipping();
            ContentList = new Dictionary<string, string>();
        }

        [Test]
        public void Should_Generate_Packing_Slip()
        {
            var isSlipGenerated = PackingSlip.GenerateSlip(TransactionId, ProductName, Amount, new Dictionary<string, string>());
            Assert.True(isSlipGenerated);
        }
        [Test]
        public void Should_Not_Fail_If_Dynamic_Content_Passed_Null_For__Packing_Slip()
        {
            var isSlipGenerated = PackingSlip.GenerateSlip(TransactionId, ProductName, Amount, null);
            Assert.True(isSlipGenerated);
        }
        [Test]
        public void Should_Print_Dynamic_Content_When_Added()
        {
            ContentList.Add("Video", "Printing Dynamic Content");
            var isSlipGenerated = PackingSlip.GenerateSlip(TransactionId, ProductName, Amount, ContentList);
            Assert.True(isSlipGenerated);
        }
        [Test]
        public void Should_Not_Print_Slip_If_No_TransactionId_Is_Present()
        {
            var isSlipGenerated = PackingSlip.GenerateSlip(string.Empty, ProductName, Amount, new Dictionary<string, string>());
            Assert.False(isSlipGenerated);
        }

    }
}
