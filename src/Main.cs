using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace TrustChainChecker
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            btnRefresh_Click(null,null);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                keyList.Items.Clear();

                ResetText(lblLMMR1);
                ResetText(lblLMMR2);
                ResetText(lblLMMOA1);
                ResetText(lblLMMOA2);
                ResetText(lblLMMOB1);

                ResetText(lblCUMR1);
                ResetText(lblCUMR2);
                ResetText(lblCUMOA1);
                ResetText(lblCUMOA2);
                ResetText(lblCUMOB1);

                ResetText(lblLMTMR1);
                ResetText(lblLMTMR2);
                ResetText(lblLMTMOA1);
                ResetText(lblLMTMOA2);
                ResetText(lblLMTMOB1);

                ResetText(lblCUTMR1);
                ResetText(lblCUTMR2);
                ResetText(lblCUTMOA1);
                ResetText(lblCUTMOA2);
                ResetText(lblCUTMOB1);

                // LocalMachine - Root
                X509Store x509Store = new X509Store(StoreName.Root, StoreLocation.LocalMachine);
                x509Store.Open(OpenFlags.ReadOnly);

                foreach (var cert in x509Store.Certificates)
                {
                    if (cert.Subject.Contains("Medicare"))
                    {
                        YearText(lblLMMR1, cert, "CN=Medicare Australia Root Certification Authority", "01", "sha1");
                        YearText(lblLMMR2, cert, "CN=Medicare Australia Root Certification Authority", "0a", "sha256");
                        YearText(lblLMMOA1, cert, "CN=Medicare Australia Organisation Certification Authority", "0cba", "sha1");
                        YearText(lblLMMOA2, cert, "CN=Medicare Australia Organisation Certification Authority", "25", "sha256");
                        YearText(lblLMMOB1, cert, "CN=Medicare Australia Organisation Certification Authority", "7716", "sha1");

                        YearText(lblLMTMR1, cert, "CN=Test Medicare Australia Root Certification Authority", "01", "sha1");
                        YearText(lblLMTMR2, cert, "CN=Test Medicare Australia Root Certification Authority", "01", "sha256");
                        YearText(lblLMTMOA1, cert, "CN=Test Medicare Australia Organisation Certification Authority", "322e", "sha1");
                        YearText(lblLMTMOA2, cert, "CN=Test Medicare Australia Organisation Certification Authority", "04", "sha256");
                        // Pre-released version
                        //YearText(lblLMTMOB1, cert, "CN=Test Medicare Australia Organisation Certification Authority", "6370", "sha1");
                        // Current version
                        YearText(lblLMTMOB1, cert, "CN=Test Medicare Australia Organisation Certification Authority", "656e", "sha1");
                    }
                }
                x509Store.Close();

                // LocalMachine - Intermediary
                x509Store = new X509Store(StoreName.CertificateAuthority, StoreLocation.LocalMachine);
                x509Store.Open(OpenFlags.ReadOnly);

                foreach (var cert in x509Store.Certificates)
                {
                    if (cert.Subject.Contains("Medicare"))
                    {
                        YearText(lblLMMOA1, cert, "CN=Medicare Australia Organisation Certification Authority", "0cba", "sha1");
                        YearText(lblLMMOA2, cert, "CN=Medicare Australia Organisation Certification Authority", "25", "sha256");
                        YearText(lblLMMOB1, cert, "CN=Medicare Australia Organisation Certification Authority", "7716", "sha1");

                        YearText(lblLMTMOA1, cert, "CN=Test Medicare Australia Organisation Certification Authority", "322e", "sha1");
                        YearText(lblLMTMOA2, cert, "CN=Test Medicare Australia Organisation Certification Authority", "04", "sha256");
                        // Pre-released version
                        //YearText(lblLMTMOB1, cert, "CN=Test Medicare Australia Organisation Certification Authority", "6370", "sha1");
                        // Current version
                        YearText(lblLMTMOB1, cert, "CN=Test Medicare Australia Organisation Certification Authority", "656e", "sha1");
                    }
                }
                x509Store.Close();

                // CurrentUser - Root
                x509Store = new X509Store(StoreName.Root, StoreLocation.CurrentUser);
                x509Store.Open(OpenFlags.ReadOnly);

                foreach (var cert in x509Store.Certificates)
                {
                    if (cert.Subject.Contains("Medicare"))
                    {
                        YearText(lblCUMR1, cert, "CN=Medicare Australia Root Certification Authority", "01", "sha1");
                        YearText(lblCUMR2, cert, "CN=Medicare Australia Root Certification Authority", "0a", "sha256");
                        YearText(lblCUMOA1, cert, "CN=Medicare Australia Organisation Certification Authority", "0cba", "sha1");
                        YearText(lblCUMOA2, cert, "CN=Medicare Australia Organisation Certification Authority", "25", "sha256");
                        YearText(lblCUMOB1, cert, "CN=Medicare Australia Organisation Certification Authority", "7716", "sha1");

                        YearText(lblCUTMR1, cert, "CN=Test Medicare Australia Root Certification Authority", "01", "sha1");
                        YearText(lblCUTMR2, cert, "CN=Test Medicare Australia Root Certification Authority", "01", "sha256");
                        YearText(lblCUTMOA1, cert, "CN=Test Medicare Australia Organisation Certification Authority", "322e", "sha1");
                        YearText(lblCUTMOA2, cert, "CN=Test Medicare Australia Organisation Certification Authority", "04", "sha256");
                        // Pre-released version
                        //YearText(lblCUTMOB1, cert, "CN=Test Medicare Australia Organisation Certification Authority", "6370", "sha1");
                        // Current version
                        YearText(lblCUTMOB1, cert, "CN=Test Medicare Australia Organisation Certification Authority", "656e", "sha1");
                    }
                }
                x509Store.Close();

                // CurrentUser - Intermediary
                x509Store = new X509Store(StoreName.CertificateAuthority, StoreLocation.CurrentUser);
                x509Store.Open(OpenFlags.ReadOnly);

                foreach (var cert in x509Store.Certificates)
                {
                    if (cert.Subject.Contains("Medicare"))
                    {
                        YearText(lblCUMOA1, cert, "CN=Medicare Australia Organisation Certification Authority", "0cba", "sha1");
                        YearText(lblCUMOA2, cert, "CN=Medicare Australia Organisation Certification Authority", "25", "sha256");
                        YearText(lblCUMOB1, cert, "CN=Medicare Australia Organisation Certification Authority", "7716", "sha1");

                        YearText(lblCUTMOA1, cert, "CN=Test Medicare Australia Organisation Certification Authority", "322e", "sha1");
                        YearText(lblCUTMOA2, cert, "CN=Test Medicare Australia Organisation Certification Authority", "04", "sha256");
                        // Pre-released version
                        //YearText(lblCUTMOB1, cert, "CN=Test Medicare Australia Organisation Certification Authority", "6370", "sha1");
                        // Current version
                        YearText(lblCUTMOB1, cert, "CN=Test Medicare Australia Organisation Certification Authority", "656e", "sha1");
                    }
                }
                x509Store.Close();

                // CurrentUser NASH Certs
                x509Store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
                x509Store.Open(OpenFlags.ReadOnly);

                foreach (var cert in x509Store.Certificates)
                {
                    if (cert.IssuerName.Name.Contains("Medicare Australia Organisation Certification Authority"))
                    {
                        string serial = cert.SerialNumber;
                        string signAlg = (cert.SignatureAlgorithm.FriendlyName.Contains("sha1") ? "SHA1 " : "SHA2 ") + "(" + serial + ") ";

                        keyList.Items.Add($"CurrUser: {signAlg} {cert.SubjectName.Name}");
                    }
                }
                x509Store.Close();

                // LocalMachine NASH Certs
                x509Store = new X509Store(StoreName.My, StoreLocation.LocalMachine);
                x509Store.Open(OpenFlags.ReadOnly);

                foreach (var cert in x509Store.Certificates)
                {
                    if (cert.IssuerName.Name.Contains("Medicare Australia Organisation Certification Authority"))
                    {
                        string serial = cert.SerialNumber;
                        string signAlg = (cert.SignatureAlgorithm.FriendlyName.Contains("sha1") ? "SHA1 " : "SHA2 ") + "(" + serial + ")";

                        keyList.Items.Add($"LocalMach: {signAlg} {cert.SubjectName.Name}");
                    }
                }
                x509Store.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to read Certificate Store {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ResetText(Label label)
        {
            label.Text = "NotFound"; 
            label.ForeColor = Color.Red;
        }

        private void YearText(Label label, X509Certificate2 cert, string starts, string serialno, string saType)
        {
            if (cert.Subject.StartsWith(starts) && cert.SerialNumber.ToLower() == serialno && cert.SignatureAlgorithm.FriendlyName.ToLower().StartsWith(saType))
            {
                label.ForeColor = Color.ForestGreen;
                label.Text = $"Exp: {cert.NotAfter.Month}/{cert.NotAfter.Year}";
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            var about = new About();
            about.ShowDialog();
        }
    }
}
