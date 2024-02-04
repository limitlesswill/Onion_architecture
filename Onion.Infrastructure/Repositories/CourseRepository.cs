using Onion.Application.Contracts;
using Onion.Infrastructure.Context;
using Onion.Models;

namespace Onion.Infrastructure.Repositories
{
    public class CourseRepository : Repository<Course, int>, ICourseRepository
    {
        private OnionContext onioncontext;
        public CourseRepository(OnionContext _onioncontext) : base(_onioncontext)
        {
            this.onioncontext = _onioncontext;
        }
        public Course SearchByName(string name)
        {
            return onioncontext.course.Where(x => x.name == name).First();
        }
    }
}
