using Microsoft.EntityFrameworkCore;
using SawitApi.Models;

namespace SawitApi.data{
    public class SawitDbContext(DbContextOptions<SawitDbContext> options) : DbContext(options){
        public DbSet<User> Users { get; set; }
        public DbSet<Campagne> Campagnes { get; set; }
        public DbSet<Candidate> Candidates  { get;  set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Vote> Votes { get; set; }
        public DbSet<Experience> Experiences {get; set ;}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Vote>()
            .HasIndex(v => new { v.UserId, v.CampagneId })
            .IsUnique();
        }

    }
}