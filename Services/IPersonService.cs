using persons_api.Models;

namespace persons_api.Models
{
    public interface IPersonService
    {
        public IEnumerable<Person> GetAll();
        public Person Get(int id);
        public Person Insert(Person person);
        public Person Update(Person person);
        public Person Delete(int id);
    }
}