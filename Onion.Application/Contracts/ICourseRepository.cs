using Onion.Models;

namespace Onion.Application.Contracts
{
    public interface ICourseRepository : IRepository<Course, int>
    {
        Course SearchByName(string name);
    }
}
