CREATE TABLE [dbo].[TBQUESTAO] (
    [id]         INT           IDENTITY (1, 1) NOT NULL,
    [enunciado]  VARCHAR (MAX) NOT NULL,
    [materia_id] INT           NOT NULL,
    [resposta]   VARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_questao] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_tbquestao_tbmateria] FOREIGN KEY ([materia_id]) REFERENCES [dbo].[TBMATERIA] ([id])
);

