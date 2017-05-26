namespace ModelDB.ModelDB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModeDB : DbContext
    {
        public ModeDB()
            : base("name=ModeDB")
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Displacement> Displacement { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<Room> Room { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Category>()
                .HasMany(e => e.ChildCategories)
                .WithOptional(e => e.ParentCategory)
                .HasForeignKey(e => e.ParentId);

            modelBuilder.Entity<Item>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Item>()
                .Property(e => e.RegistrationNumber)
                .IsFixedLength();

            modelBuilder.Entity<Room>()
                .Property(e => e.Owner)
                .IsFixedLength();

            modelBuilder.Entity<Room>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Room>()
                .HasMany(e => e.Items)
                .WithRequired(e => e.Room)
                .HasForeignKey(e => e.NumberRoom)
                .WillCascadeOnDelete(false);
        }
    }
}
