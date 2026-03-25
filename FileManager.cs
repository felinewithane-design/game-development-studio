using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace game_development_studio
{
    public static class FileManager
    {
        public static void Add(Entity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            if (!entity.IsValid())
                throw new Exception("Entity is invalid");

            string record = entity.Format();
            using (var writer = new StreamWriter(entity.FileName, append: true))
            {
                writer.WriteLine(record);
            }
        }

        public static List<T> LoadAll<T>() where T : Entity, new()
        {
            var list = new List<T>();
            string fileName = new T().FileName;

            if (!File.Exists(fileName))
                return list;

            using (var reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    T entity = new T();
                    entity.Parse(line);
                    list.Add(entity);
                }
            }
            return list;
        }
            public static string ViewAllProjects()
            {
                var projects = LoadAll<Project>();
                if (projects.Count == 0)
                    return "No projects found.";

                string result = "=== Projects ===\n";
                foreach (var p in projects)
                    result += p.Format() + "\n";
                return result;
            }

        private static List<Project> _projectCache = new List<Project>();

        public static void RefreshCache()
        {
            _projectCache = LoadAll<Project>();
        }
    }
    }