CREATE TABLE [dbo].[cmsMember] (
    [nodeId]    INT             NOT NULL,
    [Email]     NVARCHAR (1000) DEFAULT ('''') NOT NULL,
    [LoginName] NVARCHAR (1000) DEFAULT ('''') NOT NULL,
    [Password]  NVARCHAR (1000) DEFAULT ('''') NOT NULL,
    CONSTRAINT [PK_cmsMember] PRIMARY KEY CLUSTERED ([nodeId] ASC),
    CONSTRAINT [FK_cmsMember_umbracoNode_id] FOREIGN KEY ([nodeId]) REFERENCES [dbo].[umbracoNode] ([id])
);

