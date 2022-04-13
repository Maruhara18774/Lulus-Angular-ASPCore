using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lulus.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserIDCreated = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserIDUpdated = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserIDCreated = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserIDUpdated = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Designers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserIDCreated = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserIDUpdated = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Occations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserIDCreated = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserIDUpdated = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserIDCreated = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserIDUpdated = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentID = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserIDCreated = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserIDUpdated = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Textures",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserIDCreated = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserIDUpdated = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Textures", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryID = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserIDCreated = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserIDUpdated = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Countries",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false, defaultValue: 0.0),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    DesignerID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    LengthState = table.Column<int>(type: "int", nullable: true),
                    SleeveLengthState = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserIDCreated = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserIDUpdated = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Designers_DesignerID",
                        column: x => x.DesignerID,
                        principalTable: "Designers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteDesigners",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DesignerID = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserIDCreated = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserIDUpdated = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteDesigners", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FavoriteDesigners_Designers_DesignerID",
                        column: x => x.DesignerID,
                        principalTable: "Designers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteDesigners_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteSubcategories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubcategoryID = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserIDCreated = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserIDUpdated = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteSubcategories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FavoriteSubcategories_SubCategories_SubcategoryID",
                        column: x => x.SubcategoryID,
                        principalTable: "SubCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteSubcategories_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Total = table.Column<double>(type: "float", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserIDCreated = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserIDUpdated = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityID = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserIDCreated = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserIDUpdated = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Provinces_Cities_CityID",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteProducts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserIDCreated = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserIDUpdated = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteProducts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FavoriteProducts_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteProducts_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StarCount = table.Column<int>(type: "int", nullable: false),
                    IsAnonymous = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserIDCreated = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserIDUpdated = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product_Occations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OccationID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_Occations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Product_Occations_Occations_OccationID",
                        column: x => x.OccationID,
                        principalTable: "Occations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Occations_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product_SubCategories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    SubcategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_SubCategories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Product_SubCategories_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_SubCategories_SubCategories_SubcategoryID",
                        column: x => x.SubcategoryID,
                        principalTable: "SubCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductLines",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TextureID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    TextureID1 = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserIDCreated = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserIDUpdated = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductLines", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductLines_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductLines_Textures_TextureID",
                        column: x => x.TextureID,
                        principalTable: "Textures",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductLines_Textures_TextureID1",
                        column: x => x.TextureID1,
                        principalTable: "Textures",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    SalePrice = table.Column<double>(type: "float", nullable: false),
                    StartAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RemainQuantity = table.Column<int>(type: "int", nullable: false),
                    Limit = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserIDCreated = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserIDUpdated = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sales_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProvinceID = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserIDCreated = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserIDUpdated = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Addresses_Provinces_ProvinceID",
                        column: x => x.ProvinceID,
                        principalTable: "Provinces",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addresses_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LineQuantities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductLineID = table.Column<int>(type: "int", nullable: false),
                    SizeID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineQuantities", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LineQuantities_ProductLines_ProductLineID",
                        column: x => x.ProductLineID,
                        principalTable: "ProductLines",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LineQuantities_Sizes_SizeID",
                        column: x => x.SizeID,
                        principalTable: "Sizes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    Total = table.Column<double>(type: "float", nullable: false, defaultValue: 0.0),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ProductLineID = table.Column<int>(type: "int", nullable: false),
                    IsFeedback = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserIDCreated = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserIDUpdated = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_ProductLines_ProductLineID",
                        column: x => x.ProductLineID,
                        principalTable: "ProductLines",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductLineID = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserIDCreated = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserIDUpdated = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductImages_ProductLines_ProductLineID",
                        column: x => x.ProductLineID,
                        principalTable: "ProductLines",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"), "1473edd2-3e81-4ce4-8d57-dedb420e1a5c", "Customer", "CUSTOMER" },
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "eb06097a-e4bc-4fb1-9b38-159c012fc999", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Active", "Created", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 15, true, new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(7231), "Tops", new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(7232), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, true, new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(7229), "Swimsuits & Cover-Ups", new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(7230), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, true, new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(7226), "Sweaters & Knits", new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(7227), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, true, new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(7224), "Skirts", new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(7225), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, true, new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(7221), "Shorts", new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(7222), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(7219), "Rompers", new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(7220), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 4, 13, 17, 31, 15, 258, DateTimeKind.Local).AddTicks(7648), "Activewear", new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(6428), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(7213), "Loungewear", new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(7215), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(7211), "Lingerie & Sleepwear", new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(7212), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(7209), "Leather", new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(7210), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(7206), "Jumpsuits", new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(7207), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(7204), "Jackets & Coats", new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(7205), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(7201), "Dresses", new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(7202), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(7194), "Denim", new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(7199), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(7216), "Pants", new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(7217), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "Active", "Created", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(9244), "Vietnam", new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(9250), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(9520), "China", new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(9523), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(9525), "America", new DateTime(2022, 4, 13, 17, 31, 15, 259, DateTimeKind.Local).AddTicks(9526), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Designers",
                columns: new[] { "ID", "Active", "Created", "Description", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 9, true, new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(2527), null, "ASTR the Label", new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(2528), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(2524), null, "retrofete", new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(2525), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(2522), null, "SOLACE London", new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(2523), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(2514), null, "Michael Costello", new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(2515), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(2517), null, "AFRM", new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(2518), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(2512), null, "krisa", new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(2513), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(2488), null, "Sabina Musayev", new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(2491), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(2212), null, "ELLIATT", new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(2217), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(2519), null, "Amanda Uprichard", new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(2520), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Occations",
                columns: new[] { "ID", "Active", "Created", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(4312), "To A Special Event", new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(4318), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(4580), "On Vacation", new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(4583), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(4585), "For A Night Out", new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(4586), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(4588), "On The Weekend", new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(4589), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "ID", "Active", "Created", "Key", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 6, true, new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(7101), "XL", new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(7102), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(7099), "L", new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(7100), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(7104), "XXL", new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(7105), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(7094), "S", new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(7095), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(7088), "XS", new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(7092), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(7097), "M", new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(7098), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(6758), "XXS", new DateTime(2022, 4, 13, 17, 31, 15, 260, DateTimeKind.Local).AddTicks(6763), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "ID", "Active", "Created", "Name", "ParentID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 9, true, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(2894), "Sundresses", null, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(2895), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(2891), "Gingham", null, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(2892), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "ID", "Active", "Created", "Name", "ParentID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 7, true, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(2889), "Floral", null, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(2890), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(2882), "Bodycon", null, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(2883), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(2884), "Denim", null, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(2885), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(2879), "Bohemian", null, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(2880), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(2874), "One Shoulder", null, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(2877), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(2614), "Cocktail", null, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(2619), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(2886), "Wrap", null, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(2887), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Textures",
                columns: new[] { "ID", "Active", "Created", "Image", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 22, true, new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(4005), "Images/Texture/taffy-pink.webp", "Taffy Pink", new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(4006), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 21, true, new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(4002), "Images/Texture/moonglow-white.webp", "Moonglow White", new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(4003), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 20, true, new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3999), "Images/Texture/pink-orchid.webp", "Pink Orchid", new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(4000), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 19, true, new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3997), "Images/Texture/olive.webp", "Olive", new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3998), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 18, true, new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3994), "Images/Texture/white.png", "White", new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3995), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 17, true, new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3991), "Images/Texture/green.webp", "Green", new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3992), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 16, true, new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3988), "Images/Texture/pink.webp", "Pink", new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3989), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 15, true, new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3985), "Images/Texture/cream.webp", "Cream", new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3986), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, true, new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3982), "Images/Texture/black-sequin.webp", "Black Sequin", new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3983), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, true, new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3979), "Images/Texture/white-sequin.webp", "White Sequin", new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3980), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, true, new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3965), "Images/Texture/abstract-neon-dot.webp", "Abstract Neon Dot", new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3966), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3962), "Images/Texture/baby-blue.webp", "Baby Blue", new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3963), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3956), "Images/Texture/candy.webp", "Candy", new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3957), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3953), "Images/Texture/rosa.webp", "Rosa", new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3954), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3950), "Images/Texture/black.webp", "Black", new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3951), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3947), "Images/Texture/multicolor-blue.webp", "Multicolor Blue", new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3948), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3945), "Images/Texture/blush.webp", "Blush", new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3946), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3942), "Images/Texture/blue.webp", "Blue", new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3943), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3935), "Images/Texture/marigold.webp", "Marigold", new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3939), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3431), "Images/Texture/lilac.webp", "Lilac", new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3436), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, true, new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3967), "Images/Texture/multi-watercolor.webp", "Multi Watercolor", new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3969), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3959), "Images/Texture/taupe.webp", "Taupe", new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(3960), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), 0, "73ecd70b-f9b2-47e2-8fe3-e0b3ebd25d96", "user@shop.com", false, false, null, "USER@SHOP.COM", "USER", "AQAAAAEAACcQAAAAEAZI90XuKmi62rBHKa3nYmvzNOCBCq7+sDv5JdCZ4ji8gJkIWxcuHXMzaqIi0E5ByQ==", "0125454545", false, null, false, "user" },
                    { new Guid("50892ac9-ebe0-4c8d-f28e-08d9638e12dc"), 0, "dd9f6b8d-bd8d-4e8e-a84b-295f33fc8575", "user-bak@shop.com", false, false, null, "USER-BAK@SHOP.COM", "USER-BAK", "AQAAAAEAACcQAAAAEPRvwReL4vyauO4ik1fT6+qaH2PuE3WpzwdIG0efPOTBPDG8juwI+AW8HIqtxfda4A==", "0125454546", false, null, false, "user-bak" },
                    { new Guid("170ca4bc-ef9f-4de7-ae96-08d962dad25f"), 0, "dbaeb93a-ac01-4b98-a50a-620a99515a62", "admin@shop.com", false, false, null, "ADMIN@SHOP.COM", "ADMIN", "AQAAAAEAACcQAAAAEIQ7/TySkkP70wNGJZWgJpVPmXM4GTjJQ9iH/r+TtscQ5LXl53mSvn0OHJ/qCusTIA==", "0323265665", false, null, false, "admin" },
                    { new Guid("0dd37c3c-4694-429e-623b-08d962dbded7"), 0, "4c3d440b-0ce0-4bef-814a-6a30e6b3b590", "admin-bak@shop.com", false, false, null, "ADMIN-BAK@SHOP.COM", "ADMIN-BAK", "AQAAAAEAACcQAAAAEHigTIgoUfZFtPy1Q+TnI/xA9MBhi138sbuhsPfh5vhk6bq/HbxqActn5iiFYc4S+g==", "0323265666", false, null, false, "admin-bak" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"), new Guid("50892ac9-ebe0-4c8d-f28e-08d9638e12dc") },
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("0dd37c3c-4694-429e-623b-08d962dbded7") },
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("170ca4bc-ef9f-4de7-ae96-08d962dad25f") },
                    { new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8") }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "ID", "Active", "CountryID", "Created", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 11, true, 3, new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(7785), "Los Angeles", new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(7786), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, 3, new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(7783), "New York", new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(7784), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, 2, new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(7780), "Shanghai", new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(7781), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, 1, new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(7258), "Can Tho", new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(7263), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, 2, new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(7775), "Ma Cau", new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(7776), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, 2, new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(7773), "Hong Kong", new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(7774), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, 1, new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(7770), "Ho Chi Minh", new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(7771), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, 1, new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(7759), "Da Nang", new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(7763), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, 1, new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(7765), "Hai Phong", new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(7766), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, 1, new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(7768), "Hanoi", new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(7769), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, 2, new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(7778), "Beijing", new DateTime(2022, 4, 13, 17, 31, 15, 261, DateTimeKind.Local).AddTicks(7779), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "FavoriteDesigners",
                columns: new[] { "ID", "Active", "Created", "DesignerID", "Updated", "UserID", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 5, true, new DateTime(2022, 4, 13, 17, 31, 15, 262, DateTimeKind.Local).AddTicks(1141), 9, new DateTime(2022, 4, 13, 17, 31, 15, 262, DateTimeKind.Local).AddTicks(1142), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 4, 13, 17, 31, 15, 262, DateTimeKind.Local).AddTicks(1136), 7, new DateTime(2022, 4, 13, 17, 31, 15, 262, DateTimeKind.Local).AddTicks(1137), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 4, 13, 17, 31, 15, 262, DateTimeKind.Local).AddTicks(1131), 5, new DateTime(2022, 4, 13, 17, 31, 15, 262, DateTimeKind.Local).AddTicks(1132), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 4, 13, 17, 31, 15, 262, DateTimeKind.Local).AddTicks(1119), 3, new DateTime(2022, 4, 13, 17, 31, 15, 262, DateTimeKind.Local).AddTicks(1123), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 4, 13, 17, 31, 15, 262, DateTimeKind.Local).AddTicks(516), 2, new DateTime(2022, 4, 13, 17, 31, 15, 262, DateTimeKind.Local).AddTicks(520), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Active", "CategoryID", "Created", "Description", "DesignerID", "LengthState", "Name", "Price", "SleeveLengthState", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 8, true, 3, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(111), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 8, 3, "Margot Dress", 895.0, 2, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(112), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, 3, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(118), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 8, 2, "Katya Dress", 795.0, 2, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(119), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, 3, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(108), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 7, 0, "Elina Mini Dress", 527.0, 3, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(109), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, 3, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(105), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 6, 2, "x REVOLVE Samba Gown", 290.0, 3, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(106), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, 3, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(101), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 5, 2, "Shailene Dress", 88.0, 0, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(102), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, 3, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(86), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 3, 0, "Drape Button Front Mini", 216.0, 1, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(87), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, 3, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(76), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 2, 3, "X REVOLVE Carry Mini Dress", 232.0, 0, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(80), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, 3, new DateTime(2022, 4, 13, 17, 31, 15, 262, DateTimeKind.Local).AddTicks(7700), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 1, 2, "X REVOLVE Cassini Dress", 187.0, 2, new DateTime(2022, 4, 13, 17, 31, 15, 262, DateTimeKind.Local).AddTicks(7707), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, 3, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(114), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 9, 2, "Valinda Dress", 128.0, 2, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(115), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, 3, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(89), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 4, 2, "Jake Gown", 198.0, 2, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(90), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductLines",
                columns: new[] { "ID", "Active", "Created", "ProductID", "TextureID", "TextureID1", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7269), 1, 1, null, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7275), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 22, true, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7792), 10, 22, null, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7793), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 21, true, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7790), 10, 21, null, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7791), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 18, true, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7782), 8, 18, null, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7783), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 17, true, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7780), 8, 17, null, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7781), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 16, true, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7777), 7, 16, null, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7778), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 15, true, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7775), 7, 15, null, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7776), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, true, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7772), 6, 14, null, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7773), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, true, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7770), 6, 13, null, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7771), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, true, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7767), 5, 12, null, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7768), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, true, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7765), 5, 11, null, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7766), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7762), 4, 10, null, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7763), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 19, true, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7785), 9, 19, null, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7786), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7757), 3, 8, null, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7759), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7760), 4, 9, null, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7761), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7752), 3, 6, null, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7753), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7739), 1, 2, null, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7743), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7745), 1, 3, null, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7746), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7755), 3, 7, null, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7756), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7750), 2, 5, null, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7751), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7747), 2, 4, null, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7748), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 20, true, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7787), 9, 20, null, new DateTime(2022, 4, 13, 17, 31, 15, 263, DateTimeKind.Local).AddTicks(7788), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Product_Occations",
                columns: new[] { "ID", "OccationID", "ProductID" },
                values: new object[,]
                {
                    { 10, 3, 10 },
                    { 2, 1, 3 },
                    { 5, 2, 3 },
                    { 7, 2, 8 },
                    { 1, 1, 1 },
                    { 11, 4, 1 },
                    { 3, 1, 4 },
                    { 6, 2, 7 },
                    { 4, 1, 5 },
                    { 8, 3, 2 },
                    { 9, 3, 4 }
                });

            migrationBuilder.InsertData(
                table: "Product_SubCategories",
                columns: new[] { "ID", "ProductID", "SubcategoryID" },
                values: new object[,]
                {
                    { 2, 1, 3 },
                    { 5, 2, 7 },
                    { 4, 2, 6 },
                    { 3, 2, 2 },
                    { 1, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "LineQuantities",
                columns: new[] { "ID", "ProductLineID", "Quantity", "SizeID" },
                values: new object[,]
                {
                    { 95, 2, 99, 4 },
                    { 70, 2, 99, 7 },
                    { 78, 2, 99, 1 },
                    { 79, 2, 99, 2 },
                    { 80, 2, 99, 3 },
                    { 81, 2, 99, 4 },
                    { 82, 2, 99, 5 },
                    { 83, 2, 99, 6 },
                    { 69, 2, 99, 6 },
                    { 84, 2, 99, 7 },
                    { 93, 2, 99, 2 },
                    { 94, 2, 99, 3 },
                    { 96, 2, 99, 5 },
                    { 97, 2, 99, 6 },
                    { 98, 2, 99, 7 },
                    { 106, 2, 99, 1 },
                    { 107, 2, 99, 2 },
                    { 92, 2, 99, 1 },
                    { 108, 2, 99, 3 },
                    { 68, 2, 99, 5 },
                    { 66, 2, 99, 3 },
                    { 14, 2, 99, 7 },
                    { 29, 2, 99, 1 },
                    { 30, 2, 99, 2 },
                    { 31, 2, 99, 3 },
                    { 32, 2, 99, 4 },
                    { 33, 2, 99, 5 },
                    { 34, 2, 99, 6 },
                    { 67, 2, 99, 4 },
                    { 35, 2, 99, 7 },
                    { 44, 2, 99, 2 },
                    { 45, 2, 99, 3 },
                    { 46, 2, 99, 4 },
                    { 47, 2, 99, 5 },
                    { 49, 2, 99, 7 },
                    { 64, 2, 99, 1 },
                    { 65, 2, 99, 2 },
                    { 43, 2, 99, 1 },
                    { 13, 2, 99, 6 },
                    { 109, 2, 99, 4 },
                    { 111, 2, 99, 6 },
                    { 153, 2, 99, 6 }
                });

            migrationBuilder.InsertData(
                table: "LineQuantities",
                columns: new[] { "ID", "ProductLineID", "Quantity", "SizeID" },
                values: new object[,]
                {
                    { 154, 2, 99, 7 },
                    { 15, 3, 99, 1 },
                    { 16, 3, 99, 2 },
                    { 17, 3, 99, 3 },
                    { 18, 3, 99, 4 },
                    { 19, 3, 99, 5 },
                    { 152, 2, 99, 5 },
                    { 20, 3, 99, 6 },
                    { 50, 3, 99, 1 },
                    { 51, 3, 99, 2 },
                    { 52, 3, 99, 3 },
                    { 53, 3, 99, 4 },
                    { 54, 3, 99, 5 },
                    { 55, 3, 99, 6 },
                    { 56, 3, 99, 7 },
                    { 21, 3, 99, 7 },
                    { 110, 2, 99, 5 },
                    { 151, 2, 99, 4 },
                    { 149, 2, 99, 2 },
                    { 112, 2, 99, 7 },
                    { 120, 2, 99, 1 },
                    { 121, 2, 99, 2 },
                    { 122, 2, 99, 3 },
                    { 123, 2, 99, 4 },
                    { 124, 2, 99, 5 },
                    { 125, 2, 99, 6 },
                    { 150, 2, 99, 3 },
                    { 126, 2, 99, 7 },
                    { 135, 2, 99, 2 },
                    { 136, 2, 99, 3 },
                    { 137, 2, 99, 4 },
                    { 138, 2, 99, 5 },
                    { 139, 2, 99, 6 },
                    { 140, 2, 99, 7 },
                    { 148, 2, 99, 1 },
                    { 134, 2, 99, 1 },
                    { 12, 2, 99, 5 },
                    { 48, 2, 99, 6 },
                    { 10, 2, 99, 3 },
                    { 42, 1, 99, 7 },
                    { 57, 1, 99, 1 },
                    { 11, 2, 99, 4 }
                });

            migrationBuilder.InsertData(
                table: "LineQuantities",
                columns: new[] { "ID", "ProductLineID", "Quantity", "SizeID" },
                values: new object[,]
                {
                    { 59, 1, 99, 3 },
                    { 60, 1, 99, 4 },
                    { 61, 1, 99, 5 },
                    { 62, 1, 99, 6 },
                    { 41, 1, 99, 6 },
                    { 63, 1, 99, 7 },
                    { 72, 1, 99, 2 },
                    { 73, 1, 99, 3 },
                    { 74, 1, 99, 4 },
                    { 75, 1, 99, 5 },
                    { 76, 1, 99, 6 },
                    { 77, 1, 99, 7 },
                    { 85, 1, 99, 1 },
                    { 71, 1, 99, 1 },
                    { 86, 1, 99, 2 },
                    { 40, 1, 99, 5 },
                    { 38, 1, 99, 3 },
                    { 1, 1, 99, 1 },
                    { 2, 1, 99, 2 },
                    { 3, 1, 99, 3 },
                    { 4, 1, 99, 4 },
                    { 5, 1, 99, 5 },
                    { 6, 1, 99, 6 },
                    { 7, 1, 99, 7 },
                    { 39, 1, 99, 4 },
                    { 22, 1, 99, 1 },
                    { 24, 1, 99, 3 },
                    { 25, 1, 99, 4 },
                    { 26, 1, 99, 5 },
                    { 27, 1, 99, 6 },
                    { 28, 1, 99, 7 },
                    { 36, 1, 99, 1 },
                    { 37, 1, 99, 2 },
                    { 23, 1, 99, 2 },
                    { 87, 1, 99, 3 },
                    { 58, 1, 99, 2 },
                    { 89, 1, 99, 5 },
                    { 129, 1, 99, 3 },
                    { 130, 1, 99, 4 },
                    { 131, 1, 99, 5 },
                    { 132, 1, 99, 6 },
                    { 133, 1, 99, 7 }
                });

            migrationBuilder.InsertData(
                table: "LineQuantities",
                columns: new[] { "ID", "ProductLineID", "Quantity", "SizeID" },
                values: new object[,]
                {
                    { 141, 1, 99, 1 },
                    { 128, 1, 99, 2 },
                    { 142, 1, 99, 2 },
                    { 144, 1, 99, 4 },
                    { 145, 1, 99, 5 },
                    { 146, 1, 99, 6 },
                    { 88, 1, 99, 4 },
                    { 8, 2, 99, 1 },
                    { 9, 2, 99, 2 },
                    { 143, 1, 99, 3 },
                    { 127, 1, 99, 1 },
                    { 147, 1, 99, 7 },
                    { 118, 1, 99, 6 },
                    { 99, 1, 99, 1 },
                    { 119, 1, 99, 7 },
                    { 100, 1, 99, 2 },
                    { 101, 1, 99, 3 },
                    { 102, 1, 99, 4 },
                    { 103, 1, 99, 5 },
                    { 91, 1, 99, 7 },
                    { 104, 1, 99, 6 },
                    { 105, 1, 99, 7 },
                    { 113, 1, 99, 1 },
                    { 114, 1, 99, 2 },
                    { 115, 1, 99, 3 },
                    { 116, 1, 99, 4 },
                    { 117, 1, 99, 5 },
                    { 90, 1, 99, 6 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ID", "Active", "Created", "Image", "ProductLineID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 52, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5038), "Images/Product/Product7/Line2/2.webp", 16, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5039), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 51, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5036), "Images/Product/Product7/Line2/1.jpg", 16, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5037), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 54, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5044), "Images/Product/Product8/Line1/1.webp", 17, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5045), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 50, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5033), "Images/Product/Product7/Line1/3.webp", 15, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5034), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 49, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5030), "Images/Product/Product7/Line1/2.webp", 15, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5031), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 48, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5028), "Images/Product/Product7/Line1/1.webp", 15, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5029), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 53, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5041), "Images/Product/Product7/Line2/3.webp", 16, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5042), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 44, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5016), "Images/Product/Product6/Line2/1.webp", 14, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5017), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 46, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5022), "Images/Product/Product6/Line2/3.webp", 14, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5023), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 45, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5019), "Images/Product/Product6/Line2/2.webp", 14, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5020), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 55, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5047), "Images/Product/Product8/Line1/2.webp", 17, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5048), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 43, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5014), "Images/Product/Product6/Line1/5.webp", 13, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5015), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 42, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5011), "Images/Product/Product6/Line1/4.webp", 13, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5012), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 41, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5008), "Images/Product/Product6/Line1/3.webp", 13, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5009), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ID", "Active", "Created", "Image", "ProductLineID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 40, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5006), "Images/Product/Product6/Line1/2.webp", 13, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5007), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 47, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5025), "Images/Product/Product6/Line2/4.webp", 14, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5026), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 56, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5049), "Images/Product/Product8/Line1/3.webp", 17, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5050), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 70, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5094), "Images/Product/Product10/Line1/2.webp", 21, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5095), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 58, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5055), "Images/Product/Product8/Line2/1.webp", 18, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5056), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 39, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5003), "Images/Product/Product6/Line1/1.webp", 13, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5004), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 74, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5105), "Images/Product/Product10/Line2/2.webp", 22, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5106), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 73, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5103), "Images/Product/Product10/Line2/1.webp", 22, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5104), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 72, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5100), "Images/Product/Product10/Line1/4.webp", 21, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5101), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 75, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5108), "Images/Product/Product10/Line2/3.webp", 22, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5109), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 64, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5078), "Images/Product/Product9/Line1/2.webp", 19, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5079), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 63, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5075), "Images/Product/Product9/Line1/1.webp", 19, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5076), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 57, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5052), "Images/Product/Product8/Line1/4.webp", 17, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5053), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 76, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5111), "Images/Product/Product10/Line2/4.webp", 22, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5112), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 66, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5083), "Images/Product/Product9/Line2/1.webp", 20, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5084), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 71, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5097), "Images/Product/Product10/Line1/3.webp", 21, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5098), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 69, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5092), "Images/Product/Product10/Line1/1.webp", 21, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5093), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 62, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5072), "Images/Product/Product8/Line2/5.jpg", 18, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5073), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 61, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5070), "Images/Product/Product8/Line2/4.webp", 18, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5071), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 60, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5067), "Images/Product/Product8/Line2/3.webp", 18, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5068), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 59, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5058), "Images/Product/Product8/Line2/2.webp", 18, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5059), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 65, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5081), "Images/Product/Product9/Line1/3.webp", 19, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5082), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 38, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5000), "Images/Product/Product5/Line2/3.webp", 12, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5001), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4345), "Images/Product/Product1/Line1/1.webp", 1, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4361), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 36, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4995), "Images/Product/Product5/Line2/1.webp", 12, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4996), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 15, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4926), "Images/Product/Product2/Line2/2.webp", 5, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4927), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4923), "Images/Product/Product2/Line2/1.webp", 5, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4924), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4920), "Images/Product/Product2/Line1/4.jpg", 4, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4922), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4918), "Images/Product/Product2/Line1/3.webp", 4, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4919), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4915), "Images/Product/Product2/Line1/2.webp", 4, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4916), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4912), "Images/Product/Product2/Line1/1.webp", 4, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4913), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4909), "Images/Product/Product1/Line3/3.webp", 3, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4910), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4907), "Images/Product/Product1/Line3/2.webp", 3, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4908), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4904), "Images/Product/Product1/Line3/1.webp", 3, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4905), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 67, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5086), "Images/Product/Product9/Line2/2.webp", 20, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5087), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4901), "Images/Product/Product1/Line2/3.webp", 2, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4902), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4898), "Images/Product/Product1/Line2/2.webp", 2, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4899), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4895), "Images/Product/Product1/Line2/1.webp", 2, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4896), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4893), "Images/Product/Product1/Line1/3.webp", 1, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4893), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4886), "Images/Product/Product1/Line1/2.webp", 1, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4889), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 16, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4929), "Images/Product/Product2/Line2/3.webp", 5, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4930), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 17, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4932), "Images/Product/Product2/Line2/4.webp", 5, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4933), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ID", "Active", "Created", "Image", "ProductLineID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 18, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4945), "Images/Product/Product3/Line1/1.webp", 6, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4946), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 19, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4948), "Images/Product/Product3/Line1/2.webp", 6, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4949), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 35, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4992), "Images/Product/Product5/Line1/3.webp", 11, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4993), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 34, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4989), "Images/Product/Product5/Line1/2.webp", 11, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4990), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 33, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4986), "Images/Product/Product5/Line1/1.webp", 11, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4988), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 32, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4984), "Images/Product/Product4/Line2/3.webp", 10, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4985), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 31, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4981), "Images/Product/Product4/Line2/2.webp", 10, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4982), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 30, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4978), "Images/Product/Product4/Line2/1.webp", 10, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4979), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 29, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4976), "Images/Product/Product4/Line1/3.webp", 9, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4977), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 37, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4998), "Images/Product/Product5/Line2/2.webp", 12, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4999), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 28, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4973), "Images/Product/Product4/Line1/2.webp", 9, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4974), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 26, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4967), "Images/Product/Product3/Line3/3.webp", 8, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4968), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 25, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4965), "Images/Product/Product3/Line3/2.webp", 8, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4966), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 24, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4962), "Images/Product/Product3/Line3/1.webp", 8, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4963), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 23, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4959), "Images/Product/Product3/Line2/3.webp", 7, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4960), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 22, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4956), "Images/Product/Product3/Line2/2.webp", 7, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4957), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 21, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4954), "Images/Product/Product3/Line2/1.webp", 7, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4955), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 20, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4951), "Images/Product/Product3/Line1/3.webp", 6, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4952), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 27, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4970), "Images/Product/Product4/Line1/1.webp", 9, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(4971), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 68, true, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5089), "Images/Product/Product9/Line2/3.webp", 20, new DateTime(2022, 4, 13, 17, 31, 15, 265, DateTimeKind.Local).AddTicks(5090), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ProvinceID",
                table: "Addresses",
                column: "ProvinceID");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserID",
                table: "Addresses",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryID",
                table: "Cities",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteDesigners_DesignerID",
                table: "FavoriteDesigners",
                column: "DesignerID");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteDesigners_UserID",
                table: "FavoriteDesigners",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteProducts_ProductID",
                table: "FavoriteProducts",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteProducts_UserID",
                table: "FavoriteProducts",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteSubcategories_SubcategoryID",
                table: "FavoriteSubcategories",
                column: "SubcategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteSubcategories_UserID",
                table: "FavoriteSubcategories",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_ProductID",
                table: "Feedbacks",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_UserID",
                table: "Feedbacks",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_LineQuantities_ProductLineID",
                table: "LineQuantities",
                column: "ProductLineID");

            migrationBuilder.CreateIndex(
                name: "IX_LineQuantities_SizeID",
                table: "LineQuantities",
                column: "SizeID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderID",
                table: "OrderDetails",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductLineID",
                table: "OrderDetails",
                column: "ProductLineID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserID",
                table: "Orders",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Occations_OccationID",
                table: "Product_Occations",
                column: "OccationID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Occations_ProductID",
                table: "Product_Occations",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SubCategories_ProductID",
                table: "Product_SubCategories",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SubCategories_SubcategoryID",
                table: "Product_SubCategories",
                column: "SubcategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductLineID",
                table: "ProductImages",
                column: "ProductLineID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductLines_ProductID",
                table: "ProductLines",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductLines_TextureID",
                table: "ProductLines",
                column: "TextureID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductLines_TextureID1",
                table: "ProductLines",
                column: "TextureID1",
                unique: true,
                filter: "[TextureID1] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_DesignerID",
                table: "Products",
                column: "DesignerID");

            migrationBuilder.CreateIndex(
                name: "IX_Provinces_CityID",
                table: "Provinces",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ProductID",
                table: "Sales",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "FavoriteDesigners");

            migrationBuilder.DropTable(
                name: "FavoriteProducts");

            migrationBuilder.DropTable(
                name: "FavoriteSubcategories");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "LineQuantities");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Product_Occations");

            migrationBuilder.DropTable(
                name: "Product_SubCategories");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Occations");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "ProductLines");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Textures");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Designers");
        }
    }
}
