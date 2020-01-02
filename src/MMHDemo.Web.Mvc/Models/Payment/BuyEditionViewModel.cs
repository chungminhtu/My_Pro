using System.Collections.Generic;
using MMHDemo.Editions;
using MMHDemo.Editions.Dto;
using MMHDemo.MultiTenancy.Payments;
using MMHDemo.MultiTenancy.Payments.Dto;

namespace MMHDemo.Web.Models.Payment
{
    public class BuyEditionViewModel
    {
        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}
