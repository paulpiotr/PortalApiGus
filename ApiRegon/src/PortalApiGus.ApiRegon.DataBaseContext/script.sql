Build started...
Build succeeded.
Server=ISK-PP\SQLEXPRESS; Database=IUIntegrationSystemData; MultipleActiveResultSets=true; User Id=sa; Password=NIEznaszhasla111; Pooling=True; Max Pool Size=1024; Max Pool Size=65536
2021-04-06 15:11:05,556 DEBUG: Try CheckAndMigrateAsync...
2021-04-06 15:11:07,318 WARN : 
Microsoft.Data.SqlClient.SqlException

Column 'StatusNip' in table 'pagard.DaneSzukajPodmioty' is of a type that is invalid for use as a key column in an index.
   at Microsoft.Data.SqlClient.SqlConnection.OnError(SqlException exception, Boolean breakConnection, Action`1 wrapCloseInAction) in H:\tsaagent1\_work\21\s\src\Microsoft.Data.SqlClient\netcore\src\Microsoft\Data\SqlClient\SqlConnection.cs:line 1777
   at Microsoft.Data.SqlClient.SqlInternalConnection.OnError(SqlException exception, Boolean breakConnection, Action`1 wrapCloseInAction) in H:\tsaagent1\_work\21\s\src\Microsoft.Data.SqlClient\netcore\src\Microsoft\Data\SqlClient\SqlInternalConnection.cs:line 606
   at Microsoft.Data.SqlClient.TdsParser.ThrowExceptionAndWarning(TdsParserStateObject stateObj, Boolean callerHasConnectionLock, Boolean asyncClose) in H:\tsaagent1\_work\21\s\src\Microsoft.Data.SqlClient\netcore\src\Microsoft\Data\SqlClient\TdsParser.cs:line 1302
   at Microsoft.Data.SqlClient.TdsParser.TryRun(RunBehavior runBehavior, SqlCommand cmdHandler, SqlDataReader dataStream, BulkCopySimpleResultSet bulkCopyHandler, TdsParserStateObject stateObj, Boolean& dataReady) in H:\tsaagent1\_work\21\s\src\Microsoft.Data.SqlClient\netcore\src\Microsoft\Data\SqlClient\TdsParser.cs:line 2523
   at Microsoft.Data.SqlClient.SqlCommand.InternalEndExecuteNonQuery(IAsyncResult asyncResult, Boolean isInternal, String endMethod) in H:\tsaagent1\_work\21\s\src\Microsoft.Data.SqlClient\netcore\src\Microsoft\Data\SqlClient\SqlCommand.cs:line 1401
   at Microsoft.Data.SqlClient.SqlCommand.EndExecuteNonQueryInternal(IAsyncResult asyncResult) in H:\tsaagent1\_work\21\s\src\Microsoft.Data.SqlClient\netcore\src\Microsoft\Data\SqlClient\SqlCommand.cs:line 1331
   at Microsoft.Data.SqlClient.SqlCommand.EndExecuteNonQueryAsync(IAsyncResult asyncResult) in H:\tsaagent1\_work\21\s\src\Microsoft.Data.SqlClient\netcore\src\Microsoft\Data\SqlClient\SqlCommand.cs:line 1312
   at System.Threading.Tasks.TaskFactory`1.FromAsyncCoreLogic(IAsyncResult iar, Func`2 endFunction, Action`1 endAction, Task`1 promise, Boolean requiresSynchronization)
