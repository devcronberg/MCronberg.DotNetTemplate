@echo off
if not exist "C:\kursus\" mkdir C:\kursus
c:
cd kursus
set /p navn="App navn: "
dotnet new mvcstart -n %navn%
cd %navn%
%navn%.sln
