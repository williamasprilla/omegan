using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Omegan.Infrastructure.Migrations
{
    public partial class AddFilingDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FilingDate",
                table: "Compensation",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10096115-e173-4e82-903f-8b4c8f8e2ceb",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7481f18b-a81c-4b6c-8244-97d11e3c4622", "Coordinacion Operactiva", "COORDINACION OPERACTIVA" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a03991c-5128-4011-85bd-5886dd9f0906",
                column: "ConcurrencyStamp",
                value: "924421c6-9a4a-45fc-8d16-cd3d5f280cc1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a52dfb8-8595-487e-bd07-2e876c8291a5",
                column: "ConcurrencyStamp",
                value: "203eae36-95d1-4aeb-93e4-664fe34f637b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93296f46-5fd1-4b67-bb8d-9a9008adc8e6",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d99fddca-2bfd-483f-b87b-d2172322bee9", "Representante Lejal", "Representante Lejal" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9cd3b078-3254-4c05-b404-e527ec616c89",
                column: "ConcurrencyStamp",
                value: "e82770ee-a336-4ddf-b098-1118aca70bb6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a02a081e-e197-40a3-85a4-3f4cfc853961",
                column: "ConcurrencyStamp",
                value: "94829f74-5ec8-40f4-a3ea-e5fb33bbac95");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0b13f5f-1fdc-4937-99ac-91c4a5c8e1bc",
                column: "ConcurrencyStamp",
                value: "b7514705-e1dd-49eb-9ce9-9fff912c218e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aebfc368-0c43-4b94-8cce-26c277ec2e33",
                column: "ConcurrencyStamp",
                value: "0bc18dbe-bfc0-4011-8f45-60f54b4aac7e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b344f3b4-1df4-449e-8553-9dd7640820a2",
                column: "ConcurrencyStamp",
                value: "d0809fec-9b7c-46b9-b311-0405a400e22c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b947fb18-600f-4057-b05e-d306abffedb6",
                column: "ConcurrencyStamp",
                value: "bed068ac-9872-48b8-a585-e6e7dd4f8d2a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7fa985ac-095c-469b-b98d-8e09a947d66a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7209abb-c85f-4b80-b477-1744798df777", "AQAAAAEAACcQAAAAEG6KsmjsGfpL2IL8q2DUYm3v1DHbQEEBymRVrC3lbrsiVl5Vrc2ZGbxZLDbpbIxLmw==", "f69e1322-5fdf-4823-888d-4de189f07140" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FilingDate",
                table: "Compensation");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10096115-e173-4e82-903f-8b4c8f8e2ceb",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "584b7020-43b5-4832-95c2-d5aa5ef3c534", "Coordinacion Operativa", "COORDINACION OPERATIVA" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a03991c-5128-4011-85bd-5886dd9f0906",
                column: "ConcurrencyStamp",
                value: "aa78a5ca-2ad5-48f7-b40d-bd59e87bb935");

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
                keyValue: "a02a081e-e197-40a3-85a4-3f4cfc853961",
                column: "ConcurrencyStamp",
                value: "b27af457-81fb-4e05-a6d0-90002be51fe6");

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7fa985ac-095c-469b-b98d-8e09a947d66a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "814c867f-83ed-4777-9df8-ce1654b9eae5", "AQAAAAEAACcQAAAAEBzQQ0IxPNZeL29dRIUvyPPvS6jfHyvor0u+JikPgIzdn5aXNevzTYmIrmWjIOMm4A==", "6b41fe63-e937-4045-9746-21f930dbfbe3" });
        }
    }
}
