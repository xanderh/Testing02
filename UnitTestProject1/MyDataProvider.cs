using ApplicationUsingDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class MyDataProvider : IDataProvider
    {
        List<Person> people = new List<Person>();
        public int CountPeople()
        {
            return people.Count;

        }

        public bool ExistsPerson(Person pers)
        {
            return people.Exists((person)=> person.Equals(pers));
        }

        public ICollection<Payment> GetPaymentsFromPerson(Person pers)
        {
            throw new NotImplementedException();
        }

        public ICollection<Person> GetPeople()
        {
            throw new NotImplementedException();
        }

        public void SavePayment(Payment pmnt)
        {
            throw new NotImplementedException();
        }

        public void SavePerson(Person pers)
        {
            people.Add(pers);
        }
    }
}
