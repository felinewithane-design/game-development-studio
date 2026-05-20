using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Text.Json;

namespace game_development_studio.Database
{
    public class StudioDbContext : DbContext
    {
        public DbSet<ProjectModel> Projects { get; set; }
        public DbSet<ProducerModel> Producers { get; set; }
        public DbSet<PublisherModel> Publishers { get; set; }
        public DbSet<DevelopmentTeamModel> DevelopmentTeams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configPath = "dbconfig.json";

            if (!File.Exists(configPath))
                throw new FileNotFoundException(
                    "dbconfig.json not found");

            var json = File.ReadAllText(configPath);
            var doc = JsonDocument.Parse(json);
            var connectionString = doc.RootElement
                .GetProperty("ConnectionString")
                .GetString();

            optionsBuilder.UseMySql(
                connectionString,
                ServerVersion.AutoDetect(connectionString)
            );
        }
    }
}