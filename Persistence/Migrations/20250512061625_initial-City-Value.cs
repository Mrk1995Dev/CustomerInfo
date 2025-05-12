using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initialCityValue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 5, 12, 9, 46, 25, 597, DateTimeKind.Local).AddTicks(8211),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 5, 11, 14, 45, 31, 16, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 5, 12, 9, 46, 25, 597, DateTimeKind.Local).AddTicks(5554),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 5, 11, 14, 45, 31, 16, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CreatedBy", "RemoveTime", "RemovedBy", "Title", "UpdateTime", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, null, null, "آذربایجان شرقی", null, null },
                    { 2, null, null, null, "آذربایجان غربی", null, null },
                    { 3, null, null, null, "اردبیل", null, null },
                    { 4, null, null, null, "اصفهان", null, null },
                    { 5, null, null, null, "البرز", null, null },
                    { 6, null, null, null, "ایلام", null, null },
                    { 7, null, null, null, "بوشهر", null, null },
                    { 8, null, null, null, "تهران", null, null },
                    { 9, null, null, null, "چهارمحال و بختیاری", null, null },
                    { 10, null, null, null, "خراسان جنوبی", null, null },
                    { 11, null, null, null, "خراسان رضوی", null, null },
                    { 12, null, null, null, "خراسان شمالی", null, null },
                    { 13, null, null, null, "خوزستان", null, null },
                    { 14, null, null, null, "زنجان", null, null },
                    { 15, null, null, null, "سمنان", null, null },
                    { 16, null, null, null, "سیستان و بلوچستان", null, null },
                    { 17, null, null, null, "فارس", null, null },
                    { 18, null, null, null, "قزوین", null, null },
                    { 19, null, null, null, "قم", null, null },
                    { 20, null, null, null, "کردستان", null, null },
                    { 21, null, null, null, "کرمان", null, null },
                    { 22, null, null, null, "کرمانشاه", null, null },
                    { 23, null, null, null, "کهگیلویه و بویراحمد", null, null },
                    { 24, null, null, null, "گلستان", null, null },
                    { 25, null, null, null, "گیلان", null, null },
                    { 26, null, null, null, "لرستان", null, null },
                    { 27, null, null, null, "مازندران", null, null },
                    { 28, null, null, null, "مرکزی", null, null },
                    { 29, null, null, null, "هرمزگان", null, null },
                    { 30, null, null, null, "همدان", null, null },
                    { 31, null, null, null, "یزد", null, null },
                    { 32, null, null, null, "کیش", null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 5, 11, 14, 45, 31, 16, DateTimeKind.Local).AddTicks(7825),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 5, 12, 9, 46, 25, 597, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 5, 11, 14, 45, 31, 16, DateTimeKind.Local).AddTicks(5580),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 5, 12, 9, 46, 25, 597, DateTimeKind.Local).AddTicks(5554));
        }
    }
}
