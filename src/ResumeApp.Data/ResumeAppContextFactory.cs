using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ResumeApp.Data
{
    public class ResumeAppContextFactory : IDesignTimeDbContextFactory<ResumeAppDbContext>
    {
        const string ConnectionString = "Server=tcp:pavel.database.windows.net,1433;Initial Catalog=pavel;Persist Security Info=False;User ID=pavel;Password=password12#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";

        public ResumeAppDbContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<ResumeAppDbContext>();
            optionBuilder.UseSqlServer(ConnectionString);
            return new ResumeAppDbContext(optionBuilder.Options);
        }
    }
}
