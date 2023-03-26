# PizaAppRazorPageEF
APS .Net 7.0 Core Razor Page 

1) Run the command Scaffold-DbContext "Server="ConnectionString";Database=PizzaDB;Trusted_Connection=True;MultipleActiveResultSets=true" Microsoft.EntityFrameworkCore.SqlServer -ContextDir Data -OutputDir Models 
to generate the Data and Models from the existing DB

2) Right-Click in the project and select Manage User Secrets. This feature allows to store the ConnectionString in a secret location away form the code, it is also a better practice.

3) Right-Click in the pages/product filder and selected add/new Scaffolded item. it generated the CRUD opearations for Razor page
