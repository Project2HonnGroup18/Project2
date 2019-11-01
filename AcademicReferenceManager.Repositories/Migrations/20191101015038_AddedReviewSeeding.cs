using Microsoft.EntityFrameworkCore.Migrations;

namespace AcademicReferenceManager.Repositories.Migrations
{
    public partial class AddedReviewSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "FriendId", "PublicationId", "Rating" },
                values: new object[] { 85, 554, 1 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "FriendId", "PublicationId", "Rating" },
                values: new object[] { 44, 994, 2 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "FriendId", "PublicationId", "Rating" },
                values: new object[] { 85, 606, 1 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "FriendId", "PublicationId", "Rating" },
                values: new object[] { 48, 813, 1 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "FriendId", "PublicationId", "Rating" },
                values: new object[] { 10, 684, 3 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "FriendId", "PublicationId", "Rating" },
                values: new object[] { 66, 13, 0 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "FriendId", "PublicationId", "Rating" },
                values: new object[] { 23, 766, 1 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "FriendId", "PublicationId", "Rating" },
                values: new object[] { 90, 725, 2 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "FriendId", "PublicationId", "Rating" },
                values: new object[] { 41, 7, 3 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "FriendId", "PublicationId", "Rating" },
                values: new object[] { 23, 121, 0 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "FriendId", "PublicationId", "Rating" },
                values: new object[] { 92, 56, 3 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "FriendId", "PublicationId", "Rating" },
                values: new object[] { 60, 248, 1 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "FriendId", "PublicationId", "Rating" },
                values: new object[] { 44, 909, 1 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "FriendId", "PublicationId", "Rating" },
                values: new object[] { 56, 754, 4 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "FriendId", "PublicationId", "Rating" },
                values: new object[] { 48, 482, 5 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "FriendId", "PublicationId", "Rating" },
                values: new object[] { 93, 233, 4 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "FriendId", "PublicationId", "Rating" },
                values: new object[] { 82, 118, 3 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "FriendId", "PublicationId", "Rating" },
                values: new object[] { 52, 366, 1 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "FriendId", "PublicationId", "Rating" },
                values: new object[] { 72, 822, 4 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "FriendId", "PublicationId", "Rating" },
                values: new object[] { 90, 966, 2 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "FriendId", "PublicationId", "Rating" },
                values: new object[] { 7, 907, 2 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "FriendId", "PublicationId", "Rating" },
                values: new object[] { 81, 287, 5 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "FriendId", "PublicationId", "Rating" },
                values: new object[] { 82, 520, 1 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "FriendId", "PublicationId", "Rating" },
                values: new object[] { 89, 858, 3 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "FriendId", "PublicationId", "Rating" },
                values: new object[] { 64, 790, 3 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "FriendId", "PublicationId", "Rating" },
                values: new object[] { 93, 923, 5 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "FriendId", "PublicationId", "Rating" },
                values: new object[] { 61, 754, 4 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "FriendId", "PublicationId", "Rating" },
                values: new object[] { 86, 462, 2 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "FriendId", "PublicationId", "Rating" },
                values: new object[] { 76, 312, 3 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "FriendId", "PublicationId", "Rating" },
                values: new object[] { 72, 838, 1 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "FriendId", "PublicationId", "Rating" },
                values: new object[] { 92, 53, 4 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "FriendId", "PublicationId", "Rating" },
                values: new object[] { 23, 756, 1 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "FriendId", "PublicationId", "Rating" },
                values: new object[] { 100, 291, 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "FriendId", "PublicationId" },
                keyValues: new object[] { 7, 907 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "FriendId", "PublicationId" },
                keyValues: new object[] { 10, 684 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "FriendId", "PublicationId" },
                keyValues: new object[] { 23, 121 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "FriendId", "PublicationId" },
                keyValues: new object[] { 23, 756 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "FriendId", "PublicationId" },
                keyValues: new object[] { 23, 766 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "FriendId", "PublicationId" },
                keyValues: new object[] { 41, 7 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "FriendId", "PublicationId" },
                keyValues: new object[] { 44, 909 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "FriendId", "PublicationId" },
                keyValues: new object[] { 44, 994 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "FriendId", "PublicationId" },
                keyValues: new object[] { 48, 482 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "FriendId", "PublicationId" },
                keyValues: new object[] { 48, 813 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "FriendId", "PublicationId" },
                keyValues: new object[] { 52, 366 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "FriendId", "PublicationId" },
                keyValues: new object[] { 56, 754 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "FriendId", "PublicationId" },
                keyValues: new object[] { 60, 248 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "FriendId", "PublicationId" },
                keyValues: new object[] { 61, 754 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "FriendId", "PublicationId" },
                keyValues: new object[] { 64, 790 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "FriendId", "PublicationId" },
                keyValues: new object[] { 66, 13 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "FriendId", "PublicationId" },
                keyValues: new object[] { 72, 822 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "FriendId", "PublicationId" },
                keyValues: new object[] { 72, 838 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "FriendId", "PublicationId" },
                keyValues: new object[] { 76, 312 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "FriendId", "PublicationId" },
                keyValues: new object[] { 81, 287 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "FriendId", "PublicationId" },
                keyValues: new object[] { 82, 118 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "FriendId", "PublicationId" },
                keyValues: new object[] { 82, 520 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "FriendId", "PublicationId" },
                keyValues: new object[] { 85, 554 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "FriendId", "PublicationId" },
                keyValues: new object[] { 85, 606 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "FriendId", "PublicationId" },
                keyValues: new object[] { 86, 462 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "FriendId", "PublicationId" },
                keyValues: new object[] { 89, 858 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "FriendId", "PublicationId" },
                keyValues: new object[] { 90, 725 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "FriendId", "PublicationId" },
                keyValues: new object[] { 90, 966 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "FriendId", "PublicationId" },
                keyValues: new object[] { 92, 53 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "FriendId", "PublicationId" },
                keyValues: new object[] { 92, 56 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "FriendId", "PublicationId" },
                keyValues: new object[] { 93, 233 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "FriendId", "PublicationId" },
                keyValues: new object[] { 93, 923 });

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumns: new[] { "FriendId", "PublicationId" },
                keyValues: new object[] { 100, 291 });
        }
    }
}
