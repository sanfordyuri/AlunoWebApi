using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AlunoWebApi.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    CPF = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false),
                    Nascimento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alunos");
        }
    }
}
