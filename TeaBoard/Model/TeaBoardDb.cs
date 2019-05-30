namespace TeaBoard.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TeaBoardDb : DbContext
    {
        public TeaBoardDb()
            : base("name=TeaBoardDb")
        {
        }

        public virtual DbSet<Accessory> Accessories { get; set; }
        public virtual DbSet<Brew_Method> Brew_Method { get; set; }
        public virtual DbSet<Rate> Rates { get; set; }
        public virtual DbSet<Tea> Teas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accessory>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Accessory>()
                .Property(e => e.price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Accessory>()
                .Property(e => e.Tea_name)
                .IsUnicode(false);

            modelBuilder.Entity<Brew_Method>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Brew_Method>()
                .Property(e => e.instruction)
                .IsUnicode(false);

            modelBuilder.Entity<Brew_Method>()
                .Property(e => e.Tea_name)
                .IsUnicode(false);

            modelBuilder.Entity<Rate>()
                .Property(e => e.Tea_name)
                .IsUnicode(false);

            modelBuilder.Entity<Tea>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Tea>()
                .Property(e => e.origin_country)
                .IsUnicode(false);

            modelBuilder.Entity<Tea>()
                .HasMany(e => e.Accessories)
                .WithRequired(e => e.Tea)
                .HasForeignKey(e => e.Tea_name)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tea>()
                .HasMany(e => e.Brew_Method)
                .WithRequired(e => e.Tea)
                .HasForeignKey(e => e.Tea_name)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tea>()
                .HasMany(e => e.Rates)
                .WithRequired(e => e.Tea)
                .HasForeignKey(e => e.Tea_name)
                .WillCascadeOnDelete(false);
        }
    }
}
