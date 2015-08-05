CREATE TABLE [dbo].[Region] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (50) NOT NULL,
    [LanguageCode] NVARCHAR (50) NULL,
    [IsActive]     BIT           CONSTRAINT [DF__Region__IsActive__07C12930] DEFAULT ((1)) NOT NULL,
    [CreatedBy]    INT           NOT NULL,
    [DateCreated]  DATETIME      CONSTRAINT [DF__Region__DateCrea__08B54D69] DEFAULT (getdate()) NOT NULL,
    [ModifiedBy]   INT           NULL,
    [DateModified] DATETIME      NULL,
    CONSTRAINT [PK_Region] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [uq_Region] UNIQUE NONCLUSTERED ([Name] ASC, [IsActive] DESC)
);







