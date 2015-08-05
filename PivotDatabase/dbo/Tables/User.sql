CREATE TABLE [dbo].[User] (
    [Id]           INT          IDENTITY (1, 1) NOT NULL,
    [Name]         VARCHAR (50) NOT NULL,
    [Password]     VARCHAR (50) NOT NULL,
    [Deleted]      BIT          NOT NULL,
    [DateCreated]  DATETIME     NOT NULL,
    [CreatedBy]    INT          NOT NULL,
    [DateModified] DATETIME     NULL,
    [ModifiedBy]   INT          NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [IX_UniqueUser] UNIQUE NONCLUSTERED ([Name] ASC)
);



