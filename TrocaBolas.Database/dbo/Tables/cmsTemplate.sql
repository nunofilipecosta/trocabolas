CREATE TABLE [dbo].[cmsTemplate] (
    [pk]     INT            IDENTITY (4, 1) NOT NULL,
    [nodeId] INT            NOT NULL,
    [master] INT            NULL,
    [alias]  NVARCHAR (100) NULL,
    [design] NTEXT          NOT NULL,
    CONSTRAINT [PK_cmsTemplate] PRIMARY KEY CLUSTERED ([pk] ASC),
    CONSTRAINT [FK_cmsTemplate_cmsTemplate] FOREIGN KEY ([master]) REFERENCES [dbo].[umbracoNode] ([id]),
    CONSTRAINT [FK_cmsTemplate_umbracoNode] FOREIGN KEY ([nodeId]) REFERENCES [dbo].[umbracoNode] ([id])
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_cmsTemplate_nodeId]
    ON [dbo].[cmsTemplate]([nodeId] ASC);

