using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace DataWeaver.Core
{
    public class GenerateString
    {
        public string Generate(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder result = new StringBuilder(length);
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                result.Append(chars[RandomNumberGenerator.GetInt32(chars.Length)]);
            }
            return result.ToString();
        }
        public string Generate(int length, string characterSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789")
        {
            if(characterSet == null || characterSet.Length == 0)
            {
                throw new ArgumentException("Character set cannot be null or empty.", nameof(characterSet));
            }
            StringBuilder result = new StringBuilder(length);
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                result.Append(characterSet[RandomNumberGenerator.GetInt32(characterSet.Length)]);
            }
            return result.ToString();
        }



    }
}
