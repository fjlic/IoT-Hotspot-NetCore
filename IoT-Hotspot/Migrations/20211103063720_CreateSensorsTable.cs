using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IoT_Hotspot.Migrations
{
    public partial class CreateSensorsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sensor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    erb_id = table.Column<int>(type: "int", nullable: false),
                    num_serie = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    passw = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    vol_1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    vol_2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    vol_3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    temp_1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    temp_2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    temp_3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    temp_4 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    door_1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    door_2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    door_3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    door_4 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    rlay_1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    rlay_2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    rlay_3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    rlay_4 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sensor", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sensor");
        }
    }
}
