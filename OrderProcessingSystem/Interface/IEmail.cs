using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingSystem.Interface
{
    public interface IEmail
    {
       /// <summary>
       /// Email Service
       /// </summary>
       /// <param name="messageBody"></param>
       /// <param name="emailId"></param>
       /// <returns>bool</returns>
        bool SendEmail(string messageBody, string emailId);
    }
}
