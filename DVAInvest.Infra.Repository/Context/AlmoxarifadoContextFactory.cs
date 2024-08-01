using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DVAInvest.Infra.Repository.Context;

public class AlmoxarifadoContextFactory : IDesignTimeDbContextFactory<DVAInvestContext>
{
    public DVAInvestContext CreateDbContext(string[] args)
    {
        var configPath = args.Length > 0 ? args[0] : Directory.GetCurrentDirectory();
        var configuration = new ConfigurationBuilder()
            .SetBasePath(configPath)
            .AddJsonFile("appsettings.json")
            .Build();

        var optionsBuilder = new DbContextOptionsBuilder<DVAInvestContext>();
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("DVAInvestConnection"));

        return new DVAInvestContext(optionsBuilder.Options);
    }
}
