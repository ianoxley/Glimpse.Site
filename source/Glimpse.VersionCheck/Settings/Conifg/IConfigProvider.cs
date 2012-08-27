using System.Data.Common;

namespace Glimpse.VersionCheck
{
    public interface IConfigProvider
    {
        string GetAppSetting(string name);

        DbProviderFactory GetDbProviderFactory(string connectionStringName);

        string GetConnectionString(string connectionStringName);

        T GetSection<T>(string name) where T : class;
    }
}