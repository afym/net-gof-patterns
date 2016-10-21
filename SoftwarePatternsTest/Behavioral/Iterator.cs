using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftwarePatterns.Behavioral.Iterator;

namespace SoftwarePatternsTest.Behavioral
{
    [TestClass]
    public class Iterator
    {
        [TestMethod]
        public void TestInstance()
        {
            NamesStack<string> Names = new NamesStack<string>(100);
            Assert.IsInstanceOfType(Names, typeof(IEnumerable));
        }

        [TestMethod]
        public void TestIteration() 
        {
            NamesStack<string> Names = new NamesStack<string>(8);

            for (int Index = 0; Index < 5; Index++)
            {
                Names.Add("A string" + Index);
            }

            int Iterations = 0;

            foreach(string Name in Names)
            {
                Iterations++;
                Assert.IsInstanceOfType(Name, typeof(string));
            }

            Assert.AreEqual(Iterations, 5);
            Assert.AreEqual(Names.First(), "A string0");
            Assert.AreEqual(Names.Last(), "A string4");
        }
    }
}
