mkdir ncore
cd ncore
dotnet new sln -n ncore
dotnet new console -n app -f netcoreapp1.1
dotnet add app package Microsoft.EntityFrameworkCore
dotnet add app package Microsoft.EntityFrameworkCore.SqlServer
dotnet add app package Microsoft.EntityFrameworkCore.Sqlite
dotnet add app package Microsoft.EntityFrameworkCore.Tools.DotNet

dotnet new mvc -n web -f netcoreapp1.1

dotnet sln ncore.sln add app/app.csproj
dotnet sln ncore.sln add web/web.csproj

dotnet restore
dotnet build


cd ..