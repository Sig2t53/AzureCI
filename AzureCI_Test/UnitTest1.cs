using System;
using AzureCI.App;
using NUnit.Framework;

namespace AzureCI_Test
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Assert.AreEqual(11,Adder.Add(6,4));
        }
    }
}
