CREATE TABLE [dbo].[umbracoNode] (
    [id]             INT              IDENTITY (1054, 1) NOT NULL,
    [trashed]        BIT              DEFAULT ('0') NOT NULL,
    [parentID]       INT              NOT NULL,
    [nodeUser]       INT              NULL,
    [level]          INT              NOT NULL,
    [path]           NVARCHAR (150)   NOT NULL,
    [sortOrder]      INT              NOT NULL,
    [uniqueID]       UNIQUEIDENTIFIER NULL,
    [text]           NVARCHAR (255)   NULL,
    [nodeObjectType] UNIQUEIDENTIFIER NULL,
    [createDate]     DATETIME         DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_structure] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_umbracoNode_umbracoNode_id] FOREIGN KEY ([parentID]) REFERENCES [dbo].[umbracoNode] ([id])
);


GO
CREATE NONCLUSTERED INDEX [IX_umbracoNodeObjectType]
    ON [dbo].[umbracoNode]([nodeObjectType] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_umbracoNodeParentId]
    ON [dbo].[umbracoNode]([parentID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_umbracoNodeTrashed]
    ON [dbo].[umbracoNode]([trashed] ASC);

