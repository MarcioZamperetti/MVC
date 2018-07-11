CREATE TABLE [dbo].[compradores] (
    [id]       INT            IDENTITY (1, 1) NOT NULL,
    [nome]     NVARCHAR (200) NULL,
    [endereco] NVARCHAR (300) NULL,
    [telefone] NVARCHAR (20)  NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

