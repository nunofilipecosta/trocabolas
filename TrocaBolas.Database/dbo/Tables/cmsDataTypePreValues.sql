CREATE TABLE [dbo].[cmsDataTypePreValues] (
    [id]             INT             IDENTITY (5, 1) NOT NULL,
    [datatypeNodeId] INT             NOT NULL,
    [value]          NVARCHAR (2500) NULL,
    [sortorder]      INT             NOT NULL,
    [alias]          NVARCHAR (50)   NULL,
    CONSTRAINT [PK_cmsDataTypePreValues] PRIMARY KEY CLUSTERED ([id] ASC)
);

