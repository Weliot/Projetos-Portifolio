using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TravelApp.Authorization.Roles;
using TravelApp.Authorization.Users;
using TravelApp.MultiTenancy;

namespace TravelApp.EntityFrameworkCore
{
    public class TravelAppDbContext : AbpZeroDbContext<Tenant, Role, User, TravelAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public TravelAppDbContext(DbContextOptions<TravelAppDbContext> options)
            : base(options)
        {
        }
    }
}
