using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.EntityFramework.Migrations.Identity
{
    /// <inheritdoc />
    public partial class Key : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Documents_DocumentId",
                table: "Appointments");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_DocumentId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "DocumentId",
                table: "Appointments");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Appointments",
                newName: "DoctorId");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Appointments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Appointments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "PatientId",
                table: "Appointments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Appointments",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "Time",
                table: "Appointments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "CreateDate", "DoctorId", "Duration", "IsDeleted", "PatientId", "Price", "Status", "Time" },
                values: new object[,]
                {
                    { new Guid("002bfdce-b991-4733-b283-23a12a348558"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(967), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 6000m, 1, new DateTime(2024, 5, 10, 11, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("012a25a3-1424-4a7a-92cd-a8531983e9e4"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1415), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 7000m, 1, new DateTime(2024, 5, 10, 11, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("07ecd09a-e654-432f-9165-ee1293c3cff6"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1725), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 2000m, 1, new DateTime(2024, 5, 10, 9, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("09832087-23e6-40c4-97d9-9d4c8444f819"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1085), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 5000m, 1, new DateTime(2024, 5, 10, 10, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("0ba1f731-b17c-44db-a00d-294c209299bf"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1667), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 3000m, 1, new DateTime(2024, 5, 10, 10, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("0cfa4409-1717-4dc2-9ffd-56feaa28a105"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(712), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 2000m, 1, new DateTime(2024, 5, 10, 9, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("0e3f27f8-9bfc-4894-a2b0-c6fafa95c5e0"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1690), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 1000m, 1, new DateTime(2024, 5, 10, 9, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("0eea2e86-8768-40c1-bfb0-3b796c8d760d"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(947), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 2000m, 1, new DateTime(2024, 5, 10, 9, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("11ac0a13-33ee-46f6-bf1a-25ffeee0c4b3"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1052), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 5000m, 1, new DateTime(2024, 5, 10, 10, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("13d168c4-37fc-412d-b4ee-9a98b8bd577e"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1025), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 6000m, 1, new DateTime(2024, 5, 10, 11, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("1656efa1-e76e-43fc-860c-3631e53857ae"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1616), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 5000m, 1, new DateTime(2024, 5, 10, 10, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("17806de8-9327-4989-a454-a9ce71fcc9bc"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1294), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 7000m, 1, new DateTime(2024, 5, 10, 11, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("1945e90f-2a18-4ed4-9e68-6e247158e04f"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(653), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 6000m, 1, new DateTime(2024, 5, 10, 11, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("1bb8aab6-c895-42cb-b1c7-1f2181ff882b"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1717), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 7000m, 1, new DateTime(2024, 5, 10, 11, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("1c16abf6-6c6b-4a42-80a1-3fd596415b59"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1002), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 7000m, 1, new DateTime(2024, 5, 10, 11, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("1c96331e-587b-4877-b57d-dc9533c8355d"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(638), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 2000m, 1, new DateTime(2024, 5, 10, 9, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("1ec25eb3-4154-4556-aac1-1f4cedc50c07"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1411), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 6000m, 1, new DateTime(2024, 5, 10, 11, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("1f9a84c4-f986-4641-931e-e12b886b05f3"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(594), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 3000m, 1, new DateTime(2024, 5, 10, 10, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("206a4ef2-a9d2-4f3d-80c2-2ceebeeb2ee1"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(983), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 3000m, 1, new DateTime(2024, 5, 10, 10, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("23c36fb4-c591-4573-8244-6157a3568f60"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(661), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 1000m, 1, new DateTime(2024, 5, 10, 9, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("25c36f9a-a98d-4556-871c-3cffe1a3a88a"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1236), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 1000m, 1, new DateTime(2024, 5, 10, 9, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("26459eaf-34bf-4df4-8e74-03c34cfc3094"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(590), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 2000m, 1, new DateTime(2024, 5, 10, 9, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("266a06a5-cc59-4d9d-9464-f1208e2f675c"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1081), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 4000m, 1, new DateTime(2024, 5, 10, 10, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("26ea058a-771a-4d49-8eab-a99bf39ac466"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1205), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 1000m, 1, new DateTime(2024, 5, 10, 9, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("2957720a-008a-406c-ba3f-cf67d5a12f61"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1056), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 6000m, 1, new DateTime(2024, 5, 10, 11, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("2ada5f69-984b-42e2-9273-c231a1f0cd42"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1089), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 6000m, 1, new DateTime(2024, 5, 10, 11, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("2d30f138-a3f3-4170-8ba6-b685e4cee1c8"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1150), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 2000m, 1, new DateTime(2024, 5, 10, 9, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("3049af96-abd6-4add-b44f-20bf9ec362ea"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(786), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 3000m, 1, new DateTime(2024, 5, 10, 10, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("307b0f27-262c-4bc7-bd32-c7b5be560cdd"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1588), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 7000m, 1, new DateTime(2024, 5, 10, 11, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("3089f3de-ef3f-4af0-839c-1ce688d6b790"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1349), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 6000m, 1, new DateTime(2024, 5, 10, 11, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("31a4c11c-4b3c-4fc4-8d9f-43fca5305dc8"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(601), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 5000m, 1, new DateTime(2024, 5, 10, 10, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("31b3c540-8afb-4e8f-9f7c-2e9699685489"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1583), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 6000m, 1, new DateTime(2024, 5, 10, 11, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("31d6e20f-2a9c-40eb-9e37-2354a51d549f"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1710), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 6000m, 1, new DateTime(2024, 5, 10, 11, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("32394f4b-deae-44ce-950b-6569b9983c9b"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1675), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 5000m, 1, new DateTime(2024, 5, 10, 10, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("3264bce8-dd97-4409-a1f7-4167d60cb2b8"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1077), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 3000m, 1, new DateTime(2024, 5, 10, 10, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("334b6375-ddc5-4c46-82bf-005ec5a68c1e"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1311), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 4000m, 1, new DateTime(2024, 5, 10, 10, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("336c9aa1-b5af-4711-943a-b8e3ce62bb3a"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1174), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 1000m, 1, new DateTime(2024, 5, 10, 9, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("3640e2bb-dfb7-4614-a977-5db4b386c5b0"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(842), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 6000m, 1, new DateTime(2024, 5, 10, 11, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("3a7f339f-7f24-4977-baa9-0e7d5fad8fae"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1307), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 3000m, 1, new DateTime(2024, 5, 10, 10, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("3b6b2f0d-7554-4abc-80e1-6262af2f10ab"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(890), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 3000m, 1, new DateTime(2024, 5, 10, 10, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("3d7d2620-f33a-4e93-a1f0-896549a6ce87"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1721), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 1000m, 1, new DateTime(2024, 5, 10, 9, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("4195aa25-0e83-4991-b15a-11b409cc421c"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1430), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 3000m, 1, new DateTime(2024, 5, 10, 10, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("41ef456a-4606-41b9-ae3b-895486961b64"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1271), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 2000m, 1, new DateTime(2024, 5, 10, 9, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("425b11b5-f200-4311-8ff8-745e9203d737"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1041), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 2000m, 1, new DateTime(2024, 5, 10, 9, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("42e89070-0b19-47ea-8d12-5812d879f571"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1399), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 3000m, 1, new DateTime(2024, 5, 10, 10, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("437af0c7-a8d9-4878-96af-d9f4f845e11c"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1407), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 5000m, 1, new DateTime(2024, 5, 10, 10, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("46c3eb5d-74c5-4b70-a13f-b7c5e4b8c15e"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1060), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 7000m, 1, new DateTime(2024, 5, 10, 11, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("47d1bb08-d7ea-47d1-a21b-673942dea97f"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1263), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 7000m, 1, new DateTime(2024, 5, 10, 11, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("484261bd-4d96-4ba5-b19f-bb0f5063973c"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1282), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 5000m, 1, new DateTime(2024, 5, 10, 10, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("48bd9873-c7c9-4fba-b81e-3db475783437"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1624), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 7000m, 1, new DateTime(2024, 5, 10, 11, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("48d3cf34-14e3-41c2-a5c6-030f9bb419dd"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1663), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 2000m, 1, new DateTime(2024, 5, 10, 9, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("4986071e-ce1f-423b-ab99-1cd2b8d71dbf"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(916), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 1000m, 1, new DateTime(2024, 5, 10, 9, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("4ba70605-36c5-4e66-9b83-d304896e74e4"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1659), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 1000m, 1, new DateTime(2024, 5, 10, 9, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("4eb78f0e-44d3-492f-9afe-171d6934ebcc"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1384), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 7000m, 1, new DateTime(2024, 5, 10, 11, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("4fb6d9b7-24ce-4b24-8e56-5d776a45f844"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1737), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 5000m, 1, new DateTime(2024, 5, 10, 10, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("50b70d44-c954-4190-bbd9-ac67fcf2d1ca"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1601), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 2000m, 1, new DateTime(2024, 5, 10, 9, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("515f43e3-fbf7-432c-961d-46430eb7682c"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1193), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 5000m, 1, new DateTime(2024, 5, 10, 10, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("54259ff7-3e1f-423e-b5b2-c90b5e71f3fa"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1341), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 4000m, 1, new DateTime(2024, 5, 10, 10, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("567c5213-b04f-4393-9bb0-acdebd04c80c"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1592), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 1000m, 1, new DateTime(2024, 5, 10, 9, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("568fb97a-5e7e-4a00-b94b-ea1782c953ca"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(963), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 5000m, 1, new DateTime(2024, 5, 10, 10, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("57772e4a-0fa1-417b-ad73-ba31ac529a3d"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1073), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 2000m, 1, new DateTime(2024, 5, 10, 9, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("5a22f932-4e01-4097-af77-d71685cc1c19"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(550), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 1000m, 1, new DateTime(2024, 5, 10, 9, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("5a5af302-d976-4c8c-8804-a952be08d95f"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1232), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 7000m, 1, new DateTime(2024, 5, 10, 11, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("5b58c997-eb6d-4641-8fcc-7d8f865e257b"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1706), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 5000m, 1, new DateTime(2024, 5, 10, 10, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("5b758e5d-12fd-4844-b12f-a09f0939e3ef"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1010), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 2000m, 1, new DateTime(2024, 5, 10, 9, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("5e885122-6a09-4dbc-8478-96b431bdf14f"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(850), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 1000m, 1, new DateTime(2024, 5, 10, 9, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("606dbe59-3dfd-46e9-b9c2-c78f403ec49d"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(649), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 5000m, 1, new DateTime(2024, 5, 10, 10, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("6101b590-5683-48aa-b7e9-fe891db38419"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(823), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 4000m, 1, new DateTime(2024, 5, 10, 10, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("617f5694-0b12-453c-93ab-590ea20530fa"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1368), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 3000m, 1, new DateTime(2024, 5, 10, 10, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("61d9a576-8ddb-4feb-9477-7b9f416c3e45"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1045), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 3000m, 1, new DateTime(2024, 5, 10, 10, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("64537af4-56f3-4c84-b72c-1d13ff8c66b1"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1702), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 4000m, 1, new DateTime(2024, 5, 10, 10, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("65038ee5-aedf-4986-9a16-c4f70c5626eb"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1018), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 4000m, 1, new DateTime(2024, 5, 10, 10, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("66845343-c2f3-45ab-b30c-3a340a58b8de"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(979), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 2000m, 1, new DateTime(2024, 5, 10, 9, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("66aabe0b-79ac-43b7-a558-1d7151a125c4"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1671), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 4000m, 1, new DateTime(2024, 5, 10, 10, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("68dde0ae-9f9b-43b2-bf19-8fbf9784f6bf"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(791), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 4000m, 1, new DateTime(2024, 5, 10, 10, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("6996727d-1268-45d8-8a73-6112294810c2"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(819), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 3000m, 1, new DateTime(2024, 5, 10, 10, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("6a76395b-5a9e-4c0b-84b6-a77b366595ba"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1620), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 6000m, 1, new DateTime(2024, 5, 10, 11, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("6c470503-0a70-4a78-add9-2cf66d2041d1"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1632), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 2000m, 1, new DateTime(2024, 5, 10, 9, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("6c9c74f6-9d83-48ad-96d4-4e28ecf88ea7"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1033), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 7000m, 1, new DateTime(2024, 5, 10, 11, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("6ea4fde0-f768-43e5-a18b-e3b24a277ae1"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1326), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 7000m, 1, new DateTime(2024, 5, 10, 11, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("7131a0f7-452c-4ffb-82ef-f8c152048a34"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(955), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 4000m, 1, new DateTime(2024, 5, 10, 10, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("7240a658-855f-4cb6-8c81-09216a3886b3"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1093), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 7000m, 1, new DateTime(2024, 5, 10, 11, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("72b527a0-5446-410e-aa7a-4620a7a3d880"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(795), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 5000m, 1, new DateTime(2024, 5, 10, 10, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("735f8d5f-d8e7-42d2-9c43-b6482117d4e3"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1612), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 4000m, 1, new DateTime(2024, 5, 10, 10, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("73be4c5a-7680-491d-b54f-21bbf0c927a2"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1154), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 3000m, 1, new DateTime(2024, 5, 10, 10, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("753a28f0-8ab3-4f83-849a-0ce374c26e18"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1275), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 3000m, 1, new DateTime(2024, 5, 10, 10, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("7a38c5c4-97c9-4315-a133-ab06eb5dffe0"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1097), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 1000m, 1, new DateTime(2024, 5, 10, 9, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("7b27e157-22c4-437b-b1e6-ceeff39fcd17"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1228), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 6000m, 1, new DateTime(2024, 5, 10, 11, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("7bd18d94-3a9c-4064-93bf-e1a525848adc"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1314), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 5000m, 1, new DateTime(2024, 5, 10, 10, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("7c9bce15-43bf-422a-a4fd-e1344c70ad61"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1640), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 4000m, 1, new DateTime(2024, 5, 10, 10, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("7ed093a7-3cae-4e04-9969-6740b346a7ac"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1380), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 6000m, 1, new DateTime(2024, 5, 10, 11, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("866be134-fb2d-429c-88cd-4c70cb5df9de"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1189), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 4000m, 1, new DateTime(2024, 5, 10, 10, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("895c5ff4-a4da-47e2-8466-3ef9d7bb74d5"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1006), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 1000m, 1, new DateTime(2024, 5, 10, 9, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("8b065e1b-5196-45ab-9ffb-75a692709f87"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1423), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 2000m, 1, new DateTime(2024, 5, 10, 9, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("8c54d915-50cc-4e6e-a087-e437ae8f35b6"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(803), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 7000m, 1, new DateTime(2024, 5, 10, 11, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("8e62314c-f11d-48c6-8271-204f76ab99c6"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1185), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 3000m, 1, new DateTime(2024, 5, 10, 10, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("8e851ed3-fd33-4037-9359-28357fc402c0"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(645), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 4000m, 1, new DateTime(2024, 5, 10, 10, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("8ed339d2-76a7-4a92-8563-80dc7d522ede"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1178), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 2000m, 1, new DateTime(2024, 5, 10, 9, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("90f5e748-73a3-4ec3-9836-cb00759a83d0"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(971), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 7000m, 1, new DateTime(2024, 5, 10, 11, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("921c4738-a0a5-4e21-a900-84dd7274be62"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1353), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 7000m, 1, new DateTime(2024, 5, 10, 11, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("92df53f8-421c-428e-bf7d-8872716bcb50"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1345), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 5000m, 1, new DateTime(2024, 5, 10, 10, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("945cee9e-bf7c-4d87-9355-9ab24634c365"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(633), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 1000m, 1, new DateTime(2024, 5, 10, 9, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("947455dd-4e38-446b-9772-7848d00ca746"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1334), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 2000m, 1, new DateTime(2024, 5, 10, 9, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("95e78218-5088-49ce-a485-867b2708239f"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1388), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 1000m, 1, new DateTime(2024, 5, 10, 9, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("97a17467-428b-4109-8631-96dfdd484751"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1652), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 6000m, 1, new DateTime(2024, 5, 10, 11, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("98808507-2270-4c47-918d-753ac3e54e7a"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(907), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 6000m, 1, new DateTime(2024, 5, 10, 11, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("9a871425-0746-4492-ad11-a457a0f852fc"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(951), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 3000m, 1, new DateTime(2024, 5, 10, 10, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("9b56ae13-4003-4fc5-870f-665c1ec1a82b"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1628), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 1000m, 1, new DateTime(2024, 5, 10, 9, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("9d24c5f6-6b05-490b-b23b-d1beac4b6c4e"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1197), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 6000m, 1, new DateTime(2024, 5, 10, 11, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("9d2a78bd-ba61-4ea0-a9b2-aff57f6a9374"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(837), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 5000m, 1, new DateTime(2024, 5, 10, 10, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("9e164275-981b-4480-be5e-51fadf695806"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1267), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 1000m, 1, new DateTime(2024, 5, 10, 9, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("9e2782a6-93a4-4d2b-b0f0-f99d381e2fef"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(799), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 6000m, 1, new DateTime(2024, 5, 10, 11, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("9f8e9ebe-c8be-41e9-b8cb-585f21e352f1"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1209), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 2000m, 1, new DateTime(2024, 5, 10, 9, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("a2971480-917c-4515-9f21-c787496451dd"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(911), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 7000m, 1, new DateTime(2024, 5, 10, 11, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("a348a700-bb93-4b99-88a2-d226be894372"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(975), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 1000m, 1, new DateTime(2024, 5, 10, 9, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("a5cfc6e0-679a-4416-a679-22e9f22b0568"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1162), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 5000m, 1, new DateTime(2024, 5, 10, 10, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("a66ae469-965f-442c-8a9a-d660a2aa53ac"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1605), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 3000m, 1, new DateTime(2024, 5, 10, 10, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("aa5ea92c-adf5-4b50-a525-a590cb5a8d93"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(990), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 5000m, 1, new DateTime(2024, 5, 10, 10, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("ac461555-b5a6-48bf-a118-38ea04f85290"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1636), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 3000m, 1, new DateTime(2024, 5, 10, 10, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("acdb0245-bf3b-43e6-b043-07eb0fe23cd1"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1303), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 2000m, 1, new DateTime(2024, 5, 10, 9, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("ae7f7119-4586-4fbc-a188-d39828b10eff"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1240), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 2000m, 1, new DateTime(2024, 5, 10, 9, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("aef18c82-7896-46ca-beef-8b0f22326e31"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1248), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 4000m, 1, new DateTime(2024, 5, 10, 10, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("afdb2e52-3d9b-4634-86b8-00cec7d838dc"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1745), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 7000m, 1, new DateTime(2024, 5, 10, 11, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("b0e54789-b19d-4fe0-86d4-026dc49d8a24"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1224), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 5000m, 1, new DateTime(2024, 5, 10, 10, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("b1971334-b0f2-4e9c-b9b3-32ef71bedd35"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1201), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 7000m, 1, new DateTime(2024, 5, 10, 11, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("b27c1ab8-be8d-43dd-a3aa-87cdce50aa83"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(867), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 2000m, 1, new DateTime(2024, 5, 10, 9, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("b32ff331-9b5a-48fa-9b1c-cc4a11ee3a51"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1299), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 1000m, 1, new DateTime(2024, 5, 10, 9, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("b49c6f87-e12b-474b-8084-8906560b55f6"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(609), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 7000m, 1, new DateTime(2024, 5, 10, 11, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("b667a5c6-e517-44f3-8da9-2860f242e693"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1290), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 6000m, 1, new DateTime(2024, 5, 10, 11, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("b80b5650-f452-4167-bb9f-944d98d6cd1c"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1220), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 4000m, 1, new DateTime(2024, 5, 10, 10, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("b882620b-a0d6-4604-9bef-aecd16327933"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1686), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 7000m, 1, new DateTime(2024, 5, 10, 11, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("b8b3c3d2-c361-4403-9c20-f3d79e2a6a38"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(642), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 3000m, 1, new DateTime(2024, 5, 10, 10, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("b98bfc58-b4e0-4dcc-880e-f1b7d544584e"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(998), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 6000m, 1, new DateTime(2024, 5, 10, 11, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("b9a80304-5dee-4cfe-a534-a4e24eb7393e"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1733), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 4000m, 1, new DateTime(2024, 5, 10, 10, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("bc79a773-db04-4ad0-926a-1de1cdce6447"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(899), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 4000m, 1, new DateTime(2024, 5, 10, 10, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("c139081e-19d0-44e3-b448-ace0f9368efb"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1365), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 2000m, 1, new DateTime(2024, 5, 10, 9, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("c2b1062c-1c50-4053-91e5-9c57370e9481"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1166), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 6000m, 1, new DateTime(2024, 5, 10, 11, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("c4c4140a-9867-43cb-871a-4a428a77f56e"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1419), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 1000m, 1, new DateTime(2024, 5, 10, 9, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("c6c93076-94fe-4c0a-b97c-2b9d5ada02aa"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(987), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 4000m, 1, new DateTime(2024, 5, 10, 10, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("c74d94a1-fc0c-4382-8844-346fcab455be"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1338), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 3000m, 1, new DateTime(2024, 5, 10, 10, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("c967b0a9-a10e-4ac5-bc7f-260485c8c710"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1376), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 5000m, 1, new DateTime(2024, 5, 10, 10, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("ca088300-b4d1-4362-9770-9959b025fd8d"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1213), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 3000m, 1, new DateTime(2024, 5, 10, 10, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("caaa6e60-7dc3-486d-b5ec-f00c4a938480"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1244), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 3000m, 1, new DateTime(2024, 5, 10, 10, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("cb1d1d12-9645-4d78-9745-5b5ac5a436a2"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1403), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 4000m, 1, new DateTime(2024, 5, 10, 10, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("cb8737aa-724d-4a13-9600-7168d451e499"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1069), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 1000m, 1, new DateTime(2024, 5, 10, 9, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("cba14e9b-d88e-4c66-8fb1-1a9c982a755e"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1279), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 4000m, 1, new DateTime(2024, 5, 10, 10, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("cc59c3ed-2b2a-4e7d-bb97-fb32a7231a14"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1318), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 6000m, 1, new DateTime(2024, 5, 10, 11, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("d3f68e33-41bf-4eed-8615-803ce02fca84"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1255), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 5000m, 1, new DateTime(2024, 5, 10, 10, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("d5dd9eb4-889c-4754-a816-54e2f4f5c52f"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1694), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 2000m, 1, new DateTime(2024, 5, 10, 9, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("dae6d9ce-2617-4c4c-b53f-98bcb5d6e0df"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(845), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 7000m, 1, new DateTime(2024, 5, 10, 11, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("dcd8efbe-2971-4423-b6fb-9e34bd44cb93"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1361), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 1000m, 1, new DateTime(2024, 5, 10, 9, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("df1ec32f-ae3b-47f2-b7a2-b44db21c2dfa"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(807), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 1000m, 1, new DateTime(2024, 5, 10, 9, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("e0539621-5a6d-4b90-bebe-6adf670cdea4"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1372), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 4000m, 1, new DateTime(2024, 5, 10, 10, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("e1b41688-ade5-4904-a336-25563f50e8c9"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1170), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 7000m, 1, new DateTime(2024, 5, 10, 11, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("e4eb4e26-b0dc-47ef-9737-77b2da6f2e88"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1729), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 3000m, 1, new DateTime(2024, 5, 10, 10, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("e5a149a4-8014-455c-b8ab-85362896b802"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(597), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 4000m, 1, new DateTime(2024, 5, 10, 10, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("e8113d73-72fb-4f2e-8c01-760a0fbea107"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(811), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 2000m, 1, new DateTime(2024, 5, 10, 9, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("ea9ddf68-52fa-479f-b98d-b480584ac52b"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1330), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 1000m, 1, new DateTime(2024, 5, 10, 9, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("eac1046f-718f-4c9a-bb14-1945de5f98cc"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1396), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 2000m, 1, new DateTime(2024, 5, 10, 9, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("eb947131-cfe6-4c6a-a648-30fb742f962d"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1438), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 5000m, 1, new DateTime(2024, 5, 10, 10, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("ebbf6b57-25b4-4a3b-b14c-814c0b2e8e47"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1014), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 3000m, 1, new DateTime(2024, 5, 10, 10, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("ed5dc394-5bcf-4797-8693-a14e4091f52e"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1037), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 1000m, 1, new DateTime(2024, 5, 10, 9, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("ee602b79-7efb-407e-a112-82207c8165cf"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1682), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 6000m, 1, new DateTime(2024, 5, 10, 11, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("efed0ce6-ebe0-4693-aef1-75a1223f04b3"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1259), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 6000m, 1, new DateTime(2024, 5, 10, 11, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("f0362d9f-89a1-408e-ba91-7364487077f3"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1158), new Guid("eec214ba-7605-4392-9ec4-e788ded53bea"), 20, false, null, 4000m, 1, new DateTime(2024, 5, 10, 10, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("f22320f6-c587-460a-9f81-704cfa219740"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(903), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 5000m, 1, new DateTime(2024, 5, 10, 10, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("f2bff67c-4192-43ed-87c3-48dee29cada8"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1698), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 3000m, 1, new DateTime(2024, 5, 10, 10, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("f4e42e56-0380-4b51-951a-a06da9f0d4c7"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1434), new Guid("a372bf3d-efe9-4f0d-b16b-ac550a3947d2"), 20, false, null, 4000m, 1, new DateTime(2024, 5, 10, 10, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("f5069b59-0703-44cf-96d2-d19951d13ccb"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(657), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 7000m, 1, new DateTime(2024, 5, 10, 11, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("f7c36692-9291-4a8b-8489-9754ceb57a97"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1648), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 5000m, 1, new DateTime(2024, 5, 10, 10, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("f84d78b8-f1c5-4195-8631-f44693ab50c4"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(605), new Guid("61dd8fe5-aed3-44af-a451-823caeb2dc68"), 20, false, null, 6000m, 1, new DateTime(2024, 5, 10, 11, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("f89ad988-e36d-4a44-b4cd-8527137e89cd"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1049), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 4000m, 1, new DateTime(2024, 5, 10, 10, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("f97f2822-7cd1-4dd8-9f59-882e96cd40fd"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1655), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 7000m, 1, new DateTime(2024, 5, 10, 11, 20, 0, 0, DateTimeKind.Local) },
                    { new Guid("fa78b8b0-d437-4650-932a-dd254c4a6590"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1021), new Guid("c302105d-1c7e-4db4-9380-d91146596f05"), 20, false, null, 5000m, 1, new DateTime(2024, 5, 10, 10, 40, 0, 0, DateTimeKind.Local) },
                    { new Guid("fdfe835d-1135-4881-9bea-33abc291dffe"), new DateTime(2024, 5, 10, 9, 50, 11, 83, DateTimeKind.Local).AddTicks(1741), new Guid("c5508ee0-fbe6-47fa-b7d3-d6438b93b43d"), 20, false, null, 6000m, 1, new DateTime(2024, 5, 10, 11, 0, 0, 0, DateTimeKind.Local) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("002bfdce-b991-4733-b283-23a12a348558"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("012a25a3-1424-4a7a-92cd-a8531983e9e4"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("07ecd09a-e654-432f-9165-ee1293c3cff6"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("09832087-23e6-40c4-97d9-9d4c8444f819"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("0ba1f731-b17c-44db-a00d-294c209299bf"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("0cfa4409-1717-4dc2-9ffd-56feaa28a105"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("0e3f27f8-9bfc-4894-a2b0-c6fafa95c5e0"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("0eea2e86-8768-40c1-bfb0-3b796c8d760d"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("11ac0a13-33ee-46f6-bf1a-25ffeee0c4b3"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("13d168c4-37fc-412d-b4ee-9a98b8bd577e"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("1656efa1-e76e-43fc-860c-3631e53857ae"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("17806de8-9327-4989-a454-a9ce71fcc9bc"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("1945e90f-2a18-4ed4-9e68-6e247158e04f"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("1bb8aab6-c895-42cb-b1c7-1f2181ff882b"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("1c16abf6-6c6b-4a42-80a1-3fd596415b59"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("1c96331e-587b-4877-b57d-dc9533c8355d"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("1ec25eb3-4154-4556-aac1-1f4cedc50c07"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("1f9a84c4-f986-4641-931e-e12b886b05f3"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("206a4ef2-a9d2-4f3d-80c2-2ceebeeb2ee1"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("23c36fb4-c591-4573-8244-6157a3568f60"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("25c36f9a-a98d-4556-871c-3cffe1a3a88a"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("26459eaf-34bf-4df4-8e74-03c34cfc3094"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("266a06a5-cc59-4d9d-9464-f1208e2f675c"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("26ea058a-771a-4d49-8eab-a99bf39ac466"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("2957720a-008a-406c-ba3f-cf67d5a12f61"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("2ada5f69-984b-42e2-9273-c231a1f0cd42"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("2d30f138-a3f3-4170-8ba6-b685e4cee1c8"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("3049af96-abd6-4add-b44f-20bf9ec362ea"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("307b0f27-262c-4bc7-bd32-c7b5be560cdd"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("3089f3de-ef3f-4af0-839c-1ce688d6b790"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("31a4c11c-4b3c-4fc4-8d9f-43fca5305dc8"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("31b3c540-8afb-4e8f-9f7c-2e9699685489"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("31d6e20f-2a9c-40eb-9e37-2354a51d549f"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("32394f4b-deae-44ce-950b-6569b9983c9b"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("3264bce8-dd97-4409-a1f7-4167d60cb2b8"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("334b6375-ddc5-4c46-82bf-005ec5a68c1e"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("336c9aa1-b5af-4711-943a-b8e3ce62bb3a"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("3640e2bb-dfb7-4614-a977-5db4b386c5b0"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("3a7f339f-7f24-4977-baa9-0e7d5fad8fae"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("3b6b2f0d-7554-4abc-80e1-6262af2f10ab"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("3d7d2620-f33a-4e93-a1f0-896549a6ce87"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("4195aa25-0e83-4991-b15a-11b409cc421c"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("41ef456a-4606-41b9-ae3b-895486961b64"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("425b11b5-f200-4311-8ff8-745e9203d737"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("42e89070-0b19-47ea-8d12-5812d879f571"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("437af0c7-a8d9-4878-96af-d9f4f845e11c"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("46c3eb5d-74c5-4b70-a13f-b7c5e4b8c15e"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("47d1bb08-d7ea-47d1-a21b-673942dea97f"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("484261bd-4d96-4ba5-b19f-bb0f5063973c"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("48bd9873-c7c9-4fba-b81e-3db475783437"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("48d3cf34-14e3-41c2-a5c6-030f9bb419dd"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("4986071e-ce1f-423b-ab99-1cd2b8d71dbf"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("4ba70605-36c5-4e66-9b83-d304896e74e4"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("4eb78f0e-44d3-492f-9afe-171d6934ebcc"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("4fb6d9b7-24ce-4b24-8e56-5d776a45f844"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("50b70d44-c954-4190-bbd9-ac67fcf2d1ca"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("515f43e3-fbf7-432c-961d-46430eb7682c"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("54259ff7-3e1f-423e-b5b2-c90b5e71f3fa"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("567c5213-b04f-4393-9bb0-acdebd04c80c"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("568fb97a-5e7e-4a00-b94b-ea1782c953ca"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("57772e4a-0fa1-417b-ad73-ba31ac529a3d"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("5a22f932-4e01-4097-af77-d71685cc1c19"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("5a5af302-d976-4c8c-8804-a952be08d95f"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("5b58c997-eb6d-4641-8fcc-7d8f865e257b"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("5b758e5d-12fd-4844-b12f-a09f0939e3ef"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("5e885122-6a09-4dbc-8478-96b431bdf14f"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("606dbe59-3dfd-46e9-b9c2-c78f403ec49d"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("6101b590-5683-48aa-b7e9-fe891db38419"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("617f5694-0b12-453c-93ab-590ea20530fa"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("61d9a576-8ddb-4feb-9477-7b9f416c3e45"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("64537af4-56f3-4c84-b72c-1d13ff8c66b1"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("65038ee5-aedf-4986-9a16-c4f70c5626eb"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("66845343-c2f3-45ab-b30c-3a340a58b8de"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("66aabe0b-79ac-43b7-a558-1d7151a125c4"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("68dde0ae-9f9b-43b2-bf19-8fbf9784f6bf"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("6996727d-1268-45d8-8a73-6112294810c2"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("6a76395b-5a9e-4c0b-84b6-a77b366595ba"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("6c470503-0a70-4a78-add9-2cf66d2041d1"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("6c9c74f6-9d83-48ad-96d4-4e28ecf88ea7"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("6ea4fde0-f768-43e5-a18b-e3b24a277ae1"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("7131a0f7-452c-4ffb-82ef-f8c152048a34"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("7240a658-855f-4cb6-8c81-09216a3886b3"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("72b527a0-5446-410e-aa7a-4620a7a3d880"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("735f8d5f-d8e7-42d2-9c43-b6482117d4e3"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("73be4c5a-7680-491d-b54f-21bbf0c927a2"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("753a28f0-8ab3-4f83-849a-0ce374c26e18"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("7a38c5c4-97c9-4315-a133-ab06eb5dffe0"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("7b27e157-22c4-437b-b1e6-ceeff39fcd17"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("7bd18d94-3a9c-4064-93bf-e1a525848adc"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("7c9bce15-43bf-422a-a4fd-e1344c70ad61"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("7ed093a7-3cae-4e04-9969-6740b346a7ac"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("866be134-fb2d-429c-88cd-4c70cb5df9de"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("895c5ff4-a4da-47e2-8466-3ef9d7bb74d5"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("8b065e1b-5196-45ab-9ffb-75a692709f87"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("8c54d915-50cc-4e6e-a087-e437ae8f35b6"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("8e62314c-f11d-48c6-8271-204f76ab99c6"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("8e851ed3-fd33-4037-9359-28357fc402c0"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("8ed339d2-76a7-4a92-8563-80dc7d522ede"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("90f5e748-73a3-4ec3-9836-cb00759a83d0"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("921c4738-a0a5-4e21-a900-84dd7274be62"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("92df53f8-421c-428e-bf7d-8872716bcb50"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("945cee9e-bf7c-4d87-9355-9ab24634c365"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("947455dd-4e38-446b-9772-7848d00ca746"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("95e78218-5088-49ce-a485-867b2708239f"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("97a17467-428b-4109-8631-96dfdd484751"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("98808507-2270-4c47-918d-753ac3e54e7a"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("9a871425-0746-4492-ad11-a457a0f852fc"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("9b56ae13-4003-4fc5-870f-665c1ec1a82b"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("9d24c5f6-6b05-490b-b23b-d1beac4b6c4e"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("9d2a78bd-ba61-4ea0-a9b2-aff57f6a9374"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("9e164275-981b-4480-be5e-51fadf695806"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("9e2782a6-93a4-4d2b-b0f0-f99d381e2fef"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("9f8e9ebe-c8be-41e9-b8cb-585f21e352f1"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("a2971480-917c-4515-9f21-c787496451dd"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("a348a700-bb93-4b99-88a2-d226be894372"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("a5cfc6e0-679a-4416-a679-22e9f22b0568"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("a66ae469-965f-442c-8a9a-d660a2aa53ac"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("aa5ea92c-adf5-4b50-a525-a590cb5a8d93"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("ac461555-b5a6-48bf-a118-38ea04f85290"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("acdb0245-bf3b-43e6-b043-07eb0fe23cd1"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("ae7f7119-4586-4fbc-a188-d39828b10eff"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("aef18c82-7896-46ca-beef-8b0f22326e31"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("afdb2e52-3d9b-4634-86b8-00cec7d838dc"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("b0e54789-b19d-4fe0-86d4-026dc49d8a24"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("b1971334-b0f2-4e9c-b9b3-32ef71bedd35"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("b27c1ab8-be8d-43dd-a3aa-87cdce50aa83"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("b32ff331-9b5a-48fa-9b1c-cc4a11ee3a51"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("b49c6f87-e12b-474b-8084-8906560b55f6"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("b667a5c6-e517-44f3-8da9-2860f242e693"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("b80b5650-f452-4167-bb9f-944d98d6cd1c"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("b882620b-a0d6-4604-9bef-aecd16327933"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("b8b3c3d2-c361-4403-9c20-f3d79e2a6a38"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("b98bfc58-b4e0-4dcc-880e-f1b7d544584e"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("b9a80304-5dee-4cfe-a534-a4e24eb7393e"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("bc79a773-db04-4ad0-926a-1de1cdce6447"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("c139081e-19d0-44e3-b448-ace0f9368efb"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("c2b1062c-1c50-4053-91e5-9c57370e9481"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("c4c4140a-9867-43cb-871a-4a428a77f56e"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("c6c93076-94fe-4c0a-b97c-2b9d5ada02aa"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("c74d94a1-fc0c-4382-8844-346fcab455be"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("c967b0a9-a10e-4ac5-bc7f-260485c8c710"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("ca088300-b4d1-4362-9770-9959b025fd8d"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("caaa6e60-7dc3-486d-b5ec-f00c4a938480"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("cb1d1d12-9645-4d78-9745-5b5ac5a436a2"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("cb8737aa-724d-4a13-9600-7168d451e499"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("cba14e9b-d88e-4c66-8fb1-1a9c982a755e"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("cc59c3ed-2b2a-4e7d-bb97-fb32a7231a14"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("d3f68e33-41bf-4eed-8615-803ce02fca84"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("d5dd9eb4-889c-4754-a816-54e2f4f5c52f"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("dae6d9ce-2617-4c4c-b53f-98bcb5d6e0df"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("dcd8efbe-2971-4423-b6fb-9e34bd44cb93"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("df1ec32f-ae3b-47f2-b7a2-b44db21c2dfa"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("e0539621-5a6d-4b90-bebe-6adf670cdea4"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("e1b41688-ade5-4904-a336-25563f50e8c9"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("e4eb4e26-b0dc-47ef-9737-77b2da6f2e88"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("e5a149a4-8014-455c-b8ab-85362896b802"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("e8113d73-72fb-4f2e-8c01-760a0fbea107"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("ea9ddf68-52fa-479f-b98d-b480584ac52b"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("eac1046f-718f-4c9a-bb14-1945de5f98cc"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("eb947131-cfe6-4c6a-a648-30fb742f962d"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("ebbf6b57-25b4-4a3b-b14c-814c0b2e8e47"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("ed5dc394-5bcf-4797-8693-a14e4091f52e"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("ee602b79-7efb-407e-a112-82207c8165cf"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("efed0ce6-ebe0-4693-aef1-75a1223f04b3"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("f0362d9f-89a1-408e-ba91-7364487077f3"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("f22320f6-c587-460a-9f81-704cfa219740"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("f2bff67c-4192-43ed-87c3-48dee29cada8"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("f4e42e56-0380-4b51-951a-a06da9f0d4c7"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("f5069b59-0703-44cf-96d2-d19951d13ccb"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("f7c36692-9291-4a8b-8489-9754ceb57a97"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("f84d78b8-f1c5-4195-8631-f44693ab50c4"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("f89ad988-e36d-4a44-b4cd-8527137e89cd"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("f97f2822-7cd1-4dd8-9f59-882e96cd40fd"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("fa78b8b0-d437-4650-932a-dd254c4a6590"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("fdfe835d-1135-4881-9bea-33abc291dffe"));

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "Appointments");

            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "Appointments",
                newName: "UserId");

            migrationBuilder.AddColumn<Guid>(
                name: "DocumentId",
                table: "Appointments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppointmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Default = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobilePhone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppointmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentType = table.Column<int>(type: "int", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IssuedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Series = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DocumentId",
                table: "Appointments",
                column: "DocumentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_AppointmentId",
                table: "Contacts",
                column: "AppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Documents_DocumentId",
                table: "Appointments",
                column: "DocumentId",
                principalTable: "Documents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
