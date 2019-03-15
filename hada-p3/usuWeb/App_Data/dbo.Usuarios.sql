﻿CREATE TABLE [dbo].[Usuarios]
(

	[id] INT IDENTITY (1, 1) NOT NULL, 
    [nombre] NVARCHAR(32) NOT NULL, 
    [nif] NCHAR(16) NOT NULL, 
    [edad] INT NOT NULL,
	PRIMARY KEY CLUSTERED ([id] ASC),
	UNIQUE NONCLUSTERED ([nif] ASC)
)

