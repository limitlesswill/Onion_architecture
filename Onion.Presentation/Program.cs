using Autofac;
using Onion.Application.Services;
using Onion.Models;
using Onion.Presentation.Registers;

namespace Onion.Presentation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var con = AutoFacRegister.Register();
            IStudentService studentService = con.Resolve<IStudentService>();
            Student st = new Student() { name = "Ali Robert Cecil Martin mohamadeen" };
            studentService.CreateStudent(st);

            foreach (var x in studentService.GetAllPagination(3, 0))
                Console.WriteLine($"{x.id} | {x.name}");
        }
    }
}
