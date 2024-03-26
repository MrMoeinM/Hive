namespace Hive.Domain.Enums
{
    public enum InvestorType
    {
        None = 0,

        /// <summary>
        /// حقیقی ایرانی
        /// </summary>
        Individual = 1,

        /// <summary>
        /// حقوقی ایرانی
        /// </summary>
        NonIndividual = 2,

        /// <summary>
        /// حقیقی خارجی
        /// </summary>
        ForeignIndividual = 3,

        /// <summary>
        /// حقوقی خارجی
        /// </summary>
        ForeignNonIndividual = 4,

        /// <summary>
        /// سبد
        /// </summary>
        PortfolioInvestor = 5
    }
}
