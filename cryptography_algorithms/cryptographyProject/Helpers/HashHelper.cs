using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace cryptographyProject
{
    class HashHelper
    {
        /// <summary>
        /// Metoda za izračunavanje sažetka
        /// </summary>
        /// <param name="file"></param>
        /// <returns>SHA1 sažetak</returns>
        public string CalculateSHA1Hash(string file)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            FileStream fstreamU = File.OpenRead(file);
            int size = (int)fstreamU.Length;
            byte[] sadrzaj = new byte[size];
            fstreamU.Read(sadrzaj, 0, size);

            fstreamU.Flush();
            fstreamU.Close();
            fstreamU.Dispose();

            byte[] tmpHash;
            tmpHash = sha1.ComputeHash(sadrzaj);
            StringBuilder sOuput = new StringBuilder(tmpHash.Length);

            for (int i = 0; i < tmpHash.Length; i++)
            {
                sOuput.Append(tmpHash[i].ToString("x2"));
            }
            return sOuput.ToString(); 
        }
    }
}
