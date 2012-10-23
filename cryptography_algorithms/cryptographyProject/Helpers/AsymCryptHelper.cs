using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace cryptographyProject
{
    class AsymCryptHelper : GenerateKeysHelper
    {
        /// <summary>
        /// Metoda za asimetrično kriptiranje
        /// </summary>
        /// <param name="file"></param>
        public void AsymetriycCrypt(string file)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            StreamReader streamReader = new StreamReader("javni_kljuc.txt");
            string publicKey = streamReader.ReadToEnd();
            rsa.FromXmlString(publicKey);
            streamReader.Close();

            string record = file + ".rsa";

            FileStream fstreamU = File.OpenRead(file),
            fstreamO = new FileStream(record, FileMode.Create, FileAccess.ReadWrite);

            BinaryWriter bw = new BinaryWriter(fstreamO);

            BinaryReader binReader = new BinaryReader(fstreamU);
            byte[] bytes = binReader.ReadBytes((int)fstreamU.Length);
            binReader.Close();

            byte[] crypt = rsa.Encrypt(bytes, false);

            bw.Write(crypt);
            bw.Flush();
            bw.Close();
            bw.Dispose();

            fstreamU.Close(); 
            fstreamU.Dispose();
        }

        /// <summary>
        /// Metoda za asimetrično dekriptiranje
        /// </summary>
        /// <param name="file"></param>
        public void AsymetriycDecrypt(string file)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            RSACryptoServiceProvider.UseMachineKeyStore = false;
            StreamReader streamReader = new StreamReader("privatni_kljuc.txt");
            string privateKey = streamReader.ReadToEnd();
            rsa.FromXmlString(privateKey);
            streamReader.Close();

            int indexEcb = file.LastIndexOf(".rsa");
            string zapis = file.Substring(0, indexEcb);

            FileStream fstreamU = File.OpenRead(file),
            fstreamO = new FileStream(zapis, FileMode.Create, FileAccess.ReadWrite);

            BinaryWriter bw = new BinaryWriter(fstreamO);
            BinaryReader binReader = new BinaryReader(fstreamU);
            byte[] bytes = binReader.ReadBytes((int)fstreamU.Length);

            binReader.Close();

            byte[] decrypt = rsa.Decrypt(bytes, false);
            bw.Write(decrypt);

            bw.Flush();
            bw.Close();
            bw.Dispose();

            fstreamU.Close();
            fstreamU.Dispose();
        }

    }
}
