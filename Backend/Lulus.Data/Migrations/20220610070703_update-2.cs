using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lulus.Data.Migrations
{
    public partial class update2 : Migration
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
                    Quantity = table.Column<int>(type: "int", nullable: false),
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
                name: "OrderDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    Total = table.Column<double>(type: "float", nullable: false, defaultValue: 0.0),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ProductLineID = table.Column<int>(type: "int", nullable: false),
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
                    { new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"), "124d1ba9-a940-4950-a9e6-d00b6d10d6ec", "Customer", "CUSTOMER" },
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "773b4b29-d594-46de-b189-fe6b93de701f", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Active", "Created", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 15, true, new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(2949), "Tops", new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(2950), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, true, new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(2947), "Swimsuits & Cover-Ups", new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(2948), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, true, new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(2944), "Sweaters & Knits", new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(2945), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, true, new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(2942), "Skirts", new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(2943), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, true, new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(2939), "Shorts", new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(2940), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(2937), "Rompers", new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(2938), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 6, 10, 14, 7, 2, 493, DateTimeKind.Local).AddTicks(3959), "Activewear", new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(2179), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(2932), "Loungewear", new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(2933), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(2930), "Lingerie & Sleepwear", new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(2931), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(2928), "Leather", new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(2929), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(2925), "Jumpsuits", new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(2926), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(2923), "Jackets & Coats", new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(2924), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(2921), "Dresses", new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(2922), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(2915), "Denim", new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(2919), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(2935), "Pants", new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(2936), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "Active", "Created", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(4855), "Vietnam", new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(4861), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(5118), "China", new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(5120), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(5122), "America", new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(5123), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Designers",
                columns: new[] { "ID", "Active", "Created", "Description", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 10, true, new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(8129), null, "ALLSAINTS", new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(8130), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(8127), null, "ASTR the Label", new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(8128), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(8124), null, "retrofete", new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(8125), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(8060), null, "SOLACE London", new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(8061), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(8056), null, "AFRM", new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(8057), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(8052), null, "Michael Costello", new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(8053), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(8050), null, "krisa", new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(8051), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(8045), null, "Sabina Musayev", new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(8048), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(7783), null, "ELLIATT", new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(7789), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(8058), null, "Amanda Uprichard", new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(8059), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Occations",
                columns: new[] { "ID", "Active", "Created", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(9857), "To A Special Event", new DateTime(2022, 6, 10, 14, 7, 2, 494, DateTimeKind.Local).AddTicks(9863), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(118), "On Vacation", new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(121), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(123), "For A Night Out", new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(124), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(126), "On The Weekend", new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(127), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "ID", "Active", "Created", "Name", "ParentID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 9, true, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(5675), "Sundresses", null, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(5676), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(5672), "Gingham", null, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(5673), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(5668), "Wrap", null, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(5669), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(5670), "Floral", null, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(5671), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(5663), "Bodycon", null, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(5664), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(5665), "Denim", null, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(5666), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(5660), "Bohemian", null, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(5661), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(5400), "Cocktail", null, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(5405), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "ID", "Active", "Created", "Name", "ParentID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[] { 2, true, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(5655), "One Shoulder", null, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(5658), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "Textures",
                columns: new[] { "ID", "Active", "Created", "Image", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6055), "Images/Texture/lilac.webp", "Lilac", new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6061), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 22, true, new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6679), "Images/Texture/taffy-pink.webp", "Taffy Pink", new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6680), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 21, true, new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6676), "Images/Texture/moonglow-white.webp", "Moonglow White", new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6677), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 20, true, new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6673), "Images/Texture/pink-orchid.webp", "Pink Orchid", new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6674), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 19, true, new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6671), "Images/Texture/olive.webp", "Olive", new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6672), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 18, true, new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6668), "Images/Texture/white.png", "White", new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6669), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 17, true, new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6665), "Images/Texture/green.webp", "Green", new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6666), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 16, true, new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6662), "Images/Texture/pink.webp", "Pink", new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6663), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 15, true, new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6660), "Images/Texture/cream.webp", "Cream", new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6661), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, true, new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6657), "Images/Texture/black-sequin.webp", "Black Sequin", new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6658), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, true, new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6648), "Images/Texture/abstract-neon-dot.webp", "Abstract Neon Dot", new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6649), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6646), "Images/Texture/baby-blue.webp", "Baby Blue", new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6647), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6643), "Images/Texture/taupe.webp", "Taupe", new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6644), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6640), "Images/Texture/candy.webp", "Candy", new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6641), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6636), "Images/Texture/rosa.webp", "Rosa", new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6637), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6634), "Images/Texture/black.webp", "Black", new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6635), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6631), "Images/Texture/multicolor-blue.webp", "Multicolor Blue", new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6632), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6628), "Images/Texture/blush.webp", "Blush", new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6629), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6625), "Images/Texture/blue.webp", "Blue", new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6626), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6617), "Images/Texture/marigold.webp", "Marigold", new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6621), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, true, new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6651), "Images/Texture/multi-watercolor.webp", "Multi Watercolor", new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6652), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, true, new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6654), "Images/Texture/white-sequin.webp", "White Sequin", new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(6655), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), 0, "54454096-fcf9-4284-bba0-39fae5e653b6", "user@shop.com", false, false, null, "USER@SHOP.COM", "USER", "AQAAAAEAACcQAAAAEG2fPXxvFmuXt+uVyL8ghR+CktotEJ2sOvyDxqz50uIB5d/X57AnNYVuGiPnwA2txw==", "0125454545", false, null, false, "user" },
                    { new Guid("50892ac9-ebe0-4c8d-f28e-08d9638e12dc"), 0, "fd628e22-f068-487f-85f8-f825cbd4d350", "user-bak@shop.com", false, false, null, "USER-BAK@SHOP.COM", "USER-BAK", "AQAAAAEAACcQAAAAEB5TbGLxEeCtDypQ5y8KvtYgk9EJdnwPJg7QOHKyARCfOTp9BLqk62YMF3AE9TgBQQ==", "0125454546", false, null, false, "user-bak" },
                    { new Guid("170ca4bc-ef9f-4de7-ae96-08d962dad25f"), 0, "81c6930d-75b0-4472-9eaa-9f0aed2666fe", "admin@shop.com", false, false, null, "ADMIN@SHOP.COM", "ADMIN", "AQAAAAEAACcQAAAAEKzxbx6nerdzve09qX3gIFU1tWThJeYZEfqtYk7SpgqJ/i1Z5RDT5vh5LvFmqbA+zg==", "0323265665", false, null, false, "admin" },
                    { new Guid("0dd37c3c-4694-429e-623b-08d962dbded7"), 0, "8a83ea09-504b-4b98-96b7-5296a2106077", "admin-bak@shop.com", false, false, null, "ADMIN-BAK@SHOP.COM", "ADMIN-BAK", "AQAAAAEAACcQAAAAEO+BvFshdUCNwc07gSYAQH91pllnG2O6iJ6dGVZ/PQX2ikJC5UBR3mHFXWWYyvWllw==", "0323265666", false, null, false, "admin-bak" }
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
                    { 11, true, 3, new DateTime(2022, 6, 10, 14, 7, 2, 496, DateTimeKind.Local).AddTicks(370), "Los Angeles", new DateTime(2022, 6, 10, 14, 7, 2, 496, DateTimeKind.Local).AddTicks(371), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, 3, new DateTime(2022, 6, 10, 14, 7, 2, 496, DateTimeKind.Local).AddTicks(367), "New York", new DateTime(2022, 6, 10, 14, 7, 2, 496, DateTimeKind.Local).AddTicks(368), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, 2, new DateTime(2022, 6, 10, 14, 7, 2, 496, DateTimeKind.Local).AddTicks(365), "Shanghai", new DateTime(2022, 6, 10, 14, 7, 2, 496, DateTimeKind.Local).AddTicks(366), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, 1, new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(9871), "Can Tho", new DateTime(2022, 6, 10, 14, 7, 2, 495, DateTimeKind.Local).AddTicks(9876), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, 2, new DateTime(2022, 6, 10, 14, 7, 2, 496, DateTimeKind.Local).AddTicks(360), "Ma Cau", new DateTime(2022, 6, 10, 14, 7, 2, 496, DateTimeKind.Local).AddTicks(361), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, 2, new DateTime(2022, 6, 10, 14, 7, 2, 496, DateTimeKind.Local).AddTicks(357), "Hong Kong", new DateTime(2022, 6, 10, 14, 7, 2, 496, DateTimeKind.Local).AddTicks(358), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, 1, new DateTime(2022, 6, 10, 14, 7, 2, 496, DateTimeKind.Local).AddTicks(355), "Ho Chi Minh", new DateTime(2022, 6, 10, 14, 7, 2, 496, DateTimeKind.Local).AddTicks(356), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, 1, new DateTime(2022, 6, 10, 14, 7, 2, 496, DateTimeKind.Local).AddTicks(345), "Da Nang", new DateTime(2022, 6, 10, 14, 7, 2, 496, DateTimeKind.Local).AddTicks(348), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, 1, new DateTime(2022, 6, 10, 14, 7, 2, 496, DateTimeKind.Local).AddTicks(350), "Hai Phong", new DateTime(2022, 6, 10, 14, 7, 2, 496, DateTimeKind.Local).AddTicks(351), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, 1, new DateTime(2022, 6, 10, 14, 7, 2, 496, DateTimeKind.Local).AddTicks(353), "Hanoi", new DateTime(2022, 6, 10, 14, 7, 2, 496, DateTimeKind.Local).AddTicks(354), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, 2, new DateTime(2022, 6, 10, 14, 7, 2, 496, DateTimeKind.Local).AddTicks(362), "Beijing", new DateTime(2022, 6, 10, 14, 7, 2, 496, DateTimeKind.Local).AddTicks(363), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "FavoriteDesigners",
                columns: new[] { "ID", "Active", "Created", "DesignerID", "Updated", "UserID", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 5, true, new DateTime(2022, 6, 10, 14, 7, 2, 496, DateTimeKind.Local).AddTicks(3785), 9, new DateTime(2022, 6, 10, 14, 7, 2, 496, DateTimeKind.Local).AddTicks(3786), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 6, 10, 14, 7, 2, 496, DateTimeKind.Local).AddTicks(3781), 7, new DateTime(2022, 6, 10, 14, 7, 2, 496, DateTimeKind.Local).AddTicks(3782), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 10, 14, 7, 2, 496, DateTimeKind.Local).AddTicks(3776), 5, new DateTime(2022, 6, 10, 14, 7, 2, 496, DateTimeKind.Local).AddTicks(3777), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 10, 14, 7, 2, 496, DateTimeKind.Local).AddTicks(3763), 3, new DateTime(2022, 6, 10, 14, 7, 2, 496, DateTimeKind.Local).AddTicks(3767), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 6, 10, 14, 7, 2, 496, DateTimeKind.Local).AddTicks(3050), 2, new DateTime(2022, 6, 10, 14, 7, 2, 496, DateTimeKind.Local).AddTicks(3056), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Active", "CategoryID", "Created", "Description", "DesignerID", "LengthState", "Name", "Price", "SleeveLengthState", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 11, true, 2, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(2804), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 10, 3, "Morgan Biker Jacket", 659.0, 0, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(2805), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, 3, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(2801), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 8, 2, "Katya Dress", 795.0, 2, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(2802), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, 3, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(2795), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 8, 3, "Margot Dress", 895.0, 2, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(2796), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, 3, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(2792), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 7, 0, "Elina Mini Dress", 527.0, 3, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(2793), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, 3, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(2789), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 6, 2, "x REVOLVE Samba Gown", 290.0, 3, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(2790), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, 3, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(2782), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 4, 2, "Jake Gown", 198.0, 2, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(2783), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, 3, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(2779), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 3, 0, "Drape Button Front Mini", 216.0, 1, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(2780), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, 3, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(2769), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 2, 3, "X REVOLVE Carry Mini Dress", 232.0, 0, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(2774), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, 3, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(278), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 1, 2, "X REVOLVE Cassini Dress", 187.0, 2, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(284), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, 3, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(2798), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 9, 2, "Valinda Dress", 128.0, 2, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(2799), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, 3, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(2786), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 5, 2, "Shailene Dress", 88.0, 0, new DateTime(2022, 6, 10, 14, 7, 2, 497, DateTimeKind.Local).AddTicks(2787), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductLines",
                columns: new[] { "ID", "Active", "Created", "ProductID", "Quantity", "TextureID", "TextureID1", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 7, true, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1380), 3, 99, 7, null, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1381), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1383), 3, 99, 8, null, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1384), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1385), 4, 99, 9, null, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1386), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1388), 4, 99, 10, null, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1389), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, true, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1390), 5, 99, 11, null, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1391), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, true, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1393), 5, 99, 12, null, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1394), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, true, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1395), 6, 99, 13, null, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1396), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 20, true, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1413), 9, 99, 20, null, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1414), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, true, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1398), 6, 99, 14, null, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1399), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 16, true, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1403), 7, 99, 16, null, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1404), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 17, true, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1405), 8, 99, 17, null, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1406), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 18, true, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1408), 8, 99, 18, null, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1409), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 21, true, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1415), 10, 99, 21, null, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1416), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 22, true, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1418), 10, 99, 22, null, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1419), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 19, true, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1410), 9, 99, 19, null, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1411), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 15, true, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1400), 7, 99, 15, null, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1401), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1378), 3, 99, 6, null, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1379), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 23, true, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1420), 11, 99, 6, null, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1421), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1364), 1, 99, 2, null, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1368), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1373), 2, 99, 4, null, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1374), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(722), 1, 99, 1, null, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(731), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1375), 2, 99, 5, null, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1376), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1370), 1, 99, 3, null, new DateTime(2022, 6, 10, 14, 7, 2, 498, DateTimeKind.Local).AddTicks(1371), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Product_Occations",
                columns: new[] { "ID", "OccationID", "ProductID" },
                values: new object[,]
                {
                    { 10, 3, 10 },
                    { 7, 2, 8 },
                    { 6, 2, 7 },
                    { 4, 1, 5 },
                    { 9, 3, 4 },
                    { 3, 1, 4 },
                    { 8, 3, 2 },
                    { 11, 4, 1 },
                    { 5, 2, 3 },
                    { 2, 1, 3 },
                    { 1, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Product_SubCategories",
                columns: new[] { "ID", "ProductID", "SubcategoryID" },
                values: new object[,]
                {
                    { 3, 2, 2 },
                    { 4, 2, 6 },
                    { 5, 2, 7 },
                    { 2, 1, 3 },
                    { 1, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "ID", "Active", "CityID", "Created", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 7, true, 6, new DateTime(2022, 6, 10, 14, 7, 2, 501, DateTimeKind.Local).AddTicks(532), "Hong Kong Island", new DateTime(2022, 6, 10, 14, 7, 2, 501, DateTimeKind.Local).AddTicks(533), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, 6, new DateTime(2022, 6, 10, 14, 7, 2, 501, DateTimeKind.Local).AddTicks(536), "Kowloon West", new DateTime(2022, 6, 10, 14, 7, 2, 501, DateTimeKind.Local).AddTicks(537), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, 2, new DateTime(2022, 6, 10, 14, 7, 2, 501, DateTimeKind.Local).AddTicks(529), "Thanh Khe", new DateTime(2022, 6, 10, 14, 7, 2, 501, DateTimeKind.Local).AddTicks(530), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "ID", "Active", "CityID", "Created", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 5, true, 2, new DateTime(2022, 6, 10, 14, 7, 2, 501, DateTimeKind.Local).AddTicks(527), "Cam Le", new DateTime(2022, 6, 10, 14, 7, 2, 501, DateTimeKind.Local).AddTicks(528), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, 2, new DateTime(2022, 6, 10, 14, 7, 2, 501, DateTimeKind.Local).AddTicks(524), "Hai Chau", new DateTime(2022, 6, 10, 14, 7, 2, 501, DateTimeKind.Local).AddTicks(525), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, 1, new DateTime(2022, 6, 10, 14, 7, 2, 501, DateTimeKind.Local).AddTicks(522), "O Mon", new DateTime(2022, 6, 10, 14, 7, 2, 501, DateTimeKind.Local).AddTicks(523), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, 1, new DateTime(2022, 6, 10, 14, 7, 2, 501, DateTimeKind.Local).AddTicks(515), "Binh Thuy", new DateTime(2022, 6, 10, 14, 7, 2, 501, DateTimeKind.Local).AddTicks(519), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, 6, new DateTime(2022, 6, 10, 14, 7, 2, 501, DateTimeKind.Local).AddTicks(534), "New Territories East", new DateTime(2022, 6, 10, 14, 7, 2, 501, DateTimeKind.Local).AddTicks(535), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, 1, new DateTime(2022, 6, 10, 14, 7, 2, 501, DateTimeKind.Local).AddTicks(55), "Ninh Kieu", new DateTime(2022, 6, 10, 14, 7, 2, 501, DateTimeKind.Local).AddTicks(63), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ID", "Active", "Created", "Image", "ProductLineID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8018), "Images/Product/Product1/Line1/1.webp", 1, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8034), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 58, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8767), "Images/Product/Product8/Line2/1.webp", 18, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8768), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 57, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8764), "Images/Product/Product8/Line1/4.webp", 17, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8765), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 56, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8762), "Images/Product/Product8/Line1/3.webp", 17, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8763), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 55, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8759), "Images/Product/Product8/Line1/2.webp", 17, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8760), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 54, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8756), "Images/Product/Product8/Line1/1.webp", 17, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8757), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 53, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8753), "Images/Product/Product7/Line2/3.webp", 16, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8754), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 52, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8751), "Images/Product/Product7/Line2/2.webp", 16, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8752), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 59, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8770), "Images/Product/Product8/Line2/2.webp", 18, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8771), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 51, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8748), "Images/Product/Product7/Line2/1.jpg", 16, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8749), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 49, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8742), "Images/Product/Product7/Line1/2.webp", 15, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8743), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 48, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8740), "Images/Product/Product7/Line1/1.webp", 15, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8741), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 47, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8737), "Images/Product/Product6/Line2/4.webp", 14, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8738), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 46, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8734), "Images/Product/Product6/Line2/3.webp", 14, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8735), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 45, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8731), "Images/Product/Product6/Line2/2.webp", 14, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8732), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 44, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8729), "Images/Product/Product6/Line2/1.webp", 14, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8730), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 43, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8726), "Images/Product/Product6/Line1/5.webp", 13, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8727), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 50, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8745), "Images/Product/Product7/Line1/3.webp", 15, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8746), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 60, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8773), "Images/Product/Product8/Line2/3.webp", 18, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8774), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 61, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8775), "Images/Product/Product8/Line2/4.webp", 18, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8776), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 62, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8778), "Images/Product/Product8/Line2/5.jpg", 18, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8779), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 79, true, new DateTime(2022, 6, 10, 14, 7, 2, 500, DateTimeKind.Local).AddTicks(1158), "Images/Product/Product11/Line1/3.webp", 23, new DateTime(2022, 6, 10, 14, 7, 2, 500, DateTimeKind.Local).AddTicks(1159), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 78, true, new DateTime(2022, 6, 10, 14, 7, 2, 500, DateTimeKind.Local).AddTicks(1154), "Images/Product/Product11/Line1/2.webp", 23, new DateTime(2022, 6, 10, 14, 7, 2, 500, DateTimeKind.Local).AddTicks(1156), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 77, true, new DateTime(2022, 6, 10, 14, 7, 2, 500, DateTimeKind.Local).AddTicks(1143), "Images/Product/Product11/Line1/1.webp", 23, new DateTime(2022, 6, 10, 14, 7, 2, 500, DateTimeKind.Local).AddTicks(1148), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 68, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8831), "Images/Product/Product9/Line2/3.webp", 20, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8832), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 67, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8791), "Images/Product/Product9/Line2/2.webp", 20, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8792), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 66, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8789), "Images/Product/Product9/Line2/1.webp", 20, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8790), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 65, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8786), "Images/Product/Product9/Line1/3.webp", 19, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8787), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 64, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8783), "Images/Product/Product9/Line1/2.webp", 19, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8784), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 63, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8781), "Images/Product/Product9/Line1/1.webp", 19, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8782), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 76, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8853), "Images/Product/Product10/Line2/4.webp", 22, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8854), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 75, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8850), "Images/Product/Product10/Line2/3.webp", 22, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8851), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 74, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8848), "Images/Product/Product10/Line2/2.webp", 22, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8849), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 73, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8845), "Images/Product/Product10/Line2/1.webp", 22, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8846), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 72, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8842), "Images/Product/Product10/Line1/4.webp", 21, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8843), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 71, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8839), "Images/Product/Product10/Line1/3.webp", 21, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8840), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 70, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8837), "Images/Product/Product10/Line1/2.webp", 21, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8838), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 69, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8834), "Images/Product/Product10/Line1/1.webp", 21, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8835), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 42, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8723), "Images/Product/Product6/Line1/4.webp", 13, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8724), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 80, true, new DateTime(2022, 6, 10, 14, 7, 2, 500, DateTimeKind.Local).AddTicks(1161), "Images/Product/Product11/Line1/4.webp", 23, new DateTime(2022, 6, 10, 14, 7, 2, 500, DateTimeKind.Local).AddTicks(1162), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 41, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8720), "Images/Product/Product6/Line1/3.webp", 13, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8721), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 39, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8715), "Images/Product/Product6/Line1/1.webp", 13, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8716), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ID", "Active", "Created", "Image", "ProductLineID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 17, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8602), "Images/Product/Product2/Line2/4.webp", 5, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8603), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 16, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8599), "Images/Product/Product2/Line2/3.webp", 5, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8600), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 15, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8596), "Images/Product/Product2/Line2/2.webp", 5, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8597), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8593), "Images/Product/Product2/Line2/1.webp", 5, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8594), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8590), "Images/Product/Product2/Line1/4.jpg", 4, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8591), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8587), "Images/Product/Product2/Line1/3.webp", 4, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8588), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8584), "Images/Product/Product2/Line1/2.webp", 4, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8585), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 18, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8604), "Images/Product/Product3/Line1/1.webp", 6, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8605), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8582), "Images/Product/Product2/Line1/1.webp", 4, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8583), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8576), "Images/Product/Product1/Line3/2.webp", 3, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8577), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8574), "Images/Product/Product1/Line3/1.webp", 3, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8575), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8571), "Images/Product/Product1/Line2/3.webp", 2, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8572), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8568), "Images/Product/Product1/Line2/2.webp", 2, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8569), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8566), "Images/Product/Product1/Line2/1.webp", 2, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8567), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8563), "Images/Product/Product1/Line1/3.webp", 1, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8564), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8556), "Images/Product/Product1/Line1/2.webp", 1, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8559), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8579), "Images/Product/Product1/Line3/3.webp", 3, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8580), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 19, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8607), "Images/Product/Product3/Line1/2.webp", 6, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8608), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 20, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8610), "Images/Product/Product3/Line1/3.webp", 6, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8611), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 21, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8612), "Images/Product/Product3/Line2/1.webp", 7, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8613), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 38, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8712), "Images/Product/Product5/Line2/3.webp", 12, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8713), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 37, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8709), "Images/Product/Product5/Line2/2.webp", 12, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8710), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 36, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8707), "Images/Product/Product5/Line2/1.webp", 12, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8708), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 35, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8704), "Images/Product/Product5/Line1/3.webp", 11, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8705), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 34, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8701), "Images/Product/Product5/Line1/2.webp", 11, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8702), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 33, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8698), "Images/Product/Product5/Line1/1.webp", 11, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8699), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 32, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8696), "Images/Product/Product4/Line2/3.webp", 10, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8697), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 31, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8693), "Images/Product/Product4/Line2/2.webp", 10, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8694), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 30, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8690), "Images/Product/Product4/Line2/1.webp", 10, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8691), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 29, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8688), "Images/Product/Product4/Line1/3.webp", 9, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8689), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 28, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8685), "Images/Product/Product4/Line1/2.webp", 9, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8686), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 27, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8682), "Images/Product/Product4/Line1/1.webp", 9, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8683), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 26, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8679), "Images/Product/Product3/Line3/3.webp", 8, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8680), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 25, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8676), "Images/Product/Product3/Line3/2.webp", 8, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8677), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 24, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8620), "Images/Product/Product3/Line3/1.webp", 8, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8621), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 23, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8618), "Images/Product/Product3/Line2/3.webp", 7, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8619), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 22, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8615), "Images/Product/Product3/Line2/2.webp", 7, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8616), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 40, true, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8718), "Images/Product/Product6/Line1/2.webp", 13, new DateTime(2022, 6, 10, 14, 7, 2, 499, DateTimeKind.Local).AddTicks(8719), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 81, true, new DateTime(2022, 6, 10, 14, 7, 2, 500, DateTimeKind.Local).AddTicks(1163), "Images/Product/Product11/Line1/5.webp", 23, new DateTime(2022, 6, 10, 14, 7, 2, 500, DateTimeKind.Local).AddTicks(1164), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
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
