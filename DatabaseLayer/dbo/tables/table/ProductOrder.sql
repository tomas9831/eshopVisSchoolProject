CREATE TABLE [dbo].[ProductOrder]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductId] int NOT NULL FOREIGN KEY REFERENCES Games(Id), 
    [OrderId] int not null FOREIGN KEY REFERENCES SingleOrder(Id), 
)
