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
                    { new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"), "c75f88e9-bb0b-4013-b00c-4cf4084476c4", "Customer", "CUSTOMER" },
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "425bc44e-fcac-4b41-9f28-97f62bef585d", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Active", "Created", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 15, true, new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(3217), "Tops", new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(3218), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, true, new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(3214), "Swimsuits & Cover-Ups", new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(3215), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, true, new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(3211), "Sweaters & Knits", new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(3212), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, true, new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(3208), "Skirts", new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(3210), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, true, new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(3206), "Shorts", new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(3207), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(3203), "Rompers", new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(3204), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 5, 20, 23, 0, 27, 710, DateTimeKind.Local).AddTicks(1001), "Activewear", new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(1919), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(3197), "Loungewear", new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(3198), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(3194), "Lingerie & Sleepwear", new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(3195), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(3191), "Leather", new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(3193), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(3189), "Jumpsuits", new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(3190), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(3186), "Jackets & Coats", new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(3187), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(3183), "Dresses", new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(3184), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(3200), "Pants", new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(3201), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(3176), "Denim", new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(3180), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "Active", "Created", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(5780), "Vietnam", new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(5785), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(6064), "China", new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(6067), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(6069), "America", new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(6070), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Designers",
                columns: new[] { "ID", "Active", "Created", "Description", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 10, true, new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(9480), null, "ALLSAINTS", new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(9482), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(9478), null, "ASTR the Label", new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(9479), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(9475), null, "retrofete", new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(9476), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(9472), null, "SOLACE London", new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(9473), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(9466), null, "AFRM", new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(9467), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(9463), null, "Michael Costello", new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(9464), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(9407), null, "krisa", new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(9409), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(9403), null, "Sabina Musayev", new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(9405), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(9122), null, "ELLIATT", new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(9127), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(9469), null, "Amanda Uprichard", new DateTime(2022, 5, 20, 23, 0, 27, 711, DateTimeKind.Local).AddTicks(9470), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Occations",
                columns: new[] { "ID", "Active", "Created", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2022, 5, 20, 23, 0, 27, 712, DateTimeKind.Local).AddTicks(1330), "To A Special Event", new DateTime(2022, 5, 20, 23, 0, 27, 712, DateTimeKind.Local).AddTicks(1336), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 5, 20, 23, 0, 27, 712, DateTimeKind.Local).AddTicks(1606), "On Vacation", new DateTime(2022, 5, 20, 23, 0, 27, 712, DateTimeKind.Local).AddTicks(1609), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 5, 20, 23, 0, 27, 712, DateTimeKind.Local).AddTicks(1611), "For A Night Out", new DateTime(2022, 5, 20, 23, 0, 27, 712, DateTimeKind.Local).AddTicks(1612), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 5, 20, 23, 0, 27, 712, DateTimeKind.Local).AddTicks(1614), "On The Weekend", new DateTime(2022, 5, 20, 23, 0, 27, 712, DateTimeKind.Local).AddTicks(1615), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "ID", "Active", "Created", "Key", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 7, true, new DateTime(2022, 5, 20, 23, 0, 27, 712, DateTimeKind.Local).AddTicks(4366), "XXL", new DateTime(2022, 5, 20, 23, 0, 27, 712, DateTimeKind.Local).AddTicks(4367), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 5, 20, 23, 0, 27, 712, DateTimeKind.Local).AddTicks(4360), "L", new DateTime(2022, 5, 20, 23, 0, 27, 712, DateTimeKind.Local).AddTicks(4362), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 5, 20, 23, 0, 27, 712, DateTimeKind.Local).AddTicks(4363), "XL", new DateTime(2022, 5, 20, 23, 0, 27, 712, DateTimeKind.Local).AddTicks(4364), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 5, 20, 23, 0, 27, 712, DateTimeKind.Local).AddTicks(4355), "S", new DateTime(2022, 5, 20, 23, 0, 27, 712, DateTimeKind.Local).AddTicks(4356), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 5, 20, 23, 0, 27, 712, DateTimeKind.Local).AddTicks(4350), "XS", new DateTime(2022, 5, 20, 23, 0, 27, 712, DateTimeKind.Local).AddTicks(4353), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 5, 20, 23, 0, 27, 712, DateTimeKind.Local).AddTicks(4358), "M", new DateTime(2022, 5, 20, 23, 0, 27, 712, DateTimeKind.Local).AddTicks(4359), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 5, 20, 23, 0, 27, 712, DateTimeKind.Local).AddTicks(4075), "XXS", new DateTime(2022, 5, 20, 23, 0, 27, 712, DateTimeKind.Local).AddTicks(4080), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "ID", "Active", "Created", "Name", "ParentID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[] { 9, true, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(2676), "Sundresses", null, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(2678), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "ID", "Active", "Created", "Name", "ParentID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 8, true, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(2674), "Gingham", null, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(2675), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(2671), "Floral", null, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(2672), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(2662), "Bodycon", null, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(2664), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(2665), "Denim", null, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(2666), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(2660), "Bohemian", null, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(2661), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(2655), "One Shoulder", null, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(2658), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(2380), "Cocktail", null, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(2386), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(2668), "Wrap", null, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(2669), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Textures",
                columns: new[] { "ID", "Active", "Created", "Image", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 22, true, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1966), "Images/Texture/taffy-pink.webp", "Taffy Pink", new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1967), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 21, true, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1962), "Images/Texture/moonglow-white.webp", "Moonglow White", new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1964), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 20, true, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1959), "Images/Texture/pink-orchid.webp", "Pink Orchid", new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1960), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 19, true, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1956), "Images/Texture/olive.webp", "Olive", new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1957), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 18, true, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1953), "Images/Texture/white.png", "White", new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1954), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 17, true, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1950), "Images/Texture/green.webp", "Green", new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1951), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 16, true, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1947), "Images/Texture/pink.webp", "Pink", new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1948), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 15, true, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1944), "Images/Texture/cream.webp", "Cream", new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1945), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, true, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1940), "Images/Texture/black-sequin.webp", "Black Sequin", new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1941), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, true, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1936), "Images/Texture/white-sequin.webp", "White Sequin", new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1938), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, true, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1882), "Images/Texture/abstract-neon-dot.webp", "Abstract Neon Dot", new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1883), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1879), "Images/Texture/baby-blue.webp", "Baby Blue", new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1880), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1872), "Images/Texture/candy.webp", "Candy", new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1873), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1869), "Images/Texture/rosa.webp", "Rosa", new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1870), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1866), "Images/Texture/black.webp", "Black", new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1867), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1863), "Images/Texture/multicolor-blue.webp", "Multicolor Blue", new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1864), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1859), "Images/Texture/blush.webp", "Blush", new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1861), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1856), "Images/Texture/blue.webp", "Blue", new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1857), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1849), "Images/Texture/marigold.webp", "Marigold", new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1852), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1314), "Images/Texture/lilac.webp", "Lilac", new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1323), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, true, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1885), "Images/Texture/multi-watercolor.webp", "Multi Watercolor", new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1886), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1876), "Images/Texture/taupe.webp", "Taupe", new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(1877), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), 0, "6dc24f81-234c-42fc-b9e8-3c75e706bd9b", "user@shop.com", false, false, null, "USER@SHOP.COM", "USER", "AQAAAAEAACcQAAAAEEJeFAe/i94pjAmElwVyN6j8lh5fmKZ86cTK94K0J+d5xHy6VrLpWC7OYzr3o1fHyg==", "0125454545", false, null, false, "user" },
                    { new Guid("50892ac9-ebe0-4c8d-f28e-08d9638e12dc"), 0, "765532ae-6d06-41ee-bfba-048fc189307d", "user-bak@shop.com", false, false, null, "USER-BAK@SHOP.COM", "USER-BAK", "AQAAAAEAACcQAAAAEJP309OWM/EPJth0ySFz5+kuiHDrrFhyN+tzbXY0h5raT/ERR2VZXbztcXtmHfiM6w==", "0125454546", false, null, false, "user-bak" },
                    { new Guid("170ca4bc-ef9f-4de7-ae96-08d962dad25f"), 0, "c041ef37-20bf-4d40-91b7-e6ffc2678501", "admin@shop.com", false, false, null, "ADMIN@SHOP.COM", "ADMIN", "AQAAAAEAACcQAAAAECT+HW9M04BlJULJA+beBrCq3eL9wc8+BbVtVMnlZIoaO4KGJzhwWA1JkNL3Wf0ACw==", "0323265665", false, null, false, "admin" },
                    { new Guid("0dd37c3c-4694-429e-623b-08d962dbded7"), 0, "5771bc35-46ee-4937-af7a-67297687142e", "admin-bak@shop.com", false, false, null, "ADMIN-BAK@SHOP.COM", "ADMIN-BAK", "AQAAAAEAACcQAAAAEGQRCiSRiluSaJhzGxpt+oBWQgxF2n2h34sZluPkwcL76cxHP4DBiAmkV22ZeOtBPQ==", "0323265666", false, null, false, "admin-bak" }
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
                    { 11, true, 3, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(5758), "Los Angeles", new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(5759), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, 3, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(5755), "New York", new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(5757), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, 2, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(5752), "Shanghai", new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(5753), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, 1, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(5222), "Can Tho", new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(5227), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, 2, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(5747), "Ma Cau", new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(5748), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, 2, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(5744), "Hong Kong", new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(5745), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, 1, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(5741), "Ho Chi Minh", new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(5742), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, 1, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(5729), "Da Nang", new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(5733), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, 1, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(5735), "Hai Phong", new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(5736), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, 1, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(5738), "Hanoi", new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(5739), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, 2, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(5749), "Beijing", new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(5751), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "FavoriteDesigners",
                columns: new[] { "ID", "Active", "Created", "DesignerID", "Updated", "UserID", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 5, true, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(9494), 9, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(9495), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(9489), 7, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(9490), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(9484), 5, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(9485), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(9471), 3, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(9475), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(8845), 2, new DateTime(2022, 5, 20, 23, 0, 27, 713, DateTimeKind.Local).AddTicks(8850), new Guid("61ae2038-97f2-45e5-91ae-08d961fa9be8"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Active", "CategoryID", "Created", "Description", "DesignerID", "LengthState", "Name", "Price", "SleeveLengthState", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 11, true, 2, new DateTime(2022, 5, 20, 23, 0, 27, 714, DateTimeKind.Local).AddTicks(9565), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 10, 3, "Morgan Biker Jacket", 659.0, 0, new DateTime(2022, 5, 20, 23, 0, 27, 714, DateTimeKind.Local).AddTicks(9566), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, 3, new DateTime(2022, 5, 20, 23, 0, 27, 714, DateTimeKind.Local).AddTicks(9561), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 8, 2, "Katya Dress", 795.0, 2, new DateTime(2022, 5, 20, 23, 0, 27, 714, DateTimeKind.Local).AddTicks(9562), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, 3, new DateTime(2022, 5, 20, 23, 0, 27, 714, DateTimeKind.Local).AddTicks(9554), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 8, 3, "Margot Dress", 895.0, 2, new DateTime(2022, 5, 20, 23, 0, 27, 714, DateTimeKind.Local).AddTicks(9555), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, 3, new DateTime(2022, 5, 20, 23, 0, 27, 714, DateTimeKind.Local).AddTicks(9550), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 7, 0, "Elina Mini Dress", 527.0, 3, new DateTime(2022, 5, 20, 23, 0, 27, 714, DateTimeKind.Local).AddTicks(9551), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, 3, new DateTime(2022, 5, 20, 23, 0, 27, 714, DateTimeKind.Local).AddTicks(9546), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 6, 2, "x REVOLVE Samba Gown", 290.0, 3, new DateTime(2022, 5, 20, 23, 0, 27, 714, DateTimeKind.Local).AddTicks(9547), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, 3, new DateTime(2022, 5, 20, 23, 0, 27, 714, DateTimeKind.Local).AddTicks(9455), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 4, 2, "Jake Gown", 198.0, 2, new DateTime(2022, 5, 20, 23, 0, 27, 714, DateTimeKind.Local).AddTicks(9456), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, 3, new DateTime(2022, 5, 20, 23, 0, 27, 714, DateTimeKind.Local).AddTicks(9451), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 3, 0, "Drape Button Front Mini", 216.0, 1, new DateTime(2022, 5, 20, 23, 0, 27, 714, DateTimeKind.Local).AddTicks(9452), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, 3, new DateTime(2022, 5, 20, 23, 0, 27, 714, DateTimeKind.Local).AddTicks(9440), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 2, 3, "X REVOLVE Carry Mini Dress", 232.0, 0, new DateTime(2022, 5, 20, 23, 0, 27, 714, DateTimeKind.Local).AddTicks(9447), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, 3, new DateTime(2022, 5, 20, 23, 0, 27, 714, DateTimeKind.Local).AddTicks(6962), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 1, 2, "X REVOLVE Cassini Dress", 187.0, 2, new DateTime(2022, 5, 20, 23, 0, 27, 714, DateTimeKind.Local).AddTicks(6968), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, 3, new DateTime(2022, 5, 20, 23, 0, 27, 714, DateTimeKind.Local).AddTicks(9557), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 9, 2, "Valinda Dress", 128.0, 2, new DateTime(2022, 5, 20, 23, 0, 27, 714, DateTimeKind.Local).AddTicks(9559), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, 3, new DateTime(2022, 5, 20, 23, 0, 27, 714, DateTimeKind.Local).AddTicks(9542), "Self: 100% poly\nLining: 92 % poly,8 % spandex\nMade in China\nHand wash\nFully lined\nHidden side zipper closure\nOne - shoulder styling\nSide ruched detail\nHammered satin fabric\nRevolve Style No.ELLI - WD346\nManufacturer Style No.E5032105", 5, 2, "Shailene Dress", 88.0, 0, new DateTime(2022, 5, 20, 23, 0, 27, 714, DateTimeKind.Local).AddTicks(9543), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductLines",
                columns: new[] { "ID", "Active", "Created", "ProductID", "TextureID", "TextureID1", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 7, true, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8288), 3, 7, null, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8289), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8291), 3, 8, null, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8292), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8293), 4, 9, null, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8295), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8296), 4, 10, null, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8297), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, true, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8299), 5, 11, null, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8300), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, true, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8302), 5, 12, null, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8303), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, true, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8305), 6, 13, null, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8306), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 20, true, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8324), 9, 20, null, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8326), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, true, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8308), 6, 14, null, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8309), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 16, true, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8313), 7, 16, null, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8314), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 17, true, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8316), 8, 17, null, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8317), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 18, true, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8319), 8, 18, null, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8320), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 21, true, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8327), 10, 21, null, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8329), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 22, true, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8330), 10, 22, null, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8331), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 19, true, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8322), 9, 19, null, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8323), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 15, true, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8310), 7, 15, null, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8312), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8285), 3, 6, null, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8286), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 23, true, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8333), 11, 6, null, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8334), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8268), 1, 2, null, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8272), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8277), 2, 4, null, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8278), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(7780), 1, 1, null, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(7789), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8281), 2, 5, null, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8282), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8274), 1, 3, null, new DateTime(2022, 5, 20, 23, 0, 27, 715, DateTimeKind.Local).AddTicks(8275), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
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
                    { 7, true, 6, new DateTime(2022, 5, 20, 23, 0, 27, 719, DateTimeKind.Local).AddTicks(5818), "Hong Kong Island", new DateTime(2022, 5, 20, 23, 0, 27, 719, DateTimeKind.Local).AddTicks(5819), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, 6, new DateTime(2022, 5, 20, 23, 0, 27, 719, DateTimeKind.Local).AddTicks(5824), "Kowloon West", new DateTime(2022, 5, 20, 23, 0, 27, 719, DateTimeKind.Local).AddTicks(5825), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, 2, new DateTime(2022, 5, 20, 23, 0, 27, 719, DateTimeKind.Local).AddTicks(5815), "Thanh Khe", new DateTime(2022, 5, 20, 23, 0, 27, 719, DateTimeKind.Local).AddTicks(5816), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "ID", "Active", "CityID", "Created", "Name", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 5, true, 2, new DateTime(2022, 5, 20, 23, 0, 27, 719, DateTimeKind.Local).AddTicks(5812), "Cam Le", new DateTime(2022, 5, 20, 23, 0, 27, 719, DateTimeKind.Local).AddTicks(5814), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, 2, new DateTime(2022, 5, 20, 23, 0, 27, 719, DateTimeKind.Local).AddTicks(5810), "Hai Chau", new DateTime(2022, 5, 20, 23, 0, 27, 719, DateTimeKind.Local).AddTicks(5811), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, 1, new DateTime(2022, 5, 20, 23, 0, 27, 719, DateTimeKind.Local).AddTicks(5807), "O Mon", new DateTime(2022, 5, 20, 23, 0, 27, 719, DateTimeKind.Local).AddTicks(5808), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, 1, new DateTime(2022, 5, 20, 23, 0, 27, 719, DateTimeKind.Local).AddTicks(5800), "Binh Thuy", new DateTime(2022, 5, 20, 23, 0, 27, 719, DateTimeKind.Local).AddTicks(5804), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, 6, new DateTime(2022, 5, 20, 23, 0, 27, 719, DateTimeKind.Local).AddTicks(5821), "New Territories East", new DateTime(2022, 5, 20, 23, 0, 27, 719, DateTimeKind.Local).AddTicks(5822), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, 1, new DateTime(2022, 5, 20, 23, 0, 27, 719, DateTimeKind.Local).AddTicks(5146), "Ninh Kieu", new DateTime(2022, 5, 20, 23, 0, 27, 719, DateTimeKind.Local).AddTicks(5155), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "LineQuantities",
                columns: new[] { "ID", "ProductLineID", "Quantity", "SizeID" },
                values: new object[,]
                {
                    { 80, 12, 99, 3 },
                    { 74, 11, 99, 4 },
                    { 75, 11, 99, 5 },
                    { 76, 11, 99, 6 },
                    { 77, 11, 99, 7 },
                    { 147, 21, 99, 7 },
                    { 146, 21, 99, 6 },
                    { 145, 21, 99, 5 },
                    { 73, 11, 99, 3 },
                    { 78, 12, 99, 1 },
                    { 144, 21, 99, 4 },
                    { 81, 12, 99, 4 },
                    { 82, 12, 99, 5 },
                    { 83, 12, 99, 6 },
                    { 84, 12, 99, 7 },
                    { 143, 21, 99, 3 },
                    { 142, 21, 99, 2 },
                    { 79, 12, 99, 2 },
                    { 72, 11, 99, 2 },
                    { 71, 11, 99, 1 },
                    { 70, 10, 99, 7 },
                    { 151, 22, 99, 4 },
                    { 150, 22, 99, 3 },
                    { 57, 9, 99, 1 },
                    { 58, 9, 99, 2 },
                    { 118, 17, 99, 6 },
                    { 60, 9, 99, 4 },
                    { 61, 9, 99, 5 },
                    { 62, 9, 99, 6 },
                    { 63, 9, 99, 7 },
                    { 149, 22, 99, 2 },
                    { 148, 22, 99, 1 },
                    { 64, 10, 99, 1 },
                    { 65, 10, 99, 2 },
                    { 66, 10, 99, 3 },
                    { 67, 10, 99, 4 },
                    { 68, 10, 99, 5 },
                    { 69, 10, 99, 6 },
                    { 141, 21, 99, 1 },
                    { 152, 22, 99, 5 },
                    { 85, 13, 99, 1 },
                    { 87, 13, 99, 3 }
                });

            migrationBuilder.InsertData(
                table: "LineQuantities",
                columns: new[] { "ID", "ProductLineID", "Quantity", "SizeID" },
                values: new object[,]
                {
                    { 104, 15, 99, 6 },
                    { 105, 15, 99, 7 },
                    { 121, 18, 99, 2 },
                    { 120, 18, 99, 1 },
                    { 106, 16, 99, 1 },
                    { 107, 16, 99, 2 },
                    { 108, 16, 99, 3 },
                    { 103, 15, 99, 5 },
                    { 109, 16, 99, 4 },
                    { 111, 16, 99, 6 },
                    { 112, 16, 99, 7 },
                    { 113, 17, 99, 1 },
                    { 114, 17, 99, 2 },
                    { 115, 17, 99, 3 },
                    { 116, 17, 99, 4 },
                    { 117, 17, 99, 5 },
                    { 110, 16, 99, 5 },
                    { 102, 15, 99, 4 },
                    { 101, 15, 99, 3 },
                    { 100, 15, 99, 2 },
                    { 88, 13, 99, 4 },
                    { 89, 13, 99, 5 },
                    { 90, 13, 99, 6 },
                    { 91, 13, 99, 7 },
                    { 126, 18, 99, 7 },
                    { 125, 18, 99, 6 },
                    { 92, 14, 99, 1 },
                    { 93, 14, 99, 2 },
                    { 94, 14, 99, 3 },
                    { 95, 14, 99, 4 },
                    { 96, 14, 99, 5 },
                    { 97, 14, 99, 6 },
                    { 98, 14, 99, 7 },
                    { 124, 18, 99, 5 },
                    { 123, 18, 99, 4 },
                    { 122, 18, 99, 3 },
                    { 99, 15, 99, 1 },
                    { 86, 13, 99, 2 },
                    { 56, 8, 99, 7 },
                    { 59, 9, 99, 3 },
                    { 54, 8, 99, 5 },
                    { 16, 3, 99, 2 }
                });

            migrationBuilder.InsertData(
                table: "LineQuantities",
                columns: new[] { "ID", "ProductLineID", "Quantity", "SizeID" },
                values: new object[,]
                {
                    { 17, 3, 99, 3 },
                    { 18, 3, 99, 4 },
                    { 19, 3, 99, 5 },
                    { 20, 3, 99, 6 },
                    { 21, 3, 99, 7 },
                    { 135, 20, 99, 2 },
                    { 15, 3, 99, 1 },
                    { 134, 20, 99, 1 },
                    { 23, 4, 99, 2 },
                    { 24, 4, 99, 3 },
                    { 25, 4, 99, 4 },
                    { 26, 4, 99, 5 },
                    { 55, 8, 99, 6 },
                    { 28, 4, 99, 7 },
                    { 133, 19, 99, 7 },
                    { 22, 4, 99, 1 },
                    { 132, 19, 99, 6 },
                    { 136, 20, 99, 3 },
                    { 138, 20, 99, 5 },
                    { 1, 1, 99, 1 },
                    { 2, 1, 99, 2 },
                    { 3, 1, 99, 3 },
                    { 4, 1, 99, 4 },
                    { 5, 1, 99, 5 },
                    { 6, 1, 99, 6 },
                    { 7, 1, 99, 7 },
                    { 137, 20, 99, 4 },
                    { 140, 20, 99, 7 },
                    { 8, 2, 99, 1 },
                    { 9, 2, 99, 2 },
                    { 10, 2, 99, 3 },
                    { 11, 2, 99, 4 },
                    { 12, 2, 99, 5 },
                    { 13, 2, 99, 6 },
                    { 14, 2, 99, 7 },
                    { 139, 20, 99, 6 },
                    { 131, 19, 99, 5 },
                    { 27, 4, 99, 6 },
                    { 30, 5, 99, 2 },
                    { 41, 6, 99, 6 },
                    { 42, 6, 99, 7 },
                    { 29, 5, 99, 1 }
                });

            migrationBuilder.InsertData(
                table: "LineQuantities",
                columns: new[] { "ID", "ProductLineID", "Quantity", "SizeID" },
                values: new object[,]
                {
                    { 43, 7, 99, 1 },
                    { 44, 7, 99, 2 },
                    { 45, 7, 99, 3 },
                    { 46, 7, 99, 4 },
                    { 40, 6, 99, 5 },
                    { 47, 7, 99, 5 },
                    { 49, 7, 99, 7 },
                    { 154, 22, 99, 7 },
                    { 153, 22, 99, 6 },
                    { 50, 8, 99, 1 },
                    { 51, 8, 99, 2 },
                    { 52, 8, 99, 3 },
                    { 53, 8, 99, 4 },
                    { 48, 7, 99, 6 },
                    { 39, 6, 99, 4 },
                    { 127, 19, 99, 1 },
                    { 37, 6, 99, 2 },
                    { 31, 5, 99, 3 },
                    { 32, 5, 99, 4 },
                    { 33, 5, 99, 5 },
                    { 34, 5, 99, 6 },
                    { 38, 6, 99, 3 },
                    { 130, 19, 99, 4 },
                    { 129, 19, 99, 3 },
                    { 128, 19, 99, 2 },
                    { 35, 5, 99, 7 },
                    { 119, 17, 99, 7 },
                    { 36, 6, 99, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ID", "Active", "Created", "Image", "ProductLineID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 79, true, new DateTime(2022, 5, 20, 23, 0, 27, 718, DateTimeKind.Local).AddTicks(616), "Images/Product/Product11/Line1/3.webp", 23, new DateTime(2022, 5, 20, 23, 0, 27, 718, DateTimeKind.Local).AddTicks(617), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 78, true, new DateTime(2022, 5, 20, 23, 0, 27, 718, DateTimeKind.Local).AddTicks(612), "Images/Product/Product11/Line1/2.webp", 23, new DateTime(2022, 5, 20, 23, 0, 27, 718, DateTimeKind.Local).AddTicks(614), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 66, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8088), "Images/Product/Product9/Line2/1.webp", 20, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8089), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 72, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8107), "Images/Product/Product10/Line1/4.webp", 21, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8108), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 58, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8030), "Images/Product/Product8/Line2/1.webp", 18, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8032), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 59, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8066), "Images/Product/Product8/Line2/2.webp", 18, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8067), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 60, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8069), "Images/Product/Product8/Line2/3.webp", 18, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8070), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 61, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8072), "Images/Product/Product8/Line2/4.webp", 18, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8073), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 71, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8104), "Images/Product/Product10/Line1/3.webp", 21, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8105), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 73, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8110), "Images/Product/Product10/Line2/1.webp", 22, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8111), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 74, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8113), "Images/Product/Product10/Line2/2.webp", 22, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8114), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 63, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8078), "Images/Product/Product9/Line1/1.webp", 19, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8080), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 77, true, new DateTime(2022, 5, 20, 23, 0, 27, 718, DateTimeKind.Local).AddTicks(603), "Images/Product/Product11/Line1/1.webp", 23, new DateTime(2022, 5, 20, 23, 0, 27, 718, DateTimeKind.Local).AddTicks(608), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 75, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8116), "Images/Product/Product10/Line2/3.webp", 22, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8117), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ID", "Active", "Created", "Image", "ProductLineID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 68, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8094), "Images/Product/Product9/Line2/3.webp", 20, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8095), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 62, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8075), "Images/Product/Product8/Line2/5.jpg", 18, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8077), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 67, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8091), "Images/Product/Product9/Line2/2.webp", 20, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8092), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 65, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8085), "Images/Product/Product9/Line1/3.webp", 19, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8086), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 76, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8119), "Images/Product/Product10/Line2/4.webp", 22, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8120), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 64, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8082), "Images/Product/Product9/Line1/2.webp", 19, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8083), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 69, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8097), "Images/Product/Product10/Line1/1.webp", 21, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8099), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 70, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8100), "Images/Product/Product10/Line1/2.webp", 21, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8102), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 1, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7217), "Images/Product/Product1/Line1/1.webp", 1, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7231), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 56, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8024), "Images/Product/Product8/Line1/3.webp", 17, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8025), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 26, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7930), "Images/Product/Product3/Line3/3.webp", 8, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7932), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 25, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7927), "Images/Product/Product3/Line3/2.webp", 8, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7929), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 24, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7924), "Images/Product/Product3/Line3/1.webp", 8, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7925), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 23, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7921), "Images/Product/Product3/Line2/3.webp", 7, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7922), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 22, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7918), "Images/Product/Product3/Line2/2.webp", 7, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7919), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 21, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7915), "Images/Product/Product3/Line2/1.webp", 7, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7916), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 20, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7912), "Images/Product/Product3/Line1/3.webp", 6, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7913), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 19, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7909), "Images/Product/Product3/Line1/2.webp", 6, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7910), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 18, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7905), "Images/Product/Product3/Line1/1.webp", 6, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7906), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 17, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7902), "Images/Product/Product2/Line2/4.webp", 5, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7903), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 16, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7898), "Images/Product/Product2/Line2/3.webp", 5, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7900), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 15, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7849), "Images/Product/Product2/Line2/2.webp", 5, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7850), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 14, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7846), "Images/Product/Product2/Line2/1.webp", 5, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7847), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 13, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7843), "Images/Product/Product2/Line1/4.jpg", 4, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7844), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 12, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7839), "Images/Product/Product2/Line1/3.webp", 4, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7841), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 11, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7836), "Images/Product/Product2/Line1/2.webp", 4, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7837), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 10, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7833), "Images/Product/Product2/Line1/1.webp", 4, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7834), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 9, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7829), "Images/Product/Product1/Line3/3.webp", 3, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7831), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 8, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7826), "Images/Product/Product1/Line3/2.webp", 3, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7828), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 7, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7823), "Images/Product/Product1/Line3/1.webp", 3, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7824), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 6, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7820), "Images/Product/Product1/Line2/3.webp", 2, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7821), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 5, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7816), "Images/Product/Product1/Line2/2.webp", 2, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7818), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 4, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7813), "Images/Product/Product1/Line2/1.webp", 2, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7814), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 3, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7810), "Images/Product/Product1/Line1/3.webp", 1, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7811), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 2, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7802), "Images/Product/Product1/Line1/2.webp", 1, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7806), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 27, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7934), "Images/Product/Product4/Line1/1.webp", 9, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7935), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 28, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7937), "Images/Product/Product4/Line1/2.webp", 9, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7938), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 29, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7940), "Images/Product/Product4/Line1/3.webp", 9, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7941), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 30, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7943), "Images/Product/Product4/Line2/1.webp", 10, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7944), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 55, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8021), "Images/Product/Product8/Line1/2.webp", 17, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8022), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 54, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8018), "Images/Product/Product8/Line1/1.webp", 17, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8019), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 53, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8015), "Images/Product/Product7/Line2/3.webp", 16, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8016), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ID", "Active", "Created", "Image", "ProductLineID", "Updated", "UserIDCreated", "UserIDUpdated" },
                values: new object[,]
                {
                    { 52, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8011), "Images/Product/Product7/Line2/2.webp", 16, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8013), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 51, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8008), "Images/Product/Product7/Line2/1.jpg", 16, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8009), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 50, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8005), "Images/Product/Product7/Line1/3.webp", 15, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8006), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 49, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8002), "Images/Product/Product7/Line1/2.webp", 15, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8003), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 48, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7999), "Images/Product/Product7/Line1/1.webp", 15, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8000), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 47, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7996), "Images/Product/Product6/Line2/4.webp", 14, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7997), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 46, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7993), "Images/Product/Product6/Line2/3.webp", 14, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7994), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 45, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7990), "Images/Product/Product6/Line2/2.webp", 14, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7991), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 44, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7987), "Images/Product/Product6/Line2/1.webp", 14, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7988), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 57, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8027), "Images/Product/Product8/Line1/4.webp", 17, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(8028), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 43, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7983), "Images/Product/Product6/Line1/5.webp", 13, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7985), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 41, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7977), "Images/Product/Product6/Line1/3.webp", 13, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7978), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 40, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7974), "Images/Product/Product6/Line1/2.webp", 13, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7975), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 39, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7971), "Images/Product/Product6/Line1/1.webp", 13, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7972), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 80, true, new DateTime(2022, 5, 20, 23, 0, 27, 718, DateTimeKind.Local).AddTicks(619), "Images/Product/Product11/Line1/4.webp", 23, new DateTime(2022, 5, 20, 23, 0, 27, 718, DateTimeKind.Local).AddTicks(620), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 38, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7968), "Images/Product/Product5/Line2/3.webp", 12, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7969), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 37, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7964), "Images/Product/Product5/Line2/2.webp", 12, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7966), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 36, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7961), "Images/Product/Product5/Line2/1.webp", 12, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7963), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 35, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7958), "Images/Product/Product5/Line1/3.webp", 11, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7960), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 34, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7955), "Images/Product/Product5/Line1/2.webp", 11, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7956), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 33, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7952), "Images/Product/Product5/Line1/1.webp", 11, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7953), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 32, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7949), "Images/Product/Product4/Line2/3.webp", 10, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7950), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 31, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7946), "Images/Product/Product4/Line2/2.webp", 10, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7947), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 42, true, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7980), "Images/Product/Product6/Line1/4.webp", 13, new DateTime(2022, 5, 20, 23, 0, 27, 717, DateTimeKind.Local).AddTicks(7981), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { 81, true, new DateTime(2022, 5, 20, 23, 0, 27, 718, DateTimeKind.Local).AddTicks(622), "Images/Product/Product11/Line1/5.webp", 23, new DateTime(2022, 5, 20, 23, 0, 27, 718, DateTimeKind.Local).AddTicks(623), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
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
