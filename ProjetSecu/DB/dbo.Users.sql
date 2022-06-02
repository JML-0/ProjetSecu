CREATE TABLE [dbo].[Users] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Username] NVARCHAR (44)  NULL,
    [Password] NVARCHAR (192) NULL,
    [Email]    NVARCHAR (320) NULL,
    [Address]  NVARCHAR (120) NULL,
    [Age]      NVARCHAR (24)  NULL,
    [Sex]      NVARCHAR (24)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

