using Microsoft.EntityFrameworkCore;
using SawitApi.Models;

namespace SawitApi.data{
    public class SawitDbContext(DbContextOptions<SawitDbContext> options) : DbContext(options){
        public DbSet<User> Users { get; set; }
        
}
}