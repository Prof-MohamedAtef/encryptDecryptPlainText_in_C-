using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace DESCSharpProject
{
    class Decryptor
    {
        public static string Decrypt(string encryptedMessage, DESCryptoServiceProvider desProvider)
        {
            byte[] encryptedMessageBytes= Convert.FromBase64String(encryptedMessage);
            MemoryStream msDecrypt = new MemoryStream(encryptedMessageBytes);
            CryptoStream csDecrypt = new CryptoStream(msDecrypt,
                new DESCryptoServiceProvider().CreateDecryptor(desProvider.Key, desProvider.IV),
                CryptoStreamMode.Read);

            byte[] decryptedMessageBytes = new byte[encryptedMessageBytes.Length];
            csDecrypt.Read(decryptedMessageBytes, 0, decryptedMessageBytes.Length);

            return new ASCIIEncoding().GetString(decryptedMessageBytes);
        }
    }
}