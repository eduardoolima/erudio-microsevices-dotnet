using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> listPerson = new();
            for(int i= 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                listPerson.Add(person);
            }
            return listPerson;
        }        

        public Person FindById(long id)
        {
            return new Person 
            {
                Id = 1,
                FirstName = "Fulano",
                LastName = "Cliclano",
                Adress = "Alfenas - MG - Brasil",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Fulano" + i,
                LastName = "Cliclano" + i,
                Adress = "Alfenas - MG - Brasil" + i,
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
