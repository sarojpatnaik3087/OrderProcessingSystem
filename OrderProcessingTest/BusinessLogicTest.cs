using NUnit.Framework;

namespace OrderProcessingTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Should_Complete_Payment_And_Print_PackingSlip_For_PhysicalProduct()
        {
            Assert.Pass();
        }
        [Test]
        public void Should_Complete_Payment_And_Print_Duplicate_PackingSlip_For_Book()
        {
            Assert.Pass();
        }
        [Test]
        public void Should_Give_Commission_To_Agent_For_Book()
        {
            Assert.Pass();
        }
        [Test]
        public void Should_Give_Error_If_Commission_Value_Is_Negative_For_Book()
        {
            Assert.Pass();
        }
        [Test]
        public void Should_Give_Error_If_Commission_Value_Is_Negative_For_PhysicalProduct()
        {
            Assert.Pass();
        }
        [Test]
        public void Should_Give_Commission_To_Agent_For_PhysicalProduct()
        {
            Assert.Pass();
        }
        [Test]
        public void Should_Complete_Payment_And_Activate_Membership()
        {
            Assert.Pass();
        }
        [Test]
        public void Should_Complete_Payment_And_Update_Membership()
        {
            Assert.Pass();
        }
        [Test]
        public void Should_Complete_Payment_And_Send_Email_For_New_Membership()
        {
            Assert.Pass();
        }
        [Test]
        public void Should_Complete_Payment_And_Send_Email_For_Update_Membership()
        {
            Assert.Pass();
        }
        [Test]
        public void Should_Send_Error_Message_If_No_EmailId_Present_For_Membership()
        {
            Assert.Pass();
        }
        [Test]
        public void Should_Add_New_Video_Content_In_PackingSlip_For_Specific_Video_Type()
        {
            Assert.Pass();
        }
        [Test]
        public void Should_Not_Add_New_Video_Content_In_PackingSlip_If_Video_Type_Not_Matches()
        {
            Assert.Pass();
        }
    }
}