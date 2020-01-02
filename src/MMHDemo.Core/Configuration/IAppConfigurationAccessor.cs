using Microsoft.Extensions.Configuration;

namespace MMHDemo.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
