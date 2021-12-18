using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamSystems
{
    /// <summary>
    /// This class is the Paypal Payment Adapter that handles payments using Paypal
    /// </summary>
    public class PaypalPaymentAdapter : IPaymentServiceAdapter
    {
        /// <summary>
        /// MakePayment method is the implemented method from the PaymentServiceAdapter that makes a Paypal Payment
        /// </summary>
        /// <param name="customer">Customer is mandatory as it contains informaiton relating to the payment</param>
        /// <param name="totalPrice">Total Price is mandatory</param>
        /// <returns>Returns a boolean. It will be true if successful and false if not successful</returns>
        public bool MakePayment(Customer customer, float totalPrice)
        {
            Console.WriteLine($"Customer {customer.FirstName} paying ${totalPrice} by Paypal");
            throw new NotImplementedException();
        }
    }
}