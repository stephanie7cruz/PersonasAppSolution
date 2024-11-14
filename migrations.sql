IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;

CREATE TABLE [Personas] (
    [Id] int NOT NULL IDENTITY,
    [Nombres] nvarchar(255) NOT NULL,
    [Apellidos] nvarchar(255) NOT NULL,
    [TipoDocumento] nvarchar(50) NOT NULL,
    [FechaNacimiento] date NOT NULL,
    [ValorAGanar] decimal(18, 2) NOT NULL,
    [EstadoCivil] nvarchar(50) NOT NULL,
    CONSTRAINT [PK_Personas] PRIMARY KEY ([Id])
);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20241114184419_InitialCreate', N'9.0.0');

COMMIT;
GO
