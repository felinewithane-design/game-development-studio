using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_development_studio
{
    public class Project : Entity, IEntity
    {
        public bool Search(string searchString)
        {
            return Title!.Contains(searchString, StringComparison.OrdinalIgnoreCase) ||
                Genre!.Contains(searchString, StringComparison.OrdinalIgnoreCase) ||
                Status!.Contains(searchString, StringComparison.OrdinalIgnoreCase);
        }
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public decimal Budget { get; set; }
        public string? Status { get; set; }
        public DateTime? Deadline { get; set; }
        public DateTime? StartDate { get; set; }
        public Producer? Producer { get; set; }
        public Publisher? Publisher { get; set; }
        public DevelopmentTeam? DevelopmentTeam { get; set; }

        public Project()
        {
            Title = string.Empty;
            Genre = string.Empty;
            Budget = 0;
            Status = string.Empty;
            Deadline = null;
            StartDate = null;
        }

        public Project(Guid id, string title, string genre, decimal budget, DateTime deadline, DateTime startDate) : base(id)
        {
            Title = title;
            Genre = genre;
            Budget = budget;
            Deadline = deadline;
            StartDate = startDate;
        }

        public string this[int index]
        {
            get
            {
                return index switch
                {
                    0 => Title ?? "",
                    1 => Genre ?? "",
                    2 => Status ?? "",
                    3 => Budget.ToString("F2"),
                    _ => throw new IndexOutOfRangeException("Index must be between 0 and 3.")
                };
            }
        }
        public new bool IsValid()
        {
            return base.IsValid() &&
                !string.IsNullOrEmpty(Title) &&
                !string.IsNullOrEmpty(Status) &&
                Budget > 0 &&
                Deadline != null &&
                StartDate != null;
        }

        public sealed override string Format()
        {
            return string.Join(" | ",
                base.Format(),
                Title ?? "",
                Genre ?? "",
                Budget.ToString("F2"),
                Status ?? "",
                StartDate?.ToString("O") ?? "",
                Deadline?.ToString("O") ?? "",
                Producer?.Id.ToString() ?? "",
                Publisher?.Id.ToString() ?? "",
                DevelopmentTeam?.Id.ToString() ?? ""
            );
        }

        public sealed override void Parse(string record)
        {
            base.Parse(record);

            var parts = record.Split('|', StringSplitOptions.None);
            if (parts.Length < 10)
                throw new FormatException("Invalid Project record format.");

            Title = parts[1].Trim();
            Genre = parts[2].Trim();

            if (!decimal.TryParse(parts[3].Trim(), out decimal budget))
                throw new FormatException("Invalid budget.");
            Budget = budget;

            Status = parts[4].Trim();

            if (!DateTime.TryParse(parts[5].Trim(), out DateTime start))
                throw new FormatException("Invalid start date.");
            StartDate = start;

            if (string.IsNullOrWhiteSpace(parts[6].Trim()))
                Deadline = null;
            else if (!DateTime.TryParse(parts[6].Trim(), out DateTime deadline))
                throw new FormatException("Invalid deadline.");
            else
                Deadline = deadline;

            if (!string.IsNullOrWhiteSpace(parts[7].Trim()) && Guid.TryParse(parts[7].Trim(), out Guid producerId))
                Producer = new Producer { Id = producerId };
            else
                Producer = null;

            if (!string.IsNullOrWhiteSpace(parts[8].Trim()) && Guid.TryParse(parts[8].Trim(), out Guid publisherId))
                Publisher = new Publisher { Id = publisherId };
            else
                Publisher = null;

            if (!string.IsNullOrWhiteSpace(parts[9].Trim()) && Guid.TryParse(parts[9].Trim(), out Guid teamId))
                DevelopmentTeam = new DevelopmentTeam { Id = teamId };
            else
                DevelopmentTeam = null;
        }

        public sealed override string FileName => "projects.txt";
    }
}