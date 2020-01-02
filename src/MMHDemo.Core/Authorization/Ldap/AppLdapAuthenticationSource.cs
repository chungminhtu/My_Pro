using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using MMHDemo.Authorization.Users;
using MMHDemo.MultiTenancy;

namespace MMHDemo.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}