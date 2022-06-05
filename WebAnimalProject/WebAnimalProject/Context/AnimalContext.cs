using AnimalsEntity;
using System.Data.Entity;

namespace WebAnimalProject.Context
{
    public class AnimalContext: DbContext
    {
        public AnimalContext()
            : base("DBConnection")
        {
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    throw new UnintentionalCodeFirstException();
        //}

        public virtual DbSet<Animal> Animals { get; set; }
        public virtual DbSet<Artiodactyls> Artiodactylses { get; set; }
        public virtual DbSet<Mammal> Mammals { get; set; }
        public virtual DbSet<Bird> Birds { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>()
            .Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Animals");
            });

            modelBuilder.Entity<Artiodactyls>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Artiodactylses");
            });

            modelBuilder.Entity<Mammal>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Mammals");
            });

            modelBuilder.Entity<Bird>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Birds");
            });
        }
    }
}