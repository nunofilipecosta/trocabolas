CREATE TABLE [dbo].[Products] (
    [ProductId]         INT             IDENTITY (1, 1) NOT NULL,
    [ProductTypeId]     INT             NOT NULL,
    [ProductOwnerId]    INT             NOT NULL,
    [Name]              NVARCHAR (MAX)  NULL,
    [Description]       NVARCHAR (MAX)  NULL,
    [ProductState]      INT             NOT NULL,
    [Price]             DECIMAL (18, 2) NOT NULL,
    [Visualizations]    INT             NOT NULL,
    [Size]              NVARCHAR (MAX)  NULL,
    [Color]             NVARCHAR (MAX)  NULL,
    [PreservationState] INT             NOT NULL,
    CONSTRAINT [PK_dbo.Products] PRIMARY KEY CLUSTERED ([ProductId] ASC),
    CONSTRAINT [FK_dbo.Products_dbo.ProductTypes_ProductTypeId] FOREIGN KEY ([ProductTypeId]) REFERENCES [dbo].[ProductTypes] ([ProductTypeId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_ProductTypeId]
    ON [dbo].[Products]([ProductTypeId] ASC);

