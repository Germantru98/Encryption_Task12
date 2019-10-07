using System.Collections;
using System.Security.Cryptography;

namespace Encryption_Task12
{
    public class Encryptor
    {
        public byte[] CreateKey(int lengthKey)
        {
            byte[] key = new byte[lengthKey];
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetBytes(key);
            return key;
        }

        public bool LFSR()
        {
            BitArray initialStateRegister = new BitArray(CreateKey(32));
            bool outBit = initialStateRegister[0];
            bool newBit = initialStateRegister[0] ^ initialStateRegister[25] ^ initialStateRegister[27] ^ initialStateRegister[29] ^ initialStateRegister[30] ^ initialStateRegister[31];
            //цикл выполняет сдвиг битов в ячейках на одну позицию
            for (int i = 1; i < initialStateRegister.Length; i++)
            {
                initialStateRegister[i - 1] = initialStateRegister[i];
            }

            initialStateRegister[31] = newBit;
            return outBit;
        }

        //public byte[] Cipher(string plainText)
        //{
        //    byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
        //    byte[] cipherText = new byte[plainBytes.Length];
        //    bool[] oneByteKey = new bool[8];
        //    for (int i = 0; i < plainBytes.Length; i++)
        //    {
        //        for (int j = 0; j < oneByteKey.Length; j++)
        //        {
        //            oneByteKey[j] = LFSR();
        //        }
        //        cipherText[i] = (byte)(plainBytes[i] ^ oneByteKey);
        //    }

        //    return cipherText;
        //}
    }
}