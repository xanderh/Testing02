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
        List<Payment> payments = new List<Payment>();
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
            return payments.FindAll((Payment)=> Payment.Id == pers.Id);
        }

        public ICollection<Person> GetPeople()
        {
            return people;
        }

        public void SavePayment(Payment pmnt)
        {
            payments.Add(pmnt);
        }

        public void SavePerson(Person pers)
        {
            people.Add(pers);
        }
    }
}
