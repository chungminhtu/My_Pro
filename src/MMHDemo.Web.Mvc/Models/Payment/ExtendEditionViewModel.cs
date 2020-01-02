using System.Collections.Generic;
using MMHDemo.Editions.Dto;
using MMHDemo.MultiTenancy.Payments;

namespace MMHDemo.Web.Models.Payment
{
    public class ExtendEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}