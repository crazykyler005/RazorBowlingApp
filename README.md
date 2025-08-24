To run simply type "dotnet run" in the terminal while cd'ed into the root directory of the project

## Creating Database from Entities
To auto-generate a mysql database from etities simply run one of the following scripts
### Linxu
```
chmod +x db_generation.sh # makes the script executable
db_generation.sh
```
### Windows
```
db_generation.bat
```
## Planned features
- Add code to generate a mysql database that can be ran locally
- Add a means to save and retrieve data from said database
- Add a User Entity/Table so you can retrieve games created by that user
- Add page to display game history
