CREATE TABLE [dbo].[TBTESTE] (
    [id]                INT          IDENTITY (1, 1) NOT NULL,
    [nome]              VARCHAR (50) NOT NULL,
    [disciplina_id]     INT          NOT NULL,
    [materia_id]        INT          NOT NULL,
    [quantidadequestao] INT          NULL,
    [recuperacao]       BIT          NOT NULL,
    CONSTRAINT [PK_TBTESTE] PRIMARY KEY CLUSTERED ([id] ASC)
);

