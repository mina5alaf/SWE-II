CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Password] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    [Fullname] NVARCHAR(50) NOT NULL, 
    [Username] NVARCHAR(50) NOT NULL
)
