CREATE TABLE [dbo].[Event] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (100) NOT NULL,
    [Deleted]      BIT            NOT NULL,
    [DateCreated]  DATETIME       NOT NULL,
    [CreatedBy]    INT            NOT NULL,
    [DateModified] DATETIME       NULL,
    [ModifiedBy]   INT            NULL,
    CONSTRAINT [PK_Event] PRIMARY KEY CLUSTERED ([Id] ASC)
);




