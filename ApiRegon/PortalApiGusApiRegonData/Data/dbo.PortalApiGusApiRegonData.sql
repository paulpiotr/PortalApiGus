﻿CREATE TABLE [dbo].[PortalApiGusApiRegonData] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [Name]           NVARCHAR (128) NOT NULL,
    [Description]    NVARCHAR (MAX) NOT NULL,
    [PricePerClick]  MONEY          NULL,
    [NumberOfClicks] INT            NULL,
    [TotalCost]      MONEY          NULL,
    [Created]        DATETIME       NULL,
    [Modified]       DATETIME       NULL,
    CONSTRAINT [PK_dbo.PortalApiGusApiRegonData] PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

ALTER TABLE [dbo].[PortalApiGusApiRegonData] ADD CONSTRAINT [DF_PortalApiGusApiRegonData_Created]  DEFAULT (getdate()) FOR [Created]
GO

CREATE TRIGGER [dbo].[Trigger_PortalApiGusApiRegonData]
ON [dbo].[PortalApiGusApiRegonData]
AFTER INSERT, UPDATE
AS
BEGIN
	IF EXISTS (SELECT I.Id from inserted I)
	BEGIN
		UPDATE [dbo].[PortalApiGusApiRegonData]
		SET TotalCost = (inserted.NumberOfClicks * inserted.PricePerClick), Modified = getdate()
		FROM Inserted
		WHERE [dbo].[PortalApiGusApiRegonData].Id = inserted.Id
	END
END
GO

CREATE TRIGGER [dbo].[Trigger_PortalApiGusApiRegonDataAudit]
ON [dbo].[PortalApiGusApiRegonData]
AFTER UPDATE, INSERT, DELETE
AS
BEGIN
    SET NoCount ON;
	DECLARE @AuditAction AS nvarchar(16) = 'Insert';
	IF EXISTS(SELECT * FROM DELETED)
	BEGIN
		SET @AuditAction = CASE WHEN EXISTS(SELECT * FROM INSERTED) THEN 'Update' ELSE 'Delete' END
	END
	IF (@AuditAction = 'Insert' OR @AuditAction = 'Update')
	BEGIN
		INSERT INTO [dbo].[PortalApiGusApiRegonDataAudit] ([PK] ,[JsonData] ,[UserName] ,[AuditDate] ,[AuditAction] ,[AuditIP])
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
		INSERT INTO [dbo].[PortalApiGusApiRegonDataAudit] ([PK] ,[JsonData] ,[UserName] ,[AuditDate] ,[AuditAction] ,[AuditIP])
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