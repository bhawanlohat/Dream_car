
INSERT INTO [dbo].[Company] ([Id], [Company_Name], [Company_Website], [Company_Phone], [Company_Email], [Company_Headquater]) VALUES (1, N'Jeep', N'jeep.com', NULL, NULL, N'Toledo,ohio,US')
INSERT INTO [dbo].[Company] ([Id], [Company_Name], [Company_Website], [Company_Phone], [Company_Email], [Company_Headquater]) VALUES (2, N'Toyota', N'toyota-global.com', NULL, NULL, N'Toyota city, japan')
INSERT INTO [dbo].[Company] ([Id], [Company_Name], [Company_Website], [Company_Phone], [Company_Email], [Company_Headquater]) VALUES (3, N'Mazda', N'mazda.com', NULL, NULL, N'3-1 shinchi,fuchu,aki,hiroshima,japan')
INSERT INTO [dbo].[Company] ([Id], [Company_Name], [Company_Website], [Company_Phone], [Company_Email], [Company_Headquater]) VALUES (4, N'Suzuki', N'globalsuzuki.com', NULL, NULL, N'shizuoka,japan')
SET IDENTITY_INSERT [dbo].[Company] OFF
SET IDENTITY_INSERT [dbo].[Dealer] ON
INSERT INTO [dbo].[Dealer] ([Id], [Dealer_Name], [Dealer_Website], [Dealer_Address], [Dealer_Email], [CompanyId]) VALUES (5, N'Colemans', N'colemans-suzuki.co.nz', N'1 gundry street,Newton,Auckland', N'abc', 4)
INSERT INTO [dbo].[Dealer] ([Id], [Dealer_Name], [Dealer_Website], [Dealer_Address], [Dealer_Email], [CompanyId]) VALUES (6, N'Andrew Simms', N'newmarket.jeepdealer.co.nz', N'500 Broadway Newmarket,Auckland', N'*******', 1)
INSERT INTO [dbo].[Dealer] ([Id], [Dealer_Name], [Dealer_Website], [Dealer_Address], [Dealer_Email], [CompanyId]) VALUES (7, N'Toyota New Zealand', N'toyota.co.nz', N'252 Dairy Flat highway,Albany,Auckland', N'******', 2)
INSERT INTO [dbo].[Dealer] ([Id], [Dealer_Name], [Dealer_Website], [Dealer_Address], [Dealer_Email], [CompanyId]) VALUES (8, N'John Andrew', N'johnandrewmazda.co.nz', N'38 Great North Road,gret lynn,Auckland ', N'*******', 3)
SET IDENTITY_INSERT [dbo].[Dealer] OFF
SET IDENTITY_INSERT [dbo].[Dealer] ON
INSERT INTO [dbo].[Dealer] ([Id], [Dealer_Name], [Dealer_Website], [Dealer_Address], [Dealer_Email], [CompanyId]) VALUES (5, N'Colemans', N'colemans-suzuki.co.nz', N'1 gundry street,Newton,Auckland', N'abc', 4)
INSERT INTO [dbo].[Dealer] ([Id], [Dealer_Name], [Dealer_Website], [Dealer_Address], [Dealer_Email], [CompanyId]) VALUES (6, N'Andrew Simms', N'newmarket.jeepdealer.co.nz', N'500 Broadway Newmarket,Auckland', N'*******', 1)
INSERT INTO [dbo].[Dealer] ([Id], [Dealer_Name], [Dealer_Website], [Dealer_Address], [Dealer_Email], [CompanyId]) VALUES (7, N'Toyota New Zealand', N'toyota.co.nz', N'252 Dairy Flat highway,Albany,Auckland', N'******', 2)
INSERT INTO [dbo].[Dealer] ([Id], [Dealer_Name], [Dealer_Website], [Dealer_Address], [Dealer_Email], [CompanyId]) VALUES (8, N'John Andrew', N'johnandrewmazda.co.nz', N'38 Great North Road,gret lynn,Auckland ', N'*******', 3)
SET IDENTITY_INSERT [dbo].[Dealer] OFF
SET IDENTITY_INSERT [dbo].[Specification] ON
INSERT INTO [dbo].[Specification] ([Id], [Fuel_type], [Transmission], [GPS], [Rating], [ModelId]) VALUES (1, N'Regular', N'auto', N'no', N'4.2', 1)
INSERT INTO [dbo].[Specification] ([Id], [Fuel_type], [Transmission], [GPS], [Rating], [ModelId]) VALUES (2, N'Regular', N'auto', N'no', N'4.5', 2)
INSERT INTO [dbo].[Specification] ([Id], [Fuel_type], [Transmission], [GPS], [Rating], [ModelId]) VALUES (3, N'Regular', N'auto', N'no', N'4.0', 3)
INSERT INTO [dbo].[Specification] ([Id], [Fuel_type], [Transmission], [GPS], [Rating], [ModelId]) VALUES (4, N'Diesel', N'8-gear automatic', N'yes', N'4.5', 4)
INSERT INTO [dbo].[Specification] ([Id], [Fuel_type], [Transmission], [GPS], [Rating], [ModelId]) VALUES (5, N'Petrol', N'Automatic', N'yes', N'4.6', 5)
INSERT INTO [dbo].[Specification] ([Id], [Fuel_type], [Transmission], [GPS], [Rating], [ModelId]) VALUES (6, N'Premium unleaded', N'6-speed manual', N'yes', N'4.5', 6)
INSERT INTO [dbo].[Specification] ([Id], [Fuel_type], [Transmission], [GPS], [Rating], [ModelId]) VALUES (7, N'Petrol', N'Automatic', N'yes', N'4.2', 7)
INSERT INTO [dbo].[Specification] ([Id], [Fuel_type], [Transmission], [GPS], [Rating], [ModelId]) VALUES (8, N'Hybrid', N'auto', N'yes', N'4.6', 8)
INSERT INTO [dbo].[Specification] ([Id], [Fuel_type], [Transmission], [GPS], [Rating], [ModelId]) VALUES (9, N'Premium unleaded', N'Automatic', N'yes', N'4.5', 9)
SET IDENTITY_INSERT [dbo].[Specification] OFF

 
