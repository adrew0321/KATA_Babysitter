using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KATA_Babysitter;
using NUnit.Framework;

namespace KATA_BabysitterTests
{
    [TestFixture]
    public class FamilyUnitTest
    {
        [Test]
        public void GetFamilyName()
        {
            //arrange
            Family testFamily = new Family("The Drews", 15, 5);

            //act


            //assert
            Assert.AreEqual("The Drews",testFamily.Name);
            
        }
    }
}
