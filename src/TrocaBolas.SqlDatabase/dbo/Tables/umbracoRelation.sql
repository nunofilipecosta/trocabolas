﻿CREATE TABLE [dbo].[umbracoRelation] (
    [id]       INT             IDENTITY (1, 1) NOT NULL,
    [parentId] INT             NOT NULL,
    [childId]  INT             NOT NULL,
    [relType]  INT             NOT NULL,
    [datetime] DATETIME        DEFAULT (getdate()) NOT NULL,
    [comment]  NVARCHAR (1000) NOT NULL,
    CONSTRAINT [PK_umbracoRelation] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_umbracoRelation_umbracoNode] FOREIGN KEY ([parentId]) REFERENCES [dbo].[umbracoNode] ([id]),
    CONSTRAINT [FK_umbracoRelation_umbracoNode1] FOREIGN KEY ([childId]) REFERENCES [dbo].[umbracoNode] ([id]),
    CONSTRAINT [FK_umbracoRelation_umbracoRelationType_id] FOREIGN KEY ([relType]) REFERENCES [dbo].[umbracoRelationType] ([id])
);

