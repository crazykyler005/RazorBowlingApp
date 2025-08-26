#!/bin/bash

# removing old db generation from previous migration
dotnet ef database drop
# removing old migration
rm -rf Migrations
# creating migration based on entities
dotnet ef migrations add mysql-migration
# creating db from migration using DefaultConnection string
dotnet ef database update