--- End of stack trace from previous location ---
   at Microsoft.EntityFrameworkCore.Storage.RelationalCommand.ExecuteNonQueryAsync(RelationalCommandParameterObject parameterObject, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Storage.RelationalCommand.ExecuteNonQueryAsync(RelationalCommandParameterObject parameterObject, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Storage.RelationalCommand.ExecuteNonQueryAsync(RelationalCommandParameterObject parameterObject, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Migrations.Internal.MigrationCommandExecutor.ExecuteNonQueryAsync(IEnumerable`1 migrationCommands, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Migrations.Internal.MigrationCommandExecutor.ExecuteNonQueryAsync(IEnumerable`1 migrationCommands, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Migrations.Internal.MigrationCommandExecutor.ExecuteNonQueryAsync(IEnumerable`1 migrationCommands, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Migrations.Internal.MigrationCommandExecutor.ExecuteNonQueryAsync(IEnumerable`1 migrationCommands, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Migrations.Internal.Migrator.MigrateAsync(String targetMigration, CancellationToken cancellationToken)
   at NetAppCommon.Helpers.EntityContextHelper.RunMigrationAsync[TDbContext](TDbContext context) in D:\Praca\NetCoreDev\NetAppCommon\NetAppCommon\Helpers\EntityContextHelper.cs:line 122

Microsoft.Data.SqlClient.SqlException (0x80131904): Column 'StatusNip' in table 'pagard.DaneSzukajPodmioty' is of a type that is invalid for use as a key column in an index.
   at Microsoft.Data.SqlClient.SqlConnection.OnError(SqlException exception, Boolean breakConnection, Action`1 wrapCloseInAction) in H:\tsaagent1\_work\21\s\src\Microsoft.Data.SqlClient\netcore\src\Microsoft\Data\SqlClient\SqlConnection.cs:line 1777
   at Microsoft.Data.SqlClient.SqlInternalConnection.OnError(SqlException exception, Boolean breakConnection, Action`1 wrapCloseInAction) in H:\tsaagent1\_work\21\s\src\Microsoft.Data.SqlClient\netcore\src\Microsoft\Data\SqlClient\SqlInternalConnection.cs:line 606
   at Microsoft.Data.SqlClient.TdsParser.ThrowExceptionAndWarning(TdsParserStateObject stateObj, Boolean callerHasConnectionLock, Boolean asyncClose) in H:\tsaagent1\_work\21\s\src\Microsoft.Data.SqlClient\netcore\src\Microsoft\Data\SqlClient\TdsParser.cs:line 1302
   at Microsoft.Data.SqlClient.TdsParser.TryRun(RunBehavior runBehavior, SqlCommand cmdHandler, SqlDataReader dataStream, BulkCopySimpleResultSet bulkCopyHandler, TdsParserStateObject stateObj, Boolean& dataReady) in H:\tsaagent1\_work\21\s\src\Microsoft.Data.SqlClient\netcore\src\Microsoft\Data\SqlClient\TdsParser.cs:line 2523
   at Microsoft.Data.SqlClient.SqlCommand.InternalEndExecuteNonQuery(IAsyncResult asyncResult, Boolean isInternal, String endMethod) in H:\tsaagent1\_work\21\s\src\Microsoft.Data.SqlClient\netcore\src\Microsoft\Data\SqlClient\SqlCommand.cs:line 1401
   at Microsoft.Data.SqlClient.SqlCommand.EndExecuteNonQueryInternal(IAsyncResult asyncResult) in H:\tsaagent1\_work\21\s\src\Microsoft.Data.SqlClient\netcore\src\Microsoft\Data\SqlClient\SqlCommand.cs:line 1331
   at Microsoft.Data.SqlClient.SqlCommand.EndExecuteNonQueryAsync(IAsyncResult asyncResult) in H:\tsaagent1\_work\21\s\src\Microsoft.Data.SqlClient\netcore\src\Microsoft\Data\SqlClient\SqlCommand.cs:line 1312
   at System.Threading.Tasks.TaskFactory`1.FromAsyncCoreLogic(IAsyncResult iar, Func`2 endFunction, Action`1 endAction, Task`1 promise, Boolean requiresSynchronization)
--- End of stack trace from previous location ---
   at Microsoft.EntityFrameworkCore.Storage.RelationalCommand.ExecuteNonQueryAsync(RelationalCommandParameterObject parameterObject, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Storage.RelationalCommand.ExecuteNonQueryAsync(RelationalCommandParameterObject parameterObject, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Storage.RelationalCommand.ExecuteNonQueryAsync(RelationalCommandParameterObject parameterObject, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Migrations.Internal.MigrationCommandExecutor.ExecuteNonQueryAsync(IEnumerable`1 migrationCommands, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Migrations.Internal.MigrationCommandExecutor.ExecuteNonQueryAsync(IEnumerable`1 migrationCommands, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Migrations.Internal.MigrationCommandExecutor.ExecuteNonQueryAsync(IEnumerable`1 migrationCommands, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Migrations.Internal.MigrationCommandExecutor.ExecuteNonQueryAsync(IEnumerable`1 migrationCommands, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Migrations.Internal.Migrator.MigrateAsync(String targetMigration, CancellationToken cancellationToken)
   at NetAppCommon.Helpers.EntityContextHelper.RunMigrationAsync[TDbContext](TDbContext context) in D:\Praca\NetCoreDev\NetAppCommon\NetAppCommon\Helpers\EntityContextHelper.cs:line 122
ClientConnectionId:121c7555-d41b-4f2b-a6d5-533cbea465fd
Error Number:1919,State:1,Class:16
2021-04-06 15:11:07,325 DEBUG: Ok
2021-04-06 15:11:07,510 DEBUG: Execute SQL: CREATE TABLE [pagard].[DaneSzukajPodmiotyParametryWyszukiwaniaAudit] (
    [Id]          [uniqueidentifier] NOT NULL,
    [PK]          NVARCHAR (MAX) NULL,
    [JsonData]    NVARCHAR (MAX) NOT NULL,
    [UserName]    NVARCHAR (256) NOT NULL,
    [AuditDate]   DATETIME       NOT NULL,
    [AuditAction] NVARCHAR (16)  NOT NULL,
    [AuditIP]     NVARCHAR (32)  NOT NULL,
    CONSTRAINT [PK_dbo.DaneSzukajPodmiotyParametryWyszukiwaniaAudit] PRIMARY KEY CLUSTERED ([Id] ASC)
);

ALTER TABLE [pagard].[DaneSzukajPodmiotyParametryWyszukiwaniaAudit] ADD DEFAULT (newsequentialid()) FOR [Id];
2021-04-06 15:11:07,511 DEBUG: OK
2021-04-06 15:11:07,513 DEBUG: Execute SQL: CREATE TRIGGER [pagard].[Trigger_DaneSzukajPodmiotyParametryWyszukiwaniaAudit]
ON [pagard].[DaneSzukajPodmiotyParametryWyszukiwania]
AFTER UPDATE, INSERT, DELETE
AS
BEGIN
    SET NoCount ON
	DECLARE @AuditAction AS nvarchar(16) = 'Insert';
	IF EXISTS(SELECT * FROM DELETED)
	BEGIN
		SET @AuditAction = CASE WHEN EXISTS(SELECT * FROM INSERTED) THEN 'Update' ELSE 'Delete' END
	END
	IF (@AuditAction = 'Insert' OR @AuditAction = 'Update')
	BEGIN
		INSERT INTO [pagard].[DaneSzukajPodmiotyParametryWyszukiwaniaAudit] ([PK] ,[JsonData] ,[UserName] ,[AuditDate] ,[AuditAction] ,[AuditIP])
		(SELECT
			CAST(i.Id AS NVARCHAR(max)),
			CAST(JSON_QUERY((SELECT i.* FOR JSON PATH, WITHOUT_ARRAY_WRAPPER)) AS NVARCHAR(max)),
			SUSER_SNAME(),
			GETDATE(),
			@AuditAction,
			(SELECT CONVERT(VARCHAR(48), CONNECTIONPROPERTY('client_net_address')))
		FROM inserted AS i)
	END
	ELSE IF (@AuditAction = 'Delete')
	BEGIN
		INSERT INTO [pagard].[DaneSzukajPodmiotyParametryWyszukiwaniaAudit] ([PK] ,[JsonData] ,[UserName] ,[AuditDate] ,[AuditAction] ,[AuditIP])
		(SELECT
			CAST(d.Id AS NVARCHAR(max)),
			CAST(JSON_QUERY((SELECT d.* FOR JSON PATH, WITHOUT_ARRAY_WRAPPER)) AS NVARCHAR(max)),
			SUSER_SNAME(),
			GETDATE(),
			@AuditAction,
			(SELECT CONVERT(VARCHAR(48), CONNECTIONPROPERTY('client_net_address')))
		FROM deleted AS d)
	END
END
2021-04-06 15:11:07,513 DEBUG: OK
2021-04-06 15:11:07,513 DEBUG: Execute SQL: CREATE TABLE [pagard].[DaneSzukajPodmiotyAudit] (
    [Id]          [uniqueidentifier] NOT NULL,
    [PK]          NVARCHAR (MAX) NULL,
    [JsonData]    NVARCHAR (MAX) NOT NULL,
    [UserName]    NVARCHAR (256) NOT NULL,
    [AuditDate]   DATETIME       NOT NULL,
    [AuditAction] NVARCHAR (16)  NOT NULL,
    [AuditIP]     NVARCHAR (32)  NOT NULL,
    CONSTRAINT [PK_dbo.DaneSzukajPodmiotyAudit] PRIMARY KEY CLUSTERED ([Id] ASC)
);

ALTER TABLE [pagard].[DaneSzukajPodmiotyAudit] ADD DEFAULT (newsequentialid()) FOR [Id];
2021-04-06 15:11:07,513 DEBUG: OK
2021-04-06 15:11:07,514 DEBUG: Execute SQL: CREATE TRIGGER [pagard].[Trigger_DaneSzukajPodmiotyAudit]
ON [pagard].[DaneSzukajPodmioty]
AFTER UPDATE, INSERT, DELETE
AS
BEGIN
    SET NoCount ON
	DECLARE @AuditAction AS nvarchar(16) = 'Insert';
	IF EXISTS(SELECT * FROM DELETED)
	BEGIN
		SET @AuditAction = CASE WHEN EXISTS(SELECT * FROM INSERTED) THEN 'Update' ELSE 'Delete' END
	END
	IF (@AuditAction = 'Insert' OR @AuditAction = 'Update')
	BEGIN
		INSERT INTO [pagard].[DaneSzukajPodmiotyAudit] ([PK] ,[JsonData] ,[UserName] ,[AuditDate] ,[AuditAction] ,[AuditIP])
		(SELECT
			CAST(i.Id AS NVARCHAR(max)),
			CAST(JSON_QUERY((SELECT i.* FOR JSON PATH, WITHOUT_ARRAY_WRAPPER)) AS NVARCHAR(max)),
			SUSER_SNAME(),
			GETDATE(),
			@AuditAction,
			(SELECT CONVERT(VARCHAR(48), CONNECTIONPROPERTY('client_net_address')))
		FROM inserted AS i)
	END
	ELSE IF (@AuditAction = 'Delete')
	BEGIN
		INSERT INTO [pagard].[DaneSzukajPodmiotyAudit] ([PK] ,[JsonData] ,[UserName] ,[AuditDate] ,[AuditAction] ,[AuditIP])
		(SELECT
			CAST(d.Id AS NVARCHAR(max)),
			CAST(JSON_QUERY((SELECT d.* FOR JSON PATH, WITHOUT_ARRAY_WRAPPER)) AS NVARCHAR(max)),
			SUSER_SNAME(),
			GETDATE(),
			@AuditAction,
			(SELECT CONVERT(VARCHAR(48), CONNECTIONPROPERTY('client_net_address')))
		FROM deleted AS d)
	END
END
2021-04-06 15:11:07,514 DEBUG: OK
IF OBJECT_ID(N'[pagard].[__EFMigrationsHistory]') IS NULL
BEGIN
    IF SCHEMA_ID(N'pagard') IS NULL EXEC(N'CREATE SCHEMA [pagard];');
    CREATE TABLE [pagard].[__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF SCHEMA_ID(N'pagard') IS NULL EXEC(N'CREATE SCHEMA [pagard];');
GO

CREATE TABLE [pagard].[DaneSzukajPodmioty] (
    [Id] uniqueidentifier NOT NULL DEFAULT ((newsequentialid())),
    [UniqueIdentifierOfTheLoggedInUser] varchar(512) NULL,
    [ParametryWyszukiwaniaSHA512] nvarchar(max) NULL,
    [ParametryWyszukiwaniaJson] nvarchar(max) NULL,
    [Regon] nvarchar(14) NULL,
    [Nip] nvarchar(10) NULL,
    [StatusNip] nvarchar(12) NULL,
    [Nazwa] nvarchar(2000) NULL,
    [Wojewodztwo] nvarchar(200) NULL,
    [Powiat] nvarchar(200) NULL,
    [Gmina] nvarchar(200) NULL,
    [Miejscowosc] nvarchar(200) NULL,
    [KodPocztowy] nvarchar(12) NULL,
    [Ulica] nvarchar(200) NULL,
    [NrNieruchomosci] nvarchar(20) NULL,
    [NrLokalu] nvarchar(10) NULL,
    [Typ] nvarchar(2) NULL,
    [SilosID] int NULL,
    [DataZakonczeniaDzialalnosci] nvarchar(10) NULL,
    [MiejscowoscPoczty] nvarchar(200) NULL,
    [DataUtworzenia] datetime NOT NULL DEFAULT ((getdate())),
    [DataModyfikacji] datetime NULL,
    CONSTRAINT [PK_DaneSzukajPodmioty] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] (
    [Id] uniqueidentifier NOT NULL DEFAULT ((newsequentialid())),
    [UniqueIdentifierOfTheLoggedInUser] varchar(512) NULL,
    [SHA512] nvarchar(max) NULL,
    [Regon] nvarchar(14) NULL,
    [Nip] nvarchar(10) NULL,
    [Krs] nvarchar(10) NULL,
    [Nipy] nvarchar(220) NULL,
    [Regony14zn] nvarchar(300) NULL,
    [Regony9zn] nvarchar(200) NULL,
    [Krsy] nvarchar(220) NULL,
    [DataUtworzenia] datetime NOT NULL DEFAULT ((getdate())),
    [DataModyfikacji] datetime NULL,
    CONSTRAINT [PK_DaneSzukajPodmiotyParametryWyszukiwania] PRIMARY KEY ([Id])
);
GO

CREATE INDEX [IX_DaneSzukajPodmiotyGmina] ON [pagard].[DaneSzukajPodmioty] ([Gmina]);
GO

CREATE UNIQUE INDEX [IX_DaneSzukajPodmiotyId] ON [pagard].[DaneSzukajPodmioty] ([Id]);
GO

CREATE INDEX [IX_DaneSzukajPodmiotyKodPocztowy] ON [pagard].[DaneSzukajPodmioty] ([KodPocztowy]);
GO

CREATE INDEX [IX_DaneSzukajPodmiotyMiejscowosc] ON [pagard].[DaneSzukajPodmioty] ([Miejscowosc]);
GO

CREATE INDEX [IX_DaneSzukajPodmiotySilosMiejscowoscPoczty] ON [pagard].[DaneSzukajPodmioty] ([MiejscowoscPoczty]);
GO

CREATE INDEX [IX_DaneSzukajPodmiotyNazwa] ON [pagard].[DaneSzukajPodmioty] ([Nazwa]);
GO

CREATE INDEX [IX_DaneSzukajPodmiotyNip] ON [pagard].[DaneSzukajPodmioty] ([Nip]);
GO

CREATE INDEX [IX_DaneSzukajPodmiotyPowiat] ON [pagard].[DaneSzukajPodmioty] ([Powiat]);
GO

CREATE INDEX [IX_DaneSzukajPodmiotyRegon] ON [pagard].[DaneSzukajPodmioty] ([Regon]);
GO

CREATE INDEX [IX_DaneSzukajPodmiotySilosID] ON [pagard].[DaneSzukajPodmioty] ([SilosID]);
GO

CREATE INDEX [IX_DaneSzukajPodmiotyTyp] ON [pagard].[DaneSzukajPodmioty] ([Typ]);
GO

CREATE INDEX [IX_DaneSzukajPodmiotyUlica] ON [pagard].[DaneSzukajPodmioty] ([Ulica]);
GO

CREATE INDEX [IX_DaneSzukajPodmiotyUniqueIdentifierOfTheLoggedInUser] ON [pagard].[DaneSzukajPodmioty] ([UniqueIdentifierOfTheLoggedInUser]);
GO

CREATE INDEX [IX_DaneSzukajPodmiotyWojewodztwo] ON [pagard].[DaneSzukajPodmioty] ([Wojewodztwo]);
GO

CREATE UNIQUE INDEX [IX_DaneSzukajPodmiotyParametryWyszukiwaniaId] ON [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] ([Id]);
GO

CREATE INDEX [IX_DaneSzukajPodmiotyParametryWyszukiwaniaKrs] ON [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] ([Krs]);
GO

CREATE INDEX [IX_DaneSzukajPodmiotyParametryWyszukiwaniaKrsy] ON [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] ([Krsy]);
GO

CREATE INDEX [IX_DaneSzukajPodmiotyParametryWyszukiwaniaNip] ON [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] ([Nip]);
GO

CREATE INDEX [IX_DaneSzukajPodmiotyParametryWyszukiwaniaNipy] ON [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] ([Nipy]);
GO

CREATE INDEX [IX_DaneSzukajPodmiotyParametryWyszukiwaniaRegon] ON [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] ([Regon]);
GO

CREATE INDEX [IX_DaneSzukajPodmiotyParametryWyszukiwaniaRegony14zn] ON [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] ([Regony14zn]);
GO

CREATE INDEX [IX_DaneSzukajPodmiotyParametryWyszukiwaniaRegony9zn] ON [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] ([Regony9zn]);
GO

CREATE INDEX [IX_DaneSzukajPodmiotyParametryWyszukiwaniaUniqueIdentifierOfTheLoggedInUser] ON [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] ([UniqueIdentifierOfTheLoggedInUser]);
GO

INSERT INTO [pagard].[__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201018235531_1', N'5.0.4');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [pagard].[DaneSzukajPodmiotyParametryWyszukiwaniaAudit] (
    [Id]          [uniqueidentifier] NOT NULL,
    [PK]          NVARCHAR (MAX) NULL,
    [JsonData]    NVARCHAR (MAX) NOT NULL,
    [UserName]    NVARCHAR (256) NOT NULL,
    [AuditDate]   DATETIME       NOT NULL,
    [AuditAction] NVARCHAR (16)  NOT NULL,
    [AuditIP]     NVARCHAR (32)  NOT NULL,
    CONSTRAINT [PK_dbo.DaneSzukajPodmiotyParametryWyszukiwaniaAudit] PRIMARY KEY CLUSTERED ([Id] ASC)
);

ALTER TABLE [pagard].[DaneSzukajPodmiotyParametryWyszukiwaniaAudit] ADD DEFAULT (newsequentialid()) FOR [Id];
GO

CREATE TRIGGER [pagard].[Trigger_DaneSzukajPodmiotyParametryWyszukiwaniaAudit]
ON [pagard].[DaneSzukajPodmiotyParametryWyszukiwania]
AFTER UPDATE, INSERT, DELETE
AS
BEGIN
    SET NoCount ON
	DECLARE @AuditAction AS nvarchar(16) = 'Insert';
	IF EXISTS(SELECT * FROM DELETED)
	BEGIN
		SET @AuditAction = CASE WHEN EXISTS(SELECT * FROM INSERTED) THEN 'Update' ELSE 'Delete' END
	END
	IF (@AuditAction = 'Insert' OR @AuditAction = 'Update')
	BEGIN
		INSERT INTO [pagard].[DaneSzukajPodmiotyParametryWyszukiwaniaAudit] ([PK] ,[JsonData] ,[UserName] ,[AuditDate] ,[AuditAction] ,[AuditIP])
		(SELECT
			CAST(i.Id AS NVARCHAR(max)),
			CAST(JSON_QUERY((SELECT i.* FOR JSON PATH, WITHOUT_ARRAY_WRAPPER)) AS NVARCHAR(max)),
			SUSER_SNAME(),
			GETDATE(),
			@AuditAction,
			(SELECT CONVERT(VARCHAR(48), CONNECTIONPROPERTY('client_net_address')))
		FROM inserted AS i)
	END
	ELSE IF (@AuditAction = 'Delete')
	BEGIN
		INSERT INTO [pagard].[DaneSzukajPodmiotyParametryWyszukiwaniaAudit] ([PK] ,[JsonData] ,[UserName] ,[AuditDate] ,[AuditAction] ,[AuditIP])
		(SELECT
			CAST(d.Id AS NVARCHAR(max)),
			CAST(JSON_QUERY((SELECT d.* FOR JSON PATH, WITHOUT_ARRAY_WRAPPER)) AS NVARCHAR(max)),
			SUSER_SNAME(),
			GETDATE(),
			@AuditAction,
			(SELECT CONVERT(VARCHAR(48), CONNECTIONPROPERTY('client_net_address')))
		FROM deleted AS d)
	END
END
GO

CREATE TABLE [pagard].[DaneSzukajPodmiotyAudit] (
    [Id]          [uniqueidentifier] NOT NULL,
    [PK]          NVARCHAR (MAX) NULL,
    [JsonData]    NVARCHAR (MAX) NOT NULL,
    [UserName]    NVARCHAR (256) NOT NULL,
    [AuditDate]   DATETIME       NOT NULL,
    [AuditAction] NVARCHAR (16)  NOT NULL,
    [AuditIP]     NVARCHAR (32)  NOT NULL,
    CONSTRAINT [PK_dbo.DaneSzukajPodmiotyAudit] PRIMARY KEY CLUSTERED ([Id] ASC)
);

ALTER TABLE [pagard].[DaneSzukajPodmiotyAudit] ADD DEFAULT (newsequentialid()) FOR [Id];
GO

CREATE TRIGGER [pagard].[Trigger_DaneSzukajPodmiotyAudit]
ON [pagard].[DaneSzukajPodmioty]
AFTER UPDATE, INSERT, DELETE
AS
BEGIN
    SET NoCount ON
	DECLARE @AuditAction AS nvarchar(16) = 'Insert';
	IF EXISTS(SELECT * FROM DELETED)
	BEGIN
		SET @AuditAction = CASE WHEN EXISTS(SELECT * FROM INSERTED) THEN 'Update' ELSE 'Delete' END
	END
	IF (@AuditAction = 'Insert' OR @AuditAction = 'Update')
	BEGIN
		INSERT INTO [pagard].[DaneSzukajPodmiotyAudit] ([PK] ,[JsonData] ,[UserName] ,[AuditDate] ,[AuditAction] ,[AuditIP])
		(SELECT
			CAST(i.Id AS NVARCHAR(max)),
			CAST(JSON_QUERY((SELECT i.* FOR JSON PATH, WITHOUT_ARRAY_WRAPPER)) AS NVARCHAR(max)),
			SUSER_SNAME(),
			GETDATE(),
			@AuditAction,
			(SELECT CONVERT(VARCHAR(48), CONNECTIONPROPERTY('client_net_address')))
		FROM inserted AS i)
	END
	ELSE IF (@AuditAction = 'Delete')
	BEGIN
		INSERT INTO [pagard].[DaneSzukajPodmiotyAudit] ([PK] ,[JsonData] ,[UserName] ,[AuditDate] ,[AuditAction] ,[AuditIP])
		(SELECT
			CAST(d.Id AS NVARCHAR(max)),
			CAST(JSON_QUERY((SELECT d.* FOR JSON PATH, WITHOUT_ARRAY_WRAPPER)) AS NVARCHAR(max)),
			SUSER_SNAME(),
			GETDATE(),
			@AuditAction,
			(SELECT CONVERT(VARCHAR(48), CONNECTIONPROPERTY('client_net_address')))
		FROM deleted AS d)
	END
END
GO

INSERT INTO [pagard].[__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201019000806_2', N'5.0.4');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var24 sysname;
SELECT @var24 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[pagard].[DaneSzukajPodmiotyParametryWyszukiwania]') AND [c].[name] = N'SHA512');
IF @var24 IS NOT NULL EXEC(N'ALTER TABLE [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] DROP CONSTRAINT [' + @var24 + '];');
ALTER TABLE [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] DROP COLUMN [SHA512];
GO

DECLARE @var25 sysname;
SELECT @var25 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[pagard].[DaneSzukajPodmioty]') AND [c].[name] = N'ParametryWyszukiwaniaJson');
IF @var25 IS NOT NULL EXEC(N'ALTER TABLE [pagard].[DaneSzukajPodmioty] DROP CONSTRAINT [' + @var25 + '];');
ALTER TABLE [pagard].[DaneSzukajPodmioty] DROP COLUMN [ParametryWyszukiwaniaJson];
GO

DECLARE @var26 sysname;
SELECT @var26 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[pagard].[DaneSzukajPodmioty]') AND [c].[name] = N'ParametryWyszukiwaniaSHA512');
IF @var26 IS NOT NULL EXEC(N'ALTER TABLE [pagard].[DaneSzukajPodmioty] DROP CONSTRAINT [' + @var26 + '];');
ALTER TABLE [pagard].[DaneSzukajPodmioty] DROP COLUMN [ParametryWyszukiwaniaSHA512];
GO

EXEC sp_rename N'[pagard].[DaneSzukajPodmiotyParametryWyszukiwania].[IX_DaneSzukajPodmiotyParametryWyszukiwaniaUniqueIdentifierOfTheLoggedInUser]', N'IX_DaneSzukajPodmiotyParametryWyszukiwania_UniqueIdentifierOfTheLoggedInUser', N'INDEX';
GO

EXEC sp_rename N'[pagard].[DaneSzukajPodmiotyParametryWyszukiwania].[IX_DaneSzukajPodmiotyParametryWyszukiwaniaRegony9zn]', N'IX_DaneSzukajPodmiotyParametryWyszukiwania_Regony9zn', N'INDEX';
GO

EXEC sp_rename N'[pagard].[DaneSzukajPodmiotyParametryWyszukiwania].[IX_DaneSzukajPodmiotyParametryWyszukiwaniaRegony14zn]', N'IX_DaneSzukajPodmiotyParametryWyszukiwania_Regony14zn', N'INDEX';
GO

EXEC sp_rename N'[pagard].[DaneSzukajPodmiotyParametryWyszukiwania].[IX_DaneSzukajPodmiotyParametryWyszukiwaniaRegon]', N'IX_DaneSzukajPodmiotyParametryWyszukiwania_Regon', N'INDEX';
GO

EXEC sp_rename N'[pagard].[DaneSzukajPodmiotyParametryWyszukiwania].[IX_DaneSzukajPodmiotyParametryWyszukiwaniaNipy]', N'IX_DaneSzukajPodmiotyParametryWyszukiwania_Nipy', N'INDEX';
GO

EXEC sp_rename N'[pagard].[DaneSzukajPodmiotyParametryWyszukiwania].[IX_DaneSzukajPodmiotyParametryWyszukiwaniaNip]', N'IX_DaneSzukajPodmiotyParametryWyszukiwania_Nip', N'INDEX';
GO

EXEC sp_rename N'[pagard].[DaneSzukajPodmiotyParametryWyszukiwania].[IX_DaneSzukajPodmiotyParametryWyszukiwaniaKrsy]', N'IX_DaneSzukajPodmiotyParametryWyszukiwania_Krsy', N'INDEX';
GO

EXEC sp_rename N'[pagard].[DaneSzukajPodmiotyParametryWyszukiwania].[IX_DaneSzukajPodmiotyParametryWyszukiwaniaKrs]', N'IX_DaneSzukajPodmiotyParametryWyszukiwania_Krs', N'INDEX';
GO

EXEC sp_rename N'[pagard].[DaneSzukajPodmiotyParametryWyszukiwania].[IX_DaneSzukajPodmiotyParametryWyszukiwaniaId]', N'IX_DaneSzukajPodmiotyParametryWyszukiwania_Id', N'INDEX';
GO

EXEC sp_rename N'[pagard].[DaneSzukajPodmioty].[IX_DaneSzukajPodmiotyWojewodztwo]', N'IX_DaneSzukajPodmioty_Wojewodztwo', N'INDEX';
GO

EXEC sp_rename N'[pagard].[DaneSzukajPodmioty].[IX_DaneSzukajPodmiotyUniqueIdentifierOfTheLoggedInUser]', N'IX_DaneSzukajPodmioty_UniqueIdentifierOfTheLoggedInUser', N'INDEX';
GO

EXEC sp_rename N'[pagard].[DaneSzukajPodmioty].[IX_DaneSzukajPodmiotyUlica]', N'IX_DaneSzukajPodmioty_Ulica', N'INDEX';
GO

EXEC sp_rename N'[pagard].[DaneSzukajPodmioty].[IX_DaneSzukajPodmiotyTyp]', N'IX_DaneSzukajPodmioty_Typ', N'INDEX';
GO

EXEC sp_rename N'[pagard].[DaneSzukajPodmioty].[IX_DaneSzukajPodmiotySilosMiejscowoscPoczty]', N'IX_DaneSzukajPodmioty_MiejscowoscPoczty', N'INDEX';
GO

EXEC sp_rename N'[pagard].[DaneSzukajPodmioty].[IX_DaneSzukajPodmiotySilosID]', N'IX_DaneSzukajPodmioty_SilosID', N'INDEX';
GO

EXEC sp_rename N'[pagard].[DaneSzukajPodmioty].[IX_DaneSzukajPodmiotyRegon]', N'IX_DaneSzukajPodmioty_Regon', N'INDEX';
GO

EXEC sp_rename N'[pagard].[DaneSzukajPodmioty].[IX_DaneSzukajPodmiotyPowiat]', N'IX_DaneSzukajPodmioty_Powiat', N'INDEX';
GO

EXEC sp_rename N'[pagard].[DaneSzukajPodmioty].[IX_DaneSzukajPodmiotyNip]', N'IX_DaneSzukajPodmioty_Nip', N'INDEX';
GO

EXEC sp_rename N'[pagard].[DaneSzukajPodmioty].[IX_DaneSzukajPodmiotyNazwa]', N'IX_DaneSzukajPodmioty_Nazwa', N'INDEX';
GO

EXEC sp_rename N'[pagard].[DaneSzukajPodmioty].[IX_DaneSzukajPodmiotyMiejscowosc]', N'IX_DaneSzukajPodmioty_Miejscowosc', N'INDEX';
GO

EXEC sp_rename N'[pagard].[DaneSzukajPodmioty].[IX_DaneSzukajPodmiotyKodPocztowy]', N'IX_DaneSzukajPodmioty_KodPocztowy', N'INDEX';
GO

EXEC sp_rename N'[pagard].[DaneSzukajPodmioty].[IX_DaneSzukajPodmiotyId]', N'IX_DaneSzukajPodmioty_Id', N'INDEX';
GO

EXEC sp_rename N'[pagard].[DaneSzukajPodmioty].[IX_DaneSzukajPodmiotyGmina]', N'IX_DaneSzukajPodmioty_Gmina', N'INDEX';
GO

DROP INDEX [IX_DaneSzukajPodmiotyParametryWyszukiwania_UniqueIdentifierOfTheLoggedInUser] ON [pagard].[DaneSzukajPodmiotyParametryWyszukiwania];
DECLARE @var27 sysname;
SELECT @var27 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[pagard].[DaneSzukajPodmiotyParametryWyszukiwania]') AND [c].[name] = N'UniqueIdentifierOfTheLoggedInUser');
IF @var27 IS NOT NULL EXEC(N'ALTER TABLE [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] DROP CONSTRAINT [' + @var27 + '];');
ALTER TABLE [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] ALTER COLUMN [UniqueIdentifierOfTheLoggedInUser] nvarchar(256) NULL;
CREATE INDEX [IX_DaneSzukajPodmiotyParametryWyszukiwania_UniqueIdentifierOfTheLoggedInUser] ON [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] ([UniqueIdentifierOfTheLoggedInUser]);
GO

DECLARE @var28 sysname;
SELECT @var28 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[pagard].[DaneSzukajPodmiotyParametryWyszukiwania]') AND [c].[name] = N'DataUtworzenia');
IF @var28 IS NOT NULL EXEC(N'ALTER TABLE [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] DROP CONSTRAINT [' + @var28 + '];');
ALTER TABLE [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] ALTER COLUMN [DataUtworzenia] datetime2 NOT NULL;
ALTER TABLE [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] ADD DEFAULT ((getdate())) FOR [DataUtworzenia];
GO

DECLARE @var29 sysname;
SELECT @var29 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[pagard].[DaneSzukajPodmiotyParametryWyszukiwania]') AND [c].[name] = N'DataModyfikacji');
IF @var29 IS NOT NULL EXEC(N'ALTER TABLE [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] DROP CONSTRAINT [' + @var29 + '];');
ALTER TABLE [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] ALTER COLUMN [DataModyfikacji] datetime2 NULL;
GO

DROP INDEX [IX_DaneSzukajPodmioty_Wojewodztwo] ON [pagard].[DaneSzukajPodmioty];
DECLARE @var30 sysname;
SELECT @var30 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[pagard].[DaneSzukajPodmioty]') AND [c].[name] = N'Wojewodztwo');
IF @var30 IS NOT NULL EXEC(N'ALTER TABLE [pagard].[DaneSzukajPodmioty] DROP CONSTRAINT [' + @var30 + '];');
ALTER TABLE [pagard].[DaneSzukajPodmioty] ALTER COLUMN [Wojewodztwo] nvarchar(200) NOT NULL;
ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD DEFAULT N'' FOR [Wojewodztwo];
CREATE INDEX [IX_DaneSzukajPodmioty_Wojewodztwo] ON [pagard].[DaneSzukajPodmioty] ([Wojewodztwo]);
GO

DROP INDEX [IX_DaneSzukajPodmioty_UniqueIdentifierOfTheLoggedInUser] ON [pagard].[DaneSzukajPodmioty];
DECLARE @var31 sysname;
SELECT @var31 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[pagard].[DaneSzukajPodmioty]') AND [c].[name] = N'UniqueIdentifierOfTheLoggedInUser');
IF @var31 IS NOT NULL EXEC(N'ALTER TABLE [pagard].[DaneSzukajPodmioty] DROP CONSTRAINT [' + @var31 + '];');
ALTER TABLE [pagard].[DaneSzukajPodmioty] ALTER COLUMN [UniqueIdentifierOfTheLoggedInUser] nvarchar(256) NULL;
CREATE INDEX [IX_DaneSzukajPodmioty_UniqueIdentifierOfTheLoggedInUser] ON [pagard].[DaneSzukajPodmioty] ([UniqueIdentifierOfTheLoggedInUser]);
GO

DROP INDEX [IX_DaneSzukajPodmioty_Ulica] ON [pagard].[DaneSzukajPodmioty];
DECLARE @var32 sysname;
SELECT @var32 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[pagard].[DaneSzukajPodmioty]') AND [c].[name] = N'Ulica');
IF @var32 IS NOT NULL EXEC(N'ALTER TABLE [pagard].[DaneSzukajPodmioty] DROP CONSTRAINT [' + @var32 + '];');
ALTER TABLE [pagard].[DaneSzukajPodmioty] ALTER COLUMN [Ulica] nvarchar(200) NOT NULL;
ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD DEFAULT N'' FOR [Ulica];
CREATE INDEX [IX_DaneSzukajPodmioty_Ulica] ON [pagard].[DaneSzukajPodmioty] ([Ulica]);
GO

DROP INDEX [IX_DaneSzukajPodmioty_Typ] ON [pagard].[DaneSzukajPodmioty];
DECLARE @var33 sysname;
SELECT @var33 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[pagard].[DaneSzukajPodmioty]') AND [c].[name] = N'Typ');
IF @var33 IS NOT NULL EXEC(N'ALTER TABLE [pagard].[DaneSzukajPodmioty] DROP CONSTRAINT [' + @var33 + '];');
ALTER TABLE [pagard].[DaneSzukajPodmioty] ALTER COLUMN [Typ] nvarchar(2) NOT NULL;
ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD DEFAULT N'' FOR [Typ];
CREATE INDEX [IX_DaneSzukajPodmioty_Typ] ON [pagard].[DaneSzukajPodmioty] ([Typ]);
GO

DECLARE @var34 sysname;
SELECT @var34 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[pagard].[DaneSzukajPodmioty]') AND [c].[name] = N'StatusNip');
IF @var34 IS NOT NULL EXEC(N'ALTER TABLE [pagard].[DaneSzukajPodmioty] DROP CONSTRAINT [' + @var34 + '];');
ALTER TABLE [pagard].[DaneSzukajPodmioty] ALTER COLUMN [StatusNip] nvarchar(max) NOT NULL;
ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD DEFAULT N'' FOR [StatusNip];
GO

DROP INDEX [IX_DaneSzukajPodmioty_Regon] ON [pagard].[DaneSzukajPodmioty];
DECLARE @var35 sysname;
SELECT @var35 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[pagard].[DaneSzukajPodmioty]') AND [c].[name] = N'Regon');
IF @var35 IS NOT NULL EXEC(N'ALTER TABLE [pagard].[DaneSzukajPodmioty] DROP CONSTRAINT [' + @var35 + '];');
ALTER TABLE [pagard].[DaneSzukajPodmioty] ALTER COLUMN [Regon] nvarchar(14) NOT NULL;
ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD DEFAULT N'' FOR [Regon];
CREATE INDEX [IX_DaneSzukajPodmioty_Regon] ON [pagard].[DaneSzukajPodmioty] ([Regon]);
GO

DROP INDEX [IX_DaneSzukajPodmioty_Powiat] ON [pagard].[DaneSzukajPodmioty];
DECLARE @var36 sysname;
SELECT @var36 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[pagard].[DaneSzukajPodmioty]') AND [c].[name] = N'Powiat');
IF @var36 IS NOT NULL EXEC(N'ALTER TABLE [pagard].[DaneSzukajPodmioty] DROP CONSTRAINT [' + @var36 + '];');
ALTER TABLE [pagard].[DaneSzukajPodmioty] ALTER COLUMN [Powiat] nvarchar(200) NOT NULL;
ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD DEFAULT N'' FOR [Powiat];
CREATE INDEX [IX_DaneSzukajPodmioty_Powiat] ON [pagard].[DaneSzukajPodmioty] ([Powiat]);
GO

DECLARE @var37 sysname;
SELECT @var37 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[pagard].[DaneSzukajPodmioty]') AND [c].[name] = N'NrNieruchomosci');
IF @var37 IS NOT NULL EXEC(N'ALTER TABLE [pagard].[DaneSzukajPodmioty] DROP CONSTRAINT [' + @var37 + '];');
ALTER TABLE [pagard].[DaneSzukajPodmioty] ALTER COLUMN [NrNieruchomosci] nvarchar(20) NOT NULL;
ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD DEFAULT N'' FOR [NrNieruchomosci];
GO

DECLARE @var38 sysname;
SELECT @var38 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[pagard].[DaneSzukajPodmioty]') AND [c].[name] = N'NrLokalu');
IF @var38 IS NOT NULL EXEC(N'ALTER TABLE [pagard].[DaneSzukajPodmioty] DROP CONSTRAINT [' + @var38 + '];');
ALTER TABLE [pagard].[DaneSzukajPodmioty] ALTER COLUMN [NrLokalu] nvarchar(10) NOT NULL;
ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD DEFAULT N'' FOR [NrLokalu];
GO

DROP INDEX [IX_DaneSzukajPodmioty_Nip] ON [pagard].[DaneSzukajPodmioty];
DECLARE @var39 sysname;
SELECT @var39 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[pagard].[DaneSzukajPodmioty]') AND [c].[name] = N'Nip');
IF @var39 IS NOT NULL EXEC(N'ALTER TABLE [pagard].[DaneSzukajPodmioty] DROP CONSTRAINT [' + @var39 + '];');
ALTER TABLE [pagard].[DaneSzukajPodmioty] ALTER COLUMN [Nip] nvarchar(10) NOT NULL;
ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD DEFAULT N'' FOR [Nip];
CREATE INDEX [IX_DaneSzukajPodmioty_Nip] ON [pagard].[DaneSzukajPodmioty] ([Nip]);
GO

DROP INDEX [IX_DaneSzukajPodmioty_Nazwa] ON [pagard].[DaneSzukajPodmioty];
DECLARE @var40 sysname;
SELECT @var40 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[pagard].[DaneSzukajPodmioty]') AND [c].[name] = N'Nazwa');
IF @var40 IS NOT NULL EXEC(N'ALTER TABLE [pagard].[DaneSzukajPodmioty] DROP CONSTRAINT [' + @var40 + '];');
ALTER TABLE [pagard].[DaneSzukajPodmioty] ALTER COLUMN [Nazwa] nvarchar(2000) NOT NULL;
ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD DEFAULT N'' FOR [Nazwa];
CREATE INDEX [IX_DaneSzukajPodmioty_Nazwa] ON [pagard].[DaneSzukajPodmioty] ([Nazwa]);
GO

DROP INDEX [IX_DaneSzukajPodmioty_MiejscowoscPoczty] ON [pagard].[DaneSzukajPodmioty];
DECLARE @var41 sysname;
SELECT @var41 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[pagard].[DaneSzukajPodmioty]') AND [c].[name] = N'MiejscowoscPoczty');
IF @var41 IS NOT NULL EXEC(N'ALTER TABLE [pagard].[DaneSzukajPodmioty] DROP CONSTRAINT [' + @var41 + '];');
ALTER TABLE [pagard].[DaneSzukajPodmioty] ALTER COLUMN [MiejscowoscPoczty] nvarchar(200) NOT NULL;
ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD DEFAULT N'' FOR [MiejscowoscPoczty];
CREATE INDEX [IX_DaneSzukajPodmioty_MiejscowoscPoczty] ON [pagard].[DaneSzukajPodmioty] ([MiejscowoscPoczty]);
GO

DROP INDEX [IX_DaneSzukajPodmioty_Miejscowosc] ON [pagard].[DaneSzukajPodmioty];
DECLARE @var42 sysname;
SELECT @var42 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[pagard].[DaneSzukajPodmioty]') AND [c].[name] = N'Miejscowosc');
IF @var42 IS NOT NULL EXEC(N'ALTER TABLE [pagard].[DaneSzukajPodmioty] DROP CONSTRAINT [' + @var42 + '];');
ALTER TABLE [pagard].[DaneSzukajPodmioty] ALTER COLUMN [Miejscowosc] nvarchar(200) NOT NULL;
ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD DEFAULT N'' FOR [Miejscowosc];
CREATE INDEX [IX_DaneSzukajPodmioty_Miejscowosc] ON [pagard].[DaneSzukajPodmioty] ([Miejscowosc]);
GO

DROP INDEX [IX_DaneSzukajPodmioty_KodPocztowy] ON [pagard].[DaneSzukajPodmioty];
DECLARE @var43 sysname;
SELECT @var43 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[pagard].[DaneSzukajPodmioty]') AND [c].[name] = N'KodPocztowy');
IF @var43 IS NOT NULL EXEC(N'ALTER TABLE [pagard].[DaneSzukajPodmioty] DROP CONSTRAINT [' + @var43 + '];');
ALTER TABLE [pagard].[DaneSzukajPodmioty] ALTER COLUMN [KodPocztowy] nvarchar(12) NOT NULL;
ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD DEFAULT N'' FOR [KodPocztowy];
CREATE INDEX [IX_DaneSzukajPodmioty_KodPocztowy] ON [pagard].[DaneSzukajPodmioty] ([KodPocztowy]);
GO

DROP INDEX [IX_DaneSzukajPodmioty_Gmina] ON [pagard].[DaneSzukajPodmioty];
DECLARE @var44 sysname;
SELECT @var44 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[pagard].[DaneSzukajPodmioty]') AND [c].[name] = N'Gmina');
IF @var44 IS NOT NULL EXEC(N'ALTER TABLE [pagard].[DaneSzukajPodmioty] DROP CONSTRAINT [' + @var44 + '];');
ALTER TABLE [pagard].[DaneSzukajPodmioty] ALTER COLUMN [Gmina] nvarchar(200) NOT NULL;
ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD DEFAULT N'' FOR [Gmina];
CREATE INDEX [IX_DaneSzukajPodmioty_Gmina] ON [pagard].[DaneSzukajPodmioty] ([Gmina]);
GO

DECLARE @var45 sysname;
SELECT @var45 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[pagard].[DaneSzukajPodmioty]') AND [c].[name] = N'DataZakonczeniaDzialalnosci');
IF @var45 IS NOT NULL EXEC(N'ALTER TABLE [pagard].[DaneSzukajPodmioty] DROP CONSTRAINT [' + @var45 + '];');
ALTER TABLE [pagard].[DaneSzukajPodmioty] ALTER COLUMN [DataZakonczeniaDzialalnosci] nvarchar(10) NOT NULL;
ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD DEFAULT N'' FOR [DataZakonczeniaDzialalnosci];
GO

DECLARE @var46 sysname;
SELECT @var46 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[pagard].[DaneSzukajPodmioty]') AND [c].[name] = N'DataUtworzenia');
IF @var46 IS NOT NULL EXEC(N'ALTER TABLE [pagard].[DaneSzukajPodmioty] DROP CONSTRAINT [' + @var46 + '];');
ALTER TABLE [pagard].[DaneSzukajPodmioty] ALTER COLUMN [DataUtworzenia] datetime2 NOT NULL;
ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD DEFAULT ((getdate())) FOR [DataUtworzenia];
GO

DECLARE @var47 sysname;
SELECT @var47 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[pagard].[DaneSzukajPodmioty]') AND [c].[name] = N'DataModyfikacji');
IF @var47 IS NOT NULL EXEC(N'ALTER TABLE [pagard].[DaneSzukajPodmioty] DROP CONSTRAINT [' + @var47 + '];');
ALTER TABLE [pagard].[DaneSzukajPodmioty] ALTER COLUMN [DataModyfikacji] datetime2 NULL;
GO

ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD [BIR11JednLokalnaOsFizycznejId] uniqueidentifier NULL;
GO

ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD [BIR11JednLokalnaOsPrawnejId] uniqueidentifier NULL;
GO

ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD [BIR11OsFizycznaDaneOgolneId] uniqueidentifier NULL;
GO

ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD [BIR11OsFizycznaDzialalnoscCeidgId] uniqueidentifier NULL;
GO

ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD [BIR11OsFizycznaDzialalnoscPozostalaId] uniqueidentifier NULL;
GO

ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD [BIR11OsFizycznaDzialalnoscRolniczaId] uniqueidentifier NULL;
GO

ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD [BIR11OsFizycznaDzialalnoscSkreslonaDo20141108Id] uniqueidentifier NULL;
GO

ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD [BIR11OsPrawnaId] uniqueidentifier NULL;
GO

ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD [BIR11TypPodmiotuId] uniqueidentifier NULL;
GO

ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD [DaneSzukajPodmiotyKomunikatyOBledachId] uniqueidentifier NULL;
GO

ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD [DaneSzukajPodmiotyParametryWyszukiwaniaId] uniqueidentifier NULL;
GO

CREATE TABLE [pagard].[DaneSzukajPodmiotyKomunikatyOBledach] (
    [Id] uniqueidentifier NOT NULL DEFAULT ((newsequentialid())),
    [UniqueIdentifierOfTheLoggedInUser] nvarchar(256) NULL,
    [DataUtworzenia] datetime2 NOT NULL DEFAULT ((getdate())),
    [DataModyfikacji] datetime2 NULL,
    [ErrorCode] int NULL,
    [ErrorMessagePl] nvarchar(max) NULL,
    [ErrorMessageEn] nvarchar(max) NULL,
    [Regon] nvarchar(14) NULL,
    [Nip] nvarchar(10) NULL,
    [Krs] nvarchar(10) NULL,
    [Nipy] nvarchar(220) NULL,
    [Regony14zn] nvarchar(300) NULL,
    [Regony9zn] nvarchar(200) NULL,
    [Krsy] nvarchar(220) NULL,
    CONSTRAINT [PK_DaneSzukajPodmiotyKomunikatyOBledach] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [pagard].[MessageInspector] (
    [Id] uniqueidentifier NOT NULL DEFAULT ((newsequentialid())),
    [DataUtworzenia] datetime2 NOT NULL DEFAULT ((getdate())),
    [DataModyfikacji] datetime2 NULL,
    [UniqueIdentifierOfTheLoggedInUser] nvarchar(256) NULL,
    [AfterReceiveReplyMessage] nvarchar(max) NULL,
    [AfterReceiveReplyMessageAsStringXml] nvarchar(max) NULL,
    [AfterReceiveReplyCorrelationState] nvarchar(max) NULL,
    [BeforeSendRequestMessage] nvarchar(max) NULL,
    [BeforeSendRequestMessageAsStringXml] nvarchar(max) NULL,
    [BeforeSendRequestClientChannel] nvarchar(max) NULL,
    CONSTRAINT [PK_MessageInspector] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [pagard].[BIR11JednLokalnaOsFizycznej] (
    [Id] uniqueidentifier NOT NULL,
    [LokfizRegon14] nvarchar(14) NOT NULL,
    [LokfizNazwa] nvarchar(2000) NOT NULL,
    [LokfizSilosID] int NOT NULL,
    [LokfizSilosNazwa] nvarchar(10) NOT NULL,
    [LokfizDataPowstania] nvarchar(10) NOT NULL,
    [LokfizDataRozpoczeciaDzialalnosci] nvarchar(10) NOT NULL,
    [LokfizDataWpisuDoRegon] nvarchar(10) NOT NULL,
    [LokfizDataZawieszeniaDzialalnosci] nvarchar(10) NOT NULL,
    [LokfizDataWznowieniaDzialalnosci] nvarchar(10) NOT NULL,
    [LokfizDataZaistnieniaZmiany] nvarchar(10) NOT NULL,
    [LokfizDataZakonczeniaDzialalnosci] nvarchar(10) NOT NULL,
    [LokfizDataSkresleniaZRegon] nvarchar(10) NOT NULL,
    [LokfizAdSiedzKrajSymbol] nvarchar(2) NOT NULL,
    [LokfizAdSiedzWojewodztwoSymbol] nvarchar(2) NOT NULL,
    [LokfizAdSiedzPowiatSymbol] nvarchar(2) NOT NULL,
    [LokfizAdSiedzGminaSymbol] nvarchar(3) NOT NULL,
    [LokfizAdSiedzKodPocztowy] nvarchar(12) NOT NULL,
    [LokfizAdSiedzMiejscowoscPocztySymbol] nvarchar(7) NOT NULL,
    [LokfizAdSiedzMiejscowoscSymbol] nvarchar(7) NOT NULL,
    [LokfizAdSiedzUlicaSymbol] nvarchar(5) NOT NULL,
    [LokfizAdSiedzNumerNieruchomosci] nvarchar(20) NOT NULL,
    [LokfizAdSiedzNumerLokalu] nvarchar(10) NOT NULL,
    [LokfizAdSiedzNietypoweMiejsceLokalizacji] nvarchar(256) NOT NULL,
    [LokfizAdSiedzKrajNazwa] nvarchar(200) NOT NULL,
    [LokfizAdSiedzWojewodztwoNazwa] nvarchar(100) NOT NULL,
    [LokfizAdSiedzPowiatNazwa] nvarchar(100) NOT NULL,
    [LokfizAdSiedzGminaNazwa] nvarchar(100) NOT NULL,
    [LokfizAdSiedzMiejscowoscNazwa] nvarchar(100) NOT NULL,
    [LokfizAdSiedzMiejscowoscPocztyNazwa] nvarchar(100) NOT NULL,
    [LokfizAdSiedzUlicaNazwa] nvarchar(350) NOT NULL,
    [LokfizFormaFinansowaniaNazwa] nvarchar(240) NOT NULL,
    [LokfizFormaFinansowaniaSymbol] nvarchar(1) NOT NULL,
    [LokfizDataWpisuDoRejestruEwidencji] nvarchar(30) NOT NULL,
    [LokfizNumerwRejestrzeEwidencji] nvarchar(50) NOT NULL,
    [LokfizOrganRejestrowySymbol] nvarchar(9) NOT NULL,
    [LokfizRodzajRejestruSymbol] nvarchar(3) NOT NULL,
    [LokfizOrganRejestrowyNazwa] nvarchar(240) NOT NULL,
    [LokfizRodzajRejestruNazwa] nvarchar(240) NOT NULL,
    [LokfizCNiePodjetoDzialalnosci] bit NOT NULL,
    [UniqueIdentifierOfTheLoggedInUser] nvarchar(256) NULL,
    [DateOfCreate] datetime2 NOT NULL,
    [DateOfModification] datetime2 NULL,
    [PRegon] nvarchar(max) NOT NULL,
    [PNazwaRaportu] nvarchar(max) NOT NULL,
    [DaneSzukajPodmiotyParametryWyszukiwaniaId] uniqueidentifier NULL,
    [DaneSzukajPodmiotyKomunikatyOBledachId] uniqueidentifier NULL,
    CONSTRAINT [PK_BIR11JednLokalnaOsFizycznej] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_BIR11JednLokalnaOsFizycznej_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId] FOREIGN KEY ([DaneSzukajPodmiotyKomunikatyOBledachId]) REFERENCES [pagard].[DaneSzukajPodmiotyKomunikatyOBledach] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_BIR11JednLokalnaOsFizycznej_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwaniaId] FOREIGN KEY ([DaneSzukajPodmiotyParametryWyszukiwaniaId]) REFERENCES [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [pagard].[BIR11JednLokalnaOsFizycznejPkd] (
    [Id] uniqueidentifier NOT NULL,
    [DaneSzukajPodmiotyId] uniqueidentifier NULL,
    [LokfizPkdKod] nvarchar(5) NOT NULL,
    [LokfizPkdNazwa] nvarchar(200) NOT NULL,
    [LokfizPkdPrzewazajace] nvarchar(1) NOT NULL,
    [LokfizSilosSymbol] nvarchar(10) NOT NULL,
    [UniqueIdentifierOfTheLoggedInUser] nvarchar(256) NULL,
    [DateOfCreate] datetime2 NOT NULL,
    [DateOfModification] datetime2 NULL,
    [PRegon] nvarchar(max) NOT NULL,
    [PNazwaRaportu] nvarchar(max) NOT NULL,
    [DaneSzukajPodmiotyParametryWyszukiwaniaId] uniqueidentifier NULL,
    [DaneSzukajPodmiotyKomunikatyOBledachId] uniqueidentifier NULL,
    CONSTRAINT [PK_BIR11JednLokalnaOsFizycznejPkd] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_BIR11JednLokalnaOsFizycznejPkd_DaneSzukajPodmioty_DaneSzukajPodmiotyId] FOREIGN KEY ([DaneSzukajPodmiotyId]) REFERENCES [pagard].[DaneSzukajPodmioty] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_BIR11JednLokalnaOsFizycznejPkd_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId] FOREIGN KEY ([DaneSzukajPodmiotyKomunikatyOBledachId]) REFERENCES [pagard].[DaneSzukajPodmiotyKomunikatyOBledach] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_BIR11JednLokalnaOsFizycznejPkd_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwaniaId] FOREIGN KEY ([DaneSzukajPodmiotyParametryWyszukiwaniaId]) REFERENCES [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [pagard].[BIR11JednLokalnaOsPrawnej] (
    [Id] uniqueidentifier NOT NULL,
    [LokprawRegon14] nvarchar(14) NOT NULL,
    [LokprawNazwa] nvarchar(254) NOT NULL,
    [LokprawNumerWrejestrzeEwidencji] nvarchar(50) NOT NULL,
    [LokprawDataWpisuDoRejestruEwidencji] nvarchar(10) NOT NULL,
    [LokprawDataPowstania] nvarchar(10) NOT NULL,
    [LokprawDataRozpoczeciaDzialalnosci] nvarchar(10) NOT NULL,
    [LokprawDataWpisuDoRegon] nvarchar(10) NOT NULL,
    [LokprawDataZawieszeniaDzialalnosci] nvarchar(10) NOT NULL,
    [LokprawDataWznowieniaDzialalnosci] nvarchar(10) NOT NULL,
    [LokprawDataZaistnieniaZmiany] nvarchar(10) NOT NULL,
    [LokprawDataZakonczeniaDzialalnosci] nvarchar(10) NOT NULL,
    [LokprawDataSkresleniaZRegon] nvarchar(10) NOT NULL,
    [LokprawAdSiedzKrajSymbol] nvarchar(2) NOT NULL,
    [LokprawAdSiedzWojewodztwoSymbol] nvarchar(2) NOT NULL,
    [LokprawAdSiedzPowiatSymbol] nvarchar(2) NOT NULL,
    [LokprawAdSiedzGminaSymbol] nvarchar(3) NOT NULL,
    [LokprawAdSiedzKodPocztowy] nvarchar(12) NOT NULL,
    [LokprawAdSiedzMiejscowoscPocztySymbol] nvarchar(7) NOT NULL,
    [LokprawAdSiedzMiejscowoscSymbol] nvarchar(7) NOT NULL,
    [LokprawAdSiedzUlicaSymbol] nvarchar(5) NOT NULL,
    [LokprawAdSiedzNumerNieruchomosci] nvarchar(20) NOT NULL,
    [LokprawAdSiedzNumerLokalu] nvarchar(10) NOT NULL,
    [LokprawAdSiedzNietypoweMiejsceLokalizacji] nvarchar(160) NOT NULL,
    [LokprawAdSiedzKrajNazwa] nvarchar(200) NOT NULL,
    [LokprawAdSiedzWojewodztwoNazwa] nvarchar(100) NOT NULL,
    [LokprawAdSiedzPowiatNazwa] nvarchar(100) NOT NULL,
    [LokprawAdSiedzGminaNazwa] nvarchar(100) NOT NULL,
    [LokprawAdSiedzMiejscowoscNazwa] nvarchar(100) NOT NULL,
    [LokprawAdSiedzMiejscowoscPocztyNazwa] nvarchar(100) NOT NULL,
    [LokprawAdSiedzUlicaNazwa] nvarchar(351) NOT NULL,
    [LokprawFormaFinansowaniaSymbol] nvarchar(1) NOT NULL,
    [LokprawOrganRejestrowySymbol] nvarchar(9) NOT NULL,
    [LokprawRodzajRejestruEwidencjiSymbol] nvarchar(3) NOT NULL,
    [LokprawFormaFinansowaniaNazwa] nvarchar(240) NOT NULL,
    [LokprawOrganRejestrowyNazwa] nvarchar(240) NOT NULL,
    [LokprawRodzajRejestruEwidencjiNazwa] nvarchar(240) NOT NULL,
    [UniqueIdentifierOfTheLoggedInUser] nvarchar(256) NULL,
    [DateOfCreate] datetime2 NOT NULL,
    [DateOfModification] datetime2 NULL,
    [PRegon] nvarchar(max) NOT NULL,
    [PNazwaRaportu] nvarchar(max) NOT NULL,
    [DaneSzukajPodmiotyParametryWyszukiwaniaId] uniqueidentifier NULL,
    [DaneSzukajPodmiotyKomunikatyOBledachId] uniqueidentifier NULL,
    CONSTRAINT [PK_BIR11JednLokalnaOsPrawnej] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_BIR11JednLokalnaOsPrawnej_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId] FOREIGN KEY ([DaneSzukajPodmiotyKomunikatyOBledachId]) REFERENCES [pagard].[DaneSzukajPodmiotyKomunikatyOBledach] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_BIR11JednLokalnaOsPrawnej_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwaniaId] FOREIGN KEY ([DaneSzukajPodmiotyParametryWyszukiwaniaId]) REFERENCES [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [pagard].[BIR11JednLokalnaOsPrawnejPkd] (
    [Id] uniqueidentifier NOT NULL,
    [DaneSzukajPodmiotyId] uniqueidentifier NULL,
    [LokprawPkdKod] nvarchar(5) NOT NULL,
    [LokprawPkdNazwa] nvarchar(200) NOT NULL,
    [LokprawPkdPrzewazajace] nvarchar(1) NOT NULL,
    [UniqueIdentifierOfTheLoggedInUser] nvarchar(256) NULL,
    [DateOfCreate] datetime2 NOT NULL,
    [DateOfModification] datetime2 NULL,
    [PRegon] nvarchar(max) NOT NULL,
    [PNazwaRaportu] nvarchar(max) NOT NULL,
    [DaneSzukajPodmiotyParametryWyszukiwaniaId] uniqueidentifier NULL,
    [DaneSzukajPodmiotyKomunikatyOBledachId] uniqueidentifier NULL,
    CONSTRAINT [PK_BIR11JednLokalnaOsPrawnejPkd] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_BIR11JednLokalnaOsPrawnejPkd_DaneSzukajPodmioty_DaneSzukajPodmiotyId] FOREIGN KEY ([DaneSzukajPodmiotyId]) REFERENCES [pagard].[DaneSzukajPodmioty] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_BIR11JednLokalnaOsPrawnejPkd_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId] FOREIGN KEY ([DaneSzukajPodmiotyKomunikatyOBledachId]) REFERENCES [pagard].[DaneSzukajPodmiotyKomunikatyOBledach] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_BIR11JednLokalnaOsPrawnejPkd_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwaniaId] FOREIGN KEY ([DaneSzukajPodmiotyParametryWyszukiwaniaId]) REFERENCES [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [pagard].[BIR11OsFizycznaDaneOgolne] (
    [Id] uniqueidentifier NOT NULL,
    [FizRegon9] nvarchar(9) NOT NULL,
    [FizNip] nvarchar(10) NOT NULL,
    [FizStatusNip] nvarchar(max) NOT NULL,
    [FizNazwisko] nvarchar(100) NOT NULL,
    [FizImie1] nvarchar(50) NOT NULL,
    [FizImie2] nvarchar(50) NOT NULL,
    [FizDataWpisuPodmiotuDoRegon] nvarchar(10) NOT NULL,
    [FizDataZaistnieniaZmiany] nvarchar(10) NOT NULL,
    [FizDataSkresleniaPodmiotuZRegon] nvarchar(10) NOT NULL,
    [FizPodstawowaFormaPrawnaSymbol] nvarchar(3) NOT NULL,
    [FizSzczegolnaFormaPrawnaSymbol] nvarchar(3) NOT NULL,
    [FizFormaFinansowaniaSymbol] nvarchar(1) NOT NULL,
    [FizFormaWlasnosciSymbol] nvarchar(50) NOT NULL,
    [FizPodstawowaFormaPrawnaNazwa] nvarchar(200) NOT NULL,
    [FizSzczegolnaFormaPrawnaNazwa] nvarchar(200) NOT NULL,
    [FizFormaFinansowaniaNazwa] nvarchar(240) NOT NULL,
    [FizFormaWlasnosciNazwa] nvarchar(240) NOT NULL,
    [FizDzialalnoscCeidg] int NOT NULL,
    [FizDzialalnoscRolnicza] int NOT NULL,
    [FizDzialalnoscPozostala] int NOT NULL,
    [FizDzialalnoscSkreslonaDo20141108] int NOT NULL,
    [FizLiczbaJednLokalnych] int NOT NULL,
    [UniqueIdentifierOfTheLoggedInUser] nvarchar(256) NULL,
    [DateOfCreate] datetime2 NOT NULL,
    [DateOfModification] datetime2 NULL,
    [PRegon] nvarchar(max) NOT NULL,
    [PNazwaRaportu] nvarchar(max) NOT NULL,
    [DaneSzukajPodmiotyParametryWyszukiwaniaId] uniqueidentifier NULL,
    [DaneSzukajPodmiotyKomunikatyOBledachId] uniqueidentifier NULL,
    CONSTRAINT [PK_BIR11OsFizycznaDaneOgolne] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_BIR11OsFizycznaDaneOgolne_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId] FOREIGN KEY ([DaneSzukajPodmiotyKomunikatyOBledachId]) REFERENCES [pagard].[DaneSzukajPodmiotyKomunikatyOBledach] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_BIR11OsFizycznaDaneOgolne_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwaniaId] FOREIGN KEY ([DaneSzukajPodmiotyParametryWyszukiwaniaId]) REFERENCES [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [pagard].[BIR11OsFizycznaDzialalnoscCeidg] (
    [Id] uniqueidentifier NOT NULL,
    [FizRegon9] nvarchar(9) NOT NULL,
    [FizNazwa] nvarchar(2000) NOT NULL,
    [FizNazwaSkrocona] nvarchar(256) NOT NULL,
    [FizDataPowstania] nvarchar(10) NOT NULL,
    [FizDataRozpoczeciaDzialalnosci] nvarchar(10) NOT NULL,
    [FizDataWpisuDzialalnosciDoRegon] nvarchar(10) NOT NULL,
    [FizDataZawieszeniaDzialalnosci] nvarchar(10) NOT NULL,
    [FizDataWznowieniaDzialalnosci] nvarchar(10) NOT NULL,
    [FizDataZaistnieniaZmianyDzialalnosci] nvarchar(10) NOT NULL,
    [FizDataZakonczeniaDzialalnosci] nvarchar(10) NOT NULL,
    [FizDataSkresleniaDzialalnosciZRegon] nvarchar(10) NOT NULL,
    [FizDataOrzeczeniaOUpadlosci] nvarchar(10) NOT NULL,
    [FizDataZakonczeniaPostepowaniaUpadlosciowego] nvarchar(10) NOT NULL,
    [FizAdSiedzKrajSymbol] nvarchar(2) NOT NULL,
    [FizAdSiedzWojewodztwoSymbol] nvarchar(2) NOT NULL,
    [FizAdSiedzPowiatSymbol] nvarchar(2) NOT NULL,
    [FizAdSiedzGminaSymbol] nvarchar(3) NOT NULL,
    [FizAdSiedzKodPocztowy] nvarchar(12) NOT NULL,
    [FizAdSiedzMiejscowoscPocztySymbol] nvarchar(7) NOT NULL,
    [FizAdSiedzMiejscowoscSymbol] nvarchar(7) NOT NULL,
    [FizAdSiedzUlicaSymbol] nvarchar(5) NOT NULL,
    [FizAdSiedzNumerNieruchomosci] nvarchar(20) NOT NULL,
    [FizAdSiedzNumerLokalu] nvarchar(10) NOT NULL,
    [FizAdSiedzNietypoweMiejsceLokalizacji] nvarchar(160) NOT NULL,
    [FizNumerTelefonu] nvarchar(1) NOT NULL,
    [FizNumerWewnetrznyTelefonu] nvarchar(1) NOT NULL,
    [FizNumerFaksu] nvarchar(1) NOT NULL,
    [FizAdresEmail] nvarchar(100) NOT NULL,
    [FizAdresStronyinternetowej] nvarchar(100) NOT NULL,
    [FizAdSiedzKrajNazwa] nvarchar(200) NOT NULL,
    [FizAdSiedzWojewodztwoNazwa] nvarchar(100) NOT NULL,
    [FizAdSiedzPowiatNazwa] nvarchar(100) NOT NULL,
    [FizAdSiedzGminaNazwa] nvarchar(100) NOT NULL,
    [FizAdSiedzMiejscowoscNazwa] nvarchar(100) NOT NULL,
    [FizAdSiedzMiejscowoscPocztyNazwa] nvarchar(100) NOT NULL,
    [FizAdSiedzUlicaNazwa] nvarchar(351) NOT NULL,
    [FizCDataWpisuDoRejestruEwidencji] nvarchar(10) NOT NULL,
    [FizCDataSkresleniaZRejestruEwidencji] nvarchar(10) NOT NULL,
    [FizCNumerWRejestrzeEwidencji] nvarchar(50) NOT NULL,
    [FizCOrganRejestrowySymbol] nvarchar(9) NOT NULL,
    [FizCOrganRejestrowyNazwa] nvarchar(240) NOT NULL,
    [FizCRodzajRejestruSymbol] nvarchar(3) NOT NULL,
    [FizCRodzajRejestruNazwa] nvarchar(240) NOT NULL,
    [FizCNiePodjetoDzialalnosci] bit NOT NULL,
    [UniqueIdentifierOfTheLoggedInUser] nvarchar(256) NULL,
    [DateOfCreate] datetime2 NOT NULL,
    [DateOfModification] datetime2 NULL,
    [PRegon] nvarchar(max) NOT NULL,
    [PNazwaRaportu] nvarchar(max) NOT NULL,
    [DaneSzukajPodmiotyParametryWyszukiwaniaId] uniqueidentifier NULL,
    [DaneSzukajPodmiotyKomunikatyOBledachId] uniqueidentifier NULL,
    CONSTRAINT [PK_BIR11OsFizycznaDzialalnoscCeidg] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_BIR11OsFizycznaDzialalnoscCeidg_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId] FOREIGN KEY ([DaneSzukajPodmiotyKomunikatyOBledachId]) REFERENCES [pagard].[DaneSzukajPodmiotyKomunikatyOBledach] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_BIR11OsFizycznaDzialalnoscCeidg_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwaniaId] FOREIGN KEY ([DaneSzukajPodmiotyParametryWyszukiwaniaId]) REFERENCES [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [pagard].[BIR11OsFizycznaDzialalnoscPozostala] (
    [Id] uniqueidentifier NOT NULL,
    [FizRegon9] nvarchar(9) NOT NULL,
    [FizNazwa] nvarchar(2000) NOT NULL,
    [FizNazwaSkrocona] nvarchar(256) NOT NULL,
    [FizDataPowstania] nvarchar(10) NOT NULL,
    [FizDataRozpoczeciaDzialalnosci] nvarchar(10) NOT NULL,
    [FizDataWpisuDzialalnosciDoRegon] nvarchar(10) NOT NULL,
    [FizDataZawieszeniaDzialalnosci] nvarchar(10) NOT NULL,
    [FizDataWznowieniaDzialalnosci] nvarchar(10) NOT NULL,
    [FizDataZaistnieniaZmianyDzialalnosci] nvarchar(10) NOT NULL,
    [FizDataZakonczeniaDzialalnosci] nvarchar(10) NOT NULL,
    [FizDataSkresleniaDzialalnosciZRegon] nvarchar(10) NOT NULL,
    [FizDataOrzeczeniaOUpadlosci] nvarchar(10) NOT NULL,
    [FizDataZakonczeniaPostepowaniaUpadlosciowego] nvarchar(10) NOT NULL,
    [FizAdSiedzKrajSymbol] nvarchar(2) NOT NULL,
    [FizAdSiedzWojewodztwoSymbol] nvarchar(2) NOT NULL,
    [FizAdSiedzPowiatSymbol] nvarchar(2) NOT NULL,
    [FizAdSiedzGminaSymbol] nvarchar(3) NOT NULL,
    [FizAdSiedzKodPocztowy] nvarchar(12) NOT NULL,
    [FizAdSiedzMiejscowoscPocztySymbol] nvarchar(7) NOT NULL,
    [FizAdSiedzMiejscowoscSymbol] nvarchar(7) NOT NULL,
    [FizAdSiedzUlicaSymbol] nvarchar(5) NOT NULL,
    [FizAdSiedzNumerNieruchomosci] nvarchar(20) NOT NULL,
    [FizAdSiedzNumerLokalu] nvarchar(10) NOT NULL,
    [FizAdSiedzNietypoweMiejsceLokalizacji] nvarchar(160) NOT NULL,
    [FizNumerTelefonu] nvarchar(18) NOT NULL,
    [FizNumerWewnetrznyTelefonu] nvarchar(6) NOT NULL,
    [FizNumerFaksu] nvarchar(18) NOT NULL,
    [FizAdresEmail] nvarchar(100) NOT NULL,
    [FizAdresStronyinternetowej] nvarchar(100) NOT NULL,
    [FizAdSiedzKrajNazwa] nvarchar(200) NOT NULL,
    [FizAdSiedzWojewodztwoNazwa] nvarchar(100) NOT NULL,
    [FizAdSiedzPowiatNazwa] nvarchar(100) NOT NULL,
    [FizAdSiedzGminaNazwa] nvarchar(100) NOT NULL,
    [FizAdSiedzMiejscowoscNazwa] nvarchar(100) NOT NULL,
    [FizAdSiedzMiejscowoscPocztyNazwa] nvarchar(100) NOT NULL,
    [FizAdSiedzUlicaNazwa] nvarchar(351) NOT NULL,
    [FizPDataWpisuDoRejestruEwidencji] nvarchar(10) NOT NULL,
    [FizPNumerWRejestrzeEwidencji] nvarchar(50) NOT NULL,
    [FizPOrganRejestrowySymbol] nvarchar(9) NOT NULL,
    [FizPOrganRejestrowyNazwa] nvarchar(240) NOT NULL,
    [FizPRodzajRejestruSymbol] nvarchar(3) NOT NULL,
    [FizPRodzajRejestruNazwa] nvarchar(240) NOT NULL,
    [UniqueIdentifierOfTheLoggedInUser] nvarchar(256) NULL,
    [DateOfCreate] datetime2 NOT NULL,
    [DateOfModification] datetime2 NULL,
    [PRegon] nvarchar(max) NOT NULL,
    [PNazwaRaportu] nvarchar(max) NOT NULL,
    [DaneSzukajPodmiotyParametryWyszukiwaniaId] uniqueidentifier NULL,
    [DaneSzukajPodmiotyKomunikatyOBledachId] uniqueidentifier NULL,
    CONSTRAINT [PK_BIR11OsFizycznaDzialalnoscPozostala] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_BIR11OsFizycznaDzialalnoscPozostala_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId] FOREIGN KEY ([DaneSzukajPodmiotyKomunikatyOBledachId]) REFERENCES [pagard].[DaneSzukajPodmiotyKomunikatyOBledach] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_BIR11OsFizycznaDzialalnoscPozostala_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwaniaId] FOREIGN KEY ([DaneSzukajPodmiotyParametryWyszukiwaniaId]) REFERENCES [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] (
    [Id] uniqueidentifier NOT NULL,
    [FizRegon9] nvarchar(9) NOT NULL,
    [FizNazwa] nvarchar(2000) NOT NULL,
    [FizNazwaSkrocona] nvarchar(256) NOT NULL,
    [FizDataPowstania] nvarchar(10) NOT NULL,
    [FizDataRozpoczeciaDzialalnosci] nvarchar(10) NOT NULL,
    [FizDataWpisuDzialalnosciDoRegon] nvarchar(10) NOT NULL,
    [FizDataZawieszeniaDzialalnosci] nvarchar(10) NOT NULL,
    [FizDataWznowieniaDzialalnosci] nvarchar(10) NOT NULL,
    [FizDataZaistnieniaZmianyDzialalnosci] nvarchar(10) NOT NULL,
    [FizDataZakonczeniaDzialalnosci] nvarchar(10) NOT NULL,
    [FizDataSkresleniaDzialalanosciZRegon] nvarchar(10) NOT NULL,
    [FizDataOrzeczeniaOUpadlosci] nvarchar(10) NOT NULL,
    [FizDataZakonczeniaPostepowaniaUpadlosciowego] nvarchar(10) NOT NULL,
    [FizAdSiedzKrajSymbol] nvarchar(2) NOT NULL,
    [FizAdSiedzWojewodztwoSymbol] nvarchar(2) NOT NULL,
    [FizAdSiedzPowiatSymbol] nvarchar(2) NOT NULL,
    [FizAdSiedzGminaSymbol] nvarchar(3) NOT NULL,
    [FizAdSiedzKodPocztowy] nvarchar(12) NOT NULL,
    [FizAdSiedzMiejscowoscPocztySymbol] nvarchar(7) NOT NULL,
    [FizAdSiedzMiejscowoscSymbol] nvarchar(7) NOT NULL,
    [FizAdSiedzUlicaSymbol] nvarchar(5) NOT NULL,
    [FizAdSiedzNumerNieruchomosci] nvarchar(20) NOT NULL,
    [FizAdSiedzNumerLokalu] nvarchar(10) NOT NULL,
    [FizAdSiedzNietypoweMiejsceLokalizacji] nvarchar(160) NOT NULL,
    [FizNumerTelefonu] nvarchar(18) NOT NULL,
    [FizNumerWewnetrznyTelefonu] nvarchar(6) NOT NULL,
    [FizNumerFaksu] nvarchar(18) NOT NULL,
    [FizAdresEmail] nvarchar(100) NOT NULL,
    [FizAdresStronyinternetowej] nvarchar(100) NOT NULL,
    [FizAdSiedzKrajNazwa] nvarchar(200) NOT NULL,
    [FizAdSiedzWojewodztwoNazwa] nvarchar(100) NOT NULL,
    [FizAdSiedzPowiatNazwa] nvarchar(100) NOT NULL,
    [FizAdSiedzGminaNazwa] nvarchar(100) NOT NULL,
    [FizAdSiedzMiejscowoscNazwa] nvarchar(100) NOT NULL,
    [FizAdSiedzMiejscowoscPocztyNazwa] nvarchar(100) NOT NULL,
    [FizAdSiedzUlicaNazwa] nvarchar(351) NOT NULL,
    [UniqueIdentifierOfTheLoggedInUser] nvarchar(256) NULL,
    [DateOfCreate] datetime2 NOT NULL,
    [DateOfModification] datetime2 NULL,
    [PRegon] nvarchar(max) NOT NULL,
    [PNazwaRaportu] nvarchar(max) NOT NULL,
    [DaneSzukajPodmiotyParametryWyszukiwaniaId] uniqueidentifier NULL,
    [DaneSzukajPodmiotyKomunikatyOBledachId] uniqueidentifier NULL,
    CONSTRAINT [PK_BIR11OsFizycznaDzialalnoscRolnicza] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_BIR11OsFizycznaDzialalnoscRolnicza_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId] FOREIGN KEY ([DaneSzukajPodmiotyKomunikatyOBledachId]) REFERENCES [pagard].[DaneSzukajPodmiotyKomunikatyOBledach] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_BIR11OsFizycznaDzialalnoscRolnicza_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwaniaId] FOREIGN KEY ([DaneSzukajPodmiotyParametryWyszukiwaniaId]) REFERENCES [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] (
    [Id] uniqueidentifier NOT NULL,
    [FizRegon9] nvarchar(9) NOT NULL,
    [FizNazwa] nvarchar(2000) NOT NULL,
    [FizNazwaSkrocona] nvarchar(1) NOT NULL,
    [FizDataPowstania] nvarchar(1) NOT NULL,
    [FizDataRozpoczeciaDzialalnosci] nvarchar(1) NOT NULL,
    [FizDataWpisuDzialalnosciDoRegon] nvarchar(1) NOT NULL,
    [FizDataZawieszeniaDzialalnosci] nvarchar(1) NOT NULL,
    [FizDataWznowieniaDzialalnosci] nvarchar(1) NOT NULL,
    [FizDataZaistnieniaZmianyDzialalnosci] nvarchar(1) NOT NULL,
    [FizDataZakonczeniaDzialalnosci] nvarchar(10) NOT NULL,
    [FizDataSkresleniaDzialalnosciZRegon] nvarchar(1) NOT NULL,
    [FizAdSiedzKrajSymbol] nvarchar(2) NOT NULL,
    [FizAdSiedzWojewodztwoSymbol] nvarchar(2) NOT NULL,
    [FizAdSiedzPowiatSymbol] nvarchar(2) NOT NULL,
    [FizAdSiedzGminaSymbol] nvarchar(3) NOT NULL,
    [FizAdSiedzKodPocztowy] nvarchar(12) NOT NULL,
    [FizAdSiedzMiejscowoscPocztySymbol] nvarchar(7) NOT NULL,
    [FizAdSiedzMiejscowoscSymbol] nvarchar(7) NOT NULL,
    [FizAdSiedzUlicaSymbol] nvarchar(5) NOT NULL,
    [FizAdSiedzNumerNieruchomosci] nvarchar(20) NOT NULL,
    [FizAdSiedzNumerLokalu] nvarchar(10) NOT NULL,
    [FizAdSiedzNietypoweMiejsceLokalizacji] nvarchar(160) NOT NULL,
    [FizNumerTelefonu] nvarchar(1) NOT NULL,
    [FizNumerWewnetrznyTelefonu] nvarchar(1) NOT NULL,
    [FizNumerFaksu] nvarchar(1) NOT NULL,
    [FizAdresEmail] nvarchar(1) NOT NULL,
    [FizAdresStronyinternetowej] nvarchar(1) NOT NULL,
    [FizAdresEmail2] nvarchar(1) NOT NULL,
    [FizAdSiedzKrajNazwa] nvarchar(200) NOT NULL,
    [FizAdSiedzWojewodztwoNazwa] nvarchar(100) NOT NULL,
    [FizAdSiedzPowiatNazwa] nvarchar(100) NOT NULL,
    [FizAdSiedzGminaNazwa] nvarchar(100) NOT NULL,
    [FizAdSiedzMiejscowoscNazwa] nvarchar(100) NOT NULL,
    [FizAdSiedzMiejscowoscPocztyNazwa] nvarchar(100) NOT NULL,
    [FizAdSiedzUlicaNazwa] nvarchar(351) NOT NULL,
    [UniqueIdentifierOfTheLoggedInUser] nvarchar(256) NULL,
    [DateOfCreate] datetime2 NOT NULL,
    [DateOfModification] datetime2 NULL,
    [PRegon] nvarchar(max) NOT NULL,
    [PNazwaRaportu] nvarchar(max) NOT NULL,
    [DaneSzukajPodmiotyParametryWyszukiwaniaId] uniqueidentifier NULL,
    [DaneSzukajPodmiotyKomunikatyOBledachId] uniqueidentifier NULL,
    CONSTRAINT [PK_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId] FOREIGN KEY ([DaneSzukajPodmiotyKomunikatyOBledachId]) REFERENCES [pagard].[DaneSzukajPodmiotyKomunikatyOBledach] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwani~] FOREIGN KEY ([DaneSzukajPodmiotyParametryWyszukiwaniaId]) REFERENCES [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [pagard].[BIR11OsFizycznaListaJednLokalnych] (
    [Id] uniqueidentifier NOT NULL,
    [DaneSzukajPodmiotyId] uniqueidentifier NULL,
    [LokfizRegon14] nvarchar(14) NOT NULL,
    [LokfizNazwa] nvarchar(2000) NOT NULL,
    [LokfizSilosID] int NOT NULL,
    [LokfizSilosSymbol] nvarchar(10) NOT NULL,
    [LokfizAdSiedzKrajSymbol] nvarchar(2) NOT NULL,
    [LokfizAdSiedzWojewodztwoSymbol] nvarchar(2) NOT NULL,
    [LokfizAdSiedzPowiatSymbol] nvarchar(2) NOT NULL,
    [LokfizAdSiedzGminaSymbol] nvarchar(3) NOT NULL,
    [LokfizAdSiedzKodPocztowy] nvarchar(12) NOT NULL,
    [LokfizAdSiedzMiejscowoscPocztySymbol] nvarchar(7) NOT NULL,
    [LokfizAdSiedzMiejscowoscSymbol] nvarchar(7) NOT NULL,
    [LokfizAdSiedzUlicaSymbol] nvarchar(5) NOT NULL,
    [LokfizAdSiedzNumerNieruchomosci] nvarchar(20) NOT NULL,
    [LokfizAdSiedzNumerLokalu] nvarchar(10) NOT NULL,
    [LokfizAdSiedzNietypoweMiejsceLokalizacji] nvarchar(256) NOT NULL,
    [LokfizAdSiedzWojewodztwoNazwa] nvarchar(100) NOT NULL,
    [LokfizAdSiedzPowiatNazwa] nvarchar(100) NOT NULL,
    [LokfizAdSiedzGminaNazwa] nvarchar(100) NOT NULL,
    [LokfizAdSiedzMiejscowoscNazwa] nvarchar(100) NOT NULL,
    [LokfizAdSiedzMiejscowoscPocztyNazwa] nvarchar(100) NOT NULL,
    [LokfizAdSiedzUlicaNazwa] nvarchar(350) NOT NULL,
    [LokfizDataPowstania] nvarchar(10) NOT NULL,
    [LokfizDataRozpoczeciaDzialalnosci] nvarchar(10) NOT NULL,
    [LokfizDataWpisuDoRegon] nvarchar(10) NOT NULL,
    [LokfizDataZawieszeniaDzialalnosci] nvarchar(10) NOT NULL,
    [LokfizDataWznowieniaDzialalnosci] nvarchar(10) NOT NULL,
    [LokfizDataZakonczeniaDzialalnosci] nvarchar(10) NOT NULL,
    [LokfizDataSkresleniaZRegon] nvarchar(10) NOT NULL,
    [UniqueIdentifierOfTheLoggedInUser] nvarchar(256) NULL,
    [DateOfCreate] datetime2 NOT NULL,
    [DateOfModification] datetime2 NULL,
    [PRegon] nvarchar(max) NOT NULL,
    [PNazwaRaportu] nvarchar(max) NOT NULL,
    [DaneSzukajPodmiotyParametryWyszukiwaniaId] uniqueidentifier NULL,
    [DaneSzukajPodmiotyKomunikatyOBledachId] uniqueidentifier NULL,
    CONSTRAINT [PK_BIR11OsFizycznaListaJednLokalnych] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_BIR11OsFizycznaListaJednLokalnych_DaneSzukajPodmioty_DaneSzukajPodmiotyId] FOREIGN KEY ([DaneSzukajPodmiotyId]) REFERENCES [pagard].[DaneSzukajPodmioty] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_BIR11OsFizycznaListaJednLokalnych_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId] FOREIGN KEY ([DaneSzukajPodmiotyKomunikatyOBledachId]) REFERENCES [pagard].[DaneSzukajPodmiotyKomunikatyOBledach] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_BIR11OsFizycznaListaJednLokalnych_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwaniaId] FOREIGN KEY ([DaneSzukajPodmiotyParametryWyszukiwaniaId]) REFERENCES [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [pagard].[BIR11OsFizycznaPkd] (
    [Id] uniqueidentifier NOT NULL,
    [DaneSzukajPodmiotyId] uniqueidentifier NULL,
    [FizPkdKod] nvarchar(5) NOT NULL,
    [FizPkdNazwa] nvarchar(200) NOT NULL,
    [FizPkdPrzewazajace] nvarchar(1) NOT NULL,
    [FizSilosID] int NOT NULL,
    [FizSilosSymbol] nvarchar(10) NOT NULL,
    [FizDataSkresleniaDzialalnosciZRegon] nvarchar(10) NOT NULL,
    [UniqueIdentifierOfTheLoggedInUser] nvarchar(256) NULL,
    [DateOfCreate] datetime2 NOT NULL,
    [DateOfModification] datetime2 NULL,
    [PRegon] nvarchar(max) NOT NULL,
    [PNazwaRaportu] nvarchar(max) NOT NULL,
    [DaneSzukajPodmiotyParametryWyszukiwaniaId] uniqueidentifier NULL,
    [DaneSzukajPodmiotyKomunikatyOBledachId] uniqueidentifier NULL,
    CONSTRAINT [PK_BIR11OsFizycznaPkd] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_BIR11OsFizycznaPkd_DaneSzukajPodmioty_DaneSzukajPodmiotyId] FOREIGN KEY ([DaneSzukajPodmiotyId]) REFERENCES [pagard].[DaneSzukajPodmioty] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_BIR11OsFizycznaPkd_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId] FOREIGN KEY ([DaneSzukajPodmiotyKomunikatyOBledachId]) REFERENCES [pagard].[DaneSzukajPodmiotyKomunikatyOBledach] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_BIR11OsFizycznaPkd_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwaniaId] FOREIGN KEY ([DaneSzukajPodmiotyParametryWyszukiwaniaId]) REFERENCES [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [pagard].[BIR11OsPrawna] (
    [Id] uniqueidentifier NOT NULL,
    [PrawRegon9] nvarchar(9) NOT NULL,
    [PrawNip] nvarchar(10) NOT NULL,
    [PrawStatusNip] nvarchar(max) NOT NULL,
    [PrawNazwa] nvarchar(2000) NOT NULL,
    [PrawNazwaSkrocona] nvarchar(256) NOT NULL,
    [PrawNumerWRejestrzeEwidencji] nvarchar(50) NOT NULL,
    [PrawDataWpisuDoRejestruEwidencji] nvarchar(10) NOT NULL,
    [PrawDataPowstania] nvarchar(10) NOT NULL,
    [PrawDataRozpoczeciaDzialalnosci] nvarchar(10) NOT NULL,
    [PrawDataWpisuDoRegon] nvarchar(10) NOT NULL,
    [PrawDataZawieszeniaDzialalnosci] nvarchar(10) NOT NULL,
    [PrawDataWznowieniaDzialalnosci] nvarchar(10) NOT NULL,
    [PrawDataZaistnieniaZmiany] nvarchar(10) NOT NULL,
    [PrawDataZakonczeniaDzialalnosci] nvarchar(10) NOT NULL,
    [PrawDataSkresleniaZRegon] nvarchar(10) NOT NULL,
    [PrawDataOrzeczeniaOUpadlosci] nvarchar(10) NOT NULL,
    [PrawDataZakonczeniaPostepowaniaUpadlosciowego] nvarchar(10) NOT NULL,
    [PrawAdSiedzKrajSymbol] nvarchar(2) NOT NULL,
    [PrawAdSiedzWojewodztwoSymbol] nvarchar(2) NOT NULL,
    [PrawAdSiedzPowiatSymbol] nvarchar(2) NOT NULL,
    [PrawAdSiedzGminaSymbol] nvarchar(3) NOT NULL,
    [PrawAdSiedzKodPocztowy] nvarchar(12) NOT NULL,
    [PrawAdSiedzMiejscowoscPocztySymbol] nvarchar(7) NOT NULL,
    [PrawAdSiedzMiejscowoscSymbol] nvarchar(7) NOT NULL,
    [PrawAdSiedzUlicaSymbol] nvarchar(5) NOT NULL,
    [PrawAdSiedzNumerNieruchomosci] nvarchar(20) NOT NULL,
    [PrawAdSiedzNumerLokalu] nvarchar(10) NOT NULL,
    [PrawAdSiedzNietypoweMiejsceLokalizacji] nvarchar(160) NOT NULL,
    [PrawNumerTelefonu] nvarchar(18) NOT NULL,
    [PrawNumerWewnetrznyTelefonu] nvarchar(6) NOT NULL,
    [PrawNumerFaksu] nvarchar(18) NOT NULL,
    [PrawAdresEmail] nvarchar(100) NOT NULL,
    [PrawAdresStronyinternetowej] nvarchar(100) NOT NULL,
    [PrawAdSiedzKrajNazwa] nvarchar(200) NOT NULL,
    [PrawAdSiedzWojewodztwoNazwa] nvarchar(100) NOT NULL,
    [PrawAdSiedzPowiatNazwa] nvarchar(100) NOT NULL,
    [PrawAdSiedzGminaNazwa] nvarchar(100) NOT NULL,
    [PrawAdSiedzMiejscowoscNazwa] nvarchar(100) NOT NULL,
    [PrawAdSiedzMiejscowoscPocztyNazwa] nvarchar(100) NOT NULL,
    [PrawAdSiedzUlicaNazwa] nvarchar(351) NOT NULL,
    [PrawPodstawowaFormaPrawnaSymbol] nvarchar(3) NOT NULL,
    [PrawSzczegolnaFormaPrawnaSymbol] nvarchar(3) NOT NULL,
    [PrawFormaFinansowaniaSymbol] nvarchar(1) NOT NULL,
    [PrawFormaWlasnosciSymbol] nvarchar(50) NOT NULL,
    [PrawOrganZalozycielskiSymbol] nvarchar(9) NOT NULL,
    [PrawOrganRejestrowySymbol] nvarchar(9) NOT NULL,
    [PrawRodzajRejestruEwidencjiSymbol] nvarchar(3) NOT NULL,
    [PrawPodstawowaFormaPrawnaNazwa] nvarchar(200) NOT NULL,
    [PrawSzczegolnaFormaPrawnaNazwa] nvarchar(200) NOT NULL,
    [PrawFormaFinansowaniaNazwa] nvarchar(240) NOT NULL,
    [PrawFormaWlasnosciNazwa] nvarchar(240) NOT NULL,
    [PrawOrganZalozycielskiNazwa] nvarchar(200) NOT NULL,
    [PrawOrganRejestrowyNazwa] nvarchar(240) NOT NULL,
    [PrawRodzajRejestruEwidencjiNazwa] nvarchar(240) NOT NULL,
    [PrawLiczbaJednLokalnych] int NOT NULL,
    [UniqueIdentifierOfTheLoggedInUser] nvarchar(256) NULL,
    [DateOfCreate] datetime2 NOT NULL,
    [DateOfModification] datetime2 NULL,
    [PRegon] nvarchar(max) NOT NULL,
    [PNazwaRaportu] nvarchar(max) NOT NULL,
    [DaneSzukajPodmiotyParametryWyszukiwaniaId] uniqueidentifier NULL,
    [DaneSzukajPodmiotyKomunikatyOBledachId] uniqueidentifier NULL,
    CONSTRAINT [PK_BIR11OsPrawna] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_BIR11OsPrawna_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId] FOREIGN KEY ([DaneSzukajPodmiotyKomunikatyOBledachId]) REFERENCES [pagard].[DaneSzukajPodmiotyKomunikatyOBledach] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_BIR11OsPrawna_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwaniaId] FOREIGN KEY ([DaneSzukajPodmiotyParametryWyszukiwaniaId]) REFERENCES [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [pagard].[BIR11OsPrawnaListaJednLokalnych] (
    [Id] uniqueidentifier NOT NULL,
    [DaneSzukajPodmiotyId] uniqueidentifier NULL,
    [LokprawRegon14] nvarchar(14) NOT NULL,
    [LokprawNazwa] nvarchar(254) NOT NULL,
    [LokprawAdSiedzKrajSymbol] nvarchar(2) NOT NULL,
    [LokprawAdSiedzWojewodztwoSymbol] nvarchar(2) NOT NULL,
    [LokprawAdSiedzPowiatSymbol] nvarchar(2) NOT NULL,
    [LokprawAdSiedzGminaSymbol] nvarchar(3) NOT NULL,
    [LokprawAdSiedzKodPocztowy] nvarchar(12) NOT NULL,
    [LokprawAdSiedzMiejscowoscPocztySymbol] nvarchar(7) NOT NULL,
    [LokprawAdSiedzMiejscowoscSymbol] nvarchar(7) NOT NULL,
    [LokprawAdSiedzUlicaSymbol] nvarchar(5) NOT NULL,
    [LokprawAdSiedzNumerNieruchomosci] nvarchar(20) NOT NULL,
    [LokprawAdSiedzNumerLokalu] nvarchar(10) NOT NULL,
    [LokprawAdSiedzNietypoweMiejsceLokalizacji] nvarchar(160) NOT NULL,
    [LokprawAdSiedzWojewodztwoNazwa] nvarchar(100) NOT NULL,
    [LokprawAdSiedzPowiatNazwa] nvarchar(100) NOT NULL,
    [LokprawAdSiedzGminaNazwa] nvarchar(100) NOT NULL,
    [LokprawAdSiedzMiejscowoscNazwa] nvarchar(100) NOT NULL,
    [LokprawAdSiedzMiejscowoscPocztyNazwa] nvarchar(100) NOT NULL,
    [LokprawAdSiedzUlicaNazwa] nvarchar(351) NOT NULL,
    [LokprawDataPowstania] nvarchar(10) NOT NULL,
    [LokprawDataRozpoczeciaDzialalnosci] nvarchar(10) NOT NULL,
    [LokprawDataWpisuDoRegon] nvarchar(10) NOT NULL,
    [LokprawDataZawieszeniaDzialalnosci] nvarchar(10) NOT NULL,
    [LokprawDataWznowieniaDzialalnosci] nvarchar(10) NOT NULL,
    [LokprawDataZakonczeniaDzialalnosci] nvarchar(10) NOT NULL,
    [LokprawDataSkresleniaZRegon] nvarchar(10) NOT NULL,
    [UniqueIdentifierOfTheLoggedInUser] nvarchar(256) NULL,
    [DateOfCreate] datetime2 NOT NULL,
    [DateOfModification] datetime2 NULL,
    [PRegon] nvarchar(max) NOT NULL,
    [PNazwaRaportu] nvarchar(max) NOT NULL,
    [DaneSzukajPodmiotyParametryWyszukiwaniaId] uniqueidentifier NULL,
    [DaneSzukajPodmiotyKomunikatyOBledachId] uniqueidentifier NULL,
    CONSTRAINT [PK_BIR11OsPrawnaListaJednLokalnych] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_BIR11OsPrawnaListaJednLokalnych_DaneSzukajPodmioty_DaneSzukajPodmiotyId] FOREIGN KEY ([DaneSzukajPodmiotyId]) REFERENCES [pagard].[DaneSzukajPodmioty] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_BIR11OsPrawnaListaJednLokalnych_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId] FOREIGN KEY ([DaneSzukajPodmiotyKomunikatyOBledachId]) REFERENCES [pagard].[DaneSzukajPodmiotyKomunikatyOBledach] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_BIR11OsPrawnaListaJednLokalnych_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwaniaId] FOREIGN KEY ([DaneSzukajPodmiotyParametryWyszukiwaniaId]) REFERENCES [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [pagard].[BIR11OsPrawnaPkd] (
    [Id] uniqueidentifier NOT NULL,
    [DaneSzukajPodmiotyId] uniqueidentifier NULL,
    [PrawPkdKod] nvarchar(5) NOT NULL,
    [PrawPkdNazwa] nvarchar(200) NOT NULL,
    [PrawPkdPrzewazajace] nvarchar(1) NOT NULL,
    [UniqueIdentifierOfTheLoggedInUser] nvarchar(256) NULL,
    [DateOfCreate] datetime2 NOT NULL,
    [DateOfModification] datetime2 NULL,
    [PRegon] nvarchar(max) NOT NULL,
    [PNazwaRaportu] nvarchar(max) NOT NULL,
    [DaneSzukajPodmiotyParametryWyszukiwaniaId] uniqueidentifier NULL,
    [DaneSzukajPodmiotyKomunikatyOBledachId] uniqueidentifier NULL,
    CONSTRAINT [PK_BIR11OsPrawnaPkd] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_BIR11OsPrawnaPkd_DaneSzukajPodmioty_DaneSzukajPodmiotyId] FOREIGN KEY ([DaneSzukajPodmiotyId]) REFERENCES [pagard].[DaneSzukajPodmioty] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_BIR11OsPrawnaPkd_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId] FOREIGN KEY ([DaneSzukajPodmiotyKomunikatyOBledachId]) REFERENCES [pagard].[DaneSzukajPodmiotyKomunikatyOBledach] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_BIR11OsPrawnaPkd_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwaniaId] FOREIGN KEY ([DaneSzukajPodmiotyParametryWyszukiwaniaId]) REFERENCES [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [pagard].[BIR11OsPrawnaSpCywilnaWspolnicy] (
    [Id] uniqueidentifier NOT NULL,
    [DaneSzukajPodmiotyId] uniqueidentifier NULL,
    [WspolscRegonWspolnikSpolki] nvarchar(9) NOT NULL,
    [WspolscImiePierwsze] nvarchar(30) NOT NULL,
    [WspolscImieDrugie] nvarchar(30) NOT NULL,
    [WspolscNazwisko] nvarchar(40) NOT NULL,
    [WspolscFirmaNazwa] nvarchar(2000) NOT NULL,
    [UniqueIdentifierOfTheLoggedInUser] nvarchar(256) NULL,
    [DateOfCreate] datetime2 NOT NULL,
    [DateOfModification] datetime2 NULL,
    [PRegon] nvarchar(max) NOT NULL,
    [PNazwaRaportu] nvarchar(max) NOT NULL,
    [DaneSzukajPodmiotyParametryWyszukiwaniaId] uniqueidentifier NULL,
    [DaneSzukajPodmiotyKomunikatyOBledachId] uniqueidentifier NULL,
    CONSTRAINT [PK_BIR11OsPrawnaSpCywilnaWspolnicy] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_BIR11OsPrawnaSpCywilnaWspolnicy_DaneSzukajPodmioty_DaneSzukajPodmiotyId] FOREIGN KEY ([DaneSzukajPodmiotyId]) REFERENCES [pagard].[DaneSzukajPodmioty] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_BIR11OsPrawnaSpCywilnaWspolnicy_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId] FOREIGN KEY ([DaneSzukajPodmiotyKomunikatyOBledachId]) REFERENCES [pagard].[DaneSzukajPodmiotyKomunikatyOBledach] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_BIR11OsPrawnaSpCywilnaWspolnicy_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwaniaId] FOREIGN KEY ([DaneSzukajPodmiotyParametryWyszukiwaniaId]) REFERENCES [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [pagard].[BIR11TypPodmiotu] (
    [Id] uniqueidentifier NOT NULL,
    [Typ] nvarchar(max) NOT NULL,
    [UniqueIdentifierOfTheLoggedInUser] nvarchar(256) NULL,
    [DateOfCreate] datetime2 NOT NULL,
    [DateOfModification] datetime2 NULL,
    [PRegon] nvarchar(max) NOT NULL,
    [PNazwaRaportu] nvarchar(max) NOT NULL,
    [DaneSzukajPodmiotyParametryWyszukiwaniaId] uniqueidentifier NULL,
    [DaneSzukajPodmiotyKomunikatyOBledachId] uniqueidentifier NULL,
    CONSTRAINT [PK_BIR11TypPodmiotu] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_BIR11TypPodmiotu_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId] FOREIGN KEY ([DaneSzukajPodmiotyKomunikatyOBledachId]) REFERENCES [pagard].[DaneSzukajPodmiotyKomunikatyOBledach] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_BIR11TypPodmiotu_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwaniaId] FOREIGN KEY ([DaneSzukajPodmiotyParametryWyszukiwaniaId]) REFERENCES [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [pagard].[DaneSzukajPodmiotyMessageInspector] (
    [DaneSzukajPodmiotyId] uniqueidentifier NOT NULL,
    [MessageInspectorId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_DaneSzukajPodmiotyMessageInspector] PRIMARY KEY ([DaneSzukajPodmiotyId], [MessageInspectorId]),
    CONSTRAINT [FK_DaneSzukajPodmiotyMessageInspector_DaneSzukajPodmioty_DaneSzukajPodmiotyId] FOREIGN KEY ([DaneSzukajPodmiotyId]) REFERENCES [pagard].[DaneSzukajPodmioty] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_DaneSzukajPodmiotyMessageInspector_MessageInspector_MessageInspectorId] FOREIGN KEY ([MessageInspectorId]) REFERENCES [pagard].[MessageInspector] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_DaneSzukajPodmiotyParametryWyszukiwania_DataModyfikacji] ON [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] ([DataModyfikacji]);
GO

CREATE INDEX [IX_DaneSzukajPodmiotyParametryWyszukiwania_DataUtworzenia] ON [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] ([DataUtworzenia]);
GO

CREATE INDEX [IX_DaneSzukajPodmioty_BIR11JednLokalnaOsFizycznejId] ON [pagard].[DaneSzukajPodmioty] ([BIR11JednLokalnaOsFizycznejId]);
GO

CREATE INDEX [IX_DaneSzukajPodmioty_BIR11JednLokalnaOsPrawnejId] ON [pagard].[DaneSzukajPodmioty] ([BIR11JednLokalnaOsPrawnejId]);
GO

CREATE INDEX [IX_DaneSzukajPodmioty_BIR11OsFizycznaDaneOgolneId] ON [pagard].[DaneSzukajPodmioty] ([BIR11OsFizycznaDaneOgolneId]);
GO

CREATE INDEX [IX_DaneSzukajPodmioty_BIR11OsFizycznaDzialalnoscCeidgId] ON [pagard].[DaneSzukajPodmioty] ([BIR11OsFizycznaDzialalnoscCeidgId]);
GO

CREATE INDEX [IX_DaneSzukajPodmioty_BIR11OsFizycznaDzialalnoscPozostalaId] ON [pagard].[DaneSzukajPodmioty] ([BIR11OsFizycznaDzialalnoscPozostalaId]);
GO

CREATE INDEX [IX_DaneSzukajPodmioty_BIR11OsFizycznaDzialalnoscRolniczaId] ON [pagard].[DaneSzukajPodmioty] ([BIR11OsFizycznaDzialalnoscRolniczaId]);
GO

CREATE INDEX [IX_DaneSzukajPodmioty_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108Id] ON [pagard].[DaneSzukajPodmioty] ([BIR11OsFizycznaDzialalnoscSkreslonaDo20141108Id]);
GO

CREATE INDEX [IX_DaneSzukajPodmioty_BIR11OsPrawnaId] ON [pagard].[DaneSzukajPodmioty] ([BIR11OsPrawnaId]);
GO

CREATE INDEX [IX_DaneSzukajPodmioty_BIR11TypPodmiotuId] ON [pagard].[DaneSzukajPodmioty] ([BIR11TypPodmiotuId]);
GO

CREATE INDEX [IX_DaneSzukajPodmioty_DaneSzukajPodmiotyKomunikatyOBledachId] ON [pagard].[DaneSzukajPodmioty] ([DaneSzukajPodmiotyKomunikatyOBledachId]);
GO

CREATE INDEX [IX_DaneSzukajPodmioty_DaneSzukajPodmiotyParametryWyszukiwaniaId] ON [pagard].[DaneSzukajPodmioty] ([DaneSzukajPodmiotyParametryWyszukiwaniaId]);
GO

CREATE INDEX [IX_DaneSzukajPodmioty_DataModyfikacji] ON [pagard].[DaneSzukajPodmioty] ([DataModyfikacji]);
GO

CREATE INDEX [IX_DaneSzukajPodmioty_DataUtworzenia] ON [pagard].[DaneSzukajPodmioty] ([DataUtworzenia]);
GO

CREATE INDEX [IX_DaneSzukajPodmioty_DataZakonczeniaDzialalnosci] ON [pagard].[DaneSzukajPodmioty] ([DataZakonczeniaDzialalnosci]);
GO

CREATE INDEX [IX_DaneSzukajPodmioty_NrLokalu] ON [pagard].[DaneSzukajPodmioty] ([NrLokalu]);
GO

CREATE INDEX [IX_DaneSzukajPodmioty_NrNieruchomosci] ON [pagard].[DaneSzukajPodmioty] ([NrNieruchomosci]);
GO

CREATE INDEX [IX_DaneSzukajPodmioty_StatusNip] ON [pagard].[DaneSzukajPodmioty] ([StatusNip]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_DaneSzukajPodmiotyKomunikatyOBledachId] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([DaneSzukajPodmiotyKomunikatyOBledachId]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_DaneSzukajPodmiotyParametryWyszukiwaniaId] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([DaneSzukajPodmiotyParametryWyszukiwaniaId]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_DateOfCreate] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([DateOfCreate]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_DateOfModification] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([DateOfModification]);
GO

CREATE UNIQUE INDEX [IX_BIR11JednLokalnaOsFizycznej_Id] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([Id]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzGminaNazwa] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizAdSiedzGminaNazwa]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzGminaSymbol] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizAdSiedzGminaSymbol]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzKodPocztowy] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizAdSiedzKodPocztowy]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzKrajNazwa] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizAdSiedzKrajNazwa]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzKrajSymbol] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizAdSiedzKrajSymbol]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzMiejscowoscNazwa] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizAdSiedzMiejscowoscNazwa]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzMiejscowoscPocztyNazwa] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizAdSiedzMiejscowoscPocztyNazwa]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzMiejscowoscPocztySymbol] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizAdSiedzMiejscowoscPocztySymbol]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzMiejscowoscSymbol] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizAdSiedzMiejscowoscSymbol]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzNietypoweMiejsceLokalizacji] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizAdSiedzNietypoweMiejsceLokalizacji]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzNumerLokalu] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizAdSiedzNumerLokalu]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzNumerNieruchomosci] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizAdSiedzNumerNieruchomosci]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzPowiatNazwa] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizAdSiedzPowiatNazwa]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzPowiatSymbol] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizAdSiedzPowiatSymbol]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzUlicaNazwa] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizAdSiedzUlicaNazwa]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzUlicaSymbol] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizAdSiedzUlicaSymbol]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzWojewodztwoNazwa] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizAdSiedzWojewodztwoNazwa]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizAdSiedzWojewodztwoSymbol] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizAdSiedzWojewodztwoSymbol]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizCNiePodjetoDzialalnosci] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizCNiePodjetoDzialalnosci]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizDataPowstania] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizDataPowstania]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizDataRozpoczeciaDzialalnosci] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizDataRozpoczeciaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizDataSkresleniaZRegon] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizDataSkresleniaZRegon]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizDataWpisuDoRegon] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizDataWpisuDoRegon]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizDataWpisuDoRejestruEwidencji] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizDataWpisuDoRejestruEwidencji]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizDataWznowieniaDzialalnosci] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizDataWznowieniaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizDataZaistnieniaZmiany] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizDataZaistnieniaZmiany]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizDataZakonczeniaDzialalnosci] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizDataZakonczeniaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizDataZawieszeniaDzialalnosci] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizDataZawieszeniaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizFormaFinansowaniaNazwa] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizFormaFinansowaniaNazwa]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizFormaFinansowaniaSymbol] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizFormaFinansowaniaSymbol]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizNazwa] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizNazwa]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizNumerwRejestrzeEwidencji] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizNumerwRejestrzeEwidencji]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizOrganRejestrowyNazwa] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizOrganRejestrowyNazwa]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizOrganRejestrowySymbol] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizOrganRejestrowySymbol]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizRegon14] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizRegon14]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizRodzajRejestruNazwa] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizRodzajRejestruNazwa]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizRodzajRejestruSymbol] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizRodzajRejestruSymbol]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizSilosID] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizSilosID]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_LokfizSilosNazwa] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([LokfizSilosNazwa]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznej_UniqueIdentifierOfTheLoggedInUser] ON [pagard].[BIR11JednLokalnaOsFizycznej] ([UniqueIdentifierOfTheLoggedInUser]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznejPkd_DaneSzukajPodmiotyId] ON [pagard].[BIR11JednLokalnaOsFizycznejPkd] ([DaneSzukajPodmiotyId]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznejPkd_DaneSzukajPodmiotyKomunikatyOBledachId] ON [pagard].[BIR11JednLokalnaOsFizycznejPkd] ([DaneSzukajPodmiotyKomunikatyOBledachId]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznejPkd_DaneSzukajPodmiotyParametryWyszukiwaniaId] ON [pagard].[BIR11JednLokalnaOsFizycznejPkd] ([DaneSzukajPodmiotyParametryWyszukiwaniaId]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznejPkd_DateOfCreate] ON [pagard].[BIR11JednLokalnaOsFizycznejPkd] ([DateOfCreate]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznejPkd_DateOfModification] ON [pagard].[BIR11JednLokalnaOsFizycznejPkd] ([DateOfModification]);
GO

