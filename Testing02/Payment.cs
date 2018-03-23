using System;

namespace ApplicationUsingDB
{
    public class Payment
    {
        public double Amount { get; }
        public int Id { get; }

        public Payment(double amount, int id)
        {
            this.Amount = amount;
            this.Id = id;
        }

        public Payment(double amount, Person p) : this(amount, p.Id)
        {
        }

        public override string ToString()
        {
            return $"Amount: {Amount}, Id: {Id}";
        }

        public override bool Equals(object obj)
        {
            Payment other = obj as Payment;

            return ((other != null) && 
                    (this.Amount == other.Amount) && 
                    (this.Id == other.Id));
        }

        public override int GetHashCode()
        {
           int hash = 17;
            unchecked
            {
                hash = (hash * 7) + (int)Amount;
                hash = (hash * 7) + Id;
            }
            return hash;
        }
    }
}