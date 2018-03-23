namespace ApplicationUsingDB
{
    public class Person
    {
        public int Id { get; }
        public string Name { get; set; }

        public Person(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }

        public override bool Equals(object obj)
        {
            Person other = obj as Person;

            return ((other != null) &&
                    (this.Id == other.Id) &&
                    (this.Name.Equals(other.Name)));
        }

        public override int GetHashCode()
        {
            int hash = 13;
            unchecked
            {
                hash = (hash * 9) + Id;
                hash = (hash * 9) + (Name == null ? 0 : Name.GetHashCode());
            }
            return hash;
        }
    }
}