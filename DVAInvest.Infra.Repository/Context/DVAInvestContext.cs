using DVAInvest.Domain.Entities;
using DVAInvest.Domain.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DVAInvest.Infra.Repository.Context;

public class DVAInvestContext : IdentityDbContext<User, IdentityRole<long>, long, IdentityUserClaim<long>, IdentityUserRole<long>, IdentityUserLogin<long>, IdentityRoleClaim<long>, IdentityUserToken<long>>, IUnitOfWork<DVAInvestContext>
{
    public DVAInvestContext(DbContextOptions<DVAInvestContext> options) : base(options) { }

    public int Commit() => this.SaveChanges();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //modelBuilder.ApplyConfiguration(new AlmoxarifadoMap());
        //modelBuilder.ApplyConfiguration(new MaterialMap());

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DVAInvestContext).Assembly);

    }
}
