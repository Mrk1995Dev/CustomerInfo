using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initialEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 12, 10, 2, 10, 905, DateTimeKind.Local).AddTicks(6397)),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RemovedBy = table.Column<int>(type: "int", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CityId = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoWorkers = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 5, 12, 10, 2, 10, 905, DateTimeKind.Local).AddTicks(9053)),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RemovedBy = table.Column<int>(type: "int", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CityId",
                table: "Customers",
                column: "CityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
