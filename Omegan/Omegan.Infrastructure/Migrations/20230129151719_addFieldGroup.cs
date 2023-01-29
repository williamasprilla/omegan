using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Omegan.Infrastructure.Migrations
{
    public partial class addFieldGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCompensation_Compensation_CompensationId",
                table: "ProductCompensation");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCompensation_Products_ProductId",
                table: "ProductCompensation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCompensation",
                table: "ProductCompensation");

            migrationBuilder.RenameTable(
                name: "ProductCompensation",
                newName: "ProductCompensations");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCompensation_CompensationId",
                table: "ProductCompensations",
                newName: "IX_ProductCompensations_CompensationId");

            migrationBuilder.AddColumn<int>(
                name: "Group",
                table: "Archives",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCompensations",
                table: "ProductCompensations",
                columns: new[] { "ProductId", "CompensationId" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10096115-e173-4e82-903f-8b4c8f8e2ceb",
                column: "ConcurrencyStamp",
                value: "d1bfef9d-4da5-4514-9711-634e6f445661");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a03991c-5128-4011-85bd-5886dd9f0906",
                column: "ConcurrencyStamp",
                value: "34802e8a-f0a8-419e-b783-6629e91172df");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a52dfb8-8595-487e-bd07-2e876c8291a5",
                column: "ConcurrencyStamp",
                value: "636d6f86-9ff2-4148-893e-474b60c776e4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93296f46-5fd1-4b67-bb8d-9a9008adc8e6",
                column: "ConcurrencyStamp",
                value: "9e924dde-739c-47e5-b46e-ef7d64239fea");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9cd3b078-3254-4c05-b404-e527ec616c89",
                column: "ConcurrencyStamp",
                value: "279c61a2-f304-4175-b214-bb5502b8e7e7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a02a081e-e197-40a3-85a4-3f4cfc853961",
                column: "ConcurrencyStamp",
                value: "5451147e-b876-43ba-a7ff-7e444d365a55");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0b13f5f-1fdc-4937-99ac-91c4a5c8e1bc",
                column: "ConcurrencyStamp",
                value: "a79ed8d8-b9dd-4d4f-8184-2d3b26cd6100");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aebfc368-0c43-4b94-8cce-26c277ec2e33",
                column: "ConcurrencyStamp",
                value: "84f7e5ad-edc1-4461-833d-def99e6246a9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b344f3b4-1df4-449e-8553-9dd7640820a2",
                column: "ConcurrencyStamp",
                value: "c9354fa8-d7e5-4de6-82b4-6fac1792f1fd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b947fb18-600f-4057-b05e-d306abffedb6",
                column: "ConcurrencyStamp",
                value: "ebbdd0f7-ea01-4226-9d10-67484cb0f23d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7fa985ac-095c-469b-b98d-8e09a947d66a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88f4dac3-bbcb-4712-be86-c2eb68945510", "AQAAAAEAACcQAAAAEKcluxdC8P1qsrTEZ4t9ZTlU8bEGeR78jp0nnI6txi4nP3bE9A0NcQihnwIgR1ItkA==", "f70dbbd6-5599-4ae8-ad40-e219f10877b5" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCompensations_Compensation_CompensationId",
                table: "ProductCompensations",
                column: "CompensationId",
                principalTable: "Compensation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCompensations_Products_ProductId",
                table: "ProductCompensations",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCompensations_Compensation_CompensationId",
                table: "ProductCompensations");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCompensations_Products_ProductId",
                table: "ProductCompensations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCompensations",
                table: "ProductCompensations");

            migrationBuilder.DropColumn(
                name: "Group",
                table: "Archives");

            migrationBuilder.RenameTable(
                name: "ProductCompensations",
                newName: "ProductCompensation");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCompensations_CompensationId",
                table: "ProductCompensation",
                newName: "IX_ProductCompensation_CompensationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCompensation",
                table: "ProductCompensation",
                columns: new[] { "ProductId", "CompensationId" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10096115-e173-4e82-903f-8b4c8f8e2ceb",
                column: "ConcurrencyStamp",
                value: "7481f18b-a81c-4b6c-8244-97d11e3c4622");

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
                column: "ConcurrencyStamp",
                value: "d99fddca-2bfd-483f-b87b-d2172322bee9");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCompensation_Compensation_CompensationId",
                table: "ProductCompensation",
                column: "CompensationId",
                principalTable: "Compensation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCompensation_Products_ProductId",
                table: "ProductCompensation",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
