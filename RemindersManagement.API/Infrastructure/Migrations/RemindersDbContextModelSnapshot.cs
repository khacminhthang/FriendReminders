// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RemindersManagement.API.Infrastructure.Data;

namespace RemindersManagement.API.Infrastructure.Migrations
{
    [DbContext(typeof(RemindersDbContext))]
    partial class RemindersDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("RemindersManagement.API.Domain.Models.Reminder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Reminders", "reminders");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fc2036ed-72ea-495f-8833-8a9872ff1d97"),
                            Description = "Learning Microservices",
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("d569289a-f0b4-40bb-8721-9f34549c85f9"),
                            Description = "Writing Blog",
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("e0c1f691-bfa1-4d10-8a59-61282fe016d3"),
                            Description = "Presentation prepare",
                            Status = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
