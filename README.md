
USE THIS Command to 
** migrate db

	Add-Migration InitDb ` -Project ProductManagement.Infrastructure ` -StartupProject ProductManagement.Api ` -Context ProductManagementDbContext
** update db
	Update-Database ` -Project ProductManagement.Infrastructure ` -StartupProject ProductManagement.Api ` -Context ProductManagementDbContextzz