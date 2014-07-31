CREATE TABLE [dbo].[cmsContentVersion] (
    [id]             INT              IDENTITY (5, 1) NOT NULL,
    [ContentId]      INT              NOT NULL,
    [VersionId]      UNIQUEIDENTIFIER NOT NULL,
    [VersionDate]    DATETIME         DEFAULT (getdate()) NOT NULL,
    [LanguageLocale] NVARCHAR (10)    NULL,
    CONSTRAINT [PK_cmsContentVersion] PRIMARY KEY CLUSTERED ([id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_cmsContentVersion_VersionId]
    ON [dbo].[cmsContentVersion]([VersionId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_cmsContentVersion_ContentId]
    ON [dbo].[cmsContentVersion]([ContentId] ASC);

