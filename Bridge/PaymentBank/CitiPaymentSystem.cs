using Bridge.Implementor;
using System;

namespace Bridge.PaymentBank
{
    /// <summary>
    /// ConcreteImplementor 
    /// </summary>
    public class CitiPaymentSystem : IPaymentSystem
    {
        public void ProcessPayment(string paymentSystem)
        {
            Console.WriteLine("Using CitiBank gateway for  " + paymentSystem);
        }
    }
}
