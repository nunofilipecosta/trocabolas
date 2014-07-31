CREATE TABLE [dbo].[cmsPropertyTypeGroup] (
    [id]                INT            IDENTITY (6, 1) NOT NULL,
    [parentGroupId]     INT            NULL,
    [contenttypeNodeId] INT            NOT NULL,
    [text]              NVARCHAR (255) NOT NULL,
    [sortorder]         INT            NOT NULL,
    CONSTRAINT [PK_cmsPropertyTypeGroup] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_cmsPropertyTypeGroup_cmsPropertyTypeGroup_id] FOREIGN KEY ([parentGroupId]) REFERENCES [dbo].[cmsPropertyTypeGroup] ([id])
);

