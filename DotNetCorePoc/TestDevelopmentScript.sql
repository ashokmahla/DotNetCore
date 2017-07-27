create database TestDevelopment
GO
USE [TestDevelopment]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 26-05-2017 18:34:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Course]    Script Date: 26-05-2017 18:34:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[CourseID] [int] NOT NULL,
	[Credits] [int] NOT NULL,
	[Title] [nvarchar](50) NULL,
	[DepartmentID] [int] NOT NULL DEFAULT ((1)),
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CourseAssignment]    Script Date: 26-05-2017 18:34:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CourseAssignment](
	[CourseID] [int] NOT NULL,
	[InstructorID] [int] NOT NULL,
 CONSTRAINT [PK_CourseAssignment] PRIMARY KEY CLUSTERED 
(
	[CourseID] ASC,
	[InstructorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Department]    Script Date: 26-05-2017 18:34:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[DepartmentID] [int] IDENTITY(1,1) NOT NULL,
	[Budget] [money] NOT NULL,
	[InstructorID] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[StartDate] [datetime2](7) NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[DepartmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Enrollment]    Script Date: 26-05-2017 18:34:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Enrollment](
	[EnrollmentID] [int] IDENTITY(1,1) NOT NULL,
	[CourseID] [int] NOT NULL,
	[Grade] [int] NULL,
	[StudentID] [int] NOT NULL,
 CONSTRAINT [PK_Enrollment] PRIMARY KEY CLUSTERED 
(
	[EnrollmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OfficeAssignment]    Script Date: 26-05-2017 18:34:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OfficeAssignment](
	[InstructorID] [int] NOT NULL,
	[Location] [nvarchar](50) NULL,
 CONSTRAINT [PK_OfficeAssignment] PRIMARY KEY CLUSTERED 
(
	[InstructorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Person]    Script Date: 26-05-2017 18:34:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[HireDate] [datetime2](7) NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[EnrollmentDate] [datetime2](7) NULL,
	[Discriminator] [nvarchar](128) NOT NULL DEFAULT (N'Instructor'),
 CONSTRAINT [PK_Instructor] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170315162752_InitialCreate', N'1.1.1')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170315171054_MaxLengthOnNames', N'1.1.1')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170315171146_ColummFirstName', N'1.1.1')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170315171607_ComplexDataModel', N'1.1.1')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170315183847_RowVersion', N'1.1.1')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170315190150_Inheritance', N'1.1.1')
INSERT [dbo].[Course] ([CourseID], [Credits], [Title], [DepartmentID]) VALUES (1045, 4, N'Calculus', 3)
INSERT [dbo].[Course] ([CourseID], [Credits], [Title], [DepartmentID]) VALUES (1050, 3, N'Chemistry', 4)
INSERT [dbo].[Course] ([CourseID], [Credits], [Title], [DepartmentID]) VALUES (2021, 3, N'Composition', 2)
INSERT [dbo].[Course] ([CourseID], [Credits], [Title], [DepartmentID]) VALUES (2042, 4, N'Literature', 2)
INSERT [dbo].[Course] ([CourseID], [Credits], [Title], [DepartmentID]) VALUES (3141, 4, N'Trigonometry', 3)
INSERT [dbo].[Course] ([CourseID], [Credits], [Title], [DepartmentID]) VALUES (4022, 3, N'Microeconomics', 5)
INSERT [dbo].[Course] ([CourseID], [Credits], [Title], [DepartmentID]) VALUES (4041, 3, N'Macroeconomics', 5)
INSERT [dbo].[CourseAssignment] ([CourseID], [InstructorID]) VALUES (2021, 9)
INSERT [dbo].[CourseAssignment] ([CourseID], [InstructorID]) VALUES (2042, 9)
INSERT [dbo].[CourseAssignment] ([CourseID], [InstructorID]) VALUES (1045, 10)
INSERT [dbo].[CourseAssignment] ([CourseID], [InstructorID]) VALUES (1050, 11)
INSERT [dbo].[CourseAssignment] ([CourseID], [InstructorID]) VALUES (3141, 11)
INSERT [dbo].[CourseAssignment] ([CourseID], [InstructorID]) VALUES (1050, 12)
INSERT [dbo].[CourseAssignment] ([CourseID], [InstructorID]) VALUES (4022, 13)
INSERT [dbo].[CourseAssignment] ([CourseID], [InstructorID]) VALUES (4041, 13)
SET IDENTITY_INSERT [dbo].[Department] ON 

INSERT [dbo].[Department] ([DepartmentID], [Budget], [InstructorID], [Name], [StartDate]) VALUES (1, 0.0000, NULL, N'Temp', CAST(N'2017-05-26 18:16:47.9333333' AS DateTime2))
INSERT [dbo].[Department] ([DepartmentID], [Budget], [InstructorID], [Name], [StartDate]) VALUES (2, 350000.0000, 9, N'English', CAST(N'2007-09-01 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Department] ([DepartmentID], [Budget], [InstructorID], [Name], [StartDate]) VALUES (3, 100000.0000, 10, N'Mathematics', CAST(N'2007-09-01 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Department] ([DepartmentID], [Budget], [InstructorID], [Name], [StartDate]) VALUES (4, 350000.0000, 11, N'Engineering', CAST(N'2007-09-01 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Department] ([DepartmentID], [Budget], [InstructorID], [Name], [StartDate]) VALUES (5, 100000.0000, 12, N'Economics', CAST(N'2007-09-01 00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Department] OFF
SET IDENTITY_INSERT [dbo].[Enrollment] ON 

INSERT [dbo].[Enrollment] ([EnrollmentID], [CourseID], [Grade], [StudentID]) VALUES (1, 1050, 0, 1)
INSERT [dbo].[Enrollment] ([EnrollmentID], [CourseID], [Grade], [StudentID]) VALUES (2, 4022, 2, 1)
INSERT [dbo].[Enrollment] ([EnrollmentID], [CourseID], [Grade], [StudentID]) VALUES (3, 4041, 1, 1)
INSERT [dbo].[Enrollment] ([EnrollmentID], [CourseID], [Grade], [StudentID]) VALUES (4, 1045, 1, 2)
INSERT [dbo].[Enrollment] ([EnrollmentID], [CourseID], [Grade], [StudentID]) VALUES (5, 3141, 1, 2)
INSERT [dbo].[Enrollment] ([EnrollmentID], [CourseID], [Grade], [StudentID]) VALUES (6, 2021, 1, 2)
INSERT [dbo].[Enrollment] ([EnrollmentID], [CourseID], [Grade], [StudentID]) VALUES (7, 1050, NULL, 3)
INSERT [dbo].[Enrollment] ([EnrollmentID], [CourseID], [Grade], [StudentID]) VALUES (8, 4022, 1, 3)
INSERT [dbo].[Enrollment] ([EnrollmentID], [CourseID], [Grade], [StudentID]) VALUES (9, 1050, 1, 4)
INSERT [dbo].[Enrollment] ([EnrollmentID], [CourseID], [Grade], [StudentID]) VALUES (10, 2021, 1, 5)
INSERT [dbo].[Enrollment] ([EnrollmentID], [CourseID], [Grade], [StudentID]) VALUES (11, 2042, 1, 6)
SET IDENTITY_INSERT [dbo].[Enrollment] OFF
INSERT [dbo].[OfficeAssignment] ([InstructorID], [Location]) VALUES (10, N'Smith 17')
INSERT [dbo].[OfficeAssignment] ([InstructorID], [Location]) VALUES (11, N'Gowan 27')
INSERT [dbo].[OfficeAssignment] ([InstructorID], [Location]) VALUES (12, N'Thompson 304')
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([ID], [FirstName], [HireDate], [LastName], [EnrollmentDate], [Discriminator]) VALUES (1, N'Carson', NULL, N'Alexander', CAST(N'2010-09-01 00:00:00.0000000' AS DateTime2), N'Student')
INSERT [dbo].[Person] ([ID], [FirstName], [HireDate], [LastName], [EnrollmentDate], [Discriminator]) VALUES (2, N'Meredith', NULL, N'Alonso', CAST(N'2012-09-01 00:00:00.0000000' AS DateTime2), N'Student')
INSERT [dbo].[Person] ([ID], [FirstName], [HireDate], [LastName], [EnrollmentDate], [Discriminator]) VALUES (3, N'Arturo', NULL, N'Anand', CAST(N'2013-09-01 00:00:00.0000000' AS DateTime2), N'Student')
INSERT [dbo].[Person] ([ID], [FirstName], [HireDate], [LastName], [EnrollmentDate], [Discriminator]) VALUES (4, N'Gytis', NULL, N'Barzdukas', CAST(N'2012-09-01 00:00:00.0000000' AS DateTime2), N'Student')
INSERT [dbo].[Person] ([ID], [FirstName], [HireDate], [LastName], [EnrollmentDate], [Discriminator]) VALUES (5, N'Yan', NULL, N'Li', CAST(N'2012-09-01 00:00:00.0000000' AS DateTime2), N'Student')
INSERT [dbo].[Person] ([ID], [FirstName], [HireDate], [LastName], [EnrollmentDate], [Discriminator]) VALUES (6, N'Peggy', NULL, N'Justice', CAST(N'2011-09-01 00:00:00.0000000' AS DateTime2), N'Student')
INSERT [dbo].[Person] ([ID], [FirstName], [HireDate], [LastName], [EnrollmentDate], [Discriminator]) VALUES (7, N'Laura', NULL, N'Norman', CAST(N'2013-09-01 00:00:00.0000000' AS DateTime2), N'Student')
INSERT [dbo].[Person] ([ID], [FirstName], [HireDate], [LastName], [EnrollmentDate], [Discriminator]) VALUES (8, N'Nino', NULL, N'Olivetto', CAST(N'2005-09-01 00:00:00.0000000' AS DateTime2), N'Student')
INSERT [dbo].[Person] ([ID], [FirstName], [HireDate], [LastName], [EnrollmentDate], [Discriminator]) VALUES (9, N'Kim', CAST(N'1995-03-11 00:00:00.0000000' AS DateTime2), N'Abercrombie', NULL, N'Instructor')
INSERT [dbo].[Person] ([ID], [FirstName], [HireDate], [LastName], [EnrollmentDate], [Discriminator]) VALUES (10, N'Fadi', CAST(N'2002-07-06 00:00:00.0000000' AS DateTime2), N'Fakhouri', NULL, N'Instructor')
INSERT [dbo].[Person] ([ID], [FirstName], [HireDate], [LastName], [EnrollmentDate], [Discriminator]) VALUES (11, N'Roger', CAST(N'1998-07-01 00:00:00.0000000' AS DateTime2), N'Harui', NULL, N'Instructor')
INSERT [dbo].[Person] ([ID], [FirstName], [HireDate], [LastName], [EnrollmentDate], [Discriminator]) VALUES (12, N'Candace', CAST(N'2001-01-15 00:00:00.0000000' AS DateTime2), N'Kapoor', NULL, N'Instructor')
INSERT [dbo].[Person] ([ID], [FirstName], [HireDate], [LastName], [EnrollmentDate], [Discriminator]) VALUES (13, N'Roger', CAST(N'2004-02-12 00:00:00.0000000' AS DateTime2), N'Zheng', NULL, N'Instructor')
SET IDENTITY_INSERT [dbo].[Person] OFF
ALTER TABLE [dbo].[Course]  WITH CHECK ADD  CONSTRAINT [FK_Course_Department_DepartmentID] FOREIGN KEY([DepartmentID])
REFERENCES [dbo].[Department] ([DepartmentID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Course] CHECK CONSTRAINT [FK_Course_Department_DepartmentID]
GO
ALTER TABLE [dbo].[CourseAssignment]  WITH CHECK ADD  CONSTRAINT [FK_CourseAssignment_Course_CourseID] FOREIGN KEY([CourseID])
REFERENCES [dbo].[Course] ([CourseID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CourseAssignment] CHECK CONSTRAINT [FK_CourseAssignment_Course_CourseID]
GO
ALTER TABLE [dbo].[CourseAssignment]  WITH CHECK ADD  CONSTRAINT [FK_CourseAssignment_Instructor_InstructorID] FOREIGN KEY([InstructorID])
REFERENCES [dbo].[Person] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CourseAssignment] CHECK CONSTRAINT [FK_CourseAssignment_Instructor_InstructorID]
GO
ALTER TABLE [dbo].[Department]  WITH CHECK ADD  CONSTRAINT [FK_Department_Instructor_InstructorID] FOREIGN KEY([InstructorID])
REFERENCES [dbo].[Person] ([ID])
GO
ALTER TABLE [dbo].[Department] CHECK CONSTRAINT [FK_Department_Instructor_InstructorID]
GO
ALTER TABLE [dbo].[Enrollment]  WITH CHECK ADD  CONSTRAINT [FK_Enrollment_Course_CourseID] FOREIGN KEY([CourseID])
REFERENCES [dbo].[Course] ([CourseID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Enrollment] CHECK CONSTRAINT [FK_Enrollment_Course_CourseID]
GO
ALTER TABLE [dbo].[Enrollment]  WITH CHECK ADD  CONSTRAINT [FK_Enrollment_Person_StudentID] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Person] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Enrollment] CHECK CONSTRAINT [FK_Enrollment_Person_StudentID]
GO
ALTER TABLE [dbo].[OfficeAssignment]  WITH CHECK ADD  CONSTRAINT [FK_OfficeAssignment_Instructor_InstructorID] FOREIGN KEY([InstructorID])
REFERENCES [dbo].[Person] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OfficeAssignment] CHECK CONSTRAINT [FK_OfficeAssignment_Instructor_InstructorID]
GO
