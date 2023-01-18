using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Omegan.Infrastructure.Migrations
{
    public partial class addFieldsStateTRM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "Trm",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10096115-e173-4e82-903f-8b4c8f8e2ceb",
                column: "ConcurrencyStamp",
                value: "c480675f-71ae-41a1-9ae6-f235473c1efe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a52dfb8-8595-487e-bd07-2e876c8291a5",
                column: "ConcurrencyStamp",
                value: "d1f0baa7-d1a9-42c2-ba03-5074d7add1c2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93296f46-5fd1-4b67-bb8d-9a9008adc8e6",
                column: "ConcurrencyStamp",
                value: "b3b97cf0-d34b-460d-a76e-77e0b7315048");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9cd3b078-3254-4c05-b404-e527ec616c89",
                column: "ConcurrencyStamp",
                value: "a8272114-d765-45fb-9a00-76386424a371");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0b13f5f-1fdc-4937-99ac-91c4a5c8e1bc",
                column: "ConcurrencyStamp",
                value: "44b71d82-a314-4493-b1e5-60bbeffb8e15");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aebfc368-0c43-4b94-8cce-26c277ec2e33",
                column: "ConcurrencyStamp",
                value: "28016aba-2e44-4418-98a7-e7a17e956cec");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b344f3b4-1df4-449e-8553-9dd7640820a2",
                column: "ConcurrencyStamp",
                value: "270dd08e-ee2d-4588-a5df-17bda4467052");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b947fb18-600f-4057-b05e-d306abffedb6",
                column: "ConcurrencyStamp",
                value: "354f234e-099a-4774-a0ea-11bc14cfceec");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7fa985ac-095c-469b-b98d-8e09a947d66a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a7d9fbe-cc66-41fd-831f-20b0414272b8", "AQAAAAEAACcQAAAAEN61gwZErimSO/AZvBmouaAvDBLN7gxopCZ2D5oGAs5ESE7s5erZgruLUsnEnM2MQQ==", "9c5d019f-9533-4204-8ff8-be311d9eb47f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "Trm");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10096115-e173-4e82-903f-8b4c8f8e2ceb",
                column: "ConcurrencyStamp",
                value: "0dd40951-1705-4a53-a1eb-e3342a0b91a6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a52dfb8-8595-487e-bd07-2e876c8291a5",
                column: "ConcurrencyStamp",
                value: "0b12d613-dad5-4f7b-9d2a-bf2d8282de6a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93296f46-5fd1-4b67-bb8d-9a9008adc8e6",
                column: "ConcurrencyStamp",
                value: "a4dbedd9-a72c-4cab-bafc-02cafe5e5ec5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9cd3b078-3254-4c05-b404-e527ec616c89",
                column: "ConcurrencyStamp",
                value: "fd8d2381-3bce-4fdb-a02f-8892acc904ac");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0b13f5f-1fdc-4937-99ac-91c4a5c8e1bc",
                column: "ConcurrencyStamp",
                value: "4fa6906f-86f4-4dbd-8f3c-d699c4e36d39");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aebfc368-0c43-4b94-8cce-26c277ec2e33",
                column: "ConcurrencyStamp",
                value: "06b7c246-3520-4da7-ab28-4de97e2fbd92");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b344f3b4-1df4-449e-8553-9dd7640820a2",
                column: "ConcurrencyStamp",
                value: "93955196-a96c-460d-be18-c0b91f62fb53");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b947fb18-600f-4057-b05e-d306abffedb6",
                column: "ConcurrencyStamp",
                value: "e88a96dc-dd44-4cb0-802d-83e3d33b6b41");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7fa985ac-095c-469b-b98d-8e09a947d66a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0358fc80-2f86-4c49-9488-96a4810ea7c4", "AQAAAAEAACcQAAAAEENgdfIeXoA7fJByZEla2gLsG2UHzhAfgHqMNiWczqkPFhpk7NTbpvLK6FzA0nNk2g==", "05f94e83-5fcd-4e43-ae86-24e475b022db" });
        }
    }
}
