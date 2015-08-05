CREATE TABLE [dbo].[RoleRestriction] (
    [RoleId]        INT NOT NULL,
    [RestrictionId] INT NOT NULL,
    CONSTRAINT [PK_RoleRestriction_1] PRIMARY KEY CLUSTERED ([RoleId] ASC, [RestrictionId] ASC),
    CONSTRAINT [FK_RoleRestriction_Role] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[Role] ([Id]),
    CONSTRAINT [FK_RoleRestriction_RoleRestriction] FOREIGN KEY ([RestrictionId]) REFERENCES [dbo].[Restriction] ([Id])
);

