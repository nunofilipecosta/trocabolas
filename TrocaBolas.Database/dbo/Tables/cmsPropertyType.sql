CREATE TABLE [dbo].[cmsPropertyType] (
    [id]                  INT             IDENTITY (28, 1) NOT NULL,
    [dataTypeId]          INT             NOT NULL,
    [contentTypeId]       INT             NOT NULL,
    [propertyTypeGroupId] INT             NULL,
    [Alias]               NVARCHAR (255)  NOT NULL,
    [Name]                NVARCHAR (255)  NULL,
    [helpText]            NVARCHAR (1000) NULL,
    [sortOrder]           INT             DEFAULT ('0') NOT NULL,
    [mandatory]           BIT             DEFAULT ('0') NOT NULL,
    [validationRegExp]    NVARCHAR (255)  NULL,
    [Description]         NVARCHAR (2000) NULL,
    CONSTRAINT [PK_cmsPropertyType] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_cmsPropertyType_cmsPropertyTypeGroup_id] FOREIGN KEY ([propertyTypeGroupId]) REFERENCES [dbo].[cmsPropertyTypeGroup] ([id])
);

