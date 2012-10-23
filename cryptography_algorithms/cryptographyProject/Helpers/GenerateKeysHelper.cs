using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace cryptographyProject
{
    abstract class GenerateKeysHelper
    {
        /// <summary>
        /// Metoda za generiranje privatnog i javnog ključa
        /// </summary>
        public void GenerytePrivatePublicKey()
        {
            RSACryptoServiceProvider rsaProvider = new RSACryptoServiceProvider();

            string publicKey = rsaProvider.ToXmlString(false);
            string privateKey = rsaProvider.ToXmlString(true);
            TextWriter streamwriter = new StreamWriter("javni_kljuc.txt");
            TextWriter streamwriterSecond = new StreamWriter("privatni_kljuc.txt");
            streamwriter.WriteLine(publicKey);
            streamwriterSecond.WriteLine(privateKey);
            streamwriterSecond.Close();
            streamwriter.Close();

            streamwriter.Dispose();
            streamwriterSecond.Dispose();
        }

        /// <summary>
        /// Metoda za generiranje tajnog ključa
        /// </summary>
        public void GenerateSecretKey()
        {
            Rijndael rijndael = Rijndael.Create();
            string keyb64 = Convert.ToBase64String(rijndael.Key);
            TextWriter streamwriter = new StreamWriter("tajni_kljuc.txt");
            streamwriter.WriteLine(keyb64);
            streamwriter.Close();
            streamwriter.Dispose();
        }

    }
}
