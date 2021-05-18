using System;
using System.Windows.Forms;

namespace TrustChainChecker
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            Text = "About Medicare Trust Chain Checker";
            labelCompanyName.Text = "Australian Digital Health Agency";
            labelProductName.Text = "Medicare Trust Chain Checker v1.0.0";
            labelCopyright.Text =
                "The Medicare Trust Chain Checker is a tool provided by the Australian Digital Health Agency for Developer Partners to " +
                "verify chains of trust certificates and NASH Private Key(s) installed on a local Windows computer.";

            rtbLabel.AppendText("To provide any feedback or report any bugs, please email mailto:help@digitalhealth.gov.au");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rtbLabel_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }
    }
}