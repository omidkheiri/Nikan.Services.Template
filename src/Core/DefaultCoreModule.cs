using Autofac;

namespace Nikan.Services.{ Service_Name }.Core;

public class DefaultCoreModule : Module
{
  protected override void Load(ContainerBuilder builder)
  {
    //builder.RegisterType<ToDoItemSearchService>()
    //    .As<IToDoItemSearchService>().InstancePerLifetimeScope();
  }
}
