using Microsoft.EntityFrameworkCore;

namespace XLog.Category.Infrastructure.Persistence
{
    public sealed class AppDbContext : DbContext
    {
        public DbSet<Domain.PARTNERS> PARTNERS { get; set; }
        public DbSet<Domain.COUNTRY> COUNTRY { get; set; }
        public DbSet<Domain.PARTNERTYPE> PARTNERTYPE { get; set; }
        public DbSet<Domain.MERCHANDISETYPE> MERCHANDISETYPE { get; set; }
        public DbSet<Domain.EXTRASERVICE> EXTRASERVICE { get; set; }
        public DbSet<Domain.PROVINCES> PROVINCES { get; set; }
        public DbSet<Domain.DISTRICTS> DISTRICTS { get; set; }
        public DbSet<Domain.WARDS> WARDS { get; set; }
        public DbSet<Domain.POSTALCODE> POSTALCODE { get; set; }
        public DbSet<Domain.DELIVERYSTATES> DELIVERYSTATES { get; set; }
        public DbSet<Domain.USERGROUPS> USERGROUPS { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //OnModelCreatingPartial(modelBuilder);
        }

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
