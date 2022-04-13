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
                    { new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"), "a65f596f-c2c5-4436-8a27-0ff2b9d80c39", "Customer", "CUSTOMER" },
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "e8b3c801-0750-4996-b7f8-166525c7fde9", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Active", "Created", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 15, true, new DateTime(2022, 4, 13, 17, 40, 27, 364, DateTimeKind.Local).AddTicks(8204), "Tops", new DateTime(2022, 4, 13, 17, 40, 27, 364, DateTimeKind.Local).AddTicks(8206), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, true, new DateTime(2022, 4, 13, 17, 40, 27, 364, DateTimeKind.Local).AddTicks(8201), "Swimsuits & Cover-Ups", new DateTime(2022, 4, 13, 17, 40, 27, 364, DateTimeKind.Local).AddTicks(8203), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, true, new DateTime(2022, 4, 13, 17, 40, 27, 364, DateTimeKind.Local).AddTicks(8198), "Sweaters & Knits", new DateTime(2022, 4, 13, 17, 40, 27, 364, DateTimeKind.Local).AddTicks(8200), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, true, new DateTime(2022, 4, 13, 17, 40, 27, 364, DateTimeKind.Local).AddTicks(8195), "Skirts", new DateTime(2022, 4, 13, 17, 40, 27, 364, DateTimeKind.Local).AddTicks(8197), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, true, new DateTime(2022, 4, 13, 17, 40, 27, 364, DateTimeKind.Local).AddTicks(8192), "Shorts", new DateTime(2022, 4, 13, 17, 40, 27, 364, DateTimeKind.Local).AddTicks(8194), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, new DateTime(2022, 4, 13, 17, 40, 27, 364, DateTimeKind.Local).AddTicks(8189), "Rompers", new DateTime(2022, 4, 13, 17, 40, 27, 364, DateTimeKind.Local).AddTicks(8191), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 4, 13, 17, 40, 27, 363, DateTimeKind.Local).AddTicks(6432), "Activewear", new DateTime(2022, 4, 13, 17, 40, 27, 364, DateTimeKind.Local).AddTicks(6326), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 4, 13, 17, 40, 27, 364, DateTimeKind.Local).AddTicks(8183), "Loungewear", new DateTime(2022, 4, 13, 17, 40, 27, 364, DateTimeKind.Local).AddTicks(8184), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 4, 13, 17, 40, 27, 364, DateTimeKind.Local).AddTicks(8180), "Lingerie & Sleepwear", new DateTime(2022, 4, 13, 17, 40, 27, 364, DateTimeKind.Local).AddTicks(8181), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 4, 13, 17, 40, 27, 364, DateTimeKind.Local).AddTicks(8177), "Leather", new DateTime(2022, 4, 13, 17, 40, 27, 364, DateTimeKind.Local).AddTicks(8178), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 4, 13, 17, 40, 27, 364, DateTimeKind.Local).AddTicks(8174), "Jumpsuits", new DateTime(2022, 4, 13, 17, 40, 27, 364, DateTimeKind.Local).AddTicks(8175), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 4, 13, 17, 40, 27, 364, DateTimeKind.Local).AddTicks(8076), "Jackets & Coats", new DateTime(2022, 4, 13, 17, 40, 27, 364, DateTimeKind.Local).AddTicks(8077), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 4, 13, 17, 40, 27, 364, DateTimeKind.Local).AddTicks(8073), "Dresses", new DateTime(2022, 4, 13, 17, 40, 27, 364, DateTimeKind.Local).AddTicks(8074), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 4, 13, 17, 40, 27, 364, DateTimeKind.Local).AddTicks(8061), "Denim", new DateTime(2022, 4, 13, 17, 40, 27, 364, DateTimeKind.Local).AddTicks(8070), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, new DateTime(2022, 4, 13, 17, 40, 27, 364, DateTimeKind.Local).AddTicks(8186), "Pants", new DateTime(2022, 4, 13, 17, 40, 27, 364, DateTimeKind.Local).AddTicks(8187), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "Active", "Created", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2022, 4, 13, 17, 40, 27, 365, DateTimeKind.Local).AddTicks(1393), "Vietnam", new DateTime(2022, 4, 13, 17, 40, 27, 365, DateTimeKind.Local).AddTicks(1405), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 4, 13, 17, 40, 27, 365, DateTimeKind.Local).AddTicks(1943), "China", new DateTime(2022, 4, 13, 17, 40, 27, 365, DateTimeKind.Local).AddTicks(1948), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 4, 13, 17, 40, 27, 365, DateTimeKind.Local).AddTicks(1951), "America", new DateTime(2022, 4, 13, 17, 40, 27, 365, DateTimeKind.Local).AddTicks(1952), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Designers",
                columns: new[] { "ID", "Active", "Created", "Description", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 9, true, new DateTime(2022, 4, 13, 17, 40, 27, 365, DateTimeKind.Local).AddTicks(7172), null, "ASTR the Label", new DateTime(2022, 4, 13, 17, 40, 27, 365, DateTimeKind.Local).AddTicks(7174), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 4, 13, 17, 40, 27, 365, DateTimeKind.Local).AddTicks(7170), null, "retrofete", new DateTime(2022, 4, 13, 17, 40, 27, 365, DateTimeKind.Local).AddTicks(7171), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 4, 13, 17, 40, 27, 365, DateTimeKind.Local).AddTicks(7167), null, "SOLACE London", new DateTime(2022, 4, 13, 17, 40, 27, 365, DateTimeKind.Local).AddTicks(7168), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 4, 13, 17, 40, 27, 365, DateTimeKind.Local).AddTicks(7158), null, "Michael Costello", new DateTime(2022, 4, 13, 17, 40, 27, 365, DateTimeKind.Local).AddTicks(7159), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 4, 13, 17, 40, 27, 365, DateTimeKind.Local).AddTicks(7161), null, "AFRM", new DateTime(2022, 4, 13, 17, 40, 27, 365, DateTimeKind.Local).AddTicks(7162), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 4, 13, 17, 40, 27, 365, DateTimeKind.Local).AddTicks(7155), null, "krisa", new DateTime(2022, 4, 13, 17, 40, 27, 365, DateTimeKind.Local).AddTicks(7156), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 4, 13, 17, 40, 27, 365, DateTimeKind.Local).AddTicks(7148), null, "Sabina Musayev", new DateTime(2022, 4, 13, 17, 40, 27, 365, DateTimeKind.Local).AddTicks(7153), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 4, 13, 17, 40, 27, 365, DateTimeKind.Local).AddTicks(6517), null, "ELLIATT", new DateTime(2022, 4, 13, 17, 40, 27, 365, DateTimeKind.Local).AddTicks(6535), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 4, 13, 17, 40, 27, 365, DateTimeKind.Local).AddTicks(7164), null, "Amanda Uprichard", new DateTime(2022, 4, 13, 17, 40, 27, 365, DateTimeKind.Local).AddTicks(7165), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Occations",
                columns: new[] { "ID", "Active", "Created", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2022, 4, 13, 17, 40, 27, 366, DateTimeKind.Local).AddTicks(370), "To A Special Event", new DateTime(2022, 4, 13, 17, 40, 27, 366, DateTimeKind.Local).AddTicks(385), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 4, 13, 17, 40, 27, 366, DateTimeKind.Local).AddTicks(919), "On Vacation", new DateTime(2022, 4, 13, 17, 40, 27, 366, DateTimeKind.Local).AddTicks(924), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 4, 13, 17, 40, 27, 366, DateTimeKind.Local).AddTicks(926), "For A Night Out", new DateTime(2022, 4, 13, 17, 40, 27, 366, DateTimeKind.Local).AddTicks(927), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 4, 13, 17, 40, 27, 366, DateTimeKind.Local).AddTicks(929), "On The Weekend", new DateTime(2022, 4, 13, 17, 40, 27, 366, DateTimeKind.Local).AddTicks(930), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "ID", "Active", "Created", "Key", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 6, true, new DateTime(2022, 4, 13, 17, 40, 27, 366, DateTimeKind.Local).AddTicks(4859), "XL", new DateTime(2022, 4, 13, 17, 40, 27, 366, DateTimeKind.Local).AddTicks(4860), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 4, 13, 17, 40, 27, 366, DateTimeKind.Local).AddTicks(4856), "L", new DateTime(2022, 4, 13, 17, 40, 27, 366, DateTimeKind.Local).AddTicks(4857), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 4, 13, 17, 40, 27, 366, DateTimeKind.Local).AddTicks(4862), "XXL", new DateTime(2022, 4, 13, 17, 40, 27, 366, DateTimeKind.Local).AddTicks(4863), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 4, 13, 17, 40, 27, 366, DateTimeKind.Local).AddTicks(4850), "S", new DateTime(2022, 4, 13, 17, 40, 27, 366, DateTimeKind.Local).AddTicks(4851), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 4, 13, 17, 40, 27, 366, DateTimeKind.Local).AddTicks(4842), "XS", new DateTime(2022, 4, 13, 17, 40, 27, 366, DateTimeKind.Local).AddTicks(4847), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 4, 13, 17, 40, 27, 366, DateTimeKind.Local).AddTicks(4853), "M", new DateTime(2022, 4, 13, 17, 40, 27, 366, DateTimeKind.Local).AddTicks(4854), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 4, 13, 17, 40, 27, 366, DateTimeKind.Local).AddTicks(4220), "XXS", new DateTime(2022, 4, 13, 17, 40, 27, 366, DateTimeKind.Local).AddTicks(4228), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "ID", "Active", "Created", "Name", "ParentID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 9, true, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(7925), "Sundresses", null, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(7926), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(7922), "Gingham", null, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(7923), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "ID", "Active", "Created", "Name", "ParentID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 7, true, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(7919), "Floral", null, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(7920), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(7910), "Bodycon", null, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(7912), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(7913), "Denim", null, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(7914), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(7907), "Bohemian", null, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(7909), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(7900), "One Shoulder", null, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(7905), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(7385), "Cocktail", null, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(7393), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(7916), "Wrap", null, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(7917), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Textures",
                columns: new[] { "ID", "Active", "Created", "Image", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 22, true, new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7290), "Images/Texture/taffy-pink.webp", "Taffy Pink", new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7291), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 21, true, new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7286), "Images/Texture/moonglow-white.webp", "Moonglow White", new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7288), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 20, true, new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7283), "Images/Texture/pink-orchid.webp", "Pink Orchid", new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7284), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 19, true, new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7280), "Images/Texture/olive.webp", "Olive", new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7281), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 18, true, new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7277), "Images/Texture/white.png", "White", new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7278), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 17, true, new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7273), "Images/Texture/green.webp", "Green", new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7274), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 16, true, new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7270), "Images/Texture/pink.webp", "Pink", new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7271), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 15, true, new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7267), "Images/Texture/cream.webp", "Cream", new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7268), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, true, new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7263), "Images/Texture/black-sequin.webp", "Black Sequin", new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7264), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, true, new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7260), "Images/Texture/white-sequin.webp", "White Sequin", new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7261), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, true, new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7253), "Images/Texture/abstract-neon-dot.webp", "Abstract Neon Dot", new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7255), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7250), "Images/Texture/baby-blue.webp", "Baby Blue", new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7251), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7243), "Images/Texture/candy.webp", "Candy", new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7245), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7239), "Images/Texture/rosa.webp", "Rosa", new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7240), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7236), "Images/Texture/black.webp", "Black", new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7237), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7232), "Images/Texture/multicolor-blue.webp", "Multicolor Blue", new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7233), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7229), "Images/Texture/blush.webp", "Blush", new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7230), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7226), "Images/Texture/blue.webp", "Blue", new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7227), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7215), "Images/Texture/marigold.webp", "Marigold", new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7221), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(6038), "Images/Texture/lilac.webp", "Lilac", new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(6057), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, true, new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7257), "Images/Texture/multi-watercolor.webp", "Multi Watercolor", new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7258), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7247), "Images/Texture/taupe.webp", "Taupe", new DateTime(2022, 4, 13, 17, 40, 27, 367, DateTimeKind.Local).AddTicks(7248), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), 0, "b8003b63-f828-49ba-91d0-67ec48ea2a4c", "user@shop.com", false, false, null, "USER@SHOP.COM", "USER", "AQAAAAEAACcQAAAAEMOFwGgYcZIVSu9utHaDmfR2YiLAw4ygUtWKZvGS7nVvsOSpGlsJYQCnF7q44Y9hfw==", "0125454545", false, null, false, "user" },
                    { new Guid("50892ac9-ebe0-4c8d-f28e-08d9638e12dc"), 0, "8885f404-7365-48dd-8905-5eea7014639e", "user-bak@shop.com", false, false, null, "USER-BAK@SHOP.COM", "USER-BAK", "AQAAAAEAACcQAAAAEI878JBJOLqFPn+fCYoHdx3tdTu9HmvZAb+LyMjKYgV5tG0YW0rRt2lbAXfS9gU5Kg==", "0125454546", false, null, false, "user-bak" },
                    { new Guid("170ca4bc-ef9f-4de7-ae96-08d962dad25f"), 0, "34f174d1-2c75-44b1-a1b6-e7dbef6506b2", "admin@shop.com", false, false, null, "ADMIN@SHOP.COM", "ADMIN", "AQAAAAEAACcQAAAAEGKy8OQ1C85ERpXRiX1I7VqJ7f5wnjziWdxNdOZSlQv3ok4bO7RVJvZSkhfXrdhQKQ==", "0323265665", false, null, false, "admin" },
                    { new Guid("0dd37c3c-4694-429e-623b-08d962dbded7"), 0, "0b674757-4bfa-446b-94a7-5bb44e38cbb3", "admin-bak@shop.com", false, false, null, "ADMIN-BAK@SHOP.COM", "ADMIN-BAK", "AQAAAAEAACcQAAAAEAQ/1Y5aH9GHjFQhcg2JVTw8Qu8yd4MXklx6sOXdRLhOFtVGKAXdKtKXvGvRWcaR4w==", "0323265666", false, null, false, "admin-bak" }
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
                    { 11, true, 3, new DateTime(2022, 4, 13, 17, 40, 27, 368, DateTimeKind.Local).AddTicks(3525), "Los Angeles", new DateTime(2022, 4, 13, 17, 40, 27, 368, DateTimeKind.Local).AddTicks(3527), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, 3, new DateTime(2022, 4, 13, 17, 40, 27, 368, DateTimeKind.Local).AddTicks(3522), "New York", new DateTime(2022, 4, 13, 17, 40, 27, 368, DateTimeKind.Local).AddTicks(3524), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, 2, new DateTime(2022, 4, 13, 17, 40, 27, 368, DateTimeKind.Local).AddTicks(3519), "Shanghai", new DateTime(2022, 4, 13, 17, 40, 27, 368, DateTimeKind.Local).AddTicks(3521), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, 1, new DateTime(2022, 4, 13, 17, 40, 27, 368, DateTimeKind.Local).AddTicks(2275), "Can Tho", new DateTime(2022, 4, 13, 17, 40, 27, 368, DateTimeKind.Local).AddTicks(2288), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, 2, new DateTime(2022, 4, 13, 17, 40, 27, 368, DateTimeKind.Local).AddTicks(3514), "Ma Cau", new DateTime(2022, 4, 13, 17, 40, 27, 368, DateTimeKind.Local).AddTicks(3515), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, 2, new DateTime(2022, 4, 13, 17, 40, 27, 368, DateTimeKind.Local).AddTicks(3511), "Hong Kong", new DateTime(2022, 4, 13, 17, 40, 27, 368, DateTimeKind.Local).AddTicks(3512), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, 1, new DateTime(2022, 4, 13, 17, 40, 27, 368, DateTimeKind.Local).AddTicks(3508), "Ho Chi Minh", new DateTime(2022, 4, 13, 17, 40, 27, 368, DateTimeKind.Local).AddTicks(3509), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, 1, new DateTime(2022, 4, 13, 17, 40, 27, 368, DateTimeKind.Local).AddTicks(3489), "Da Nang", new DateTime(2022, 4, 13, 17, 40, 27, 368, DateTimeKind.Local).AddTicks(3498), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, 1, new DateTime(2022, 4, 13, 17, 40, 27, 368, DateTimeKind.Local).AddTicks(3502), "Hai Phong", new DateTime(2022, 4, 13, 17, 40, 27, 368, DateTimeKind.Local).AddTicks(3503), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, 1, new DateTime(2022, 4, 13, 17, 40, 27, 368, DateTimeKind.Local).AddTicks(3505), "Hanoi", new DateTime(2022, 4, 13, 17, 40, 27, 368, DateTimeKind.Local).AddTicks(3506), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, 2, new DateTime(2022, 4, 13, 17, 40, 27, 368, DateTimeKind.Local).AddTicks(3516), "Beijing", new DateTime(2022, 4, 13, 17, 40, 27, 368, DateTimeKind.Local).AddTicks(3518), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "FavoriteDesigners",
                columns: new[] { "ID", "Active", "Created", "DesignerID", "Updated", "UserID", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 5, true, new DateTime(2022, 4, 13, 17, 40, 27, 368, DateTimeKind.Local).AddTicks(8801), 9, new DateTime(2022, 4, 13, 17, 40, 27, 368, DateTimeKind.Local).AddTicks(8802), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 4, 13, 17, 40, 27, 368, DateTimeKind.Local).AddTicks(8796), 7, new DateTime(2022, 4, 13, 17, 40, 27, 368, DateTimeKind.Local).AddTicks(8797), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 4, 13, 17, 40, 27, 368, DateTimeKind.Local).AddTicks(8790), 5, new DateTime(2022, 4, 13, 17, 40, 27, 368, DateTimeKind.Local).AddTicks(8791), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 4, 13, 17, 40, 27, 368, DateTimeKind.Local).AddTicks(8772), 3, new DateTime(2022, 4, 13, 17, 40, 27, 368, DateTimeKind.Local).AddTicks(8778), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 4, 13, 17, 40, 27, 368, DateTimeKind.Local).AddTicks(7607), 2, new DateTime(2022, 4, 13, 17, 40, 27, 368, DateTimeKind.Local).AddTicks(7616), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Active", "CategoryID", "Created", "Description", "DesignerID", "LengthState", "Name", "Price", "SleeveLengthState", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 8, true, 3, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(3490), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 8, 3, "Margot Dress", 895.0, 2, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(3491), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, 3, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(3498), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 8, 2, "Katya Dress", 795.0, 2, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(3499), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, 3, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(3486), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 7, 0, "Elina Mini Dress", 527.0, 3, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(3487), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, 3, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(3482), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 6, 2, "x REVOLVE Samba Gown", 290.0, 3, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(3484), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, 3, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(3479), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 5, 2, "Shailene Dress", 88.0, 0, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(3480), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, 3, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(3471), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 3, 0, "Drape Button Front Mini", 216.0, 1, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(3472), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, 3, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(3455), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 2, 3, "X REVOLVE Carry Mini Dress", 232.0, 0, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(3464), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, 3, new DateTime(2022, 4, 13, 17, 40, 27, 369, DateTimeKind.Local).AddTicks(8308), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 1, 2, "X REVOLVE Cassini Dress", 187.0, 2, new DateTime(2022, 4, 13, 17, 40, 27, 369, DateTimeKind.Local).AddTicks(8332), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, 3, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(3494), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 9, 2, "Valinda Dress", 128.0, 2, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(3495), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, 3, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(3475), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 4, 2, "Jake Gown", 198.0, 2, new DateTime(2022, 4, 13, 17, 40, 27, 370, DateTimeKind.Local).AddTicks(3476), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductLines",
                columns: new[] { "ID", "Active", "Created", "ProductID", "TextureID", "TextureID1", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(3994), 1, 1, null, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(4001), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 22, true, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(5047), 10, 22, null, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(5049), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 21, true, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(5045), 10, 21, null, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(5046), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 18, true, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(5036), 8, 18, null, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(5037), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 17, true, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(5033), 8, 17, null, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(5034), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 16, true, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(5030), 7, 16, null, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(5031), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 15, true, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(5027), 7, 15, null, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(5028), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, true, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(5024), 6, 14, null, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(5025), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, true, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(5021), 6, 13, null, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(5022), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, true, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(5018), 5, 12, null, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(5019), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, true, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(5015), 5, 11, null, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(5016), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(5012), 4, 10, null, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(5013), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 19, true, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(5039), 9, 19, null, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(5040), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(4982), 3, 8, null, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(4983), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(4985), 4, 9, null, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(4986), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(4976), 3, 6, null, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(4977), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(4959), 1, 2, null, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(4964), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(4967), 1, 3, null, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(4968), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(4979), 3, 7, null, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(4980), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(4973), 2, 5, null, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(4974), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(4970), 2, 4, null, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(4971), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 20, true, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(5042), 9, 20, null, new DateTime(2022, 4, 13, 17, 40, 27, 371, DateTimeKind.Local).AddTicks(5043), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
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
                    { 140, 20, 99, 7 },
                    { 72, 11, 99, 2 },
                    { 73, 11, 99, 3 },
                    { 74, 11, 99, 4 },
                    { 75, 11, 99, 5 },
                    { 76, 11, 99, 6 },
                    { 77, 11, 99, 7 },
                    { 142, 21, 99, 2 },
                    { 71, 11, 99, 1 },
                    { 141, 21, 99, 1 },
                    { 78, 12, 99, 1 },
                    { 79, 12, 99, 2 },
                    { 80, 12, 99, 3 },
                    { 81, 12, 99, 4 },
                    { 82, 12, 99, 5 },
                    { 83, 12, 99, 6 },
                    { 84, 12, 99, 7 },
                    { 139, 20, 99, 6 },
                    { 126, 18, 99, 7 },
                    { 143, 21, 99, 3 },
                    { 145, 21, 99, 5 },
                    { 57, 9, 99, 1 },
                    { 115, 17, 99, 3 },
                    { 59, 9, 99, 3 },
                    { 60, 9, 99, 4 },
                    { 61, 9, 99, 5 },
                    { 62, 9, 99, 6 },
                    { 63, 9, 99, 7 },
                    { 144, 21, 99, 4 },
                    { 147, 21, 99, 7 },
                    { 64, 10, 99, 1 },
                    { 65, 10, 99, 2 },
                    { 66, 10, 99, 3 },
                    { 67, 10, 99, 4 },
                    { 68, 10, 99, 5 },
                    { 69, 10, 99, 6 },
                    { 70, 10, 99, 7 },
                    { 146, 21, 99, 6 },
                    { 56, 8, 99, 7 },
                    { 85, 13, 99, 1 },
                    { 87, 13, 99, 3 },
                    { 102, 15, 99, 4 }
                });

            migrationBuilder.InsertData(
                table: "LineQuantities",
                columns: new[] { "ID", "ProductLineID", "Quantity", "SizeID" },
                values: new object[,]
                {
                    { 103, 15, 99, 5 },
                    { 104, 15, 99, 6 },
                    { 105, 15, 99, 7 },
                    { 106, 16, 99, 1 },
                    { 107, 16, 99, 2 },
                    { 108, 16, 99, 3 },
                    { 101, 15, 99, 3 },
                    { 109, 16, 99, 4 },
                    { 111, 16, 99, 6 },
                    { 112, 16, 99, 7 },
                    { 119, 17, 99, 7 },
                    { 118, 17, 99, 6 },
                    { 117, 17, 99, 5 },
                    { 113, 17, 99, 1 },
                    { 114, 17, 99, 2 },
                    { 110, 16, 99, 5 },
                    { 86, 13, 99, 2 },
                    { 100, 15, 99, 2 },
                    { 120, 18, 99, 1 },
                    { 88, 13, 99, 4 },
                    { 89, 13, 99, 5 },
                    { 90, 13, 99, 6 },
                    { 91, 13, 99, 7 },
                    { 125, 18, 99, 6 },
                    { 124, 18, 99, 5 },
                    { 123, 18, 99, 4 },
                    { 99, 15, 99, 1 },
                    { 122, 18, 99, 3 },
                    { 93, 14, 99, 2 },
                    { 94, 14, 99, 3 },
                    { 95, 14, 99, 4 },
                    { 96, 14, 99, 5 },
                    { 97, 14, 99, 6 },
                    { 98, 14, 99, 7 },
                    { 121, 18, 99, 2 },
                    { 92, 14, 99, 1 },
                    { 55, 8, 99, 6 },
                    { 58, 9, 99, 2 },
                    { 53, 8, 99, 4 },
                    { 17, 3, 99, 3 },
                    { 18, 3, 99, 4 },
                    { 19, 3, 99, 5 }
                });

            migrationBuilder.InsertData(
                table: "LineQuantities",
                columns: new[] { "ID", "ProductLineID", "Quantity", "SizeID" },
                values: new object[,]
                {
                    { 20, 3, 99, 6 },
                    { 21, 3, 99, 7 },
                    { 133, 19, 99, 7 },
                    { 132, 19, 99, 6 },
                    { 16, 3, 99, 2 },
                    { 131, 19, 99, 5 },
                    { 22, 4, 99, 1 },
                    { 23, 4, 99, 2 },
                    { 24, 4, 99, 3 },
                    { 25, 4, 99, 4 },
                    { 26, 4, 99, 5 },
                    { 27, 4, 99, 6 },
                    { 54, 8, 99, 5 },
                    { 130, 19, 99, 4 },
                    { 15, 3, 99, 1 },
                    { 14, 2, 99, 7 },
                    { 13, 2, 99, 6 },
                    { 138, 20, 99, 5 },
                    { 137, 20, 99, 4 },
                    { 1, 1, 99, 1 },
                    { 2, 1, 99, 2 },
                    { 3, 1, 99, 3 },
                    { 4, 1, 99, 4 },
                    { 5, 1, 99, 5 },
                    { 6, 1, 99, 6 },
                    { 7, 1, 99, 7 },
                    { 136, 20, 99, 3 },
                    { 135, 20, 99, 2 },
                    { 134, 20, 99, 1 },
                    { 8, 2, 99, 1 },
                    { 9, 2, 99, 2 },
                    { 10, 2, 99, 3 },
                    { 11, 2, 99, 4 },
                    { 12, 2, 99, 5 },
                    { 129, 19, 99, 3 },
                    { 128, 19, 99, 2 },
                    { 28, 4, 99, 7 },
                    { 116, 17, 99, 4 },
                    { 41, 6, 99, 6 },
                    { 42, 6, 99, 7 },
                    { 153, 22, 99, 6 },
                    { 50, 8, 99, 1 }
                });

            migrationBuilder.InsertData(
                table: "LineQuantities",
                columns: new[] { "ID", "ProductLineID", "Quantity", "SizeID" },
                values: new object[,]
                {
                    { 148, 22, 99, 1 },
                    { 127, 19, 99, 1 },
                    { 149, 22, 99, 2 },
                    { 152, 22, 99, 5 },
                    { 151, 22, 99, 4 },
                    { 43, 7, 99, 1 },
                    { 44, 7, 99, 2 },
                    { 45, 7, 99, 3 },
                    { 46, 7, 99, 4 },
                    { 47, 7, 99, 5 },
                    { 150, 22, 99, 3 },
                    { 40, 6, 99, 5 },
                    { 49, 7, 99, 7 },
                    { 39, 6, 99, 4 },
                    { 37, 6, 99, 2 },
                    { 52, 8, 99, 3 },
                    { 29, 5, 99, 1 },
                    { 30, 5, 99, 2 },
                    { 31, 5, 99, 3 },
                    { 38, 6, 99, 3 },
                    { 33, 5, 99, 5 },
                    { 32, 5, 99, 4 },
                    { 35, 5, 99, 7 },
                    { 51, 8, 99, 2 },
                    { 154, 22, 99, 7 },
                    { 36, 6, 99, 1 },
                    { 34, 5, 99, 6 },
                    { 48, 7, 99, 6 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ID", "Active", "Created", "Image", "ProductLineID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 58, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9611), "Images/Product/Product8/Line2/1.webp", 18, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9613), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 74, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9663), "Images/Product/Product10/Line2/2.webp", 22, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9664), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 75, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9666), "Images/Product/Product10/Line2/3.webp", 22, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9668), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 76, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9670), "Images/Product/Product10/Line2/4.webp", 22, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9671), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 68, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9644), "Images/Product/Product9/Line2/3.webp", 20, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9645), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 59, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9615), "Images/Product/Product8/Line2/2.webp", 18, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9616), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 60, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9618), "Images/Product/Product8/Line2/3.webp", 18, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9619), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 61, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9621), "Images/Product/Product8/Line2/4.webp", 18, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9622), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 62, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9624), "Images/Product/Product8/Line2/5.jpg", 18, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9626), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 67, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9641), "Images/Product/Product9/Line2/2.webp", 20, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9642), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 66, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9637), "Images/Product/Product9/Line2/1.webp", 20, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9638), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 63, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9628), "Images/Product/Product9/Line1/1.webp", 19, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9629), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 64, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9631), "Images/Product/Product9/Line1/2.webp", 19, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9632), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 69, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9647), "Images/Product/Product10/Line1/1.webp", 21, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9648), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ID", "Active", "Created", "Image", "ProductLineID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 70, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9650), "Images/Product/Product10/Line1/2.webp", 21, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9651), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 71, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9653), "Images/Product/Product10/Line1/3.webp", 21, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9655), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 72, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9657), "Images/Product/Product10/Line1/4.webp", 21, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9658), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 73, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9660), "Images/Product/Product10/Line2/1.webp", 22, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9661), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 65, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9634), "Images/Product/Product9/Line1/3.webp", 19, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9635), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 38, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9537), "Images/Product/Product5/Line2/3.webp", 12, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9538), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 56, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9605), "Images/Product/Product8/Line1/3.webp", 17, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9606), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 25, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9495), "Images/Product/Product3/Line3/2.webp", 8, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9496), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 24, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9491), "Images/Product/Product3/Line3/1.webp", 8, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9493), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 23, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9488), "Images/Product/Product3/Line2/3.webp", 7, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9489), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 22, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9485), "Images/Product/Product3/Line2/2.webp", 7, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9486), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 21, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9482), "Images/Product/Product3/Line2/1.webp", 7, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9483), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 20, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9478), "Images/Product/Product3/Line1/3.webp", 6, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9480), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 19, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9475), "Images/Product/Product3/Line1/2.webp", 6, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9476), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 18, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9472), "Images/Product/Product3/Line1/1.webp", 6, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9473), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 17, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9469), "Images/Product/Product2/Line2/4.webp", 5, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9470), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 16, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9465), "Images/Product/Product2/Line2/3.webp", 5, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9467), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 15, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9462), "Images/Product/Product2/Line2/2.webp", 5, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9463), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 26, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9498), "Images/Product/Product3/Line3/3.webp", 8, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9499), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9459), "Images/Product/Product2/Line2/1.webp", 5, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9460), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9452), "Images/Product/Product2/Line1/3.webp", 4, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9453), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9449), "Images/Product/Product2/Line1/2.webp", 4, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9450), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9446), "Images/Product/Product2/Line1/1.webp", 4, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9447), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9442), "Images/Product/Product1/Line3/3.webp", 3, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9443), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9439), "Images/Product/Product1/Line3/2.webp", 3, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9440), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9435), "Images/Product/Product1/Line3/1.webp", 3, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9437), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9432), "Images/Product/Product1/Line2/3.webp", 2, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9433), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9429), "Images/Product/Product1/Line2/2.webp", 2, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9430), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9425), "Images/Product/Product1/Line2/1.webp", 2, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9427), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9422), "Images/Product/Product1/Line1/3.webp", 1, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9423), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9411), "Images/Product/Product1/Line1/2.webp", 1, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9417), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9456), "Images/Product/Product2/Line1/4.jpg", 4, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9457), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 27, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9501), "Images/Product/Product4/Line1/1.webp", 9, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9502), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 28, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9504), "Images/Product/Product4/Line1/2.webp", 9, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9506), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 29, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9508), "Images/Product/Product4/Line1/3.webp", 9, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9509), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 55, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9602), "Images/Product/Product8/Line1/2.webp", 17, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9603), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 54, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9598), "Images/Product/Product8/Line1/1.webp", 17, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9600), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 53, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9595), "Images/Product/Product7/Line2/3.webp", 16, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9596), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 52, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9592), "Images/Product/Product7/Line2/2.webp", 16, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9593), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 51, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9589), "Images/Product/Product7/Line2/1.jpg", 16, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9590), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 50, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9586), "Images/Product/Product7/Line1/3.webp", 15, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9587), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 49, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9582), "Images/Product/Product7/Line1/2.webp", 15, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9584), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ID", "Active", "Created", "Image", "ProductLineID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 48, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9579), "Images/Product/Product7/Line1/1.webp", 15, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9580), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 47, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9576), "Images/Product/Product6/Line2/4.webp", 14, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9577), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 46, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9572), "Images/Product/Product6/Line2/3.webp", 14, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9574), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 45, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9569), "Images/Product/Product6/Line2/2.webp", 14, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9570), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 44, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9566), "Images/Product/Product6/Line2/1.webp", 14, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9567), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 43, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9553), "Images/Product/Product6/Line1/5.webp", 13, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9555), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 42, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9550), "Images/Product/Product6/Line1/4.webp", 13, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9551), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 41, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9547), "Images/Product/Product6/Line1/3.webp", 13, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9548), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 40, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9543), "Images/Product/Product6/Line1/2.webp", 13, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9545), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 39, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9540), "Images/Product/Product6/Line1/1.webp", 13, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9541), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 37, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9534), "Images/Product/Product5/Line2/2.webp", 12, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9535), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 36, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9530), "Images/Product/Product5/Line2/1.webp", 12, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9532), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 35, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9527), "Images/Product/Product5/Line1/3.webp", 11, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9528), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 34, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9524), "Images/Product/Product5/Line1/2.webp", 11, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9525), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 33, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9521), "Images/Product/Product5/Line1/1.webp", 11, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9522), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 32, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9517), "Images/Product/Product4/Line2/3.webp", 10, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9519), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 31, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9514), "Images/Product/Product4/Line2/2.webp", 10, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9515), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 30, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9511), "Images/Product/Product4/Line2/1.webp", 10, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9512), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 57, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9608), "Images/Product/Product8/Line1/4.webp", 17, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(9609), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(8262), "Images/Product/Product1/Line1/1.webp", 1, new DateTime(2022, 4, 13, 17, 40, 27, 373, DateTimeKind.Local).AddTicks(8291), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
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
