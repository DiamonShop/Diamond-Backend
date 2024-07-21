using Microsoft.EntityFrameworkCore;
using DiamondShop.Data;
using Diamond.Entities.Data;

public class DiamondDbContext : DbContext
{
    public DiamondDbContext(DbContextOptions<DiamondDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Certification> Certificates { get; set; }
    public DbSet<Diamonds> Diamonds { get; set; }
    public DbSet<Warranty> Warranties { get; set; }
    public DbSet<Feedback> Feedbacks { get; set; }
    public DbSet<JewelrySettings> JewelrySetting { get; set; }
    public DbSet<Jewelry> Jewelry { get; set; }
    public DbSet<JewelrySize> JewelrySizes { get; set; }
    public DbSet<MainDiamond> MainDiamonds { get; set; }
    public DbSet<SideDiamond> SideDiamonds { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(e =>
        {
            e.HasOne(x => x.Role)
                .WithMany(x => x.Users)
                .HasForeignKey(x => x.RoleId);
        });

        modelBuilder.Entity<Certification>(e =>
        {
            e.HasOne(x => x.Diamond)
                .WithOne(x => x.Certification)
                .HasForeignKey<Certification>(x => x.DiamondID);
        });

        modelBuilder.Entity<Order>(e =>
        {
            e.Property(e => e.TotalPrice).HasColumnType("decimal(18,2)");

            e.HasOne(x => x.User)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.UserID);
        });

        modelBuilder.Entity<OrderDetail>(e =>
        {
            e.HasOne(x => x.Product)
                .WithMany(x => x.OrderDetails)
                .HasForeignKey(x => x.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            e.HasOne(x => x.Order)
                .WithMany(x => x.OrderDetails)
                .HasForeignKey(x => x.OrderId)
                .OnDelete(DeleteBehavior.NoAction);
        });

        modelBuilder.Entity<Diamonds>(e =>
        {
            e.Property(e => e.Carat).HasColumnType("decimal(18,2)");
            e.Property(e => e.DiameterMM).HasColumnType("decimal(18,2)");

            e.HasOne(x => x.Product)
                .WithOne(x => x.Diamond)
                .HasForeignKey<Diamonds>(x => x.ProductID);
        });

        modelBuilder.Entity<Product>(e =>
        {
            e.Property(e => e.MarkupRate).HasColumnType("decimal(18,2)");
        });

        modelBuilder.Entity<Feedback>(e =>
        {
            e.HasOne(x => x.Product)
                .WithMany(x => x.Feedbacks)
                .HasForeignKey(x => x.ProductID)
                .OnDelete(DeleteBehavior.Cascade);

            e.HasOne(x => x.User)
                .WithMany(x => x.Feedbacks)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction); // Thay đổi hành vi xóa

           
        });

        modelBuilder.Entity<Jewelry>(e =>
        {
            e.HasOne(x => x.JewelrySetting)
                .WithMany(x => x.Jewelry)
                .HasForeignKey(x => x.JewelrySettingID);

            e.HasOne(x => x.Category)
                .WithMany(x => x.Jewelry)
                .HasForeignKey(x => x.CategoryId);

            e.HasOne(x => x.Product)
                .WithOne(x => x.Jewelry)
                .HasForeignKey<Jewelry>(x => x.ProductID);
        });

        modelBuilder.Entity<Warranty>(e =>
        {
            e.HasOne(x => x.User)
                .WithMany(x => x.Warranties)
                .HasForeignKey(x => x.UserId);

            e.HasOne(w => w.Product)
            .WithMany(p => p.Warranties)
            .HasForeignKey(w => w.ProductId);
        });
    }
}
