using Bridge.Implementor;
using System;

namespace Bridge.PaymentBank
{
    public class IDBIPaymentSystem : IPaymentSystem
    {
        public void ProcessPayment(string paymentSystem)
        {
            Console.WriteLine("Using IDBIBank gateway for  " + paymentSystem);
        }
    }
}
