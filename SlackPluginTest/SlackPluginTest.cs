using System;
using SlackPlugin;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SlackPluginTest {
    [TestClass]
    public class SlackPluginTest {
        [TestMethod]
        public void TestMessage() {
            var client = new SlackClient("");
            client.SendMessage("", "", "","");
        }
    }
}
