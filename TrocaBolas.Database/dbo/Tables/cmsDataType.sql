CREATE TABLE [dbo].[cmsDataType] (
    [pk]                  INT            IDENTITY (25, 1) NOT NULL,
    [nodeId]              INT            NOT NULL,
    [dbType]              NVARCHAR (50)  NOT NULL,
    [propertyEditorAlias] NVARCHAR (255) NOT NULL,
    CONSTRAINT [PK_cmsDataType] PRIMARY KEY CLUSTERED ([pk] ASC),
    CONSTRAINT [FK_cmsDataType_umbracoNode_id] FOREIGN KEY ([nodeId]) REFERENCES [dbo].[umbracoNode] ([id])
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_cmsDataType_nodeId]
    ON [dbo].[cmsDataType]([nodeId] ASC);

