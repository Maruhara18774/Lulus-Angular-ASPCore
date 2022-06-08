using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lulus.Data.Migrations
{
    public partial class update1 : Migration
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
                    { new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"), "20c59643-40bd-4ac4-b484-eec807da5772", "Customer", "CUSTOMER" },
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "7202a3ae-cd04-42be-81eb-61c0e80bbd2a", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Active", "Created", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 15, true, new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(1063), "Tops", new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(1064), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, true, new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(1060), "Swimsuits & Cover-Ups", new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(1061), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, true, new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(1058), "Sweaters & Knits", new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(1059), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, true, new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(1056), "Skirts", new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(1057), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, true, new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(1053), "Shorts", new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(1054), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(1051), "Rompers", new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(1052), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 6, 8, 22, 33, 46, 40, DateTimeKind.Local).AddTicks(5696), "Activewear", new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(91), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(1046), "Loungewear", new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(1047), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(1044), "Lingerie & Sleepwear", new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(1045), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(1040), "Leather", new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(1041), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(1037), "Jumpsuits", new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(1038), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(1035), "Jackets & Coats", new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(1036), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(1031), "Dresses", new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(1033), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(1025), "Denim", new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(1029), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(1048), "Pants", new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(1049), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "Active", "Created", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(3210), "Vietnam", new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(3215), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(3483), "China", new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(3486), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(3488), "America", new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(3489), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Designers",
                columns: new[] { "ID", "Active", "Created", "Description", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 10, true, new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(6385), null, "ALLSAINTS", new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(6386), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(6382), null, "ASTR the Label", new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(6383), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(6380), null, "retrofete", new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(6381), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(6378), null, "SOLACE London", new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(6379), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(6373), null, "AFRM", new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(6374), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(6370), null, "Michael Costello", new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(6371), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(6368), null, "krisa", new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(6369), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(6364), null, "Sabina Musayev", new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(6366), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(6095), null, "ELLIATT", new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(6101), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(6375), null, "Amanda Uprichard", new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(6376), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Occations",
                columns: new[] { "ID", "Active", "Created", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(8348), "To A Special Event", new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(8353), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(8616), "On Vacation", new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(8619), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(8621), "For A Night Out", new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(8622), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(8624), "On The Weekend", new DateTime(2022, 6, 8, 22, 33, 46, 42, DateTimeKind.Local).AddTicks(8625), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "ID", "Active", "Created", "Name", "ParentID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 9, true, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(4967), "Sundresses", null, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(4968), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(4965), "Gingham", null, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(4966), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(4960), "Wrap", null, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(4961), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(4963), "Floral", null, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(4964), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(4955), "Bodycon", null, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(4956), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(4958), "Denim", null, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(4959), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(4953), "Bohemian", null, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(4954), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(4691), "Cocktail", null, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(4697), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "ID", "Active", "Created", "Name", "ParentID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[] { 2, true, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(4948), "One Shoulder", null, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(4951), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "Textures",
                columns: new[] { "ID", "Active", "Created", "Image", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(4738), "Images/Texture/lilac.webp", "Lilac", new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(4744), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 22, true, new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5740), "Images/Texture/taffy-pink.webp", "Taffy Pink", new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5741), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 21, true, new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5737), "Images/Texture/moonglow-white.webp", "Moonglow White", new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5738), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 20, true, new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5733), "Images/Texture/pink-orchid.webp", "Pink Orchid", new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5735), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 19, true, new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5727), "Images/Texture/olive.webp", "Olive", new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5731), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 18, true, new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5700), "Images/Texture/white.png", "White", new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5701), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 17, true, new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5696), "Images/Texture/green.webp", "Green", new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5698), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 16, true, new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5693), "Images/Texture/pink.webp", "Pink", new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5694), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 15, true, new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5689), "Images/Texture/cream.webp", "Cream", new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5690), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, true, new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5684), "Images/Texture/black-sequin.webp", "Black Sequin", new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5686), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, true, new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5669), "Images/Texture/abstract-neon-dot.webp", "Abstract Neon Dot", new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5671), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5666), "Images/Texture/baby-blue.webp", "Baby Blue", new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5667), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5663), "Images/Texture/taupe.webp", "Taupe", new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5664), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5653), "Images/Texture/candy.webp", "Candy", new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5660), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5649), "Images/Texture/rosa.webp", "Rosa", new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5651), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5646), "Images/Texture/black.webp", "Black", new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5647), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5642), "Images/Texture/multicolor-blue.webp", "Multicolor Blue", new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5644), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5639), "Images/Texture/blush.webp", "Blush", new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5640), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5634), "Images/Texture/blue.webp", "Blue", new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5636), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5610), "Images/Texture/marigold.webp", "Marigold", new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5629), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, true, new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5675), "Images/Texture/multi-watercolor.webp", "Multi Watercolor", new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5677), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, true, new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5680), "Images/Texture/white-sequin.webp", "White Sequin", new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(5682), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), 0, "14cf6c0f-6292-449c-ad8b-f3d7c741c664", "user@shop.com", false, false, null, "USER@SHOP.COM", "USER", "AQAAAAEAACcQAAAAEGV39DKUcm8XGle5CSJHfH07mmhzhcsGTkCbp3IC8ajS2mA31a2XwC6pcIRqHLDdOw==", "0125454545", false, null, false, "user" },
                    { new Guid("50892ac9-ebe0-4c8d-f28e-08d9638e12dc"), 0, "02d4f319-5bd0-4242-aeb6-e20bea7ad597", "user-bak@shop.com", false, false, null, "USER-BAK@SHOP.COM", "USER-BAK", "AQAAAAEAACcQAAAAEGwJFLfE/2miOIVJACRJ7ejQ47zHDHmgv34eLblWtAt+mGu3fpeFO/585V2IA6O9Dg==", "0125454546", false, null, false, "user-bak" },
                    { new Guid("170ca4bc-ef9f-4de7-ae96-08d962dad25f"), 0, "8b290583-79f4-485e-b40e-e6c51bb384ff", "admin@shop.com", false, false, null, "ADMIN@SHOP.COM", "ADMIN", "AQAAAAEAACcQAAAAEB3FAPBG/CfpQ4ZCDa3Rtw/F7VUIpQKolQJkDjs1NIxWybIwz+jDMrsr/BsdHKdO5w==", "0323265665", false, null, false, "admin" },
                    { new Guid("0dd37c3c-4694-429e-623b-08d962dbded7"), 0, "d9e33661-6cfa-4f28-a3e8-8d181b6fef38", "admin-bak@shop.com", false, false, null, "ADMIN-BAK@SHOP.COM", "ADMIN-BAK", "AQAAAAEAACcQAAAAEDTD91LVsR49lEwd7KSAe6+g6kXIC07xo5XC4zWy895+HzH09z5wvRNuldsrRke7Aw==", "0323265666", false, null, false, "admin-bak" }
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
                    { 11, true, 3, new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(9417), "Los Angeles", new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(9418), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, 3, new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(9415), "New York", new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(9416), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, 2, new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(9412), "Shanghai", new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(9413), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, 1, new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(8851), "Can Tho", new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(8858), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, 2, new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(9407), "Ma Cau", new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(9408), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, 2, new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(9346), "Hong Kong", new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(9347), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, 1, new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(9343), "Ho Chi Minh", new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(9344), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, 1, new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(9332), "Da Nang", new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(9336), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, 1, new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(9338), "Hai Phong", new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(9339), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, 1, new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(9341), "Hanoi", new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(9342), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, 2, new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(9410), "Beijing", new DateTime(2022, 6, 8, 22, 33, 46, 43, DateTimeKind.Local).AddTicks(9411), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "FavoriteDesigners",
                columns: new[] { "ID", "Active", "Created", "DesignerID", "Updated", "UserID", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 5, true, new DateTime(2022, 6, 8, 22, 33, 46, 44, DateTimeKind.Local).AddTicks(2776), 9, new DateTime(2022, 6, 8, 22, 33, 46, 44, DateTimeKind.Local).AddTicks(2778), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 6, 8, 22, 33, 46, 44, DateTimeKind.Local).AddTicks(2772), 7, new DateTime(2022, 6, 8, 22, 33, 46, 44, DateTimeKind.Local).AddTicks(2773), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 8, 22, 33, 46, 44, DateTimeKind.Local).AddTicks(2768), 5, new DateTime(2022, 6, 8, 22, 33, 46, 44, DateTimeKind.Local).AddTicks(2769), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 8, 22, 33, 46, 44, DateTimeKind.Local).AddTicks(2754), 3, new DateTime(2022, 6, 8, 22, 33, 46, 44, DateTimeKind.Local).AddTicks(2758), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 6, 8, 22, 33, 46, 44, DateTimeKind.Local).AddTicks(2156), 2, new DateTime(2022, 6, 8, 22, 33, 46, 44, DateTimeKind.Local).AddTicks(2165), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Active", "CategoryID", "Created", "Description", "DesignerID", "LengthState", "Name", "Price", "SleeveLengthState", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 11, true, 2, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(1912), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 10, 3, "Morgan Biker Jacket", 659.0, 0, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(1913), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, 3, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(1909), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 8, 2, "Katya Dress", 795.0, 2, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(1910), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, 3, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(1903), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 8, 3, "Margot Dress", 895.0, 2, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(1904), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, 3, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(1900), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 7, 0, "Elina Mini Dress", 527.0, 3, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(1901), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, 3, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(1897), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 6, 2, "x REVOLVE Samba Gown", 290.0, 3, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(1898), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, 3, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(1890), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 4, 2, "Jake Gown", 198.0, 2, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(1891), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, 3, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(1886), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 3, 0, "Drape Button Front Mini", 216.0, 1, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(1887), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, 3, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(1878), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 2, 3, "X REVOLVE Carry Mini Dress", 232.0, 0, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(1882), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, 3, new DateTime(2022, 6, 8, 22, 33, 46, 44, DateTimeKind.Local).AddTicks(9537), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 1, 2, "X REVOLVE Cassini Dress", 187.0, 2, new DateTime(2022, 6, 8, 22, 33, 46, 44, DateTimeKind.Local).AddTicks(9543), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, 3, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(1906), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 9, 2, "Valinda Dress", 128.0, 2, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(1907), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, 3, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(1893), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 5, 2, "Shailene Dress", 88.0, 0, new DateTime(2022, 6, 8, 22, 33, 46, 45, DateTimeKind.Local).AddTicks(1894), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductLines",
                columns: new[] { "ID", "Active", "Created", "ProductID", "Quantity", "TextureID", "TextureID1", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 7, true, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(709), 3, 99, 7, null, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(710), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(712), 3, 99, 8, null, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(713), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(714), 4, 99, 9, null, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(715), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(717), 4, 99, 10, null, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(718), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, true, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(719), 5, 99, 11, null, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(720), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, true, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(722), 5, 99, 12, null, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(723), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, true, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(724), 6, 99, 13, null, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(725), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 20, true, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(742), 9, 99, 20, null, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(743), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, true, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(727), 6, 99, 14, null, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(728), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 16, true, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(732), 7, 99, 16, null, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(733), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 17, true, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(735), 8, 99, 17, null, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(735), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 18, true, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(737), 8, 99, 18, null, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(738), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 21, true, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(744), 10, 99, 21, null, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(745), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 22, true, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(747), 10, 99, 22, null, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(748), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 19, true, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(739), 9, 99, 19, null, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(740), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 15, true, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(730), 7, 99, 15, null, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(731), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(707), 3, 99, 6, null, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(708), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 23, true, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(749), 11, 99, 6, null, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(750), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(693), 1, 99, 2, null, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(697), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(702), 2, 99, 4, null, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(703), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(37), 1, 99, 1, null, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(44), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(704), 2, 99, 5, null, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(705), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(699), 1, 99, 3, null, new DateTime(2022, 6, 8, 22, 33, 46, 46, DateTimeKind.Local).AddTicks(700), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
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
                    { 7, true, 6, new DateTime(2022, 6, 8, 22, 33, 46, 48, DateTimeKind.Local).AddTicks(9529), "Hong Kong Island", new DateTime(2022, 6, 8, 22, 33, 46, 48, DateTimeKind.Local).AddTicks(9530), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, 6, new DateTime(2022, 6, 8, 22, 33, 46, 48, DateTimeKind.Local).AddTicks(9534), "Kowloon West", new DateTime(2022, 6, 8, 22, 33, 46, 48, DateTimeKind.Local).AddTicks(9535), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, 2, new DateTime(2022, 6, 8, 22, 33, 46, 48, DateTimeKind.Local).AddTicks(9526), "Thanh Khe", new DateTime(2022, 6, 8, 22, 33, 46, 48, DateTimeKind.Local).AddTicks(9527), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "ID", "Active", "CityID", "Created", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 5, true, 2, new DateTime(2022, 6, 8, 22, 33, 46, 48, DateTimeKind.Local).AddTicks(9524), "Cam Le", new DateTime(2022, 6, 8, 22, 33, 46, 48, DateTimeKind.Local).AddTicks(9525), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, 2, new DateTime(2022, 6, 8, 22, 33, 46, 48, DateTimeKind.Local).AddTicks(9521), "Hai Chau", new DateTime(2022, 6, 8, 22, 33, 46, 48, DateTimeKind.Local).AddTicks(9522), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, 1, new DateTime(2022, 6, 8, 22, 33, 46, 48, DateTimeKind.Local).AddTicks(9519), "O Mon", new DateTime(2022, 6, 8, 22, 33, 46, 48, DateTimeKind.Local).AddTicks(9520), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, 1, new DateTime(2022, 6, 8, 22, 33, 46, 48, DateTimeKind.Local).AddTicks(9513), "Binh Thuy", new DateTime(2022, 6, 8, 22, 33, 46, 48, DateTimeKind.Local).AddTicks(9517), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, 6, new DateTime(2022, 6, 8, 22, 33, 46, 48, DateTimeKind.Local).AddTicks(9531), "New Territories East", new DateTime(2022, 6, 8, 22, 33, 46, 48, DateTimeKind.Local).AddTicks(9532), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, 1, new DateTime(2022, 6, 8, 22, 33, 46, 48, DateTimeKind.Local).AddTicks(9036), "Ninh Kieu", new DateTime(2022, 6, 8, 22, 33, 46, 48, DateTimeKind.Local).AddTicks(9046), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ID", "Active", "Created", "Image", "ProductLineID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7062), "Images/Product/Product1/Line1/1.webp", 1, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7076), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 58, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7814), "Images/Product/Product8/Line2/1.webp", 18, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7815), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 57, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7811), "Images/Product/Product8/Line1/4.webp", 17, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7812), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 56, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7808), "Images/Product/Product8/Line1/3.webp", 17, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7809), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 55, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7806), "Images/Product/Product8/Line1/2.webp", 17, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7807), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 54, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7803), "Images/Product/Product8/Line1/1.webp", 17, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7804), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 53, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7800), "Images/Product/Product7/Line2/3.webp", 16, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7801), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 52, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7798), "Images/Product/Product7/Line2/2.webp", 16, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7799), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 59, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7817), "Images/Product/Product8/Line2/2.webp", 18, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7818), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 51, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7795), "Images/Product/Product7/Line2/1.jpg", 16, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7796), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 49, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7789), "Images/Product/Product7/Line1/2.webp", 15, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7790), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 48, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7786), "Images/Product/Product7/Line1/1.webp", 15, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7787), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 47, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7784), "Images/Product/Product6/Line2/4.webp", 14, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7785), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 46, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7781), "Images/Product/Product6/Line2/3.webp", 14, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7782), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 45, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7778), "Images/Product/Product6/Line2/2.webp", 14, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7779), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 44, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7775), "Images/Product/Product6/Line2/1.webp", 14, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7776), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 43, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7773), "Images/Product/Product6/Line1/5.webp", 13, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7774), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 50, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7792), "Images/Product/Product7/Line1/3.webp", 15, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7793), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 60, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7819), "Images/Product/Product8/Line2/3.webp", 18, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7820), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 61, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7822), "Images/Product/Product8/Line2/4.webp", 18, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7823), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 62, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7825), "Images/Product/Product8/Line2/5.jpg", 18, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7826), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 79, true, new DateTime(2022, 6, 8, 22, 33, 46, 48, DateTimeKind.Local).AddTicks(74), "Images/Product/Product11/Line1/3.webp", 23, new DateTime(2022, 6, 8, 22, 33, 46, 48, DateTimeKind.Local).AddTicks(75), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 78, true, new DateTime(2022, 6, 8, 22, 33, 46, 48, DateTimeKind.Local).AddTicks(71), "Images/Product/Product11/Line1/2.webp", 23, new DateTime(2022, 6, 8, 22, 33, 46, 48, DateTimeKind.Local).AddTicks(72), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 77, true, new DateTime(2022, 6, 8, 22, 33, 46, 48, DateTimeKind.Local).AddTicks(60), "Images/Product/Product11/Line1/1.webp", 23, new DateTime(2022, 6, 8, 22, 33, 46, 48, DateTimeKind.Local).AddTicks(66), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 68, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7841), "Images/Product/Product9/Line2/3.webp", 20, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7842), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 67, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7838), "Images/Product/Product9/Line2/2.webp", 20, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7839), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 66, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7836), "Images/Product/Product9/Line2/1.webp", 20, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7837), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 65, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7833), "Images/Product/Product9/Line1/3.webp", 19, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7834), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 64, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7830), "Images/Product/Product9/Line1/2.webp", 19, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7831), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 63, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7828), "Images/Product/Product9/Line1/1.webp", 19, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7829), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 76, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7863), "Images/Product/Product10/Line2/4.webp", 22, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7864), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 75, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7860), "Images/Product/Product10/Line2/3.webp", 22, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7861), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 74, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7857), "Images/Product/Product10/Line2/2.webp", 22, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7858), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 73, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7855), "Images/Product/Product10/Line2/1.webp", 22, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7856), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 72, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7852), "Images/Product/Product10/Line1/4.webp", 21, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7853), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 71, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7849), "Images/Product/Product10/Line1/3.webp", 21, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7850), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 70, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7847), "Images/Product/Product10/Line1/2.webp", 21, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7848), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 69, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7844), "Images/Product/Product10/Line1/1.webp", 21, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7845), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 42, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7770), "Images/Product/Product6/Line1/4.webp", 13, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7771), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 80, true, new DateTime(2022, 6, 8, 22, 33, 46, 48, DateTimeKind.Local).AddTicks(77), "Images/Product/Product11/Line1/4.webp", 23, new DateTime(2022, 6, 8, 22, 33, 46, 48, DateTimeKind.Local).AddTicks(78), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 41, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7767), "Images/Product/Product6/Line1/3.webp", 13, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7768), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 39, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7761), "Images/Product/Product6/Line1/1.webp", 13, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7762), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ID", "Active", "Created", "Image", "ProductLineID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 17, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7650), "Images/Product/Product2/Line2/4.webp", 5, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7651), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 16, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7647), "Images/Product/Product2/Line2/3.webp", 5, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7648), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 15, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7645), "Images/Product/Product2/Line2/2.webp", 5, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7646), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7642), "Images/Product/Product2/Line2/1.webp", 5, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7643), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7639), "Images/Product/Product2/Line1/4.jpg", 4, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7640), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7636), "Images/Product/Product2/Line1/3.webp", 4, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7637), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7634), "Images/Product/Product2/Line1/2.webp", 4, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7635), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 18, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7653), "Images/Product/Product3/Line1/1.webp", 6, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7654), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7631), "Images/Product/Product2/Line1/1.webp", 4, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7632), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7625), "Images/Product/Product1/Line3/2.webp", 3, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7626), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7622), "Images/Product/Product1/Line3/1.webp", 3, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7623), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7619), "Images/Product/Product1/Line2/3.webp", 2, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7620), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7617), "Images/Product/Product1/Line2/2.webp", 2, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7618), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7614), "Images/Product/Product1/Line2/1.webp", 2, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7615), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7611), "Images/Product/Product1/Line1/3.webp", 1, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7612), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7604), "Images/Product/Product1/Line1/2.webp", 1, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7608), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7628), "Images/Product/Product1/Line3/3.webp", 3, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7629), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 19, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7656), "Images/Product/Product3/Line1/2.webp", 6, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7657), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 20, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7658), "Images/Product/Product3/Line1/3.webp", 6, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7659), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 21, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7661), "Images/Product/Product3/Line2/1.webp", 7, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7662), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 38, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7758), "Images/Product/Product5/Line2/3.webp", 12, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7759), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 37, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7755), "Images/Product/Product5/Line2/2.webp", 12, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7756), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 36, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7702), "Images/Product/Product5/Line2/1.webp", 12, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7703), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 35, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7699), "Images/Product/Product5/Line1/3.webp", 11, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7700), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 34, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7697), "Images/Product/Product5/Line1/2.webp", 11, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7698), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 33, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7694), "Images/Product/Product5/Line1/1.webp", 11, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7695), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 32, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7691), "Images/Product/Product4/Line2/3.webp", 10, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7692), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 31, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7688), "Images/Product/Product4/Line2/2.webp", 10, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7689), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 30, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7686), "Images/Product/Product4/Line2/1.webp", 10, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7687), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 29, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7683), "Images/Product/Product4/Line1/3.webp", 9, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7684), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 28, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7680), "Images/Product/Product4/Line1/2.webp", 9, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7681), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 27, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7678), "Images/Product/Product4/Line1/1.webp", 9, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7679), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 26, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7675), "Images/Product/Product3/Line3/3.webp", 8, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7676), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 25, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7672), "Images/Product/Product3/Line3/2.webp", 8, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7673), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 24, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7669), "Images/Product/Product3/Line3/1.webp", 8, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7670), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 23, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7667), "Images/Product/Product3/Line2/3.webp", 7, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7668), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 22, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7664), "Images/Product/Product3/Line2/2.webp", 7, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7665), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 40, true, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7764), "Images/Product/Product6/Line1/2.webp", 13, new DateTime(2022, 6, 8, 22, 33, 46, 47, DateTimeKind.Local).AddTicks(7765), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 81, true, new DateTime(2022, 6, 8, 22, 33, 46, 48, DateTimeKind.Local).AddTicks(79), "Images/Product/Product11/Line1/5.webp", 23, new DateTime(2022, 6, 8, 22, 33, 46, 48, DateTimeKind.Local).AddTicks(80), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
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
