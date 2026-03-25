using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_development_studio
{
    public class Person : Entity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }

        public Person()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Email=string.Empty;
        }

        public Person(Guid id, string firstName, string lastName, string email) : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public new bool IsValid()
        {
            return base.IsValid()&& 
                !string.IsNullOrEmpty(FirstName) &&
                   !string.IsNullOrEmpty(LastName) &&
                   !string.IsNullOrEmpty(Email);
        }

        public override string Format()
        {
            return $"{base.Format()} | {FirstName} {LastName} ({Email})";
        }

        public override void Parse(string record)
        {
            base.Parse(record); 

            var parts = record.Split('|', StringSplitOptions.None);
            if (parts.Length < 4)
                throw new FormatException("Invalid Person record format.");

            FirstName = parts[1].Trim();
            LastName = parts[2].Trim();
            Email = parts[3].Trim();
        }

        public override string FileName => "persons.txt";
    }
}
