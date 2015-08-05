CREATE TABLE [dbo].[WarehouseProductProduct] (
    [ProductId]          INT NOT NULL,
    [WarehouseProductId] INT NOT NULL,
    CONSTRAINT [PK_ProductWarehouseProduct] PRIMARY KEY CLUSTERED ([ProductId] ASC, [WarehouseProductId] ASC),
    CONSTRAINT [FK_WarehouseProductProduct_Product] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product] ([Id])
);