CREATE UNIQUE INDEX [IX_BIR11JednLokalnaOsFizycznejPkd_Id] ON [pagard].[BIR11JednLokalnaOsFizycznejPkd] ([Id]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznejPkd_LokfizPkdKod] ON [pagard].[BIR11JednLokalnaOsFizycznejPkd] ([LokfizPkdKod]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznejPkd_LokfizPkdNazwa] ON [pagard].[BIR11JednLokalnaOsFizycznejPkd] ([LokfizPkdNazwa]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznejPkd_LokfizPkdPrzewazajace] ON [pagard].[BIR11JednLokalnaOsFizycznejPkd] ([LokfizPkdPrzewazajace]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznejPkd_LokfizSilosSymbol] ON [pagard].[BIR11JednLokalnaOsFizycznejPkd] ([LokfizSilosSymbol]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsFizycznejPkd_UniqueIdentifierOfTheLoggedInUser] ON [pagard].[BIR11JednLokalnaOsFizycznejPkd] ([UniqueIdentifierOfTheLoggedInUser]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_DaneSzukajPodmiotyKomunikatyOBledachId] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([DaneSzukajPodmiotyKomunikatyOBledachId]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_DaneSzukajPodmiotyParametryWyszukiwaniaId] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([DaneSzukajPodmiotyParametryWyszukiwaniaId]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_DateOfCreate] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([DateOfCreate]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_DateOfModification] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([DateOfModification]);
GO

