using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_development_studio
{
    public class Producer : Person
    {
        public string? EmployeeID { get; set; }
        public int YearsOfExperience { get; set; }

        public Producer()
        {
            EmployeeID = string.Empty;
            YearsOfExperience = 0;
        }

        public Producer(Guid id, string firstName, string lastName, string email, string employeeID, int yearsOfExperience) : base(id, firstName, lastName, email)
        {
        EmployeeID = employeeID;
        YearsOfExperience = yearsOfExperience;
        }

        public new bool IsVaid()
        {
            return base.IsValid()&& 
                !string.IsNullOrEmpty(EmployeeID) &&
                    YearsOfExperience > 0;
        }

        public sealed override string Format()
        {
            return $"{base.Format()} | {EmployeeID} ({YearsOfExperience})";
        }

        public sealed override void Parse(string record)
        {
            base.Parse(record);

            var parts = record.Split('|', StringSplitOptions.None);
            if (parts.Length < 6)
                throw new FormatException("Invalid Producer record format.");

            EmployeeID = parts[4].Trim();
            if (!int.TryParse(parts[5].Trim(), out int years))
                throw new FormatException("Invalid years of experience.");
            YearsOfExperience = years;
        }

        public sealed override string FileName => "producers.txt";
    }
}
