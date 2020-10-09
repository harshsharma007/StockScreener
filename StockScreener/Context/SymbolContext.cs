using StockScreener.Model;
using Microsoft.EntityFrameworkCore;

namespace StockScreener.Context
{
    class SymbolContext : DbContext
    {
        public SymbolContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Symbol> Symbols { get; set; }
    }
}
