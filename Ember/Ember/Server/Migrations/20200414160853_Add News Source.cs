using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ember.Server.Migrations
{
    public partial class AddNewsSource : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Posts",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageSrc",
                table: "Posts",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Posts",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Source",
                table: "Posts",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageSrc", "Time", "Title" },
                values: new object[] { "Согласно Правил подготовки теплового хозяйства к отопительному сезону предприятием были разработаны мероприятия по подготовке объектов теплоснабжения к работе в осеннее-зимний", "https://sun9-9.userapi.com/c850128/v850128254/1d36a9/B54sYaowd5E.jpg", new DateTime(2020, 4, 14, 19, 8, 51, 955, DateTimeKind.Local).AddTicks(9501), "Об итогах ремонтного периода." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "ImageSrc", "Time", "Title" },
                values: new object[] { 2, "https://sun9-28.userapi.com/c204516/v204516299/3b411/0qjhwQo15mw.jpg", new DateTime(2020, 4, 14, 19, 8, 51, 958, DateTimeKind.Local).AddTicks(7957), "Внимание произвадятся работы!!!" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "ImageSrc", "Time", "Title" },
                values: new object[] { 3, "https://sun9-35.userapi.com/c851028/v851028124/196804/0j89FAqJ5Wg.jpg", new DateTime(2020, 4, 14, 19, 8, 51, 958, DateTimeKind.Local).AddTicks(8127), "Инвестиционная программа 2019 года" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Source",
                table: "Posts");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ImageSrc",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageSrc", "Time", "Title" },
                values: new object[] { "Согласно Правил подготовки теплового хозяйства к отопительному сезону предприятием были разработаны мероприятия по подготовке объектов теплоснабжения к работе в осеннее-зимнийСогласно Правил подготовки теплового хозяйства к отопительному сезону предприятием были разработаны мероприятия по подготовке объектов теплоснабжения к работе в осеннее-зимний", "https://sun9-28.userapi.com/c204516/v204516299/3b411/0qjhwQo15mw.jpg", new DateTime(2020, 2, 26, 14, 37, 15, 241, DateTimeKind.Local).AddTicks(6703), "Внимание произвадятся работы!!!" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "ImageSrc", "Time", "Title" },
                values: new object[] { 3, "https://sun9-35.userapi.com/c851028/v851028124/196804/0j89FAqJ5Wg.jpg", new DateTime(2020, 2, 26, 14, 37, 15, 241, DateTimeKind.Local).AddTicks(6963), "Инвестиционная программа 2019 года" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "ImageSrc", "Time", "Title" },
                values: new object[] { 1, "https://sun9-11.userapi.com/c857016/v857016695/75e15/jvemse0yWlE.jpg", new DateTime(2020, 2, 26, 14, 37, 15, 241, DateTimeKind.Local).AddTicks(6971), "Об итогах ремонтного периода." });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Category", "Description", "ImageSrc", "Time", "Title" },
                values: new object[,]
                {
                    { 7, 2, "Согласно Правил подготовки теплового хозяйства к отопительному сезону предприятием были разработаны мероприятия по подготовке объектов теплоснабжения к работе в осеннее-зимний", "https://sun9-9.userapi.com/c850128/v850128254/1d36a9/B54sYaowd5E.jpg", new DateTime(2020, 2, 26, 14, 37, 15, 210, DateTimeKind.Local).AddTicks(5280), "Об итогах ремонтного периода." },
                    { 4, 1, "Согласно Правил подготовки теплового хозяйства к отопительному сезону предприятием были разработаны мероприятия по подготовке объектов теплоснабжения к работе в осеннее-зимний", "https://sun9-60.userapi.com/c850636/v850636790/1ff3b2/R0pcwT1oVsw.jpg", new DateTime(2020, 2, 26, 14, 37, 15, 241, DateTimeKind.Local).AddTicks(6976), "Внимание произвадятся работы!!!" },
                    { 5, 3, "Согласно Правил подготовки теплового хозяйства к отопительному сезону предприятием были разработаны мероприятия по подготовке объектов теплоснабжения к работе в осеннее-зимний", "https://sun9-28.userapi.com/c854224/v854224084/12aa7f/aJlUY851MCw.jpg", new DateTime(2020, 2, 26, 14, 37, 15, 241, DateTimeKind.Local).AddTicks(6981), "Инвестиционная программа 2019 года" },
                    { 6, 1, "Согласно Правил подготовки теплового хозяйства к отопительному сезону предприятием были разработаны мероприятия по подготовке объектов теплоснабжения к работе в осеннее-зимний", "https://sun9-26.userapi.com/c206624/v206624328/1cfc1/QhLJ8tTkLC8.jpg", new DateTime(2020, 2, 26, 14, 37, 15, 241, DateTimeKind.Local).AddTicks(6986), "Об итогах ремонтного периода." }
                });
        }
    }
}
