pushd %~dp0
if not exist "C:\kursus\" mkdir C:\kursus
c:
cd\kursus
set /p navn="App navn: "
dotnet new blazorserver_start -n %navn%
cd %navn%
dotnet restore
start "" "%navn%.sln"
popd
