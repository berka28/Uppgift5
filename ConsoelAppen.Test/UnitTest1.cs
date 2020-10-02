using SharedLibraries.Services;
using System;
using Xunit;

namespace ConsoelAppen.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("consoleapp", "SetInterval", "5", "200")]
        [InlineData ("consoleapp", "GetInterval", "5", "501")]

        public void Test1(string targetDevice, string methodName, string payload, string expected)
        {

            var service = new ServiceClientService("HostName=EC-WIN20-MB-IoT-hubb-1.azure-devices.net;DeviceId=ConsoleApp;SharedAccessKey=KhOzfu1bdjGysi3hmNSD+lA7RBVHjjtoaThZ+c0RIyY=");
            var response = service.InvokeMethodAsync(targetDevice, methodName, payload);

            Assert.Equal(expected, response.Result.Status.ToString());
        }
    }
}
