using Hive.Application.Common;

namespace Hive.Infrastructure.OS
{
    public class UniversalDateTime : IDateTime
    {
        public DateTime Now => DateTime.UtcNow;
    }
}