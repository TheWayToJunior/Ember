using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ember.Server.Migrations
{
    public partial class InitDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageSrc = table.Column<string>(nullable: true),
                    Time = table.Column<DateTime>(nullable: false),
                    Category = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Category", "Description", "ImageSrc", "Time", "Title" },
                values: new object[,]
                {
                    { 7, 2, "Согласно Правил подготовки теплового хозяйства к отопительному сезону предприятием были разработаны мероприятия по подготовке объектов теплоснабжения к работе в осеннее-зимний", "https://sun9-9.userapi.com/c850128/v850128254/1d36a9/B54sYaowd5E.jpg", new DateTime(2020, 2, 26, 14, 37, 15, 210, DateTimeKind.Local).AddTicks(5280), "Об итогах ремонтного периода." },
                    { 1, 2, "Согласно Правил подготовки теплового хозяйства к отопительному сезону предприятием были разработаны мероприятия по подготовке объектов теплоснабжения к работе в осеннее-зимнийСогласно Правил подготовки теплового хозяйства к отопительному сезону предприятием были разработаны мероприятия по подготовке объектов теплоснабжения к работе в осеннее-зимний", "https://sun9-28.userapi.com/c204516/v204516299/3b411/0qjhwQo15mw.jpg", new DateTime(2020, 2, 26, 14, 37, 15, 241, DateTimeKind.Local).AddTicks(6703), "Внимание произвадятся работы!!!" },
                    { 2, 3, "Согласно Правил подготовки теплового хозяйства к отопительному сезону предприятием были разработаны мероприятия по подготовке объектов теплоснабжения к работе в осеннее-зимний", "https://sun9-35.userapi.com/c851028/v851028124/196804/0j89FAqJ5Wg.jpg", new DateTime(2020, 2, 26, 14, 37, 15, 241, DateTimeKind.Local).AddTicks(6963), "Инвестиционная программа 2019 года" },
                    { 3, 1, "Согласно Правил подготовки теплового хозяйства к отопительному сезону предприятием были разработаны мероприятия по подготовке объектов теплоснабжения к работе в осеннее-зимний", "https://sun9-11.userapi.com/c857016/v857016695/75e15/jvemse0yWlE.jpg", new DateTime(2020, 2, 26, 14, 37, 15, 241, DateTimeKind.Local).AddTicks(6971), "Об итогах ремонтного периода." },
                    { 4, 1, "Согласно Правил подготовки теплового хозяйства к отопительному сезону предприятием были разработаны мероприятия по подготовке объектов теплоснабжения к работе в осеннее-зимний", "https://sun9-60.userapi.com/c850636/v850636790/1ff3b2/R0pcwT1oVsw.jpg", new DateTime(2020, 2, 26, 14, 37, 15, 241, DateTimeKind.Local).AddTicks(6976), "Внимание произвадятся работы!!!" },
                    { 5, 3, "Согласно Правил подготовки теплового хозяйства к отопительному сезону предприятием были разработаны мероприятия по подготовке объектов теплоснабжения к работе в осеннее-зимний", "https://sun9-28.userapi.com/c854224/v854224084/12aa7f/aJlUY851MCw.jpg", new DateTime(2020, 2, 26, 14, 37, 15, 241, DateTimeKind.Local).AddTicks(6981), "Инвестиционная программа 2019 года" },
                    { 6, 1, "Согласно Правил подготовки теплового хозяйства к отопительному сезону предприятием были разработаны мероприятия по подготовке объектов теплоснабжения к работе в осеннее-зимний", "https://sun9-26.userapi.com/c206624/v206624328/1cfc1/QhLJ8tTkLC8.jpg", new DateTime(2020, 2, 26, 14, 37, 15, 241, DateTimeKind.Local).AddTicks(6986), "Об итогах ремонтного периода." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
