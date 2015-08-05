CREATE TABLE [dbo].[PaymentMethod] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (30) NOT NULL,
    [CreatedBy]    INT           NOT NULL,
    [DateCreated]  DATETIME      NOT NULL,
    [ModifiedBy]   INT           NULL,
    [DateModified] DATETIME      NULL,
    CONSTRAINT [PK_PaymentMethod] PRIMARY KEY CLUSTERED ([Id] ASC)
);

