using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace cryptographyProject
{
    class SyncCryptHelper : GenerateKeysHelper
    {
        public int BufferSize { get; set; }

        /// <summary>
        /// Konstruktor
        /// </summary>
        public SyncCryptHelper()
        {
            BufferSize = 128 * 1024;
        }

        /// <summary>
        /// Metoda za simetrično kriptiranje
        /// </summary>
        /// <param name="file"></param>
        public void SyncCrypt(string file)
        {
            string zapis;
            zapis = file + ".ecb";
            FileStream fstreamU = File.OpenRead(file),
            fstreamO = File.OpenWrite(zapis);
            long lSize = fstreamU.Length;

            byte[] bytes = new byte[BufferSize];
            int read = -1;

            Rijndael rijndaelAlg = Rijndael.Create();
            rijndaelAlg.Mode = CipherMode.ECB;
            TextReader streamreader = new StreamReader("tajni_kljuc.txt");
            string secretKey = streamreader.ReadLine();
            rijndaelAlg.Key = Convert.FromBase64String(secretKey);
            streamreader.Close();

            CryptoStream cout = new CryptoStream(fstreamO, rijndaelAlg.CreateEncryptor(), CryptoStreamMode.Write);

            BinaryWriter bw = new BinaryWriter(cout);
            bw.Write(lSize);

            while ((read = fstreamU.Read(bytes, 0, bytes.Length)) != 0)
            {
                cout.Write(bytes, 0, read);
            }

            cout.Flush();
            cout.Close();
            cout.Dispose();
            fstreamU.Flush();
            fstreamU.Close();
            fstreamU.Dispose();
        }

        /// <summary>
        /// Metoda za asimetrično kriptiranje
        /// </summary>
        /// <param name="file"></param>
        /// <param name="decryptedFile"></param>
        public void SyncDecrypt(string file, string decryptedFile)
        {
            FileStream fstreamU = File.OpenRead(file), fstreamO = File.OpenWrite(decryptedFile);

            byte[] bytes = new byte[BufferSize];
            int read = -1;

            SymmetricAlgorithm sma = Rijndael.Create();
            sma.Mode = CipherMode.ECB;

            TextReader tr = new StreamReader("tajni_kljuc.txt");
            string secretKey = tr.ReadLine();
            sma.Key = Convert.FromBase64String(secretKey);
            tr.Close();

            CryptoStream cin = new CryptoStream(fstreamU, sma.CreateDecryptor(), CryptoStreamMode.Read);
            {
                BinaryReader br = new BinaryReader(cin);
                long lSize = br.ReadInt64();

                long numReads = lSize / BufferSize;

                long slack = (long)lSize % BufferSize;

                for (int i = 0; i < numReads; ++i)
                {
                    read = cin.Read(bytes, 0, bytes.Length);
                    fstreamO.Write(bytes, 0, read);
                }
                if (slack > 0)
                {
                    read = cin.Read(bytes, 0, (int)slack);
                    fstreamO.Write(bytes, 0, read);
                }
                fstreamO.Flush();
                fstreamO.Close();
                fstreamO.Dispose();
            }
        }
    }
}
