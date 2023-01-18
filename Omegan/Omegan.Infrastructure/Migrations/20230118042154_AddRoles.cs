using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Omegan.Infrastructure.Migrations
{
    public partial class AddRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10096115-e173-4e82-903f-8b4c8f8e2ceb",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "584b7020-43b5-4832-95c2-d5aa5ef3c534", "Coordinacion Operativa", "COORDINACION OPERATIVA" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a52dfb8-8595-487e-bd07-2e876c8291a5",
                column: "ConcurrencyStamp",
                value: "f7fd2f0d-4e3c-4354-90bd-efff8bcaadbc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93296f46-5fd1-4b67-bb8d-9a9008adc8e6",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "23ec2a96-23c2-4783-a3d3-4e19b5aced8a", "Representante Legal", "Representante Legal" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9cd3b078-3254-4c05-b404-e527ec616c89",
                column: "ConcurrencyStamp",
                value: "9ad85710-1bb9-4faf-b25e-4bb7f58c646b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0b13f5f-1fdc-4937-99ac-91c4a5c8e1bc",
                column: "ConcurrencyStamp",
                value: "d90aac2d-3a3d-41dd-999b-fc0803593a03");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aebfc368-0c43-4b94-8cce-26c277ec2e33",
                column: "ConcurrencyStamp",
                value: "12485850-2e91-47f8-9704-43f5654fbfde");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b344f3b4-1df4-449e-8553-9dd7640820a2",
                column: "ConcurrencyStamp",
                value: "2a8670e8-87fa-4a05-b2ec-2d0ce064a54a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b947fb18-600f-4057-b05e-d306abffedb6",
                column: "ConcurrencyStamp",
                value: "63df50d9-7c95-49d5-9ce7-2ec3da1b28b6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3a03991c-5128-4011-85bd-5886dd9f0906", "aa78a5ca-2ad5-48f7-b40d-bd59e87bb935", "Asistente  Compensaciones", "ASISTENTE DE COMPENSACIONES" },
                    { "a02a081e-e197-40a3-85a4-3f4cfc853961", "b27af457-81fb-4e05-a6d0-90002be51fe6", "Contabilidad", "CONTABILIDAD" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7fa985ac-095c-469b-b98d-8e09a947d66a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "814c867f-83ed-4777-9df8-ce1654b9eae5", "AQAAAAEAACcQAAAAEBzQQ0IxPNZeL29dRIUvyPPvS6jfHyvor0u+JikPgIzdn5aXNevzTYmIrmWjIOMm4A==", "6b41fe63-e937-4045-9746-21f930dbfbe3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a03991c-5128-4011-85bd-5886dd9f0906");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a02a081e-e197-40a3-85a4-3f4cfc853961");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10096115-e173-4e82-903f-8b4c8f8e2ceb",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c480675f-71ae-41a1-9ae6-f235473c1efe", "Coordinacion Operactiva", "COORDINACION OPERACTIVA" });

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
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b3b97cf0-d34b-460d-a76e-77e0b7315048", "Representante Lejal", "Representante Lejal" });

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
    }
}
