using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace DESCSharpProject
{
    class Encryptor
    {
        public static string Encrypt(string plainTextMessage, DESCryptoServiceProvider desProvider)
        {
            byte[] messageBytes = ASCIIEncoding.ASCII.GetBytes(plainTextMessage);

            
            ICryptoTransform transform = desProvider.CreateEncryptor(desProvider.Key, desProvider.IV);
            CryptoStreamMode mode = CryptoStreamMode.Write;

            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStyream = new CryptoStream(memoryStream, transform, mode);
            cryptoStyream.Write(messageBytes, 0, messageBytes.Length);
            Console.WriteLine("Plain Text Length is: "+messageBytes.Length.ToString());
            cryptoStyream.FlushFinalBlock();

            byte[] encryptedMessageBytes = new byte[memoryStream.Length];

            memoryStream.Position = 0;
            memoryStream.Read(encryptedMessageBytes, 0, encryptedMessageBytes.Length);

            return Convert.ToBase64String(encryptedMessageBytes);
        }  
    }
}