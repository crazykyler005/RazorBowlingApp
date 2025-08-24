@echo off
REM removing old db generation from previous migration
dotnet ef database drop --force --no-build

REM removing old migration folder
rmdir /s /q Migrations

REM creating migration based on entities
dotnet ef migrations add mysql-migration

REM creating db from migration using DefaultConnection string
dotnet ef database update