using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace game_development_studio
{
    public class Person : Entity, IEntity
    {
        public override string FileName => "persons.txt";

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

        public string this[int index]
        {
            get
            {
                return index switch
                {
                    0 => FirstName ?? "",
                    1 => LastName ?? "",
                    2 => Email ?? "",
                    _ => throw new IndexOutOfRangeException("Index must be between 0 and 2.")
                };
            }
        }
        public bool Search(string searchString)
        {
            return FirstName!.Contains(searchString, StringComparison.OrdinalIgnoreCase) ||
                LastName!.Contains(searchString, StringComparison.OrdinalIgnoreCase) ||
                Email!.Contains(searchString, StringComparison.OrdinalIgnoreCase);
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
    }
}
