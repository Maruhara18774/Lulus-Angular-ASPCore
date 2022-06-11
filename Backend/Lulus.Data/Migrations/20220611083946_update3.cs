using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lulus.Data.Migrations
{
    public partial class update3 : Migration
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
                    { new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"), "e408343a-4131-4c7f-ad7c-4d55fe5df21a", "Customer", "CUSTOMER" },
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "d923881f-7c6d-4949-94df-9dff85fe10cb", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Active", "Created", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 15, true, new DateTime(2022, 6, 11, 15, 39, 45, 160, DateTimeKind.Local).AddTicks(7733), "Tops", new DateTime(2022, 6, 11, 15, 39, 45, 160, DateTimeKind.Local).AddTicks(7734), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, true, new DateTime(2022, 6, 11, 15, 39, 45, 160, DateTimeKind.Local).AddTicks(7731), "Swimsuits & Cover-Ups", new DateTime(2022, 6, 11, 15, 39, 45, 160, DateTimeKind.Local).AddTicks(7732), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, true, new DateTime(2022, 6, 11, 15, 39, 45, 160, DateTimeKind.Local).AddTicks(7728), "Sweaters & Knits", new DateTime(2022, 6, 11, 15, 39, 45, 160, DateTimeKind.Local).AddTicks(7729), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, true, new DateTime(2022, 6, 11, 15, 39, 45, 160, DateTimeKind.Local).AddTicks(7725), "Skirts", new DateTime(2022, 6, 11, 15, 39, 45, 160, DateTimeKind.Local).AddTicks(7726), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, true, new DateTime(2022, 6, 11, 15, 39, 45, 160, DateTimeKind.Local).AddTicks(7615), "Shorts", new DateTime(2022, 6, 11, 15, 39, 45, 160, DateTimeKind.Local).AddTicks(7616), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, new DateTime(2022, 6, 11, 15, 39, 45, 160, DateTimeKind.Local).AddTicks(7613), "Rompers", new DateTime(2022, 6, 11, 15, 39, 45, 160, DateTimeKind.Local).AddTicks(7613), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 6, 11, 15, 39, 45, 159, DateTimeKind.Local).AddTicks(7569), "Activewear", new DateTime(2022, 6, 11, 15, 39, 45, 160, DateTimeKind.Local).AddTicks(6169), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 6, 11, 15, 39, 45, 160, DateTimeKind.Local).AddTicks(7608), "Loungewear", new DateTime(2022, 6, 11, 15, 39, 45, 160, DateTimeKind.Local).AddTicks(7609), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, new DateTime(2022, 6, 11, 15, 39, 45, 160, DateTimeKind.Local).AddTicks(7610), "Pants", new DateTime(2022, 6, 11, 15, 39, 45, 160, DateTimeKind.Local).AddTicks(7611), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 11, 15, 39, 45, 160, DateTimeKind.Local).AddTicks(7596), "Dresses", new DateTime(2022, 6, 11, 15, 39, 45, 160, DateTimeKind.Local).AddTicks(7597), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 6, 11, 15, 39, 45, 160, DateTimeKind.Local).AddTicks(7598), "Jackets & Coats", new DateTime(2022, 6, 11, 15, 39, 45, 160, DateTimeKind.Local).AddTicks(7599), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 11, 15, 39, 45, 160, DateTimeKind.Local).AddTicks(7589), "Denim", new DateTime(2022, 6, 11, 15, 39, 45, 160, DateTimeKind.Local).AddTicks(7594), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 6, 11, 15, 39, 45, 160, DateTimeKind.Local).AddTicks(7603), "Leather", new DateTime(2022, 6, 11, 15, 39, 45, 160, DateTimeKind.Local).AddTicks(7604), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 6, 11, 15, 39, 45, 160, DateTimeKind.Local).AddTicks(7606), "Lingerie & Sleepwear", new DateTime(2022, 6, 11, 15, 39, 45, 160, DateTimeKind.Local).AddTicks(7607), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 6, 11, 15, 39, 45, 160, DateTimeKind.Local).AddTicks(7601), "Jumpsuits", new DateTime(2022, 6, 11, 15, 39, 45, 160, DateTimeKind.Local).AddTicks(7602), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "Active", "Created", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(359), "Vietnam", new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(365), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(810), "China", new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(814), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(816), "America", new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(817), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Designers",
                columns: new[] { "ID", "Active", "Created", "Description", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 14, true, new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6200), null, "SPRWMN", new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6201), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 22, true, new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6219), null, "Cult Gaia", new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6220), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 21, true, new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6217), null, "Brochu Walker", new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6218), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 20, true, new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6215), null, "COTTON CITIZEN", new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6215), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 19, true, new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6212), null, "Lovers and Friends", new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6213), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 18, true, new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6210), null, "Nookie", new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6211), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 17, true, new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6207), null, "Enza Costa", new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6208), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 16, true, new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6205), null, "Indah", new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6206), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 15, true, new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6203), null, "Understated Leather", new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6204), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 23, true, new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6222), null, "VALENTINA SHAH", new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6223), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, true, new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6195), null, "Helmut Lang", new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6196), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, true, new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6192), null, "LAMARQUE", new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6193), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(5718), null, "ELLIATT", new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(5724), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, true, new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6198), null, "LPA", new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6199), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6173), null, "krisa", new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6174), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6175), null, "Michael Costello", new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6176), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6178), null, "AFRM", new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6179), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6167), null, "Sabina Musayev", new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6171), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6183), null, "SOLACE London", new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6184), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6185), null, "retrofete", new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6186), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6188), null, "ASTR the Label", new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6189), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6190), null, "ALLSAINTS", new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6191), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Designers",
                columns: new[] { "ID", "Active", "Created", "Description", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[] { 6, true, new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6180), null, "Amanda Uprichard", new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(6181), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "Occations",
                columns: new[] { "ID", "Active", "Created", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(8382), "To A Special Event", new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(8388), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(8820), "On Vacation", new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(8823), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(8826), "For A Night Out", new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(8827), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(8828), "On The Weekend", new DateTime(2022, 6, 11, 15, 39, 45, 161, DateTimeKind.Local).AddTicks(8829), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "ID", "Active", "Created", "Name", "ParentID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 9, true, new DateTime(2022, 6, 11, 15, 39, 45, 164, DateTimeKind.Local).AddTicks(6148), "Sundresses", null, new DateTime(2022, 6, 11, 15, 39, 45, 164, DateTimeKind.Local).AddTicks(6149), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 6, 11, 15, 39, 45, 164, DateTimeKind.Local).AddTicks(6146), "Gingham", null, new DateTime(2022, 6, 11, 15, 39, 45, 164, DateTimeKind.Local).AddTicks(6147), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 6, 11, 15, 39, 45, 164, DateTimeKind.Local).AddTicks(6141), "Wrap", null, new DateTime(2022, 6, 11, 15, 39, 45, 164, DateTimeKind.Local).AddTicks(6142), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 6, 11, 15, 39, 45, 164, DateTimeKind.Local).AddTicks(6144), "Floral", null, new DateTime(2022, 6, 11, 15, 39, 45, 164, DateTimeKind.Local).AddTicks(6145), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 6, 11, 15, 39, 45, 164, DateTimeKind.Local).AddTicks(6137), "Bodycon", null, new DateTime(2022, 6, 11, 15, 39, 45, 164, DateTimeKind.Local).AddTicks(6138), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 6, 11, 15, 39, 45, 164, DateTimeKind.Local).AddTicks(5684), "Cocktail", null, new DateTime(2022, 6, 11, 15, 39, 45, 164, DateTimeKind.Local).AddTicks(5690), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 6, 11, 15, 39, 45, 164, DateTimeKind.Local).AddTicks(6139), "Denim", null, new DateTime(2022, 6, 11, 15, 39, 45, 164, DateTimeKind.Local).AddTicks(6140), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 11, 15, 39, 45, 164, DateTimeKind.Local).AddTicks(6134), "Bohemian", null, new DateTime(2022, 6, 11, 15, 39, 45, 164, DateTimeKind.Local).AddTicks(6135), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 11, 15, 39, 45, 164, DateTimeKind.Local).AddTicks(6128), "One Shoulder", null, new DateTime(2022, 6, 11, 15, 39, 45, 164, DateTimeKind.Local).AddTicks(6132), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Textures",
                columns: new[] { "ID", "Active", "Created", "Image", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 44, true, new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(3373), "Images/Texture/chocolate.webp", "Chocolate", new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(3374), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 26, true, new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9353), "Images/Texture/faded-jean.webp", "Faded Jean", new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9354), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 27, true, new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9355), "Images/Texture/bone.webp", "Bone", new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9356), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 28, true, new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9358), "Images/Texture/off-white.webp", "Off White", new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9359), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 29, true, new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9361), "Images/Texture/dust.webp", "Dust", new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9362), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 30, true, new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9364), "Images/Texture/dusty-pink.webp", "Dusty Pink", new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9365), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 31, true, new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9366), "Images/Texture/sand.webp", "Sand", new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9367), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 32, true, new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9369), "Images/Texture/seseme.webp", "Seseme", new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9370), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 33, true, new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(3334), "Images/Texture/namibia.webp", "Namibia", new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(3340), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 35, true, new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(3348), "Images/Texture/dark-nude.webp", "Dark Nude", new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(3349), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 25, true, new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9350), "Images/Texture/red.webp", "Red", new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9351), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 37, true, new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(3353), "Images/Texture/ivory.webp", "Ivory", new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(3354), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 38, true, new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(3356), "Images/Texture/rosebloom-pink.webp", "Rosebloom Pink", new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(3357), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 39, true, new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(3359), "Images/Texture/blue2.webp", "Blue", new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(3360), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 40, true, new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(3362), "Images/Texture/washed-chambray.webp", "Washed Chambray", new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(3363), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 41, true, new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(3365), "Images/Texture/washed-black.webp", "Washed Black", new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(3366), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 42, true, new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(3368), "Images/Texture/aloe.webp", "Aloe", new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(3369), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 43, true, new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(3370), "Images/Texture/pink2.webp", "Pink", new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(3371), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 34, true, new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(3345), "Images/Texture/citron.webp", "Citron", new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(3346), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 36, true, new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(3350), "Images/Texture/bronze.webp", "Bronze", new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(3351), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 24, true, new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9347), "Images/Texture/tan.webp", "Tan", new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9348), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 22, true, new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9341), "Images/Texture/taffy-pink.webp", "Taffy Pink", new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9342), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(8407), "Images/Texture/lilac.webp", "Lilac", new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(8413), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9279), "Images/Texture/marigold.webp", "Marigold", new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9284), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9291), "Images/Texture/blush.webp", "Blush", new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9292), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9294), "Images/Texture/multicolor-blue.webp", "Multicolor Blue", new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9295), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9297), "Images/Texture/black.webp", "Black", new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9298), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9300), "Images/Texture/rosa.webp", "Rosa", new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9301), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Textures",
                columns: new[] { "ID", "Active", "Created", "Image", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 8, true, new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9302), "Images/Texture/candy.webp", "Candy", new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9303), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 23, true, new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9344), "Images/Texture/acid-wash-black.webp", "Acid Wash Black", new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9345), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9308), "Images/Texture/baby-blue.webp", "Baby Blue", new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9309), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, true, new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9310), "Images/Texture/abstract-neon-dot.webp", "Abstract Neon Dot", new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9311), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9305), "Images/Texture/taupe.webp", "Taupe", new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9306), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, true, new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9316), "Images/Texture/white-sequin.webp", "White Sequin", new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9317), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, true, new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9319), "Images/Texture/black-sequin.webp", "Black Sequin", new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9320), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 15, true, new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9322), "Images/Texture/cream.webp", "Cream", new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9323), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 16, true, new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9325), "Images/Texture/pink.webp", "Pink", new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9326), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 17, true, new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9328), "Images/Texture/green.webp", "Green", new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9329), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 18, true, new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9331), "Images/Texture/white.png", "White", new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9332), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 19, true, new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9333), "Images/Texture/olive.webp", "Olive", new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9334), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 20, true, new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9336), "Images/Texture/pink-orchid.webp", "Pink Orchid", new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9337), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 21, true, new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9339), "Images/Texture/moonglow-white.webp", "Moonglow White", new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9340), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, true, new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9314), "Images/Texture/multi-watercolor.webp", "Multi Watercolor", new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9315), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9289), "Images/Texture/blue.webp", "Blue", new DateTime(2022, 6, 11, 15, 39, 45, 162, DateTimeKind.Local).AddTicks(9290), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), 0, "c27bb117-1edc-495b-8604-98f91a1d8261", "user@shop.com", false, false, null, "USER@SHOP.COM", "USER", "AQAAAAEAACcQAAAAEAcSUWpJ5I/Znh1dJKeeeM+IdeG4tiXrvoU0LMJItxMj/wkS+NkmWs9VnHXMlvOSGw==", "0125454545", false, null, false, "user" },
                    { new Guid("50892ac9-ebe0-4c8d-f28e-08d9638e12dc"), 0, "6b824210-412f-4870-b68d-a24ecca13b01", "user-bak@shop.com", false, false, null, "USER-BAK@SHOP.COM", "USER-BAK", "AQAAAAEAACcQAAAAEOQEC8ceOqcoxom7Z3GQNEEVPOzRp7dX4gmwEBiATniQCQqfkkW34ZeREWvnzSUUng==", "0125454546", false, null, false, "user-bak" },
                    { new Guid("170ca4bc-ef9f-4de7-ae96-08d962dad25f"), 0, "06eb878c-49f2-4682-ac7d-19b1cc6b6edd", "admin@shop.com", false, false, null, "ADMIN@SHOP.COM", "ADMIN", "AQAAAAEAACcQAAAAEMQj/BErlRyJ2JIWOJN5+DibAfbhRQeC4QoGOjv0W0XGSy5g5arfC4ujV8ViU2ysHw==", "0323265665", false, null, false, "admin" },
                    { new Guid("0dd37c3c-4694-429e-623b-08d962dbded7"), 0, "5d6ef997-10c6-473f-bb06-f2c4b7523675", "admin-bak@shop.com", false, false, null, "ADMIN-BAK@SHOP.COM", "ADMIN-BAK", "AQAAAAEAACcQAAAAEM5U6dVvCc+BAKeL+It5JAx510knvFWTXq6uoDUHejHx3SP4J6HzPqTrHAgPDV/m4A==", "0323265666", false, null, false, "admin-bak" }
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
                    { 11, true, 3, new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(8139), "Los Angeles", new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(8140), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, 3, new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(8137), "New York", new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(8138), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, 2, new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(8134), "Shanghai", new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(8135), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, 1, new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(7258), "Can Tho", new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(7264), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, 2, new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(8129), "Ma Cau", new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(8130), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, 2, new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(8127), "Hong Kong", new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(8128), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, 1, new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(8124), "Ho Chi Minh", new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(8125), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, 1, new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(8111), "Da Nang", new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(8117), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, 1, new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(8119), "Hai Phong", new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(8120), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, 2, new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(8132), "Beijing", new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(8133), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, 1, new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(8122), "Hanoi", new DateTime(2022, 6, 11, 15, 39, 45, 163, DateTimeKind.Local).AddTicks(8123), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "FavoriteDesigners",
                columns: new[] { "ID", "Active", "Created", "DesignerID", "Updated", "UserID", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 5, true, new DateTime(2022, 6, 11, 15, 39, 45, 164, DateTimeKind.Local).AddTicks(2589), 9, new DateTime(2022, 6, 11, 15, 39, 45, 164, DateTimeKind.Local).AddTicks(2590), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 6, 11, 15, 39, 45, 164, DateTimeKind.Local).AddTicks(2585), 7, new DateTime(2022, 6, 11, 15, 39, 45, 164, DateTimeKind.Local).AddTicks(2586), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 11, 15, 39, 45, 164, DateTimeKind.Local).AddTicks(2580), 5, new DateTime(2022, 6, 11, 15, 39, 45, 164, DateTimeKind.Local).AddTicks(2581), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 11, 15, 39, 45, 164, DateTimeKind.Local).AddTicks(2565), 3, new DateTime(2022, 6, 11, 15, 39, 45, 164, DateTimeKind.Local).AddTicks(2571), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 6, 11, 15, 39, 45, 164, DateTimeKind.Local).AddTicks(1580), 2, new DateTime(2022, 6, 11, 15, 39, 45, 164, DateTimeKind.Local).AddTicks(1590), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Active", "CategoryID", "Created", "Description", "DesignerID", "LengthState", "Name", "Price", "SleeveLengthState", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 21, true, 3, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7530), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 16, 2, "Gigi Maxi Skirt", 101.0, 2, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7531), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 23, true, 3, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7536), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 17, 2, "Stretch Silk Knit Essential Skirt", 145.0, 2, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7537), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 24, true, 3, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7539), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 18, 2, "Alyssa Chain Skirt", 199.0, 2, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7540), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 29, true, 3, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7554), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 23, 0, "Stella Skirt", 455.0, 2, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7555), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 25, true, 3, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7542), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 19, 0, "Carlita Skirt", 138.0, 2, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7543), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 26, true, 3, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7545), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 20, 2, "Capri Cut Out Midi Skirt", 195.0, 2, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7546), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 27, true, 3, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7548), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 21, 2, "Havana Skirt", 278.0, 2, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7549), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 28, true, 3, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7551), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 22, 2, "Samira Skirt", 258.0, 2, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7552), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 30, true, 3, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7557), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 18, 2, "Aria Skirt", 169.0, 2, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7558), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 18, true, 2, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7520), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 15, 0, "X REVOLVE Paris Texas Full Skirt", 242.0, 0, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7521), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, true, 2, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7457), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 12, 0, "Slit Leather Pant", 995.0, 0, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7458), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 15, true, 2, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7460), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 13, 0, "Carmella Leather Corset", 209.0, 2, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7461), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, 3, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(3172), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 1, 2, "X REVOLVE Cassini Dress", 187.0, 2, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(3181), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, 3, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7410), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 2, 3, "X REVOLVE Carry Mini Dress", 232.0, 0, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7417), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, 3, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7422), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 3, 0, "Drape Button Front Mini", 216.0, 1, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7423), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, 3, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7426), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 4, 2, "Jake Gown", 198.0, 2, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7427), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, 3, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7429), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 5, 2, "Shailene Dress", 88.0, 0, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7430), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, 3, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7432), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 6, 2, "x REVOLVE Samba Gown", 290.0, 3, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7433), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 22, true, 3, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7533), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 6, 0, "x REVOLVE Mini Ludlow Slit Skirt", 207.0, 2, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7534), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 17, true, 2, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7516), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 14, 0, "Ankle Legging With Zipper", 1250.0, 0, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7517), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, 3, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7435), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 7, 0, "Elina Mini Dress", 527.0, 3, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7436), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, 3, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7444), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 8, 2, "Katya Dress", 795.0, 2, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7445), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Active", "CategoryID", "Created", "Description", "DesignerID", "LengthState", "Name", "Price", "SleeveLengthState", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 9, true, 3, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7441), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 9, 2, "Valinda Dress", 128.0, 2, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7442), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, true, 2, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7447), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 10, 3, "Morgan Biker Jacket", 659.0, 0, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7448), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, true, 2, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7450), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 11, 0, "x REVOLVE Dylan Jacket", 295.0, 0, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7451), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 16, true, 2, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7463), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 11, 2, "Ilonna Dress", 693.0, 0, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7464), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 19, true, 2, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7523), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 11, 0, "X REVOLVE Paris Texas Full Skirt", 242.0, 2, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7524), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 20, true, 2, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7526), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 11, 0, "Davina Leather Corset", 319.0, 0, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7527), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, 3, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7438), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 8, 3, "Margot Dress", 895.0, 2, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7439), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, true, 2, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7454), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 11, 0, "Donna Jacket", 546.0, 0, new DateTime(2022, 6, 11, 15, 39, 45, 166, DateTimeKind.Local).AddTicks(7455), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductLines",
                columns: new[] { "ID", "Active", "Created", "ProductID", "Quantity", "TextureID", "TextureID1", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 22, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8593), 10, 99, 22, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8594), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 33, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8621), 15, 99, 15, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8622), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 32, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8618), 14, 99, 6, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8619), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 43, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8706), 20, 99, 32, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8707), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 42, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8703), 20, 99, 6, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8704), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 41, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8701), 19, 99, 6, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8702), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 40, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8698), 19, 99, 31, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8699), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 35, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8626), 16, 99, 27, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8627), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 34, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8623), 16, 99, 6, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8624), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 36, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8628), 17, 99, 28, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8629), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 31, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8616), 13, 99, 26, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8617), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 29, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8611), 13, 99, 6, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8612), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 28, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8608), 12, 99, 25, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8609), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 27, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8605), 12, 99, 24, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8606), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 26, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8603), 12, 99, 18, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8604), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 25, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8600), 12, 99, 23, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8601), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 24, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8598), 12, 99, 6, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8599), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 23, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8595), 11, 99, 6, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8596), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 20, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8588), 9, 99, 20, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8589), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 30, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8613), 13, 99, 18, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8614), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 37, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8690), 17, 99, 6, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8691), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 38, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8693), 18, 99, 29, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8694), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 39, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8696), 18, 99, 30, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8697), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 61, true, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3801), 28, 99, 42, null, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3802), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 60, true, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3799), 28, 99, 28, null, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3800), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 59, true, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3796), 27, 99, 41, null, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3797), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 58, true, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3794), 27, 99, 40, null, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3795), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 57, true, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3792), 26, 99, 18, null, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3792), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 56, true, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3789), 26, 99, 6, null, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3790), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 55, true, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3787), 25, 99, 39, null, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3788), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 54, true, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3784), 25, 99, 38, null, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3785), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 66, true, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3815), 30, 99, 25, null, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3816), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 65, true, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3812), 30, 99, 44, null, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3813), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 64, true, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3809), 30, 99, 6, null, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3810), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 53, true, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3782), 24, 99, 6, null, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3783), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 52, true, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3779), 24, 99, 37, null, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3780), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 51, true, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3776), 23, 99, 18, null, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3777), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 50, true, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3773), 23, 99, 36, null, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3774), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 49, true, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3771), 23, 99, 6, null, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3772), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 48, true, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3768), 23, 99, 35, null, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3769), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 45, true, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3759), 21, 99, 33, null, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3760), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 44, true, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3750), 21, 99, 18, null, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3756), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductLines",
                columns: new[] { "ID", "Active", "Created", "ProductID", "Quantity", "TextureID", "TextureID1", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 19, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8585), 9, 99, 19, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8586), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 62, true, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3804), 28, 99, 6, null, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3805), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 63, true, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3806), 29, 99, 43, null, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3807), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8552), 3, 99, 6, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8553), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8555), 3, 99, 7, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8556), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8558), 3, 99, 8, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8559), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8549), 2, 99, 5, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8550), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8546), 2, 99, 4, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8547), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8560), 4, 99, 9, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8561), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8563), 4, 99, 10, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8564), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8565), 5, 99, 11, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8566), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8568), 5, 99, 12, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8569), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 21, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8590), 10, 99, 21, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8591), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8544), 1, 99, 3, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8545), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8573), 6, 99, 14, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8574), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 46, true, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3763), 22, 99, 34, null, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3764), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 47, true, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3766), 22, 99, 27, null, new DateTime(2022, 6, 11, 15, 39, 45, 168, DateTimeKind.Local).AddTicks(3766), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 15, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8575), 7, 99, 15, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8576), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 16, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8578), 7, 99, 16, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8579), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8534), 1, 99, 2, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8541), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 17, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8580), 8, 99, 17, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8581), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 18, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8583), 8, 99, 18, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8584), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(7268), 1, 99, 1, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(7302), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, true, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8570), 6, 99, 13, null, new DateTime(2022, 6, 11, 15, 39, 45, 167, DateTimeKind.Local).AddTicks(8571), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
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
                    { 9, true, 6, new DateTime(2022, 6, 11, 15, 39, 45, 175, DateTimeKind.Local).AddTicks(5528), "Kowloon West", new DateTime(2022, 6, 11, 15, 39, 45, 175, DateTimeKind.Local).AddTicks(5529), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, 6, new DateTime(2022, 6, 11, 15, 39, 45, 175, DateTimeKind.Local).AddTicks(5526), "New Territories East", new DateTime(2022, 6, 11, 15, 39, 45, 175, DateTimeKind.Local).AddTicks(5527), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "ID", "Active", "CityID", "Created", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 7, true, 6, new DateTime(2022, 6, 11, 15, 39, 45, 175, DateTimeKind.Local).AddTicks(5523), "Hong Kong Island", new DateTime(2022, 6, 11, 15, 39, 45, 175, DateTimeKind.Local).AddTicks(5524), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, 2, new DateTime(2022, 6, 11, 15, 39, 45, 175, DateTimeKind.Local).AddTicks(5521), "Thanh Khe", new DateTime(2022, 6, 11, 15, 39, 45, 175, DateTimeKind.Local).AddTicks(5522), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, 2, new DateTime(2022, 6, 11, 15, 39, 45, 175, DateTimeKind.Local).AddTicks(5518), "Cam Le", new DateTime(2022, 6, 11, 15, 39, 45, 175, DateTimeKind.Local).AddTicks(5519), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, 2, new DateTime(2022, 6, 11, 15, 39, 45, 175, DateTimeKind.Local).AddTicks(5516), "Hai Chau", new DateTime(2022, 6, 11, 15, 39, 45, 175, DateTimeKind.Local).AddTicks(5517), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, 1, new DateTime(2022, 6, 11, 15, 39, 45, 175, DateTimeKind.Local).AddTicks(5513), "O Mon", new DateTime(2022, 6, 11, 15, 39, 45, 175, DateTimeKind.Local).AddTicks(5514), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, 1, new DateTime(2022, 6, 11, 15, 39, 45, 175, DateTimeKind.Local).AddTicks(5457), "Binh Thuy", new DateTime(2022, 6, 11, 15, 39, 45, 175, DateTimeKind.Local).AddTicks(5462), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, 1, new DateTime(2022, 6, 11, 15, 39, 45, 175, DateTimeKind.Local).AddTicks(4628), "Ninh Kieu", new DateTime(2022, 6, 11, 15, 39, 45, 175, DateTimeKind.Local).AddTicks(4639), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ID", "Active", "Created", "Image", "ProductLineID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(735), "Images/Product/Product1/Line1/1.webp", 1, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(746), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 142, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(573), "Images/Product/Product18/Line1/4.webp", 38, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(574), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 143, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(625), "Images/Product/Product18/Line1/5.webp", 38, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(626), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 144, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(628), "Images/Product/Product18/Line2/1.webp", 39, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(629), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 145, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(631), "Images/Product/Product18/Line2/2.webp", 39, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(632), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 146, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(634), "Images/Product/Product18/Line2/3.webp", 39, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(635), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 147, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(637), "Images/Product/Product18/Line2/4.webp", 39, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(638), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 165, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2145), "Images/Product/Product21/Line1/1.webp", 44, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2169), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 166, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2183), "Images/Product/Product21/Line1/2.webp", 44, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2184), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 167, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2186), "Images/Product/Product21/Line1/3.webp", 44, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2187), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 168, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2189), "Images/Product/Product21/Line1/4.webp", 44, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2190), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 169, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2192), "Images/Product/Product21/Line2/1.webp", 45, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2193), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 170, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2194), "Images/Product/Product21/Line2/2.webp", 45, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2195), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 171, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2197), "Images/Product/Product21/Line2/3.webp", 45, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2198), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 172, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2200), "Images/Product/Product21/Line2/4.webp", 45, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2201), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 181, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2341), "Images/Product/Product23/Line1/1.webp", 48, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2342), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 182, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2344), "Images/Product/Product23/Line1/2.webp", 48, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2344), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 183, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2346), "Images/Product/Product23/Line1/3.webp", 48, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2347), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 184, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2349), "Images/Product/Product23/Line1/4.webp", 48, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2350), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 185, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2352), "Images/Product/Product23/Line2/1.webp", 49, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2353), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 186, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2354), "Images/Product/Product23/Line2/2.webp", 49, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2355), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 187, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2357), "Images/Product/Product23/Line2/3.webp", 49, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2358), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 188, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2360), "Images/Product/Product23/Line2/4.webp", 49, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2361), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 189, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2362), "Images/Product/Product23/Line2/5.webp", 49, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2363), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 190, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2365), "Images/Product/Product23/Line3/1.webp", 50, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2366), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 191, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2368), "Images/Product/Product23/Line3/2.webp", 50, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2369), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 192, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2370), "Images/Product/Product23/Line3/3.webp", 50, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2371), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 193, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2373), "Images/Product/Product23/Line3/4.webp", 50, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2374), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 194, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2376), "Images/Product/Product23/Line3/5.webp", 50, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2377), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 195, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2378), "Images/Product/Product23/Line4/1.webp", 51, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2379), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 141, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(571), "Images/Product/Product18/Line1/3.webp", 38, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(572), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 196, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2381), "Images/Product/Product23/Line4/2.webp", 51, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2382), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 140, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(568), "Images/Product/Product18/Line1/2.webp", 38, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(569), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 138, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(562), "Images/Product/Product17/Line2/4.webp", 37, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(563), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 151, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(648), "Images/Product/Product19/Line1/4.webp", 40, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(649), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 152, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(651), "Images/Product/Product19/Line2/1.webp", 41, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(652), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 153, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(653), "Images/Product/Product19/Line2/2.webp", 41, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(654), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 154, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(656), "Images/Product/Product19/Line2/3.webp", 41, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(657), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 155, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(659), "Images/Product/Product19/Line2/4.webp", 41, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(660), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 156, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(662), "Images/Product/Product20/Line1/1.webp", 42, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(662), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 157, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(664), "Images/Product/Product20/Line1/2.webp", 42, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(665), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 158, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(667), "Images/Product/Product20/Line1/3.webp", 42, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(668), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ID", "Active", "Created", "Image", "ProductLineID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 159, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(670), "Images/Product/Product20/Line1/4.webp", 42, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(671), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 160, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(672), "Images/Product/Product20/Line1/5.webp", 42, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(673), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 161, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(675), "Images/Product/Product20/Line2/1.webp", 43, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(676), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 162, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(678), "Images/Product/Product20/Line2/2.webp", 43, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(679), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 163, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(681), "Images/Product/Product20/Line2/3.webp", 43, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(682), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 164, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(683), "Images/Product/Product20/Line2/4.webp", 43, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(684), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 116, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(501), "Images/Product/Product14/Line1/1.webp", 32, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(502), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 117, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(504), "Images/Product/Product14/Line1/2.webp", 32, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(505), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 118, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(507), "Images/Product/Product14/Line1/3.webp", 32, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(508), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 119, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(510), "Images/Product/Product14/Line1/4.webp", 32, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(511), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 120, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(512), "Images/Product/Product15/Line1/1.webp", 33, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(513), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 121, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(515), "Images/Product/Product15/Line1/2.webp", 33, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(516), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 122, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(518), "Images/Product/Product15/Line1/3.webp", 33, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(519), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 123, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(521), "Images/Product/Product15/Line1/4.webp", 33, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(522), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 131, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(543), "Images/Product/Product17/Line1/1.webp", 36, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(544), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 132, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(546), "Images/Product/Product17/Line1/2.webp", 36, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(547), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 133, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(549), "Images/Product/Product17/Line1/3.webp", 36, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(550), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 134, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(552), "Images/Product/Product17/Line1/4.webp", 36, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(553), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 135, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(554), "Images/Product/Product17/Line2/1.webp", 37, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(555), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 136, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(557), "Images/Product/Product17/Line2/2.webp", 37, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(558), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 137, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(560), "Images/Product/Product17/Line2/3.webp", 37, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(561), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 139, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(565), "Images/Product/Product18/Line1/1.webp", 38, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(566), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 150, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(645), "Images/Product/Product19/Line1/3.webp", 40, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(646), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 197, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2384), "Images/Product/Product23/Line4/3.webp", 51, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2385), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 199, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2389), "Images/Product/Product23/Line4/5.webp", 51, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2390), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 220, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2488), "Images/Product/Product26/Line1/4.webp", 56, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2489), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 221, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2491), "Images/Product/Product26/Line2/1.webp", 57, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2491), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 222, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2493), "Images/Product/Product26/Line2/2.webp", 57, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2494), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 223, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2496), "Images/Product/Product26/Line2/3.webp", 57, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2497), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 224, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2499), "Images/Product/Product26/Line2/4.webp", 57, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2499), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 225, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2501), "Images/Product/Product27/Line1/1.webp", 58, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2502), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 226, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2504), "Images/Product/Product27/Line1/2.webp", 58, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2505), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 227, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2507), "Images/Product/Product27/Line1/3.webp", 58, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2508), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 228, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2510), "Images/Product/Product27/Line1/4.webp", 58, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2511), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 229, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2512), "Images/Product/Product27/Line2/1.webp", 59, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2513), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 230, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2515), "Images/Product/Product27/Line2/2.webp", 59, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2516), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 231, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2518), "Images/Product/Product27/Line2/3.webp", 59, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2519), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 232, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2520), "Images/Product/Product27/Line2/4.webp", 59, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2521), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 233, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2523), "Images/Product/Product28/Line1/1.webp", 60, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2524), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 234, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2526), "Images/Product/Product28/Line1/2.webp", 60, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2527), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 235, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2529), "Images/Product/Product28/Line1/3.webp", 60, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2530), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 236, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2531), "Images/Product/Product28/Line1/4.webp", 60, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2532), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ID", "Active", "Created", "Image", "ProductLineID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 237, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2534), "Images/Product/Product28/Line1/5.webp", 60, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2535), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 238, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2537), "Images/Product/Product28/Line2/1.webp", 61, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2538), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 239, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2539), "Images/Product/Product28/Line2/2.webp", 61, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2540), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 240, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2542), "Images/Product/Product28/Line2/3.webp", 61, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2543), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 241, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2545), "Images/Product/Product28/Line2/4.webp", 61, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2546), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 242, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2547), "Images/Product/Product28/Line3/1.webp", 62, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2548), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 243, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2550), "Images/Product/Product28/Line3/2.webp", 62, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2551), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 244, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2553), "Images/Product/Product28/Line3/3.webp", 62, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2554), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 245, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2556), "Images/Product/Product28/Line3/4.webp", 62, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2557), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 246, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2558), "Images/Product/Product28/Line3/5.webp", 62, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2559), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 247, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2561), "Images/Product/Product29/Line1/1.webp", 63, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2562), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 248, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2564), "Images/Product/Product29/Line1/2.webp", 63, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2565), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 219, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2485), "Images/Product/Product26/Line1/3.webp", 56, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2486), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 198, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2386), "Images/Product/Product23/Line4/4.webp", 51, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2387), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 218, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2482), "Images/Product/Product26/Line1/2.webp", 56, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2483), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 216, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2435), "Images/Product/Product25/Line2/4.webp", 55, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2436), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 200, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2392), "Images/Product/Product24/Line1/1.webp", 52, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2393), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 201, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2395), "Images/Product/Product24/Line1/2.webp", 52, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2396), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 202, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2397), "Images/Product/Product24/Line1/3.webp", 52, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2398), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 203, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2400), "Images/Product/Product24/Line1/4.webp", 52, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2401), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 204, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2403), "Images/Product/Product24/Line2/1.webp", 53, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2404), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 205, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2405), "Images/Product/Product24/Line2/2.webp", 53, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2406), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 206, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2408), "Images/Product/Product24/Line2/3.webp", 53, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2409), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 207, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2411), "Images/Product/Product24/Line2/4.webp", 53, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2412), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 251, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2572), "Images/Product/Product30/Line1/1.webp", 64, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2573), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 252, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2575), "Images/Product/Product30/Line1/2.webp", 64, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2576), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 253, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2577), "Images/Product/Product30/Line1/3.webp", 64, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2578), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 254, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2580), "Images/Product/Product30/Line1/4.webp", 64, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2581), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 255, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2583), "Images/Product/Product30/Line1/5.webp", 64, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2584), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 256, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2585), "Images/Product/Product30/Line2/1.webp", 65, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2586), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 257, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2588), "Images/Product/Product30/Line2/2.webp", 65, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2589), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 258, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2591), "Images/Product/Product30/Line2/3.webp", 65, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2592), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 259, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2628), "Images/Product/Product30/Line2/4.webp", 65, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2629), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 260, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2631), "Images/Product/Product30/Line3/1.jpg", 66, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2632), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 261, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2634), "Images/Product/Product30/Line3/2.jpg", 66, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2635), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 262, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2637), "Images/Product/Product30/Line3/3.jpg", 66, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2638), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 263, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2639), "Images/Product/Product30/Line3/4.jpg", 66, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2640), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 208, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2413), "Images/Product/Product25/Line1/1.webp", 54, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2414), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 209, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2416), "Images/Product/Product25/Line1/2.webp", 54, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2417), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 210, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2419), "Images/Product/Product25/Line1/3.webp", 54, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2420), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 211, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2422), "Images/Product/Product25/Line1/4.webp", 54, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2423), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 212, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2424), "Images/Product/Product25/Line1/5.webp", 54, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2425), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ID", "Active", "Created", "Image", "ProductLineID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 213, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2427), "Images/Product/Product25/Line2/1.webp", 55, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2428), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 214, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2430), "Images/Product/Product25/Line2/2.webp", 55, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2431), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 215, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2432), "Images/Product/Product25/Line2/3.webp", 55, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2433), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 217, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2479), "Images/Product/Product26/Line1/1.webp", 56, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2480), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 249, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2567), "Images/Product/Product29/Line1/3.webp", 63, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2568), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 149, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(642), "Images/Product/Product19/Line1/2.webp", 40, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(643), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 130, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(540), "Images/Product/Product16/Line2/3.webp", 35, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(541), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 35, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1767), "Images/Product/Product5/Line1/3.webp", 11, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1768), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 36, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1770), "Images/Product/Product5/Line2/1.webp", 12, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1771), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 37, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1773), "Images/Product/Product5/Line2/2.webp", 12, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1774), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 38, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1776), "Images/Product/Product5/Line2/3.webp", 12, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1777), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 39, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1778), "Images/Product/Product6/Line1/1.webp", 13, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1779), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 40, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1781), "Images/Product/Product6/Line1/2.webp", 13, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1782), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 41, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1784), "Images/Product/Product6/Line1/3.webp", 13, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1785), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 42, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1787), "Images/Product/Product6/Line1/4.webp", 13, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1787), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 43, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1789), "Images/Product/Product6/Line1/5.webp", 13, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1790), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 44, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1792), "Images/Product/Product6/Line2/1.webp", 14, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1793), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 45, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1795), "Images/Product/Product6/Line2/2.webp", 14, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1796), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 46, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1798), "Images/Product/Product6/Line2/3.webp", 14, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1798), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 47, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1800), "Images/Product/Product6/Line2/4.webp", 14, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1801), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 173, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2202), "Images/Product/Product22/Line1/1.webp", 46, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2203), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 174, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2321), "Images/Product/Product22/Line1/2.webp", 46, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2322), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 175, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2324), "Images/Product/Product22/Line1/3.webp", 46, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2325), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 176, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2327), "Images/Product/Product22/Line1/4.webp", 46, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2328), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 177, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2330), "Images/Product/Product22/Line2/1.webp", 47, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2331), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 178, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2333), "Images/Product/Product22/Line2/2.webp", 47, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2333), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 179, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2335), "Images/Product/Product22/Line2/3.webp", 47, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2336), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 180, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2338), "Images/Product/Product22/Line2/4.webp", 47, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2339), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 48, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1803), "Images/Product/Product7/Line1/1.webp", 15, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1804), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 49, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1806), "Images/Product/Product7/Line1/2.webp", 15, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1807), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 50, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1808), "Images/Product/Product7/Line1/3.webp", 15, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1809), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 51, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1811), "Images/Product/Product7/Line2/1.jpg", 16, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1812), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 52, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1814), "Images/Product/Product7/Line2/2.webp", 16, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1815), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 53, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1817), "Images/Product/Product7/Line2/3.webp", 16, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1818), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 54, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1820), "Images/Product/Product8/Line1/1.webp", 17, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1821), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 55, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1822), "Images/Product/Product8/Line1/2.webp", 17, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1823), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 34, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1765), "Images/Product/Product5/Line1/2.webp", 11, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1766), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 56, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1825), "Images/Product/Product8/Line1/3.webp", 17, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1826), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 33, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1762), "Images/Product/Product5/Line1/1.webp", 11, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1763), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 31, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1756), "Images/Product/Product4/Line2/2.webp", 10, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1757), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1620), "Images/Product/Product1/Line1/2.webp", 1, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1626), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1631), "Images/Product/Product1/Line1/3.webp", 1, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1632), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ID", "Active", "Created", "Image", "ProductLineID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 4, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1634), "Images/Product/Product1/Line2/1.webp", 2, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1635), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1637), "Images/Product/Product1/Line2/2.webp", 2, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1638), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1639), "Images/Product/Product1/Line2/3.webp", 2, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1640), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1642), "Images/Product/Product1/Line3/1.webp", 3, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1643), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1645), "Images/Product/Product1/Line3/2.webp", 3, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1646), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1648), "Images/Product/Product1/Line3/3.webp", 3, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1649), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1650), "Images/Product/Product2/Line1/1.webp", 4, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1651), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1653), "Images/Product/Product2/Line1/2.webp", 4, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1654), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1656), "Images/Product/Product2/Line1/3.webp", 4, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1657), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1659), "Images/Product/Product2/Line1/4.jpg", 4, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1660), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1662), "Images/Product/Product2/Line2/1.webp", 5, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1663), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 15, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1664), "Images/Product/Product2/Line2/2.webp", 5, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1665), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 16, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1667), "Images/Product/Product2/Line2/3.webp", 5, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1668), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 17, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1670), "Images/Product/Product2/Line2/4.webp", 5, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1671), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 18, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1672), "Images/Product/Product3/Line1/1.webp", 6, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1673), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 19, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1675), "Images/Product/Product3/Line1/2.webp", 6, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1676), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 20, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1678), "Images/Product/Product3/Line1/3.webp", 6, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1679), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 21, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1680), "Images/Product/Product3/Line2/1.webp", 7, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1681), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 22, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1731), "Images/Product/Product3/Line2/2.webp", 7, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1732), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 23, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1734), "Images/Product/Product3/Line2/3.webp", 7, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1735), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 24, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1737), "Images/Product/Product3/Line3/1.webp", 8, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1738), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 25, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1740), "Images/Product/Product3/Line3/2.webp", 8, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1741), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 26, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1743), "Images/Product/Product3/Line3/3.webp", 8, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1744), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 27, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1745), "Images/Product/Product4/Line1/1.webp", 9, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1746), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 28, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1748), "Images/Product/Product4/Line1/2.webp", 9, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1749), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 29, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1751), "Images/Product/Product4/Line1/3.webp", 9, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1752), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 30, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1754), "Images/Product/Product4/Line2/1.webp", 10, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1755), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 32, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1759), "Images/Product/Product4/Line2/3.webp", 10, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1760), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 148, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(639), "Images/Product/Product19/Line1/1.webp", 40, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(640), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 57, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1828), "Images/Product/Product8/Line1/4.webp", 17, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1829), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 59, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1833), "Images/Product/Product8/Line2/2.webp", 18, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1834), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 93, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(404), "Images/Product/Product12/Line4/1.webp", 27, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(405), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 94, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(407), "Images/Product/Product12/Line4/2.webp", 27, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(408), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 95, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(410), "Images/Product/Product12/Line4/3.webp", 27, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(411), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 96, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(413), "Images/Product/Product12/Line4/4.webp", 27, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(414), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 97, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(415), "Images/Product/Product12/Line4/5.webp", 27, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(416), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 98, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(418), "Images/Product/Product12/Line5/1.webp", 28, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(419), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 99, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(421), "Images/Product/Product12/Line5/2.webp", 28, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(422), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 100, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(457), "Images/Product/Product12/Line5/3.webp", 28, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(458), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 101, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(460), "Images/Product/Product12/Line5/4.webp", 28, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(461), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 102, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(463), "Images/Product/Product13/Line1/1.webp", 29, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(464), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 103, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(466), "Images/Product/Product13/Line1/2.webp", 29, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(467), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ID", "Active", "Created", "Image", "ProductLineID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 104, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(469), "Images/Product/Product13/Line1/3.webp", 29, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(470), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 105, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(471), "Images/Product/Product13/Line1/4.webp", 29, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(472), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 106, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(474), "Images/Product/Product13/Line1/5.webp", 29, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(475), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 107, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(477), "Images/Product/Product13/Line2/1.webp", 30, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(478), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 108, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(480), "Images/Product/Product13/Line2/2.webp", 30, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(481), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 109, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(482), "Images/Product/Product13/Line2/3.webp", 30, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(483), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 110, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(485), "Images/Product/Product13/Line2/4.webp", 30, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(486), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 111, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(488), "Images/Product/Product13/Line2/5.webp", 30, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(489), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 112, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(491), "Images/Product/Product13/Line3/1.webp", 31, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(492), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 113, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(493), "Images/Product/Product13/Line3/2.webp", 31, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(494), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 114, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(496), "Images/Product/Product13/Line3/3.webp", 31, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(497), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 115, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(499), "Images/Product/Product13/Line3/4.webp", 31, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(500), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 124, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(523), "Images/Product/Product16/Line1/1.webp", 34, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(524), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 125, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(526), "Images/Product/Product16/Line1/2.webp", 34, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(527), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 126, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(529), "Images/Product/Product16/Line1/3.webp", 34, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(530), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 127, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(531), "Images/Product/Product16/Line1/4.webp", 34, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(532), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 128, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(535), "Images/Product/Product16/Line2/1.webp", 35, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(536), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 129, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(538), "Images/Product/Product16/Line2/2.webp", 35, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(539), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 92, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(402), "Images/Product/Product12/Line3/4.webp", 26, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(403), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 58, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1831), "Images/Product/Product8/Line2/1.webp", 18, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1832), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 91, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(399), "Images/Product/Product12/Line3/3.webp", 26, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(400), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 89, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(394), "Images/Product/Product12/Line3/1.webp", 26, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(395), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 60, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1836), "Images/Product/Product8/Line2/3.webp", 18, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1837), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 61, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1839), "Images/Product/Product8/Line2/4.webp", 18, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1840), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 62, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1842), "Images/Product/Product8/Line2/5.jpg", 18, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1843), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 69, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1900), "Images/Product/Product10/Line1/1.webp", 21, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1901), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 70, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1903), "Images/Product/Product10/Line1/2.webp", 21, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1904), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 71, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1905), "Images/Product/Product10/Line1/3.webp", 21, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1906), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 72, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1908), "Images/Product/Product10/Line1/4.webp", 21, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1909), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 73, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1911), "Images/Product/Product10/Line2/1.webp", 22, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1912), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 74, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1914), "Images/Product/Product10/Line2/2.webp", 22, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1915), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 75, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1916), "Images/Product/Product10/Line2/3.webp", 22, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1917), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 76, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1919), "Images/Product/Product10/Line2/4.webp", 22, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1920), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 63, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1845), "Images/Product/Product9/Line1/1.webp", 19, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1846), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 64, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1848), "Images/Product/Product9/Line1/2.webp", 19, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1849), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 65, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1887), "Images/Product/Product9/Line1/3.webp", 19, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1888), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 66, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1890), "Images/Product/Product9/Line2/1.webp", 20, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1891), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 67, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1894), "Images/Product/Product9/Line2/2.webp", 20, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1895), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 68, true, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1897), "Images/Product/Product9/Line2/3.webp", 20, new DateTime(2022, 6, 11, 15, 39, 45, 170, DateTimeKind.Local).AddTicks(1898), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 77, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(337), "Images/Product/Product11/Line1/1.webp", 23, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(352), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 78, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(362), "Images/Product/Product11/Line1/2.webp", 23, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(363), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 79, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(365), "Images/Product/Product11/Line1/3.webp", 23, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(366), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ID", "Active", "Created", "Image", "ProductLineID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 80, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(368), "Images/Product/Product11/Line1/4.webp", 23, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(369), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 81, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(370), "Images/Product/Product12/Line1/1.webp", 24, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(371), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 82, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(374), "Images/Product/Product12/Line1/2.webp", 24, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(375), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 83, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(377), "Images/Product/Product12/Line1/3.webp", 24, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(378), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 84, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(380), "Images/Product/Product12/Line1/4.webp", 24, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(381), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 85, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(383), "Images/Product/Product12/Line2/1.webp", 25, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(384), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 86, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(385), "Images/Product/Product12/Line2/2.webp", 25, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(386), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 87, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(388), "Images/Product/Product12/Line2/3.webp", 25, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(389), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 88, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(391), "Images/Product/Product12/Line2/4.webp", 25, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(392), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 90, true, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(396), "Images/Product/Product12/Line3/2.webp", 26, new DateTime(2022, 6, 11, 15, 39, 45, 172, DateTimeKind.Local).AddTicks(397), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 250, true, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2569), "Images/Product/Product29/Line1/4.webp", 63, new DateTime(2022, 6, 11, 15, 39, 45, 174, DateTimeKind.Local).AddTicks(2570), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
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
