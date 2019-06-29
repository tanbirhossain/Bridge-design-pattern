﻿using Bridge.Implementor;

namespace Bridge.Abstraction
{
    public abstract class Payment
    {
        public IPaymentSystem _IPaymentSystem;
        public abstract void MakePayment();
    }
}
