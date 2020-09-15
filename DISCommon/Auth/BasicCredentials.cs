using System;

namespace Com.Bigdata.Dis.Sdk.DISCommon.Auth
{
    public class BasicCredentials : ICredentials
    {
        private readonly string accessKey;
        private readonly string secretKey;
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
            //access key='';
            //secret key='';
            //huaweicloud myhuaweiclouds
            // 通过ak查询user  https://7819130ff14d4763971afcf82ba61acb.apigw.cn-north-4.huaweicloud.com/getUser?ak=4DKX9KS03M1XPSJKDQJD
            ak = '4DKX9KS03M1XPSJKDQJD';
            accessKey = '4DKX9KS03M1XPSJKDQJD';
            sk = 'Dkc9dk20d8n33oskKdckNkd99lKIjwnJIpkKInkO';
            secretKey = 'Dkc9dk20d8n33oskKdckNkd99lKIjwnJIpkKInkO';
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
