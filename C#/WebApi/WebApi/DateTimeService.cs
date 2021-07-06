using System;

namespace WebApi
{
    public interface IDateTimeService
    {
        DateTime Now { get; }
    }

    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime Now
        {
            get { return DateTime.Now; }
        }
    }
}