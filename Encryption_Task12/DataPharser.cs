using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Encryption_Task12
{
    internal class DataPharser
    {
        public string Generate_Pseudorandom_KeyWord(int length, int startSeed, List<char> alphabet)
        {
            Random rand = new Random(startSeed);

            string result = "";

            for (int i = 0; i < length; i++)
                result += alphabet[rand.Next(0, alphabet.Count)];

            return result;
        }

        public string getMessage()
        {
            using (StreamReader stream = new StreamReader("Message.txt", Encoding.Default))
            {
                return stream.ReadToEnd().ToUpper();
            }
        }

        public List<char> GetAlphabet()
        {
            using (StreamReader stream = new StreamReader("Alphabet.txt", Encoding.Default))
            {
                return stream.ReadToEnd().ToList();
            }
        }
    }
}