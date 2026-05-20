using System;
using System.Collections.Generic;
using System.Linq;

namespace game_development_studio.Database
{
    public static class StudioDataManager
    {
        // ── CREATE ────────────────────────────────────────────────────────

        public static void AddProject(ProjectModel project)
        {
            using var db = new StudioDbContext();
            db.Projects.Add(project);
            db.SaveChanges();
        }

        public static void AddProducer(ProducerModel producer)
        {
            using var db = new StudioDbContext();
            db.Producers.Add(producer);
            db.SaveChanges();
        }

        public static void AddPublisher(PublisherModel publisher)
        {
            using var db = new StudioDbContext();
            db.Publishers.Add(publisher);
            db.SaveChanges();
        }

        public static void AddDevelopmentTeam(DevelopmentTeamModel team)
        {
            using var db = new StudioDbContext();
            db.DevelopmentTeams.Add(team);
            db.SaveChanges();
        }

        // ── READ ──────────────────────────────────────────────────────────

        public static List<ProjectModel> GetAllProjects()
        {
            using var db = new StudioDbContext();
            return db.Projects
                .OrderBy(p => p.Title)
                .ToList();
        }

        public static ProjectModel? GetProjectById(int id)
        {
            using var db = new StudioDbContext();
            return db.Projects.FirstOrDefault(p => p.Id == id);
        }

        public static List<ProducerModel> GetAllProducers()
        {
            using var db = new StudioDbContext();
            return db.Producers.ToList();
        }

        // ── UPDATE ────────────────────────────────────────────────────────

        public static void UpdateProject(ProjectModel updated)
        {
            using var db = new StudioDbContext();
            db.Projects.Update(updated);
            db.SaveChanges();
        }

        // ── DELETE ────────────────────────────────────────────────────────

        public static void DeleteProject(int id)
        {
            using var db = new StudioDbContext();
            var project = db.Projects.FirstOrDefault(p => p.Id == id);
            if (project != null)
            {
                db.Projects.Remove(project);
                db.SaveChanges();
            }
        }
    }
}