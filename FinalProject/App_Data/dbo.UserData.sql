CREATE TABLE [dbo].[Table]
(
	[ID] INT NOT NULL PRIMARY KEY, 
    [Username] NCHAR(20) NOT NULL, 
    [Firstname] NCHAR(20) NOT NULL, 
    [Lastname] NCHAR(20) NOT NULL, 
    [Email] NCHAR(50) NOT NULL, 
    [Password] NCHAR(20) NOT NULL, 
    [Gender] NCHAR(10) NOT NULL
)
