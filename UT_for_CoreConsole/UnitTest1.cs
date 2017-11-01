using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreConsole.Entities;

namespace UT_for_CoreConsole {
    [TestClass]
    public class UnitTestSoldier {
        [TestMethod]
        public void TestConstructorA() {
            Soldier testee = new Soldier();

            Assert.AreEqual(100, testee.Morale);
        }

        [TestMethod]
        public void TestConstructorB() {
            Soldier testee = new Soldier(newMaxMorale: 77, newMaxToughness: 33);

            Assert.AreEqual(77, testee.Morale);
        }

        [TestMethod]
        public void TestConstructorC() {
            Soldier testee = new Soldier(newMaxMorale: 44, newMaxToughness: 66, newMorale: 30, newToughness: 55);

            Assert.AreEqual(30, testee.Morale);
        }
    }
}
