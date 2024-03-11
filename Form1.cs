using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IpCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            tbIP.Text = "192.168.0.1/24";
        }        
        
        private void tbIP_Enter(object sender, EventArgs e)
        {
            if(tbIP.Text == "Введите IP")
            {
                tbIP.Clear();
            }
        }        

        private void tbIP_Leave(object sender, EventArgs e)
        {
            if (tbIP.Text == "")
            {
                tbIP.Text = "Введите IP";
            }
        }

        private IPCalculator IPCalculator;
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            IPCalculator = new IPCalculator(tbIP.Text);

            tbSubnetMask.Text = IPCalculator.SubnetMask;
            tbSubnetMask.TextAlign = HorizontalAlignment.Center;
            tbMaxCountIP.Text = IPCalculator.HostParts.ToString();
            tbMaxCountIP.TextAlign = HorizontalAlignment.Center;
            tbNetworkAddress.Text = IPCalculator.NetworkAdress;
            tbNetworkAddress.TextAlign = HorizontalAlignment.Center;
            tbBoardcast.Text = IPCalculator.BroadcastAdress;
            tbBoardcast.TextAlign = HorizontalAlignment.Center;
            tbFirstHost.Text = IPCalculator.FirstHost;
            tbFirstHost.TextAlign = HorizontalAlignment.Center;
            tbLastHost.Text = IPCalculator.LastHost;
            tbLastHost.TextAlign = HorizontalAlignment.Center;
        }

    }
}
