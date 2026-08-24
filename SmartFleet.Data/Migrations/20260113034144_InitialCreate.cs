using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountMasters",
                columns: table => new
                {
                    AccountID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentAccountID = table.Column<int>(type: "int", nullable: false),
                    AccountCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AccountGroupCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    BranchID = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountMasters", x => x.AccountID);
                });

            migrationBuilder.CreateTable(
                name: "BillTransaction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BillDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalTaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrandAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    YearCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxPer = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillTransaction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ContactPhone = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CompanyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PANNo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    GSTNo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    SACNo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ContactPhone = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    EmailId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PANNo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    GSTNo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    SACNo = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    LicensedValidTill = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JournalEntries",
                columns: table => new
                {
                    JournalEntryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Narration = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournalEntries", x => x.JournalEntryId);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ContactPerson = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LocationType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    BranchID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuMasters",
                columns: table => new
                {
                    MenuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModuleID = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: true),
                    url = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    orderNo = table.Column<int>(type: "int", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    IconName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuMasters", x => x.MenuID);
                });

            migrationBuilder.CreateTable(
                name: "ModuleMasters",
                columns: table => new
                {
                    ModuleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModuleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModuleVersion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleMasters", x => x.ModuleID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    ProductCategory = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    BranchID = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    BranchID = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Vehilces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    VehicleType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tons = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Make = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    year = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsOwn = table.Column<bool>(type: "bit", nullable: false),
                    BranchID = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehilces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ContactPerson = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TaxNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PaymentTerms = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CustomerType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BillingMode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GSTNo = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    PanNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    BranchID = table.Column<int>(type: "int", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InvoiceTemplateName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_AccountMasters_AccountId",
                        column: x => x.AccountId,
                        principalTable: "AccountMasters",
                        principalColumn: "AccountID");
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    EmpAccountID = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    BranchID = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_AccountMasters_EmpAccountID",
                        column: x => x.EmpAccountID,
                        principalTable: "AccountMasters",
                        principalColumn: "AccountID");
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ContactPerson = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TaxNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PaymentTerms = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CustomerType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BillingMode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    BranchID = table.Column<int>(type: "int", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vendors_AccountMasters_AccountId",
                        column: x => x.AccountId,
                        principalTable: "AccountMasters",
                        principalColumn: "AccountID");
                });

            migrationBuilder.CreateTable(
                name: "BillItemDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TripId = table.Column<int>(type: "int", nullable: false),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Route = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OriginId = table.Column<int>(type: "int", nullable: false),
                    DestinationId = table.Column<int>(type: "int", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoadingCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CommissionAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AdditionalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MtnNo = table.Column<int>(type: "int", nullable: false),
                    Kms = table.Column<int>(type: "int", nullable: false),
                    LrNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BTId = table.Column<int>(type: "int", nullable: false),
                    BillId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillItemDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillItemDetails_BillTransaction_BillId",
                        column: x => x.BillId,
                        principalTable: "BillTransaction",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JournalEntriesLine",
                columns: table => new
                {
                    JournalEntryLineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JournalEntryId = table.Column<int>(type: "int", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    Debit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Credit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournalEntriesLine", x => x.JournalEntryLineId);
                    table.ForeignKey(
                        name: "FK_JournalEntriesLine_AccountMasters_AccountId",
                        column: x => x.AccountId,
                        principalTable: "AccountMasters",
                        principalColumn: "AccountID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JournalEntriesLine_JournalEntries_JournalEntryId",
                        column: x => x.JournalEntryId,
                        principalTable: "JournalEntries",
                        principalColumn: "JournalEntryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Receipts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiptDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReceiptMode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ToAccountId = table.Column<int>(type: "int", nullable: false),
                    ReferenceNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    JournalEntryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receipts_AccountMasters_ToAccountId",
                        column: x => x.ToAccountId,
                        principalTable: "AccountMasters",
                        principalColumn: "AccountID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receipts_JournalEntries_JournalEntryId",
                        column: x => x.JournalEntryId,
                        principalTable: "JournalEntries",
                        principalColumn: "JournalEntryId");
                });

            migrationBuilder.CreateTable(
                name: "UserAuths",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAuths", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAuths_UserRole_RoleId",
                        column: x => x.RoleId,
                        principalTable: "UserRole",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoleMenus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoleMenus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoleMenus_MenuMasters_MenuId",
                        column: x => x.MenuId,
                        principalTable: "MenuMasters",
                        principalColumn: "MenuID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoleMenus_UserRole_RoleId",
                        column: x => x.RoleId,
                        principalTable: "UserRole",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TripTransaction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LRDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReferenceNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FromCustomerId = table.Column<int>(type: "int", nullable: false),
                    ToCustomerId = table.Column<int>(type: "int", nullable: false),
                    OriginId = table.Column<int>(type: "int", nullable: false),
                    DestinationId = table.Column<int>(type: "int", nullable: false),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Route = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpectedDeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualDeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    ProductCount = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoadingCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CommissionAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AdditionalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BillNo = table.Column<int>(type: "int", nullable: true),
                    MtnNo = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Kms = table.Column<int>(type: "int", nullable: true),
                    InvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrieghtCharges = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GoodsValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LRCharges = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    HaltingCharges = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    HandlingCharges = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripTransaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TripTransaction_Customers_FromCustomerId",
                        column: x => x.FromCustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TripTransaction_Customers_ToCustomerId",
                        column: x => x.ToCustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TripTransaction_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TripTransaction_Locations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TripTransaction_Locations_OriginId",
                        column: x => x.OriginId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TripTransaction_Vehilces_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehilces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReceiptsDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ReceiptId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptsDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReceiptsDetail_Receipts_ReceiptId",
                        column: x => x.ReceiptId,
                        principalTable: "Receipts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FuelLog",
                columns: table => new
                {
                    FuelLogId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    Vehicle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DriverId = table.Column<int>(type: "int", nullable: true),
                    Driver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tripId = table.Column<int>(type: "int", nullable: true),
                    FuelType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Station = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LogDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Odometer = table.Column<long>(type: "bigint", nullable: true),
                    Volume = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsFullTank = table.Column<bool>(type: "bit", nullable: false),
                    InvoiceNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PaymentMode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelLog", x => x.FuelLogId);
                    table.ForeignKey(
                        name: "FK_FuelLog_TripTransaction_tripId",
                        column: x => x.tripId,
                        principalTable: "TripTransaction",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PayDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PayMode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FromAccountId = table.Column<int>(type: "int", nullable: false),
                    PayeeAccountId = table.Column<int>(type: "int", nullable: false),
                    ReferenceNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    VehicleId = table.Column<int>(type: "int", nullable: true),
                    TripId = table.Column<int>(type: "int", nullable: true),
                    JournalEntryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_payments_AccountMasters_FromAccountId",
                        column: x => x.FromAccountId,
                        principalTable: "AccountMasters",
                        principalColumn: "AccountID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_payments_JournalEntries_JournalEntryId",
                        column: x => x.JournalEntryId,
                        principalTable: "JournalEntries",
                        principalColumn: "JournalEntryId");
                    table.ForeignKey(
                        name: "FK_payments_TripTransaction_TripId",
                        column: x => x.TripId,
                        principalTable: "TripTransaction",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_payments_Vehilces_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehilces",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TripProductDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    TripTransactionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripProductDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TripProductDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TripProductDetails_TripTransaction_TripTransactionId",
                        column: x => x.TripTransactionId,
                        principalTable: "TripTransaction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "paymentsDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paymentsDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_paymentsDetail_payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "payments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AccountMasters",
                columns: new[] { "AccountID", "AccountCode", "AccountGroupCode", "AccountName", "AccountType", "Address", "BranchID", "CreatedAt", "IsActive", "LastUpdatedAt", "Notes", "ParentAccountID" },
                values: new object[,]
                {
                    { 1, "1000", "ASSET", "Cash", "Asset", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6076), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0 },
                    { 2, "1100", "ASSET", "Bank Accounts", "Asset", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6688), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0 },
                    { 3, "1200", "ASSET", "Accounts Receivable", "Asset", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6699), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0 },
                    { 4, "1300", "ASSET", "Inventory", "Asset", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6700), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0 },
                    { 5, "1400", "ASSET", "Fleet Vehicles", "Asset", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6701), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0 },
                    { 6, "1410", "ASSET", "Accumulated Depreciation - Vehicles", "Asset", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6702), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5 },
                    { 7, "1420", "ASSET", "Fuel Stock", "Asset", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6767), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5 },
                    { 8, "1430", "ASSET", "Spare Parts & Tyres Inventory", "Asset", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6769), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5 },
                    { 9, "2000", "LIAB", "Accounts Payable", "Liability", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6770), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0 },
                    { 10, "2100", "LIAB", "Accrued Expenses", "Liability", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6771), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0 },
                    { 11, "2200", "LIAB", "Loans Payable", "Liability", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6772), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0 },
                    { 12, "2210", "LIAB", "Driver Advances Payable", "Liability", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6773), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0 },
                    { 13, "2220", "LIAB", "Vehicle Lease Obligations", "Liability", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6774), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0 },
                    { 14, "3000", "EQUITY", "Owner’s Equity", "Equity", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6776), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0 },
                    { 15, "3100", "EQUITY", "Retained Earnings", "Equity", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6777), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0 },
                    { 16, "4000", "INCOME", "Income", "Income", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6778), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0 },
                    { 17, "4100", "INCOME", "Trip Income", "Income", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6779), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 16 },
                    { 18, "4110", "INCOME", "Freight Charges", "Income", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6780), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 17 },
                    { 19, "4120", "INCOME", "Rental Income - Vehicles", "Income", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6789), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 17 },
                    { 20, "4130", "INCOME", "Fuel Surcharge Income", "Income", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6790), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 17 },
                    { 21, "4200", "INCOME", "Other Service Income", "Income", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6792), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 16 },
                    { 22, "5000", "EXP", "Expenses", "Expense", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6793), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 0 },
                    { 23, "5001", "EXP", "ADMIN", "Expense", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6794), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 22 },
                    { 24, "5100", "EXP", "Fuel Expense", "Expense", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6795), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 22 },
                    { 25, "5110", "EXP", "Driver Wages & Allowances", "Expense", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6797), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 22 },
                    { 26, "5120", "EXP", "Trip Expenses (Tolls, Parking, Lodging)", "Expense", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6798), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 22 },
                    { 27, "5130", "EXP", "Vehicle Maintenance & Repairs", "Expense", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6799), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 22 },
                    { 28, "5140", "EXP", "Tyres & Spare Parts Replacement", "Expense", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6800), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 22 },
                    { 29, "5150", "EXP", "Vehicle Insurance", "Expense", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6801), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 22 },
                    { 30, "5160", "EXP", "Road Tax & Permits", "Expense", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6803), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 22 },
                    { 31, "5200", "EXP", "General Admin Expense", "Expense", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6804), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 22 },
                    { 32, "5210", "EXP", "Office Rent", "Expense", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6805), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 22 },
                    { 33, "5220", "EXP", "Utilities", "Expense", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6807), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 22 },
                    { 34, "5230", "EXP", "Professional Fees", "Expense", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6808), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 22 },
                    { 35, "5240", "EXP", "Bank Charges & Interest", "Expense", "", 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(6809), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 22 }
                });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Address", "CompanyId", "ContactNo", "ContactPhone", "CreatedAt", "EmailId", "GSTNo", "IsActive", "LastUpdatedAt", "Name", "PANNo", "SACNo" },
                values: new object[] { 1, "", "1", "", "", new DateTime(2026, 1, 13, 9, 11, 43, 407, DateTimeKind.Local).AddTicks(2304), null, null, true, new DateTime(2026, 1, 13, 9, 11, 43, 407, DateTimeKind.Local).AddTicks(2391), "Main Branch", null, null });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "ContactNo", "ContactPhone", "CreatedAt", "EmailId", "GSTNo", "IsActive", "LastUpdatedAt", "LicensedValidTill", "Name", "PANNo", "SACNo" },
                values: new object[] { 1, "", "", "", new DateTime(2026, 1, 13, 9, 11, 43, 406, DateTimeKind.Local).AddTicks(6045), null, null, true, new DateTime(2026, 1, 13, 9, 11, 43, 406, DateTimeKind.Local).AddTicks(6221), new DateTime(2026, 7, 12, 9, 11, 43, 406, DateTimeKind.Local).AddTicks(6535), "Default Company", null, null });

            migrationBuilder.InsertData(
                table: "MenuMasters",
                columns: new[] { "MenuID", "GroupId", "IconName", "ModuleID", "Name", "isActive", "orderNo", "url" },
                values: new object[,]
                {
                    { 1, 1, "LayoutDashboard", 1, "Dashboard", true, 1, "/dashboard" },
                    { 2, 2, "Users", 1, "Employees", true, 2, "/users" },
                    { 3, 2, "MapPin", 1, "Locations", true, 3, "/locations" },
                    { 4, 2, "Scale", 1, "Units", true, 4, "/units" },
                    { 5, 2, "Car", 1, "Vehicles", true, 5, "/vehicle" },
                    { 6, 2, "Store", 1, "Vendors", true, 6, "/vendors" },
                    { 7, 2, "Package", 1, "Products", true, 7, "/products" },
                    { 8, 2, "User", 1, "Customers", true, 8, "/customers" },
                    { 9, 3, "Route", 1, "Trips", true, 9, "/trips" },
                    { 10, 3, "CreditCard", 1, "Billing", true, 10, "/Invoice" },
                    { 11, 2, "Droplet", 1, "Fuel", true, 11, "/fuels" },
                    { 12, 1, "Wallet", 2, "Payments", true, 12, "/payments" },
                    { 13, 1, "Wallet", 2, "Receipts", true, 13, "/Receipts" },
                    { 14, 4, "Truck", 1, "Trips", true, 14, "/trips/report/" },
                    { 15, 4, "Receipt", 1, "Customer Bills", true, 15, "/Invoice/report/" }
                });

            migrationBuilder.InsertData(
                table: "ModuleMasters",
                columns: new[] { "ModuleID", "IsActive", "ModuleName", "ModuleVersion" },
                values: new object[,]
                {
                    { 1, true, "Fleet", "1.0" },
                    { 2, true, "Accounts", "1.0" },
                    { 3, false, "Inventory", "1.0" }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleID", "CreatedAt", "Name", "UpdatedAt", "isActive" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(8310), "Admin", new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(8397), true },
                    { 2, new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(8462), "General", new DateTime(2026, 1, 13, 9, 11, 43, 408, DateTimeKind.Local).AddTicks(8463), true }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "BranchID", "CreatedAt", "Email", "EmpAccountID", "FirstName", "Gender", "IsActive", "LastName", "LastUpdatedAt", "Name", "Password", "Phone", "Role", "UserCode" },
                values: new object[] { 1, 1, new DateTime(2026, 1, 13, 9, 11, 43, 409, DateTimeKind.Local).AddTicks(3423), "admin@user.com", 23, "ADMIN", "Male", true, "USER", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ADMIN USER", "Password@321", "8547325650", "ADMIN", "ADM" });

            migrationBuilder.InsertData(
                table: "UserAuths",
                columns: new[] { "Id", "CreatedAt", "IsActive", "LastUpdatedAt", "Password", "RoleId", "UserCode", "UserName" },
                values: new object[] { 1, new DateTime(2026, 1, 13, 9, 11, 43, 409, DateTimeKind.Local).AddTicks(5488), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", 1, "ADM", "admin@rmt.com" });

            migrationBuilder.InsertData(
                table: "UserRoleMenus",
                columns: new[] { "Id", "IsActive", "MenuId", "OrderId", "RoleId" },
                values: new object[,]
                {
                    { 1, true, 1, 1, 1 },
                    { 2, true, 2, 1, 1 },
                    { 3, true, 3, 2, 1 },
                    { 4, true, 4, 3, 1 },
                    { 5, true, 5, 4, 1 },
                    { 6, true, 6, 5, 1 },
                    { 7, true, 7, 6, 1 },
                    { 8, true, 8, 1, 1 },
                    { 9, true, 9, 1, 1 },
                    { 10, true, 10, 1, 1 },
                    { 11, true, 11, 1, 1 },
                    { 12, true, 12, 1, 1 },
                    { 13, true, 13, 1, 1 },
                    { 14, true, 14, 1, 1 },
                    { 15, true, 15, 1, 1 },
                    { 16, true, 1, 1, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BillItemDetails_BillId",
                table: "BillItemDetails",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AccountId",
                table: "Customers",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmpAccountID",
                table: "Employees",
                column: "EmpAccountID");

            migrationBuilder.CreateIndex(
                name: "IX_FuelLog_tripId",
                table: "FuelLog",
                column: "tripId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalEntriesLine_AccountId",
                table: "JournalEntriesLine",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalEntriesLine_JournalEntryId",
                table: "JournalEntriesLine",
                column: "JournalEntryId");

            migrationBuilder.CreateIndex(
                name: "IX_payments_FromAccountId",
                table: "payments",
                column: "FromAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_payments_JournalEntryId",
                table: "payments",
                column: "JournalEntryId");

            migrationBuilder.CreateIndex(
                name: "IX_payments_TripId",
                table: "payments",
                column: "TripId");

            migrationBuilder.CreateIndex(
                name: "IX_payments_VehicleId",
                table: "payments",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_paymentsDetail_PaymentId",
                table: "paymentsDetail",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_JournalEntryId",
                table: "Receipts",
                column: "JournalEntryId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_ToAccountId",
                table: "Receipts",
                column: "ToAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptsDetail_ReceiptId",
                table: "ReceiptsDetail",
                column: "ReceiptId");

            migrationBuilder.CreateIndex(
                name: "IX_TripProductDetails_ProductId",
                table: "TripProductDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TripProductDetails_TripTransactionId",
                table: "TripProductDetails",
                column: "TripTransactionId");

            migrationBuilder.CreateIndex(
                name: "IX_TripTransaction_DestinationId",
                table: "TripTransaction",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_TripTransaction_EmployeeId",
                table: "TripTransaction",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TripTransaction_FromCustomerId",
                table: "TripTransaction",
                column: "FromCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_TripTransaction_OriginId",
                table: "TripTransaction",
                column: "OriginId");

            migrationBuilder.CreateIndex(
                name: "IX_TripTransaction_ToCustomerId",
                table: "TripTransaction",
                column: "ToCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_TripTransaction_VehicleId",
                table: "TripTransaction",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAuths_RoleId",
                table: "UserAuths",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleMenus_MenuId",
                table: "UserRoleMenus",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleMenus_RoleId",
                table: "UserRoleMenus",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_AccountId",
                table: "Vendors",
                column: "AccountId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillItemDetails");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "FuelLog");

            migrationBuilder.DropTable(
                name: "JournalEntriesLine");

            migrationBuilder.DropTable(
                name: "ModuleMasters");

            migrationBuilder.DropTable(
                name: "paymentsDetail");

            migrationBuilder.DropTable(
                name: "ReceiptsDetail");

            migrationBuilder.DropTable(
                name: "TripProductDetails");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "UserAuths");

            migrationBuilder.DropTable(
                name: "UserRoleMenus");

            migrationBuilder.DropTable(
                name: "Vendors");

            migrationBuilder.DropTable(
                name: "BillTransaction");

            migrationBuilder.DropTable(
                name: "payments");

            migrationBuilder.DropTable(
                name: "Receipts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "MenuMasters");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "TripTransaction");

            migrationBuilder.DropTable(
                name: "JournalEntries");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Vehilces");

            migrationBuilder.DropTable(
                name: "AccountMasters");
        }
    }
}
