using System.Threading.Tasks;
using Abp.Application.Services;
using MMHDemo.MultiTenancy.Payments.PayPal.Dto;

namespace MMHDemo.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