CREATE UNIQUE INDEX [IX_BIR11JednLokalnaOsPrawnej_Id] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([Id]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzGminaNazwa] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawAdSiedzGminaNazwa]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzGminaSymbol] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawAdSiedzGminaSymbol]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzKodPocztowy] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawAdSiedzKodPocztowy]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzKrajNazwa] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawAdSiedzKrajNazwa]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzKrajSymbol] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawAdSiedzKrajSymbol]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzMiejscowoscNazwa] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawAdSiedzMiejscowoscNazwa]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzMiejscowoscPocztyNazwa] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawAdSiedzMiejscowoscPocztyNazwa]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzMiejscowoscPocztySymbol] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawAdSiedzMiejscowoscPocztySymbol]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzMiejscowoscSymbol] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawAdSiedzMiejscowoscSymbol]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzNietypoweMiejsceLokalizacji] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawAdSiedzNietypoweMiejsceLokalizacji]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzNumerLokalu] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawAdSiedzNumerLokalu]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzNumerNieruchomosci] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawAdSiedzNumerNieruchomosci]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzPowiatNazwa] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawAdSiedzPowiatNazwa]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzPowiatSymbol] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawAdSiedzPowiatSymbol]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzUlicaNazwa] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawAdSiedzUlicaNazwa]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzUlicaSymbol] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawAdSiedzUlicaSymbol]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzWojewodztwoNazwa] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawAdSiedzWojewodztwoNazwa]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawAdSiedzWojewodztwoSymbol] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawAdSiedzWojewodztwoSymbol]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawDataPowstania] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawDataPowstania]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawDataRozpoczeciaDzialalnosci] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawDataRozpoczeciaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawDataSkresleniaZRegon] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawDataSkresleniaZRegon]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawDataWpisuDoRegon] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawDataWpisuDoRegon]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawDataWpisuDoRejestruEwidencji] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawDataWpisuDoRejestruEwidencji]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawDataWznowieniaDzialalnosci] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawDataWznowieniaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawDataZaistnieniaZmiany] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawDataZaistnieniaZmiany]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawDataZakonczeniaDzialalnosci] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawDataZakonczeniaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawDataZawieszeniaDzialalnosci] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawDataZawieszeniaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawFormaFinansowaniaNazwa] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawFormaFinansowaniaNazwa]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawFormaFinansowaniaSymbol] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawFormaFinansowaniaSymbol]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawNazwa] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawNazwa]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawNumerWrejestrzeEwidencji] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawNumerWrejestrzeEwidencji]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawOrganRejestrowyNazwa] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawOrganRejestrowyNazwa]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawOrganRejestrowySymbol] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawOrganRejestrowySymbol]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawRegon14] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawRegon14]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawRodzajRejestruEwidencjiNazwa] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawRodzajRejestruEwidencjiNazwa]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_LokprawRodzajRejestruEwidencjiSymbol] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([LokprawRodzajRejestruEwidencjiSymbol]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnej_UniqueIdentifierOfTheLoggedInUser] ON [pagard].[BIR11JednLokalnaOsPrawnej] ([UniqueIdentifierOfTheLoggedInUser]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnejPkd_DaneSzukajPodmiotyId] ON [pagard].[BIR11JednLokalnaOsPrawnejPkd] ([DaneSzukajPodmiotyId]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnejPkd_DaneSzukajPodmiotyKomunikatyOBledachId] ON [pagard].[BIR11JednLokalnaOsPrawnejPkd] ([DaneSzukajPodmiotyKomunikatyOBledachId]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnejPkd_DaneSzukajPodmiotyParametryWyszukiwaniaId] ON [pagard].[BIR11JednLokalnaOsPrawnejPkd] ([DaneSzukajPodmiotyParametryWyszukiwaniaId]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnejPkd_DateOfCreate] ON [pagard].[BIR11JednLokalnaOsPrawnejPkd] ([DateOfCreate]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnejPkd_DateOfModification] ON [pagard].[BIR11JednLokalnaOsPrawnejPkd] ([DateOfModification]);
GO

