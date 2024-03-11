namespace IpCalc
{
    internal interface ICalculateIP
    {
        int CalculateHosts(int subnetSuffix);
        string GetFirstNetworkAdress(int add, byte[] ipByte, byte[] subnetMaskByte);
        string GetLastNetworkAdress(int subtract, byte[] ipByte, byte[] subnetMaskByte);
        string GetSubnetMask(int subnetSuffix, ref string binarySubnetMask, ref byte[] subnetMaskByteArray);
        void SplitIpAdress(string ipAndSubnet, ref int subnetSuffix, ref byte[] ipByte);
    }
}
