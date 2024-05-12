using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bonfidanet.Client.Test
{

    [TestClass]
    public class ClientFactoryTest
    {
        [TestMethod]
        public void BuildClient()
        {
            var c = ClientFactory.GetClient();

            Assert.IsInstanceOfType(c, typeof(BonfidaClient));
        }

        [TestMethod]
        public void BuildStreamingClient()
        {
            var c = ClientFactory.GetStreamingClient();

            Assert.IsInstanceOfType(c, typeof(BonfidaStreamingClient));
        }
    }
}