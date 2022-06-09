using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using PaymentMethod.Services.Requests;
using PaymentMethod.Services.Results;

namespace PaymentMethod.Services
{
    public interface IPaymentProvider
    {
        Task<PaymentGatewayResult> ThreeDGatewayRequest(PaymentGatewayRequest request);
        Task<VerifyGatewayResult> VerifyGateway(VerifyGatewayRequest request, PaymentGatewayRequest gatewayRequest, IFormCollection form);
        Task<CancelPaymentResult> CancelRequest(CancelPaymentRequest request);
        Task<RefundPaymentResult> RefundRequest(RefundPaymentRequest request);
        Task<PaymentDetailResult> PaymentDetailRequest(PaymentDetailRequest request);
        Dictionary<string, string> TestParameters { get; }
    }
}