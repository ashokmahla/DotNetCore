SELECT  *
  FROM [TestDevelopment1].[dbo].[CourseAssignment]

DECLARE @cnt INT = 0;

WHILE @cnt < 12000
BEGIN   
   SET @cnt = @cnt + 1;
   INSERT [dbo].[CourseAssignment] ([CourseID], [InstructorID]) VALUES (@cnt, @cnt)    
END;

PRINT 'Loop finished';
GO