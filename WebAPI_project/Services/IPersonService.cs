using WebAPI_project.Models;

namespace WebAPI_project.Services
{
    public interface IPersonService
    {
        public IEnumerable<Person> GetPeople();
    }
}
