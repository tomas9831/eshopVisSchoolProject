CREATE TABLE [dbo].[Requests]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[UserId] INT NOT NULL foreign key references UsersTable(Id),
	[Request]  NVARCHAR(100) NOT NULL , 
)
