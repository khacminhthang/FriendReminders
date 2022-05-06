using RemindersManagement.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RemindersManagement.API.Domain.Interfaces
{
    public interface IRemindersService
    {
        Task<IEnumerable<Reminder>> GetRemindersAsync();
        Task<Reminder> GetReminderAsync(Guid id);
        Task<Reminder> PutReminderAsync(Reminder reminder);
        Task<Reminder> DeleteReminder(Guid id);
        Task<Reminder> PutReminderAsync(Guid id, Reminder reminder);
    }
}
