namespace FCSchoolLibrary
{
    using System.Data.Entity;

    public class FCSchoolLibrary : DbContext
    {
        public FCSchoolLibrary()
            : base("name=FCSchoolLibrary")
        {
        }

        public virtual DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);
        }

    }
}
