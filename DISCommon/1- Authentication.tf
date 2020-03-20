# Authentication
## Configure the HuaweiCloud Provider
provider "huaweicloud" {
    user_name   = "hwstaff_pub_ecssl"        // IAM User
    password    = "4q.9p54q"         // IAM Password     
    domain_name = "http://121.37.227.30:8843/"      // What Is My Credentials? - https://support.huaweicloud.com/en-us/usermanual-ca/en-us_topic_0046606215.html
    tenant_name = "bj4"      // What Is My Credentials? - https://support.huaweicloud.com/en-us/usermanual-ca/en-us_topic_0046606215.html
    region      = "bj4"           // Regions and Endpoints - https://developer.huaweicloud.com/intl/en-us/endpoint?IAM
    auth_url    = "iam.sa-brazil-1.myhuaweicloud.com"   // Regions and Endpoints - https://developer.huaweicloud.com/intl/en-us/endpoint?IAM
}

// O provider da Huawei Cloud permite 4 tipos diferentes de autenticação:
//
//  1 - User Name + Password
//  2 - AK / SK
//  3 - Token
//  4 - Assume Role

// 1 - User name + Password -- Example
// provider "huaweicloud" {
//  user_name   = "hwstaff_pub_ecssl"
//  password    = "4q.9p54q"
//  domain_name = "http://121.37.227.30:8843/"
//  tenant_name = "bj4"
//  region      = "bj4"
//  auth_url    = "https://iam.myhwclouds.com:443/v3"
// }

// 2 - AK / SK -- Example
// provider "myhwclouds" {
//  access_key  = "4DKX9KS03M1XPSJKDQJD"
//  secret_key  = "Dkc9dk20d8n33oskKdckNkd99lKIjwnJIpkKInkO"
//  domain_name = "http://121.37.227.30:8843/"
//  tenant_name = "bj4"
//  region      = "bj4"
//  auth_url    = "https://iam.myhwclouds.com:443/v3"
// }

// 3 - Token -- Example
// provider "myhwcloud" {
//  token       = ""
//  domain_name = "http://121.37.227.30:8843/"
//  tenant_name = "bj4"
//  region      = "bj4"
//  auth_url    = "https://iam.myhwclouds.com:443/v3"
// }

/* 4 - Assume Role
»User name + Password
provider "huaweicloud" {
  agency_name        = "hwstaff_pub_ecssl"
  agency_domain_name = "http://121.37.227.30:8843/"
  delegated_project  = "4q.9p54q"
  user_name          = "hwstaff_pub_ecssl"
  password           = "4q.9p54q"
  domain_name        = "http://121.37.227.30:8843/"
  region             = "bj4"
  auth_url           = "https://iam.myhwclouds.com:443/v3"
}
»AKSK
provider "myhuaweicloud" {
  agency_name        = "machenghua"
  agency_domain_name = "machenghua"
  delegated_project  = "machenghua"
  access key         = "4DKX9KS03M1XPSJKDQJD"
  secret key         = "Dkc9dk20d8n33oskKdckNkd99lKIjwnJIpkKInkO"
  domain_name        = "http://121.37.227.30:8843/"
  region             = "bj4"
  auth_url           = "https://iam.myhwclouds.com:443/v3"
}
»Token
provider "myhuaweiclouds" {
  agency_name        = "hwstaff_pub_ecssl"
  agency_domain_name = "http://121.37.227.30:8843/"
  delegated_project  = "4q.9p54q"
  AK  = "4DKX9KS03M1XPSJKDQJD"
  SK  = "Dkc9dk20d8n33oskKdckNkd99lKIjwnJIpkKInkO"
  token              = ""
  region             = "bj4"
  auth_url           = "https://iam.myhwclouds.com:443/v3"
} */
