using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Lanches.Infra.Data.Context;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var optionBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionBuilder.UseSqlServer("Server=.;Database=Lanches;User Id=sa;Password=1q2w3e4r@#$;Trust Server Certificate=true");

        return new AppDbContext(optionBuilder.Options);
    }
}
