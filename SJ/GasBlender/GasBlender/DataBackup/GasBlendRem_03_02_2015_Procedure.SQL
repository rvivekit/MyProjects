USE [gasblend]
GO
/****** Object:  StoredProcedure [dbo].[BOLLog]    Script Date: 3/2/2015 11:56:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BOLLog]
(
	@startDate DATE,
	@endDate Date
)
AS
	SET NOCOUNT ON;
 SELECT locationTBL.locationName, lineTBL.RAdd, lineTBL.CType, lineTBL.CAmount, 
 loadTBL.stamp, lineTBL.EAdd, loadTBL.refNum, lineTBL.loadID, loadTBL.loadID, lineTBL.SAdd
 FROM   (locationTBL locationTBL 
 INNER JOIN lineTBL lineTBL ON locationTBL.locationID=lineTBL.CLocationID) 
 INNER JOIN loadTBL loadTBL ON lineTBL.loadID=loadTBL.loadID
 WHERE stamp BETWEEN @startDate AND @endDate
 ORDER BY loadTBL.stamp,lineTBL.loadID

GO
/****** Object:  StoredProcedure [dbo].[GetBOL]    Script Date: 3/2/2015 11:56:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetBOL]
(
	@LoadTableID bigint
)
AS
	SET NOCOUNT ON;
SELECT        lineTBL.CAmount, lineTBL.CType, lineTBL.EAdd, loadTBL.driver, loadTBL.loadType, lineTBL.RAdd, loadTBL.loadID, lineTBL.SAdd, trailerTBL.trailerNumber, 
                         loadTBL.truck, loadTBL.refNum, loadTBL.stamp, lineTBL.CLocationID, locationTBL.locationName, locationTBL.address, locationTBL.city, locationTBL.state, 
                         locationTBL.zip, carrierTBL.tollNumber, carrierTBL.localContactName, carrierTBL.localContactNumber, carrierTBL.name, lineTBL.compartment, loadTBL.note, 
                         lineTBL.combined
FROM            locationTBL AS locationTBL INNER JOIN
                         lineTBL AS lineTBL ON locationTBL.locationID = lineTBL.CLocationID INNER JOIN
                         loadTBL AS loadTBL ON lineTBL.loadID = loadTBL.loadID INNER JOIN
                         trailerTBL AS trailerTBL ON loadTBL.trailerID = trailerTBL.trailerID INNER JOIN
                         carrierTBL AS carrierTBL ON loadTBL.carrierID = carrierTBL.carrierID
WHERE        (loadTBL.loadID = @LoadTableID)
ORDER BY lineTBL.CLocationID

GO
/****** Object:  StoredProcedure [dbo].[SelectCarrier]    Script Date: 3/2/2015 11:56:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectCarrier]
	/*
	(
	@parameter1 int = 5,
	@parameter2 datatype OUTPUT
	)
	*/
AS
	SELECT        carrierTBL.*
FROM            carrierTBL
	RETURN


GO
/****** Object:  Table [dbo].[logTBL]    Script Date: 3/2/2015 11:56:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[logTBL](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [varchar](50) NULL,
	[Action] [varchar](500) NULL,
	[Page] [varchar](50) NULL,
	[DateCreated] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[userTBL]    Script Date: 3/2/2015 11:56:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[userTBL](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](500) NULL,
	[Name] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[IsAdmin] [bit] NULL,
	[DateCreated] [datetime] NULL,
 CONSTRAINT [PK_userTBL] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[logTBL] ON 

GO
GO
SET IDENTITY_INSERT [dbo].[logTBL] OFF
GO
SET IDENTITY_INSERT [dbo].[userTBL] ON 

GO
INSERT [dbo].[userTBL] ([ID], [Username], [Password], [Name], [Email], [IsAdmin], [DateCreated]) VALUES (5, N'admin', N'z8jVioTaXkzaan284HKbBxM9YoUOk8Qm+lEM6ms6jrA=', N'Administrator', N'vramalingam@smokinjoe.com', 1, CAST(0x0000A44900E556EA AS DateTime))
GO
INSERT [dbo].[userTBL] ([ID], [Username], [Password], [Name], [Email], [IsAdmin], [DateCreated]) VALUES (7, N'mike', N'dIJI52Yz5AkxIIb50lxXEA==', N'Mike', N'', 0, CAST(0x0000A44B00FD390A AS DateTime))
GO
INSERT [dbo].[userTBL] ([ID], [Username], [Password], [Name], [Email], [IsAdmin], [DateCreated]) VALUES (6, N'vramalingam', N'a8EzTdJAvPjqo0j3Xrr9B3MjmWCOdP/RozmhPMiwuwg=', N'Vivekanandan Ramalingam', N'vramalingam@smokinjoe.com', 1, CAST(0x0000A44A00EE5425 AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[userTBL] OFF
GO
