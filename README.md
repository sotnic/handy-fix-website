# handy-fix-website

A website created for providing home maintenance services.

## Running

To run on a local machine migrations are used:

dotnet ef database drop --context IdentityDbContext</br>
dotnet ef database drop --context ApplicationDbContext 

dotnet ef migrations remove --context IdentityDbContext</br>
dotnet ef migrations remove --context ApplicationDbContext 

dotnet ef migrations add Initial --context IdentityDbContext</br> 
dotnet ef migrations add Initial --context ApplicationDbContext 

dotnet ef database update --context IdentityDbContext</br> 
dotnet ef database update --context ApplicationDbContext 
