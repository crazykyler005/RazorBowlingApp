To run simply type "dotnet run" in the terminal while cd'ed into the root directory of the project

## Setting up local mysql db connection
In the root directory, if you want to create a db, create a `appsettings.json` file and add the following to it
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",

  "ConnectionStrings": {
    "DefaultConnection": "server=localhost;database=bowlingdb;user=myuser;password=mypassword"
  }

}
```
You can change the default connection as you please but make sure you actually have the user and database pre-created. You can do so by typing the following in your terminal:
```
mysql -u root # connecting to mysql
CREATE USER 'myuser'@'localhost' IDENTIFIED BY 'mypassword';

CREATE DATABASE IF NOT EXISTS bowlingdb;
GRANT ALL PRIVILEGES ON bowlingdb.* TO 'test'@'localhost';
FLUSH PRIVILEGES;
EXIT;

```


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
