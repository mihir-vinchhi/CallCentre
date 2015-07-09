using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;

namespace CallCentre.Core.Models
{
    public class CallCentreContext : DbContext
    {
        public CallCentreContext()
            : base("CallCentreContext")
        {
        }

        public virtual DbSet<Operator> Operators { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Operator>()
                .HasKey(o => o.ID);

            modelBuilder.Entity<Operator>()
                .Property(o => o.Extension)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_Extension") { IsUnique = true }));
        }
    }
}