using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cryptographyProject
{
    public partial class MainForm : Form
    {

    #region Class members
        private AsymCryptHelper _asymCryptHelper = new AsymCryptHelper();
        private DigSignatureHelper _digSignatureHelper = new DigSignatureHelper();
        private SyncCryptHelper _syncCryptHelper = new SyncCryptHelper();
        private HashHelper _hashHelper = new HashHelper();
    #endregion

        /// <summary>
        /// Konstruktor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

    #region Form event handlers
        private void btnDigSign_Click(object sender, EventArgs e)
        {
            try
            {
                string file = txtFile.Text;
                _digSignatureHelper.MakeDigitalSignature(file);
                MessageBox.Show("Datoteka je potpisana", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dogodila se pogreška!\n" + ex.Message, "My Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDigSignVerify_Click(object sender, EventArgs e)
        {
            try
            {
                string file = txtFile.Text;
                _digSignatureHelper.VerifyDigitalSignature(file);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dogodila se pogreška!\n" + ex.Message, "My Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnGenAsnycKeys_Click(object sender, EventArgs e)
        {
            try
            {
                _asymCryptHelper.GenerytePrivatePublicKey();
                MessageBox.Show("Ključevi generirani!", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dogodila se pogreška!\n" + ex.Message, "My Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAsyncCrypt_Click(object sender, EventArgs e)
        {
            try
            {
                _asymCryptHelper.AsymetriycCrypt(txtFile.Text);
                MessageBox.Show("Datoteka je kriptirana", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dogodila se pogreška!\n" + ex.Message, "My Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAsyncDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                _asymCryptHelper.AsymetriycDecrypt(txtFile.Text);
                MessageBox.Show("Datoteka je dekriptirana", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dogodila se pogreška!\n" + ex.Message, "My Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnOpenDat_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                txtFile.Clear();

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    txtFile.Text = openFileDialog1.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dogodila se pogreška!\n" + ex.Message, "My Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSynCrypt_Click(object sender, EventArgs e)
        {
            try
            {
                _syncCryptHelper.SyncCrypt(txtFile_second_tab.Text);
                MessageBox.Show("Datoteka je kriptirana", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dogodila se pogreška!\n" + ex.Message, "My Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSymDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string inFile = txtFile_second_tab.Text;

                int indexECB = inFile.LastIndexOf(".ecb");
                string outFileECB = inFile.Substring(0, indexECB);
                _syncCryptHelper.SyncDecrypt(inFile, outFileECB);
                MessageBox.Show("Datoteka je dekriptirana", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dogodila se pogreška!\n" + ex.Message, "My Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void genSymKey_Click(object sender, EventArgs e)
        {
            try
            {
                _syncCryptHelper.GenerateSecretKey();
                MessageBox.Show("Tajni ključ je generiran", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dogodila se pogreška!\n" + ex.Message, "My Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCalcHash_Click(object sender, EventArgs e)
        {
            try
            {
                string sazetak = _hashHelper.CalculateSHA1Hash(txtSazetakFile.Text);
                txtSazetak.Text = sazetak;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dogodila se pogreška!\n" + ex.Message, "My Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpnDat_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog_second_tab = new OpenFileDialog();
                txtFile_second_tab.Clear();

                if (openFileDialog_second_tab.ShowDialog() == DialogResult.OK)
                    txtFile_second_tab.Text = openFileDialog_second_tab.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dogodila se pogreška!\n" + ex.Message, "My Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpeDat_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                txtSazetakFile.Clear();

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    txtSazetakFile.Text = openFileDialog1.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dogodila se pogreška!\n" + ex.Message, "My Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
#endregion

    }
}
