CREATE TABLE [dbo].[ProductTypes] (
    [ProductTypeId] INT            IDENTITY (1, 1) NOT NULL,
    [Description]   NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.ProductTypes] PRIMARY KEY CLUSTERED ([ProductTypeId] ASC)
);

