using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyNamespace;

namespace UnitTestProject
{
    [TestClass]
    public class SerializationTests
    {
        [TestMethod]
        public async Task DeserializeCircularReferences()
        {
            var client = new Client("http://127.0.0.1:5000/");
            var a = await client.Test_GetAsync();
            
            Assert.AreEqual(a.Children.Count, 1);
        }
    }
}
