using System;
using Lab4Variant10;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void method_EnterAll1Matrix_And2_Answer1And15()
        {
            double[] a = new double[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            double c = 2;
            double[] expected = new double[] { 1, 15 };
            double[] actual = Class1.method(a, c);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void method_Enter1And2Matrix_And2_Answer1And12()
        {
            double[] a = new double[] { 1, 2, 1, 2, 1, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            double c = 2;
            double[] expected = new double[] { 1, 12 };
            double[] actual = Class1.method(a, c);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void method_Enter1And2And3And4Matrix_And4_Answer18And13()
        {
            double[] a = new double[] { 1, 2, 3, 3, 4, 4, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            double c = 4;
            double[] expected = new double[] { 18, 13 };
            double[] actual = Class1.method(a, c);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void method_Enter1And1Dot5And2And3And4Matrix_And3_Answer3And12()
        {
            double[] a = new double[] { 1, 1.5, 2, 3, 4, 4, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            double c = 3;
            double[] expected = new double[] { 3, 12 };
            double[] actual = Class1.method(a, c);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void method_EnterMinus1And1And2And3Matrix_And3_AnswerMinus4And14()
        {
            double[] a = new double[] { -1, 1, 2, 2, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            double c = 3;
            double[] expected = new double[] { -4, 14 };
            double[] actual = Class1.method(a, c);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
