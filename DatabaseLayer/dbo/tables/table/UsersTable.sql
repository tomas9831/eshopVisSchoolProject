CREATE TABLE [dbo].[UsersTable]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Email] NVARCHAR(50) NOT NULL, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Surname] NVARCHAR(50) NOT NULL, 
    [Phone] NVARCHAR(50) NOT NULL, 
    [Adress] NVARCHAR(150) NOT NULL, 
    [Birthday] NVARCHAR(50) NOT NULL, 
    [Verified] BIT NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL, 
    [UserType] NVARCHAR(50) NOT NULL,
    
)
