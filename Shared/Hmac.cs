using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace IdealResidencia.Shared
{
    public static class Hmac
    {
        private static string DefaultSignatureKey = "sig";
        private static string salt = "H*2Tpa[%Tz8pPwq^LKwL,$OxBO$Nh.@@xc^7[C_[c>u^QSivj'^7w)dESYm-UOIY";
        private static byte[] secretKey = Hmac.Sha256(ConfigurationManager.ConnectionStrings["DASConStr"].ToString() + Hmac.salt);

        public static byte[] Sha256(string text)
        {
            return new SHA256Managed().ComputeHash(Encoding.UTF8.GetBytes(text));
        }

        public static byte[] Sign(string message)
        {
            return new HMACSHA256(Hmac.secretKey).ComputeHash(Encoding.UTF8.GetBytes(message));
        }

        public static string SignUrl(string urlQuerystring)
        {
            return Hmac.SignUrl(urlQuerystring, new DateTime?());
        }

        public static string SignUrl(string urlQuerystring, DateTime? timeout)
        {
            return Hmac.SignUrl(urlQuerystring, timeout, Hmac.DefaultSignatureKey);
        }

        public static string SignUrl(string urlQuerystring, DateTime? timeout, string signatureKey)
        {
            if (timeout.HasValue)
                urlQuerystring = urlQuerystring + "&ts=" + HttpUtility.UrlEncode(timeout.Value.ToString("r"));
            byte[] inArray = Hmac.Sign(urlQuerystring);
            return string.Format("{0}&{1}={2}", (object)urlQuerystring, (object)signatureKey, (object)HttpUtility.UrlEncode(Convert.ToBase64String(inArray)));
        }

        public static bool Validate(string message, string signature)
        {
            return Hmac.Validate(message, Convert.FromBase64String(signature));
        }

        public static bool Validate(string message, byte[] signature)
        {
            byte[] numArray = Hmac.Sign(message);
            return ((IEnumerable<byte>)signature).SequenceEqual<byte>((IEnumerable<byte>)numArray);
        }

        public static bool ValidateRequest(Uri uri)
        {
            return Hmac.ValidateRequest(uri, Hmac.DefaultSignatureKey);
        }

        public static bool ValidateRequest(Uri uri, string signatureKey)
        {
            try
            {
                UriBuilder uriBuilder = new UriBuilder(uri);
                NameValueCollection queryString = HttpUtility.ParseQueryString(uri.Query);
                string signature = queryString[signatureKey];
                queryString.Remove(signatureKey);
                uriBuilder.Query = queryString.ToString();
                bool flag = Hmac.Validate(uriBuilder.Uri.PathAndQuery, signature);
                if (flag && queryString["ts"] != null && DateTime.ParseExact(queryString["ts"], "r", (IFormatProvider)null) < DateTime.UtcNow)
                    return false;
                return flag;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
