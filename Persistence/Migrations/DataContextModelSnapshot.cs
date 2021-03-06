// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Activity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Venue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Activities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7494e5b1-54ea-4a37-ab9d-bd783e008f0b"),
                            Category = "drinks",
                            City = "London",
                            Date = new DateTime(2021, 6, 23, 9, 31, 47, 591, DateTimeKind.Local).AddTicks(3442),
                            Description = "Activity 2 months ago",
                            Title = "Past Activity 1",
                            Venue = "Pub"
                        },
                        new
                        {
                            Id = new Guid("afe83825-bdf3-4fbe-8224-30f5472ad5d5"),
                            Category = "culture",
                            City = "Paris",
                            Date = new DateTime(2021, 7, 23, 9, 31, 47, 592, DateTimeKind.Local).AddTicks(835),
                            Description = "Activity 1 month ago",
                            Title = "Past Activity 2",
                            Venue = "Louvre"
                        },
                        new
                        {
                            Id = new Guid("29ab9f99-43ec-452d-86e4-66bcc2e40c66"),
                            Category = "culture",
                            City = "London",
                            Date = new DateTime(2021, 9, 23, 9, 31, 47, 592, DateTimeKind.Local).AddTicks(854),
                            Description = "Activity 1 month in future",
                            Title = "Future Activity 1",
                            Venue = "Natural History Museum"
                        },
                        new
                        {
                            Id = new Guid("440335f0-6b33-429e-8107-ec12728e3df6"),
                            Category = "music",
                            City = "London",
                            Date = new DateTime(2021, 10, 23, 9, 31, 47, 592, DateTimeKind.Local).AddTicks(857),
                            Description = "Activity 2 months in future",
                            Title = "Future Activity 2",
                            Venue = "O2 Arena"
                        },
                        new
                        {
                            Id = new Guid("f8706f28-d8d8-41a2-9b5a-e1a326731d5c"),
                            Category = "drinks",
                            City = "London",
                            Date = new DateTime(2021, 11, 23, 9, 31, 47, 592, DateTimeKind.Local).AddTicks(860),
                            Description = "Activity 3 months in future",
                            Title = "Future Activity 3",
                            Venue = "Another pub"
                        },
                        new
                        {
                            Id = new Guid("0f76a90f-9e7a-4394-8247-8d8c40c3efb8"),
                            Category = "drinks",
                            City = "London",
                            Date = new DateTime(2021, 12, 23, 9, 31, 47, 592, DateTimeKind.Local).AddTicks(862),
                            Description = "Activity 4 months in future",
                            Title = "Future Activity 4",
                            Venue = "Yet another pub"
                        },
                        new
                        {
                            Id = new Guid("63a4ca8c-c2e2-4815-961e-f9042d9c6597"),
                            Category = "drinks",
                            City = "London",
                            Date = new DateTime(2022, 1, 23, 9, 31, 47, 592, DateTimeKind.Local).AddTicks(877),
                            Description = "Activity 5 months in future",
                            Title = "Future Activity 5",
                            Venue = "Just another pub"
                        },
                        new
                        {
                            Id = new Guid("ac573536-c52b-46ca-92d3-21fd74b77640"),
                            Category = "music",
                            City = "London",
                            Date = new DateTime(2022, 2, 23, 9, 31, 47, 592, DateTimeKind.Local).AddTicks(880),
                            Description = "Activity 6 months in future",
                            Title = "Future Activity 6",
                            Venue = "Roundhouse Camden"
                        },
                        new
                        {
                            Id = new Guid("007fb57c-2907-4deb-8fe9-82da8044c89c"),
                            Category = "travel",
                            City = "London",
                            Date = new DateTime(2022, 3, 23, 9, 31, 47, 592, DateTimeKind.Local).AddTicks(882),
                            Description = "Activity 2 months ago",
                            Title = "Future Activity 7",
                            Venue = "Somewhere on the Thames"
                        },
                        new
                        {
                            Id = new Guid("42b17c8c-fdc8-49fb-bd40-0da144ec3ee2"),
                            Category = "film",
                            City = "London",
                            Date = new DateTime(2022, 4, 23, 9, 31, 47, 592, DateTimeKind.Local).AddTicks(884),
                            Description = "Activity 8 months in future",
                            Title = "Future Activity 8",
                            Venue = "Cinema"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
