CREATE TABLE [dbo].[TBALTERNATIVA] (
    [id]         INT           IDENTITY (1, 1) NOT NULL,
    [resposta]   VARCHAR (MAX) NOT NULL,
    [verdadeiro] BIT           NOT NULL,
    [questao_id] INT           NOT NULL,
    CONSTRAINT [PK_tbalternativa] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_tbalternativa_tbquestao] FOREIGN KEY ([questao_id]) REFERENCES [dbo].[TBQUESTAO] ([id])
);

