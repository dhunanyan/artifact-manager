using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtifactManager.Migrations
{
    public partial class InitalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attributes",
                columns: table => new
                {
                    AttributeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Type = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attributes", x => x.AttributeID);
                    table.UniqueConstraint("AK_Attributes_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Priveleges",
                columns: table => new
                {
                    PrivelegeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Type = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priveleges", x => x.PrivelegeID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Username = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                    table.UniqueConstraint("AK_Users_Username", x => x.Username);
                });

            migrationBuilder.CreateTable(
                name: "Entities",
                columns: table => new
                {
                    EntityID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Rank = table.Column<int>(nullable: true),
                    Power = table.Column<int>(nullable: true),
                    Size = table.Column<int>(nullable: true),
                    CategoryID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities", x => x.EntityID);
                    table.UniqueConstraint("AK_Entities_Name", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Entities_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurrentRolePrivileges",
                columns: table => new
                {
                    CurrentRolePrivilegeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrivilegeOwner = table.Column<string>(nullable: false),
                    PrivelegeID = table.Column<int>(nullable: true),
                    RoleID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentRolePrivileges", x => x.CurrentRolePrivilegeID);
                    table.ForeignKey(
                        name: "FK_CurrentRolePrivileges_Priveleges_PrivelegeID",
                        column: x => x.PrivelegeID,
                        principalTable: "Priveleges",
                        principalColumn: "PrivelegeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CurrentRolePrivileges_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CurrentUserCategories",
                columns: table => new
                {
                    CurrentUserCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryOwner = table.Column<string>(nullable: false),
                    UserID = table.Column<int>(nullable: true),
                    CategoryID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentUserCategories", x => x.CurrentUserCategoryID);
                    table.ForeignKey(
                        name: "FK_CurrentUserCategories_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentUserCategories_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurrentUserRoles",
                columns: table => new
                {
                    CurrentUserRoleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleOwner = table.Column<string>(nullable: false),
                    UserID = table.Column<int>(nullable: true),
                    RoleID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentUserRoles", x => x.CurrentUserRoleID);
                    table.ForeignKey(
                        name: "FK_CurrentUserRoles_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentUserRoles_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurrentEntityAttribute",
                columns: table => new
                {
                    CurrentEntityAttributeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttributeOwner = table.Column<string>(nullable: false),
                    EntityID = table.Column<int>(nullable: true),
                    AttributeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentEntityAttribute", x => x.CurrentEntityAttributeID);
                    table.ForeignKey(
                        name: "FK_CurrentEntityAttribute_Attributes_AttributeID",
                        column: x => x.AttributeID,
                        principalTable: "Attributes",
                        principalColumn: "AttributeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CurrentEntityAttribute_Entities_EntityID",
                        column: x => x.EntityID,
                        principalTable: "Entities",
                        principalColumn: "EntityID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "Name" },
                values: new object[,]
                {
                    { 1, "Guest" },
                    { 2, "User" },
                    { 3, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "FirstName", "LastName", "Password", "Username" },
                values: new object[] { 1, "Admin", "Admin", "Admin-10", "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_CurrentEntityAttribute_AttributeID",
                table: "CurrentEntityAttribute",
                column: "AttributeID");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentEntityAttribute_EntityID",
                table: "CurrentEntityAttribute",
                column: "EntityID");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentRolePrivileges_PrivelegeID",
                table: "CurrentRolePrivileges",
                column: "PrivelegeID");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentRolePrivileges_RoleID",
                table: "CurrentRolePrivileges",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentUserCategories_CategoryID",
                table: "CurrentUserCategories",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentUserCategories_UserID",
                table: "CurrentUserCategories",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentUserRoles_RoleID",
                table: "CurrentUserRoles",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentUserRoles_UserID",
                table: "CurrentUserRoles",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Entities_CategoryID",
                table: "Entities",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurrentEntityAttribute");

            migrationBuilder.DropTable(
                name: "CurrentRolePrivileges");

            migrationBuilder.DropTable(
                name: "CurrentUserCategories");

            migrationBuilder.DropTable(
                name: "CurrentUserRoles");

            migrationBuilder.DropTable(
                name: "Attributes");

            migrationBuilder.DropTable(
                name: "Entities");

            migrationBuilder.DropTable(
                name: "Priveleges");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
