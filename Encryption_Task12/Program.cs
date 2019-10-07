using System;
using System.IO;

namespace Encryption_Task12
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Encryptor encryptor = new Encryptor();
            DataPharser dataPharser = new DataPharser();
            var key = encryptor.CreateKey(6);
            string text = dataPharser.getMessage();
            using (StreamReader sr = new StreamReader("Input.txt", System.Text.Encoding.Default, false))
            {
                text = sr.ReadLine();
            }
            LFSR t1 = new LFSR(text, 0, "10001110101011101110000111");
            Console.WriteLine("Текст: {0}", t1.CleanText);
            Console.WriteLine("Ключ: {0}", t1.Key);
            Console.WriteLine("Последовательность текста: {0}", t1.TextKey);
            Console.WriteLine("Псевдослучайная последовательность: {0}", t1.RandomKey);
            Console.WriteLine("Зашифрованный текст: {0}", t1.EncryptedText);
            Console.WriteLine("Расшифрованный текст: {0}", t1.DecryptedText);
            Console.Read();
            using (StreamWriter sw = new StreamWriter("Output.txt"))
            {
                sw.WriteLine(t1.EncryptedText);
                sw.WriteLine(t1.DecryptedText);
            }
        }
    }
}