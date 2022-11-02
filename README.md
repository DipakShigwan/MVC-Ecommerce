# MVC-Ecommerce
product category admin + user

Step 1: Add Connection String In AppSetting.json.

{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },  
    "ConnectionStrings": {
      "DefaultConnection": "Server=DESKTOP-N0D6E01\\SQLEXPRESS;Database=Northwiind;Trusted_Connection=True;"
    }
  ,
  "AllowedHosts": "*"
}

step2 :Install-Package Microsoft.EntityFrameworkCore.Tools 

step3 : command for database first approach.

 Scaffold-DbContext "Server=DESKTOP-N0D6E01\SQLEXPRESS;Initial Catalog=;User =;Password=;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Data -Context ApplicationDBContext -DataAnnotations
 
 step4 :add elow line for DB connections
 
 builder.Services.AddDbContext<CustomerContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CustomerContext") ?? throw new InvalidOperationException("Connection string 'CustomerContext' not found."))); 
