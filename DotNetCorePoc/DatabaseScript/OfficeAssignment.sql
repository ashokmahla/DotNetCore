/****** Script for SelectTopNRows command from SSMS  ******/
SELECT  *
  FROM [TestDevelopment1].[dbo].[OfficeAssignment]

DECLARE @cnt INT = 0;

WHILE @cnt < 12000
BEGIN   
   SET @cnt = @cnt + 1;
   if(@cnt != 17762 and @cnt != 17763 and  @cnt != 17764)
   Begin
   insert into OfficeAssignment values(@cnt,'test'+ CAST(@cnt AS VARCHAR))
   End
END;

PRINT 'Loop finished';
GO