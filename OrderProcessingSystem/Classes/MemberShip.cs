using System;
using System.Collections.Generic;
using System.Text;
using OrderProcessingSystem.Interface;

namespace OrderProcessingSystem.Classes
{
    public class MemberShip:Product,IEmail
    {
        public MemberShip(string productName, double price, string ownerEmailId) : base(productName, price, ownerEmailId)
        {
        }

        public override bool DoPayment()
        { 
            Console.WriteLine("MemberShip Payment Completed");
            SendEmail("MemberShip Activation Completed", OwnerEmailId);
            return true;
        }

        public bool SendEmail(string messageBody, string emailId)
        {
            try
            {
                ValidateEmailId(emailId);
                Console.WriteLine(messageBody);
                Console.WriteLine("Email Sent Successfully to: " + emailId);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Email Sent Failed");
                return false;
            }

        }

        private void ValidateEmailId(string emailId)
        {
            if (string.IsNullOrEmpty(emailId))
            {
                throw new Exception("EmailId is not valid");
            }
        }
    }
}
