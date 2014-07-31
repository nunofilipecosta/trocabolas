CREATE TABLE [dbo].[Customer]
(
	[CustomerId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [EmailAddress] VARCHAR(50) NULL, 
    [CreatedDate] DATETIME NOT NULL DEFAULT GETDATE(), 
    [CustomerTypeId] INT NOT NULL, 
    CONSTRAINT [FK_Customer_CustomerType] FOREIGN KEY (CustomerTypeId) REFERENCES [CustomerType]([CustomerTypeId])
)
