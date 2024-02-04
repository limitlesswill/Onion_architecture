
using Onion.Application.Contracts;
using Onion.Models;

namespace Onion.Application.Services
{
    public class StudentService : IStudentService
    {
        IStudentRepository _studentrepo { get; set; }
        public StudentService(IStudentRepository studentrepo)
        {
            this._studentrepo = studentrepo;
        }

        public List<Student> GetAllPagination(int num, int pageNum)
        {
            var query = _studentrepo.GetAll().Skip(num * pageNum).Take(num).ToList();
            return query;
        }

        public Student GetStudent(int id)
        {
            if (id != 0)
                return _studentrepo.GetOne(id);
            return null;
        }

        public Student CreateStudent(Student student)
        {
            if (student != null)
            {
                var st = _studentrepo.Create(student);
                _studentrepo.Save();
                return st;
            }
            return null;
        }
    }
}
