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
IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20260627161934_InicialInventario'
)
BEGIN
    CREATE TABLE [Productos] (
        [Id] int NOT NULL IDENTITY,
        [Nombre] nvarchar(100) NOT NULL,
        [Categoria] nvarchar(50) NOT NULL,
        [Precio] decimal(18,2) NOT NULL,
        [Stock] int NOT NULL,
        CONSTRAINT [PK_Productos] PRIMARY KEY ([Id])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20260627161934_InicialInventario'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20260627161934_InicialInventario', N'10.0.9');
END;

COMMIT;
GO

BEGIN TRANSACTION;
IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20260627165732_DatosSemilla'
)
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Categoria', N'Nombre', N'Precio', N'Stock') AND [object_id] = OBJECT_ID(N'[Productos]'))
        SET IDENTITY_INSERT [Productos] ON;
    EXEC(N'INSERT INTO [Productos] ([Id], [Categoria], [Nombre], [Precio], [Stock])
    VALUES (1, N''Electrónica'', N''Laptop'', 999.99, 10),
    (2, N''Electrónica'', N''Smartphone'', 499.99, 3),
    (3, N''Muebles'', N''Mesa de Oficina'', 199.0, 15),
    (4, N''Muebles'', N''Silla Ergonómica'', 149.99, 2),
    (5, N''Electrónica'', N''Mouse Ergonómico'', 700.0, 5)');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Categoria', N'Nombre', N'Precio', N'Stock') AND [object_id] = OBJECT_ID(N'[Productos]'))
        SET IDENTITY_INSERT [Productos] OFF;
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20260627165732_DatosSemilla'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20260627165732_DatosSemilla', N'10.0.9');
END;

COMMIT;
GO

