using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsStore.Migrations
{
    public partial class Orders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartLine_Orderd_OrderId",
                table: "CartLine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orderd",
                table: "Orderd");

            migrationBuilder.RenameTable(
                name: "Orderd",
                newName: "Orders");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartLine_Orders_OrderId",
                table: "CartLine",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartLine_Orders_OrderId",
                table: "CartLine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Orderd");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orderd",
                table: "Orderd",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartLine_Orderd_OrderId",
                table: "CartLine",
                column: "OrderId",
                principalTable: "Orderd",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