CREATE UNIQUE INDEX [IX_BIR11JednLokalnaOsPrawnejPkd_Id] ON [pagard].[BIR11JednLokalnaOsPrawnejPkd] ([Id]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnejPkd_LokprawPkdKod] ON [pagard].[BIR11JednLokalnaOsPrawnejPkd] ([LokprawPkdKod]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnejPkd_LokprawPkdNazwa] ON [pagard].[BIR11JednLokalnaOsPrawnejPkd] ([LokprawPkdNazwa]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnejPkd_LokprawPkdPrzewazajace] ON [pagard].[BIR11JednLokalnaOsPrawnejPkd] ([LokprawPkdPrzewazajace]);
GO

CREATE INDEX [IX_BIR11JednLokalnaOsPrawnejPkd_UniqueIdentifierOfTheLoggedInUser] ON [pagard].[BIR11JednLokalnaOsPrawnejPkd] ([UniqueIdentifierOfTheLoggedInUser]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDaneOgolne_DaneSzukajPodmiotyKomunikatyOBledachId] ON [pagard].[BIR11OsFizycznaDaneOgolne] ([DaneSzukajPodmiotyKomunikatyOBledachId]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDaneOgolne_DaneSzukajPodmiotyParametryWyszukiwaniaId] ON [pagard].[BIR11OsFizycznaDaneOgolne] ([DaneSzukajPodmiotyParametryWyszukiwaniaId]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDaneOgolne_DateOfCreate] ON [pagard].[BIR11OsFizycznaDaneOgolne] ([DateOfCreate]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDaneOgolne_DateOfModification] ON [pagard].[BIR11OsFizycznaDaneOgolne] ([DateOfModification]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDaneOgolne_FizDataSkresleniaPodmiotuZRegon] ON [pagard].[BIR11OsFizycznaDaneOgolne] ([FizDataSkresleniaPodmiotuZRegon]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDaneOgolne_FizDataWpisuPodmiotuDoRegon] ON [pagard].[BIR11OsFizycznaDaneOgolne] ([FizDataWpisuPodmiotuDoRegon]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDaneOgolne_FizDataZaistnieniaZmiany] ON [pagard].[BIR11OsFizycznaDaneOgolne] ([FizDataZaistnieniaZmiany]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDaneOgolne_FizDzialalnoscCeidg] ON [pagard].[BIR11OsFizycznaDaneOgolne] ([FizDzialalnoscCeidg]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDaneOgolne_FizDzialalnoscPozostala] ON [pagard].[BIR11OsFizycznaDaneOgolne] ([FizDzialalnoscPozostala]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDaneOgolne_FizDzialalnoscRolnicza] ON [pagard].[BIR11OsFizycznaDaneOgolne] ([FizDzialalnoscRolnicza]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDaneOgolne_FizDzialalnoscSkreslonaDo20141108] ON [pagard].[BIR11OsFizycznaDaneOgolne] ([FizDzialalnoscSkreslonaDo20141108]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDaneOgolne_FizFormaFinansowaniaNazwa] ON [pagard].[BIR11OsFizycznaDaneOgolne] ([FizFormaFinansowaniaNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDaneOgolne_FizFormaFinansowaniaSymbol] ON [pagard].[BIR11OsFizycznaDaneOgolne] ([FizFormaFinansowaniaSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDaneOgolne_FizFormaWlasnosciNazwa] ON [pagard].[BIR11OsFizycznaDaneOgolne] ([FizFormaWlasnosciNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDaneOgolne_FizFormaWlasnosciSymbol] ON [pagard].[BIR11OsFizycznaDaneOgolne] ([FizFormaWlasnosciSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDaneOgolne_FizImie1] ON [pagard].[BIR11OsFizycznaDaneOgolne] ([FizImie1]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDaneOgolne_FizImie2] ON [pagard].[BIR11OsFizycznaDaneOgolne] ([FizImie2]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDaneOgolne_FizLiczbaJednLokalnych] ON [pagard].[BIR11OsFizycznaDaneOgolne] ([FizLiczbaJednLokalnych]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDaneOgolne_FizNazwisko] ON [pagard].[BIR11OsFizycznaDaneOgolne] ([FizNazwisko]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDaneOgolne_FizNip] ON [pagard].[BIR11OsFizycznaDaneOgolne] ([FizNip]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDaneOgolne_FizPodstawowaFormaPrawnaNazwa] ON [pagard].[BIR11OsFizycznaDaneOgolne] ([FizPodstawowaFormaPrawnaNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDaneOgolne_FizPodstawowaFormaPrawnaSymbol] ON [pagard].[BIR11OsFizycznaDaneOgolne] ([FizPodstawowaFormaPrawnaSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDaneOgolne_FizRegon9] ON [pagard].[BIR11OsFizycznaDaneOgolne] ([FizRegon9]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDaneOgolne_FizStatusNip] ON [pagard].[BIR11OsFizycznaDaneOgolne] ([FizStatusNip]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDaneOgolne_FizSzczegolnaFormaPrawnaNazwa] ON [pagard].[BIR11OsFizycznaDaneOgolne] ([FizSzczegolnaFormaPrawnaNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDaneOgolne_FizSzczegolnaFormaPrawnaSymbol] ON [pagard].[BIR11OsFizycznaDaneOgolne] ([FizSzczegolnaFormaPrawnaSymbol]);
GO

CREATE UNIQUE INDEX [IX_BIR11OsFizycznaDaneOgolne_Id] ON [pagard].[BIR11OsFizycznaDaneOgolne] ([Id]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDaneOgolne_UniqueIdentifierOfTheLoggedInUser] ON [pagard].[BIR11OsFizycznaDaneOgolne] ([UniqueIdentifierOfTheLoggedInUser]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_DaneSzukajPodmiotyKomunikatyOBledachId] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([DaneSzukajPodmiotyKomunikatyOBledachId]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_DaneSzukajPodmiotyParametryWyszukiwaniaId] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([DaneSzukajPodmiotyParametryWyszukiwaniaId]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_DateOfCreate] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([DateOfCreate]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_DateOfModification] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([DateOfModification]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdresEmail] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizAdresEmail]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdresStronyinternetowej] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizAdresStronyinternetowej]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzGminaNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizAdSiedzGminaNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzGminaSymbol] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizAdSiedzGminaSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzKodPocztowy] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizAdSiedzKodPocztowy]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzKrajNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizAdSiedzKrajNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzKrajSymbol] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizAdSiedzKrajSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzMiejscowoscNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizAdSiedzMiejscowoscNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzMiejscowoscPocztyNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizAdSiedzMiejscowoscPocztyNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzMiejscowoscPocztySymbol] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizAdSiedzMiejscowoscPocztySymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzMiejscowoscSymbol] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizAdSiedzMiejscowoscSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzNietypoweMiejsceLokalizacji] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizAdSiedzNietypoweMiejsceLokalizacji]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzNumerLokalu] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizAdSiedzNumerLokalu]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzNumerNieruchomosci] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizAdSiedzNumerNieruchomosci]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzPowiatNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizAdSiedzPowiatNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzPowiatSymbol] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizAdSiedzPowiatSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzUlicaNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizAdSiedzUlicaNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzUlicaSymbol] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizAdSiedzUlicaSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzWojewodztwoNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizAdSiedzWojewodztwoNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizAdSiedzWojewodztwoSymbol] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizAdSiedzWojewodztwoSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizCDataSkresleniaZRejestruEwidencji] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizCDataSkresleniaZRejestruEwidencji]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizCDataWpisuDoRejestruEwidencji] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizCDataWpisuDoRejestruEwidencji]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizCNiePodjetoDzialalnosci] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizCNiePodjetoDzialalnosci]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizCNumerWRejestrzeEwidencji] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizCNumerWRejestrzeEwidencji]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizCOrganRejestrowyNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizCOrganRejestrowyNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizCOrganRejestrowySymbol] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizCOrganRejestrowySymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizCRodzajRejestruNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizCRodzajRejestruNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizCRodzajRejestruSymbol] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizCRodzajRejestruSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizDataOrzeczeniaOUpadlosci] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizDataOrzeczeniaOUpadlosci]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizDataPowstania] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizDataPowstania]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizDataRozpoczeciaDzialalnosci] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizDataRozpoczeciaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizDataSkresleniaDzialalnosciZRegon] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizDataSkresleniaDzialalnosciZRegon]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizDataWpisuDzialalnosciDoRegon] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizDataWpisuDzialalnosciDoRegon]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizDataWznowieniaDzialalnosci] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizDataWznowieniaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizDataZaistnieniaZmianyDzialalnosci] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizDataZaistnieniaZmianyDzialalnosci]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizDataZakonczeniaDzialalnosci] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizDataZakonczeniaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizDataZakonczeniaPostepowaniaUpadlosciowego] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizDataZakonczeniaPostepowaniaUpadlosciowego]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizDataZawieszeniaDzialalnosci] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizDataZawieszeniaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizNazwaSkrocona] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizNazwaSkrocona]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizNumerFaksu] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizNumerFaksu]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizNumerTelefonu] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizNumerTelefonu]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizNumerWewnetrznyTelefonu] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizNumerWewnetrznyTelefonu]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_FizRegon9] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([FizRegon9]);
GO

