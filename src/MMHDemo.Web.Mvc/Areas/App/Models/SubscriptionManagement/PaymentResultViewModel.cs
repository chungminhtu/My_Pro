using Abp.AutoMapper;
using MMHDemo.Editions;
using MMHDemo.MultiTenancy.Payments.Dto;

namespace MMHDemo.Web.Areas.App.Models.SubscriptionManagement
{
    [AutoMapTo(typeof(ExecutePaymentDto))]
    public class PaymentResultViewModel : SubscriptionPaymentDto
    {
        public EditionPaymentType EditionPaymentType { get; set; }
    }
}