using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RemindersManagement.API.Domain.Models;

namespace RemindersManagement.API.Infrastructure.Data
{
    public class RemindersDbContext : DbContext
    {
        const string DEFAULT_SCHEMA = "reminders";
        public DbSet<Reminder> Reminders { get; set; }

        public RemindersDbContext(DbContextOptions<RemindersDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API
            modelBuilder.Entity<Reminder>(ConfigureReminders);
            // Data Seed
            modelBuilder.Entity<Reminder>().HasData(
                new Reminder
                {
                    Id = Guid.NewGuid(),
                    Description = "Learning Microservices",
                    Status = ReminderStatus.Finished
                },
                new Reminder
                {
                    Id = Guid.NewGuid(),
                    Description = "Writing Blog",
                    Status = ReminderStatus.Doing
                },
                new Reminder
                {
                    Id = Guid.NewGuid(),
                    Description = "Presentation prepare",
                    Status = ReminderStatus.Doing
                }
            );
        }

        void ConfigureReminders(EntityTypeBuilder<Reminder> reminderConfiguration)
        {
            reminderConfiguration.ToTable("Reminders", DEFAULT_SCHEMA);
            reminderConfiguration.HasKey(r => r.Id);
            reminderConfiguration.Property(r => r.Description).IsRequired();
            reminderConfiguration.Property(r => r.Status).HasColumnType("varchar(50)").IsRequired();
        }
    }
}