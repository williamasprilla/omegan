using Omegan.Application.Interfaces.Common;

namespace Omegan.Infrastructure.Common
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
