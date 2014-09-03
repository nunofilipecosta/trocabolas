CREATE TABLE [dbo].[cmsContent] (
    [pk]          INT IDENTITY (3, 1) NOT NULL,
    [nodeId]      INT NOT NULL,
    [contentType] INT NOT NULL,
    CONSTRAINT [PK_cmsContent] PRIMARY KEY CLUSTERED ([pk] ASC),
    CONSTRAINT [FK_cmsContent_umbracoNode_id] FOREIGN KEY ([nodeId]) REFERENCES [dbo].[umbracoNode] ([id])
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_cmsContent]
    ON [dbo].[cmsContent]([nodeId] ASC);

