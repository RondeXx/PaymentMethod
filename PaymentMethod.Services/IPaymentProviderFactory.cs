using System;
using System.Collections.Generic;

namespace PaymentMethod.Services
{
    public interface IPaymentProviderFactory
    {
        IPaymentProvider Create(BankNames bankName);
        string CreatePaymentFormHtml(IDictionary<string, object> parameters, Uri actionUrl, bool appendFormSubmitScript = true);
    }
}