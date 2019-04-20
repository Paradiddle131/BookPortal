CREATE TABLE [dbo].[Review]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Category] NCHAR(30) NULL, 
    [BookName] NCHAR(30) NULL, 
    [ReviewType] NCHAR(30) NULL, 
    [BookSubject] NCHAR(30) NULL, 
    [BookAnalysis] NCHAR(999) NULL, 
    [AuthorName] NCHAR(30) NULL, 
    [OtherBooks] NCHAR(30) NULL
)
