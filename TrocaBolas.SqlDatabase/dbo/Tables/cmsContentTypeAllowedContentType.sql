CREATE TABLE [dbo].[cmsContentTypeAllowedContentType] (
    [Id]        INT NOT NULL,
    [AllowedId] INT NOT NULL,
    [SortOrder] INT DEFAULT ('0') NOT NULL,
    CONSTRAINT [PK_cmsContentTypeAllowedContentType] PRIMARY KEY CLUSTERED ([Id] ASC, [AllowedId] ASC)
);

