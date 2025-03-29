USE master;
GO

-- Create the database if it doesn't exist
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = '$(DB_NAME)')
BEGIN
    PRINT 'Creating database $(DB_NAME)...'
    CREATE DATABASE $(DB_NAME);
END
GO

-- Create a login and user for the new database
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = '$(DB_USER)')
BEGIN
    PRINT 'Creating login $(DB_USER) with password $(DB_USER_PASSWORD)...'
    CREATE LOGIN $(DB_USER) WITH PASSWORD = '$(DB_USER_PASSWORD)';
END
GO

USE $(DB_NAME);
GO

-- Create a database user for the login
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = '$(DB_USER)')
BEGIN
    PRINT 'Creating database user $(DB_USER)...'
    CREATE USER $(DB_USER) FOR LOGIN $(DB_USER);
END
GO

-- Grant the user db_owner permissions
ALTER ROLE db_owner ADD MEMBER $(DB_USER);
GO

--Set default database
BEGIN
    ALTER LOGIN $(DB_USER) WITH DEFAULT_DATABASE = $(DB_NAME);
    PRINT 'Setting $(DB_USER) default database to $(DB_NAME)...'
END
GO