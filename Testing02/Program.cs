using System;
using System.Collections.Generic;
using System.Linq;

namespace ApplicationUsingDB
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }

        private void Run()
        {
            //do stuff
        }

        //Precondition: Both arguments must be not-null, throws NullReferenceException otherwise
        //              Person must not be saved already, throws ArgumentException otherwise
        public void SavePerson(IDataProvider data, Person pers)
        {
            if ((data == null) || (pers == null))
            {
                throw new NullReferenceException(); 
            }
            else
            {
                if (data.ExistsPerson(pers))
                {
                    throw new ArgumentException();
                }
                else
                {
                    data.SavePerson(pers);
                }
            }
        }

        //Precondition: IDataProvider arguments must be not-null, throws ArgumentException otherwise
        public ICollection<Person> GetTopThreePeople(IDataProvider data)
        {
            ICollection<Person> result = data.GetPeople();

            if (data.CountPeople() > 3)
            {
                ICollection<Person> temp = new List<Person>();
                for (int i = 0; i < 3; i++)
                {
                    temp.Add(result.ElementAt(i));
                }
                result = temp;
            }

            return result;
        }

        //Precondition: both arguments must be not-null, throws ArgumentException otherwise
        public double GetPaymentTotal(IDataProvider data, Person pers)
        {
            ICollection<Payment> payments = data.GetPaymentsFromPerson(pers);
            double result = 0.0;
            foreach (Payment pmnt in payments)
            {
                result = result + pmnt.Amount;
            }

            return result;
        }
    }
}
