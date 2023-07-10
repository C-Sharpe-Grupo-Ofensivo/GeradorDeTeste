CREATE TABLE [dbo].[TBTESTE_TBQUESTAO] (
    [teste_id]   INT NOT NULL,
    [questao_id] INT NOT NULL,
    CONSTRAINT [FK_tbquestao_tbteste] FOREIGN KEY ([questao_id]) REFERENCES [dbo].[TBQUESTAO] ([id]),
    CONSTRAINT [FK_tbteste_tbquestao] FOREIGN KEY ([teste_id]) REFERENCES [dbo].[TBTESTE] ([id])
);

