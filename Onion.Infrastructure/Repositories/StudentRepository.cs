using Onion.Application.Contracts;
using Onion.Infrastructure.Context;
using Onion.Models;

namespace Onion.Infrastructure.Repositories
{
    public class StudentRepository : Repository<Student, int>, IStudentRepository
    {
        private OnionContext onioncontext;
        public StudentRepository(OnionContext _onioncontext) : base(_onioncontext)
        {
            this.onioncontext = _onioncontext;
        }
    }
}
