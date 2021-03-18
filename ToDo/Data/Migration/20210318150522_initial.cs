using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDo.Data.Migration
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WhatTodos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Task = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deadline = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Done = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhatTodos", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WhatTodos");
        }
    }
}
