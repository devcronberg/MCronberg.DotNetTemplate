@echo off
if not exist "C:\kursus\" mkdir C:\kursus
cd c:\kursus
set /p navn="App navn: "
dotnet new console_async -n %navn%
cd %navn%
%navn%.sln
