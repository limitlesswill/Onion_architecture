using Autofac;
using Autofac.Core;
using Onion.Infrastructure.Context;
using Onion.Application.Contracts;
using Onion.Application.Services;
using Onion.Infrastructure.Repositories;

namespace Onion.Presentation.Registers
{
    public class AutoFacRegister
    {
        public static IContainer Register()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<OnionContext>().As<OnionContext>();
            builder.RegisterType<StudentRepository>().As<IStudentRepository>();
            builder.RegisterType<StudentService>().As<IStudentService>();
            var container = builder.Build();
            return container;
        }
    }
}
