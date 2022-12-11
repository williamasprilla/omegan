using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Omegan.Infrastructure.Migrations
{
    public partial class AddFieldsTableTRM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "InitialDivision",
                table: "Trm",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MonthlyBudget",
                table: "Trm",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "NumberCompanies",
                table: "Trm",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10096115-e173-4e82-903f-8b4c8f8e2ceb",
                column: "ConcurrencyStamp",
                value: "f94a3278-ccd7-45fa-ae35-f7b2633c0551");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a52dfb8-8595-487e-bd07-2e876c8291a5",
                column: "ConcurrencyStamp",
                value: "aebd9345-3dc7-48dc-96d6-3e1d34dcecff");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93296f46-5fd1-4b67-bb8d-9a9008adc8e6",
                column: "ConcurrencyStamp",
                value: "9ed6a75f-e1e4-41a9-89f1-6a772be4de70");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9cd3b078-3254-4c05-b404-e527ec616c89",
                column: "ConcurrencyStamp",
                value: "39d77a0e-002b-4bd2-8c25-1cefe9336401");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0b13f5f-1fdc-4937-99ac-91c4a5c8e1bc",
                column: "ConcurrencyStamp",
                value: "4d8766f2-697a-43d4-b16b-22c44e5e954e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aebfc368-0c43-4b94-8cce-26c277ec2e33",
                column: "ConcurrencyStamp",
                value: "87b9e819-da54-4258-adcd-3bc96a46d8bd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b344f3b4-1df4-449e-8553-9dd7640820a2",
                column: "ConcurrencyStamp",
                value: "6e54481f-02e5-4acf-8dd0-afffbcd39d13");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b947fb18-600f-4057-b05e-d306abffedb6",
                column: "ConcurrencyStamp",
                value: "038c385c-957e-4567-9132-79854fc2a078");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7fa985ac-095c-469b-b98d-8e09a947d66a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "731fd518-b8cd-491f-8231-8e7af2f00f79", "AQAAAAEAACcQAAAAENHPki1mWssTcXzXPHXUnQpE9G74yfv5YWXCBonWVkgky4mDB3HsaASlYBjuj1AOwQ==", "340d87b1-2329-4f98-9c17-96b2bf2997cc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InitialDivision",
                table: "Trm");

            migrationBuilder.DropColumn(
                name: "MonthlyBudget",
                table: "Trm");

            migrationBuilder.DropColumn(
                name: "NumberCompanies",
                table: "Trm");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10096115-e173-4e82-903f-8b4c8f8e2ceb",
                column: "ConcurrencyStamp",
                value: "f3ba04ae-49d8-4ee4-9338-5bddba1e780e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a52dfb8-8595-487e-bd07-2e876c8291a5",
                column: "ConcurrencyStamp",
                value: "2c5027a9-3153-43f5-acf7-64ace6dfcdea");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93296f46-5fd1-4b67-bb8d-9a9008adc8e6",
                column: "ConcurrencyStamp",
                value: "b3aa2890-1647-4bcf-aa9c-438e2ac81fb8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9cd3b078-3254-4c05-b404-e527ec616c89",
                column: "ConcurrencyStamp",
                value: "36776ab3-67a2-480d-9261-417ef13a6fec");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0b13f5f-1fdc-4937-99ac-91c4a5c8e1bc",
                column: "ConcurrencyStamp",
                value: "9b088155-8777-4188-a0b0-2ebc14800246");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aebfc368-0c43-4b94-8cce-26c277ec2e33",
                column: "ConcurrencyStamp",
                value: "64d748cc-e14b-4ebf-84c4-6d4812cc1eef");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b344f3b4-1df4-449e-8553-9dd7640820a2",
                column: "ConcurrencyStamp",
                value: "5ea4c583-eed9-4948-b5f0-952c3b4e036f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b947fb18-600f-4057-b05e-d306abffedb6",
                column: "ConcurrencyStamp",
                value: "10d5d60a-44ac-4666-a05e-69100857ddd8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7fa985ac-095c-469b-b98d-8e09a947d66a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b414a5c8-2161-40e1-a184-12e0c8f82236", "AQAAAAEAACcQAAAAEHyOHu7jodPfioM1MHLlGAjrYpjU5z7CXmGABtS6N5dOOq+w1iLBW6sQ8qH19Jnaow==", "72a632d1-e8ee-4545-b9fe-9c6e55f6b125" });
        }
    }
}
