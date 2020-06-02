using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ember.Server.Migrations
{
    public partial class AddUsersAccounts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    NumberId = table.Column<string>(maxLength: 6, nullable: false),
                    Payment = table.Column<decimal>(nullable: false),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.NumberId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Payment = table.Column<decimal>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    AccountNumberId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentHistory_Account_AccountNumberId",
                        column: x => x.AccountNumberId,
                        principalTable: "Account",
                        principalColumn: "NumberId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UsersAccounts",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    AccountId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersAccounts", x => new { x.UserId, x.AccountId });
                    table.ForeignKey(
                        name: "FK_UsersAccounts_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "NumberId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersAccounts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "NumberId", "Address", "Payment" },
                values: new object[,]
                {
                    { "193216", "ул. Великан д. 21 кв. 28", 125m },
                    { "321619", "ул. Жарова д. 5а кв. 47", 75m },
                    { "161932", "ул. Нежская д. 19", 547m }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2020, 5, 24, 21, 49, 1, 993, DateTimeKind.Local).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2020, 5, 24, 21, 49, 1, 995, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2020, 5, 24, 21, 49, 1, 995, DateTimeKind.Local).AddTicks(1522));

            migrationBuilder.CreateIndex(
                name: "IX_PaymentHistory_AccountNumberId",
                table: "PaymentHistory",
                column: "AccountNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersAccounts_AccountId",
                table: "UsersAccounts",
                column: "AccountId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentHistory");

            migrationBuilder.DropTable(
                name: "UsersAccounts");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2020, 5, 24, 21, 47, 58, 530, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2020, 5, 24, 21, 47, 58, 532, DateTimeKind.Local).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2020, 5, 24, 21, 47, 58, 532, DateTimeKind.Local).AddTicks(1176));
        }
    }
}
