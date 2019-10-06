using System;

namespace Encryption_Task12
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DataPharser dp = new DataPharser();
            Encryptor encryptor = new Encryptor();
            var message = dp.getMessage();
            var alphabet = dp.GetAlphabet();
            var keyWord = dp.Generate_Pseudorandom_KeyWord(message.Length, 8, alphabet);
            var encryptedMessage = encryptor.Encrypt(message, keyWord);
            Console.WriteLine(encryptedMessage);
            var decryptedMessage = encryptor.Decrypt(encryptedMessage, keyWord);
            Console.WriteLine(decryptedMessage);
        }
    }
}