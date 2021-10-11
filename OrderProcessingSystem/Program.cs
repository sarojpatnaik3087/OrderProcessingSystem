using System;
using OrderProcessingSystem.BusinessLayer;

namespace OrderProcessingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Facade Pattern helps here to maintain an abstraction.. how downstream objects are created which client shouldn't know.
           var productFacade = new ProductFacade("OnceInaWhile", 2000, "validemailid@gmail.com");
           productFacade.BookPayment();
        }
    }
}
