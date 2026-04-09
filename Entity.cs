using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_development_studio {


    public interface IEntity
    {
        public bool Search(string searchString);
            string this[int index] { get; }
    }

    public class Entity
    {
        public Guid Id { get; set; }

        public Entity()
        {
            Id= Guid.NewGuid();
        }

        public Entity(Guid id)
        {
            Id = id;
        }

        public virtual bool IsValid()
        {
            return Id!= Guid.Empty;
        }

        public virtual string Format()
        {
            return Id.ToString();
        }

        public virtual void Parse(string record)
        {
            if (string.IsNullOrWhiteSpace(record))
                throw new ArgumentException("Record cannot be null or empty.", nameof(record));

            var parts = record.Split('|', StringSplitOptions.None);
            if (parts.Length < 1)
                throw new FormatException("Invalid record format.");

            
            if (!Guid.TryParse(parts[0].Trim(), out Guid id))
                throw new FormatException("Invalid ID format.");
            Id = id;
        }

        public virtual string FileName => "entities.txt";
    }
}