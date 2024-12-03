using System;
using System.Security.Cryptography;

namespace PassMan
{
    public class HasherService
    {
        private const int _saltSize = 16; // 128 bits
        private const int _keySize = 20;
        private const int _iterations = 10000;

        public static string HashPass2(string password)
        {
            // Create salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[_saltSize]);

            // Create Hash
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, _iterations);
            byte[] hash = pbkdf2.GetBytes(_keySize);

            // Combine salt and Hash
            byte[] hashBytes = new byte[_saltSize + _keySize];
            Array.Copy(salt, 0, hashBytes, 0, _saltSize);
            Array.Copy(hash, 0, hashBytes, _saltSize, _keySize);

            // Convert to base64
            var base64Hash = Convert.ToBase64String(hashBytes);
            return base64Hash;
        }

        public static bool Verify(string password, string hashedPassword)
        {
            // Get hash bytes
            var hashBytes = Convert.FromBase64String(hashedPassword);

            // Get salt
            var salt = new byte[_saltSize];
            Array.Copy(hashBytes, 0, salt, 0, _saltSize);

            // Create hash with given salt
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, _iterations);
            byte[] hash = pbkdf2.GetBytes(_keySize);

            // Get result
            for (var i = 0; i < _keySize; i++)
            {
                if (hashBytes[i + _saltSize] != hash[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
