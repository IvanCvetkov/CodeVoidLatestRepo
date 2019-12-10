using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CodeVoidWPF.UserDB.Encryption
{
    public class PasswordEncryptor
    {
        TripleDESCryptoServiceProvider symm;
    
        #region Factory
        public PasswordEncryptor()
        {
            this.symm = new TripleDESCryptoServiceProvider();
            this.symm.Padding = PaddingMode.PKCS7;
        }
        public PasswordEncryptor(TripleDESCryptoServiceProvider keys)
        {
            this.symm = keys;
        }

        public PasswordEncryptor(byte[] key, byte[] iv)
        {
            this.symm = new TripleDESCryptoServiceProvider();
            this.symm.Padding = PaddingMode.PKCS7;
            this.symm.Key = key;
            this.symm.IV = iv;
        }

        public TripleDESCryptoServiceProvider Algorithm
        {
            get { return symm; }
            set { symm = value; }
        }
        public byte[] IV
        {
            get { return symm.IV; }
            set { symm.IV = value; }
        }
        public byte[] Key
        {
            get { return symm.Key; }
            set { symm.Key = value; }
        }
        

        public byte[] Encrypt(byte[] data) { return Encrypt(data, data.Length); }
        public byte[] Encrypt(byte[] data, int length)
        {
            try
            {
                var ms = new MemoryStream();

                var cs = new CryptoStream(ms,
                    symm.CreateEncryptor(symm.Key, symm.IV),
                    CryptoStreamMode.Write);

                cs.Write(data, 0, length);
                cs.FlushFinalBlock();

                byte[] ret = ms.ToArray();

                cs.Close();
                ms.Close();

                return ret;
            }
            catch (CryptographicException ex)
            {
                Console.WriteLine("A cryptographic error occured: {0}", ex.Message);
            }
            return null;
        }

        public string EncryptString(string text)
        {
            return Convert.ToBase64String(Encrypt(Encoding.UTF8.GetBytes(text)));
        }

        public byte[] Decrypt(byte[] data) { return Decrypt(data, data.Length); }
        public byte[] Decrypt(byte[] data, int length)
        {
            try
            {
                MemoryStream ms = new MemoryStream(data);

                CryptoStream cs = new CryptoStream(ms,
                    symm.CreateDecryptor(symm.Key, symm.IV),
                    CryptoStreamMode.Read);

                byte[] result = new byte[length];

                cs.Read(result, 0, result.Length);
                return result;
            }
            catch (CryptographicException ex)
            {
                Console.WriteLine("A cryptographic error occured: {0}", ex.Message);
            }
            return null;
        }

        public string DecryptString(string data)
        {
            return Encoding.UTF8.GetString(Decrypt(Convert.FromBase64String(data))).TrimEnd('\0');
        }

        #endregion

    }
}
