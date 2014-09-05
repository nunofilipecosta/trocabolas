CREATE TABLE [dbo].[umbracoUser] (
    [id]               INT            IDENTITY (1, 1) NOT NULL,
    [userDisabled]     BIT            DEFAULT ('0') NOT NULL,
    [userNoConsole]    BIT            DEFAULT ('0') NOT NULL,
    [userType]         INT            NOT NULL,
    [startStructureID] INT            NOT NULL,
    [startMediaID]     INT            NULL,
    [userName]         NVARCHAR (255) NOT NULL,
    [userLogin]        NVARCHAR (125) NOT NULL,
    [userPassword]     NVARCHAR (500) NOT NULL,
    [userEmail]        NVARCHAR (255) NOT NULL,
    [userLanguage]     NVARCHAR (10)  NULL,
    CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_umbracoUser_umbracoUserType_id] FOREIGN KEY ([userType]) REFERENCES [dbo].[umbracoUserType] ([id])
);


GO
CREATE NONCLUSTERED INDEX [IX_umbracoUser_userLogin]
    ON [dbo].[umbracoUser]([userLogin] ASC);

