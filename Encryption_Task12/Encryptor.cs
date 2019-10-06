namespace Encryption_Task12
{
    public class Encryptor
    {
        private string GetRepeatKey(string s, int n)
        {
            var r = s;
            while (r.Length < n)
            {
                r += r;
            }

            return r.Substring(0, n);
        }

        private string Cipher(string text, string secretKey)
        {
            var currentKey = GetRepeatKey(secretKey, text.Length);
            var res = string.Empty;
            for (var i = 0; i < text.Length; i++)
            {
                res += ((char)(text[i] ^ currentKey[i])).ToString();
            }

            return res;
        }

        public string Encrypt(string plainText, string keyWord)
            => Cipher(plainText, keyWord);

        public string Decrypt(string encryptedText, string keyWord)
            => Cipher(encryptedText, keyWord);
    }
}