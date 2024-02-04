using Onion.Application.Contracts;
using Onion.Infrastructure.Context;
using Onion.Models;

namespace Onion.Infrastructure.Repositories
{
    public class StudentCourseRepository : Repository<StudentCourse, int>, IStudentCourseRepository
    {
        private OnionContext onioncontext;
        public StudentCourseRepository(OnionContext _onioncontext) : base(_onioncontext)
        {
            this.onioncontext = _onioncontext;
        }
    }
}
