using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreConsole.Entities;

namespace UT_for_CoreConsole {

    [TestClass]
    public class UnitTestPerson {

        [TestMethod]
        public void TestConstructorA() {
            Person testee = new Person("Jerry", "Jones");

            Assert.AreEqual("Jones", testee.LastName);
        }

        [TestMethod]
        public void TestFullNameA() {
            Person testee = new Person("Mary", "Turner", "Joe");

            Assert.AreEqual("Mary Joe Turner", testee.FullName());
        }

        [TestMethod]
        public void TestFullNameB() {
            Person testee = new Person("Mary", "Joe");

            Assert.AreEqual("Mary Joe", testee.FullName());
        }

        //[TestMethod]
        //public void TestConstructorB() {
        //    Soldier testee = new Soldier(newMaxMorale: 77, newMaxToughness: 33);

        //    Assert.AreEqual(77, testee.Morale);
        //}

        //[TestMethod]
        //public void TestConstructorC() {
        //    Soldier testee = new Soldier(newMaxMorale: 44, newMaxToughness: 66, newMorale: 30, newToughness: 55);

        //    Assert.AreEqual(30, testee.Morale);
        //}
    }
}
