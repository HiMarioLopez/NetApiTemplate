using System;
using MyOnionApi.Application.Interfaces;

namespace MyOnionApi.Infrastructure.Shared.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}