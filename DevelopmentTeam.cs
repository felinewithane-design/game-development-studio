using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_development_studio
{
    public class DevelopmentTeam : Entity
    {
        public string? TeamName { get; set; }
        public string? Specialization { get; set; }
        public int NumberOfMembers { get; set; }
        public string? LeadDeveloper { get; set; }
    

    public DevelopmentTeam()
        {
            TeamName = string.Empty;
            Specialization = string.Empty;
            NumberOfMembers = 0;
            LeadDeveloper = string.Empty;
        }
        public DevelopmentTeam(Guid teamId, string teamName, string specialization, int numberOfMembers, string leadDeveloper) : base(teamId)
        {
            TeamName = teamName;
            Specialization = specialization;
            NumberOfMembers = numberOfMembers;
            LeadDeveloper = leadDeveloper;
        }

        public new bool IsValid()
        {
            return base.IsValid()&& 
                !string.IsNullOrEmpty(TeamName) &&
                !string.IsNullOrEmpty(Specialization) &&
                !string.IsNullOrEmpty(LeadDeveloper) &&
                NumberOfMembers > 0;
        }

        public sealed override string Format()
        {
            return $"{base.Format()} | {TeamName} ({Specialization}) - Lead: {LeadDeveloper}, Members: {NumberOfMembers}";
        }

        public sealed override void Parse(string record)
        {
            base.Parse(record);

            var parts = record.Split('|', StringSplitOptions.None);
            if (parts.Length < 5)
                throw new FormatException("Invalid DevelopmentTeam record format.");

            TeamName = parts[1].Trim();
            Specialization = parts[2].Trim();
            if (!int.TryParse(parts[3].Trim(), out int members))
                throw new FormatException("Invalid number of members.");
            NumberOfMembers = members;
            LeadDeveloper = parts[4].Trim();
        }

        public sealed override string FileName => "developmentteams.txt";
    }
}
