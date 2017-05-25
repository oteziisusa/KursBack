namespace ModelDB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelDB : DbContext
    {
        public ModelDB()
            : base("name=ModelDB")
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

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Items)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Item>()
                .Property(e => e.RegistrationNumber)
                .IsFixedLength();

            modelBuilder.Entity<Item>()
                .HasMany(e => e.Displacements)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.Owner)
                .IsFixedLength();

            modelBuilder.Entity<Room>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Room>()
                .HasMany(e => e.Displacements)
                .WithRequired(e => e.Room)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Room>()
                .HasMany(e => e.Items)
                .WithRequired(e => e.Room)
                .HasForeignKey(e => e.NumberRoom)
                .WillCascadeOnDelete(false);
        }
    }
}
