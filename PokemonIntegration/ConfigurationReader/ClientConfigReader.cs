using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonIntegration.Configuration
{
    public static class ClientConfigReader
	{
        public static string GetApiHost()
        {
            string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Configuration", "ServiceModel", "Client.config");

            var configMap = new ExeConfigurationFileMap
            {
                ExeConfigFilename = configPath
            };

            var config = System.Configuration.ConfigurationManager.OpenMappedExeConfiguration(configMap, ConfigurationUserLevel.None);
            var host = config.AppSettings.Settings["PokeHost"]?.Value;
            return host;
        }

    }
}
