namespace Cinema.DataBase
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CinemaDB : DbContext
    {
        public CinemaDB()
            : base("name=CinemaDB")
        {
        }

        public virtual DbSet<Hall> Halls { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Row> Rows { get; set; }
        public virtual DbSet<Show> Shows { get; set; }
        public virtual DbSet<Sold__or_Reserved_Tickets> Sold__or_Reserved_Tickets { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hall>()
                .Property(e => e.HallName)
                .IsUnicode(false);

            modelBuilder.Entity<Hall>()
                .HasMany(e => e.Rows)
                .WithRequired(e => e.Hall)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hall>()
                .HasMany(e => e.Shows)
                .WithRequired(e => e.Hall)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Show>()
                .Property(e => e.ShowName)
                .IsUnicode(false);

            modelBuilder.Entity<Show>()
                .HasMany(e => e.Sold__or_Reserved_Tickets)
                .WithRequired(e => e.Show)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sold__or_Reserved_Tickets>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Sold__or_Reserved_Tickets>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Role)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Sold__or_Reserved_Tickets)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
