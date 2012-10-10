using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Checksum_Generator
{
    public partial class CheckSum_Checker : Form
    {
        public CheckSum_Checker()
        {
            InitializeComponent();

            openFileDialog1.Title = "Select File";
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            fileTextbox.Text = openFileDialog1.FileName.ToString();
        }

        private void fileEnter(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void checkHashes(object sender, EventArgs e)
        {
            if (originalCheck.Text != "" && fileTextbox.Text != "")
            {
                string originalHash = originalCheck.Text;
                HashAlgorithm hash;
                byte[] fileHash;

                switch (algorithmBox.SelectedItem.ToString())
                {
                    case "MD5":
                        hash = MD5.Create();
                        break;
                    case "SHA1":
                        hash = SHA1.Create();
                        break;
                    case "SHA512":
                        hash = SHA512.Create();
                        break;
                    case "SHA256":
                        hash = SHA256.Create();
                        break;
                    default:
                        hash = MD5.Create();
                        break;
                }

                // FileStream automatically closes with 'using'
                using (FileStream fileStream = new FileStream(fileTextbox.Text, FileMode.Open))
                {
                    fileHash = hash.ComputeHash(fileStream);
                }

                if (String.Equals(originalHash, BitConverter.ToString(fileHash).Replace("-", ""), StringComparison.InvariantCultureIgnoreCase))
                {
                    resultBox.Checked = true;
                }
                else
                {
                    resultBox.Checked = false;
                }
            }
        }
    }
}
