using Bridge.Abstraction;
using Bridge.PaymentBank;
using Bridge.RefinedAbstraction;
using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Card payment
            Payment order = new CardPayment();
            order._IPaymentSystem = new CitiPaymentSystem();
            order.MakePayment();

            order._IPaymentSystem = new IDBIPaymentSystem();
            order.MakePayment();


            //NetBanking payment
            order = new NetBankingPayment();
            order._IPaymentSystem = new CitiPaymentSystem();
            order.MakePayment();

            Console.ReadKey();


        }
    }
}
