using System.Collections.Generic;

namespace ApplicationUsingDB
{
    public interface IDataProvider
    {
        void SavePerson(Person pers); //stores the Person objects state.
        bool ExistsPerson(Person pers); //returns true if Person object is stored, false otherwise
        ICollection<Person> GetPeople(); //returns all Person objects stored
        int CountPeople(); //returns number of Person objects stored

        void SavePayment(Payment pmnt); //stores a Payment objects state. 
        ICollection<Payment> GetPaymentsFromPerson(Person pers);//returns all Payments for <pers>
    }
}
