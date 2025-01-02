using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace stock_manager
{
    internal class Backend_user
    {
        private const int HashSize = 20;
        private const int SaltSize = 16;
        private const int iterations = 10000;
        public static string HashPassword(string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            var hash = pbkdf2.GetBytes(HashSize);

            var hashBytes = new byte[SaltSize + HashSize];
            Array.Copy(salt, 0, hashBytes, 0, SaltSize);
            Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

            var base64Hash = Convert.ToBase64String(hashBytes);

            return string.Format("$MYHASH$V1${0}${1}", iterations, base64Hash);
        }
        public static bool VertifyPassword(string password, string storeHashpassword)
        {
            var splitHashString = storeHashpassword.Replace("$MYHASH$V1$", "").Split('$');
            //int newIterations = int.Parse(splitHashString[0]);
            var base64Hash = splitHashString[1];

            byte[] hashBytes = Convert.FromBase64String(base64Hash);

            byte[] salt = new byte[SaltSize];
            Array.Copy(hashBytes, 0, salt, 0, SaltSize);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            byte[] Hash = pbkdf2.GetBytes(HashSize);

            for (int i = 0; i < HashSize; i++)
            {
                if (hashBytes[i + SaltSize] != Hash[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
