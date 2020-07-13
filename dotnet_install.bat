dotnet tool install -g Microsoft.Web.LibraryManager.Cli --version 1.0.94-g606058a278 --add-source C:\Temp\
dotnet new --debug:reinit
cd aspnet-mvc-start
dotnet new -i ./
cd..
cd console-async
dotnet new -i ./
cd..
cd blazor-webassembly-start
dotnet new -i ./
cd..
cd blazor-server-start
dotnet new -i ./
cd..