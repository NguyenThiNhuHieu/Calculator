using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TinhToan;
namespace CalculatorTester
{
    [TestClass]

    public class UnitTest1
    {
        private Calculation c;
        public TestContext TestContext { get; set; }
        [TestInitialize]  //Thiết lập DL test cast dùng chung 
        
        public void SetUp()
        {
            c = new Calculation(10, 5);
        }
        [TestMethod]
        public void TestCong()
        {
            int expected, actual;
            //Calculation c = new Calculation(10, 5);
            expected = 15;
            actual = c.Execute("+");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestTru()

        {
            int expected, actual;
            //Calculation c = new Calculation(10, 5);
            expected = 5;
            actual = c.Execute("-");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestNhan()

        {
            int expected, actual;
            //Calculation c = new Calculation(10, 5);
            expected = 50;
            actual = c.Execute("*");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestChia()

        {
            int expected, actual;
            //Calculation c = new Calculation(10, 5);
            expected = 2;
            actual = c.Execute("/");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestBatLoiChia0()

        {
            c = new Calculation(10, 0);
            c.Execute("/");
        }
        //Liên kết Testdata với project
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        public void TestLayDL()
        {
            int a, b, expected, actual;
            a = int.Parse(TestContext.DataRow[0].ToString());
            b = int.Parse(TestContext.DataRow[1].ToString());
            expected = int.Parse(TestContext.DataRow[2].ToString());
            c = new Calculation(a, b);
            actual = c.Execute("+");
            Assert.AreEqual(expected, actual);
        }
    }
}
