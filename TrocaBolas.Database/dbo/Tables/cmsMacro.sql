CREATE TABLE [dbo].[cmsMacro] (
    [id]                     INT            IDENTITY (1, 1) NOT NULL,
    [macroUseInEditor]       BIT            DEFAULT ('0') NOT NULL,
    [macroRefreshRate]       INT            DEFAULT ('0') NOT NULL,
    [macroAlias]             NVARCHAR (255) NOT NULL,
    [macroName]              NVARCHAR (255) NULL,
    [macroScriptType]        NVARCHAR (255) NULL,
    [macroScriptAssembly]    NVARCHAR (255) NULL,
    [macroXSLT]              NVARCHAR (255) NULL,
    [macroCacheByPage]       BIT            DEFAULT ('1') NOT NULL,
    [macroCachePersonalized] BIT            DEFAULT ('0') NOT NULL,
    [macroDontRender]        BIT            DEFAULT ('0') NOT NULL,
    [macroPython]            NVARCHAR (255) NULL,
    CONSTRAINT [PK_cmsMacro] PRIMARY KEY CLUSTERED ([id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_cmsMacro_Alias]
    ON [dbo].[cmsMacro]([macroAlias] ASC);

