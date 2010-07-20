using System;
using System.IO;
using System.Security.Cryptography;
using Microsoft.Practices.EnterpriseLibrary.Security.Cryptography;
using System.Text;

namespace Mds.Biodata.Helpers
{
    public class CryptoHelper
    {
        private const string SHA_PROVIDER_NAME = "SHA1Managed";
        private const string MD5_PROVIDER_NAME = "MD5CryptoServiceProvider";

        public static string HashSHA(string cleanString)
        {
            string generatedHash = Cryptographer.CreateHash(SHA_PROVIDER_NAME, cleanString);
            return generatedHash;
        }

        public static bool ComparePasswordSHA(string passwordEntered, string passwordHashed)
        {
            return Cryptographer.CompareHash(SHA_PROVIDER_NAME, passwordEntered, passwordHashed);
        }

        public static string HashMD5(string cleanString)
        {
            string generatedHash = Cryptographer.CreateHash(MD5_PROVIDER_NAME, cleanString);
            return generatedHash;
        }

        public static bool ComparePasswordMD5(string passwordEntered, string passwordHashed)
        {
            return Cryptographer.CompareHash(MD5_PROVIDER_NAME, passwordEntered, passwordHashed);
        }

        public static string HashMD5CompatiblePHP(string cleanString)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            byte[] dataMd5 = md5.ComputeHash(Encoding.Default.GetBytes(cleanString));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < dataMd5.Length; i++)
                sb.AppendFormat("{0:x2}", dataMd5[i]);
            return sb.ToString();
        }

        public static string Encrypt(string cleanString)
        {
            string encryptedPassword = Cryptographer.EncryptSymmetric("RijndaelManaged", cleanString);
            return encryptedPassword;
        }

        public static string Decrypt(string encryptedString)
        {
            string cleanString = Cryptographer.DecryptSymmetric("RijndaelManaged", encryptedString);
            return cleanString;
        }

    }
}