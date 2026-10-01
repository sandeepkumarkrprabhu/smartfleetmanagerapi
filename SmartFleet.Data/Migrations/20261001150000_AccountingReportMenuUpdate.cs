using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    public partial class AccountingReportMenuUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
DECLARE @CashBankMenuId INT;
DECLARE @ReceivablesPayableMenuId INT;
DECLARE @TaxReportsMenuId INT;
DECLARE @ManagementAnalysisMenuId INT;
DECLARE @MenuId INT;

SELECT @CashBankMenuId = MenuID FROM MenuMasters WHERE ModuleID = 2 AND Name = N'Cash & Bank Reports';
IF @CashBankMenuId IS NULL
BEGIN
    INSERT INTO MenuMasters (GroupId, IconName, ModuleID, Name, isActive, orderNo, url)
    VALUES (4, N'Landmark', 2, N'Cash & Bank Reports', 1, 2, N'/accounts/CashBankReports');
    SET @CashBankMenuId = CONVERT(INT, SCOPE_IDENTITY());
END;

SELECT @ReceivablesPayableMenuId = MenuID FROM MenuMasters WHERE ModuleID = 2 AND Name = N'Receivables & Payable Reports';
IF @ReceivablesPayableMenuId IS NULL
BEGIN
    INSERT INTO MenuMasters (GroupId, IconName, ModuleID, Name, isActive, orderNo, url)
    VALUES (4, N'ArrowLeftRight', 2, N'Receivables & Payable Reports', 1, 3, N'/accounts/ReceivablePayableReports');
    SET @ReceivablesPayableMenuId = CONVERT(INT, SCOPE_IDENTITY());
END;

SELECT @TaxReportsMenuId = MenuID FROM MenuMasters WHERE ModuleID = 2 AND Name = N'Tax Reports';
IF @TaxReportsMenuId IS NULL
BEGIN
    INSERT INTO MenuMasters (GroupId, IconName, ModuleID, Name, isActive, orderNo, url)
    VALUES (4, N'ReceiptText', 2, N'Tax Reports', 1, 4, N'/accounts/TaxReports');
    SET @TaxReportsMenuId = CONVERT(INT, SCOPE_IDENTITY());
END;

SELECT @ManagementAnalysisMenuId = MenuID FROM MenuMasters WHERE ModuleID = 2 AND Name = N'Management Analysis';
IF @ManagementAnalysisMenuId IS NULL
BEGIN
    INSERT INTO MenuMasters (GroupId, IconName, ModuleID, Name, isActive, orderNo, url)
    VALUES (4, N'ChartNoAxesCombined', 2, N'Management Analysis', 1, 5, N'/accounts/ManagementAnalysis');
    SET @ManagementAnalysisMenuId = CONVERT(INT, SCOPE_IDENTITY());
END;

SELECT @MenuId = MenuID FROM MenuMasters WHERE ModuleID = 2 AND Name = N'Trail Balance';
IF @MenuId IS NOT NULL AND NOT EXISTS (SELECT 1 FROM UserRoleMenus WHERE RoleId = 1 AND MenuId = @MenuId)
    INSERT INTO UserRoleMenus (HasAddPermission, HasDeletePermission, HasEditPermission, HasPostingPermission, HasPrintPermission, IsActive, MenuId, OrderId, RoleId)
    VALUES (0, 0, 0, 0, 0, 1, @MenuId, 2, 1);

SELECT @MenuId = MenuID FROM MenuMasters WHERE ModuleID = 2 AND Name = N'Profit & Loss A/c';
IF @MenuId IS NOT NULL AND NOT EXISTS (SELECT 1 FROM UserRoleMenus WHERE RoleId = 1 AND MenuId = @MenuId)
    INSERT INTO UserRoleMenus (HasAddPermission, HasDeletePermission, HasEditPermission, HasPostingPermission, HasPrintPermission, IsActive, MenuId, OrderId, RoleId)
    VALUES (0, 0, 0, 0, 0, 1, @MenuId, 3, 1);

SELECT @MenuId = MenuID FROM MenuMasters WHERE ModuleID = 2 AND Name = N'Balance Sheet';
IF @MenuId IS NOT NULL AND NOT EXISTS (SELECT 1 FROM UserRoleMenus WHERE RoleId = 1 AND MenuId = @MenuId)
    INSERT INTO UserRoleMenus (HasAddPermission, HasDeletePermission, HasEditPermission, HasPostingPermission, HasPrintPermission, IsActive, MenuId, OrderId, RoleId)
    VALUES (0, 0, 0, 0, 0, 0, 1, @MenuId, 4, 1);

