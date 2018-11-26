CREATE TABLE [dbo].[Submissions] (
    [Id]                INT           IDENTITY (1, 1) NOT NULL,
    [FileSpecification] VARCHAR (50)  NULL,
    [DueDate]           DATETIME2 (7) NULL,
    [AssignedUser] VARCHAR(50) NULL, 
    [SubmissionState] INT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

