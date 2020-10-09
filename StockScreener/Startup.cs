using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StockScreener.Context;

namespace StockScreener
{
    class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SymbolContext>(x => x.UseSqlServer(Configuration["AppSettings:ConnectionString"]));
            services.AddControllers();
        }
    }
}
