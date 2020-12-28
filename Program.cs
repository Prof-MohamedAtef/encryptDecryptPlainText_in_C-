using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DESCSharpProject
{

    /*public enum ProcessType
    {
        Encrypt, Decrypt
    }*/
     
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.ReadLine();
            Console.WriteLine("Welcome in DES Algorithm Encryptor and Decryptor");
            Console.ReadLine();
            Console.WriteLine("Which Process would you like to implement, Encryption or Decryption ?\nEnter 1 for Encryption\nEnter 2 for Decryption");
            string processChoice= Helper.setProcessType(Console.ReadLine());
            Console.WriteLine("You have selected:" + processChoice);
            Console.ReadLine();
            Console.WriteLine("Enter your Plain Text Message");
            string userPlainText = Console.ReadLine();
            Console.WriteLine("Plain Text Message \n("+userPlainText+")\nis being Encrypted ...");
            Console.ReadLine();
        }


        
    }
}