if not exist "C:\kursus\" mkdir C:\kursus
c:
cd\kursus
set /p navn="App navn: "
dotnet new mvcstart -n %navn%
cd %navn%
dotnet restore
libman restore
start "" "%navn%.sln"