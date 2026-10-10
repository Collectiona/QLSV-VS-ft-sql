using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Sửa Server cho đúng máy của cậu chủ trước khi chạy
        optionsBuilder.UseSqlServer(
            "Server=.;" +
            "Database=QuanLySinhVien;" +
            "Trusted_Connection=True;TrustServerCertificate=True;"
        );
    }
}