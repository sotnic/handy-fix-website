# handy-fix-website

A website created for providing home maintenance services.

## Running

To run on a local machine migrations are used:

dotnet ef database drop --context IdentityDbContext
dotnet ef database drop --context ApplicationDbContext

dotnet ef migrations remove --context IdentityDbContext
dotnet ef migrations remove --context ApplicationDbContext

dotnet ef migrations add Initial --context IdentityDbContext
dotnet ef migrations add Initial --context ApplicationDbContext

dotnet ef database update --context IdentityDbContext
dotnet ef database update --context ApplicationDbContext
