SELECT  *
  FROM [TestDevelopment1].[dbo].[Enrollment]

DECLARE @cnt INT = 0;

WHILE @cnt < 12000
BEGIN   
   SET @cnt = @cnt + 1;
  INSERT [dbo].[Enrollment] ([CourseID], [Grade], [StudentID]) VALUES (@cnt, 1, @cnt)   
END;

PRINT 'Loop finished';
GO