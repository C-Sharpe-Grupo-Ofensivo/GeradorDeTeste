CREATE TABLE [dbo].[TBMATERIA] (
    [id]            INT           IDENTITY (1, 1) NOT NULL,
    [nome]          VARCHAR (MAX) NOT NULL,
    [serie]         VARCHAR (MAX) NOT NULL,
    [disciplina_id] INT           NOT NULL,
    CONSTRAINT [PK_tbmateria] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_tbMateria_tbdisciplina] FOREIGN KEY ([disciplina_id]) REFERENCES [dbo].[TBDISCIPLINA] ([id])
);

