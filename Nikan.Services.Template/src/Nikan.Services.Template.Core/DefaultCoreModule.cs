using Autofac;
using Nikan.Services.Template.Core.Interfaces;
using Nikan.Services.Template.Core.Services;

namespace Nikan.Services.Template.Core
{
  public class DefaultCoreModule : Module
  {
    protected override void Load(ContainerBuilder builder)
    {
      builder.RegisterType<ToDoItemSearchService>()
          .As<IToDoItemSearchService>().InstancePerLifetimeScope();
    }
  }
}