using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestLib;

namespace MSTestAutomatedTester {
    [TestClass]
    public class TestFunctions {
        Functions func = null;
        [TestInitialize]
        public void Setup() {
            func = new Functions();
        }

        [TestMethod]
        public void TestAdd1() {
            var answer = func.Add1(3); // return 4
            Assert.AreEqual(4, answer);
            answer = func.Add1(-1);
            Assert.AreEqual(0, answer);

        }
        [TestMethod]
        public void Test2() {
            var answer = func.Add1(0); // return 4
            Assert.AreEqual(1, answer, "fumbo dumbo");

        }
        [TestMethod]
        public void TestXSquaredPlus3() {
            //test input 0
            var answ = func.XSquaredPlus3(0);
            Assert.AreEqual(3, answ);
            //test input 4
            answ = func.XSquaredPlus3(4);
            Assert.AreEqual(19, answ);
            //test input -3
            answ = func.XSquaredPlus3(-3);
            Assert.AreEqual(12, answ);
        }
        [TestMethod]
        public void FailXSquaredPlus3() {
            //test input -4
            var ans = func.XSquaredPlus3(-4);
            Assert.AreNotEqual(-13, ans);
            //test input 5
            ans = func.XSquaredPlus3(5);
            Assert.AreNotEqual(22, ans);
            //test input 0
            ans = func.XSquaredPlus3(0);
            Assert.AreNotEqual(0, ans);

        }
        [TestMethod]
        public void TestX7X12() {
            //test input 2
            var an = func.X7X12(2);
            Assert.AreEqual(2, an);
            //test input 0
            an = func.X7X12(0);
            Assert.AreEqual(12, an);
            //test input -2
            an = func.X7X12(-2);
            Assert.AreEqual(30, an);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestFailX7X12() {
            //test input 2
            var an = func.X7X12(2);
            Assert.AreNotEqual(30, an, "Potatos are in the punch bowl");
            //test input 0
            an = func.X7X12(0);
            Assert.AreNotEqual(0, an);
            //test input -2

            Assert.AreNotEqual(16, func.X7X12(-2));
            Assert.AreEqual(0, func.X7X12(4));
        }
    }   
}
