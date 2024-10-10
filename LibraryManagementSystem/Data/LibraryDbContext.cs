using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Data
{
    public class LibraryDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookRequest> BookRequests { get; set; }
        public DbSet<IssuedBook> IssuedBooks { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Setting> Settings { get; set; }

        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure User - One-to-Many relationship with BookRequest
            modelBuilder.Entity<BookRequest>()
                .HasOne(br => br.User)
                .WithMany(u => u.BookRequests)
                .HasForeignKey(br => br.UserId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete if user is deleted

            // Configure User - One-to-Many relationship with IssuedBook
            modelBuilder.Entity<IssuedBook>()
                .HasOne(ib => ib.User)
                .WithMany(u => u.IssuedBooks)
                .HasForeignKey(ib => ib.UserId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete

            // Configure Book - One-to-Many relationship with BookRequest
            modelBuilder.Entity<BookRequest>()
                .HasOne(br => br.Book)
                .WithMany(b => b.BookRequests)
                .HasForeignKey(br => br.BookId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent deleting a book if requests exist

            // Configure Book - One-to-Many relationship with IssuedBook
            modelBuilder.Entity<IssuedBook>()
                .HasOne(ib => ib.Book)
                .WithMany(b => b.IssuedBooks)
                .HasForeignKey(ib => ib.BookId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent deleting a book if issued

            // Configure Category - One-to-Many relationship with Book
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Category)
                .WithMany(c => c.Books)
                .HasForeignKey(b => b.CategoryId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete if category is deleted

            // Configure Author - One-to-Many relationship with Book
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.AuthorId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete if author is deleted

            // Configure unique ISBN for Book
            modelBuilder.Entity<Book>()
                .HasIndex(b => b.ISBN)
                .IsUnique();

            // Configure Transaction - One-to-Many with User and Book
            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.User)
                .WithMany(u => u.Transactions)
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.Book)
                .WithMany(b => b.Transactions)
                .HasForeignKey(t => t.BookId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure the Logs table with no cascading rules
            modelBuilder.Entity<Log>()
                .HasOne(l => l.User)
                .WithMany()
                .HasForeignKey(l => l.UserId)
                .OnDelete(DeleteBehavior.SetNull); // User can be deleted but log remains

            // Seed data example (optional)
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Username = "admin", Email = "admin@example.com", Role = UserRole.Admin, PasswordHash = "hashedpassword" },
                new User { UserId = 2, Username = "student1", Email = "student1@example.com", Role = UserRole.Student, PasswordHash = "hashedpassword" }
            );
        }
    }

}
