using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LommeRegnerLibrary;
using System.Transactions;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

namespace LommeRegnerUnitTest
{
    [TestClass]
    public class LommeRegnerUnit
    {
        [TestMethod]
        public void AddMethodTest()
        {
            float tal1 = 2;
            float tal2 = 2;

            float result = LommeRegner.Plus(tal1, tal2);

            Assert.IsTrue(result == 4, "PlusMethode stemmer ikke overens med det forventede");

        }

        [TestMethod]
        public void SubMethodTest()
        {
            float tal1 = 2;
            float tal2 = 2;

            float result = LommeRegner.Minus(tal1, tal2);

            Assert.IsTrue(result == 0, "MinusMethode stemmer ikke overens med det forventede");

        }

        [TestMethod]
        public void MultMethodTest()
        {
            float tal1 = 3;
            float tal2 = 3;

            float result = LommeRegner.Gange(tal1, tal2);

            Assert.IsTrue(result == 9, "GangeMethode stemmer ikke overens med det forventede");

        }

        [TestMethod]
        public void DivMethodTest()
        {
            float tal1 = 2;
            float tal2 = 0;

            float result = LommeRegner.Dividere(tal1, tal2);

            Assert.IsTrue(result == 1, "DividerMethode stemmer ikke overens med det forventede");

            try
            {
                if(tal1 == 0 || tal2 == 0)
                {
                    Assert.Fail();
                }
                                
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
    }
}
