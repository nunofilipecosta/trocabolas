CREATE TABLE [dbo].[umbracoUserLogins] (
    [contextID] UNIQUEIDENTIFIER NOT NULL,
    [userID]    INT              NOT NULL,
    [timeout]   BIGINT           NOT NULL,
	RowId int NOT NULL IDENTITY (1, 1) PRIMARY KEY CLUSTERED
);


GO
CREATE NONCLUSTERED INDEX [umbracoUserLogins_Index]
    ON [dbo].[umbracoUserLogins]([contextID] ASC);

