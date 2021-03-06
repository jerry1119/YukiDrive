using Microsoft.EntityFrameworkCore;
using YukiDrive.Models;

namespace YukiDrive.Contexts
{
    public class SettingContext : DbContext
    {
        public DbSet<Setting> Settings { get; set; }

        public SettingContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlite(Configuration.ConnectionString);
        }
    }
}