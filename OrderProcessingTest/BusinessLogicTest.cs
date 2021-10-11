using NUnit.Framework;
using OrderProcessingSystem.BusinessLayer;

namespace OrderProcessingTest
{
    /// <summary>
    /// This is end-end testing of application
    /// </summary>
    public class Tests
    {
        private ProductFacade ProductFacade { get; set; }
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Should_Complete_Payment_And_Print_PackingSlip_For_PhysicalProduct()
        {
            ProductFacade = new ProductFacade("TV", 2000, "validemailid@gmail.com");
            Assert.True(ProductFacade.PhysicalProductPayment());
        }
        [Test]
        public void Should_Complete_Payment_And_Print_Duplicate_PackingSlip_For_Book()
        {
            ProductFacade = new ProductFacade("OnceInaWhile", 2000, "validemailid@gmail.com");
            Assert.True(ProductFacade.BookPayment());
        }
        
        [Test]
        public void Should_Complete_Payment_And_Activate_Membership()
        {
            ProductFacade = new ProductFacade("PrimeMemberShip", 2000, "validemailid@gmail.com");
            Assert.True(ProductFacade.MembershipPayment());
        }
        [Test]
        public void Should_Complete_Payment_And_Update_Membership()
        {
            ProductFacade = new ProductFacade("PrimeMemberShip", 2000, "validemailid@gmail.com");
            Assert.True(ProductFacade.UpgradeMembershipPayment());
        }
        //TODO
        //Not completed due to time constraint
        public void Should_Complete_Payment_For_Video()
        {
            
        }
    }
}