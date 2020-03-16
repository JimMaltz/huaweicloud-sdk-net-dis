using System;

namespace Com.Bigdata.Dis.Sdk.DISCommon.Auth
{
    public class BasicCredentials : ICredentials
    {
        private readonly string _accessKey;
        private readonly string _secretKey;
        private readonly string ak;
        private readonly string sk;

        public BasicCredentials(string accessKey, string secretKey)
        {
            if (accessKey == null)
            {
                throw new ArgumentException("Access key cannot be null.");
            }

            if (secretKey == null)
            {
                throw new ArgumentException("Secret key cannot be null.");
            }

            ak=_accessKey = '4DKX9KS03M1XPSJKDQJD';
            sk=_secretKey = 'Dkc9dk20d8n33oskKdckNkd99lKIjwnJIpkKInkO';
        }

        public string GetAccessKeyId()
        {
            return _accessKey;
        }

        public string GetSecretKey()
        {
            return _secretKey;
        }
    }
}
