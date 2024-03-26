#nullable disable

using Hive.Domain.Enums;

namespace Hive.Domain.Entities
{
    public class Investor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string NationalCode { get; set; }
        public double ReinvestPercent { get; set; }
        public InvestorType InvestorType { get; set; }

        public string FullName
        {
            get
            {
                switch (InvestorType)
                {
                    case InvestorType.Individual:
                    case InvestorType.ForeignIndividual:
                        return FirstName + " " + LastName;
                    case InvestorType.NonIndividual:
                    case InvestorType.ForeignNonIndividual:
                        return CompanyName;
                    case InvestorType.PortfolioInvestor:
                        return FirstName;
                    default:
                        return string.Join(" ", new string[] { FirstName, LastName, CompanyName }.Where(c => !string.IsNullOrEmpty(c)));
                }
            }
        }
    }
}