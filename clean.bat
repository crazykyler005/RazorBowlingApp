@echo off
REM temporary files
rmdir /s /q bin
rmdir /s /q obj

REM rebuilding them
dotnet build