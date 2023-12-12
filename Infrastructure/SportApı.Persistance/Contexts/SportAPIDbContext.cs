using Microsoft.EntityFrameworkCore;
using SportAPI.Domain.Entities;
using SportAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportAPI.Persistance.Contexts
{
    public class SportAPIDbContext : DbContext
    {
        public SportAPIDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<LectureUser> LectureUsers { get; set; }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken=default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();
            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreateDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdateDate = DateTime.UtcNow
                };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
