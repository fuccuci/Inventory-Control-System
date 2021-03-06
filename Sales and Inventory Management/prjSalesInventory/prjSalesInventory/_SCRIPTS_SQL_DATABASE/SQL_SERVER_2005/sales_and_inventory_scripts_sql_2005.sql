USE [SaleInv_DB]
GO
/****** Object:  Table [dbo].[TBL_Users]    Script Date: 04/17/2011 02:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Users](
	[User_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](max) NULL,
	[UserPass] [varchar](max) NULL,
	[Access_Type] [varchar](50) NULL,
	[lastname] [varchar](50) NULL,
	[firstname] [varchar](50) NULL,
	[middlename] [varchar](50) NULL,
	[address] [varchar](50) NULL,
	[contact] [varchar](50) NULL,
	[local_number] [varchar](50) NULL,
 CONSTRAINT [PK_TBL_Users] PRIMARY KEY CLUSTERED 
(
	[User_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Users] ON
INSERT [dbo].[TBL_Users] ([User_ID], [Username], [UserPass], [Access_Type], [lastname], [firstname], [middlename], [address], [contact], [local_number]) VALUES (9, N'admin', N'admin', N'Administrator', N'admin', N'admin', N'admin', N'admin', N'1234', N'1')
INSERT [dbo].[TBL_Users] ([User_ID], [Username], [UserPass], [Access_Type], [lastname], [firstname], [middlename], [address], [contact], [local_number]) VALUES (12, N'cashier', N'cashier', N'Cashier', N'cashier', N'cashier', N'cashier', N'cashier', N'1234', NULL)
INSERT [dbo].[TBL_Users] ([User_ID], [Username], [UserPass], [Access_Type], [lastname], [firstname], [middlename], [address], [contact], [local_number]) VALUES (13, N'stock', N'stock', N'Stock Room', N'stock', N'stock', N'stock', N'stock', N'123213', N'3')
INSERT [dbo].[TBL_Users] ([User_ID], [Username], [UserPass], [Access_Type], [lastname], [firstname], [middlename], [address], [contact], [local_number]) VALUES (14, N'sales', N'sales', N'Sales Agent', N'sales', N'agent', N'agent', N'agent', N'123445', NULL)
SET IDENTITY_INSERT [dbo].[TBL_Users] OFF
/****** Object:  Table [dbo].[TBL_Unit_Measure]    Script Date: 04/17/2011 02:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Unit_Measure](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Code] [text] NULL,
	[Description] [text] NULL,
 CONSTRAINT [PK_TBL_Unit_Measure] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TBL_Unit_Measure] ON
INSERT [dbo].[TBL_Unit_Measure] ([ID], [Code], [Description]) VALUES (1, N'PC', N'Piece(s)')
INSERT [dbo].[TBL_Unit_Measure] ([ID], [Code], [Description]) VALUES (2, N'Bx', N'Box(s)')
INSERT [dbo].[TBL_Unit_Measure] ([ID], [Code], [Description]) VALUES (5, N'Sk', N'Sack(s)')
INSERT [dbo].[TBL_Unit_Measure] ([ID], [Code], [Description]) VALUES (6, N'L', N'Liter(s)')
INSERT [dbo].[TBL_Unit_Measure] ([ID], [Code], [Description]) VALUES (7, N'G', N'Gallon(s)')
SET IDENTITY_INSERT [dbo].[TBL_Unit_Measure] OFF
/****** Object:  Table [dbo].[TBL_Suppliers_Product]    Script Date: 04/17/2011 02:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Suppliers_Product](
	[Prod_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Supp_ID] [bigint] NULL,
	[Item_ID] [bigint] NULL,
	[Prod_Name] [varchar](max) NULL,
	[Item_Price] [money] NULL,
	[Catg_ID] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Suppliers_Product] ON
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (123, 5, 1, N'Bumper Support', 168.0000, 1)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (124, 5, 2, N'Bumper Support', 168.0000, 1)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (125, 5, 3, N'Center Bearing Assembly', 757.1200, 2)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (126, 5, 4, N'Center Bearing Assembly', 476.0000, 2)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (127, 5, 5, N'Engine Support', 162.4000, 3)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (128, 5, 6, N'Engine Support', 162.4000, 3)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (129, 5, 7, N'Engine Support', 392.0000, 3)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (130, 5, 8, N'Shock Absorber Mounting', 448.0000, 4)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (86, 4, 9, N'ATF Dexron III', 229.6000, 5)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (87, 4, 10, N'Common Rail', 252.0000, 5)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (88, 4, 12, N'Common Rail (G)', 1085.2800, 5)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (89, 4, 13, N'Speed Max 430 (G)', 1435.8400, 5)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (90, 4, 11, N'Speed Max 430', 285.6000, 5)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (79, 1, 19, N'Auto Bulb "Narva"', 13.4400, 8)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (80, 1, 20, N'Auto Bulb "Narva"', 19.0400, 8)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (81, 1, 14, N'Halogen Bulb "Narva"', 201.6000, 6)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (82, 1, 15, N'Halogen Bulb "Narva"', 151.2000, 6)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (83, 1, 16, N'Halogen Bulb "Narva"', 100.8000, 6)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (84, 1, 17, N'Halogen Bulb "Narva"', 123.2000, 6)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (85, 1, 18, N'Crystal Bulb', 11.2000, 7)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (27, 10, 24, N'Timing Belt', 485.6320, 11)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (28, 10, 25, N'Timing Belt', 632.8000, 11)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (29, 10, 26, N'Timing Belt', 304.6400, 11)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (30, 10, 23, N'Bando Cogbelt', 485.6320, 10)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (31, 10, 27, N'Bando Cogbelt', 227.0240, 10)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (32, 10, 28, N'Bando Cogbelt', 253.3440, 10)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (33, 10, 29, N'Bando Cogbelt', 259.8400, 10)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (34, 10, 30, N'Bando Cogbelt', 194.9920, 10)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (35, 10, 31, N'Bando Cogbelt', 422.2400, 10)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (36, 10, 32, N'Bando Cogbelt', 569.9680, 10)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (37, 10, 33, N'Bando Cogbelt', 696.6400, 10)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (38, 10, 21, N'Ribbed Ace Belt', 383.1520, 9)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (39, 10, 22, N'Ribbed Ace Belt', 388.1920, 9)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (103, 6, 40, N'Cylinder Head Gasket', 739.2000, 19)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (104, 6, 41, N'Cylinder Head Gasket', 683.2000, 19)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (105, 6, 42, N'Cylinder Head Gasket', 156.8000, 19)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (106, 6, 43, N'Cylinder Head Gasket', 156.8000, 19)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (107, 6, 44, N'Cylinder Head Gasket', 750.4000, 19)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (108, 6, 39, N'Cylinder Head Gasket Steel', 827.4560, 18)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (109, 6, 35, N'Exhause Manifold Gasket', 54.6560, 15)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (110, 6, 36, N'Exhaust Manifold Gasket', 54.6560, 15)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (111, 6, 34, N'Exhaust Manifold Gasket 5k', 43.4560, 14)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (112, 6, 37, N'Oil Pan Gasket 4BA1', 144.2560, 16)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (113, 6, 38, N'Oil Pan Gasket 4BC2 4.5mm', 256.2560, 17)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (114, 6, 47, N'Oil Filter', 154.0000, 20)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (115, 6, 48, N'Oil Filter', 162.0000, 20)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (116, 6, 49, N'Oil Filter', 133.0000, 20)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (117, 6, 50, N'Oil Filter', 239.0000, 20)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (118, 6, 51, N'Fuel Filter', 239.0000, 21)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (119, 6, 52, N'Fuel Filter', 588.0000, 21)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (120, 6, 53, N'Fuel Filter', 187.0000, 21)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (99, 9, 27, N'Bando Cogbelt', 227.0240, 10)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (92, 3, 2, N'Bumper Support', 168.0000, 1)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (100, 9, 5, N'Engine Support $.$$.$echo$.$$.$', 162.4000, 3)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (101, 9, 6, N'Engine Support "echo"', 162.4000, 3)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (102, 9, 7, N'Engine Support $.$echo$.$', 392.0000, 3)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (121, 6, 46, N'Valve Cover Gasket', 155.4560, 13)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (122, 6, 45, N'Valve Cover Gasket 4D56', 110.6560, 12)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (131, 5, 54, N'Clutch Master Assembly', 840.0000, 22)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (135, 11, 55, N'Titan', 1680.0000, 23)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (136, 11, 56, N'test', 560.0000, 24)
INSERT [dbo].[TBL_Suppliers_Product] ([Prod_ID], [Supp_ID], [Item_ID], [Prod_Name], [Item_Price], [Catg_ID]) VALUES (137, 11, 57, N'NISSAN TEST', 582.4000, 25)
SET IDENTITY_INSERT [dbo].[TBL_Suppliers_Product] OFF
/****** Object:  Table [dbo].[TBL_Suppliers]    Script Date: 04/17/2011 02:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Suppliers](
	[Supp_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[SuppName] [varchar](max) NULL,
	[SuppAdd] [varchar](max) NULL,
	[SuppContact] [varchar](max) NULL,
	[ContactPerson] [varchar](max) NULL,
	[supplocal] [varchar](max) NULL,
 CONSTRAINT [PK_TBL_Suppliers] PRIMARY KEY CLUSTERED 
(
	[Supp_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Suppliers] ON
INSERT [dbo].[TBL_Suppliers] ([Supp_ID], [SuppName], [SuppAdd], [SuppContact], [ContactPerson], [supplocal]) VALUES (1, N'Eco Parts Commercial', N'917-B Aurora Boulevard Silangan Cubao Quezon City', N'912-4732', N'', N'')
INSERT [dbo].[TBL_Suppliers] ([Supp_ID], [SuppName], [SuppAdd], [SuppContact], [ContactPerson], [supplocal]) VALUES (2, N'Anson Auto Supply Co.', N'1505 Batangas Street, Sta. Cruz, Manila', N'254-2232', N'', N'')
INSERT [dbo].[TBL_Suppliers] ([Supp_ID], [SuppName], [SuppAdd], [SuppContact], [ContactPerson], [supplocal]) VALUES (3, N'Rings Marketing', N'', N'721-17-03', N'', N'')
INSERT [dbo].[TBL_Suppliers] ([Supp_ID], [SuppName], [SuppAdd], [SuppContact], [ContactPerson], [supplocal]) VALUES (4, N'Amco Phil Multinational Corp.', N'463 E. Rodriguez Sr. Ave. Tatalon$..$ Quezon City', N'712-AMCO', N'', N'')
INSERT [dbo].[TBL_Suppliers] ([Supp_ID], [SuppName], [SuppAdd], [SuppContact], [ContactPerson], [supplocal]) VALUES (5, N'Yale Motor Parts Supply', N'', N'743-0179', N'', N'')
INSERT [dbo].[TBL_Suppliers] ([Supp_ID], [SuppName], [SuppAdd], [SuppContact], [ContactPerson], [supplocal]) VALUES (6, N'Genstar Auto Supply', N'Taft Ave. Ext.$..$ Pasay City', N'833-1489', N'', N'')
INSERT [dbo].[TBL_Suppliers] ([Supp_ID], [SuppName], [SuppAdd], [SuppContact], [ContactPerson], [supplocal]) VALUES (7, N'YCSU Trading Corporation', N'1740 Ma. Orosa Street, Malate Manila', N'', N'', N'')
INSERT [dbo].[TBL_Suppliers] ([Supp_ID], [SuppName], [SuppAdd], [SuppContact], [ContactPerson], [supplocal]) VALUES (8, N'Infinity Star Merchandising Corp.', N'', N'', N'', N'')
INSERT [dbo].[TBL_Suppliers] ([Supp_ID], [SuppName], [SuppAdd], [SuppContact], [ContactPerson], [supplocal]) VALUES (9, N'Stanhope Marketing Corporation', N'2841-2851 Molave Street$..$ Manuguit$..$ Tondo$..$ Manila$.$choi ', N'252-6151', N'', N'')
INSERT [dbo].[TBL_Suppliers] ([Supp_ID], [SuppName], [SuppAdd], [SuppContact], [ContactPerson], [supplocal]) VALUES (10, N'Philippine Belt Manufacturing Corporation Corp.', N'Plant Bo. Kaligayahan, Novaliches, Quezon City', N'241-0794', N'', N'')
INSERT [dbo].[TBL_Suppliers] ([Supp_ID], [SuppName], [SuppAdd], [SuppContact], [ContactPerson], [supplocal]) VALUES (11, N'Chuey Trading Inc', N'1A Cadena De Amor. St. Roxas Dist.$..$ Q.C.', N'09173548176', N'Chuey Marquez', N'')
SET IDENTITY_INSERT [dbo].[TBL_Suppliers] OFF
/****** Object:  Table [dbo].[TBL_Stocks_Balances]    Script Date: 04/17/2011 02:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Stocks_Balances](
	[Stock_Bal_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Item_ID] [bigint] NULL,
	[Item_QTY] [bigint] NULL,
	[Item_Description] [text] NULL,
	[Item_Barcode] [bigint] NULL,
	[Item_Price] [money] NULL,
	[PASSWORD_INPUTED] [text] NULL,
	[DIRECT_INPUT] [text] NULL,
	[Unit_Measure] [text] NULL,
 CONSTRAINT [PK_TBL_Stocks_Balances_1] PRIMARY KEY CLUSTERED 
(
	[Stock_Bal_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TBL_Stocks_Balances] ON
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (1, 14, 5, N'48328', 718263, 201.6000, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (2, 15, 10, N'48892', 89034, 151.2000, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (3, 16, 16, N'48881', 567434, 100.8000, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (4, 17, 20, N'48901', 12983, 123.2000, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (5, 18, 100, N'171771', 237894, 10.0000, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (6, 19, 96, N'17311', 12873, 13.4400, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (7, 20, 100, N'17328', 129037, 19.0400, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (8, 9, 21, N'ATF Dexron III', 1207893, 229.6000, N'No', N'No', N'Liter(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (9, 10, 24, N'Common Rail', 92874, 252.0000, N'No', N'No', N'Liter(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (10, 12, 8, N'Common Rail (G)', 823904, 1085.2800, N'No', N'No', N'Gallon(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (11, 13, 6, N'Speed Max 430 (G)', 267136, 1435.8400, N'No', N'No', N'Gallon(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (12, 11, 24, N'Speed Max 430', 912038, 285.6000, N'No', N'No', N'Liter(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (13, 47, 5, N'C-102', 798421, 154.0000, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (14, 48, 3, N'C-303', 65798132, 162.0000, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (15, 49, 5, N'C-110', 546987, 133.0000, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (16, 50, 5, N'C-503', 1389047, 239.0000, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (17, 45, 3, N'050312', 238741, 110.6560, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (18, 46, 2, N'YVCG-V410', 3497521, 155.4560, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (19, 34, 19, N'17172-13030', 781236, 43.4560, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (20, 35, 10, N'5-14145-004-0', 823732, 54.6560, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (21, 36, 4, N'013811', 23186, 54.6560, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (22, 37, 9, N'9-11367-614-0', 3248721, 144.2560, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (23, 38, 2, N'5-11367-064-0', 3247321, 256.2560, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (24, 39, 2, N'OK71E-10-271', 36784, 827.4560, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (25, 40, 2, N'RHG84338', 723648, 739.2000, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (26, 41, 2, N'RHG60440', 832758, 683.2000, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (27, 42, 5, N'RHG60043', 734651, 156.8000, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (28, 43, 2, N'RHG60561', 167152, 156.8000, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (29, 44, 2, N'RHG98466', 23489571, 750.4000, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (30, 1, 5, N'MB-109915', 9734, 168.0000, N'Yes', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (31, 2, 5, N'MB-109916', 9735, 168.0000, N'Yes', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (32, 3, 2, N'1-37510-105-10', 83274, 757.1200, N'Yes', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (33, 4, 2, N'37521-36G25', 12789, 476.0000, N'Yes', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (34, 5, 4, N'8-94172-018-1', 21837, 162.4000, N'Yes', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (35, 6, 4, N'8-94172-019-1', 9834128, 162.4000, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (36, 7, 4, N'12361-16040', 218793, 392.0000, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (37, 8, 1, N'48609-12270', 128937, 448.0000, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (38, 54, 1, N'8-97102-437-0', 347959, 840.0000, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (39, 21, 2, N'4PK-760', 523123, 383.1520, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (40, 22, 2, N'4PK-770', 52231, 388.1920, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (41, 23, 5, N'RPF-5460', 21763, 485.6320, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (42, 31, 5, N'RPF 5400', 34897, 422.2400, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (43, 32, 6, N'RPF 5540', 2343984, 569.9680, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (44, 33, 1, N'RPF 5660', 23074, 696.6400, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (45, 27, 5, N'RPF-2345', 2374823, 227.0240, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (46, 28, 5, N'RPF 2385', 412127, 253.3440, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (47, 29, 3, N'RPF 2395', 812673, 259.8400, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (48, 30, 5, N'RPF 3280', 53781, 194.9920, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (49, 24, 2, N'123 YH24', 328947, 485.6320, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (50, 25, 2, N'163 ZBS25', 213678, 632.8000, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (51, 26, 2, N'83 ZBS19', 28713, 304.6400, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (52, 56, 5, N'test', 1203978273198, 560.0000, N'No', N'No', N'Piece(s)')
INSERT [dbo].[TBL_Stocks_Balances] ([Stock_Bal_ID], [Item_ID], [Item_QTY], [Item_Description], [Item_Barcode], [Item_Price], [PASSWORD_INPUTED], [DIRECT_INPUT], [Unit_Measure]) VALUES (53, 57, 5, N'NISSAN TEST 0234', 441123, 582.4000, N'No', N'No', N'Piece(s)')
SET IDENTITY_INSERT [dbo].[TBL_Stocks_Balances] OFF
/****** Object:  Table [dbo].[TBL_Sales_Void]    Script Date: 04/17/2011 02:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Sales_Void](
	[Void_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Sales_ID] [bigint] NULL,
	[Receipt_ID] [bigint] NULL,
	[Void_Date] [datetime] NULL,
 CONSTRAINT [PK_TBL_Sales_Void] PRIMARY KEY CLUSTERED 
(
	[Void_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TBL_Sales_Void] ON
INSERT [dbo].[TBL_Sales_Void] ([Void_ID], [Sales_ID], [Receipt_ID], [Void_Date]) VALUES (1, 1, 1, CAST(0x00009E9C00000000 AS DateTime))
INSERT [dbo].[TBL_Sales_Void] ([Void_ID], [Sales_ID], [Receipt_ID], [Void_Date]) VALUES (2, 3, 3, CAST(0x00009E9C00000000 AS DateTime))
INSERT [dbo].[TBL_Sales_Void] ([Void_ID], [Sales_ID], [Receipt_ID], [Void_Date]) VALUES (3, 6, 6, CAST(0x00009E9C00000000 AS DateTime))
SET IDENTITY_INSERT [dbo].[TBL_Sales_Void] OFF
/****** Object:  Table [dbo].[TBL_Sales_Sold_Detail]    Script Date: 04/17/2011 02:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Sales_Sold_Detail](
	[Sales_Detail_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Sales_ID] [bigint] NOT NULL,
	[Item_ID] [bigint] NULL,
	[Item_Name] [varchar](max) NULL,
	[Item_Description] [varchar](max) NULL,
	[Item_Price] [money] NULL,
	[Item_Qty] [bigint] NULL,
	[Total_Price] [money] NULL,
	[Added_QTY] [bigint] NULL,
 CONSTRAINT [PK_TBL_Sales_Sold_Detail] PRIMARY KEY CLUSTERED 
(
	[Sales_Detail_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Sales_Sold_Detail] ON
INSERT [dbo].[TBL_Sales_Sold_Detail] ([Sales_Detail_ID], [Sales_ID], [Item_ID], [Item_Name], [Item_Description], [Item_Price], [Item_Qty], [Total_Price], [Added_QTY]) VALUES (1, 1, 1, N'Bumper Support - 2 QTY Return Product(s)', N'MB-109915', 168.0000, 3, 504.0000, 0)
INSERT [dbo].[TBL_Sales_Sold_Detail] ([Sales_Detail_ID], [Sales_ID], [Item_ID], [Item_Name], [Item_Description], [Item_Price], [Item_Qty], [Total_Price], [Added_QTY]) VALUES (2, 1, 2, N'Bumper Support', N'MB-109916', 168.0000, 5, 840.0000, 0)
INSERT [dbo].[TBL_Sales_Sold_Detail] ([Sales_Detail_ID], [Sales_ID], [Item_ID], [Item_Name], [Item_Description], [Item_Price], [Item_Qty], [Total_Price], [Added_QTY]) VALUES (3, 1, 3, N'Center Bearing Assembly', N'1-37510-105-10', 757.1200, 2, 1514.2400, 0)
INSERT [dbo].[TBL_Sales_Sold_Detail] ([Sales_Detail_ID], [Sales_ID], [Item_ID], [Item_Name], [Item_Description], [Item_Price], [Item_Qty], [Total_Price], [Added_QTY]) VALUES (4, 1, 4, N'CenterBearingAssembly', N'37521-36G25', 476.0000, 2, 952.0000, 0)
INSERT [dbo].[TBL_Sales_Sold_Detail] ([Sales_Detail_ID], [Sales_ID], [Item_ID], [Item_Name], [Item_Description], [Item_Price], [Item_Qty], [Total_Price], [Added_QTY]) VALUES (5, 1, 5, N'Engine Support $.$$.$echo$.$$.$', N'8-94172-018-1', 162.4000, 4, 649.6000, 0)
INSERT [dbo].[TBL_Sales_Sold_Detail] ([Sales_Detail_ID], [Sales_ID], [Item_ID], [Item_Name], [Item_Description], [Item_Price], [Item_Qty], [Total_Price], [Added_QTY]) VALUES (6, 1, 38, N'Oil Pan Gasket 4BC2 4.5mm / 1 QTY Return Product(s)', N'5-11367-064-0', 256.2560, 2, 512.5120, 0)
INSERT [dbo].[TBL_Sales_Sold_Detail] ([Sales_Detail_ID], [Sales_ID], [Item_ID], [Item_Name], [Item_Description], [Item_Price], [Item_Qty], [Total_Price], [Added_QTY]) VALUES (7, 2, 16, N'Halogen Bulb Narva', N'48881', 100.8000, 4, 403.2000, 0)
INSERT [dbo].[TBL_Sales_Sold_Detail] ([Sales_Detail_ID], [Sales_ID], [Item_ID], [Item_Name], [Item_Description], [Item_Price], [Item_Qty], [Total_Price], [Added_QTY]) VALUES (8, 2, 19, N'Auto Bulb "Narva"', N'17311', 13.4400, 4, 53.7600, 0)
INSERT [dbo].[TBL_Sales_Sold_Detail] ([Sales_Detail_ID], [Sales_ID], [Item_ID], [Item_Name], [Item_Description], [Item_Price], [Item_Qty], [Total_Price], [Added_QTY]) VALUES (9, 2, 34, N'Exhaust Manifold Gasket 5k', N'17172-13030', 43.4560, 1, 43.4560, 0)
INSERT [dbo].[TBL_Sales_Sold_Detail] ([Sales_Detail_ID], [Sales_ID], [Item_ID], [Item_Name], [Item_Description], [Item_Price], [Item_Qty], [Total_Price], [Added_QTY]) VALUES (10, 3, 29, N'Bando Cogbelt', N'RPF 2395', 259.8400, 2, 519.6800, 0)
INSERT [dbo].[TBL_Sales_Sold_Detail] ([Sales_Detail_ID], [Sales_ID], [Item_ID], [Item_Name], [Item_Description], [Item_Price], [Item_Qty], [Total_Price], [Added_QTY]) VALUES (11, 3, 46, N'Valve Cover Gasket', N'YVCG-V410', 155.4560, 1, 155.4560, 0)
INSERT [dbo].[TBL_Sales_Sold_Detail] ([Sales_Detail_ID], [Sales_ID], [Item_ID], [Item_Name], [Item_Description], [Item_Price], [Item_Qty], [Total_Price], [Added_QTY]) VALUES (12, 4, 9, N'ATF Dexron III', N'ATF Dexron III', 229.6000, 3, 688.8000, 0)
INSERT [dbo].[TBL_Sales_Sold_Detail] ([Sales_Detail_ID], [Sales_ID], [Item_ID], [Item_Name], [Item_Description], [Item_Price], [Item_Qty], [Total_Price], [Added_QTY]) VALUES (13, 4, 29, N'Bando Cogbelt', N'RPF 2395', 259.8400, 2, 519.6800, 0)
INSERT [dbo].[TBL_Sales_Sold_Detail] ([Sales_Detail_ID], [Sales_ID], [Item_ID], [Item_Name], [Item_Description], [Item_Price], [Item_Qty], [Total_Price], [Added_QTY]) VALUES (14, 4, 46, N'Valve Cover Gasket', N'YVCG-V410', 155.4560, 1, 155.4560, 0)
INSERT [dbo].[TBL_Sales_Sold_Detail] ([Sales_Detail_ID], [Sales_ID], [Item_ID], [Item_Name], [Item_Description], [Item_Price], [Item_Qty], [Total_Price], [Added_QTY]) VALUES (15, 5, 56, N'test - 1 QTY Return Product(s)', N'test', 560.0000, 2, 1120.0000, 0)
INSERT [dbo].[TBL_Sales_Sold_Detail] ([Sales_Detail_ID], [Sales_ID], [Item_ID], [Item_Name], [Item_Description], [Item_Price], [Item_Qty], [Total_Price], [Added_QTY]) VALUES (16, 5, 8, N'Shock Absorber Mounting [ Added new product ]', N'48609-12270', 448.0000, 3, 1344.0000, 0)
INSERT [dbo].[TBL_Sales_Sold_Detail] ([Sales_Detail_ID], [Sales_ID], [Item_ID], [Item_Name], [Item_Description], [Item_Price], [Item_Qty], [Total_Price], [Added_QTY]) VALUES (17, 6, 56, N'test / 2 QTY Return Product(s)', N'test', 560.0000, 3, 1680.0000, 0)
INSERT [dbo].[TBL_Sales_Sold_Detail] ([Sales_Detail_ID], [Sales_ID], [Item_ID], [Item_Name], [Item_Description], [Item_Price], [Item_Qty], [Total_Price], [Added_QTY]) VALUES (18, 6, 57, N'NISSAN TEST', N'NISSAN TEST 0234', 582.4000, 50, 29120.0000, 0)
INSERT [dbo].[TBL_Sales_Sold_Detail] ([Sales_Detail_ID], [Sales_ID], [Item_ID], [Item_Name], [Item_Description], [Item_Price], [Item_Qty], [Total_Price], [Added_QTY]) VALUES (19, 7, 56, N'test', N'test', 560.0000, 3, 1680.0000, 0)
INSERT [dbo].[TBL_Sales_Sold_Detail] ([Sales_Detail_ID], [Sales_ID], [Item_ID], [Item_Name], [Item_Description], [Item_Price], [Item_Qty], [Total_Price], [Added_QTY]) VALUES (20, 7, 57, N'NISSAN TEST', N'NISSAN TEST 0234', 582.4000, 50, 29120.0000, 0)
SET IDENTITY_INSERT [dbo].[TBL_Sales_Sold_Detail] OFF
/****** Object:  Table [dbo].[TBL_Sales_Sold]    Script Date: 04/17/2011 02:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Sales_Sold](
	[Sales_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Sales_Date] [datetime] NULL,
	[User_ID] [bigint] NULL,
	[Amount_Due] [money] NULL,
	[Amount_Receive] [money] NULL,
	[Amount_Change] [money] NULL,
	[Order_No] [bigint] NULL,
 CONSTRAINT [PK_TBL_Sales_Sold] PRIMARY KEY CLUSTERED 
(
	[Sales_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TBL_Sales_Sold] ON
INSERT [dbo].[TBL_Sales_Sold] ([Sales_ID], [Sales_Date], [User_ID], [Amount_Due], [Amount_Receive], [Amount_Change], [Order_No]) VALUES (1, CAST(0x00009E9C00000000 AS DateTime), NULL, 4972.3520, 5000.0000, 27.6480, 0)
INSERT [dbo].[TBL_Sales_Sold] ([Sales_ID], [Sales_Date], [User_ID], [Amount_Due], [Amount_Receive], [Amount_Change], [Order_No]) VALUES (2, CAST(0x00009E9C00000000 AS DateTime), NULL, 500.4200, 501.0000, 0.5800, 1)
INSERT [dbo].[TBL_Sales_Sold] ([Sales_ID], [Sales_Date], [User_ID], [Amount_Due], [Amount_Receive], [Amount_Change], [Order_No]) VALUES (3, CAST(0x00009E9C00000000 AS DateTime), NULL, 675.1400, 700.0000, 24.8600, 2)
INSERT [dbo].[TBL_Sales_Sold] ([Sales_ID], [Sales_Date], [User_ID], [Amount_Due], [Amount_Receive], [Amount_Change], [Order_No]) VALUES (4, CAST(0x00009E9C00000000 AS DateTime), NULL, 1363.9400, 1400.0000, 36.0600, 2)
INSERT [dbo].[TBL_Sales_Sold] ([Sales_ID], [Sales_Date], [User_ID], [Amount_Due], [Amount_Receive], [Amount_Change], [Order_No]) VALUES (5, CAST(0x00009E9C00000000 AS DateTime), NULL, 2464.0000, 3000.0000, 536.0000, 3)
INSERT [dbo].[TBL_Sales_Sold] ([Sales_ID], [Sales_Date], [User_ID], [Amount_Due], [Amount_Receive], [Amount_Change], [Order_No]) VALUES (6, CAST(0x00009E9C00000000 AS DateTime), NULL, 30800.0000, 200000000.0000, 199969200.0000, 0)
INSERT [dbo].[TBL_Sales_Sold] ([Sales_ID], [Sales_Date], [User_ID], [Amount_Due], [Amount_Receive], [Amount_Change], [Order_No]) VALUES (7, CAST(0x00009E9C00000000 AS DateTime), NULL, 30800.0000, 200000000.0000, 199969200.0000, 4)
SET IDENTITY_INSERT [dbo].[TBL_Sales_Sold] OFF
/****** Object:  Table [dbo].[TBL_Sales_Receipt]    Script Date: 04/17/2011 02:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Sales_Receipt](
	[Receipt_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Sales_ID] [bigint] NULL,
	[Vatable] [money] NULL,
	[VAT_Exempt_Sale] [money] NULL,
	[VATZero_Rated_Sale] [money] NULL,
	[Total_Sale] [money] NULL,
	[VAT] [money] NULL,
	[Amount_Due] [money] NULL,
	[User_ID] [bigint] NULL,
	[Receipt_Date] [datetime] NULL,
	[Void] [varchar](50) NULL,
	[Order_No] [bigint] NULL,
 CONSTRAINT [PK_TBL_Sales_Receipt] PRIMARY KEY CLUSTERED 
(
	[Receipt_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Sales_Receipt] ON
INSERT [dbo].[TBL_Sales_Receipt] ([Receipt_ID], [Sales_ID], [Vatable], [VAT_Exempt_Sale], [VATZero_Rated_Sale], [Total_Sale], [VAT], [Amount_Due], [User_ID], [Receipt_Date], [Void], [Order_No]) VALUES (1, 1, 4439.6000, 0.0000, NULL, 4439.6000, 532.7500, 4972.3500, 12, CAST(0x00009E9C00000000 AS DateTime), N'Yes', 0)
INSERT [dbo].[TBL_Sales_Receipt] ([Receipt_ID], [Sales_ID], [Vatable], [VAT_Exempt_Sale], [VATZero_Rated_Sale], [Total_Sale], [VAT], [Amount_Due], [User_ID], [Receipt_Date], [Void], [Order_No]) VALUES (2, 2, 446.8000, 0.0000, NULL, 446.8000, 53.6200, 500.4200, 12, CAST(0x00009E9C00000000 AS DateTime), N'No', 1)
INSERT [dbo].[TBL_Sales_Receipt] ([Receipt_ID], [Sales_ID], [Vatable], [VAT_Exempt_Sale], [VATZero_Rated_Sale], [Total_Sale], [VAT], [Amount_Due], [User_ID], [Receipt_Date], [Void], [Order_No]) VALUES (3, 3, 602.8000, 0.0000, NULL, 602.8000, 72.3400, 675.1400, 9, CAST(0x00009E9C00000000 AS DateTime), N'Yes', 2)
INSERT [dbo].[TBL_Sales_Receipt] ([Receipt_ID], [Sales_ID], [Vatable], [VAT_Exempt_Sale], [VATZero_Rated_Sale], [Total_Sale], [VAT], [Amount_Due], [User_ID], [Receipt_Date], [Void], [Order_No]) VALUES (4, 4, 1217.8000, 0.0000, NULL, 1217.8000, 146.1400, 1363.9400, 9, CAST(0x00009E9C00000000 AS DateTime), N'No', 2)
INSERT [dbo].[TBL_Sales_Receipt] ([Receipt_ID], [Sales_ID], [Vatable], [VAT_Exempt_Sale], [VATZero_Rated_Sale], [Total_Sale], [VAT], [Amount_Due], [User_ID], [Receipt_Date], [Void], [Order_No]) VALUES (5, 5, 2200.0000, 0.0000, NULL, 2200.0000, 264.0000, 2464.0000, 12, CAST(0x00009E9C00000000 AS DateTime), N'No', 3)
INSERT [dbo].[TBL_Sales_Receipt] ([Receipt_ID], [Sales_ID], [Vatable], [VAT_Exempt_Sale], [VATZero_Rated_Sale], [Total_Sale], [VAT], [Amount_Due], [User_ID], [Receipt_Date], [Void], [Order_No]) VALUES (6, 6, 27500.0000, 0.0000, NULL, 27500.0000, 3300.0000, 30800.0000, 12, CAST(0x00009E9C00000000 AS DateTime), N'Yes', 0)
INSERT [dbo].[TBL_Sales_Receipt] ([Receipt_ID], [Sales_ID], [Vatable], [VAT_Exempt_Sale], [VATZero_Rated_Sale], [Total_Sale], [VAT], [Amount_Due], [User_ID], [Receipt_Date], [Void], [Order_No]) VALUES (7, 7, 27500.0000, 0.0000, NULL, 27500.0000, 3300.0000, 30800.0000, 12, CAST(0x00009E9C00000000 AS DateTime), N'No', 4)
SET IDENTITY_INSERT [dbo].[TBL_Sales_Receipt] OFF
/****** Object:  Table [dbo].[TBL_Purchase_Order]    Script Date: 04/17/2011 02:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Purchase_Order](
	[Purchase_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Supp_ID] [bigint] NULL,
	[Address] [varchar](max) NULL,
	[Delivery_Term] [varchar](max) NULL,
	[Approved] [varchar](50) NULL,
	[Purchased_Date] [datetime] NULL,
	[Received_Date] [datetime] NULL,
	[Approveby] [varchar](max) NULL,
	[Direct_Input] [varchar](50) NULL,
	[Supp_Name] [varchar](max) NULL,
	[Purchase_Total] [money] NULL,
 CONSTRAINT [PK_TBL_Purchase_Order] PRIMARY KEY CLUSTERED 
(
	[Purchase_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Purchase_Order] ON
INSERT [dbo].[TBL_Purchase_Order] ([Purchase_ID], [Supp_ID], [Address], [Delivery_Term], [Approved], [Purchased_Date], [Received_Date], [Approveby], [Direct_Input], [Supp_Name], [Purchase_Total]) VALUES (1, 1, N'917-B Aurora Boulevard Silangan Cubao Quezon City', N'Paid after deliver', N'Yes', CAST(0x00009E9C00000000 AS DateTime), CAST(0x00009E9C00000000 AS DateTime), NULL, N'No', NULL, 11248.0000)
INSERT [dbo].[TBL_Purchase_Order] ([Purchase_ID], [Supp_ID], [Address], [Delivery_Term], [Approved], [Purchased_Date], [Received_Date], [Approveby], [Direct_Input], [Supp_Name], [Purchase_Total]) VALUES (2, 4, N'463 E. Rodriguez Sr. Ave. Tatalon$..$ Quezon City', N'Paid after deliver', N'Yes', CAST(0x00009E9C00000000 AS DateTime), CAST(0x00009E9C00000000 AS DateTime), NULL, N'No', NULL, 35710.0800)
INSERT [dbo].[TBL_Purchase_Order] ([Purchase_ID], [Supp_ID], [Address], [Delivery_Term], [Approved], [Purchased_Date], [Received_Date], [Approveby], [Direct_Input], [Supp_Name], [Purchase_Total]) VALUES (3, 6, N'Taft Ave. Ext.$..$ Pasay City', N'Paid after deliver', N'Yes', CAST(0x00009E9C00000000 AS DateTime), CAST(0x00009E9C00000000 AS DateTime), NULL, N'No', NULL, 14457.5680)
INSERT [dbo].[TBL_Purchase_Order] ([Purchase_ID], [Supp_ID], [Address], [Delivery_Term], [Approved], [Purchased_Date], [Received_Date], [Approveby], [Direct_Input], [Supp_Name], [Purchase_Total]) VALUES (4, 5, N'', N'Paid after deliver', N'Yes', CAST(0x00009E9C00000000 AS DateTime), CAST(0x00009E9C00000000 AS DateTime), NULL, N'No', NULL, 9645.4400)
INSERT [dbo].[TBL_Purchase_Order] ([Purchase_ID], [Supp_ID], [Address], [Delivery_Term], [Approved], [Purchased_Date], [Received_Date], [Approveby], [Direct_Input], [Supp_Name], [Purchase_Total]) VALUES (5, 10, N'Plant Bo. Kaligayahan$..$ Novaliches$..$ Quezon City', N'Paid after deliver', N'Yes', CAST(0x00009E9C00000000 AS DateTime), CAST(0x00009E9C00000000 AS DateTime), NULL, N'No', NULL, 17720.6400)
INSERT [dbo].[TBL_Purchase_Order] ([Purchase_ID], [Supp_ID], [Address], [Delivery_Term], [Approved], [Purchased_Date], [Received_Date], [Approveby], [Direct_Input], [Supp_Name], [Purchase_Total]) VALUES (6, 11, N'1A Cadena De Amor. St. Roxas Dist.$..$ Q.C.', N'Paid after deliver', N'Yes', CAST(0x00009E9C00000000 AS DateTime), CAST(0x00009E9C00000000 AS DateTime), NULL, N'No', NULL, 2800.0000)
INSERT [dbo].[TBL_Purchase_Order] ([Purchase_ID], [Supp_ID], [Address], [Delivery_Term], [Approved], [Purchased_Date], [Received_Date], [Approveby], [Direct_Input], [Supp_Name], [Purchase_Total]) VALUES (7, 11, N'1A Cadena De Amor. St. Roxas Dist.$..$ Q.C.', N'Paid after deliver', N'Yes', CAST(0x00009E9C00000000 AS DateTime), CAST(0x00009E9C00000000 AS DateTime), NULL, N'No', NULL, 32032.0000)
INSERT [dbo].[TBL_Purchase_Order] ([Purchase_ID], [Supp_ID], [Address], [Delivery_Term], [Approved], [Purchased_Date], [Received_Date], [Approveby], [Direct_Input], [Supp_Name], [Purchase_Total]) VALUES (8, 11, N'1A Cadena De Amor. St. Roxas Dist.$..$ Q.C.', N'Paid after deliver', N'Yes', CAST(0x00009E9C00000000 AS DateTime), CAST(0x00009E9C00000000 AS DateTime), NULL, N'No', NULL, 2800.0000)
SET IDENTITY_INSERT [dbo].[TBL_Purchase_Order] OFF
/****** Object:  Table [dbo].[TBL_Purchase_Detail]    Script Date: 04/17/2011 02:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Purchase_Detail](
	[Purchase_Detail_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Purchase_ID] [bigint] NULL,
	[Item_ID] [bigint] NULL,
	[Item_QTY] [bigint] NULL,
	[Item_Price] [money] NULL,
	[Total_Price] [money] NULL,
	[Unit_Measure] [varchar](50) NULL,
 CONSTRAINT [PK_TBL_Purchase_Detail] PRIMARY KEY CLUSTERED 
(
	[Purchase_Detail_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Purchase_Detail] ON
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (8, 1, 14, 5, 201.6000, 1008.0000, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (9, 1, 15, 10, 151.2000, 1512.0000, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (10, 1, 16, 20, 100.8000, 2016.0000, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (11, 1, 17, 20, 123.2000, 2464.0000, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (12, 1, 18, 100, 10.0000, 1000.0000, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (13, 1, 19, 100, 13.4400, 1344.0000, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (14, 1, 20, 100, 19.0400, 1904.0000, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (15, 2, 9, 24, 229.6000, 5510.4000, N'Liter(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (16, 2, 10, 24, 252.0000, 6048.0000, N'Liter(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (17, 2, 12, 8, 1085.2800, 8682.2400, N'Gallon(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (18, 2, 13, 6, 1435.8400, 8615.0400, N'Gallon(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (19, 2, 11, 24, 285.6000, 6854.4000, N'Liter(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (20, 3, 47, 5, 154.0000, 770.0000, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (21, 3, 48, 3, 162.0000, 486.0000, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (22, 3, 49, 5, 133.0000, 665.0000, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (23, 3, 50, 5, 239.0000, 1195.0000, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (24, 3, 45, 3, 110.6560, 331.9680, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (25, 3, 46, 3, 155.4560, 466.3680, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (26, 3, 34, 20, 43.4560, 869.1200, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (27, 3, 35, 10, 54.6560, 546.5600, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (28, 3, 36, 4, 54.6560, 218.6240, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (29, 3, 37, 9, 144.2560, 1298.3040, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (30, 3, 38, 2, 256.2560, 512.5120, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (31, 3, 39, 2, 827.4560, 1654.9120, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (32, 3, 40, 2, 739.2000, 1478.4000, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (33, 3, 41, 2, 683.2000, 1366.4000, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (34, 3, 42, 5, 156.8000, 784.0000, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (35, 3, 43, 2, 156.8000, 313.6000, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (36, 3, 44, 2, 750.4000, 1500.8000, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (37, 4, 1, 5, 168.0000, 840.0000, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (38, 4, 2, 5, 168.0000, 840.0000, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (39, 4, 3, 2, 757.1200, 1514.2400, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (40, 4, 4, 2, 476.0000, 952.0000, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (41, 4, 5, 4, 162.4000, 649.6000, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (42, 4, 6, 4, 162.4000, 649.6000, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (43, 4, 7, 4, 392.0000, 1568.0000, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (44, 4, 8, 4, 448.0000, 1792.0000, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (45, 4, 54, 1, 840.0000, 840.0000, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (46, 5, 21, 2, 383.1520, 766.3040, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (47, 5, 22, 2, 388.1920, 776.3840, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (48, 5, 23, 5, 485.6320, 2428.1600, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (49, 5, 31, 5, 422.2400, 2111.2000, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (50, 5, 32, 6, 569.9680, 3419.8080, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (51, 5, 33, 1, 696.6400, 696.6400, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (52, 5, 27, 5, 227.0240, 1135.1200, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (53, 5, 28, 5, 253.3440, 1266.7200, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (54, 5, 29, 5, 259.8400, 1299.2000, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (55, 5, 30, 5, 194.9920, 974.9600, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (56, 5, 24, 2, 485.6320, 971.2640, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (57, 5, 25, 2, 632.8000, 1265.6000, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (58, 5, 26, 2, 304.6400, 609.2800, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (60, 6, 56, 5, 560.0000, 2800.0000, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (61, 7, 57, 55, 582.4000, 32032.0000, N'Piece(s)')
INSERT [dbo].[TBL_Purchase_Detail] ([Purchase_Detail_ID], [Purchase_ID], [Item_ID], [Item_QTY], [Item_Price], [Total_Price], [Unit_Measure]) VALUES (62, 8, 56, 5, 560.0000, 2800.0000, N'Piece(s)')
SET IDENTITY_INSERT [dbo].[TBL_Purchase_Detail] OFF
/****** Object:  Table [dbo].[TBL_Physical_Count_Details]    Script Date: 04/17/2011 02:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Physical_Count_Details](
	[PD_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[P_ID] [bigint] NULL,
	[Item_ID] [bigint] NULL,
	[P_Counts] [bigint] NULL,
	[P_Remarks] [varchar](max) NULL,
	[Total_QTY] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Physical_Count_Details] ON
INSERT [dbo].[TBL_Physical_Count_Details] ([PD_ID], [P_ID], [Item_ID], [P_Counts], [P_Remarks], [Total_QTY]) VALUES (1, 1, 24, 2, N'', 2)
INSERT [dbo].[TBL_Physical_Count_Details] ([PD_ID], [P_ID], [Item_ID], [P_Counts], [P_Remarks], [Total_QTY]) VALUES (2, 1, 15, 9, N'Missing 1 item(s)', 10)
INSERT [dbo].[TBL_Physical_Count_Details] ([PD_ID], [P_ID], [Item_ID], [P_Counts], [P_Remarks], [Total_QTY]) VALUES (3, 1, 32, 5, N'Missing 1 item(s)', 6)
INSERT [dbo].[TBL_Physical_Count_Details] ([PD_ID], [P_ID], [Item_ID], [P_Counts], [P_Remarks], [Total_QTY]) VALUES (4, 2, 57, 3, N'Missing 2 item(s)', 5)
INSERT [dbo].[TBL_Physical_Count_Details] ([PD_ID], [P_ID], [Item_ID], [P_Counts], [P_Remarks], [Total_QTY]) VALUES (5, 2, 9, 5, N'Missing 16 item(s)', 21)
INSERT [dbo].[TBL_Physical_Count_Details] ([PD_ID], [P_ID], [Item_ID], [P_Counts], [P_Remarks], [Total_QTY]) VALUES (6, 2, 19, 96, N'', 96)
INSERT [dbo].[TBL_Physical_Count_Details] ([PD_ID], [P_ID], [Item_ID], [P_Counts], [P_Remarks], [Total_QTY]) VALUES (7, 3, 24, 2, N'', 2)
INSERT [dbo].[TBL_Physical_Count_Details] ([PD_ID], [P_ID], [Item_ID], [P_Counts], [P_Remarks], [Total_QTY]) VALUES (8, 3, 23, 4, N'Missing 1 item(s)', 5)
INSERT [dbo].[TBL_Physical_Count_Details] ([PD_ID], [P_ID], [Item_ID], [P_Counts], [P_Remarks], [Total_QTY]) VALUES (9, 3, 15, 9, N'Missing 1 item(s)', 10)
SET IDENTITY_INSERT [dbo].[TBL_Physical_Count_Details] OFF
/****** Object:  Table [dbo].[TBL_Physical_Count]    Script Date: 04/17/2011 02:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Physical_Count](
	[P_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[P_Date] [datetime] NULL,
	[User_ID] [bigint] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TBL_Physical_Count] ON
INSERT [dbo].[TBL_Physical_Count] ([P_ID], [P_Date], [User_ID]) VALUES (1, CAST(0x00009E9C00000000 AS DateTime), 14)
INSERT [dbo].[TBL_Physical_Count] ([P_ID], [P_Date], [User_ID]) VALUES (2, CAST(0x00009E9C00000000 AS DateTime), 14)
INSERT [dbo].[TBL_Physical_Count] ([P_ID], [P_Date], [User_ID]) VALUES (3, CAST(0x00009E9C00000000 AS DateTime), 14)
SET IDENTITY_INSERT [dbo].[TBL_Physical_Count] OFF
/****** Object:  Table [dbo].[TBL_Pending_Item]    Script Date: 04/17/2011 02:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Pending_Item](
	[Pending_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Item_ID] [bigint] NULL,
	[Pending_Date] [datetime] NULL,
	[User_ID] [bigint] NULL,
	[Item_QTY] [bigint] NULL,
	[Returnx] [varchar](50) NULL,
	[Receipt_ID] [bigint] NULL,
	[Return_Date] [datetime] NULL,
	[Sales_Detail_ID] [bigint] NULL,
 CONSTRAINT [PK_TBL_Pending_Item] PRIMARY KEY CLUSTERED 
(
	[Pending_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Pending_Item] ON
INSERT [dbo].[TBL_Pending_Item] ([Pending_ID], [Item_ID], [Pending_Date], [User_ID], [Item_QTY], [Returnx], [Receipt_ID], [Return_Date], [Sales_Detail_ID]) VALUES (1, 38, CAST(0x00009E9C00000000 AS DateTime), 9, 1, N'Yes', 1, CAST(0x00009E9C00000000 AS DateTime), 6)
INSERT [dbo].[TBL_Pending_Item] ([Pending_ID], [Item_ID], [Pending_Date], [User_ID], [Item_QTY], [Returnx], [Receipt_ID], [Return_Date], [Sales_Detail_ID]) VALUES (2, 56, CAST(0x00009E9C00000000 AS DateTime), 12, 3, N'Yes', 6, CAST(0x00009E9C00000000 AS DateTime), 17)
SET IDENTITY_INSERT [dbo].[TBL_Pending_Item] OFF
/****** Object:  Table [dbo].[TBL_Orders_Detail]    Script Date: 04/17/2011 02:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Orders_Detail](
	[Order_Dtl] [bigint] IDENTITY(1,1) NOT NULL,
	[Order_No] [bigint] NULL,
	[Item_ID] [bigint] NULL,
	[Product_Name] [varchar](max) NULL,
	[Unit_Measure] [varchar](50) NULL,
	[Unit_Cost] [money] NULL,
	[QTY] [bigint] NULL,
	[TOTAL_COST] [money] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Orders_Detail] ON
INSERT [dbo].[TBL_Orders_Detail] ([Order_Dtl], [Order_No], [Item_ID], [Product_Name], [Unit_Measure], [Unit_Cost], [QTY], [TOTAL_COST]) VALUES (1, 1, 16, N'Halogen Bulb Narva', N'Piece(s)', 100.8000, 4, 403.2000)
INSERT [dbo].[TBL_Orders_Detail] ([Order_Dtl], [Order_No], [Item_ID], [Product_Name], [Unit_Measure], [Unit_Cost], [QTY], [TOTAL_COST]) VALUES (2, 1, 19, N'Auto Bulb "Narva"', N'Piece(s)', 13.4400, 4, 53.7600)
INSERT [dbo].[TBL_Orders_Detail] ([Order_Dtl], [Order_No], [Item_ID], [Product_Name], [Unit_Measure], [Unit_Cost], [QTY], [TOTAL_COST]) VALUES (3, 1, 34, N'Exhaust Manifold Gasket 5k', N'Piece(s)', 43.4560, 1, 43.4560)
INSERT [dbo].[TBL_Orders_Detail] ([Order_Dtl], [Order_No], [Item_ID], [Product_Name], [Unit_Measure], [Unit_Cost], [QTY], [TOTAL_COST]) VALUES (4, 2, 29, N'Bando Cogbelt', N'Piece(s)', 259.8400, 2, 519.6800)
INSERT [dbo].[TBL_Orders_Detail] ([Order_Dtl], [Order_No], [Item_ID], [Product_Name], [Unit_Measure], [Unit_Cost], [QTY], [TOTAL_COST]) VALUES (5, 2, 46, N'Valve Cover Gasket', N'Piece(s)', 155.4560, 1, 155.4560)
INSERT [dbo].[TBL_Orders_Detail] ([Order_Dtl], [Order_No], [Item_ID], [Product_Name], [Unit_Measure], [Unit_Cost], [QTY], [TOTAL_COST]) VALUES (7, 3, 56, N'test', N'Piece(s)', 560.0000, 5, 2800.0000)
INSERT [dbo].[TBL_Orders_Detail] ([Order_Dtl], [Order_No], [Item_ID], [Product_Name], [Unit_Measure], [Unit_Cost], [QTY], [TOTAL_COST]) VALUES (8, 4, 57, N'NISSAN TEST', N'Piece(s)', 582.4000, 50, 29120.0000)
INSERT [dbo].[TBL_Orders_Detail] ([Order_Dtl], [Order_No], [Item_ID], [Product_Name], [Unit_Measure], [Unit_Cost], [QTY], [TOTAL_COST]) VALUES (9, 4, 56, N'test', N'Piece(s)', 560.0000, 3, 1680.0000)
INSERT [dbo].[TBL_Orders_Detail] ([Order_Dtl], [Order_No], [Item_ID], [Product_Name], [Unit_Measure], [Unit_Cost], [QTY], [TOTAL_COST]) VALUES (6, 2, 9, N'ATF Dexron III', N'Liter(s)', 229.6000, 3, 688.8000)
SET IDENTITY_INSERT [dbo].[TBL_Orders_Detail] OFF
/****** Object:  Table [dbo].[TBL_Orders]    Script Date: 04/17/2011 02:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Orders](
	[Order_No] [bigint] IDENTITY(1,1) NOT NULL,
	[Order_Date] [datetime] NULL,
	[Product_Total] [money] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TBL_Orders] ON
INSERT [dbo].[TBL_Orders] ([Order_No], [Order_Date], [Product_Total]) VALUES (1, CAST(0x00009E9C00000000 AS DateTime), 500.4160)
INSERT [dbo].[TBL_Orders] ([Order_No], [Order_Date], [Product_Total]) VALUES (2, CAST(0x00009E9C00000000 AS DateTime), 1363.9360)
INSERT [dbo].[TBL_Orders] ([Order_No], [Order_Date], [Product_Total]) VALUES (3, CAST(0x00009E9C00000000 AS DateTime), 2800.0000)
INSERT [dbo].[TBL_Orders] ([Order_No], [Order_Date], [Product_Total]) VALUES (4, CAST(0x00009E9C00000000 AS DateTime), 30800.0000)
SET IDENTITY_INSERT [dbo].[TBL_Orders] OFF
/****** Object:  Table [dbo].[TBL_Group]    Script Date: 04/17/2011 02:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Group](
	[Group_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Group_Name] [varchar](max) NULL,
	[Group_Description] [varchar](max) NULL,
 CONSTRAINT [PK_TBL_Group] PRIMARY KEY CLUSTERED 
(
	[Group_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Group] ON
INSERT [dbo].[TBL_Group] ([Group_ID], [Group_Name], [Group_Description]) VALUES (1, N'Maxx Brand', N'Maxx Brand')
INSERT [dbo].[TBL_Group] ([Group_ID], [Group_Name], [Group_Description]) VALUES (2, N'Amco', N'Transmission Fluid')
INSERT [dbo].[TBL_Group] ([Group_ID], [Group_Name], [Group_Description]) VALUES (3, N'Halogen Bulb', N'Halogen Bulb')
INSERT [dbo].[TBL_Group] ([Group_ID], [Group_Name], [Group_Description]) VALUES (4, N'Fan Belt', N'Fan Belt')
INSERT [dbo].[TBL_Group] ([Group_ID], [Group_Name], [Group_Description]) VALUES (5, N'Yasui', N'Yasui (Gasket)')
INSERT [dbo].[TBL_Group] ([Group_ID], [Group_Name], [Group_Description]) VALUES (6, N'Federal Mogul', N'Federal (Gasket)')
INSERT [dbo].[TBL_Group] ([Group_ID], [Group_Name], [Group_Description]) VALUES (7, N'Vic (Oil and Fuel Filter)', N'Vic (Oil and Fuel Filter)')
INSERT [dbo].[TBL_Group] ([Group_ID], [Group_Name], [Group_Description]) VALUES (8, N'Toyota', N'Toyota')
INSERT [dbo].[TBL_Group] ([Group_ID], [Group_Name], [Group_Description]) VALUES (9, N'FTC Brand', N'Clutch Master Assembly')
INSERT [dbo].[TBL_Group] ([Group_ID], [Group_Name], [Group_Description]) VALUES (10, N'Titan', N'Shock Absorber')
INSERT [dbo].[TBL_Group] ([Group_ID], [Group_Name], [Group_Description]) VALUES (11, N'CMD', N'Ball Joint')
INSERT [dbo].[TBL_Group] ([Group_ID], [Group_Name], [Group_Description]) VALUES (12, N'HOOD', N'HOOD')
SET IDENTITY_INSERT [dbo].[TBL_Group] OFF
/****** Object:  Table [dbo].[TBL_Globaldata]    Script Date: 04/17/2011 02:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Globaldata](
	[Buss_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[BussName] [varchar](max) NULL,
	[BussLocation] [varchar](max) NULL,
	[BussVaT] [float] NULL,
	[BussContact] [varchar](max) NULL,
	[Tin] [varchar](50) NULL,
	[busslocal] [varchar](max) NULL,
	[Email_Address] [varchar](max) NULL,
	[Website] [varchar](max) NULL,
 CONSTRAINT [PK_TBL_Globaldata] PRIMARY KEY CLUSTERED 
(
	[Buss_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Globaldata] ON
INSERT [dbo].[TBL_Globaldata] ([Buss_ID], [BussName], [BussLocation], [BussVaT], [BussContact], [Tin], [busslocal], [Email_Address], [Website]) VALUES (1, N'Gazuto Merchandising Inc', N'Panay Ave QC', 12, N'410-01-78', N'258-715-834-000', N'', N'gazutoemail@yahoo.com', N'www.gazuto.com.ph')
SET IDENTITY_INSERT [dbo].[TBL_Globaldata] OFF
/****** Object:  Table [dbo].[TBL_Deffective_PO_Return_Details]    Script Date: 04/17/2011 02:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Deffective_PO_Return_Details](
	[Def_Return_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Purchase_ID] [bigint] NULL,
	[Purchase_Detail_ID] [bigint] NULL,
	[Item_ID] [bigint] NULL,
	[Return_QTY] [bigint] NULL,
	[Unit] [varchar](50) NULL,
	[Return_ID] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Deffective_PO_Return_Details] ON
INSERT [dbo].[TBL_Deffective_PO_Return_Details] ([Def_Return_ID], [Purchase_ID], [Purchase_Detail_ID], [Item_ID], [Return_QTY], [Unit], [Return_ID]) VALUES (1, 3, 30, 38, 1, N'Piece(s)', 1)
INSERT [dbo].[TBL_Deffective_PO_Return_Details] ([Def_Return_ID], [Purchase_ID], [Purchase_Detail_ID], [Item_ID], [Return_QTY], [Unit], [Return_ID]) VALUES (2, 1, 14, 20, 10, N'Piece(s)', 2)
INSERT [dbo].[TBL_Deffective_PO_Return_Details] ([Def_Return_ID], [Purchase_ID], [Purchase_Detail_ID], [Item_ID], [Return_QTY], [Unit], [Return_ID]) VALUES (3, 3, 20, 47, 2, N'Piece(s)', 3)
INSERT [dbo].[TBL_Deffective_PO_Return_Details] ([Def_Return_ID], [Purchase_ID], [Purchase_Detail_ID], [Item_ID], [Return_QTY], [Unit], [Return_ID]) VALUES (4, 6, 60, 56, 1, N'Piece(s)', 4)
INSERT [dbo].[TBL_Deffective_PO_Return_Details] ([Def_Return_ID], [Purchase_ID], [Purchase_Detail_ID], [Item_ID], [Return_QTY], [Unit], [Return_ID]) VALUES (5, 6, 60, 56, 3, N'Piece(s)', 5)
SET IDENTITY_INSERT [dbo].[TBL_Deffective_PO_Return_Details] OFF
/****** Object:  Table [dbo].[TBL_Deffective_PO_Return]    Script Date: 04/17/2011 02:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Deffective_PO_Return](
	[Return_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Purchase_ID] [bigint] NULL,
	[SupplierName] [varchar](max) NULL,
	[Delivery_Term] [varchar](max) NULL,
	[Address] [varchar](max) NULL,
	[Return_Date] [datetime] NULL,
	[DEF_PO_ID] [bigint] NULL,
	[Fully_Return] [varchar](max) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Deffective_PO_Return] ON
INSERT [dbo].[TBL_Deffective_PO_Return] ([Return_ID], [Purchase_ID], [SupplierName], [Delivery_Term], [Address], [Return_Date], [DEF_PO_ID], [Fully_Return]) VALUES (1, 3, N'Genstar Auto Supply', N'Paid after deliver', N'Taft Ave. Ext.$..$ Pasay City', CAST(0x00009E9C00000000 AS DateTime), 1, N'Yes')
INSERT [dbo].[TBL_Deffective_PO_Return] ([Return_ID], [Purchase_ID], [SupplierName], [Delivery_Term], [Address], [Return_Date], [DEF_PO_ID], [Fully_Return]) VALUES (2, 1, N'Eco Parts Commercial', N'Paid after deliver', N'917-B Aurora Boulevard Silangan Cubao Quezon City', CAST(0x00009E9C00000000 AS DateTime), 2, N'Yes')
INSERT [dbo].[TBL_Deffective_PO_Return] ([Return_ID], [Purchase_ID], [SupplierName], [Delivery_Term], [Address], [Return_Date], [DEF_PO_ID], [Fully_Return]) VALUES (3, 3, N'Genstar Auto Supply', N'Paid after deliver', N'Taft Ave. Ext.$..$ Pasay City', CAST(0x00009E9C00000000 AS DateTime), 3, N'Yes')
INSERT [dbo].[TBL_Deffective_PO_Return] ([Return_ID], [Purchase_ID], [SupplierName], [Delivery_Term], [Address], [Return_Date], [DEF_PO_ID], [Fully_Return]) VALUES (4, 6, N'Chuey Trading Inc', N'Paid after deliver', N'1A Cadena De Amor. St. Roxas Dist.$..$ Q.C.', CAST(0x00009E9C00000000 AS DateTime), 4, N'Yes')
INSERT [dbo].[TBL_Deffective_PO_Return] ([Return_ID], [Purchase_ID], [SupplierName], [Delivery_Term], [Address], [Return_Date], [DEF_PO_ID], [Fully_Return]) VALUES (5, 6, N'Chuey Trading Inc', N'Paid after deliver', N'1A Cadena De Amor. St. Roxas Dist.$..$ Q.C.', CAST(0x00009E9C00000000 AS DateTime), 5, N'Yes')
SET IDENTITY_INSERT [dbo].[TBL_Deffective_PO_Return] OFF
/****** Object:  Table [dbo].[TBL_Deffective_PO_Details]    Script Date: 04/17/2011 02:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Deffective_PO_Details](
	[Def_ID_Details] [bigint] IDENTITY(1,1) NOT NULL,
	[Purchase_ID] [bigint] NULL,
	[Purchase_Detail_ID] [bigint] NULL,
	[Item_ID] [bigint] NULL,
	[Def_QTY] [bigint] NULL,
	[Unit] [varchar](50) NULL,
	[DEF_PO_ID] [bigint] NULL,
	[Pending_ID] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Deffective_PO_Details] ON
INSERT [dbo].[TBL_Deffective_PO_Details] ([Def_ID_Details], [Purchase_ID], [Purchase_Detail_ID], [Item_ID], [Def_QTY], [Unit], [DEF_PO_ID], [Pending_ID]) VALUES (1, 3, 30, 38, 1, N'Piece(s)', 1, 1)
INSERT [dbo].[TBL_Deffective_PO_Details] ([Def_ID_Details], [Purchase_ID], [Purchase_Detail_ID], [Item_ID], [Def_QTY], [Unit], [DEF_PO_ID], [Pending_ID]) VALUES (2, 1, 14, 20, 10, N'Piece(s)', 2, 0)
INSERT [dbo].[TBL_Deffective_PO_Details] ([Def_ID_Details], [Purchase_ID], [Purchase_Detail_ID], [Item_ID], [Def_QTY], [Unit], [DEF_PO_ID], [Pending_ID]) VALUES (3, 3, 20, 47, 2, N'Piece(s)', 3, 0)
INSERT [dbo].[TBL_Deffective_PO_Details] ([Def_ID_Details], [Purchase_ID], [Purchase_Detail_ID], [Item_ID], [Def_QTY], [Unit], [DEF_PO_ID], [Pending_ID]) VALUES (4, 6, 60, 56, 1, N'Piece(s)', 4, 0)
INSERT [dbo].[TBL_Deffective_PO_Details] ([Def_ID_Details], [Purchase_ID], [Purchase_Detail_ID], [Item_ID], [Def_QTY], [Unit], [DEF_PO_ID], [Pending_ID]) VALUES (5, 6, 60, 56, 3, N'Piece(s)', 5, 2)
SET IDENTITY_INSERT [dbo].[TBL_Deffective_PO_Details] OFF
/****** Object:  Table [dbo].[TBL_Deffective_PO]    Script Date: 04/17/2011 02:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Deffective_PO](
	[DEF_PO_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Purchase_ID] [bigint] NULL,
	[SupplierName] [varchar](max) NULL,
	[Delivery_Term] [varchar](max) NULL,
	[Address] [varchar](max) NULL,
	[Return_Date] [datetime] NULL,
	[Pending_ID] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Deffective_PO] ON
INSERT [dbo].[TBL_Deffective_PO] ([DEF_PO_ID], [Purchase_ID], [SupplierName], [Delivery_Term], [Address], [Return_Date], [Pending_ID]) VALUES (1, 3, N'Genstar Auto Supply', N'Paid after deliver', N'Taft Ave. Ext.$..$ Pasay City', CAST(0x00009E9C00000000 AS DateTime), 1)
INSERT [dbo].[TBL_Deffective_PO] ([DEF_PO_ID], [Purchase_ID], [SupplierName], [Delivery_Term], [Address], [Return_Date], [Pending_ID]) VALUES (2, 1, N'Eco Parts Commercial', N'Paid after deliver', N'917-B Aurora Boulevard Silangan Cubao Quezon City', CAST(0x00009E9C00000000 AS DateTime), 0)
INSERT [dbo].[TBL_Deffective_PO] ([DEF_PO_ID], [Purchase_ID], [SupplierName], [Delivery_Term], [Address], [Return_Date], [Pending_ID]) VALUES (3, 3, N'Genstar Auto Supply', N'Paid after deliver', N'Taft Ave. Ext.$..$ Pasay City', CAST(0x00009E9C00000000 AS DateTime), 0)
INSERT [dbo].[TBL_Deffective_PO] ([DEF_PO_ID], [Purchase_ID], [SupplierName], [Delivery_Term], [Address], [Return_Date], [Pending_ID]) VALUES (4, 6, N'Chuey Trading Inc', N'Paid after deliver', N'1A Cadena De Amor. St. Roxas Dist.$..$ Q.C.', CAST(0x00009E9C00000000 AS DateTime), 0)
INSERT [dbo].[TBL_Deffective_PO] ([DEF_PO_ID], [Purchase_ID], [SupplierName], [Delivery_Term], [Address], [Return_Date], [Pending_ID]) VALUES (5, 6, N'Chuey Trading Inc', N'Paid after deliver', N'1A Cadena De Amor. St. Roxas Dist.$..$ Q.C.', CAST(0x00009E9C00000000 AS DateTime), 2)
SET IDENTITY_INSERT [dbo].[TBL_Deffective_PO] OFF
/****** Object:  Table [dbo].[TBL_Category_Item_File]    Script Date: 04/17/2011 02:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Category_Item_File](
	[Catg_ID] [bigint] NULL,
	[Item_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Item_Name] [varchar](max) NULL,
	[Item_Description] [varchar](max) NULL,
	[Item_BarCode] [bigint] NULL,
	[Item_Reorder_Point] [bigint] NULL,
	[Item_Price] [money] NULL,
	[Unit_Measure] [varchar](50) NULL,
	[Item_Org_Price] [money] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Category_Item_File] ON
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (1, 1, N'Bumper Support', N'MB-109915', 9734, 3, 168.0000, N'Piece(s)', 150.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (1, 2, N'Bumper Support', N'MB-109916', 9735, 3, 168.0000, N'Piece(s)', 150.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (2, 3, N'Center Bearing Assembly', N'1-37510-105-10', 83274, 1, 757.1200, N'Piece(s)', 676.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (2, 4, N'CenterBearingAssembly', N'37521-36G25', 12789, 1, 476.0000, N'Piece(s)', 425.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (3, 5, N'Engine Support $.$$.$echo$.$$.$', N'8-94172-018-1', 21837, 2, 162.4000, N'Piece(s)', 145.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (3, 6, N'Engine Support "echo"', N'8-94172-019-1', 9834128, 4, 162.4000, N'Piece(s)', 145.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (3, 7, N'Engine Support $.$echo$.$', N'12361-16040', 218793, 2, 392.0000, N'Piece(s)', 350.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (4, 8, N'Shock Absorber Mounting', N'48609-12270', 128937, 2, 448.0000, N'Piece(s)', 400.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (5, 9, N'ATF Dexron III', N'ATF Dexron III', 1207893, 5, 229.6000, N'Liter(s)', 205.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (5, 10, N'Common Rail', N'Common Rail', 92874, 5, 252.0000, N'Liter(s)', 225.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (6, 14, N'Halogen Bulb $.$Narva$.$', N'48328', 718263, 3, 201.6000, N'Piece(s)', 180.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (6, 15, N'Halogen Bulb "Narva"', N'48892', 89034, 5, 151.2000, N'Piece(s)', 135.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (6, 16, N'Halogen Bulb Narva', N'48881', 567434, 5, 100.8000, N'Piece(s)', 90.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (6, 17, N'Halogen Bulb "Narva"', N'48901', 12983, 5, 123.2000, N'Piece(s)', 110.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (7, 18, N'Crystal Bulb', N'171771', 237894, 50, 10.0000, N'Piece(s)', 10.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (8, 19, N'Auto Bulb "Narva"', N'17311', 12873, 50, 13.4400, N'Piece(s)', 12.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (8, 20, N'Auto Bulb "Narva"', N'17328', 129037, 5, 19.0400, N'Piece(s)', 17.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (9, 21, N'Ribbed Ace Belt', N'4PK-760', 523123, 1, 383.1520, N'Piece(s)', 342.1000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (9, 22, N'Ribbed Ace Belt', N'4PK-770', 52231, 1, 388.1920, N'Piece(s)', 346.6000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (10, 23, N'Bando Cogbelt', N'RPF-5460', 21763, 2, 485.6320, N'Piece(s)', 433.6000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (11, 24, N'Timing Belt', N'123 YH24', 328947, 2, 485.6320, N'Piece(s)', 433.6000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (11, 25, N'Timing Belt', N'163 ZBS25', 213678, 0, 632.8000, N'Piece(s)', 565.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (11, 26, N'Timing Belt', N'83 ZBS19', 28713, 0, 304.6400, N'Piece(s)', 272.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (10, 27, N'Bando Cogbelt', N'RPF-2345', 2374823, 2, 227.0240, N'Piece(s)', 202.7000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (10, 28, N'Bando Cogbelt', N'RPF 2385', 412127, 2, 253.3440, N'Piece(s)', 226.2000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (10, 29, N'Bando Cogbelt', N'RPF 2395', 812673, 2, 259.8400, N'Piece(s)', 232.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (10, 30, N'Bando Cogbelt', N'RPF 3280', 53781, 2, 194.9920, N'Piece(s)', 174.1000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (10, 31, N'Bando Cogbelt', N'RPF 5400', 34897, 1, 422.2400, N'Piece(s)', 377.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (10, 32, N'Bando Cogbelt', N'RPF 5540', 2343984, 2, 569.9680, N'Piece(s)', 508.9000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (10, 33, N'Bando Cogbelt', N'RPF 5660', 23074, 0, 696.6400, N'Piece(s)', 622.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (14, 34, N'Exhaust Manifold Gasket 5k', N'17172-13030', 781236, 5, 43.4560, N'Piece(s)', 38.8000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (15, 35, N'Exhause Manifold Gasket', N'5-14145-004-0', 823732, 5, 54.6560, N'Piece(s)', 48.8000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (15, 36, N'Exhaust Manifold Gasket', N'013811', 23186, 2, 54.6560, N'Piece(s)', 48.8000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (16, 37, N'Oil Pan Gasket 4BA1', N'9-11367-614-0', 3248721, 1, 144.2560, N'Piece(s)', 128.8000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (17, 38, N'Oil Pan Gasket 4BC2 4.5mm', N'5-11367-064-0', 3247321, 1, 256.2560, N'Piece(s)', 228.8000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (18, 39, N'Cylinder Head Gasket Steel', N'OK71E-10-271', 36784, 1, 827.4560, N'Piece(s)', 738.8000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (19, 40, N'Cylinder Head Gasket', N'RHG84338', 723648, 1, 739.2000, N'Piece(s)', 660.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (19, 41, N'Cylinder Head Gasket', N'RHG60440', 832758, 2, 683.2000, N'Piece(s)', 610.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (19, 42, N'Cylinder Head Gasket', N'RHG60043', 734651, 2, 156.8000, N'Piece(s)', 140.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (19, 43, N'Cylinder Head Gasket', N'RHG60561', 167152, 2, 156.8000, N'Piece(s)', 140.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (19, 44, N'Cylinder Head Gasket', N'RHG98466', 23489571, 2, 750.4000, N'Piece(s)', 670.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (12, 45, N'Valve Cover Gasket 4D56', N'050312', 238741, 2, 110.6560, N'Piece(s)', 98.8000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (13, 46, N'Valve Cover Gasket', N'YVCG-V410', 3497521, 2, 155.4560, N'Piece(s)', 138.8000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (20, 47, N'Oil Filter', N'C-102', 798421, 2, 154.0000, N'Piece(s)', 154.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (20, 48, N'Oil Filter', N'C-303', 65798132, 2, 162.0000, N'Piece(s)', 162.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (20, 49, N'Oil Filter', N'C-110', 546987, 2, 133.0000, N'Piece(s)', 133.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (20, 50, N'Oil Filter', N'C-503', 1389047, 2, 239.0000, N'Piece(s)', 239.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (21, 51, N'Fuel Filter', N'FC-317', 5465132, 2, 239.0000, N'Piece(s)', 239.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (5, 11, N'Speed Max 430', N'Speed Max 430', 912038, 5, 285.6000, N'Liter(s)', 255.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (5, 12, N'Common Rail (G)', N'Common Rail (G)', 823904, 4, 1085.2800, N'Gallon(s)', 969.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (5, 13, N'Speed Max 430 (G)', N'Speed Max 430 (G)', 267136, 3, 1435.8400, N'Gallon(s)', 1282.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (21, 52, N'Fuel Filter', N'FC-321', 345681, 2, 588.0000, N'Piece(s)', 588.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (21, 53, N'Fuel Filter', N'FC-208A', 27489, 2, 187.0000, N'Piece(s)', 187.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (22, 54, N'Clutch Master Assembly', N'8-97102-437-0', 347959, 1, 840.0000, N'Piece(s)', 750.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (23, 55, N'Titan', N'172-RH-P423', 8641523, 5, 1680.0000, N'Piece(s)', 1500.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (24, 56, N'test', N'test', 1203978273198, 2, 560.0000, N'Piece(s)', 500.0000)
INSERT [dbo].[TBL_Category_Item_File] ([Catg_ID], [Item_ID], [Item_Name], [Item_Description], [Item_BarCode], [Item_Reorder_Point], [Item_Price], [Unit_Measure], [Item_Org_Price]) VALUES (25, 57, N'NISSAN TEST', N'NISSAN TEST 0234', 441123, 1, 582.4000, N'Piece(s)', 520.0000)
SET IDENTITY_INSERT [dbo].[TBL_Category_Item_File] OFF
/****** Object:  Table [dbo].[TBL_Category_File]    Script Date: 04/17/2011 02:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Category_File](
	[Catg_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Catg_Name] [varchar](max) NULL,
	[Catg_Description] [varchar](max) NULL,
	[Group_ID] [bigint] NULL,
 CONSTRAINT [PK_TBL_Category_File] PRIMARY KEY CLUSTERED 
(
	[Catg_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Category_File] ON
INSERT [dbo].[TBL_Category_File] ([Catg_ID], [Catg_Name], [Catg_Description], [Group_ID]) VALUES (1, N'Bumper Support', N'Maxx Brand', 1)
INSERT [dbo].[TBL_Category_File] ([Catg_ID], [Catg_Name], [Catg_Description], [Group_ID]) VALUES (2, N'Center Bearing Assembly', N'Maxx Brand', 1)
INSERT [dbo].[TBL_Category_File] ([Catg_ID], [Catg_Name], [Catg_Description], [Group_ID]) VALUES (3, N'Engine Support', N'Maxx Brand', 1)
INSERT [dbo].[TBL_Category_File] ([Catg_ID], [Catg_Name], [Catg_Description], [Group_ID]) VALUES (4, N'Shock Absorber Mounting', N'Maxx Brand', 1)
INSERT [dbo].[TBL_Category_File] ([Catg_ID], [Catg_Name], [Catg_Description], [Group_ID]) VALUES (5, N'AMCO Transmission Fluid', N'AMCO Transmission Fluid', 2)
INSERT [dbo].[TBL_Category_File] ([Catg_ID], [Catg_Name], [Catg_Description], [Group_ID]) VALUES (6, N'Halogen Bulb', N'Halogen Bulb', 3)
INSERT [dbo].[TBL_Category_File] ([Catg_ID], [Catg_Name], [Catg_Description], [Group_ID]) VALUES (7, N'Crystal Bulb', N'Crystal Bulb', 3)
INSERT [dbo].[TBL_Category_File] ([Catg_ID], [Catg_Name], [Catg_Description], [Group_ID]) VALUES (8, N'Auto Bulb', N'Auto Bulb', 3)
INSERT [dbo].[TBL_Category_File] ([Catg_ID], [Catg_Name], [Catg_Description], [Group_ID]) VALUES (9, N'Ribbed Ace Belt', N'Ribbed Ace Belt', 4)
INSERT [dbo].[TBL_Category_File] ([Catg_ID], [Catg_Name], [Catg_Description], [Group_ID]) VALUES (10, N'Bando Cogbelt', N'Bando Cogbelt', 4)
INSERT [dbo].[TBL_Category_File] ([Catg_ID], [Catg_Name], [Catg_Description], [Group_ID]) VALUES (11, N'Timing Belt', N'Timing Belt', 4)
INSERT [dbo].[TBL_Category_File] ([Catg_ID], [Catg_Name], [Catg_Description], [Group_ID]) VALUES (12, N'Valve Cover Gasket 4D56', N'Valve Cover Gasket 4D56', 5)
INSERT [dbo].[TBL_Category_File] ([Catg_ID], [Catg_Name], [Catg_Description], [Group_ID]) VALUES (13, N'Valve Cover Gasket', N'Valve Cover Gasket', 5)
INSERT [dbo].[TBL_Category_File] ([Catg_ID], [Catg_Name], [Catg_Description], [Group_ID]) VALUES (14, N'Exhaust Manifold Gasket 5k', N'Exhaust Manifold Gasket 5k', 5)
INSERT [dbo].[TBL_Category_File] ([Catg_ID], [Catg_Name], [Catg_Description], [Group_ID]) VALUES (15, N'Exhaust Manifold Gasket', N'Exhaust Manifold Gasket', 5)
INSERT [dbo].[TBL_Category_File] ([Catg_ID], [Catg_Name], [Catg_Description], [Group_ID]) VALUES (16, N'Oil Pan Gasket 4BA1', N'Oil Pan Gasket 4BA1', 5)
INSERT [dbo].[TBL_Category_File] ([Catg_ID], [Catg_Name], [Catg_Description], [Group_ID]) VALUES (17, N'Oil Pan Gasket 4BC2 4.5mm', N'Oil Pan Gasket 4BC2 4.5mm', 5)
INSERT [dbo].[TBL_Category_File] ([Catg_ID], [Catg_Name], [Catg_Description], [Group_ID]) VALUES (18, N'Cylinder Head Gasket Steel', N'Cylinder Head Gasket Steel', 5)
INSERT [dbo].[TBL_Category_File] ([Catg_ID], [Catg_Name], [Catg_Description], [Group_ID]) VALUES (19, N'Cylinder Head Gasket', N'Cylinder Head Gasket', 6)
INSERT [dbo].[TBL_Category_File] ([Catg_ID], [Catg_Name], [Catg_Description], [Group_ID]) VALUES (20, N'Oil Filter', N'Oil Filter', 7)
INSERT [dbo].[TBL_Category_File] ([Catg_ID], [Catg_Name], [Catg_Description], [Group_ID]) VALUES (21, N'Fuel Filter', N'Fuel Filter', 7)
INSERT [dbo].[TBL_Category_File] ([Catg_ID], [Catg_Name], [Catg_Description], [Group_ID]) VALUES (22, N'Clutch Master Assembly', N'FTC Brand', 9)
INSERT [dbo].[TBL_Category_File] ([Catg_ID], [Catg_Name], [Catg_Description], [Group_ID]) VALUES (23, N'Toyota Shock Absorber', N'Toyota', 10)
INSERT [dbo].[TBL_Category_File] ([Catg_ID], [Catg_Name], [Catg_Description], [Group_ID]) VALUES (24, N'Nissan Ball Joint', N'Nissan', 11)
INSERT [dbo].[TBL_Category_File] ([Catg_ID], [Catg_Name], [Catg_Description], [Group_ID]) VALUES (25, N'NISSAN HOOD', N'NISSAN HOOD', 12)
SET IDENTITY_INSERT [dbo].[TBL_Category_File] OFF
/****** Object:  Table [dbo].[TBL_Barcode]    Script Date: 04/17/2011 02:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Barcode](
	[Barcode1] [varchar](max) NULL,
	[Barcode2] [varchar](max) NULL,
	[Barcode3] [varchar](max) NULL,
	[Barcode4] [varchar](max) NULL,
	[Barcode5] [varchar](max) NULL,
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_TBL_Barcode] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Barcode] ON
INSERT [dbo].[TBL_Barcode] ([Barcode1], [Barcode2], [Barcode3], [Barcode4], [Barcode5], [ID]) VALUES (N'441123', N'1203978273198', N'8641523', NULL, NULL, 19)
SET IDENTITY_INSERT [dbo].[TBL_Barcode] OFF
/****** Object:  Table [dbo].[TBL_Audit_Trail]    Script Date: 04/17/2011 02:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Audit_Trail](
	[Audit_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[User_ID] [bigint] NOT NULL,
	[Date] [datetime] NULL,
	[Action] [varchar](50) NULL,
	[Timex] [varchar](50) NULL,
	[Log_ID] [bigint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Audit_Trail] ON
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (2, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'12:09:30 PM', 2)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (3, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Products Purchasing Order and Receive Form', N'12:09:47 PM', 2)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (4, 9, CAST(0x00009E9C00000000 AS DateTime), N'Add New Purchase Order Stocks', N'12:12:01 PM', 2)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (5, 9, CAST(0x00009E9C00000000 AS DateTime), N'Edit Purchase Order Stocks', N'12:12:14 PM', 2)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (6, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Stocks Monitoring Balances', N'12:12:20 PM', 2)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (7, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'12:12:09 PM', 3)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (8, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Stocks Monitoring Balances', N'12:12:17 PM', 3)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (10, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Stocks Monitoring Balances', N'12:12:50 PM', 3)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (11, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Product Listing', N'12:13:22 PM', 2)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (12, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Product Listing', N'12:14:53 PM', 3)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (13, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Suppliers Profile', N'12:14:53 PM', 3)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (14, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Products Purchasing Order and Receive Form', N'12:14:55 PM', 3)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (15, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Stocks Monitoring Balances', N'12:14:55 PM', 3)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (16, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Products On Reorder Point', N'12:14:56 PM', 3)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (17, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Deffective and Return Stocks', N'12:14:57 PM', 3)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (18, 9, CAST(0x00009E9C00000000 AS DateTime), N'Add New Purchase Order Stocks', N'12:15:59 PM', 2)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (19, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'12:16:29 PM', 4)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (20, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Product Listing', N'12:16:31 PM', 4)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (21, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Suppliers Profile', N'12:16:34 PM', 4)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (22, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Stocks Monitoring Balances', N'12:16:37 PM', 4)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (23, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Products Purchasing Order and Receive Form', N'12:16:38 PM', 4)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (24, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Products On Reorder Point', N'12:16:41 PM', 4)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (25, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Deffective and Return Stocks', N'12:16:42 PM', 4)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (26, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Products On Reorder Point', N'12:17:16 PM', 4)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (27, 12, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'12:17:47 PM', 5)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (28, 9, CAST(0x00009E9C00000000 AS DateTime), N'Add New Purchase Order Stocks', N'12:20:13 PM', 2)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (29, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Suppliers Profile', N'12:20:21 PM', 2)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (30, 9, CAST(0x00009E9C00000000 AS DateTime), N'Add New Purchase Order Stocks', N'12:22:51 PM', 2)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (31, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'12:24:01 PM', 6)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (32, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Product Listing', N'12:24:05 PM', 6)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (33, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Sales Receipt Listing', N'12:25:31 PM', 6)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (40, 9, CAST(0x00009E9C00000000 AS DateTime), N'Add New Purchase Order Stocks', N'12:30:32 PM', 2)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (61, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Deffective and Return Stocks', N'12:46:38 PM', 2)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (62, 9, CAST(0x00009E9C00000000 AS DateTime), N'Add New Deffective Stocks', N'12:48:03 PM', 2)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (63, 9, CAST(0x00009E9C00000000 AS DateTime), N'Add New Deffective Stocks', N'12:49:13 PM', 2)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (69, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'12:57:09 PM', 17)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (70, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Stocks Monitoring Balances', N'12:57:33 PM', 17)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (71, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Products On Reorder Point', N'12:57:36 PM', 17)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (72, 9, CAST(0x00009E9C00000000 AS DateTime), N'Print Report - Collection Summary ', N'12:57:58 PM', 17)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (73, 9, CAST(0x00009E9C00000000 AS DateTime), N'Print Report - Sales Collection ', N'12:58:09 PM', 17)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (74, 9, CAST(0x00009E9C00000000 AS DateTime), N'Print Report - Collection Summary ', N'12:58:44 PM', 17)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (75, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'1:03:23 PM', 18)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (76, 9, CAST(0x00009E9C00000000 AS DateTime), N'Add New User Account ', N'1:04:39 PM', 18)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (77, 15, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'1:04:48 PM', 19)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (78, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'1:05:00 PM', 20)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (79, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Sales Receipt Listing', N'1:06:50 PM', 17)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (80, 9, CAST(0x00009E9C00000000 AS DateTime), N'Print Report - Suppliers Listing', N'1:07:27 PM', 17)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (82, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'1:09:31 PM', 22)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (83, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'1:10:43 PM', 23)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (84, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Product Listing', N'1:11:13 PM', 23)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (85, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'1:12:00 PM', 24)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (86, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'1:13:07 PM', 25)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (89, 14, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'1:16:38 PM', 27)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (107, 14, CAST(0x00009E9C00000000 AS DateTime), N'View Products Purchasing Order and Receive Form', N'1:26:16 PM', 27)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (108, 14, CAST(0x00009E9C00000000 AS DateTime), N'Print Report - Purchase Order ', N'1:26:21 PM', 27)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (112, 14, CAST(0x00009E9C00000000 AS DateTime), N'View Products Purchasing Order and Receive Form', N'1:27:06 PM', 27)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (113, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'1:28:41 PM', 32)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (114, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Deffective and Return Stocks', N'1:28:52 PM', 32)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (115, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'1:29:52 PM', 33)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (116, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Deffective and Return Stocks', N'1:30:16 PM', 33)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (117, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Products Purchasing Order and Receive Form', N'1:32:17 PM', 33)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (118, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Products On Reorder Point', N'1:33:49 PM', 33)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (119, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Sales Receipt Listing', N'1:34:38 PM', 33)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (120, 9, CAST(0x00009E9C00000000 AS DateTime), N'Receipt Void Receipt No: 2', N'1:34:43 PM', 33)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (121, 9, CAST(0x00009E9C00000000 AS DateTime), N'Print New Sales Receipt Receipt No : 4', N'1:35:18 PM', 33)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (122, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'2:21:54 PM', 34)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (123, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Deffective and Return Stocks', N'2:22:09 PM', 34)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (124, 9, CAST(0x00009E9C00000000 AS DateTime), N'Add New User Account ', N'2:23:08 PM', 34)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (125, 16, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'2:23:46 PM', 35)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (126, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'2:23:58 PM', 36)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (127, 13, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'2:24:29 PM', 37)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (128, 14, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'2:24:48 PM', 38)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (129, 14, CAST(0x00009E9C00000000 AS DateTime), N'View Product Listing', N'2:24:55 PM', 38)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (130, 12, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'2:27:50 PM', 39)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (131, 12, CAST(0x00009E9C00000000 AS DateTime), N'View Sales Receipt Listing', N'2:28:09 PM', 39)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (133, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'2:29:19 PM', 40)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (134, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Product Listing', N'2:29:21 PM', 40)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (135, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'2:30:50 PM', 41)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (136, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Product Listing', N'2:30:59 PM', 41)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (145, 14, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'2:36:55 PM', 45)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (146, 14, CAST(0x00009E9C00000000 AS DateTime), N'View Suppliers Profile', N'2:37:10 PM', 45)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (147, 14, CAST(0x00009E9C00000000 AS DateTime), N'Edit Suppliers Products ', N'2:37:45 PM', 45)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (148, 14, CAST(0x00009E9C00000000 AS DateTime), N'View Products Purchasing Order and Receive Form', N'2:37:48 PM', 45)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (149, 14, CAST(0x00009E9C00000000 AS DateTime), N'Add New Purchase Order Stocks', N'2:38:06 PM', 45)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (168, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Product Listing', N'2:53:53 PM', 48)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (171, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'2:55:38 PM', 50)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (172, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Sales Receipt Listing', N'2:55:48 PM', 50)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (173, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'2:56:44 PM', 51)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (174, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Sales Receipt Listing', N'2:56:54 PM', 51)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (175, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Product Listing', N'2:58:52 PM', 48)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (176, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'3:02:01 PM', 52)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (177, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Sales Receipt Listing', N'3:02:14 PM', 52)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (178, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'3:05:09 PM', 53)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (179, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Sales Receipt Listing', N'3:05:21 PM', 53)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (180, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Product Listing', N'3:06:37 PM', 53)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (181, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Stocks Monitoring Balances', N'3:07:33 PM', 48)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (184, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Product Listing', N'3:09:40 PM', 48)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (185, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Suppliers Profile', N'3:09:49 PM', 48)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (189, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Suppliers Profile', N'3:10:32 PM', 48)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (190, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Product Listing', N'3:10:33 PM', 48)
GO
print 'Processed 100 total records'
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (9, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Products Purchasing Order and Receive Form', N'12:12:22 PM', 3)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (165, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Product Listing', N'2:52:12 PM', 48)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (166, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Product Listing', N'2:52:41 PM', 48)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (192, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Supplies and Property File', N'3:11:49 PM', 48)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (193, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Product Listing', N'3:11:57 PM', 48)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (194, 12, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'3:15:20 PM', 56)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (195, 12, CAST(0x00009E9C00000000 AS DateTime), N'View Sales Receipt Listing', N'3:15:38 PM', 56)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (198, 12, CAST(0x00009E9C00000000 AS DateTime), N'View Sales Receipt Listing', N'3:26:05 PM', 56)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (199, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'3:30:11 PM', 58)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (200, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'3:32:52 PM', 59)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (201, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Sales Receipt Listing', N'3:33:04 PM', 59)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (202, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'3:36:18 PM', 60)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (203, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Sales Receipt Listing', N'3:36:30 PM', 60)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (204, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'3:38:48 PM', 61)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (205, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Sales Receipt Listing', N'3:38:59 PM', 61)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (208, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'4:19:50 PM', 63)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (209, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Sales Receipt Listing', N'4:20:01 PM', 63)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (210, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'4:23:40 PM', 64)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (211, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Sales Receipt Listing', N'4:23:50 PM', 64)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (212, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'4:30:49 PM', 65)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (213, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'5:44:34 PM', 66)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (214, 9, CAST(0x00009E9C00000000 AS DateTime), N'Print Report - Suppliers Listing', N'5:44:43 PM', 66)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (215, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'5:46:53 PM', 67)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (216, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Products On Reorder Point', N'5:47:02 PM', 67)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (218, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'5:50:06 PM', 68)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (219, 9, CAST(0x00009E9C00000000 AS DateTime), N'Print Report - Purchase Order ', N'5:50:18 PM', 68)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (220, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Product Listing', N'5:55:37 PM', 67)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (222, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Products Purchasing Order and Receive Form', N'5:56:47 PM', 69)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (223, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Products Purchasing Order and Receive Form', N'5:56:57 PM', 69)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (224, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Products Purchasing Order and Receive Form', N'5:57:07 PM', 69)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (225, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Product Listing', N'5:57:30 PM', 69)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (226, 14, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'5:57:44 PM', 70)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (227, 14, CAST(0x00009E9C00000000 AS DateTime), N'View Product Listing', N'5:57:46 PM', 70)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (228, 12, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'5:57:35 PM', 71)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (229, 14, CAST(0x00009E9C00000000 AS DateTime), N'Add New Data On Category Listing ', N'5:58:21 PM', 70)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (230, 12, CAST(0x00009E9C00000000 AS DateTime), N'View Sales Receipt Listing', N'5:58:35 PM', 71)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (231, 14, CAST(0x00009E9C00000000 AS DateTime), N'Add New Item File List', N'5:58:56 PM', 70)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (232, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'5:58:51 PM', 72)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (233, 14, CAST(0x00009E9C00000000 AS DateTime), N'View Suppliers Profile', N'5:59:04 PM', 70)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (234, 14, CAST(0x00009E9C00000000 AS DateTime), N'Edit Suppliers Products ', N'5:59:15 PM', 70)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (235, 14, CAST(0x00009E9C00000000 AS DateTime), N'View Products Purchasing Order and Receive Form', N'5:59:19 PM', 70)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (236, 14, CAST(0x00009E9C00000000 AS DateTime), N'Add New Purchase Order Stocks', N'5:59:43 PM', 70)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (237, 12, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'5:59:44 PM', 73)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (238, 14, CAST(0x00009E9C00000000 AS DateTime), N'View Stocks Monitoring Balances', N'6:02:19 PM', 70)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (239, 12, CAST(0x00009E9C00000000 AS DateTime), N'Print New Sales Receipt Receipt No : 6', N'6:02:53 PM', 73)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (240, 12, CAST(0x00009E9C00000000 AS DateTime), N'View Sales Receipt Listing', N'6:03:41 PM', 73)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (244, 12, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'6:07:22 PM', 74)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (245, 12, CAST(0x00009E9C00000000 AS DateTime), N'View Sales Receipt Listing', N'6:07:32 PM', 74)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (246, 12, CAST(0x00009E9C00000000 AS DateTime), N'View Sales Receipt Listing', N'6:07:37 PM', 74)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (247, 14, CAST(0x00009E9C00000000 AS DateTime), N'Edit Return Stocks', N'6:08:43 PM', 70)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (248, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'6:10:08 PM', 75)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (249, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Sales Receipt Listing', N'6:10:11 PM', 75)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (250, 9, CAST(0x00009E9C00000000 AS DateTime), N'Receipt Void Receipt No: 0', N'6:10:14 PM', 75)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (251, 12, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'6:11:00 PM', 76)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (252, 12, CAST(0x00009E9C00000000 AS DateTime), N'Print New Sales Receipt Receipt No : 7', N'6:12:04 PM', 76)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (253, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'6:12:55 PM', 77)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (254, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Products On Reorder Point', N'6:15:13 PM', 77)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (255, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Products On Reorder Point', N'6:15:20 PM', 77)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (256, 9, CAST(0x00009E9C00000000 AS DateTime), N'Add New Purchase Order Stocks', N'6:15:34 PM', 77)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (257, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Stocks Monitoring Balances', N'6:15:45 PM', 77)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (258, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Stocks Monitoring Balances', N'6:17:33 PM', 77)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (259, 9, CAST(0x00009E9C00000000 AS DateTime), N'Print Report - Sales Collection Void ', N'6:19:34 PM', 77)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (260, 9, CAST(0x00009E9C00000000 AS DateTime), N'Print Report - Sales Collection ', N'6:20:58 PM', 77)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (262, 14, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'6:26:24 PM', 79)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (263, 14, CAST(0x00009E9C00000000 AS DateTime), N'View Physical Counting', N'6:26:36 PM', 79)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (264, 14, CAST(0x00009E9C00000000 AS DateTime), N'Add New Physical Count', N'6:26:53 PM', 79)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (299, 9, CAST(0x00009EC800000000 AS DateTime), N'Login to system ', N'1:38:53 AM', 91)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (300, 9, CAST(0x00009EC800000000 AS DateTime), N'View Deffective and Return Stocks', N'1:39:08 AM', 91)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (303, 9, CAST(0x00009EC800000000 AS DateTime), N'Login to system ', N'1:50:08 AM', 93)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (304, 9, CAST(0x00009EC800000000 AS DateTime), N'Login to system ', N'1:55:00 AM', 94)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (305, 9, CAST(0x00009EC800000000 AS DateTime), N'View Product Listing', N'1:55:05 AM', 94)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (306, 9, CAST(0x00009EC800000000 AS DateTime), N'Login to system ', N'1:57:23 AM', 95)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (307, 9, CAST(0x00009EC800000000 AS DateTime), N'View Products On Reorder Point', N'1:57:42 AM', 95)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (167, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Product Listing', N'2:53:09 PM', 48)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (241, 14, CAST(0x00009E9C00000000 AS DateTime), N'View Deffective and Return Stocks', N'6:05:36 PM', 70)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (242, 14, CAST(0x00009E9C00000000 AS DateTime), N'Add New Deffective Stocks', N'6:05:49 PM', 70)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (243, 14, CAST(0x00009E9C00000000 AS DateTime), N'Add New Return Stocks', N'6:06:04 PM', 70)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (221, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'5:56:33 PM', 69)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (217, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Products Purchasing Order and Receive Form', N'5:49:17 PM', 67)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (283, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'6:41:38 PM', 88)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (81, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'1:08:00 PM', 21)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (105, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Products Purchasing Order and Receive Form', N'1:25:45 PM', 31)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (106, 9, CAST(0x00009E9C00000000 AS DateTime), N'Print Report - Purchase Order ', N'1:25:49 PM', 31)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (109, 9, CAST(0x00009E9C00000000 AS DateTime), N'Print Report - Purchase Order ', N'1:26:20 PM', 31)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (110, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Deffective and Return Stocks', N'1:26:31 PM', 31)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (111, 9, CAST(0x00009E9C00000000 AS DateTime), N'Print Report - Deffective Stocks ', N'1:26:36 PM', 31)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (160, 12, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'2:43:38 PM', 47)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (161, 12, CAST(0x00009E9C00000000 AS DateTime), N'View Sales Receipt Listing', N'2:43:48 PM', 47)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (162, 12, CAST(0x00009E9C00000000 AS DateTime), N'Print New Sales Receipt Receipt No : 5', N'2:44:04 PM', 47)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (275, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'6:39:10 PM', 86)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (276, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Deffective and Return Stocks', N'6:39:25 PM', 86)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (277, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Physical Counting', N'6:39:38 PM', 86)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (278, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'6:40:11 PM', 87)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (279, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Product Listing', N'6:40:14 PM', 87)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (280, 9, CAST(0x00009E9C00000000 AS DateTime), N'Edit Item File List', N'6:40:32 PM', 87)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (281, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Physical Counting', N'6:40:41 PM', 87)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (282, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Physical Counting', N'6:41:19 PM', 87)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (284, 14, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'6:41:31 PM', 89)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (285, 14, CAST(0x00009E9C00000000 AS DateTime), N'View Physical Counting', N'6:41:34 PM', 89)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (286, 14, CAST(0x00009E9C00000000 AS DateTime), N'View Products Purchasing Order and Receive Form', N'6:41:41 PM', 89)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (287, 14, CAST(0x00009E9C00000000 AS DateTime), N'View Deffective and Return Stocks', N'6:41:46 PM', 89)
GO
print 'Processed 200 total records'
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (288, 14, CAST(0x00009E9C00000000 AS DateTime), N'View Physical Counting', N'6:41:55 PM', 89)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (289, 14, CAST(0x00009E9C00000000 AS DateTime), N'Edit Physical Count', N'6:42:13 PM', 89)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (290, 14, CAST(0x00009E9C00000000 AS DateTime), N'View Suppliers Profile', N'6:42:37 PM', 89)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (291, 14, CAST(0x00009E9C00000000 AS DateTime), N'View Product Listing', N'6:42:41 PM', 89)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (292, 13, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'6:43:10 PM', 90)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (293, 13, CAST(0x00009E9C00000000 AS DateTime), N'View Products Purchasing Order and Receive Form', N'6:43:13 PM', 90)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (294, 13, CAST(0x00009E9C00000000 AS DateTime), N'View Stocks Monitoring Balances', N'6:43:16 PM', 90)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (295, 13, CAST(0x00009E9C00000000 AS DateTime), N'View Physical Counting', N'6:43:18 PM', 90)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (296, 13, CAST(0x00009E9C00000000 AS DateTime), N'View Products On Reorder Point', N'6:43:28 PM', 90)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (297, 13, CAST(0x00009E9C00000000 AS DateTime), N'View Deffective and Return Stocks', N'6:43:33 PM', 90)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (298, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Suppliers Profile', N'6:46:32 PM', 88)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (34, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'12:27:57 PM', 7)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (35, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Product Listing', N'12:28:12 PM', 7)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (36, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'12:29:13 PM', 8)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (37, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Stocks Monitoring Balances', N'12:29:23 PM', 8)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (38, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Products On Reorder Point', N'12:29:30 PM', 8)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (39, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Product Listing', N'12:29:40 PM', 8)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (41, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'12:30:25 PM', 9)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (42, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Product Listing', N'12:30:29 PM', 9)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (44, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'12:33:25 PM', 10)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (45, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Products On Reorder Point', N'12:34:19 PM', 10)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (46, 12, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'12:34:34 PM', 11)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (47, 12, CAST(0x00009E9C00000000 AS DateTime), N'Print New Sales Receipt Receipt No : 1', N'12:36:11 PM', 11)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (49, 13, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'12:37:26 PM', 12)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (50, 13, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'12:37:39 PM', 13)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (51, 14, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'12:37:45 PM', 14)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (52, 14, CAST(0x00009E9C00000000 AS DateTime), N'View Product Listing', N'12:37:47 PM', 14)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (53, 13, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'12:39:27 PM', 15)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (54, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'12:39:38 PM', 16)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (55, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Sales Receipt Listing', N'12:39:47 PM', 16)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (56, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Stocks Monitoring Balances', N'12:41:11 PM', 16)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (57, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Deffective and Return Stocks', N'12:43:27 PM', 16)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (58, 9, CAST(0x00009E9C00000000 AS DateTime), N'Add New Deffective Stocks', N'12:43:49 PM', 16)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (59, 9, CAST(0x00009E9C00000000 AS DateTime), N'Add New Return Stocks', N'12:44:05 PM', 16)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (60, 9, CAST(0x00009E9C00000000 AS DateTime), N'Receipt Void Receipt No: 0', N'12:45:30 PM', 16)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (64, 9, CAST(0x00009E9C00000000 AS DateTime), N'Add New Return Stocks', N'12:50:45 PM', 2)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (65, 9, CAST(0x00009E9C00000000 AS DateTime), N'Edit Return Stocks', N'12:51:43 PM', 2)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (66, 9, CAST(0x00009E9C00000000 AS DateTime), N'Add New Return Stocks', N'12:52:23 PM', 2)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (67, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Products On Reorder Point', N'12:52:41 PM', 2)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (68, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Products On Reorder Point', N'12:53:12 PM', 2)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (132, 14, CAST(0x00009E9C00000000 AS DateTime), N'Add New Data On Category Listing ', N'2:29:04 PM', 38)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (182, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'3:08:26 PM', 54)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (183, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Product Listing', N'3:08:33 PM', 54)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (186, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'3:09:59 PM', 55)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (187, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Product Listing', N'3:10:00 PM', 55)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (188, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Product Listing', N'3:10:04 PM', 55)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (191, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Sales Receipt Listing', N'3:10:36 PM', 55)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (261, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'6:26:34 PM', 78)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (265, 14, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'6:29:07 PM', 80)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (266, 14, CAST(0x00009E9C00000000 AS DateTime), N'View Physical Counting', N'6:29:14 PM', 80)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (267, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'6:31:18 PM', 81)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (268, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'6:31:52 PM', 82)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (269, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'6:33:59 PM', 83)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (270, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Physical Counting', N'6:34:16 PM', 83)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (271, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'6:34:47 PM', 84)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (272, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Physical Counting', N'6:34:54 PM', 84)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (273, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'6:36:55 PM', 85)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (274, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Physical Counting', N'6:37:02 PM', 85)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (301, 9, CAST(0x00009EC800000000 AS DateTime), N'Login to system ', N'1:47:44 AM', 0)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (302, 9, CAST(0x00009EC800000000 AS DateTime), N'Login to system ', N'1:49:00 AM', 92)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (1, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'11:26:49 AM', 1)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (43, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Stocks Monitoring Balances', N'12:32:52 PM', 2)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (48, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Sales Receipt Listing', N'12:36:40 PM', 2)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (87, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Stocks Monitoring Balances', N'1:14:18 PM', 17)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (88, 14, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'1:14:40 PM', 26)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (90, 12, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'1:16:45 PM', 28)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (91, 12, CAST(0x00009E9C00000000 AS DateTime), N'Print New Sales Receipt Receipt No : 2', N'1:17:36 PM', 28)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (92, 12, CAST(0x00009E9C00000000 AS DateTime), N'View Sales Receipt Listing', N'1:17:50 PM', 28)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (93, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'1:18:03 PM', 29)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (94, 9, CAST(0x00009E9C00000000 AS DateTime), N'Print Report - Collection Summary ', N'1:18:18 PM', 29)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (95, 9, CAST(0x00009E9C00000000 AS DateTime), N'Print Report - Collection Summary ', N'1:18:36 PM', 29)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (96, 9, CAST(0x00009E9C00000000 AS DateTime), N'Print Report - Sales Collection ', N'1:18:40 PM', 29)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (97, 9, CAST(0x00009E9C00000000 AS DateTime), N'Print New Sales Receipt Receipt No : 3', N'1:19:31 PM', 29)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (98, 9, CAST(0x00009E9C00000000 AS DateTime), N'Print Report - Sales Collection ', N'1:19:44 PM', 29)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (99, 9, CAST(0x00009E9C00000000 AS DateTime), N'Print Report - Sales Collection ', N'1:20:03 PM', 29)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (100, 9, CAST(0x00009E9C00000000 AS DateTime), N'Print Report - Collection Summary ', N'1:20:10 PM', 29)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (101, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Sales Receipt Listing', N'1:21:25 PM', 29)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (102, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'1:23:30 PM', 30)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (103, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'1:24:07 PM', 31)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (104, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Sales Receipt Listing', N'1:24:19 PM', 31)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (137, 14, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'2:32:04 PM', 42)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (138, 14, CAST(0x00009E9C00000000 AS DateTime), N'View Product Listing', N'2:32:11 PM', 42)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (139, 14, CAST(0x00009E9C00000000 AS DateTime), N'Edit Data On Category Listing ', N'2:32:51 PM', 42)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (140, 14, CAST(0x00009E9C00000000 AS DateTime), N'Edit Data On Category Listing ', N'2:33:47 PM', 42)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (141, 14, CAST(0x00009E9C00000000 AS DateTime), N'Add New Item File List', N'2:34:28 PM', 42)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (142, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'2:35:21 PM', 43)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (143, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Suppliers Profile', N'2:35:23 PM', 43)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (144, 12, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'2:36:39 PM', 44)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (150, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'2:38:08 PM', 46)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (151, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Products Purchasing Order and Receive Form', N'2:38:16 PM', 46)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (152, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Stocks Monitoring Balances', N'2:38:25 PM', 46)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (153, 14, CAST(0x00009E9C00000000 AS DateTime), N'Edit Purchase Order Stocks', N'2:40:38 PM', 45)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (154, 14, CAST(0x00009E9C00000000 AS DateTime), N'View Stocks Monitoring Balances', N'2:40:52 PM', 45)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (155, 14, CAST(0x00009E9C00000000 AS DateTime), N'View Products On Reorder Point', N'2:41:29 PM', 45)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (156, 14, CAST(0x00009E9C00000000 AS DateTime), N'View Deffective and Return Stocks', N'2:41:37 PM', 45)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (157, 14, CAST(0x00009E9C00000000 AS DateTime), N'Add New Deffective Stocks', N'2:42:03 PM', 45)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (158, 14, CAST(0x00009E9C00000000 AS DateTime), N'Add New Return Stocks', N'2:42:41 PM', 45)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (159, 14, CAST(0x00009E9C00000000 AS DateTime), N'Print Report - Deffective Stocks Return ', N'2:42:55 PM', 45)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (163, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'2:44:32 PM', 48)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (164, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Sales Receipt Listing', N'2:44:36 PM', 48)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (169, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'2:54:33 PM', 49)
GO
print 'Processed 300 total records'
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (170, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Sales Receipt Listing', N'2:54:43 PM', 49)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (196, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'3:25:00 PM', 57)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (197, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Sales Receipt Listing', N'3:25:13 PM', 57)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (206, 9, CAST(0x00009E9C00000000 AS DateTime), N'Login to system ', N'3:56:31 PM', 62)
INSERT [dbo].[TBL_Audit_Trail] ([Audit_ID], [User_ID], [Date], [Action], [Timex], [Log_ID]) VALUES (207, 9, CAST(0x00009E9C00000000 AS DateTime), N'View Sales Receipt Listing', N'3:56:47 PM', 62)
SET IDENTITY_INSERT [dbo].[TBL_Audit_Trail] OFF
/****** Object:  Table [dbo].[TBL_Audit_Log]    Script Date: 04/17/2011 02:22:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Audit_Log](
	[Log_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[User_ID] [bigint] NOT NULL,
	[LOGIN] [varchar](50) NULL,
	[LOGOUT] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Audit_Log] ON
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (2, 9, N'12:09:30 PM', N'12:54:45 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (3, 9, N'12:12:09 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (4, 9, N'12:16:29 PM', N'12:17:42 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (6, 9, N'12:24:01 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (17, 9, N'12:57:09 PM', N'1:14:30 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (18, 9, N'1:03:23 PM', N'1:04:43 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (19, 15, N'1:04:48 PM', N'1:04:57 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (20, 9, N'1:05:00 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (22, 9, N'1:09:31 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (23, 9, N'1:10:43 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (24, 9, N'1:12:00 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (25, 9, N'1:13:07 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (27, 14, N'1:16:38 PM', N'1:36:26 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (32, 9, N'1:28:41 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (33, 9, N'1:29:52 PM', N'1:37:54 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (34, 9, N'2:21:54 PM', N'2:23:38 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (35, 16, N'2:23:46 PM', N'2:23:54 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (36, 9, N'2:23:58 PM', N'2:24:24 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (37, 13, N'2:24:29 PM', N'2:24:45 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (38, 14, N'2:24:48 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (39, 12, N'2:27:50 PM', N'2:29:16 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (40, 9, N'2:29:19 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (41, 9, N'2:30:50 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (45, 14, N'2:36:55 PM', N'2:44:28 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (50, 9, N'2:55:38 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (51, 9, N'2:56:44 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (53, 9, N'3:05:09 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (56, 12, N'3:15:20 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (58, 9, N'3:30:11 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (59, 9, N'3:32:52 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (60, 9, N'3:36:18 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (61, 9, N'3:38:48 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (63, 9, N'4:19:50 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (64, 9, N'4:23:40 PM', N'4:24:47 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (65, 9, N'4:30:49 PM', N'4:33:22 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (66, 9, N'5:44:34 PM', N'5:46:00 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (67, 9, N'5:46:53 PM', N'5:57:29 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (68, 9, N'5:50:06 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (69, 9, N'5:56:33 PM', N'5:57:39 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (71, 12, N'5:57:35 PM', N'5:58:48 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (72, 9, N'5:58:51 PM', N'5:59:39 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (73, 12, N'5:59:44 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (74, 12, N'6:07:22 PM', N'6:10:05 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (75, 9, N'6:10:08 PM', N'6:10:16 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (76, 12, N'6:11:00 PM', N'6:12:52 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (77, 9, N'6:12:55 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (79, 14, N'6:26:24 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (91, 9, N'1:38:52 AM', N'1:39:16 AM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (93, 9, N'1:50:08 AM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (94, 9, N'1:55:00 AM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (95, 9, N'1:57:23 AM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (5, 12, N'12:17:47 PM', N'12:23:57 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (52, 9, N'3:02:01 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (70, 14, N'5:57:44 PM', N'6:26:31 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (88, 9, N'6:41:38 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (21, 9, N'1:08:00 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (47, 12, N'2:43:38 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (86, 9, N'6:39:10 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (87, 9, N'6:40:11 PM', N'6:41:23 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (89, 14, N'6:41:31 PM', N'6:43:06 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (90, 13, N'6:43:10 PM', N'6:43:36 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (7, 9, N'12:27:57 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (8, 9, N'12:29:13 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (9, 9, N'12:30:25 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (10, 9, N'12:33:25 PM', N'12:34:31 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (11, 12, N'12:34:34 PM', N'12:37:23 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (12, 13, N'12:37:26 PM', N'12:37:32 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (13, 13, N'12:37:39 PM', N'12:37:41 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (14, 14, N'12:37:45 PM', N'12:39:22 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (15, 13, N'12:39:27 PM', N'12:39:36 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (16, 9, N'12:39:38 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (54, 9, N'3:08:26 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (55, 9, N'3:09:59 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (78, 9, N'6:26:34 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (80, 14, N'6:29:07 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (81, 9, N'6:31:18 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (82, 9, N'6:31:52 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (83, 9, N'6:33:59 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (84, 9, N'6:34:47 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (85, 9, N'6:36:55 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (92, 9, N'1:49:00 AM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (1, 9, N'11:26:49 AM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (26, 14, N'1:14:40 PM', N'1:16:30 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (28, 12, N'1:16:45 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (29, 9, N'1:18:03 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (30, 9, N'1:23:30 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (31, 9, N'1:24:07 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (42, 14, N'2:32:04 PM', N'2:35:19 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (43, 9, N'2:35:21 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (44, 12, N'2:36:39 PM', N'2:38:05 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (46, 9, N'2:38:08 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (48, 9, N'2:44:32 PM', N'3:13:23 PM')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (49, 9, N'2:54:33 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (57, 9, N'3:25:00 PM', N'--')
INSERT [dbo].[TBL_Audit_Log] ([Log_ID], [User_ID], [LOGIN], [LOGOUT]) VALUES (62, 9, N'3:56:31 PM', N'--')
SET IDENTITY_INSERT [dbo].[TBL_Audit_Log] OFF
/****** Object:  Default [DF_TBL_Audit_Log_LOGOUT]    Script Date: 04/17/2011 02:22:34 ******/
ALTER TABLE [dbo].[TBL_Audit_Log] ADD  CONSTRAINT [DF_TBL_Audit_Log_LOGOUT]  DEFAULT ('--') FOR [LOGOUT]
GO
