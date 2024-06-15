using Diamond.Entities.Data;
using DiamondShop.Data;
using DiamondShop.Model;
using Microsoft.EntityFrameworkCore;

public class DiamondDbContext : DbContext
{
    public DiamondDbContext(DbContextOptions<DiamondDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<CartItem> CartItems { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Certification> Certificates { get; set; }
    public DbSet<Diamonds> Diamonds { get; set; }
    public DbSet<Warranty> Warranties { get; set; }
    public DbSet<Feedback> Feedbacks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Mark CartItemModel as keyless
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

        modelBuilder.Entity<CartItem>(e =>
        {
            e.Property(e => e.Price).HasColumnType("decimal(18,2)");

            e.HasOne(x => x.ShoppingCart)
                .WithMany(x => x.CartItems)
                .HasForeignKey(x => x.CartId)
                .OnDelete(DeleteBehavior.NoAction);

            e.HasOne(x => x.Product)
                .WithMany(x => x.CartItems)
                .HasForeignKey(x => x.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            e.HasOne(x => x.Order)
                .WithMany(x => x.CartItems)
                .HasForeignKey(x => x.OrderId)
                .OnDelete(DeleteBehavior.NoAction);
        });

        modelBuilder.Entity<Diamonds>(e =>
        {
            e.Property(e => e.Carat).HasColumnType("decimal(18,2)");

            e.HasOne(x => x.Product)
                .WithOne(x => x.Diamond)
                .HasForeignKey<Diamonds>(x => x.ProductID);
        });

        modelBuilder.Entity<Product>(e =>
        {
            e.ToTable("Product");
            e.Property(e => e.MarkupRate).HasColumnType("decimal(18,2)");

            e.HasOne(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.CategoryId);

            e.HasOne(x => x.Diamond)
                .WithOne(x => x.Product)
                .HasForeignKey<Diamonds>(x => x.ProductID);

            e.HasOne(x => x.Warranty)
                .WithOne(x => x.Product)
                .HasForeignKey<Warranty>(x => x.WarrantyId);

            e.HasOne(x => x.JewelrySetting)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.JewelrySettingID);
        });

        modelBuilder.Entity<Feedback>(e =>
        {
            e.HasOne(x => x.Product)
                .WithMany(x => x.Feedbacks)
                .HasForeignKey(x => x.ProductID);

            e.HasOne(x => x.User)
                .WithMany(x => x.Feedbacks)
                .HasForeignKey(x => x.UserId);
        });

        modelBuilder.Entity<ShoppingCart>(e =>
        {
            e.ToTable("ShoppingCart");
            e.HasKey(x => x.CartId);
            e.Property(e => e.UserId);
            e.HasOne(x => x.User)
                .WithMany(x => x.ShoppingCarts)
                .HasForeignKey(x => x.UserId);
        });

        modelBuilder.Entity<JewelrySetting>(e =>
        {
            e.Property(e => e.BasePrice).HasColumnType("decimal(18,2)");
        });
    }
}
