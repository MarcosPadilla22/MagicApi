using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Affinity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Affinity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grimoire",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grimoire", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Identification = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Age = table.Column<short>(type: "smallint", maxLength: 2, nullable: false),
                    IdAffinity = table.Column<int>(type: "int", nullable: false),
                    IdGrimoire = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 3, 5, 18, 47, 27, 438, DateTimeKind.Local).AddTicks(730)),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_Affinity_IdAffinity",
                        column: x => x.IdAffinity,
                        principalTable: "Affinity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_Grimoire_IdGrimoire",
                        column: x => x.IdGrimoire,
                        principalTable: "Grimoire",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Affinity",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "", "Oscuridad" },
                    { 2, "", "Luz" },
                    { 3, "", "Fuego" },
                    { 4, "", "Agua" },
                    { 5, "", "Viento" },
                    { 6, "", "Tierra" }
                });

            migrationBuilder.InsertData(
                table: "Grimoire",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Trébol de 1 hoja", "Sinceridad" },
                    { 2, "Trébol de 2 hojas", "Esperanza" },
                    { 3, "Trébol de 3 hojas", "Amor" },
                    { 4, "Trébol de 4 hojas", "Buena Fortuna" },
                    { 5, "Trébol de 5 hojas", "Desesperación" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_IdAffinity",
                table: "Student",
                column: "IdAffinity",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_IdGrimoire",
                table: "Student",
                column: "IdGrimoire",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Affinity");

            migrationBuilder.DropTable(
                name: "Grimoire");
        }
    }
}
