using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistence
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Value> Values {get; set;}
        public DbSet<QBContactModel> Contacts {get; set;}

        public DbSet<ActivityModel> Activities {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>()
                .HasData(
                    new Value {Id = 1, Name = "Value 101"}
                    ,new Value {Id = 2, Name = "Value 102"}
                    ,new Value {Id = 3, Name = "Value 103"}
                );
            
            builder.Entity<QBContactModel>()
                .ToTable("QBContact")
                .HasKey(x => x.Id);

            builder.Entity<QBContactModel>()
                .Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Entity<QBContactModel>()
                .Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Entity<QBContactModel>()
                .Property(x => x.CompanyName)
                .IsRequired()
                .HasMaxLength(50);


            builder.Entity<ActivityModel>()
                .ToTable("Activity")
                .HasKey(x => x.Id);
        }


    }
}
