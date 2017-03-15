mkdir ncore
cd ncore
dotnet new sln -n ncore
cd app
dotnet new console -n app -f netcoreapp1.1
dotnet sln ncore.sln add app/app.csproj