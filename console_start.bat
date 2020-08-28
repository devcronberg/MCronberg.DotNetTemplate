if not exist "C:\kursus\" mkdir C:\kursus
c:
cd\kursus
set /p navn="App navn: "
dotnet new console_start -n %navn%
cd %navn%
dotnet restore
start "" "%navn%.sln"
