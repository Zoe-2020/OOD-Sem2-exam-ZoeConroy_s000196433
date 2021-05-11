using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZoeConroy_s000196433;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
            public void TestPriceDecrease()
            {
                Game p1 = new Game("Mario  64", 95, "platform game for the Nintendo 64 and the first Super Mario game to feature 3D gameplay", "Nintendo 64", 50);
                double finalPrice = 45;

                
                p1.DecreasePrice(.10);

               
                Assert.AreEqual(finalPrice, p1.Price);
            
        }
    }
}
