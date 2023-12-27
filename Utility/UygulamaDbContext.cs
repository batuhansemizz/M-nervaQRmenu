using Microsoft.EntityFrameworkCore;
using MınervaQRmenu.Models;

namespace MınervaQRmenu.Utility
{
    public class UygulamaDbContext : DbContext  
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options) { }

        public DbSet<KitapTuru> kitapTurleri { get; set; }
    }
}
