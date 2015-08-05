CREATE TABLE [dbo].[RackSample] (
    [SampleId]   INT    NOT NULL,
    [RackNumber] BIGINT NOT NULL,
    CONSTRAINT [PK_RackSample] PRIMARY KEY CLUSTERED ([SampleId] ASC, [RackNumber] ASC),
    CONSTRAINT [FK_RackSample_Rack] FOREIGN KEY ([RackNumber]) REFERENCES [dbo].[Rack] ([RackNumber]),
    CONSTRAINT [FK_RackSample_Sample] FOREIGN KEY ([SampleId]) REFERENCES [dbo].[Sample] ([Id])
);

