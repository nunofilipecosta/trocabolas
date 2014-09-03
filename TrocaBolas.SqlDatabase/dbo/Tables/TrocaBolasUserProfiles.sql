CREATE TABLE [dbo].[TrocaBolasUserProfiles] (
    [UserId]  UNIQUEIDENTIFIER NOT NULL,
    [Name]    NVARCHAR (500)   NOT NULL,
    [ZipCode] NVARCHAR (8)     NOT NULL,
    [Address] NVARCHAR (500)   NOT NULL,
    [Town]    NVARCHAR (MAX)   NULL,
    [Phone]   NVARCHAR (MAX)   NULL,
    CONSTRAINT [PK_dbo.TrocaBolasUserProfiles] PRIMARY KEY CLUSTERED ([UserId] ASC)
);

