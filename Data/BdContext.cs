using BootCampDev.Models;
using Microsoft.EntityFrameworkCore;

namespace BootCampDev.Data
{
    public class BdContext : DbContext
    {
        public BdContext(DbContextOptions<BdContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
    }
}