CREATE UNIQUE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_Id] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([Id]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscCeidg_UniqueIdentifierOfTheLoggedInUser] ON [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([UniqueIdentifierOfTheLoggedInUser]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_DaneSzukajPodmiotyKomunikatyOBledachId] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([DaneSzukajPodmiotyKomunikatyOBledachId]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_DaneSzukajPodmiotyParametryWyszukiwaniaId] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([DaneSzukajPodmiotyParametryWyszukiwaniaId]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_DateOfCreate] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([DateOfCreate]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_DateOfModification] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([DateOfModification]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdresEmail] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizAdresEmail]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdresStronyinternetowej] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizAdresStronyinternetowej]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzGminaNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizAdSiedzGminaNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzGminaSymbol] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizAdSiedzGminaSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzKodPocztowy] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizAdSiedzKodPocztowy]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzKrajNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizAdSiedzKrajNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzKrajSymbol] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizAdSiedzKrajSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzMiejscowoscNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizAdSiedzMiejscowoscNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzMiejscowoscPocztyNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizAdSiedzMiejscowoscPocztyNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzMiejscowoscPocztySymbol] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizAdSiedzMiejscowoscPocztySymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzMiejscowoscSymbol] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizAdSiedzMiejscowoscSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzNietypoweMiejsceLokalizacji] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizAdSiedzNietypoweMiejsceLokalizacji]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzNumerLokalu] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizAdSiedzNumerLokalu]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzNumerNieruchomosci] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizAdSiedzNumerNieruchomosci]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzPowiatNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizAdSiedzPowiatNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzPowiatSymbol] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizAdSiedzPowiatSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzUlicaNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizAdSiedzUlicaNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzUlicaSymbol] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizAdSiedzUlicaSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzWojewodztwoNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizAdSiedzWojewodztwoNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizAdSiedzWojewodztwoSymbol] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizAdSiedzWojewodztwoSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizDataOrzeczeniaOUpadlosci] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizDataOrzeczeniaOUpadlosci]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizDataPowstania] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizDataPowstania]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizDataRozpoczeciaDzialalnosci] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizDataRozpoczeciaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizDataSkresleniaDzialalnosciZRegon] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizDataSkresleniaDzialalnosciZRegon]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizDataWpisuDzialalnosciDoRegon] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizDataWpisuDzialalnosciDoRegon]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizDataWznowieniaDzialalnosci] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizDataWznowieniaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizDataZaistnieniaZmianyDzialalnosci] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizDataZaistnieniaZmianyDzialalnosci]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizDataZakonczeniaDzialalnosci] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizDataZakonczeniaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizDataZakonczeniaPostepowaniaUpadlosciowego] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizDataZakonczeniaPostepowaniaUpadlosciowego]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizDataZawieszeniaDzialalnosci] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizDataZawieszeniaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizNazwaSkrocona] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizNazwaSkrocona]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizNumerFaksu] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizNumerFaksu]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizNumerTelefonu] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizNumerTelefonu]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizNumerWewnetrznyTelefonu] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizNumerWewnetrznyTelefonu]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizPDataWpisuDoRejestruEwidencji] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizPDataWpisuDoRejestruEwidencji]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizPNumerWRejestrzeEwidencji] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizPNumerWRejestrzeEwidencji]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizPOrganRejestrowyNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizPOrganRejestrowyNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizPOrganRejestrowySymbol] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizPOrganRejestrowySymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizPRodzajRejestruNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizPRodzajRejestruNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizPRodzajRejestruSymbol] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizPRodzajRejestruSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_FizRegon9] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([FizRegon9]);
GO

