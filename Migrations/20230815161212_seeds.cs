using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace inter.Migrations
{
    /// <inheritdoc />
    public partial class seeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Agents",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 1, "VVV", "HHH" });

            migrationBuilder.InsertData(
                table: "Scouts",
                columns: new[] { "ScoutID", "Age", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 44, "Randum", "Name" },
                    { 2, 33, "Scout", "Name" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamID", "Name", "lastUpdatedDate" },
                values: new object[,]
                {
                    { 1, "Barcelona", new DateTime(2023, 8, 15, 19, 12, 12, 396, DateTimeKind.Local).AddTicks(4852) },
                    { 2, "Real Madrid", new DateTime(2023, 8, 15, 19, 12, 12, 396, DateTimeKind.Local).AddTicks(4886) },
                    { 3, "Atletico Madrid", new DateTime(2023, 8, 15, 19, 12, 12, 396, DateTimeKind.Local).AddTicks(4889) },
                    { 4, "Valencia", new DateTime(2023, 8, 15, 19, 12, 12, 396, DateTimeKind.Local).AddTicks(4891) }
                });

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "TeamID", "Type" },
                values: new object[,]
                {
                    { 1, 50, "Pep", "Guardiola", 1, 0 },
                    { 2, 54, "Carlo", "Ancelotti", 3, 0 },
                    { 3, 46, "Diego", "Simeone", 4, 0 }
                });

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "OwnerID", "Age", "FirstName", "LastName", "TeamID" },
                values: new object[,]
                {
                    { 1, 40, "WW", "QQ", 1 },
                    { 2, 42, "EE", "TT", 3 },
                    { 3, 47, "UU", "OO", 4 }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "ID", "DateOfBirth", "FirstName", "LastName", "ScoutID", "TeamID" },
                values: new object[,]
                {
                    { 4, new DateTime(2023, 8, 15, 19, 12, 12, 396, DateTimeKind.Local).AddTicks(5034), "Luca", "Modric", 2, 3 },
                    { 5, new DateTime(2023, 8, 15, 19, 12, 12, 396, DateTimeKind.Local).AddTicks(5038), "Toni", "Kroos", 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "ScoutsTeams",
                columns: new[] { "ScoutsID", "TeamsID", "StartDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 8, 15, 19, 12, 12, 396, DateTimeKind.Local).AddTicks(5071) },
                    { 1, 3, new DateTime(2023, 8, 15, 19, 12, 12, 396, DateTimeKind.Local).AddTicks(5073) },
                    { 2, 1, new DateTime(2023, 8, 15, 19, 12, 12, 396, DateTimeKind.Local).AddTicks(5075) },
                    { 2, 3, new DateTime(2023, 8, 15, 19, 12, 12, 396, DateTimeKind.Local).AddTicks(5077) },
                    { 2, 4, new DateTime(2023, 8, 15, 19, 12, 12, 396, DateTimeKind.Local).AddTicks(5079) }
                });

            migrationBuilder.InsertData(
                table: "AgentsPlayers",
                columns: new[] { "AgentsId", "PlayersID" },
                values: new object[,]
                {
                    { 1, 4 },
                    { 1, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AgentsPlayers",
                keyColumns: new[] { "AgentsId", "PlayersID" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "AgentsPlayers",
                keyColumns: new[] { "AgentsId", "PlayersID" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "OwnerID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "OwnerID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "OwnerID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ScoutsTeams",
                keyColumns: new[] { "ScoutsID", "TeamsID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ScoutsTeams",
                keyColumns: new[] { "ScoutsID", "TeamsID" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ScoutsTeams",
                keyColumns: new[] { "ScoutsID", "TeamsID" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ScoutsTeams",
                keyColumns: new[] { "ScoutsID", "TeamsID" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "ScoutsTeams",
                keyColumns: new[] { "ScoutsID", "TeamsID" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Scouts",
                keyColumn: "ScoutID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Scouts",
                keyColumn: "ScoutID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamID",
                keyValue: 3);
        }
    }
}
