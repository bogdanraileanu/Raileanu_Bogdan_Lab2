using Microsoft.EntityFrameworkCore;

public class Raileanu_Bogdan_Lab2Context(DbContextOptions<Raileanu_Bogdan_Lab2Context> options) : DbContext(options)
{
    public DbSet<Raileanu_Bogdan_Lab2.Models.Book> Book { get; set; } = default!;
    public DbSet<Raileanu_Bogdan_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    public DbSet<Raileanu_Bogdan_Lab2.Models.Author> Author { get; set; } = default!;
    public DbSet<Raileanu_Bogdan_Lab2.Models.Category> Category { get; set; } = default!;
}
