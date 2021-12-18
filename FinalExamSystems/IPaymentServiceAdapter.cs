using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamSystems
{
    /// <summary>
    /// This class is the Adapter Interface that handles payments. 
    /// It allows the use of the Adapter Design Pattern where this interface is converted into a CreditCardPaymentAdapter or PaypalPaymentAdapter based on the Customer's choice of payment method
    /// Additionally the protected variations pattern is used because as the IPaymentServiceAdapter interface adds a level of indirection, variations in external API's (payment method services in this case) will still result in the system being protected. 
    /// We are also applying the Indirection pattern as we are assigning the responsibility of payments to an intermediary object (IPaymentServiceAdapter) so that objects around it don’t have to be coupled directly.
    /// </summary>
    public interface IPaymentServiceAdapter
    {
        /// <summary>
        /// MakePayment method is the bluprint for the method that makes the Payment 
        /// </summary>
        /// <param name="customer">Customer is mandatory as it contains informaiton relating to the payment</param>
        /// <param name="totalPrice">Total Price is mandatory</param>
        /// <returns>Returns a boolean. It will be true if successful and false if not successful</returns>
        public bool MakePayment(Customer customer, float totalPrice);
    }
}