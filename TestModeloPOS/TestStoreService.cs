using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModeloPOS;

namespace TestModeloPOS
{
    [TestClass]
    public class TestStoreService
    {
        //Pode fazer esse teste só com a DLL indo em Dependencies com o lado dir do mouse 
        //no "Add Project Reference" e marca a DLL (nesse caso ModeloPOS)
        [TestMethod]
        public void TestAddStore()
        {
            //Prepare
            StoreService storeService = new StoreService();
            //Execute
            Store s1 = storeService.AddStore("Loja1", "Porto");
            //Assert
            Assert.IsNotNull(s1);
            Assert.AreEqual("Loja1", s1.StoreName);
            Assert.AreEqual("Porto", s1.City);
            //Execute
            Store s2 = storeService.AddStore("Loja1", "Porto");
            //Assert
            Assert.IsNull(s2);
        }
    }
}