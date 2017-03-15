mkdir ncore
cd ncore
dotnet new sln -n ncore
dotnet new console -n app -f netcoreapp1.1
dotnet sln ncore.sln add app/app.csproj
dotnet restore
dotnet build
dotnet run --project app/app.csproj
cd ..