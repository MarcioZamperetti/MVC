CREATE TABLE [dbo].[compras] (
    [id]           INT             IDENTITY (1, 1) NOT NULL,
    [valor]        DECIMAL (18, 2) NULL,
    [data]         DATE            NULL,
    [observacoes]  NVARCHAR (200)  NULL,
    [recebida]     BIT             NULL,
    [comprador_id] INT             NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

