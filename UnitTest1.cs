using PointLibrary;
using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConstructorTest1()
        {
            var p = new Point(5, 6);
            Assert.IsTrue((p.x,p.y)==(5,6));
        }

        [TestMethod]
        public void ConstructorTest2()
        {
            var p = new Point();
            Assert.IsTrue((p.x, p.y) == (0, 0));
        }

       /* [TestMethod]
        public void ConstructorTest3()
        {
            var p = new Point();
            Assert.ThrowsException<ArgumentException>(()=>new Point(5,6));
        }*/
    }
}
