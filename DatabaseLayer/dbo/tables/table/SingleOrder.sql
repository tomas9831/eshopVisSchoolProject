CREATE TABLE [dbo].[SingleOrder]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CustomerId] INT NOT NULL FOREIGN KEY REFERENCES UsersTable(Id), 
    [PaymentType] NVARCHAR(50) NOT NULL, 
    [Adress] NVARCHAR(150) NOT NULL, 
    [DeliveryType] NVARCHAR(50) NOT NULL, 
    [Price] FLOAT NOT NULL
)
