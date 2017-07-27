SELECT  *
  FROM [TestDevelopment1].[dbo].[Course]

DECLARE @cnt INT = 0;

WHILE @cnt < 12000
BEGIN   
   SET @cnt = @cnt + 1;
   if(@cnt not in(1045,1050,2021,2042,3141,4022,4041))
   Begin
   INSERT [dbo].[Course] ([CourseID], [Credits], [Title], [DepartmentID]) VALUES (@cnt, @cnt, N'Calculus', @cnt)   
   End
END;

PRINT 'Loop finished';
GO

