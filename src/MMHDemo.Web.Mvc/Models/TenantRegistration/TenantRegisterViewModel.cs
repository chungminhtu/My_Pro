using MMHDemo.Editions;
using MMHDemo.Editions.Dto;
using MMHDemo.MultiTenancy.Payments;
using MMHDemo.Security;
using MMHDemo.MultiTenancy.Payments.Dto;

namespace MMHDemo.Web.Models.TenantRegistration
{
    public class TenantRegisterViewModel
    {
        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public int? EditionId { get; set; }

        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }
    }
}
