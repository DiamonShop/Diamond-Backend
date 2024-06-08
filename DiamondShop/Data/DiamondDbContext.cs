using DiamondShop.Data;
using Microsoft.EntityFrameworkCore;

namespace FAMS.Entities.Data
{
    public class DiamondDbContext : DbContext
	{
		public DiamondDbContext()
		{

		}
		public DiamondDbContext(DbContextOptions<DiamondDbContext> options) : base(options)
		{
		}

		public DbSet<User> Users { get; set; }
		public DbSet<Role> Roles { get; set; }
		public DbSet<ShoppingCartViewModel> ShoppingCarts { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<CartItem> CartItems { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Certificate> Certificates { get; set; }
		public DbSet<ProductDetail> ProductDetails { get; set; }
		public DbSet<Warranty> Warranties { get; set; }
		public DbSet<Feedback> Feedbacks { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>(e =>
			{
				e.ToTable("User");
				e.HasKey(x => x.UserId);
				e.Property(x => x.Username);
				e.Property(x => x.Password);
				e.Property(x => x.Email);
				e.Property(x => x.FullName);
				e.Property(x => x.RoleId);
				e.Property(x => x.IsActive);
				e.HasOne(x => x.Role)
					.WithMany(x => x.Users)
					.HasForeignKey(x => x.RoleId);
			});

			modelBuilder.Entity<Role>(e =>
			{
				e.ToTable("Role");
				e.HasKey(x => x.RoleId);
				e.Property(x => x.RoleName);
			});

			modelBuilder.Entity<Certificate>(e =>
			{
				e.ToTable("Certificate");
				e.HasKey(x => x.CertificateId);
				e.Property(x => x.CaratWeight).HasColumnType("decimal(18,2)");
				e.Property(x => x.Clarity);
				e.Property(x => x.Color);
				e.Property(x => x.Cut);
				e.Property(x => x.ProductId);

				e.HasOne(x => x.Product)
					.WithOne(x => x.Certificate)
					.HasForeignKey<Certificate>(x => x.ProductId);
			});

			modelBuilder.Entity<Order>(e =>
			{
				e.ToTable("Order");
				e.HasKey(x => x.OrderId);
				e.Property(x => x.OrderDate);
				e.Property(x => x.Status);
				e.Property(e => e.TotalPrice).HasColumnType("decimal(18,2)"); ;
				e.Property(x => x.UserId);

				e.HasOne(x => x.User)
					.WithMany(x => x.Orders)
					.HasForeignKey(x => x.UserId);
			});

			modelBuilder.Entity<CartItem>(e =>
			{
				e.ToTable("CartItem");
				e.HasKey(x => x.CartItemId);
				e.Property(e => e.OrderId);
				e.Property(e => e.CartId);
				e.Property(e => e.ProductId);
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

			modelBuilder.Entity<ProductDetail>(e =>
			{
				e.ToTable("ProductDetail");
				e.HasKey(x => x.ProductDetailId);
				e.Property(e => e.Carat).HasColumnType("decimal(18,2)");
				e.Property(e => e.Clarity);
				e.Property(e => e.Cut);
				e.Property(e => e.Color);
				e.Property(e => e.Origin);
				e.Property(e => e.ProductId);

				e.HasOne(x => x.Product)
					.WithOne(x => x.ProductDetail)
					.HasForeignKey<ProductDetail>(x => x.ProductId);
			});

			modelBuilder.Entity<Category>(e =>
			{
				e.ToTable("Category");
				e.HasKey(x => x.CategoryId);
				e.Property(e => e.CategoryName);

			});

			modelBuilder.Entity<Product>(e =>
			{
				e.ToTable("Product");
				e.HasKey(x => x.ProductId);
				e.Property(e => e.ProductName);
				e.Property(e => e.Price);
				e.Property(e => e.Description);
				e.Property(e => e.IsActive);
				e.Property(e => e.Stock);
				e.Property(e => e.CategoryId); 

				e.Property(e => e.CategoryId);
                e.Property(e => e.Price);
                e.Property(e => e.ProductName);
                e.HasOne(x => x.ProductDetail)
					.WithOne(x => x.Product)
					.HasForeignKey<ProductDetail>(x => x.ProductId);

				e.HasOne(x => x.Category)
					.WithMany(x => x.Products)
					.HasForeignKey(x => x.CategoryId);

				e.HasOne(x => x.Certificate)
					.WithOne(x => x.Product)
					.HasForeignKey<Certificate>(x => x.CertificateId);

				e.HasOne(x => x.Warranty)
					.WithOne(x => x.Product)
					.HasForeignKey<Warranty>(x => x.WarrantyId);
			});

			modelBuilder.Entity<Warranty>(e =>
			{
				e.ToTable("Warranty");
				e.HasKey(x => x.WarrantyId);
				e.Property(e => e.WarrantyPeriod);
				e.Property(e => e.ProductId);
				e.Property(e => e.UserId);

				e.HasOne(x => x.User)
					.WithMany(x => x.Warranties)
					.HasForeignKey(x => x.UserId);
			});

			modelBuilder.Entity<Feedback>(e =>
			{
				e.ToTable("Feedback");
				e.HasKey(x => x.FeedbackId);
				e.Property(e => e.Description);
				e.Property(e => e.ProductId);
				e.Property(e => e.UserId);

				e.HasOne(x => x.Product)
					.WithMany(x => x.Feedbacks)
					.HasForeignKey(x => x.ProductId);

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
		}
	}
}