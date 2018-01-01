using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreConsole.Entities;

namespace UT_for_CoreConsole {

    [TestClass]
    public class UnitTestAllergy {

        [TestMethod]
        public void TestConstructor() {
            Allergy testee = new Allergy("Strawberry");

            Assert.AreEqual("Strawberry", testee.AllergyName);
        } 

        [TestMethod]
        public void TestToStringOverride()
        {
            Allergy testee = new Allergy("Belinda");

            Assert.AreEqual("Belinda", testee.ToString());
        }
    }
}