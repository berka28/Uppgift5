using SharedLibraries.Services;
using System;


namespace ConsoleAppen
{
    class Program
    {
        static void Main(string[] args)
        {
            var device = new DeviceClientService("HostName=EC-WIN20-MB-IoT-hubb-1.azure-devices.net;DeviceId=ConsoleApp;SharedAccessKey=KhOzfu1bdjGysi3hmNSD+lA7RBVHjjtoaThZ+c0RIyY=");

            Console.ReadKey();
        }
    }
}
