using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lulus.Data.Migrations
{
    public partial class update4 : Migration
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
                    { new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"), "731518e6-9f34-41f7-8bd1-bc116c18fc80", "Customer", "CUSTOMER" },
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "2342561b-62fb-4c7c-a0a0-9c2858cae297", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Active", "Created", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 15, true, new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(4678), "Tops", new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(4679), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, true, new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(4672), "Swimsuits & Cover-Ups", new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(4675), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, true, new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(4667), "Sweaters & Knits", new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(4668), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, true, new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(4660), "Skirts", new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(4662), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, true, new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(4655), "Shorts", new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(4658), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(4649), "Rompers", new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(4652), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 6, 11, 16, 3, 6, 123, DateTimeKind.Local).AddTicks(4162), "Activewear", new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(2777), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(4638), "Loungewear", new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(4641), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(4643), "Pants", new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(4645), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(4608), "Dresses", new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(4611), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(4614), "Jackets & Coats", new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(4616), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(4586), "Denim", new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(4604), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(4624), "Leather", new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(4626), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(4629), "Lingerie & Sleepwear", new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(4634), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(4620), "Jumpsuits", new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(4622), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "Active", "Created", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(7956), "Vietnam", new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(7968), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(8420), "China", new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(8424), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(8426), "America", new DateTime(2022, 6, 11, 16, 3, 6, 124, DateTimeKind.Local).AddTicks(8427), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Designers",
                columns: new[] { "ID", "Active", "Created", "Description", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 14, true, new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3692), null, "SPRWMN", new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3693), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 22, true, new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3711), null, "Cult Gaia", new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3712), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 21, true, new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3709), null, "Brochu Walker", new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3710), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 20, true, new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3706), null, "COTTON CITIZEN", new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3707), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 19, true, new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3704), null, "Lovers and Friends", new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3705), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 18, true, new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3701), null, "Nookie", new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3702), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 17, true, new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3699), null, "Enza Costa", new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3700), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 16, true, new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3697), null, "Indah", new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3698), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 15, true, new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3694), null, "Understated Leather", new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3695), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 23, true, new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3714), null, "VALENTINA SHAH", new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3715), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, true, new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3687), null, "Helmut Lang", new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3688), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, true, new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3684), null, "LAMARQUE", new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3685), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3186), null, "ELLIATT", new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3197), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, true, new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3689), null, "LPA", new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3690), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3665), null, "krisa", new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3666), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3667), null, "Michael Costello", new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3668), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3670), null, "AFRM", new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3671), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3658), null, "Sabina Musayev", new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3662), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3674), null, "SOLACE London", new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3675), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3677), null, "retrofete", new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3678), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3679), null, "ASTR the Label", new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3680), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3682), null, "ALLSAINTS", new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3683), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Designers",
                columns: new[] { "ID", "Active", "Created", "Description", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[] { 6, true, new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3672), null, "Amanda Uprichard", new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(3673), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "Occations",
                columns: new[] { "ID", "Active", "Created", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(5967), "To A Special Event", new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(5973), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(6404), "On Vacation", new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(6407), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(6410), "For A Night Out", new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(6411), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(6412), "On The Weekend", new DateTime(2022, 6, 11, 16, 3, 6, 125, DateTimeKind.Local).AddTicks(6413), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "ID", "Active", "Created", "Name", "ParentID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 9, true, new DateTime(2022, 6, 11, 16, 3, 6, 128, DateTimeKind.Local).AddTicks(2139), "Sundresses", null, new DateTime(2022, 6, 11, 16, 3, 6, 128, DateTimeKind.Local).AddTicks(2140), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 6, 11, 16, 3, 6, 128, DateTimeKind.Local).AddTicks(2137), "Gingham", null, new DateTime(2022, 6, 11, 16, 3, 6, 128, DateTimeKind.Local).AddTicks(2138), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 6, 11, 16, 3, 6, 128, DateTimeKind.Local).AddTicks(2132), "Wrap", null, new DateTime(2022, 6, 11, 16, 3, 6, 128, DateTimeKind.Local).AddTicks(2133), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 6, 11, 16, 3, 6, 128, DateTimeKind.Local).AddTicks(2134), "Floral", null, new DateTime(2022, 6, 11, 16, 3, 6, 128, DateTimeKind.Local).AddTicks(2135), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 6, 11, 16, 3, 6, 128, DateTimeKind.Local).AddTicks(2127), "Bodycon", null, new DateTime(2022, 6, 11, 16, 3, 6, 128, DateTimeKind.Local).AddTicks(2128), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 6, 11, 16, 3, 6, 128, DateTimeKind.Local).AddTicks(1681), "Cocktail", null, new DateTime(2022, 6, 11, 16, 3, 6, 128, DateTimeKind.Local).AddTicks(1688), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 6, 11, 16, 3, 6, 128, DateTimeKind.Local).AddTicks(2129), "Denim", null, new DateTime(2022, 6, 11, 16, 3, 6, 128, DateTimeKind.Local).AddTicks(2130), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 11, 16, 3, 6, 128, DateTimeKind.Local).AddTicks(2124), "Bohemian", null, new DateTime(2022, 6, 11, 16, 3, 6, 128, DateTimeKind.Local).AddTicks(2125), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 11, 16, 3, 6, 128, DateTimeKind.Local).AddTicks(2116), "One Shoulder", null, new DateTime(2022, 6, 11, 16, 3, 6, 128, DateTimeKind.Local).AddTicks(2122), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Textures",
                columns: new[] { "ID", "Active", "Created", "Image", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 44, true, new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(279), "Images/Texture/chocolate.webp", "Chocolate", new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(280), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 26, true, new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6484), "Images/Texture/faded-jean.webp", "Faded Jean", new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6485), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 27, true, new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6486), "Images/Texture/bone.webp", "Bone", new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6487), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 28, true, new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6489), "Images/Texture/off-white.webp", "Off White", new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6490), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 29, true, new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6492), "Images/Texture/dust.webp", "Dust", new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6493), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 30, true, new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6495), "Images/Texture/dusty-pink.webp", "Dusty Pink", new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6496), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 31, true, new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6497), "Images/Texture/sand.webp", "Sand", new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6498), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 32, true, new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6500), "Images/Texture/seseme.webp", "Seseme", new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6501), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 33, true, new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(203), "Images/Texture/namibia.webp", "Namibia", new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(209), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 35, true, new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(217), "Images/Texture/dark-nude.webp", "Dark Nude", new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(218), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 25, true, new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6481), "Images/Texture/red.webp", "Red", new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6482), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 37, true, new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(258), "Images/Texture/ivory.webp", "Ivory", new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(259), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 38, true, new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(261), "Images/Texture/rosebloom-pink.webp", "Rosebloom Pink", new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(262), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 39, true, new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(264), "Images/Texture/blue2.webp", "Blue", new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(265), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 40, true, new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(267), "Images/Texture/washed-chambray.webp", "Washed Chambray", new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(268), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 41, true, new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(270), "Images/Texture/washed-black.webp", "Washed Black", new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(271), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 42, true, new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(273), "Images/Texture/aloe.webp", "Aloe", new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(274), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 43, true, new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(276), "Images/Texture/pink2.webp", "Pink", new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(277), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 34, true, new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(214), "Images/Texture/citron.webp", "Citron", new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(215), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 36, true, new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(220), "Images/Texture/bronze.webp", "Bronze", new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(221), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 24, true, new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6478), "Images/Texture/tan.webp", "Tan", new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6479), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 22, true, new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6472), "Images/Texture/taffy-pink.webp", "Taffy Pink", new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6473), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(5488), "Images/Texture/lilac.webp", "Lilac", new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(5502), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6364), "Images/Texture/marigold.webp", "Marigold", new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6368), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6420), "Images/Texture/blush.webp", "Blush", new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6421), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6424), "Images/Texture/multicolor-blue.webp", "Multicolor Blue", new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6425), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6427), "Images/Texture/black.webp", "Black", new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6428), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6429), "Images/Texture/rosa.webp", "Rosa", new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6430), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Textures",
                columns: new[] { "ID", "Active", "Created", "Image", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 8, true, new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6432), "Images/Texture/candy.webp", "Candy", new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6433), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 23, true, new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6475), "Images/Texture/acid-wash-black.webp", "Acid Wash Black", new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6476), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6438), "Images/Texture/baby-blue.webp", "Baby Blue", new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6439), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, true, new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6441), "Images/Texture/abstract-neon-dot.webp", "Abstract Neon Dot", new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6442), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6435), "Images/Texture/taupe.webp", "Taupe", new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6436), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, true, new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6447), "Images/Texture/white-sequin.webp", "White Sequin", new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6448), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, true, new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6450), "Images/Texture/black-sequin.webp", "Black Sequin", new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6451), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 15, true, new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6452), "Images/Texture/cream.webp", "Cream", new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6453), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 16, true, new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6455), "Images/Texture/pink.webp", "Pink", new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6456), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 17, true, new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6458), "Images/Texture/green.webp", "Green", new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6459), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 18, true, new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6461), "Images/Texture/white.png", "White", new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6462), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 19, true, new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6464), "Images/Texture/olive.webp", "Olive", new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6465), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 20, true, new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6466), "Images/Texture/pink-orchid.webp", "Pink Orchid", new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6467), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 21, true, new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6469), "Images/Texture/moonglow-white.webp", "Moonglow White", new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6470), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, true, new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6444), "Images/Texture/multi-watercolor.webp", "Multi Watercolor", new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6445), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6372), "Images/Texture/blue.webp", "Blue", new DateTime(2022, 6, 11, 16, 3, 6, 126, DateTimeKind.Local).AddTicks(6373), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), 0, "a2cc160c-8372-4029-8c06-3af91438cbd9", "user@shop.com", false, false, null, "USER@SHOP.COM", "USER", "AQAAAAEAACcQAAAAENlNk6r27pBlQpm/6j6NjxBtGsdqpJomqBVKgNKkZZaQZxD/KA2Jnz3u2jhTgWZr6Q==", "0125454545", false, null, false, "user" },
                    { new Guid("50892ac9-ebe0-4c8d-f28e-08d9638e12dc"), 0, "607201cd-5852-42e5-8bf7-ae3434f0917b", "user-bak@shop.com", false, false, null, "USER-BAK@SHOP.COM", "USER-BAK", "AQAAAAEAACcQAAAAEGb+330T22QbkCshI3W+jZmdCh6VhDHYBs9LygXuz5fmbiYch3Nm1ZUNvCMiJHyhdw==", "0125454546", false, null, false, "user-bak" },
                    { new Guid("170ca4bc-ef9f-4de7-ae96-08d962dad25f"), 0, "9fc8c89b-750a-4e31-a5b0-1832101dca54", "admin@shop.com", false, false, null, "ADMIN@SHOP.COM", "ADMIN", "AQAAAAEAACcQAAAAEE9K2d8dBQh6thnWaMaYsGIywjzBm24E4yubxa6eUmvWHP02d3pMZuY2yYX/3BSfVQ==", "0323265665", false, null, false, "admin" },
                    { new Guid("0dd37c3c-4694-429e-623b-08d962dbded7"), 0, "33b70111-8d00-43fd-b871-27932d1cd716", "admin-bak@shop.com", false, false, null, "ADMIN-BAK@SHOP.COM", "ADMIN-BAK", "AQAAAAEAACcQAAAAEINN2wIM78RpmshExc93pPvw33k3QZ0sbse7+MbooIaqwPVzBMb6Yj3+kpM58ijjWA==", "0323265666", false, null, false, "admin-bak" }
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
                    { 11, true, 3, new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(4758), "Los Angeles", new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(4759), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, 3, new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(4756), "New York", new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(4757), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, 2, new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(4753), "Shanghai", new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(4754), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, 1, new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(3902), "Can Tho", new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(3907), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, 2, new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(4748), "Ma Cau", new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(4749), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, 2, new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(4746), "Hong Kong", new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(4747), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, 1, new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(4743), "Ho Chi Minh", new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(4744), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, 1, new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(4731), "Da Nang", new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(4736), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, 1, new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(4738), "Hai Phong", new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(4739), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, 2, new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(4751), "Beijing", new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(4752), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, 1, new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(4741), "Hanoi", new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(4742), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "FavoriteDesigners",
                columns: new[] { "ID", "Active", "Created", "DesignerID", "Updated", "UserID", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 5, true, new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(8870), 9, new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(8871), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(8866), 7, new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(8867), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(8861), 5, new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(8862), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(8846), 3, new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(8851), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(7892), 2, new DateTime(2022, 6, 11, 16, 3, 6, 127, DateTimeKind.Local).AddTicks(7898), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Active", "CategoryID", "Created", "Description", "DesignerID", "LengthState", "Name", "Price", "SleeveLengthState", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 21, true, 12, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3563), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 16, 2, "Gigi Maxi Skirt", 101.0, 2, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3564), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 23, true, 12, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3569), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 17, 2, "Stretch Silk Knit Essential Skirt", 145.0, 2, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3570), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 24, true, 12, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3572), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 18, 2, "Alyssa Chain Skirt", 199.0, 2, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3573), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 29, true, 12, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3588), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 23, 0, "Stella Skirt", 455.0, 2, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3589), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 25, true, 12, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3575), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 19, 0, "Carlita Skirt", 138.0, 2, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3576), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 26, true, 12, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3579), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 20, 2, "Capri Cut Out Midi Skirt", 195.0, 2, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3580), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 27, true, 12, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3582), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 21, 2, "Havana Skirt", 278.0, 2, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3583), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 28, true, 12, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3585), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 22, 2, "Samira Skirt", 258.0, 2, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3586), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 30, true, 12, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3591), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 18, 2, "Aria Skirt", 169.0, 2, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3592), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 18, true, 6, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3553), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 15, 0, "X REVOLVE Paris Texas Full Skirt", 242.0, 0, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3554), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, true, 6, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3541), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 12, 0, "Slit Leather Pant", 995.0, 0, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3542), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 15, true, 6, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3544), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 13, 0, "Carmella Leather Corset", 209.0, 2, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3545), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, 3, new DateTime(2022, 6, 11, 16, 3, 6, 129, DateTimeKind.Local).AddTicks(8551), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 1, 2, "X REVOLVE Cassini Dress", 187.0, 2, new DateTime(2022, 6, 11, 16, 3, 6, 129, DateTimeKind.Local).AddTicks(8573), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, 3, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3482), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 2, 3, "X REVOLVE Carry Mini Dress", 232.0, 0, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3497), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, 3, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3504), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 3, 0, "Drape Button Front Mini", 216.0, 1, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3505), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, 3, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3507), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 4, 2, "Jake Gown", 198.0, 2, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3508), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, 3, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3510), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 5, 2, "Shailene Dress", 88.0, 0, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3511), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, 3, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3514), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 6, 2, "x REVOLVE Samba Gown", 290.0, 3, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3516), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 22, true, 12, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3566), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 6, 0, "x REVOLVE Mini Ludlow Slit Skirt", 207.0, 2, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3567), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 17, true, 6, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3550), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 14, 0, "Ankle Legging With Zipper", 1250.0, 0, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3551), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, 3, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3518), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 7, 0, "Elina Mini Dress", 527.0, 3, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3519), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, 3, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3528), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 8, 2, "Katya Dress", 795.0, 2, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3529), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Active", "CategoryID", "Created", "Description", "DesignerID", "LengthState", "Name", "Price", "SleeveLengthState", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 9, true, 3, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3524), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 9, 2, "Valinda Dress", 128.0, 2, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3525), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, true, 6, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3531), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 10, 3, "Morgan Biker Jacket", 659.0, 0, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3532), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, true, 6, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3534), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 11, 0, "x REVOLVE Dylan Jacket", 295.0, 0, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3535), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 16, true, 6, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3547), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 11, 2, "Ilonna Dress", 693.0, 0, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3548), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 19, true, 6, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3556), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 11, 0, "X REVOLVE Paris Texas Full Skirt", 242.0, 2, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3557), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 20, true, 6, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3560), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 11, 0, "Davina Leather Corset", 319.0, 0, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3561), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, 3, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3521), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 8, 3, "Margot Dress", 895.0, 2, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3522), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, true, 6, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3537), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 11, 0, "Donna Jacket", 546.0, 0, new DateTime(2022, 6, 11, 16, 3, 6, 130, DateTimeKind.Local).AddTicks(3538), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductLines",
                columns: new[] { "ID", "Active", "Created", "ProductID", "Quantity", "TextureID", "TextureID1", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 22, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4434), 10, 99, 22, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4435), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 33, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4461), 15, 99, 15, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4462), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 32, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4459), 14, 99, 6, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4460), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 43, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4486), 20, 99, 32, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4487), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 42, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4484), 20, 99, 6, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4485), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 41, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4481), 19, 99, 6, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4482), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 40, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4479), 19, 99, 31, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4480), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 35, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4466), 16, 99, 27, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4467), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 34, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4464), 16, 99, 6, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4465), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 36, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4469), 17, 99, 28, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4470), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 31, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4456), 13, 99, 26, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4457), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 29, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4451), 13, 99, 6, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4452), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 28, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4449), 12, 99, 25, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4450), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 27, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4446), 12, 99, 24, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4447), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 26, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4444), 12, 99, 18, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4445), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 25, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4441), 12, 99, 23, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4442), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 24, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4439), 12, 99, 6, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4440), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 23, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4436), 11, 99, 6, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4437), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 20, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4429), 9, 99, 20, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4430), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 30, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4454), 13, 99, 18, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4455), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 37, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4471), 17, 99, 6, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4472), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 38, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4474), 18, 99, 29, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4475), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 39, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4476), 18, 99, 30, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4477), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 61, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9409), 28, 99, 42, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9410), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 60, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9406), 28, 99, 28, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9407), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 59, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9404), 27, 99, 41, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9405), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 58, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9400), 27, 99, 40, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9401), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 57, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9398), 26, 99, 18, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9399), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 56, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9395), 26, 99, 6, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9396), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 55, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9392), 25, 99, 39, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9393), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 54, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9390), 25, 99, 38, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9391), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 66, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9422), 30, 99, 25, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9423), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 65, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9419), 30, 99, 44, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9420), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 64, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9417), 30, 99, 6, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9418), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 53, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9387), 24, 99, 6, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9388), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 52, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9385), 24, 99, 37, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9386), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 51, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9382), 23, 99, 18, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9383), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 50, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9380), 23, 99, 36, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9381), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 49, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9377), 23, 99, 6, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9378), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 48, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9375), 23, 99, 35, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9376), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 45, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9328), 21, 99, 33, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9329), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 44, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9319), 21, 99, 18, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9325), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductLines",
                columns: new[] { "ID", "Active", "Created", "ProductID", "Quantity", "TextureID", "TextureID1", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 19, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4426), 9, 99, 19, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4427), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 62, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9412), 28, 99, 6, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9413), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 63, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9414), 29, 99, 43, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9415), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4393), 3, 99, 6, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4394), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4396), 3, 99, 7, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4397), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4399), 3, 99, 8, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4400), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4391), 2, 99, 5, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4392), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4388), 2, 99, 4, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4389), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4401), 4, 99, 9, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4402), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4404), 4, 99, 10, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4405), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4406), 5, 99, 11, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4407), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4409), 5, 99, 12, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4410), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 21, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4431), 10, 99, 21, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4432), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4386), 1, 99, 3, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4387), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4414), 6, 99, 14, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4415), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 46, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9330), 22, 99, 34, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9331), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 47, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9371), 22, 99, 27, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(9373), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 15, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4416), 7, 99, 15, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4417), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 16, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4419), 7, 99, 16, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4420), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4377), 1, 99, 2, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4383), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 17, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4421), 8, 99, 17, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4422), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 18, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4424), 8, 99, 18, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4425), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(3170), 1, 99, 1, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(3182), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, true, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4411), 6, 99, 13, null, new DateTime(2022, 6, 11, 16, 3, 6, 131, DateTimeKind.Local).AddTicks(4412), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Product_Occations",
                columns: new[] { "ID", "OccationID", "ProductID" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 11, 4, 1 },
                    { 8, 3, 2 },
                    { 7, 2, 8 },
                    { 10, 3, 10 },
                    { 2, 1, 3 },
                    { 5, 2, 3 },
                    { 6, 2, 7 },
                    { 4, 1, 5 },
                    { 3, 1, 4 },
                    { 9, 3, 4 }
                });

            migrationBuilder.InsertData(
                table: "Product_SubCategories",
                columns: new[] { "ID", "ProductID", "SubcategoryID" },
                values: new object[,]
                {
                    { 4, 2, 6 },
                    { 3, 2, 2 },
                    { 2, 1, 3 },
                    { 5, 2, 7 },
                    { 1, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "ID", "Active", "CityID", "Created", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 9, true, 6, new DateTime(2022, 6, 11, 16, 3, 6, 139, DateTimeKind.Local).AddTicks(27), "Kowloon West", new DateTime(2022, 6, 11, 16, 3, 6, 139, DateTimeKind.Local).AddTicks(28), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, 6, new DateTime(2022, 6, 11, 16, 3, 6, 139, DateTimeKind.Local).AddTicks(24), "New Territories East", new DateTime(2022, 6, 11, 16, 3, 6, 139, DateTimeKind.Local).AddTicks(25), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "ID", "Active", "CityID", "Created", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 7, true, 6, new DateTime(2022, 6, 11, 16, 3, 6, 139, DateTimeKind.Local).AddTicks(22), "Hong Kong Island", new DateTime(2022, 6, 11, 16, 3, 6, 139, DateTimeKind.Local).AddTicks(23), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, 2, new DateTime(2022, 6, 11, 16, 3, 6, 139, DateTimeKind.Local).AddTicks(19), "Thanh Khe", new DateTime(2022, 6, 11, 16, 3, 6, 139, DateTimeKind.Local).AddTicks(20), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, 2, new DateTime(2022, 6, 11, 16, 3, 6, 139, DateTimeKind.Local).AddTicks(17), "Cam Le", new DateTime(2022, 6, 11, 16, 3, 6, 139, DateTimeKind.Local).AddTicks(18), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, 2, new DateTime(2022, 6, 11, 16, 3, 6, 139, DateTimeKind.Local).AddTicks(14), "Hai Chau", new DateTime(2022, 6, 11, 16, 3, 6, 139, DateTimeKind.Local).AddTicks(15), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, 1, new DateTime(2022, 6, 11, 16, 3, 6, 139, DateTimeKind.Local).AddTicks(12), "O Mon", new DateTime(2022, 6, 11, 16, 3, 6, 139, DateTimeKind.Local).AddTicks(13), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, 1, new DateTime(2022, 6, 11, 16, 3, 6, 139, DateTimeKind.Local).AddTicks(3), "Binh Thuy", new DateTime(2022, 6, 11, 16, 3, 6, 139, DateTimeKind.Local).AddTicks(9), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, 1, new DateTime(2022, 6, 11, 16, 3, 6, 138, DateTimeKind.Local).AddTicks(9171), "Ninh Kieu", new DateTime(2022, 6, 11, 16, 3, 6, 138, DateTimeKind.Local).AddTicks(9191), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ID", "Active", "Created", "Image", "ProductLineID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(6432), "Images/Product/Product1/Line1/1.webp", 1, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(6446), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 142, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5933), "Images/Product/Product18/Line1/4.webp", 38, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5934), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 143, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5936), "Images/Product/Product18/Line1/5.webp", 38, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5937), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 144, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5938), "Images/Product/Product18/Line2/1.webp", 39, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5939), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 145, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5941), "Images/Product/Product18/Line2/2.webp", 39, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5942), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 146, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5944), "Images/Product/Product18/Line2/3.webp", 39, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5945), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 147, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5947), "Images/Product/Product18/Line2/4.webp", 39, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5948), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 165, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6370), "Images/Product/Product21/Line1/1.webp", 44, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6391), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 166, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6400), "Images/Product/Product21/Line1/2.webp", 44, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6401), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 167, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6403), "Images/Product/Product21/Line1/3.webp", 44, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6404), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 168, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6405), "Images/Product/Product21/Line1/4.webp", 44, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6406), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 169, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6408), "Images/Product/Product21/Line2/1.webp", 45, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6409), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 170, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6411), "Images/Product/Product21/Line2/2.webp", 45, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6412), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 171, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6414), "Images/Product/Product21/Line2/3.webp", 45, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6415), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 172, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6417), "Images/Product/Product21/Line2/4.webp", 45, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6418), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 181, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6442), "Images/Product/Product23/Line1/1.webp", 48, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6443), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 182, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6445), "Images/Product/Product23/Line1/2.webp", 48, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6446), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 183, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6447), "Images/Product/Product23/Line1/3.webp", 48, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6448), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 184, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6450), "Images/Product/Product23/Line1/4.webp", 48, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6451), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 185, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6453), "Images/Product/Product23/Line2/1.webp", 49, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6454), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 186, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6455), "Images/Product/Product23/Line2/2.webp", 49, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6456), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 187, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6458), "Images/Product/Product23/Line2/3.webp", 49, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6459), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 188, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6461), "Images/Product/Product23/Line2/4.webp", 49, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6462), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 189, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6566), "Images/Product/Product23/Line2/5.webp", 49, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6567), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 190, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6570), "Images/Product/Product23/Line3/1.webp", 50, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6571), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 191, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6574), "Images/Product/Product23/Line3/2.webp", 50, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6575), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 192, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6577), "Images/Product/Product23/Line3/3.webp", 50, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6578), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 193, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6580), "Images/Product/Product23/Line3/4.webp", 50, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6580), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 194, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6582), "Images/Product/Product23/Line3/5.webp", 50, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6583), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 195, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6585), "Images/Product/Product23/Line4/1.webp", 51, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6586), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 141, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5930), "Images/Product/Product18/Line1/3.webp", 38, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5931), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 196, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6588), "Images/Product/Product23/Line4/2.webp", 51, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6589), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 140, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5927), "Images/Product/Product18/Line1/2.webp", 38, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5928), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 138, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5922), "Images/Product/Product17/Line2/4.webp", 37, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5923), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 151, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5958), "Images/Product/Product19/Line1/4.webp", 40, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5959), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 152, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5961), "Images/Product/Product19/Line2/1.webp", 41, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5962), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 153, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5963), "Images/Product/Product19/Line2/2.webp", 41, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5964), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 154, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5966), "Images/Product/Product19/Line2/3.webp", 41, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5967), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 155, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5969), "Images/Product/Product19/Line2/4.webp", 41, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5970), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 156, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5972), "Images/Product/Product20/Line1/1.webp", 42, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5973), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 157, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5974), "Images/Product/Product20/Line1/2.webp", 42, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5975), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 158, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(6003), "Images/Product/Product20/Line1/3.webp", 42, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(6004), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ID", "Active", "Created", "Image", "ProductLineID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 159, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(6006), "Images/Product/Product20/Line1/4.webp", 42, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(6007), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 160, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(6009), "Images/Product/Product20/Line1/5.webp", 42, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(6010), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 161, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(6012), "Images/Product/Product20/Line2/1.webp", 43, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(6013), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 162, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(6015), "Images/Product/Product20/Line2/2.webp", 43, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(6016), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 163, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(6017), "Images/Product/Product20/Line2/3.webp", 43, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(6018), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 164, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(6020), "Images/Product/Product20/Line2/4.webp", 43, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(6021), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 116, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5861), "Images/Product/Product14/Line1/1.webp", 32, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5862), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 117, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5864), "Images/Product/Product14/Line1/2.webp", 32, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5865), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 118, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5867), "Images/Product/Product14/Line1/3.webp", 32, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5868), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 119, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5870), "Images/Product/Product14/Line1/4.webp", 32, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5871), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 120, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5872), "Images/Product/Product15/Line1/1.webp", 33, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5873), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 121, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5875), "Images/Product/Product15/Line1/2.webp", 33, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5876), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 122, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5878), "Images/Product/Product15/Line1/3.webp", 33, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5879), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 123, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5881), "Images/Product/Product15/Line1/4.webp", 33, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5882), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 131, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5903), "Images/Product/Product17/Line1/1.webp", 36, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5904), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 132, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5906), "Images/Product/Product17/Line1/2.webp", 36, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5907), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 133, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5908), "Images/Product/Product17/Line1/3.webp", 36, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5909), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 134, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5911), "Images/Product/Product17/Line1/4.webp", 36, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5912), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 135, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5914), "Images/Product/Product17/Line2/1.webp", 37, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5915), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 136, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5917), "Images/Product/Product17/Line2/2.webp", 37, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5918), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 137, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5919), "Images/Product/Product17/Line2/3.webp", 37, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5920), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 139, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5925), "Images/Product/Product18/Line1/1.webp", 38, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5926), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 150, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5955), "Images/Product/Product19/Line1/3.webp", 40, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5956), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 197, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6590), "Images/Product/Product23/Line4/3.webp", 51, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6591), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 199, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6596), "Images/Product/Product23/Line4/5.webp", 51, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6597), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 220, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6655), "Images/Product/Product26/Line1/4.webp", 56, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6656), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 221, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6658), "Images/Product/Product26/Line2/1.webp", 57, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6659), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 222, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6661), "Images/Product/Product26/Line2/2.webp", 57, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6662), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 223, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6664), "Images/Product/Product26/Line2/3.webp", 57, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6665), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 224, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6666), "Images/Product/Product26/Line2/4.webp", 57, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6667), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 225, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6669), "Images/Product/Product27/Line1/1.webp", 58, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6670), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 226, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6672), "Images/Product/Product27/Line1/2.webp", 58, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6673), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 227, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6674), "Images/Product/Product27/Line1/3.webp", 58, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6675), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 228, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6677), "Images/Product/Product27/Line1/4.webp", 58, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6678), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 229, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6680), "Images/Product/Product27/Line2/1.webp", 59, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6681), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 230, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6683), "Images/Product/Product27/Line2/2.webp", 59, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6684), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 231, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6685), "Images/Product/Product27/Line2/3.webp", 59, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6686), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 232, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6715), "Images/Product/Product27/Line2/4.webp", 59, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6716), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 233, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6718), "Images/Product/Product28/Line1/1.webp", 60, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6719), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 234, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6721), "Images/Product/Product28/Line1/2.webp", 60, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6722), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 235, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6724), "Images/Product/Product28/Line1/3.webp", 60, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6725), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 236, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6726), "Images/Product/Product28/Line1/4.webp", 60, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6727), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ID", "Active", "Created", "Image", "ProductLineID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 237, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6729), "Images/Product/Product28/Line1/5.webp", 60, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6730), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 238, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6732), "Images/Product/Product28/Line2/1.webp", 61, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6733), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 239, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6735), "Images/Product/Product28/Line2/2.webp", 61, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6736), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 240, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6737), "Images/Product/Product28/Line2/3.webp", 61, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6738), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 241, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6740), "Images/Product/Product28/Line2/4.webp", 61, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6741), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 242, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6743), "Images/Product/Product28/Line3/1.webp", 62, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6744), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 243, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6745), "Images/Product/Product28/Line3/2.webp", 62, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6746), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 244, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6748), "Images/Product/Product28/Line3/3.webp", 62, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6749), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 245, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6751), "Images/Product/Product28/Line3/4.webp", 62, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6752), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 246, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6754), "Images/Product/Product28/Line3/5.webp", 62, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6755), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 247, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6756), "Images/Product/Product29/Line1/1.jpg", 63, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6757), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 248, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6759), "Images/Product/Product29/Line1/2.jpg", 63, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6760), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 219, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6653), "Images/Product/Product26/Line1/3.webp", 56, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6654), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 198, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6593), "Images/Product/Product23/Line4/4.webp", 51, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6594), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 218, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6650), "Images/Product/Product26/Line1/2.webp", 56, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6651), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 216, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6644), "Images/Product/Product25/Line2/4.webp", 55, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6645), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 200, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6599), "Images/Product/Product24/Line1/1.webp", 52, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6600), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 201, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6601), "Images/Product/Product24/Line1/2.webp", 52, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6602), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 202, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6604), "Images/Product/Product24/Line1/3.webp", 52, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6605), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 203, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6608), "Images/Product/Product24/Line1/4.webp", 52, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6609), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 204, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6611), "Images/Product/Product24/Line2/1.webp", 53, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6612), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 205, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6613), "Images/Product/Product24/Line2/2.webp", 53, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6614), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 206, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6617), "Images/Product/Product24/Line2/3.webp", 53, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6618), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 207, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6620), "Images/Product/Product24/Line2/4.webp", 53, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6621), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 251, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6767), "Images/Product/Product30/Line1/1.webp", 64, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6768), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 252, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6770), "Images/Product/Product30/Line1/2.webp", 64, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6771), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 253, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6773), "Images/Product/Product30/Line1/3.webp", 64, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6774), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 254, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6776), "Images/Product/Product30/Line1/4.webp", 64, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6776), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 255, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6778), "Images/Product/Product30/Line1/5.webp", 64, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6779), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 256, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6781), "Images/Product/Product30/Line2/1.webp", 65, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6782), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 257, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6784), "Images/Product/Product30/Line2/2.webp", 65, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6785), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 258, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6786), "Images/Product/Product30/Line2/3.webp", 65, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6787), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 259, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6789), "Images/Product/Product30/Line2/4.webp", 65, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6790), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 260, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6792), "Images/Product/Product30/Line3/1.jpg", 66, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6793), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 261, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6795), "Images/Product/Product30/Line3/2.jpg", 66, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6796), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 262, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6797), "Images/Product/Product30/Line3/3.jpg", 66, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6798), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 263, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6800), "Images/Product/Product30/Line3/4.jpg", 66, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6801), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 208, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6623), "Images/Product/Product25/Line1/1.webp", 54, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6624), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 209, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6625), "Images/Product/Product25/Line1/2.webp", 54, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6626), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 210, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6628), "Images/Product/Product25/Line1/3.webp", 54, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6629), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 211, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6631), "Images/Product/Product25/Line1/4.webp", 54, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6632), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 212, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6634), "Images/Product/Product25/Line1/5.webp", 54, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6635), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ID", "Active", "Created", "Image", "ProductLineID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 213, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6636), "Images/Product/Product25/Line2/1.webp", 55, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6637), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 214, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6639), "Images/Product/Product25/Line2/2.webp", 55, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6640), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 215, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6642), "Images/Product/Product25/Line2/3.webp", 55, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6643), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 217, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6647), "Images/Product/Product26/Line1/1.webp", 56, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6648), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 249, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6762), "Images/Product/Product29/Line1/3.jpg", 63, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6763), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 149, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5952), "Images/Product/Product19/Line1/2.webp", 40, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5953), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 130, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5900), "Images/Product/Product16/Line2/3.webp", 35, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5901), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 35, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7418), "Images/Product/Product5/Line1/3.webp", 11, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7419), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 36, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7421), "Images/Product/Product5/Line2/1.webp", 12, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7422), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 37, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7464), "Images/Product/Product5/Line2/2.webp", 12, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7465), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 38, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7467), "Images/Product/Product5/Line2/3.webp", 12, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7468), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 39, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7470), "Images/Product/Product6/Line1/1.webp", 13, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7471), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 40, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7473), "Images/Product/Product6/Line1/2.webp", 13, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7474), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 41, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7476), "Images/Product/Product6/Line1/3.webp", 13, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7477), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 42, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7478), "Images/Product/Product6/Line1/4.webp", 13, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7479), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 43, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7481), "Images/Product/Product6/Line1/5.webp", 13, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7482), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 44, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7484), "Images/Product/Product6/Line2/1.webp", 14, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7485), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 45, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7486), "Images/Product/Product6/Line2/2.webp", 14, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7487), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 46, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7489), "Images/Product/Product6/Line2/3.webp", 14, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7490), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 47, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7492), "Images/Product/Product6/Line2/4.webp", 14, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7493), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 173, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6420), "Images/Product/Product22/Line1/1.webp", 46, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6421), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 174, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6423), "Images/Product/Product22/Line1/2.webp", 46, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6423), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 175, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6425), "Images/Product/Product22/Line1/3.webp", 46, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6426), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 176, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6428), "Images/Product/Product22/Line1/4.webp", 46, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6429), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 177, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6431), "Images/Product/Product22/Line2/1.webp", 47, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6432), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 178, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6434), "Images/Product/Product22/Line2/2.webp", 47, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6435), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 179, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6436), "Images/Product/Product22/Line2/3.webp", 47, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6437), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 180, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6439), "Images/Product/Product22/Line2/4.webp", 47, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6440), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 48, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7495), "Images/Product/Product7/Line1/1.webp", 15, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7496), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 49, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7498), "Images/Product/Product7/Line1/2.webp", 15, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7498), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 50, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7500), "Images/Product/Product7/Line1/3.webp", 15, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7501), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 51, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7503), "Images/Product/Product7/Line2/1.jpg", 16, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7504), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 52, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7506), "Images/Product/Product7/Line2/2.webp", 16, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7507), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 53, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7508), "Images/Product/Product7/Line2/3.webp", 16, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7509), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 54, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7511), "Images/Product/Product8/Line1/1.webp", 17, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7512), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 55, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7514), "Images/Product/Product8/Line1/2.webp", 17, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7515), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 34, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7416), "Images/Product/Product5/Line1/2.webp", 11, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7417), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 56, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7516), "Images/Product/Product8/Line1/3.webp", 17, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7517), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 33, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7413), "Images/Product/Product5/Line1/1.webp", 11, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7414), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 31, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7408), "Images/Product/Product4/Line2/2.webp", 10, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7409), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7320), "Images/Product/Product1/Line1/2.webp", 1, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7326), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7330), "Images/Product/Product1/Line1/3.webp", 1, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7331), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ID", "Active", "Created", "Image", "ProductLineID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 4, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7333), "Images/Product/Product1/Line2/1.webp", 2, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7334), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7336), "Images/Product/Product1/Line2/2.webp", 2, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7337), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7338), "Images/Product/Product1/Line2/3.webp", 2, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7339), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7341), "Images/Product/Product1/Line3/1.webp", 3, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7342), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7344), "Images/Product/Product1/Line3/2.webp", 3, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7345), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7347), "Images/Product/Product1/Line3/3.webp", 3, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7348), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7350), "Images/Product/Product2/Line1/1.webp", 4, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7351), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7352), "Images/Product/Product2/Line1/2.webp", 4, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7353), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7355), "Images/Product/Product2/Line1/3.webp", 4, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7356), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7358), "Images/Product/Product2/Line1/4.jpg", 4, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7359), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7361), "Images/Product/Product2/Line2/1.webp", 5, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7362), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 15, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7364), "Images/Product/Product2/Line2/2.webp", 5, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7365), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 16, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7366), "Images/Product/Product2/Line2/3.webp", 5, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7367), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 17, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7369), "Images/Product/Product2/Line2/4.webp", 5, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7370), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 18, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7372), "Images/Product/Product3/Line1/1.webp", 6, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7373), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 19, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7375), "Images/Product/Product3/Line1/2.webp", 6, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7376), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 20, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7378), "Images/Product/Product3/Line1/3.webp", 6, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7378), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 21, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7380), "Images/Product/Product3/Line2/1.webp", 7, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7381), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 22, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7383), "Images/Product/Product3/Line2/2.webp", 7, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7384), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 23, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7386), "Images/Product/Product3/Line2/3.webp", 7, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7387), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 24, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7388), "Images/Product/Product3/Line3/1.webp", 8, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7389), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 25, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7391), "Images/Product/Product3/Line3/2.webp", 8, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7392), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 26, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7394), "Images/Product/Product3/Line3/3.webp", 8, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7395), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 27, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7397), "Images/Product/Product4/Line1/1.webp", 9, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7398), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 28, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7399), "Images/Product/Product4/Line1/2.webp", 9, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7400), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 29, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7402), "Images/Product/Product4/Line1/3.webp", 9, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7403), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 30, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7405), "Images/Product/Product4/Line2/1.webp", 10, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7406), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 32, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7410), "Images/Product/Product4/Line2/3.webp", 10, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7411), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 148, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5949), "Images/Product/Product19/Line1/1.webp", 40, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5950), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 57, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7519), "Images/Product/Product8/Line1/4.webp", 17, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7520), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 59, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7524), "Images/Product/Product8/Line2/2.webp", 18, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7525), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 93, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5772), "Images/Product/Product12/Line4/1.webp", 27, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5773), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 94, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5774), "Images/Product/Product12/Line4/2.webp", 27, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5775), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 95, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5777), "Images/Product/Product12/Line4/3.webp", 27, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5778), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 96, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5780), "Images/Product/Product12/Line4/4.webp", 27, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5781), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 97, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5783), "Images/Product/Product12/Line4/5.webp", 27, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5784), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 98, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5785), "Images/Product/Product12/Line5/1.webp", 28, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5786), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 99, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5788), "Images/Product/Product12/Line5/2.webp", 28, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5789), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 100, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5791), "Images/Product/Product12/Line5/3.webp", 28, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5792), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 101, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5794), "Images/Product/Product12/Line5/4.webp", 28, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5795), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 102, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5796), "Images/Product/Product13/Line1/1.webp", 29, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5797), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 103, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5799), "Images/Product/Product13/Line1/2.webp", 29, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5800), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ID", "Active", "Created", "Image", "ProductLineID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 104, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5802), "Images/Product/Product13/Line1/3.webp", 29, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5803), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 105, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5804), "Images/Product/Product13/Line1/4.webp", 29, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5805), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 106, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5807), "Images/Product/Product13/Line1/5.webp", 29, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5808), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 107, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5810), "Images/Product/Product13/Line2/1.webp", 30, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5811), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 108, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5813), "Images/Product/Product13/Line2/2.webp", 30, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5814), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 109, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5815), "Images/Product/Product13/Line2/3.webp", 30, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5816), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 110, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5818), "Images/Product/Product13/Line2/4.webp", 30, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5819), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 111, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5821), "Images/Product/Product13/Line2/5.webp", 30, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5822), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 112, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5824), "Images/Product/Product13/Line3/1.webp", 31, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5825), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 113, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5826), "Images/Product/Product13/Line3/2.webp", 31, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5827), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 114, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5829), "Images/Product/Product13/Line3/3.webp", 31, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5830), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 115, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5858), "Images/Product/Product13/Line3/4.webp", 31, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5859), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 124, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5883), "Images/Product/Product16/Line1/1.webp", 34, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5884), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 125, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5886), "Images/Product/Product16/Line1/2.webp", 34, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5887), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 126, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5889), "Images/Product/Product16/Line1/3.webp", 34, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5890), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 127, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5892), "Images/Product/Product16/Line1/4.webp", 34, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5893), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 128, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5895), "Images/Product/Product16/Line2/1.webp", 35, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5896), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 129, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5897), "Images/Product/Product16/Line2/2.webp", 35, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5898), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 92, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5769), "Images/Product/Product12/Line3/4.webp", 26, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5770), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 58, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7522), "Images/Product/Product8/Line2/1.webp", 18, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7523), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 91, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5766), "Images/Product/Product12/Line3/3.webp", 26, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5767), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 89, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5761), "Images/Product/Product12/Line3/1.webp", 26, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5762), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 60, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7527), "Images/Product/Product8/Line2/3.webp", 18, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7528), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 61, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7530), "Images/Product/Product8/Line2/4.webp", 18, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7531), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 62, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7533), "Images/Product/Product8/Line2/5.jpg", 18, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7534), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 69, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7552), "Images/Product/Product10/Line1/1.webp", 21, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7553), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 70, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7554), "Images/Product/Product10/Line1/2.webp", 21, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7555), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 71, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7557), "Images/Product/Product10/Line1/3.webp", 21, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7558), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 72, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7560), "Images/Product/Product10/Line1/4.webp", 21, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7561), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 73, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7562), "Images/Product/Product10/Line2/1.webp", 22, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7563), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 74, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7565), "Images/Product/Product10/Line2/2.webp", 22, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7566), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 75, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7568), "Images/Product/Product10/Line2/3.webp", 22, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7569), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 76, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7571), "Images/Product/Product10/Line2/4.webp", 22, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7572), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 63, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7535), "Images/Product/Product9/Line1/1.webp", 19, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7536), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 64, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7538), "Images/Product/Product9/Line1/2.webp", 19, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7539), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 65, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7541), "Images/Product/Product9/Line1/3.webp", 19, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7542), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 66, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7543), "Images/Product/Product9/Line2/1.webp", 20, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7544), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 67, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7546), "Images/Product/Product9/Line2/2.webp", 20, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7547), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 68, true, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7549), "Images/Product/Product9/Line2/3.webp", 20, new DateTime(2022, 6, 11, 16, 3, 6, 133, DateTimeKind.Local).AddTicks(7550), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 77, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5711), "Images/Product/Product11/Line1/1.webp", 23, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5722), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 78, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5730), "Images/Product/Product11/Line1/2.webp", 23, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5731), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 79, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5733), "Images/Product/Product11/Line1/3.webp", 23, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5734), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ID", "Active", "Created", "Image", "ProductLineID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 80, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5735), "Images/Product/Product11/Line1/4.webp", 23, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5736), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 81, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5738), "Images/Product/Product12/Line1/1.webp", 24, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5739), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 82, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5741), "Images/Product/Product12/Line1/2.webp", 24, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5742), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 83, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5744), "Images/Product/Product12/Line1/3.webp", 24, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5745), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 84, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5746), "Images/Product/Product12/Line1/4.webp", 24, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5747), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 85, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5749), "Images/Product/Product12/Line2/1.webp", 25, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5750), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 86, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5752), "Images/Product/Product12/Line2/2.webp", 25, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5753), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 87, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5755), "Images/Product/Product12/Line2/3.webp", 25, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5756), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 88, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5758), "Images/Product/Product12/Line2/4.webp", 25, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5759), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 90, true, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5763), "Images/Product/Product12/Line3/2.webp", 26, new DateTime(2022, 6, 11, 16, 3, 6, 135, DateTimeKind.Local).AddTicks(5764), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 250, true, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6765), "Images/Product/Product29/Line1/4.jpg", 63, new DateTime(2022, 6, 11, 16, 3, 6, 137, DateTimeKind.Local).AddTicks(6766), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
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