CREATE UNIQUE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_Id] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([Id]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscPozostala_UniqueIdentifierOfTheLoggedInUser] ON [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([UniqueIdentifierOfTheLoggedInUser]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_DaneSzukajPodmiotyKomunikatyOBledachId] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([DaneSzukajPodmiotyKomunikatyOBledachId]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_DaneSzukajPodmiotyParametryWyszukiwaniaId] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([DaneSzukajPodmiotyParametryWyszukiwaniaId]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_DateOfCreate] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([DateOfCreate]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_DateOfModification] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([DateOfModification]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdresEmail] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizAdresEmail]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdresStronyinternetowej] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizAdresStronyinternetowej]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzGminaNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizAdSiedzGminaNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzGminaSymbol] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizAdSiedzGminaSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzKodPocztowy] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizAdSiedzKodPocztowy]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzKrajNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizAdSiedzKrajNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzKrajSymbol] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizAdSiedzKrajSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzMiejscowoscNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizAdSiedzMiejscowoscNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzMiejscowoscPocztyNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizAdSiedzMiejscowoscPocztyNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzMiejscowoscPocztySymbol] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizAdSiedzMiejscowoscPocztySymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzMiejscowoscSymbol] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizAdSiedzMiejscowoscSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzNietypoweMiejsceLokalizacji] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizAdSiedzNietypoweMiejsceLokalizacji]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzNumerLokalu] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizAdSiedzNumerLokalu]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzNumerNieruchomosci] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizAdSiedzNumerNieruchomosci]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzPowiatNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizAdSiedzPowiatNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzPowiatSymbol] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizAdSiedzPowiatSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzUlicaNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizAdSiedzUlicaNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzUlicaSymbol] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizAdSiedzUlicaSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzWojewodztwoNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizAdSiedzWojewodztwoNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizAdSiedzWojewodztwoSymbol] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizAdSiedzWojewodztwoSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizDataOrzeczeniaOUpadlosci] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizDataOrzeczeniaOUpadlosci]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizDataPowstania] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizDataPowstania]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizDataRozpoczeciaDzialalnosci] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizDataRozpoczeciaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizDataSkresleniaDzialalanosciZRegon] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizDataSkresleniaDzialalanosciZRegon]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizDataWpisuDzialalnosciDoRegon] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizDataWpisuDzialalnosciDoRegon]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizDataWznowieniaDzialalnosci] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizDataWznowieniaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizDataZaistnieniaZmianyDzialalnosci] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizDataZaistnieniaZmianyDzialalnosci]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizDataZakonczeniaDzialalnosci] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizDataZakonczeniaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizDataZakonczeniaPostepowaniaUpadlosciowego] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizDataZakonczeniaPostepowaniaUpadlosciowego]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizDataZawieszeniaDzialalnosci] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizDataZawieszeniaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizNazwaSkrocona] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizNazwaSkrocona]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizNumerFaksu] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizNumerFaksu]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizNumerTelefonu] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizNumerTelefonu]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizNumerWewnetrznyTelefonu] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizNumerWewnetrznyTelefonu]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_FizRegon9] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([FizRegon9]);
GO

CREATE UNIQUE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_Id] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([Id]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscRolnicza_UniqueIdentifierOfTheLoggedInUser] ON [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([UniqueIdentifierOfTheLoggedInUser]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_DaneSzukajPodmiotyKomunikatyOBledachId] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([DaneSzukajPodmiotyKomunikatyOBledachId]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_DaneSzukajPodmiotyParametryWyszukiwaniaId] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([DaneSzukajPodmiotyParametryWyszukiwaniaId]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_DateOfCreate] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([DateOfCreate]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_DateOfModification] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([DateOfModification]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdresEmail] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizAdresEmail]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdresEmail2] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizAdresEmail2]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdresStronyinternetowej] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizAdresStronyinternetowej]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzGminaNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizAdSiedzGminaNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzGminaSymbol] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizAdSiedzGminaSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzKodPocztowy] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizAdSiedzKodPocztowy]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzKrajNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizAdSiedzKrajNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzKrajSymbol] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizAdSiedzKrajSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzMiejscowoscNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizAdSiedzMiejscowoscNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzMiejscowoscPocztyNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizAdSiedzMiejscowoscPocztyNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzMiejscowoscPocztySymbol] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizAdSiedzMiejscowoscPocztySymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzMiejscowoscSymbol] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizAdSiedzMiejscowoscSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzNietypoweMiejsceLokalizacji] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizAdSiedzNietypoweMiejsceLokalizacji]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzNumerLokalu] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizAdSiedzNumerLokalu]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzNumerNieruchomosci] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizAdSiedzNumerNieruchomosci]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzPowiatNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizAdSiedzPowiatNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzPowiatSymbol] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizAdSiedzPowiatSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzUlicaNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizAdSiedzUlicaNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzUlicaSymbol] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizAdSiedzUlicaSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzWojewodztwoNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizAdSiedzWojewodztwoNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizAdSiedzWojewodztwoSymbol] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizAdSiedzWojewodztwoSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizDataPowstania] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizDataPowstania]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizDataRozpoczeciaDzialalnosci] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizDataRozpoczeciaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizDataSkresleniaDzialalnosciZRegon] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizDataSkresleniaDzialalnosciZRegon]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizDataWpisuDzialalnosciDoRegon] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizDataWpisuDzialalnosciDoRegon]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizDataWznowieniaDzialalnosci] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizDataWznowieniaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizDataZaistnieniaZmianyDzialalnosci] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizDataZaistnieniaZmianyDzialalnosci]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizDataZakonczeniaDzialalnosci] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizDataZakonczeniaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizDataZawieszeniaDzialalnosci] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizDataZawieszeniaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizNazwa] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizNazwaSkrocona] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizNazwaSkrocona]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizNumerFaksu] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizNumerFaksu]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizNumerTelefonu] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizNumerTelefonu]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizNumerWewnetrznyTelefonu] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizNumerWewnetrznyTelefonu]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_FizRegon9] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([FizRegon9]);
GO

CREATE UNIQUE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_Id] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([Id]);
GO

