CREATE TABLE [User] (
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [Username] NVARCHAR(50) NOT NULL UNIQUE,
    [Password] NVARCHAR(100) NOT NULL,
    [Name] NVARCHAR(100) NOT NULL
);

INSERT INTO [User] ([Username], [Password], [Name])
VALUES ('user1', 'password123', 'Pranit');

