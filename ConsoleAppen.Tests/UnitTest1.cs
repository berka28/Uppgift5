using SharedLibraries.Services;
using System;
using Xunit;

namespace ConsoleAppen.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("ConsoleApp", "SetInterval", "5", "200")]
        [InlineData("ConsoleApp", "GetInterval", "5", "501")]

        public void Test1(string targetDevice, string methodName, string payload, string expected)
        {

            var service = new ServiceClientService("HostName=EC-WIN20-MB-IoT-hubb-1.azure-devices.net;SharedAccessKeyName=iothubowner;SharedAccessKey=Q5ue7rCw+m/F431P5x4DdH0Fyea0S/0Q4GSjqQwsgzw=");
            var response = service.InvokeMethodAsync(targetDevice, methodName, payload);

            Assert.Equal(expected, response.Result.Status.ToString());
        }
    }
}
