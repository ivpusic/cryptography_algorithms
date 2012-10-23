using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace cryptographyProject
{
    class DigSignatureHelper
    {
        /// <summary>
        /// Metoda za digitalno potpisivanje dokumenta
        /// </summary>
        /// <param name="file"></param>
        public void MakeDigitalSignature(string file)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            StreamReader streamReader = new StreamReader("privatni_kljuc.txt");
            string publicOnlyKeyXml = streamReader.ReadToEnd();
            rsa.FromXmlString(publicOnlyKeyXml);

            streamReader.Close();
            streamReader.Dispose();

            FileStream dat = new FileStream(file, FileMode.Open, FileAccess.Read);

            BinaryReader binReader = new BinaryReader(dat);
            byte[] data = binReader.ReadBytes((int)dat.Length);
            byte[] sign = rsa.SignData(data, "SHA1");

            binReader.Close();
            binReader.Dispose();
            dat.Close();
            dat.Dispose();

            string datName = file + ".dp";

            TextWriter tw = new StreamWriter(datName);
            tw.WriteLine(Convert.ToBase64String(sign));
            tw.Close();
            tw.Dispose();
        }

        /// <summary>
        /// Metoda za verifikaciju ispravnosti digitalnog potpisa dokumenta
        /// </summary>
        /// <param name="file"></param>
        public void VerifyDigitalSignature(string file)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            StreamReader streamReader = new StreamReader("javni_kljuc.txt");
            string publicKey = streamReader.ReadToEnd();
            rsa.FromXmlString(publicKey);
            streamReader.Close();
            streamReader.Dispose();

            FileStream dat = new FileStream(file, FileMode.Open, FileAccess.Read);
            BinaryReader binReader = new BinaryReader(dat);
            byte[] data = binReader.ReadBytes((int)dat.Length);
            string nameP = file + ".dp";

            TextReader streamreader = new StreamReader(nameP);
            string sign = streamreader.ReadLine();
            streamreader.Close();
            streamreader.Dispose();

            if (rsa.VerifyData(data, "SHA1", Convert.FromBase64String(sign)))
            {
                MessageBox.Show("Datoteka je ispravno potpisana", "My Application",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
                MessageBox.Show("Datoteka nije ispravno potpisana", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            binReader.Close();
            binReader.Dispose();
            dat.Close();
            dat.Dispose();
        }

    }
}
