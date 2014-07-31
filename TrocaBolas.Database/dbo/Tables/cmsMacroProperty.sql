﻿CREATE TABLE [dbo].[cmsMacroProperty] (
    [id]                     INT            IDENTITY (1, 1) NOT NULL,
    [macro]                  INT            NOT NULL,
    [macroPropertySortOrder] INT            DEFAULT ('0') NOT NULL,
    [macroPropertyAlias]     NVARCHAR (50)  NOT NULL,
    [macroPropertyName]      NVARCHAR (255) NOT NULL,
    [editorAlias]            NVARCHAR (255) NOT NULL,
    CONSTRAINT [PK_cmsMacroProperty] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_cmsMacroProperty_cmsMacro_id] FOREIGN KEY ([macro]) REFERENCES [dbo].[cmsMacro] ([id])
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_cmsMacroProperty_Alias]
    ON [dbo].[cmsMacroProperty]([macro] ASC, [macroPropertyAlias] ASC);

