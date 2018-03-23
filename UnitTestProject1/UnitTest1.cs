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

        [TestMethod]
        public void TestGetTopThreePeople()
        {
            Program program = new Program();
            //Should fail test, as method doesn't throw the exception it promised. 
            Assert.ThrowsException<ArgumentException>(() => program.GetTopThreePeople(null));
            MyDataProvider data = new MyDataProvider();
            Assert.AreEqual(0, program.GetTopThreePeople(data).Count);
            Person pers1 = new Person(0, "Bob");
            data.SavePerson(pers1);
            Person pers2 = new Person(1, "Bobby");
            data.SavePerson(pers2);
            Person pers3 = new Person(2, "Bubba");
            data.SavePerson(pers3);
            Assert.AreEqual(3, program.GetTopThreePeople(data).Count);
            Person pers4 = new Person(3, "Bibi");
            data.SavePerson(pers4);
            Assert.AreEqual(3, program.GetTopThreePeople(data).Count);
        }
    }
}