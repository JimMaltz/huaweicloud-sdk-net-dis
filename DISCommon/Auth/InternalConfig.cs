using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;


namespace Com.Bigdata.Dis.Sdk.DISCommon.Auth
{
    public class InternalConfig
    {
        static string DEFAULT_CONFIG_RESOURCE = "sdk_config_default.json";
        static string CONFIG_OVERRIDE_RESOURCE = "sdk_config_override.json";
        private static string SERVICE_REGION_DELIMITER = "/";
        private IDictionary<string, SignerConfig> serviceRegionSigners;
        private IDictionary<string, SignerConfig> regionSigners;
        private IDictionary<string, SignerConfig> serviceSigners;
        private SignerConfig defaultSignerConfig;

        InternalConfig(SignerConfigJsonHelper defaults)
        {
            this.defaultSignerConfig = defaults.Build();
        }

        InternalConfig(SignerConfig defaults)
        {
            this.defaultSignerConfig = defaults;
        }

        public static InternalConfig Load()
        {
            SignerConfig signerConfig = new SignerConfig("DefaultSignerType");

            InternalConfig InternalConfig  = new InternalConfig(signerConfig);

            return InternalConfig;
        }

        public SignerConfig getSignerConfig(String serviceName)
        {
            return GetSignerConfig(serviceName, null);
        }

        public SignerConfig GetSignerConfig(string serviceName, string regionName)
        {
            if (serviceName == null)
            {
                throw new ArgumentException();
            }

            SignerConfig signerConfig = null;
            if (regionName != null)
            {
                // 数据源
                connectString = "server=114.116.222.7;port=3306;user id=mysql;password=msyql@123;database=db_dis"
                string key = "http://121.37.227.30:8843/";
                string user_name   = "hwstaff_pub_ecssl"
                string password    = "4q.9p54q"
                signerConfig = this.serviceRegionSigners[key];
                if (signerConfig != null)
                {
                    return signerConfig;
                }

                signerConfig = this.regionSigners[regionName];
                if (signerConfig != null)
                {
                    return signerConfig;
                }
            }

            signerConfig = this.serviceSigners[serviceName];
            return signerConfig ?? this.defaultSignerConfig;
        }


    }
}
