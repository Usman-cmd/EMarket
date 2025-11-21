using EMarket.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EMarket.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Graphics Cards", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Processors", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Monitors", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 1,
                    Name = "Apex Innovations",
                    StreetAddress = "123 Innovation Dr",
                    City = "Silicon Valley",
                    PostalCode = "94043",
                    State = "CA",
                    PhoneNumber = "8005550101"
                },
                new Company
                {
                    Id = 2,
                    Name = "CircuitWorks",
                    StreetAddress = "456 Component Ave",
                    City = "Austin",
                    PostalCode = "78701",
                    State = "TX",
                    PhoneNumber = "8005550102"
                },
                new Company
                {
                    Id = 3,
                    Name = "Digital Horizon",
                    StreetAddress = "789 Pixel Blvd",
                    City = "Seattle",
                    PostalCode = "98101",
                    State = "WA",
                    PhoneNumber = "8005550103"
                }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Apex Nova RTX 5080",
                    Brand = "Apex Innovations", 
                    Description = "Experience next-generation gaming with hyper-realistic ray tracing and AI-powered performance boosts. The flagship GPU for enthusiasts.",
                    ModelNumber = "APX-NV-5080",   
                    ListPrice = 1299,
                    Price = 1199,
                    Price50 = 1149,
                    Price100 = 1099,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Title = "CircuitWorks Pulse RX 9800XT",
                    Brand = "CircuitWorks",
                    Description = "A powerful competitor offering incredible 4K performance and high refresh rates. Built on a revolutionary new architecture.",
                    ModelNumber = "CW-PL-9800XT",
                    ListPrice = 999,
                    Price = 949,
                    Price50 = 899,
                    Price100 = 849,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = "Apex Core i9 Ultra",
                    Brand = "Apex Innovations",
                    Description = "Unleash extreme mega-tasking performance with 16 cores and 24 threads. The ultimate CPU for content creation and hardcore gaming.",
                    ModelNumber = "APX-CPU-i9U",
                    ListPrice = 649,
                    Price = 629,
                    Price50 = 599,
                    Price100 = 579,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 4,
                    Title = "Digital Horizon Ryzen 9",
                    Brand = "Digital Horizon",
                    Description = "Dominate your workload with this efficient and powerful processor. Perfect for streamers, creators, and professionals.",
                    ModelNumber = "DH-RYZ-9X",
                    ListPrice = 599,
                    Price = 579,
                    Price50 = 549,
                    Price100 = 529,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 5,
                    Title = "Digital Horizon ProArt 32\" 4K",
                    Brand = "Digital Horizon",
                    Description = "A professional 32-inch 4K HDR monitor with exceptional color accuracy. Designed for photographers, videographers, and graphic designers.",
                    ModelNumber = "DH-MON-PA32K",
                    ListPrice = 899,
                    Price = 849,
                    Price50 = 829,
                    Price100 = 799,
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 6,
                    Title = "CircuitWorks Gaming 27\" QHD 240Hz",
                    Brand = "CircuitWorks",
                    Description = "Gain the competitive edge with a blazing-fast 240Hz refresh rate and a crisp QHD resolution. Smooth, tear-free gaming has arrived.",
                    ModelNumber = "CW-MON-GM27Q",
                    ListPrice = 449,
                    Price = 429,
                    Price50 = 399,
                    Price100 = 379,
                    CategoryId = 3,
                    ImageUrl = ""
                }
                );
        }
    }
}