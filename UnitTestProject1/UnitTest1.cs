using System;
using ApplicationUsingDB;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSavePerson()
        {
            Program program = new Program();
            Assert.ThrowsException<NullReferenceException>(() => program.SavePerson(null, null));
            MyDataProvider myDataProvider = new MyDataProvider();
            Assert.ThrowsException<NullReferenceException>(() => program.SavePerson(myDataProvider, null));
            Person person = new Person(0, "Bob");
            Assert.ThrowsException<NullReferenceException>(() => program.SavePerson(null, person));
            program.SavePerson(myDataProvider, person);
            Assert.AreEqual(1, myDataProvider.CountPeople());
            Assert.ThrowsException<ArgumentException>(() => program.SavePerson(myDataProvider, person));
        }
    }
}