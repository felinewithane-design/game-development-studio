using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_development_studio
{
    public class Publisher : Entity
    {
        public string? Address { get; set; }
        public string? ContactTerms { get; set; }
        public decimal? FundingAmount { get; set; }

        public Publisher()
        {
            Address = string.Empty;
            ContactTerms = string.Empty;
            FundingAmount = decimal.MinValue;
        }

        public Publisher(Guid id, string address, string  contactTerms, decimal? fundingAmount):base(id)
        {
            Address = address;
            ContactTerms = contactTerms;
        }

        public new bool IsValid()
        {
            return base.IsValid()&& 
                !string.IsNullOrEmpty(Address) &&
                   !string.IsNullOrEmpty(ContactTerms) &&
                   FundingAmount.HasValue &&
                   FundingAmount.Value > 0;
        }
        public sealed override string Format()
        {
            return $"{base.Format()} | {Address} | {ContactTerms} | {FundingAmount:C}";
        }

        public sealed override void Parse(string record)
        {
            base.Parse(record);

            var parts = record.Split('|', StringSplitOptions.None);
            if (parts.Length < 4)
                throw new FormatException("Invalid Publisher record format.");

            Address = parts[1].Trim();
            ContactTerms = parts[2].Trim();
            if (parts[3].Trim() == "")
                FundingAmount = null;
            else if (!decimal.TryParse(parts[3].Trim(), out decimal amount))
                throw new FormatException("Invalid funding amount.");
            else
                FundingAmount = amount;
        }

        public sealed override string FileName => "publishers.txt";
    }
}
