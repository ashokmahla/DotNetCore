SELECT  *
  FROM [TestDevelopment1].[dbo].[Department]

DECLARE @cnt INT = 4;
DECLARE @budget Money = 45000;
DECLARE @instructorId INT = 0;

WHILE @cnt < 12000
BEGIN   
   SET @cnt = @cnt + 1;
   SET @budget = @budget + 1;
    SET @instructorId = @instructorId + 1;
   if(@cnt != 17762 and @cnt != 17763 and  @cnt != 17764)
   Begin
  INSERT [dbo].[Department] ([Budget], [InstructorID], [Name], [StartDate]) VALUES (@budget, @instructorId, N'Economics', CAST(N'2007-09-01 00:00:00.0000000' AS DateTime2))  
   End
END;

PRINT 'Loop finished';
GO