CREATE INDEX [IX_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_UniqueIdentifierOfTheLoggedInUser] ON [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([UniqueIdentifierOfTheLoggedInUser]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_DaneSzukajPodmiotyId] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([DaneSzukajPodmiotyId]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_DaneSzukajPodmiotyKomunikatyOBledachId] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([DaneSzukajPodmiotyKomunikatyOBledachId]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_DaneSzukajPodmiotyParametryWyszukiwaniaId] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([DaneSzukajPodmiotyParametryWyszukiwaniaId]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_DateOfCreate] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([DateOfCreate]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_DateOfModification] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([DateOfModification]);
GO

CREATE UNIQUE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_Id] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([Id]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzGminaNazwa] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([LokfizAdSiedzGminaNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzGminaSymbol] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([LokfizAdSiedzGminaSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzKodPocztowy] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([LokfizAdSiedzKodPocztowy]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzKrajSymbol] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([LokfizAdSiedzKrajSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzMiejscowoscNazwa] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([LokfizAdSiedzMiejscowoscNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzMiejscowoscPocztyNazwa] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([LokfizAdSiedzMiejscowoscPocztyNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzMiejscowoscPocztySymbol] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([LokfizAdSiedzMiejscowoscPocztySymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzMiejscowoscSymbol] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([LokfizAdSiedzMiejscowoscSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzNietypoweMiejsceLokalizacji] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([LokfizAdSiedzNietypoweMiejsceLokalizacji]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzNumerLokalu] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([LokfizAdSiedzNumerLokalu]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzNumerNieruchomosci] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([LokfizAdSiedzNumerNieruchomosci]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzPowiatNazwa] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([LokfizAdSiedzPowiatNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzPowiatSymbol] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([LokfizAdSiedzPowiatSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzUlicaNazwa] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([LokfizAdSiedzUlicaNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzUlicaSymbol] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([LokfizAdSiedzUlicaSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzWojewodztwoNazwa] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([LokfizAdSiedzWojewodztwoNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_LokfizAdSiedzWojewodztwoSymbol] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([LokfizAdSiedzWojewodztwoSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_LokfizDataPowstania] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([LokfizDataPowstania]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_LokfizDataRozpoczeciaDzialalnosci] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([LokfizDataRozpoczeciaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_LokfizDataSkresleniaZRegon] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([LokfizDataSkresleniaZRegon]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_LokfizDataWpisuDoRegon] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([LokfizDataWpisuDoRegon]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_LokfizDataWznowieniaDzialalnosci] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([LokfizDataWznowieniaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_LokfizDataZakonczeniaDzialalnosci] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([LokfizDataZakonczeniaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_LokfizDataZawieszeniaDzialalnosci] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([LokfizDataZawieszeniaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_LokfizNazwa] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([LokfizNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_LokfizRegon14] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([LokfizRegon14]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_LokfizSilosID] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([LokfizSilosID]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_LokfizSilosSymbol] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([LokfizSilosSymbol]);
GO

CREATE INDEX [IX_BIR11OsFizycznaListaJednLokalnych_UniqueIdentifierOfTheLoggedInUser] ON [pagard].[BIR11OsFizycznaListaJednLokalnych] ([UniqueIdentifierOfTheLoggedInUser]);
GO

CREATE INDEX [IX_BIR11OsFizycznaPkd_DaneSzukajPodmiotyId] ON [pagard].[BIR11OsFizycznaPkd] ([DaneSzukajPodmiotyId]);
GO

CREATE INDEX [IX_BIR11OsFizycznaPkd_DaneSzukajPodmiotyKomunikatyOBledachId] ON [pagard].[BIR11OsFizycznaPkd] ([DaneSzukajPodmiotyKomunikatyOBledachId]);
GO

CREATE INDEX [IX_BIR11OsFizycznaPkd_DaneSzukajPodmiotyParametryWyszukiwaniaId] ON [pagard].[BIR11OsFizycznaPkd] ([DaneSzukajPodmiotyParametryWyszukiwaniaId]);
GO

CREATE INDEX [IX_BIR11OsFizycznaPkd_DateOfCreate] ON [pagard].[BIR11OsFizycznaPkd] ([DateOfCreate]);
GO

CREATE INDEX [IX_BIR11OsFizycznaPkd_DateOfModification] ON [pagard].[BIR11OsFizycznaPkd] ([DateOfModification]);
GO

CREATE INDEX [IX_BIR11OsFizycznaPkd_FizDataSkresleniaDzialalnosciZRegon] ON [pagard].[BIR11OsFizycznaPkd] ([FizDataSkresleniaDzialalnosciZRegon]);
GO

CREATE INDEX [IX_BIR11OsFizycznaPkd_FizPkdKod] ON [pagard].[BIR11OsFizycznaPkd] ([FizPkdKod]);
GO

CREATE INDEX [IX_BIR11OsFizycznaPkd_FizPkdNazwa] ON [pagard].[BIR11OsFizycznaPkd] ([FizPkdNazwa]);
GO

CREATE INDEX [IX_BIR11OsFizycznaPkd_FizPkdPrzewazajace] ON [pagard].[BIR11OsFizycznaPkd] ([FizPkdPrzewazajace]);
GO

CREATE INDEX [IX_BIR11OsFizycznaPkd_FizSilosID] ON [pagard].[BIR11OsFizycznaPkd] ([FizSilosID]);
GO

CREATE INDEX [IX_BIR11OsFizycznaPkd_FizSilosSymbol] ON [pagard].[BIR11OsFizycznaPkd] ([FizSilosSymbol]);
GO

CREATE UNIQUE INDEX [IX_BIR11OsFizycznaPkd_Id] ON [pagard].[BIR11OsFizycznaPkd] ([Id]);
GO

CREATE INDEX [IX_BIR11OsFizycznaPkd_UniqueIdentifierOfTheLoggedInUser] ON [pagard].[BIR11OsFizycznaPkd] ([UniqueIdentifierOfTheLoggedInUser]);
GO

CREATE INDEX [IX_BIR11OsPrawna_DaneSzukajPodmiotyKomunikatyOBledachId] ON [pagard].[BIR11OsPrawna] ([DaneSzukajPodmiotyKomunikatyOBledachId]);
GO

CREATE INDEX [IX_BIR11OsPrawna_DaneSzukajPodmiotyParametryWyszukiwaniaId] ON [pagard].[BIR11OsPrawna] ([DaneSzukajPodmiotyParametryWyszukiwaniaId]);
GO

CREATE INDEX [IX_BIR11OsPrawna_DateOfCreate] ON [pagard].[BIR11OsPrawna] ([DateOfCreate]);
GO

CREATE INDEX [IX_BIR11OsPrawna_DateOfModification] ON [pagard].[BIR11OsPrawna] ([DateOfModification]);
GO

CREATE UNIQUE INDEX [IX_BIR11OsPrawna_Id] ON [pagard].[BIR11OsPrawna] ([Id]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawAdresEmail] ON [pagard].[BIR11OsPrawna] ([PrawAdresEmail]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawAdresStronyinternetowej] ON [pagard].[BIR11OsPrawna] ([PrawAdresStronyinternetowej]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawAdSiedzGminaNazwa] ON [pagard].[BIR11OsPrawna] ([PrawAdSiedzGminaNazwa]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawAdSiedzGminaSymbol] ON [pagard].[BIR11OsPrawna] ([PrawAdSiedzGminaSymbol]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawAdSiedzKodPocztowy] ON [pagard].[BIR11OsPrawna] ([PrawAdSiedzKodPocztowy]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawAdSiedzKrajNazwa] ON [pagard].[BIR11OsPrawna] ([PrawAdSiedzKrajNazwa]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawAdSiedzKrajSymbol] ON [pagard].[BIR11OsPrawna] ([PrawAdSiedzKrajSymbol]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawAdSiedzMiejscowoscNazwa] ON [pagard].[BIR11OsPrawna] ([PrawAdSiedzMiejscowoscNazwa]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawAdSiedzMiejscowoscPocztyNazwa] ON [pagard].[BIR11OsPrawna] ([PrawAdSiedzMiejscowoscPocztyNazwa]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawAdSiedzMiejscowoscPocztySymbol] ON [pagard].[BIR11OsPrawna] ([PrawAdSiedzMiejscowoscPocztySymbol]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawAdSiedzMiejscowoscSymbol] ON [pagard].[BIR11OsPrawna] ([PrawAdSiedzMiejscowoscSymbol]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawAdSiedzNietypoweMiejsceLokalizacji] ON [pagard].[BIR11OsPrawna] ([PrawAdSiedzNietypoweMiejsceLokalizacji]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawAdSiedzNumerLokalu] ON [pagard].[BIR11OsPrawna] ([PrawAdSiedzNumerLokalu]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawAdSiedzNumerNieruchomosci] ON [pagard].[BIR11OsPrawna] ([PrawAdSiedzNumerNieruchomosci]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawAdSiedzPowiatNazwa] ON [pagard].[BIR11OsPrawna] ([PrawAdSiedzPowiatNazwa]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawAdSiedzPowiatSymbol] ON [pagard].[BIR11OsPrawna] ([PrawAdSiedzPowiatSymbol]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawAdSiedzUlicaNazwa] ON [pagard].[BIR11OsPrawna] ([PrawAdSiedzUlicaNazwa]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawAdSiedzUlicaSymbol] ON [pagard].[BIR11OsPrawna] ([PrawAdSiedzUlicaSymbol]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawAdSiedzWojewodztwoNazwa] ON [pagard].[BIR11OsPrawna] ([PrawAdSiedzWojewodztwoNazwa]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawAdSiedzWojewodztwoSymbol] ON [pagard].[BIR11OsPrawna] ([PrawAdSiedzWojewodztwoSymbol]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawDataOrzeczeniaOUpadlosci] ON [pagard].[BIR11OsPrawna] ([PrawDataOrzeczeniaOUpadlosci]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawDataPowstania] ON [pagard].[BIR11OsPrawna] ([PrawDataPowstania]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawDataRozpoczeciaDzialalnosci] ON [pagard].[BIR11OsPrawna] ([PrawDataRozpoczeciaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawDataSkresleniaZRegon] ON [pagard].[BIR11OsPrawna] ([PrawDataSkresleniaZRegon]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawDataWpisuDoRegon] ON [pagard].[BIR11OsPrawna] ([PrawDataWpisuDoRegon]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawDataWpisuDoRejestruEwidencji] ON [pagard].[BIR11OsPrawna] ([PrawDataWpisuDoRejestruEwidencji]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawDataWznowieniaDzialalnosci] ON [pagard].[BIR11OsPrawna] ([PrawDataWznowieniaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawDataZaistnieniaZmiany] ON [pagard].[BIR11OsPrawna] ([PrawDataZaistnieniaZmiany]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawDataZakonczeniaDzialalnosci] ON [pagard].[BIR11OsPrawna] ([PrawDataZakonczeniaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawDataZakonczeniaPostepowaniaUpadlosciowego] ON [pagard].[BIR11OsPrawna] ([PrawDataZakonczeniaPostepowaniaUpadlosciowego]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawDataZawieszeniaDzialalnosci] ON [pagard].[BIR11OsPrawna] ([PrawDataZawieszeniaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawFormaFinansowaniaNazwa] ON [pagard].[BIR11OsPrawna] ([PrawFormaFinansowaniaNazwa]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawFormaFinansowaniaSymbol] ON [pagard].[BIR11OsPrawna] ([PrawFormaFinansowaniaSymbol]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawFormaWlasnosciNazwa] ON [pagard].[BIR11OsPrawna] ([PrawFormaWlasnosciNazwa]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawFormaWlasnosciSymbol] ON [pagard].[BIR11OsPrawna] ([PrawFormaWlasnosciSymbol]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawLiczbaJednLokalnych] ON [pagard].[BIR11OsPrawna] ([PrawLiczbaJednLokalnych]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawNazwa] ON [pagard].[BIR11OsPrawna] ([PrawNazwa]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawNazwaSkrocona] ON [pagard].[BIR11OsPrawna] ([PrawNazwaSkrocona]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawNip] ON [pagard].[BIR11OsPrawna] ([PrawNip]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawNumerFaksu] ON [pagard].[BIR11OsPrawna] ([PrawNumerFaksu]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawNumerTelefonu] ON [pagard].[BIR11OsPrawna] ([PrawNumerTelefonu]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawNumerWewnetrznyTelefonu] ON [pagard].[BIR11OsPrawna] ([PrawNumerWewnetrznyTelefonu]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawNumerWRejestrzeEwidencji] ON [pagard].[BIR11OsPrawna] ([PrawNumerWRejestrzeEwidencji]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawOrganRejestrowyNazwa] ON [pagard].[BIR11OsPrawna] ([PrawOrganRejestrowyNazwa]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawOrganRejestrowySymbol] ON [pagard].[BIR11OsPrawna] ([PrawOrganRejestrowySymbol]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawOrganZalozycielskiNazwa] ON [pagard].[BIR11OsPrawna] ([PrawOrganZalozycielskiNazwa]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawOrganZalozycielskiSymbol] ON [pagard].[BIR11OsPrawna] ([PrawOrganZalozycielskiSymbol]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawPodstawowaFormaPrawnaNazwa] ON [pagard].[BIR11OsPrawna] ([PrawPodstawowaFormaPrawnaNazwa]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawPodstawowaFormaPrawnaSymbol] ON [pagard].[BIR11OsPrawna] ([PrawPodstawowaFormaPrawnaSymbol]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawRegon9] ON [pagard].[BIR11OsPrawna] ([PrawRegon9]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawRodzajRejestruEwidencjiNazwa] ON [pagard].[BIR11OsPrawna] ([PrawRodzajRejestruEwidencjiNazwa]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawRodzajRejestruEwidencjiSymbol] ON [pagard].[BIR11OsPrawna] ([PrawRodzajRejestruEwidencjiSymbol]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawStatusNip] ON [pagard].[BIR11OsPrawna] ([PrawStatusNip]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawSzczegolnaFormaPrawnaNazwa] ON [pagard].[BIR11OsPrawna] ([PrawSzczegolnaFormaPrawnaNazwa]);
GO

CREATE INDEX [IX_BIR11OsPrawna_PrawSzczegolnaFormaPrawnaSymbol] ON [pagard].[BIR11OsPrawna] ([PrawSzczegolnaFormaPrawnaSymbol]);
GO

CREATE INDEX [IX_BIR11OsPrawna_UniqueIdentifierOfTheLoggedInUser] ON [pagard].[BIR11OsPrawna] ([UniqueIdentifierOfTheLoggedInUser]);
GO

CREATE INDEX [IX_BIR11OsPrawnaListaJednLokalnych_DaneSzukajPodmiotyId] ON [pagard].[BIR11OsPrawnaListaJednLokalnych] ([DaneSzukajPodmiotyId]);
GO

CREATE INDEX [IX_BIR11OsPrawnaListaJednLokalnych_DaneSzukajPodmiotyKomunikatyOBledachId] ON [pagard].[BIR11OsPrawnaListaJednLokalnych] ([DaneSzukajPodmiotyKomunikatyOBledachId]);
GO

CREATE INDEX [IX_BIR11OsPrawnaListaJednLokalnych_DaneSzukajPodmiotyParametryWyszukiwaniaId] ON [pagard].[BIR11OsPrawnaListaJednLokalnych] ([DaneSzukajPodmiotyParametryWyszukiwaniaId]);
GO

CREATE INDEX [IX_BIR11OsPrawnaListaJednLokalnych_DateOfCreate] ON [pagard].[BIR11OsPrawnaListaJednLokalnych] ([DateOfCreate]);
GO

CREATE INDEX [IX_BIR11OsPrawnaListaJednLokalnych_DateOfModification] ON [pagard].[BIR11OsPrawnaListaJednLokalnych] ([DateOfModification]);
GO

CREATE UNIQUE INDEX [IX_BIR11OsPrawnaListaJednLokalnych_Id] ON [pagard].[BIR11OsPrawnaListaJednLokalnych] ([Id]);
GO

CREATE INDEX [IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzGminaNazwa] ON [pagard].[BIR11OsPrawnaListaJednLokalnych] ([LokprawAdSiedzGminaNazwa]);
GO

CREATE INDEX [IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzGminaSymbol] ON [pagard].[BIR11OsPrawnaListaJednLokalnych] ([LokprawAdSiedzGminaSymbol]);
GO

CREATE INDEX [IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzKodPocztowy] ON [pagard].[BIR11OsPrawnaListaJednLokalnych] ([LokprawAdSiedzKodPocztowy]);
GO

CREATE INDEX [IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzKrajSymbol] ON [pagard].[BIR11OsPrawnaListaJednLokalnych] ([LokprawAdSiedzKrajSymbol]);
GO

CREATE INDEX [IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzMiejscowoscNazwa] ON [pagard].[BIR11OsPrawnaListaJednLokalnych] ([LokprawAdSiedzMiejscowoscNazwa]);
GO

CREATE INDEX [IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzMiejscowoscPocztyNazwa] ON [pagard].[BIR11OsPrawnaListaJednLokalnych] ([LokprawAdSiedzMiejscowoscPocztyNazwa]);
GO

CREATE INDEX [IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzMiejscowoscPocztySymbol] ON [pagard].[BIR11OsPrawnaListaJednLokalnych] ([LokprawAdSiedzMiejscowoscPocztySymbol]);
GO

CREATE INDEX [IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzMiejscowoscSymbol] ON [pagard].[BIR11OsPrawnaListaJednLokalnych] ([LokprawAdSiedzMiejscowoscSymbol]);
GO

CREATE INDEX [IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzNietypoweMiejsceLokalizacji] ON [pagard].[BIR11OsPrawnaListaJednLokalnych] ([LokprawAdSiedzNietypoweMiejsceLokalizacji]);
GO

CREATE INDEX [IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzNumerLokalu] ON [pagard].[BIR11OsPrawnaListaJednLokalnych] ([LokprawAdSiedzNumerLokalu]);
GO

CREATE INDEX [IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzNumerNieruchomosci] ON [pagard].[BIR11OsPrawnaListaJednLokalnych] ([LokprawAdSiedzNumerNieruchomosci]);
GO

CREATE INDEX [IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzPowiatNazwa] ON [pagard].[BIR11OsPrawnaListaJednLokalnych] ([LokprawAdSiedzPowiatNazwa]);
GO

CREATE INDEX [IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzPowiatSymbol] ON [pagard].[BIR11OsPrawnaListaJednLokalnych] ([LokprawAdSiedzPowiatSymbol]);
GO

CREATE INDEX [IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzUlicaNazwa] ON [pagard].[BIR11OsPrawnaListaJednLokalnych] ([LokprawAdSiedzUlicaNazwa]);
GO

CREATE INDEX [IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzUlicaSymbol] ON [pagard].[BIR11OsPrawnaListaJednLokalnych] ([LokprawAdSiedzUlicaSymbol]);
GO

CREATE INDEX [IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzWojewodztwoNazwa] ON [pagard].[BIR11OsPrawnaListaJednLokalnych] ([LokprawAdSiedzWojewodztwoNazwa]);
GO

CREATE INDEX [IX_BIR11OsPrawnaListaJednLokalnych_LokprawAdSiedzWojewodztwoSymbol] ON [pagard].[BIR11OsPrawnaListaJednLokalnych] ([LokprawAdSiedzWojewodztwoSymbol]);
GO

CREATE INDEX [IX_BIR11OsPrawnaListaJednLokalnych_LokprawDataPowstania] ON [pagard].[BIR11OsPrawnaListaJednLokalnych] ([LokprawDataPowstania]);
GO

CREATE INDEX [IX_BIR11OsPrawnaListaJednLokalnych_LokprawDataRozpoczeciaDzialalnosci] ON [pagard].[BIR11OsPrawnaListaJednLokalnych] ([LokprawDataRozpoczeciaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11OsPrawnaListaJednLokalnych_LokprawDataSkresleniaZRegon] ON [pagard].[BIR11OsPrawnaListaJednLokalnych] ([LokprawDataSkresleniaZRegon]);
GO

CREATE INDEX [IX_BIR11OsPrawnaListaJednLokalnych_LokprawDataWpisuDoRegon] ON [pagard].[BIR11OsPrawnaListaJednLokalnych] ([LokprawDataWpisuDoRegon]);
GO

CREATE INDEX [IX_BIR11OsPrawnaListaJednLokalnych_LokprawDataWznowieniaDzialalnosci] ON [pagard].[BIR11OsPrawnaListaJednLokalnych] ([LokprawDataWznowieniaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11OsPrawnaListaJednLokalnych_LokprawDataZakonczeniaDzialalnosci] ON [pagard].[BIR11OsPrawnaListaJednLokalnych] ([LokprawDataZakonczeniaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11OsPrawnaListaJednLokalnych_LokprawDataZawieszeniaDzialalnosci] ON [pagard].[BIR11OsPrawnaListaJednLokalnych] ([LokprawDataZawieszeniaDzialalnosci]);
GO

CREATE INDEX [IX_BIR11OsPrawnaListaJednLokalnych_LokprawNazwa] ON [pagard].[BIR11OsPrawnaListaJednLokalnych] ([LokprawNazwa]);
GO

CREATE INDEX [IX_BIR11OsPrawnaListaJednLokalnych_LokprawRegon14] ON [pagard].[BIR11OsPrawnaListaJednLokalnych] ([LokprawRegon14]);
GO

CREATE INDEX [IX_BIR11OsPrawnaListaJednLokalnych_UniqueIdentifierOfTheLoggedInUser] ON [pagard].[BIR11OsPrawnaListaJednLokalnych] ([UniqueIdentifierOfTheLoggedInUser]);
GO

CREATE INDEX [IX_BIR11OsPrawnaPkd_DaneSzukajPodmiotyId] ON [pagard].[BIR11OsPrawnaPkd] ([DaneSzukajPodmiotyId]);
GO

CREATE INDEX [IX_BIR11OsPrawnaPkd_DaneSzukajPodmiotyKomunikatyOBledachId] ON [pagard].[BIR11OsPrawnaPkd] ([DaneSzukajPodmiotyKomunikatyOBledachId]);
GO

CREATE INDEX [IX_BIR11OsPrawnaPkd_DaneSzukajPodmiotyParametryWyszukiwaniaId] ON [pagard].[BIR11OsPrawnaPkd] ([DaneSzukajPodmiotyParametryWyszukiwaniaId]);
GO

CREATE INDEX [IX_BIR11OsPrawnaPkd_DateOfCreate] ON [pagard].[BIR11OsPrawnaPkd] ([DateOfCreate]);
GO

CREATE INDEX [IX_BIR11OsPrawnaPkd_DateOfModification] ON [pagard].[BIR11OsPrawnaPkd] ([DateOfModification]);
GO

CREATE UNIQUE INDEX [IX_BIR11OsPrawnaPkd_Id] ON [pagard].[BIR11OsPrawnaPkd] ([Id]);
GO

CREATE INDEX [IX_BIR11OsPrawnaPkd_PrawPkdKod] ON [pagard].[BIR11OsPrawnaPkd] ([PrawPkdKod]);
GO

CREATE INDEX [IX_BIR11OsPrawnaPkd_PrawPkdNazwa] ON [pagard].[BIR11OsPrawnaPkd] ([PrawPkdNazwa]);
GO

CREATE INDEX [IX_BIR11OsPrawnaPkd_PrawPkdPrzewazajace] ON [pagard].[BIR11OsPrawnaPkd] ([PrawPkdPrzewazajace]);
GO

CREATE INDEX [IX_BIR11OsPrawnaPkd_UniqueIdentifierOfTheLoggedInUser] ON [pagard].[BIR11OsPrawnaPkd] ([UniqueIdentifierOfTheLoggedInUser]);
GO

CREATE INDEX [IX_BIR11OsPrawnaSpCywilnaWspolnicy_DaneSzukajPodmiotyId] ON [pagard].[BIR11OsPrawnaSpCywilnaWspolnicy] ([DaneSzukajPodmiotyId]);
GO

CREATE INDEX [IX_BIR11OsPrawnaSpCywilnaWspolnicy_DaneSzukajPodmiotyKomunikatyOBledachId] ON [pagard].[BIR11OsPrawnaSpCywilnaWspolnicy] ([DaneSzukajPodmiotyKomunikatyOBledachId]);
GO

CREATE INDEX [IX_BIR11OsPrawnaSpCywilnaWspolnicy_DaneSzukajPodmiotyParametryWyszukiwaniaId] ON [pagard].[BIR11OsPrawnaSpCywilnaWspolnicy] ([DaneSzukajPodmiotyParametryWyszukiwaniaId]);
GO

CREATE INDEX [IX_BIR11OsPrawnaSpCywilnaWspolnicy_DateOfCreate] ON [pagard].[BIR11OsPrawnaSpCywilnaWspolnicy] ([DateOfCreate]);
GO

CREATE INDEX [IX_BIR11OsPrawnaSpCywilnaWspolnicy_DateOfModification] ON [pagard].[BIR11OsPrawnaSpCywilnaWspolnicy] ([DateOfModification]);
GO

CREATE UNIQUE INDEX [IX_BIR11OsPrawnaSpCywilnaWspolnicy_Id] ON [pagard].[BIR11OsPrawnaSpCywilnaWspolnicy] ([Id]);
GO

CREATE INDEX [IX_BIR11OsPrawnaSpCywilnaWspolnicy_UniqueIdentifierOfTheLoggedInUser] ON [pagard].[BIR11OsPrawnaSpCywilnaWspolnicy] ([UniqueIdentifierOfTheLoggedInUser]);
GO

CREATE INDEX [IX_BIR11OsPrawnaSpCywilnaWspolnicy_WspolscFirmaNazwa] ON [pagard].[BIR11OsPrawnaSpCywilnaWspolnicy] ([WspolscFirmaNazwa]);
GO

CREATE INDEX [IX_BIR11OsPrawnaSpCywilnaWspolnicy_WspolscImieDrugie] ON [pagard].[BIR11OsPrawnaSpCywilnaWspolnicy] ([WspolscImieDrugie]);
GO

CREATE INDEX [IX_BIR11OsPrawnaSpCywilnaWspolnicy_WspolscImiePierwsze] ON [pagard].[BIR11OsPrawnaSpCywilnaWspolnicy] ([WspolscImiePierwsze]);
GO

CREATE INDEX [IX_BIR11OsPrawnaSpCywilnaWspolnicy_WspolscNazwisko] ON [pagard].[BIR11OsPrawnaSpCywilnaWspolnicy] ([WspolscNazwisko]);
GO

CREATE INDEX [IX_BIR11OsPrawnaSpCywilnaWspolnicy_WspolscRegonWspolnikSpolki] ON [pagard].[BIR11OsPrawnaSpCywilnaWspolnicy] ([WspolscRegonWspolnikSpolki]);
GO

CREATE INDEX [IX_BIR11TypPodmiotu_DaneSzukajPodmiotyKomunikatyOBledachId] ON [pagard].[BIR11TypPodmiotu] ([DaneSzukajPodmiotyKomunikatyOBledachId]);
GO

CREATE INDEX [IX_BIR11TypPodmiotu_DaneSzukajPodmiotyParametryWyszukiwaniaId] ON [pagard].[BIR11TypPodmiotu] ([DaneSzukajPodmiotyParametryWyszukiwaniaId]);
GO

CREATE INDEX [IX_BIR11TypPodmiotu_DateOfCreate] ON [pagard].[BIR11TypPodmiotu] ([DateOfCreate]);
GO

CREATE INDEX [IX_BIR11TypPodmiotu_DateOfModification] ON [pagard].[BIR11TypPodmiotu] ([DateOfModification]);
GO

CREATE UNIQUE INDEX [IX_BIR11TypPodmiotu_Id] ON [pagard].[BIR11TypPodmiotu] ([Id]);
GO

CREATE INDEX [IX_BIR11TypPodmiotu_Typ] ON [pagard].[BIR11TypPodmiotu] ([Typ]);
GO

CREATE INDEX [IX_BIR11TypPodmiotu_UniqueIdentifierOfTheLoggedInUser] ON [pagard].[BIR11TypPodmiotu] ([UniqueIdentifierOfTheLoggedInUser]);
GO

CREATE INDEX [IX_DaneSzukajPodmiotyKomunikatyOBledach_DataModyfikacji] ON [pagard].[DaneSzukajPodmiotyKomunikatyOBledach] ([DataModyfikacji]);
GO

CREATE INDEX [IX_DaneSzukajPodmiotyKomunikatyOBledach_DataUtworzenia] ON [pagard].[DaneSzukajPodmiotyKomunikatyOBledach] ([DataUtworzenia]);
GO

CREATE UNIQUE INDEX [IX_DaneSzukajPodmiotyKomunikatyOBledach_Id] ON [pagard].[DaneSzukajPodmiotyKomunikatyOBledach] ([Id]);
GO

CREATE INDEX [IX_DaneSzukajPodmiotyKomunikatyOBledach_Krs] ON [pagard].[DaneSzukajPodmiotyKomunikatyOBledach] ([Krs]);
GO

CREATE INDEX [IX_DaneSzukajPodmiotyKomunikatyOBledach_Krsy] ON [pagard].[DaneSzukajPodmiotyKomunikatyOBledach] ([Krsy]);
GO

CREATE INDEX [IX_DaneSzukajPodmiotyKomunikatyOBledach_Nip] ON [pagard].[DaneSzukajPodmiotyKomunikatyOBledach] ([Nip]);
GO

CREATE INDEX [IX_DaneSzukajPodmiotyKomunikatyOBledach_Nipy] ON [pagard].[DaneSzukajPodmiotyKomunikatyOBledach] ([Nipy]);
GO

CREATE INDEX [IX_DaneSzukajPodmiotyKomunikatyOBledach_Regon] ON [pagard].[DaneSzukajPodmiotyKomunikatyOBledach] ([Regon]);
GO

CREATE INDEX [IX_DaneSzukajPodmiotyKomunikatyOBledach_Regony14zn] ON [pagard].[DaneSzukajPodmiotyKomunikatyOBledach] ([Regony14zn]);
GO

CREATE INDEX [IX_DaneSzukajPodmiotyKomunikatyOBledach_Regony9zn] ON [pagard].[DaneSzukajPodmiotyKomunikatyOBledach] ([Regony9zn]);
GO

CREATE INDEX [IX_DaneSzukajPodmiotyKomunikatyOBledach_UniqueIdentifierOfTheLoggedInUser] ON [pagard].[DaneSzukajPodmiotyKomunikatyOBledach] ([UniqueIdentifierOfTheLoggedInUser]);
GO

CREATE INDEX [IX_DaneSzukajPodmiotyMessageInspector_DaneSzukajPodmiotyId] ON [pagard].[DaneSzukajPodmiotyMessageInspector] ([DaneSzukajPodmiotyId]);
GO

CREATE INDEX [IX_DaneSzukajPodmiotyMessageInspector_MessageInspectorId] ON [pagard].[DaneSzukajPodmiotyMessageInspector] ([MessageInspectorId]);
GO

CREATE INDEX [IX_MessageInspector_DataModyfikacji] ON [pagard].[MessageInspector] ([DataModyfikacji]);
GO

CREATE INDEX [IX_MessageInspector_DataUtworzenia] ON [pagard].[MessageInspector] ([DataUtworzenia]);
GO

CREATE UNIQUE INDEX [IX_MessageInspector_Id] ON [pagard].[MessageInspector] ([Id]);
GO

CREATE INDEX [IX_MessageInspector_UniqueIdentifierOfTheLoggedInUser] ON [pagard].[MessageInspector] ([UniqueIdentifierOfTheLoggedInUser]);
GO

ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD CONSTRAINT [FK_DaneSzukajPodmioty_BIR11JednLokalnaOsFizycznej_BIR11JednLokalnaOsFizycznejId] FOREIGN KEY ([BIR11JednLokalnaOsFizycznejId]) REFERENCES [pagard].[BIR11JednLokalnaOsFizycznej] ([Id]) ON DELETE NO ACTION;
GO

ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD CONSTRAINT [FK_DaneSzukajPodmioty_BIR11JednLokalnaOsPrawnej_BIR11JednLokalnaOsPrawnejId] FOREIGN KEY ([BIR11JednLokalnaOsPrawnejId]) REFERENCES [pagard].[BIR11JednLokalnaOsPrawnej] ([Id]) ON DELETE NO ACTION;
GO

ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD CONSTRAINT [FK_DaneSzukajPodmioty_BIR11OsFizycznaDaneOgolne_BIR11OsFizycznaDaneOgolneId] FOREIGN KEY ([BIR11OsFizycznaDaneOgolneId]) REFERENCES [pagard].[BIR11OsFizycznaDaneOgolne] ([Id]) ON DELETE NO ACTION;
GO

ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD CONSTRAINT [FK_DaneSzukajPodmioty_BIR11OsFizycznaDzialalnoscCeidg_BIR11OsFizycznaDzialalnoscCeidgId] FOREIGN KEY ([BIR11OsFizycznaDzialalnoscCeidgId]) REFERENCES [pagard].[BIR11OsFizycznaDzialalnoscCeidg] ([Id]) ON DELETE NO ACTION;
GO

ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD CONSTRAINT [FK_DaneSzukajPodmioty_BIR11OsFizycznaDzialalnoscPozostala_BIR11OsFizycznaDzialalnoscPozostalaId] FOREIGN KEY ([BIR11OsFizycznaDzialalnoscPozostalaId]) REFERENCES [pagard].[BIR11OsFizycznaDzialalnoscPozostala] ([Id]) ON DELETE NO ACTION;
GO

ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD CONSTRAINT [FK_DaneSzukajPodmioty_BIR11OsFizycznaDzialalnoscRolnicza_BIR11OsFizycznaDzialalnoscRolniczaId] FOREIGN KEY ([BIR11OsFizycznaDzialalnoscRolniczaId]) REFERENCES [pagard].[BIR11OsFizycznaDzialalnoscRolnicza] ([Id]) ON DELETE NO ACTION;
GO

ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD CONSTRAINT [FK_DaneSzukajPodmioty_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108_BIR11OsFizycznaDzialalnoscSkreslonaDo20141108Id] FOREIGN KEY ([BIR11OsFizycznaDzialalnoscSkreslonaDo20141108Id]) REFERENCES [pagard].[BIR11OsFizycznaDzialalnoscSkreslonaDo20141108] ([Id]) ON DELETE NO ACTION;
GO

ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD CONSTRAINT [FK_DaneSzukajPodmioty_BIR11OsPrawna_BIR11OsPrawnaId] FOREIGN KEY ([BIR11OsPrawnaId]) REFERENCES [pagard].[BIR11OsPrawna] ([Id]) ON DELETE NO ACTION;
GO

ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD CONSTRAINT [FK_DaneSzukajPodmioty_BIR11TypPodmiotu_BIR11TypPodmiotuId] FOREIGN KEY ([BIR11TypPodmiotuId]) REFERENCES [pagard].[BIR11TypPodmiotu] ([Id]) ON DELETE NO ACTION;
GO

ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD CONSTRAINT [FK_DaneSzukajPodmioty_DaneSzukajPodmiotyKomunikatyOBledach_DaneSzukajPodmiotyKomunikatyOBledachId] FOREIGN KEY ([DaneSzukajPodmiotyKomunikatyOBledachId]) REFERENCES [pagard].[DaneSzukajPodmiotyKomunikatyOBledach] ([Id]) ON DELETE NO ACTION;
GO

ALTER TABLE [pagard].[DaneSzukajPodmioty] ADD CONSTRAINT [FK_DaneSzukajPodmioty_DaneSzukajPodmiotyParametryWyszukiwania_DaneSzukajPodmiotyParametryWyszukiwaniaId] FOREIGN KEY ([DaneSzukajPodmiotyParametryWyszukiwaniaId]) REFERENCES [pagard].[DaneSzukajPodmiotyParametryWyszukiwania] ([Id]) ON DELETE NO ACTION;
GO

INSERT INTO [pagard].[__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210406131010_3', N'5.0.4');
GO

COMMIT;
GO


