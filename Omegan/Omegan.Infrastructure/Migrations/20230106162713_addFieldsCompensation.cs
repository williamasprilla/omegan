using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Omegan.Infrastructure.Migrations
{
    public partial class addFieldsCompensation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdDestinationCountry",
                table: "Compensation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "Compensation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10096115-e173-4e82-903f-8b4c8f8e2ceb",
                column: "ConcurrencyStamp",
                value: "1133aff1-75c7-4dd6-b257-8e86b27354c7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a52dfb8-8595-487e-bd07-2e876c8291a5",
                column: "ConcurrencyStamp",
                value: "15aa4abe-0bf6-44d8-ac94-9ac948da9f5a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93296f46-5fd1-4b67-bb8d-9a9008adc8e6",
                column: "ConcurrencyStamp",
                value: "6fc0cbc9-ea4a-4515-af5a-dd6be7c0f786");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9cd3b078-3254-4c05-b404-e527ec616c89",
                column: "ConcurrencyStamp",
                value: "648a8bfd-b3fd-4f65-acc0-7ffef5415590");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0b13f5f-1fdc-4937-99ac-91c4a5c8e1bc",
                column: "ConcurrencyStamp",
                value: "ad8919d4-8daf-4a61-ac83-a41ee93b5d0f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aebfc368-0c43-4b94-8cce-26c277ec2e33",
                column: "ConcurrencyStamp",
                value: "8005ac45-c20a-4e42-a3d3-643239176332");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b344f3b4-1df4-449e-8553-9dd7640820a2",
                column: "ConcurrencyStamp",
                value: "93f854ce-97b6-4c0a-a9de-b60ddcba847b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b947fb18-600f-4057-b05e-d306abffedb6",
                column: "ConcurrencyStamp",
                value: "d44830cc-000e-46a7-a743-03daefa4c39b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7fa985ac-095c-469b-b98d-8e09a947d66a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70440d00-bbab-459a-9fa8-8f3b497aa9e7", "AQAAAAEAACcQAAAAEFQqc4FTZfS0TVtiSJb5pKc1J5jvSrUEPWSaswYzh+X6l3l0DICmoDM1bfVg9U5ObA==", "054325bc-3e0f-4638-8f70-777a80e91f8f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdDestinationCountry",
                table: "Compensation");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Compensation");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10096115-e173-4e82-903f-8b4c8f8e2ceb",
                column: "ConcurrencyStamp",
                value: "d69a79cd-1ccc-4033-acb0-df0ab0280e91");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a52dfb8-8595-487e-bd07-2e876c8291a5",
                column: "ConcurrencyStamp",
                value: "7144cff9-6d08-461b-a10b-7c47d7c16f42");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93296f46-5fd1-4b67-bb8d-9a9008adc8e6",
                column: "ConcurrencyStamp",
                value: "4b6fa706-9d02-4d77-8e57-ca627ade32d9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9cd3b078-3254-4c05-b404-e527ec616c89",
                column: "ConcurrencyStamp",
                value: "b39908a6-d9b2-46b2-9ada-3e808bdc039c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0b13f5f-1fdc-4937-99ac-91c4a5c8e1bc",
                column: "ConcurrencyStamp",
                value: "e3055302-6d5c-4575-867f-600c968bf452");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aebfc368-0c43-4b94-8cce-26c277ec2e33",
                column: "ConcurrencyStamp",
                value: "9d68e69a-a718-4916-b5d4-c10929c213f8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b344f3b4-1df4-449e-8553-9dd7640820a2",
                column: "ConcurrencyStamp",
                value: "04940fa4-414b-40a8-8454-b69a12d1a583");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b947fb18-600f-4057-b05e-d306abffedb6",
                column: "ConcurrencyStamp",
                value: "5998c8ce-38a3-4144-bbce-64f7b134d756");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7fa985ac-095c-469b-b98d-8e09a947d66a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0b7cb0c-a2c1-469d-a34a-1391b13139cf", "AQAAAAEAACcQAAAAELHwXtE2NP2Vli08jo646TKYtIcqiI14GpnQJBE+Dx/mW5e/fXPbLBm8XwrFCE+O+w==", "fcc2e459-8591-4aba-94bf-2a399b9e267d" });
        }
    }
}
