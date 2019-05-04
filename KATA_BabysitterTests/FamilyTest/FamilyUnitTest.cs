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
        public void GetFamilyAlwaysReturnsExpectedValues()
        {
            //arrange & act
            Family testFamily = new Family
            {
                Name = "The Drews",
                RatePerHour = 15,
            };

            //assert
            Assert.AreEqual("The Drews",testFamily.Name);
            Assert.AreEqual(15, testFamily.RatePerHour);
            
        }
    }
}
