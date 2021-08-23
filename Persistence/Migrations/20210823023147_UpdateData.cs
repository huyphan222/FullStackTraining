using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class UpdateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[,]
                {
                    { new Guid("7494e5b1-54ea-4a37-ab9d-bd783e008f0b"), "drinks", "London", new DateTime(2021, 6, 23, 9, 31, 47, 591, DateTimeKind.Local).AddTicks(3442), "Activity 2 months ago", "Past Activity 1", "Pub" },
                    { new Guid("afe83825-bdf3-4fbe-8224-30f5472ad5d5"), "culture", "Paris", new DateTime(2021, 7, 23, 9, 31, 47, 592, DateTimeKind.Local).AddTicks(835), "Activity 1 month ago", "Past Activity 2", "Louvre" },
                    { new Guid("29ab9f99-43ec-452d-86e4-66bcc2e40c66"), "culture", "London", new DateTime(2021, 9, 23, 9, 31, 47, 592, DateTimeKind.Local).AddTicks(854), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" },
                    { new Guid("440335f0-6b33-429e-8107-ec12728e3df6"), "music", "London", new DateTime(2021, 10, 23, 9, 31, 47, 592, DateTimeKind.Local).AddTicks(857), "Activity 2 months in future", "Future Activity 2", "O2 Arena" },
                    { new Guid("f8706f28-d8d8-41a2-9b5a-e1a326731d5c"), "drinks", "London", new DateTime(2021, 11, 23, 9, 31, 47, 592, DateTimeKind.Local).AddTicks(860), "Activity 3 months in future", "Future Activity 3", "Another pub" },
                    { new Guid("0f76a90f-9e7a-4394-8247-8d8c40c3efb8"), "drinks", "London", new DateTime(2021, 12, 23, 9, 31, 47, 592, DateTimeKind.Local).AddTicks(862), "Activity 4 months in future", "Future Activity 4", "Yet another pub" },
                    { new Guid("63a4ca8c-c2e2-4815-961e-f9042d9c6597"), "drinks", "London", new DateTime(2022, 1, 23, 9, 31, 47, 592, DateTimeKind.Local).AddTicks(877), "Activity 5 months in future", "Future Activity 5", "Just another pub" },
                    { new Guid("ac573536-c52b-46ca-92d3-21fd74b77640"), "music", "London", new DateTime(2022, 2, 23, 9, 31, 47, 592, DateTimeKind.Local).AddTicks(880), "Activity 6 months in future", "Future Activity 6", "Roundhouse Camden" },
                    { new Guid("007fb57c-2907-4deb-8fe9-82da8044c89c"), "travel", "London", new DateTime(2022, 3, 23, 9, 31, 47, 592, DateTimeKind.Local).AddTicks(882), "Activity 2 months ago", "Future Activity 7", "Somewhere on the Thames" },
                    { new Guid("42b17c8c-fdc8-49fb-bd40-0da144ec3ee2"), "film", "London", new DateTime(2022, 4, 23, 9, 31, 47, 592, DateTimeKind.Local).AddTicks(884), "Activity 8 months in future", "Future Activity 8", "Cinema" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("007fb57c-2907-4deb-8fe9-82da8044c89c"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("0f76a90f-9e7a-4394-8247-8d8c40c3efb8"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("29ab9f99-43ec-452d-86e4-66bcc2e40c66"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("42b17c8c-fdc8-49fb-bd40-0da144ec3ee2"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("440335f0-6b33-429e-8107-ec12728e3df6"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("63a4ca8c-c2e2-4815-961e-f9042d9c6597"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("7494e5b1-54ea-4a37-ab9d-bd783e008f0b"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("ac573536-c52b-46ca-92d3-21fd74b77640"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("afe83825-bdf3-4fbe-8224-30f5472ad5d5"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("f8706f28-d8d8-41a2-9b5a-e1a326731d5c"));
        }
    }
}
