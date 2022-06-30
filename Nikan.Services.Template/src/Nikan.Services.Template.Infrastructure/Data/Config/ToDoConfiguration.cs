using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nikan.Services.Template.Core.ProjectAggregate;

namespace Nikan.Services.Template.Infrastructure.Data.Config
{
  public class ToDoConfiguration : IEntityTypeConfiguration<ToDoItem>
  {
    public void Configure(EntityTypeBuilder<ToDoItem> builder)
    {
      builder.Property(t => t.Title)
          .IsRequired();
    }
  }
}