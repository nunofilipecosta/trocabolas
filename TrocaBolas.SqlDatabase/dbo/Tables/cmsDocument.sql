CREATE TABLE [dbo].[cmsDocument] (
    [nodeId]       INT              NOT NULL,
    [published]    BIT              NOT NULL,
    [documentUser] INT              NOT NULL,
    [versionId]    UNIQUEIDENTIFIER NOT NULL,
    [text]         NVARCHAR (255)   NOT NULL,
    [releaseDate]  DATETIME         NULL,
    [expireDate]   DATETIME         NULL,
    [updateDate]   DATETIME         DEFAULT (getdate()) NOT NULL,
    [templateId]   INT              NULL,
    [alias]        NVARCHAR (255)   NULL,
    [newest]       BIT              DEFAULT ('0') NOT NULL,
    CONSTRAINT [PK_cmsDocument] PRIMARY KEY CLUSTERED ([versionId] ASC),
    CONSTRAINT [FK_cmsDocument_umbracoNode_id] FOREIGN KEY ([nodeId]) REFERENCES [dbo].[umbracoNode] ([id])
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_cmsDocument]
    ON [dbo].[cmsDocument]([nodeId] ASC, [versionId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_cmsDocument_published]
    ON [dbo].[cmsDocument]([published] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_cmsDocument_newest]
    ON [dbo].[cmsDocument]([newest] ASC);

