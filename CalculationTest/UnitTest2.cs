using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TinhToan;
namespace CalculationTest
{
    //[TestClass]
    //public class UnitTest
    //{
    //    [TestMethod]
    //    public void TestMethod1()
    //    {
    //    }
    //}
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
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        public void TestLayDLCong()
        {
            int a, b, expected;
            string operation;
            a = int.Parse(TestContext.DataRow[0].ToString());
            b = int.Parse(TestContext.DataRow[1].ToString());
            operation = TestContext.DataRow[2].ToString();
            operation = operation.Remove(0, 1);
            expected = int.Parse(TestContext.DataRow[3].ToString());
            c = new Calculation(a, b);
            Assert.AreEqual(expected, c.Execute(operation));
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        @".\Data\TestData.csv", "TestDataSoSanh#csv", DataAccessMethod.Sequential)]
        public void TestLayDLSoSanh()
        {
            int a, b, expected, actual;
            a = int.Parse(TestContext.DataRow[0].ToString());
            b = int.Parse(TestContext.DataRow[1].ToString());
            expected = int.Parse(TestContext.DataRow[2].ToString());
            c = new Calculation(a, b);
            actual = c.SoSanh(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
