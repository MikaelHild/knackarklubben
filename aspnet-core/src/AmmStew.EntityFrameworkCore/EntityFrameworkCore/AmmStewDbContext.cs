using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AmmStew.Authorization.Roles;
using AmmStew.Authorization.Users;
using AmmStew.MultiTenancy;

namespace AmmStew.EntityFrameworkCore
{
    public class AmmStewDbContext : AbpZeroDbContext<Tenant, Role, User, AmmStewDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AmmStewDbContext(DbContextOptions<AmmStewDbContext> options)
            : base(options)
        {
        }
    }
}
