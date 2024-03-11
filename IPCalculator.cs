using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IpCalc
{
    internal class IPCalculator : ICalculateIP
    {
        #region Properties        
        public string Input { get; }
        public int HostParts { get; }
        public string NetworkAdress { get; }
        public string BroadcastAdress { get; }
        public string SubnetMask { get; }
        public string LastHost { get; }
        public string FirstHost { get; }

        #endregion

        #region Construct
        public IPCalculator(string ipAdressWithSubnetSuffix)
        {
            Input = ipAdressWithSubnetSuffix;
            byte[] ipByte = new byte[4]; 
            byte[] subnetMaskByteArray = new byte[4];
            int hostParts, subnetSuffix = 0;
            string binarySubnetMask = string.Empty;

            SplitIpAdress(ipAdressWithSubnetSuffix, ref subnetSuffix, ref ipByte);
            HostParts = hostParts = CalculateHosts(subnetSuffix);
            SubnetMask = GetSubnetMask(subnetSuffix, ref binarySubnetMask, ref subnetMaskByteArray);
            LastHost = GetLastNetworkAdress(1, ipByte, subnetMaskByteArray);
            BroadcastAdress = GetLastNetworkAdress(0, ipByte, subnetMaskByteArray);
            FirstHost = GetFirstNetworkAdress(1, ipByte, subnetMaskByteArray);
            NetworkAdress = GetFirstNetworkAdress(0, ipByte, subnetMaskByteArray);
        }

        #endregion

        #region Functions

        public void SplitIpAdress(string ipAndSubnet, ref int subnetSuffix, ref byte[] ipByte)
        {
            string[] tmpStringArray = ipAndSubnet.Split("./".ToCharArray());
            for (int i = 0; i < 4; i++) { ipByte[i] = (byte)Convert.ToInt32(tmpStringArray[i]); }
            subnetSuffix = int.Parse(tmpStringArray.Last());
        }

        public int CalculateHosts(int subnetSuffix) => (int)Math.Pow(2, 32 - subnetSuffix) - 2;

        public string GetSubnetMask(int subnetSuffix, ref string binarySubnetMask, ref byte[] subnetMaskByteArray)
        {
            for (int i = 0; i < 32; i++) { binarySubnetMask = i < subnetSuffix ? binarySubnetMask += "1" : binarySubnetMask += "0"; }

            subnetMaskByteArray[0] = (byte)Convert.ToInt32(binarySubnetMask.Substring(0, 8), 2);
            subnetMaskByteArray[1] = (byte)Convert.ToInt32(binarySubnetMask.Substring(8, 8), 2);
            subnetMaskByteArray[2] = (byte)Convert.ToInt32(binarySubnetMask.Substring(16, 8), 2);
            subnetMaskByteArray[3] = (byte)Convert.ToInt32(binarySubnetMask.Substring(24, 8), 2);

            return $"{subnetMaskByteArray[0]}.{subnetMaskByteArray[1]}.{subnetMaskByteArray[2]}.{subnetMaskByteArray[3]}";
        }

        public string GetFirstNetworkAdress(int add, byte[] ipByte, byte[] subnetMaskByte) =>             
                                                      $"{ipByte[0] & subnetMaskByte[0]}." +
                                                      $"{ipByte[1] & subnetMaskByte[1]}." +
                                                      $"{ipByte[2] & subnetMaskByte[2]}." +
                                                      $"{(ipByte[3] & subnetMaskByte[3]) + add}";

        public string GetLastNetworkAdress(int subtract, byte[] ipByte, byte[] subnetMaskByte) =>
                                                      $"{(byte)((ipByte[0]) | ~subnetMaskByte[0])}." +
                                                      $"{(byte)((ipByte[1]) | ~subnetMaskByte[1])}." +
                                                      $"{(byte)((ipByte[2]) | ~subnetMaskByte[2])}." +
                                                      $"{(byte)((ipByte[3]) | ~subnetMaskByte[3]) - subtract}";

        #endregion
    }
}
