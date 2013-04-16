using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using TaskSystem.Models.DAL;
using TaskSystem.Repository;

namespace TaskSystem.Common.Installer
{
    public class RepositoriesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component
                    .For<IUserRepository>()
                    .ImplementedBy<UserRepository>().LifeStyle.Singleton,
                Component
                    .For<ITaskRepository>()
                    .ImplementedBy<TaskRepository>().LifeStyle.Singleton,
                Component
                    .For<TaskEntities>()
                    .ImplementedBy<TaskEntities>().LifeStyle.Singleton);
        }
    }
}