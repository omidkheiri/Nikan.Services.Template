using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Nikan.Services.{ Service_Name}.Core.CompanyAggregate;
using Nikan.Services.{ Service_Name}.SharedKernel;
using Nikan.Services.{ Service_Name}.SharedKernel.Interfaces;

namespace Nikan.Services.{ Service_Name }.Infrastructure.Data;

public class AppDbContext : DbContext
{
  private readonly IDomainEventDispatcher _dispatcher;

  public AppDbContext(DbContextOptions<AppDbContext> options,
    IDomainEventDispatcher dispatcher)
    : base(options)
  {
    _dispatcher = dispatcher;
  }

  //public DbSet<ToDoItem> ToDoItems => Set<ToDoItem>();
  //public DbSet<Project> Projects => Set<Project>();

  public DbSet<Company> Companies => Set<Company>();

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    if (modelBuilder == null)
    {
      throw new ArgumentNullException(nameof(modelBuilder), $"{nameof(modelBuilder)} is null.");
    }

    base.OnModelCreating(modelBuilder);
    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
  }

  public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
  {
    var result = await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

    // ignore events if no dispatcher provided
    if (_dispatcher == null)
    {
      return result;
    }

    // dispatch events only if save was successful
    var entitiesWithEvents = ChangeTracker.Entries<EntityBase>()
      .Select(e => e.Entity)
      .Where(e => e.DomainEvents.Any())
      .ToArray();

    await _dispatcher.DispatchAndClearEvents(entitiesWithEvents);

    return result;
  }

  public override int SaveChanges()
  {
    return SaveChangesAsync().GetAwaiter().GetResult();
  }
}
