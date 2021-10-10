CREATE DATABASE Reminder_Dev;
GO

USE Reminder_Dev;
GO

CREATE TABLE [dbo].[UtilTests]
(
	[UtilTestId] [bigint] IDENTITY(1,1) NOT NULL CONSTRAINT PK_UtilTests PRIMARY KEY NONCLUSTERED,
	[Description] [varchar](100) NOT NULL
)
GO