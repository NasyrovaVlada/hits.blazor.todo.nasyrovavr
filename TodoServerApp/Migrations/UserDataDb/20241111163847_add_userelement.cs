using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoServerApp.Migrations.UserDataDb
{
    /// <inheritdoc />
    public partial class add_userelement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserElements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Patronymic = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserElements", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "UserElements",
                columns: new[] { "Id", "Name", "Patronymic", "Surname" },
                values: new object[,]
                {
                    { 1, "Кристина", "Лебедь", "Елена" },
                    { 2, "бебе", "бебебе", "бе" },
                    { 3, "Николай", "Васильевич", "Гоголь" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserElements");
        }
    }
}
