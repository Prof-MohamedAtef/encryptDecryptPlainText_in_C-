using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace DESCSharpProject
{

    /*public enum ProcessType
    {
        Encrypt, Decrypt
    }*/
     
    class Program
    {
        public static bool fontChanged;
        public static bool backgroundChanged;
        public static DESCryptoServiceProvider desProvider;
        static void Main(string[] args)
        {
            changingColors();
            DESAlgorithmImplementation();
        }

        private static void changingColors()
        {
            Console.ReadLine();
            Console.WriteLine("Select Colors of your choice :\nfor background color enter 1\nfor foreground color enter 2");
            string colorsChangingChoice = Console.ReadLine();
            if (colorsChangingChoice == "1")
            {
                backgroundChanged = true;
                changeBackColor();
            }
            else if (colorsChangingChoice == "2")
            {
                fontChanged = true;
                changeColorFont();
            }
            if (!fontChanged)
            {
                changeColorFont();
            }
            if (!backgroundChanged)
            {
                changeBackColor();
            }
        }

        private static void changeBackColor()
        {
            Console.WriteLine("Select background color\n\nfor Red press 1\nfor Green press 2\nfor Blue press 3\n for White press 4");
            string selectedBackgroundColor = Console.ReadLine();
            if (selectedBackgroundColor == "1")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
            }
            else if (selectedBackgroundColor == "2")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
            }
            else if (selectedBackgroundColor == "3")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
            }
            else if (selectedBackgroundColor == "4")
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
            }
        }

        private static void changeColorFont()
        {
            Console.ReadLine();
            Console.WriteLine("Change color font\n\nfor Red press 1\nfor Green press 2\nfor Blue press 3\n for White press 4");
            string selectedFontColor = Console.ReadLine();
            if (selectedFontColor == "1")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
            }
            else if (selectedFontColor == "2")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
            }
            else if (selectedFontColor == "3")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Clear();
            }
            else if (selectedFontColor == "4")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
            }
        }

        private static void DESAlgorithmImplementation()
        {
            desProvider = new DESCryptoServiceProvider();
            Console.ReadLine();
            Console.WriteLine("Welcome in DES Algorithm Encryptor and Decryptor");
            Console.ReadLine();
            Console.WriteLine("Which Process would you like to implement, Encryption or Decryption ?\nEnter 1 for Encryption\nEnter 2 for Decryption");
            string processChoice = Helper.setProcessType(Console.ReadLine());
            Console.WriteLine("You have selected:" + processChoice);
            Console.ReadLine();
            Console.WriteLine("Enter your Plain Text Message");
            string userPlainText = Console.ReadLine();
            Console.WriteLine("Plain Text Message \n(" + userPlainText + ")\nis being Encrypted ...");
            Console.ReadLine();
            string cipherText = Encryptor.Encrypt(userPlainText, desProvider);
            Console.WriteLine("Cipher Text is:\n(" + cipherText);
            Console.ReadLine();

            Console.WriteLine("Do you want to Decrypt Cipher ?\nEnter 1 for Yes\nEnter 2 for No");
            string decryptionAnswer = Console.ReadLine();
            if (decryptionAnswer == "1")
            {
                Console.WriteLine(Decryptor.Decrypt(cipherText, desProvider));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Good Bey ...");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
    }
}