SELECT @MenuId = MenuID FROM MenuMasters WHERE ModuleID = 2 AND Name = N'Posting';
IF @MenuId IS NOT NULL AND NOT EXISTS (SELECT 1 FROM UserRoleMenus WHERE RoleId = 1 AND MenuId = @MenuId)
    INSERT INTO UserRoleMenus (HasAddPermission, HasDeletePermission, HasEditPermission, HasPostingPermission, HasPrintPermission, IsActive, MenuId, OrderId, RoleId)
    VALUES (0, 0, 0, 0, 0, 1, @MenuId, 5, 1);

SELECT @MenuId = MenuID FROM MenuMasters WHERE ModuleID = 2 AND Name = N'Account Statement';
IF @MenuId IS NOT NULL AND NOT EXISTS (SELECT 1 FROM UserRoleMenus WHERE RoleId = 1 AND MenuId = @MenuId)
    INSERT INTO UserRoleMenus (HasAddPermission, HasDeletePermission, HasEditPermission, HasPostingPermission, HasPrintPermission, IsActive, MenuId, OrderId, RoleId)
    VALUES (0, 0, 0, 0, 0, 1, @MenuId, 6, 1);

IF NOT EXISTS (SELECT 1 FROM UserRoleMenus WHERE RoleId = 1 AND MenuId = @CashBankMenuId)
    INSERT INTO UserRoleMenus (HasAddPermission, HasDeletePermission, HasEditPermission, HasPostingPermission, HasPrintPermission, IsActive, MenuId, OrderId, RoleId)
    VALUES (0, 0, 0, 0, 0, 1, @CashBankMenuId, 7, 1);

IF NOT EXISTS (SELECT 1 FROM UserRoleMenus WHERE RoleId = 1 AND MenuId = @ReceivablesPayableMenuId)
    INSERT INTO UserRoleMenus (HasAddPermission, HasDeletePermission, HasEditPermission, HasPostingPermission, HasPrintPermission, IsActive, MenuId, OrderId, RoleId)
    VALUES (0, 0, 0, 0, 0, 1, @ReceivablesPayableMenuId, 8, 1);

IF NOT EXISTS (SELECT 1 FROM UserRoleMenus WHERE RoleId = 1 AND MenuId = @TaxReportsMenuId)
    INSERT INTO UserRoleMenus (HasAddPermission, HasDeletePermission, HasEditPermission, HasPostingPermission, HasPrintPermission, IsActive, MenuId, OrderId, RoleId)
    VALUES (0, 0, 0, 0, 0, 1, @TaxReportsMenuId, 9, 1);

IF NOT EXISTS (SELECT 1 FROM UserRoleMenus WHERE RoleId = 1 AND MenuId = @ManagementAnalysisMenuId)
    INSERT INTO UserRoleMenus (HasAddPermission, HasDeletePermission, HasEditPermission, HasPostingPermission, HasPrintPermission, IsActive, MenuId, OrderId, RoleId)
    VALUES (0, 0, 0, 0, 0, 1, @ManagementAnalysisMenuId, 10, 1);
");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
DECLARE @MenuId INT;

SELECT @MenuId = MenuID FROM MenuMasters WHERE ModuleID = 2 AND Name = N'Management Analysis';
DELETE FROM UserRoleMenus WHERE RoleId = 1 AND MenuId = @MenuId;
DELETE FROM MenuMasters WHERE MenuID = @MenuId;

SELECT @MenuId = MenuID FROM MenuMasters WHERE ModuleID = 2 AND Name = N'Tax Reports';
DELETE FROM UserRoleMenus WHERE RoleId = 1 AND MenuId = @MenuId;
DELETE FROM MenuMasters WHERE MenuID = @MenuId;

SELECT @MenuId = MenuID FROM MenuMasters WHERE ModuleID = 2 AND Name = N'Receivables & Payable Reports';
DELETE FROM UserRoleMenus WHERE RoleId = 1 AND MenuId = @MenuId;
DELETE FROM MenuMasters WHERE MenuID = @MenuId;

SELECT @MenuId = MenuID FROM MenuMasters WHERE ModuleID = 2 AND Name = N'Cash & Bank Reports';
DELETE FROM UserRoleMenus WHERE RoleId = 1 AND MenuId = @MenuId;
DELETE FROM MenuMasters WHERE MenuID = @MenuId;

DELETE urm
FROM UserRoleMenus urm
INNER JOIN MenuMasters mm ON mm.MenuID = urm.MenuId
WHERE urm.RoleId = 1
  AND mm.ModuleID = 2
  AND mm.Name IN (N'Account Statement', N'Posting', N'Balance Sheet', N'Profit & Loss A/c', N'Trail Balance');
");
        }
    }
}