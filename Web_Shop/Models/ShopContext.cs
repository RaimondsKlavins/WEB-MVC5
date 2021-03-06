using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Web_Shop.Models
{
    public class ShopContext : DbContext
    {
        static ShopContext()
        {
            Database.SetInitializer<ShopContext>(null);
        }
        //connectionString="data source=WIN-QUV67OKIEV1\MSSQLSERVER01;Initial Catalog=ShopDb;User Id=SqlManager;Password=Gr33k!manager" 
        public ShopContext()
            : base(@"Data Source=WIN-QUV67OKIEV1\MSSQLSERVER01;Initial Catalog=ShopDb;Persist Security Info=True;User ID=SqlManager;Password=Gr33k!manager;MultipleActiveResultSets=True")
        {
        }

        //public ShopContext() : base("name=WebShopDBConnectionString")
        //{
        //    //Database.SetInitializer<ShopContext>(new ShopInitializer());
        //}

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Garment> Garments { get; set; }

        public DbSet<Purchase> Purchases { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Web_Shop.Models.BusinessModel> BusinessModels { get; set; }
    }
}