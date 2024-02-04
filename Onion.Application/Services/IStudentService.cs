using Onion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Application.Services
{
    public interface IStudentService
    {
        public List<Student> GetAllPagination(int num, int pageNum);
        public Student GetStudent(int id);
        public Student CreateStudent(Student student);
    }
}
