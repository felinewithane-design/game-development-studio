using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_development_studio
{
    public class DataManager<T> where T : IEntity
    {
        public static IEnumerable<T> Entities { get; private set; } = new List<T>();

        public static void Add(T entity)
        {
            Entities=Entities.Append(entity);
        }

        public static IEnumerable<T> Search(string searchString)
        {
            foreach (var entity in Entities)
            {
                if(entity.Search(searchString))
                {
                    yield return entity;
                }
            }
        }

        public static IEnumerable<T> Filter(FilterDelegate<T> filter)
        {
            foreach (var entity in Entities)
            {
                if (filter.Invoke(entity))
                    yield return entity;
            }
        }
    }
}
