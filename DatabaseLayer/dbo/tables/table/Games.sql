CREATE TABLE [dbo].[Games]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Pegi] INT NOT NULL, 
    [Description] NVARCHAR(150) NOT NULL, 
    [PriceNew] FLOAT NOT NULL, 
    [PriceOld] FLOAT NOT NULL, 
    [PricePurchase] FLOAT NOT NULL, 
    [CoverImage] NVARCHAR(250) NULL,
    [Availability] NVARCHAR(50) NOT NULL, 
)
