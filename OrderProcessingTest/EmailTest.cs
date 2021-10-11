using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;
using OrderProcessingSystem.Classes;
using OrderProcessingSystem.Interface;

namespace OrderProcessingTest
{
    public class EmailTest
    {
        private IEmail Email { get; set; }
        [SetUp]
        public void Setup()
        {
            Email = new MemberShip("Membership", 1000, "validemail@gmail.com");
        }

        [Test]
        public void Should_Send_Email()
        {
            var isEmailSent = Email.SendEmail("Test MessageBody", "validemail@gmail.com");
            Assert.True(isEmailSent);
        }

        [Test]
        public void Email_Send_Should_Fail_If_EmailId_Is_Wrong()
        {
            var isEmailSent = Email.SendEmail("Test MessageBody", string.Empty);
            Assert.False(isEmailSent);
        }
    }
}
