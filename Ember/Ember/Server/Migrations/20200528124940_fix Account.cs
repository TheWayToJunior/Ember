using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ember.Server.Migrations
{
    public partial class fixAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentHistory_Account_AccountNumberId",
                table: "PaymentHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersAccounts_Account_AccountId",
                table: "UsersAccounts");

            migrationBuilder.DropIndex(
                name: "IX_PaymentHistory_AccountNumberId",
                table: "PaymentHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Account",
                table: "Account");

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "NumberId",
                keyValue: "161932");

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "NumberId",
                keyValue: "193216");

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "NumberId",
                keyValue: "321619");

            migrationBuilder.DropColumn(
                name: "AccountNumberId",
                table: "PaymentHistory");

            migrationBuilder.DropColumn(
                name: "NumberId",
                table: "Account");

            migrationBuilder.RenameTable(
                name: "Account",
                newName: "Accounts");

            migrationBuilder.AddColumn<string>(
                name: "AccountNumber",
                table: "PaymentHistory",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "Accounts",
                maxLength: 6,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts",
                column: "Number");

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Number", "Address", "Payment" },
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
                value: new DateTime(2020, 5, 28, 15, 49, 39, 86, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2020, 5, 28, 15, 49, 39, 89, DateTimeKind.Local).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2020, 5, 28, 15, 49, 39, 89, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.CreateIndex(
                name: "IX_PaymentHistory_AccountNumber",
                table: "PaymentHistory",
                column: "AccountNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentHistory_Accounts_AccountNumber",
                table: "PaymentHistory",
                column: "AccountNumber",
                principalTable: "Accounts",
                principalColumn: "Number",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersAccounts_Accounts_AccountId",
                table: "UsersAccounts",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Number",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentHistory_Accounts_AccountNumber",
                table: "PaymentHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersAccounts_Accounts_AccountId",
                table: "UsersAccounts");

            migrationBuilder.DropIndex(
                name: "IX_PaymentHistory_AccountNumber",
                table: "PaymentHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Number",
                keyValue: "161932");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Number",
                keyValue: "193216");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Number",
                keyValue: "321619");

            migrationBuilder.DropColumn(
                name: "AccountNumber",
                table: "PaymentHistory");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Accounts");

            migrationBuilder.RenameTable(
                name: "Accounts",
                newName: "Account");

            migrationBuilder.AddColumn<string>(
                name: "AccountNumberId",
                table: "PaymentHistory",
                type: "nvarchar(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumberId",
                table: "Account",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Account",
                table: "Account",
                column: "NumberId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentHistory_Account_AccountNumberId",
                table: "PaymentHistory",
                column: "AccountNumberId",
                principalTable: "Account",
                principalColumn: "NumberId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersAccounts_Account_AccountId",
                table: "UsersAccounts",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "NumberId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
