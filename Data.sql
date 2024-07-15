USE [DiamondStore]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (1, N'Nhan')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (2, N'Daychuyen')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (3, N'Matdaychuyen')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (4, N'Vongtay')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (5, N'Kimcuong')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[JewelrySetting] ON 

INSERT [dbo].[JewelrySetting] ([JewelrySettingID], [Material], [BasePrice]) VALUES (1, N'Vàng 14K', 3000000)
INSERT [dbo].[JewelrySetting] ([JewelrySettingID], [Material], [BasePrice]) VALUES (2, N'Vàng 18K', 5000000)
INSERT [dbo].[JewelrySetting] ([JewelrySettingID], [Material], [BasePrice]) VALUES (3, N'White Gold', 4500000)
INSERT [dbo].[JewelrySetting] ([JewelrySettingID], [Material], [BasePrice]) VALUES (4, N'Bạc', 2000000)
SET IDENTITY_INSERT [dbo].[JewelrySetting] OFF
GO
SET IDENTITY_INSERT [dbo].[MainDiamonds] ON 

INSERT [dbo].[MainDiamonds] ([MainDiamondID], [MainDiamondName], [Price]) VALUES (1, N'Đá CZ', 5000000)
INSERT [dbo].[MainDiamonds] ([MainDiamondID], [MainDiamondName], [Price]) VALUES (2, N'Đá SYN.RUB', 7500000)
INSERT [dbo].[MainDiamonds] ([MainDiamondID], [MainDiamondName], [Price]) VALUES (3, N'Đá SYN.SAP', 8000000)
SET IDENTITY_INSERT [dbo].[MainDiamonds] OFF
GO
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'DC-001', N'Dây chuyền Bạc Ý 0000W060096', N'Jewelry', N'Sparkling diamond earrings', CAST(1.00 AS Decimal(18, 2)), 1995000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'DC-002', N'Dây chuyền Vàng trắng Ý 18K 0000W000871', N'Jewelry', N'Sparkling diamond earrings', CAST(1.00 AS Decimal(18, 2)), 16963000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'DC-003', N'Dây chuyền Vàng Ý 18K 0000Y060507', N'Jewelry', N'Sparkling diamond earrings', CAST(1.00 AS Decimal(18, 2)), 20534400, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'DC-004', N'Dây chuyền nam Vàng trắng Ý 18K 0000W061242', N'Jewelry', N'Sparkling diamond earrings', CAST(1.00 AS Decimal(18, 2)), 11320000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'DC-005', N'Dây chuyền nam Vàng trắng Ý 18K 0000W061240', N'Jewelry', N'Sparkling diamond earrings', CAST(1.00 AS Decimal(18, 2)), 33386800, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'DC-006', N'Dây chuyền Vàng Ý 18K PNJ 0000C000043', N'Jewelry', N'Sparkling diamond earrings', CAST(1.00 AS Decimal(18, 2)), 18077000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'DC-007', N'Dây chuyền nam Vàng Ý 18K 0000Y060509', N'Jewelry', N'Sparkling diamond earrings', CAST(1.00 AS Decimal(18, 2)), 42494800, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'DC-008', N'Dây chuyền nam Vàng Ý 18K 0000C060176', N'Jewelry', N'Sparkling diamond earrings', CAST(1.00 AS Decimal(18, 2)), 73690000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-3.6-001', N'Kim cương viên GIA 3.6ly E VS2 EX', N'Diamond', N'A beautiful 0.5 carat diamond ring', CAST(1.00 AS Decimal(18, 2)), 25000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-3.6-002', N'Kim cương viên GIA 3.6ly G VS2 EX', N'Diamond', N'beautiful diamond', CAST(1.00 AS Decimal(18, 2)), 11045000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-3.6-003', N'Kim cương viên GIA 3.6ly G VS1 EX', N'Diamond', N'beautiful diamond', CAST(1.00 AS Decimal(18, 2)), 11421000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-3.6-004', N'Kim cương viên GIA 3.6ly F VS1 EX', N'Diamond', N'beautiful diamond', CAST(1.00 AS Decimal(18, 2)), 12267000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-3.6-005', N'Kim cương viên GIA 3.6ly H VVS2 EX', N'Diamond', N'beautiful diamond', CAST(1.00 AS Decimal(18, 2)), 12361000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-3.6-006', N'Kim cương viên GIA 3.6ly G VVS1 EX', N'Diamond', N'beautiful diamond', CAST(1.00 AS Decimal(18, 2)), 13160000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-3.6-007', N'Kim cương viên GIA 3.6ly D VVS2 VG', N'Diamond', N'beautiful diamond', CAST(1.00 AS Decimal(18, 2)), 15087000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-3.6-008', N'Kim cương viên GIA 3.6ly D IF EX', N'Diamond', N'beautiful diamond', CAST(1.00 AS Decimal(18, 2)), 18095000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.1-001', N'Diamond Ring 0.75 Carat', N'Diamond', N'A beautiful 0.75 carat diamond ring', CAST(1.00 AS Decimal(18, 2)), 7500, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.5-001', N'Diamond Ring 1.0 Carat', N'Diamond', N'A beautiful 1.0 carat diamond ring', CAST(1.00 AS Decimal(18, 2)), 10000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-5.4-001', N'Diamond Ring 0.6 Carat', N'Diamond', N'A beautiful 0.6 carat diamond ring', CAST(1.00 AS Decimal(18, 2)), 6000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'MDC-001', N'Mặt dây chuyền Vàng 14K đính đá Ruby Disney', N'Jewelry', N'Luxury platinum bracelet', CAST(1.00 AS Decimal(18, 2)), 6283000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'MDC-002', N'Mặt dây chuyền Vàng 18K đính đá CZ', N'Jewelry', N'Luxury platinum bracelet', CAST(1.00 AS Decimal(18, 2)), 17590000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'MDC-003', N'Mặt dây chuyền Vàng 14K đính đá', N'Jewelry', N'Luxury platinum bracelet', CAST(1.00 AS Decimal(18, 2)), 7190000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'MDC-004', N'Mặt dây chuyền Vàng 14K đính đá Synthetic HELLO KITTY', N'Jewelry', N'Luxury platinum bracelet', CAST(1.00 AS Decimal(18, 2)), 3180000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'MDC-005', N'Mặt dây chuyền Vàng 14K đính đá Synthetic HELLO KITTY', N'Jewelry', N'Luxury platinum bracelet', CAST(1.00 AS Decimal(18, 2)), 4105500, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'MDC-006', N'Mặt dây chuyền Vàng 14K đính đá Synthetic HELLO KITTY', N'Jewelry', N'Luxury platinum bracelet', CAST(1.00 AS Decimal(18, 2)), 3170500, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'MDC-007', N'Mặt dây chuyền Vàng Trắng 14K đính ngọc trai Akoya PAXMW000101', N'Jewelry', N'Luxury platinum bracelet', CAST(1.00 AS Decimal(18, 2)), 11567000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'MDC-008', N'Mặt dây chuyền Vàng trắng 14K đính đá Topaz PNJ TPXMW000417', N'Jewelry', N'Luxury platinum bracelet', CAST(1.00 AS Decimal(18, 2)), 6346000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'N-001', N'Nhẫn Kim Cương Vàng 14k Timeless Diamond', N'Jewelry', N'A beautiful gold ring', CAST(1.00 AS Decimal(18, 2)), 56419000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'N-002', N'Nhẫn Vàng trắng 14K đính đá ECZ', N'Jewelry', N'A beautiful gold ring', CAST(1.00 AS Decimal(18, 2)), 8359000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'N-003', N'Nhẫn Kim Cương Vàng 14k Timeless Diamond', N'Jewelry', N'A beautiful gold ring', CAST(1.00 AS Decimal(18, 2)), 124398000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'N-004', N'Nhẫn Kim cương Vàng trắng 14K', N'Jewelry', N'A beautiful gold ring', CAST(1.00 AS Decimal(18, 2)), 43544000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'VT-001', N'Emerald Pendant', N'Jewelry', N'Beautiful emerald pendant', CAST(1.00 AS Decimal(18, 2)), 7500000, 1)
GO
SET IDENTITY_INSERT [dbo].[SideDiamonds] ON 

INSERT [dbo].[SideDiamonds] ([SideDiamondID], [SideDiamondName], [Price]) VALUES (1, N'KC DIA WHIRD 1.2', 3000000)
INSERT [dbo].[SideDiamonds] ([SideDiamondID], [SideDiamondName], [Price]) VALUES (2, N'KC DIA WHIRD 1.3', 3500000)
INSERT [dbo].[SideDiamonds] ([SideDiamondID], [SideDiamondName], [Price]) VALUES (3, N'KC DIA WHIRD 1.5', 4000000)
SET IDENTITY_INSERT [dbo].[SideDiamonds] OFF
GO
SET IDENTITY_INSERT [dbo].[Jewelry] ON 

INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (1, 3, N'N-001', 1, 2, 1, 4, 1, 56419000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (2, 3, N'N-002', 2, 2, 2, 4, 1, 8359000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (3, 3, N'N-003', 3, 2, 3, 4, 1, 124398000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (5, 3, N'DC-001', 1, 2, 1, 4, 2, 1995000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (6, 3, N'DC-002', 2, 2, 2, 4, 2, 16963000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (7, 3, N'DC-003', 3, 2, 3, 4, 2, 20534400)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (9, 3, N'DC-005', 1, 2, 1, 4, 2, 33386800)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (10, 2, N'DC-006', 2, 2, 2, 4, 2, 18077000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (11, 2, N'DC-007', 3, 2, 3, 4, 2, 42494800)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (13, 1, N'MDC-001', 1, 2, 1, 4, 3, 6283000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (14, 1, N'MDC-002', 2, 2, 2, 4, 3, 17590000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (15, 3, N'MDC-003', 3, 2, 3, 4, 3, 7190000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (17, 3, N'MDC-005', 1, 2, 1, 4, 3, 4105500)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (18, 2, N'MDC-006', 2, 2, 2, 4, 3, 3170500)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (19, 2, N'MDC-007', 3, 2, 3, 4, 3, 11567000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (21, 1, N'VT-001', 1, 2, 1, 4, 4, 7500000)
SET IDENTITY_INSERT [dbo].[Jewelry] OFF
GO
SET IDENTITY_INSERT [dbo].[Diamonds] ON 

INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (1, N'KC-3.6-001', CAST(0.50 AS Decimal(18, 2)), N'VS2', N'EX', N'E', CAST(3.60 AS Decimal(18, 2)), 12267000, 10)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (2, N'KC-4.1-001', CAST(0.75 AS Decimal(18, 2)), N'VVS2', N'Round', N'E', CAST(4.10 AS Decimal(18, 2)), 7500, 8)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (3, N'KC-4.5-001', CAST(1.00 AS Decimal(18, 2)), N'IF', N'Round', N'F', CAST(4.50 AS Decimal(18, 2)), 10000, 5)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (4, N'KC-5.4-001', CAST(0.60 AS Decimal(18, 2)), N'SI1', N'Round', N'G', CAST(5.40 AS Decimal(18, 2)), 6000, 7)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (6, N'KC-3.6-002', CAST(0.50 AS Decimal(18, 2)), N'VS2', N'EX', N'G', CAST(3.60 AS Decimal(18, 2)), 11045000, 10)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (8, N'KC-3.6-003', CAST(0.50 AS Decimal(18, 2)), N'VS1', N'EX', N'G', CAST(3.60 AS Decimal(18, 2)), 11421000, 10)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (9, N'KC-3.6-004', CAST(0.50 AS Decimal(18, 2)), N'VS1', N'EX', N'F', CAST(3.60 AS Decimal(18, 2)), 12267000, 10)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (10, N'KC-3.6-005', CAST(0.50 AS Decimal(18, 2)), N'VVS2', N'EX', N'H', CAST(3.60 AS Decimal(18, 2)), 12361000, 10)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (11, N'KC-3.6-006', CAST(0.50 AS Decimal(18, 2)), N'VVS1', N'EX', N'G', CAST(3.60 AS Decimal(18, 2)), 13160000, 10)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (12, N'KC-3.6-007', CAST(0.50 AS Decimal(18, 2)), N'VVS2', N'VG', N'D', CAST(3.60 AS Decimal(18, 2)), 15087000, 10)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (13, N'KC-3.6-008', CAST(0.50 AS Decimal(18, 2)), N'IF', N'EX', N'D', CAST(3.60 AS Decimal(18, 2)), 18095000, 10)
SET IDENTITY_INSERT [dbo].[Diamonds] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([RoleId], [RoleName]) VALUES (1, N'Admin')
INSERT [dbo].[Roles] ([RoleId], [RoleName]) VALUES (2, N'Manager')
INSERT [dbo].[Roles] ([RoleId], [RoleName]) VALUES (3, N'Member')
INSERT [dbo].[Roles] ([RoleId], [RoleName]) VALUES (4, N'Delivery')
INSERT [dbo].[Roles] ([RoleId], [RoleName]) VALUES (5, N'Staff')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (1, 1, N'admin@example.com', N'Admin User', N'0912345678', N'admin', N'123', N'123 Admin St', 100, 1)
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (2, 2, N'manager@example.com', N'Manager User', N'0987654321', N'manager', N'123', N'456 Manager Ave', 200, 1)
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (3, 3, N'member@example.com', N'Member User', N'0915666777', N'member', N'123', N'789 Member Blvd', 300, 1)
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (4, 4, N'delivery@example.com', N'Delivery User', N'0999888777', N'delivery', N'123', N'321 Delivery Dr', 400, 1)
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (5, 5, N'staff@example.com', N'Staff User', N'0911122333', N'staff', N'123', N'654 Staff Ln', 500, 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) VALUES (1, 1, CAST(99.99 AS Decimal(18, 2)), N'Completed', CAST(N'2023-05-15T12:34:56.1230000' AS DateTime2), N'Giao hàng nhanh chóng', NULL)
INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) VALUES (2, 2, CAST(49.49 AS Decimal(18, 2)), N'Ordering', CAST(N'2023-05-16T14:21:22.4560000' AS DateTime2), N'Yêu cầu gói quà', NULL)
INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) VALUES (3, 3, CAST(75.00 AS Decimal(18, 2)), N'Shipping', CAST(N'2023-05-17T16:45:33.7890000' AS DateTime2), N'Liên hệ trước khi giao', NULL)
INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) VALUES (4, 4, CAST(120.50 AS Decimal(18, 2)), N'Completed', CAST(N'2023-05-18T11:12:12.0120000' AS DateTime2), N'Khách hàng VIP', NULL)
INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) VALUES (5, 1, CAST(200.99 AS Decimal(18, 2)), N'Shipping', CAST(N'2023-05-19T10:01:44.3210000' AS DateTime2), N'Địa chỉ giao hàng mới', NULL)
INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) VALUES (6, 1, CAST(15.75 AS Decimal(18, 2)), N'Completed', CAST(N'2023-05-20T17:23:55.6540000' AS DateTime2), N'Ưu đãi đặc biệt', NULL)
INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) VALUES (7, 2, CAST(250.00 AS Decimal(18, 2)), N'Completed', CAST(N'2023-05-21T09:30:11.9870000' AS DateTime2), N'Sản phẩm cao cấp', NULL)
INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) VALUES (8, 3, CAST(60.60 AS Decimal(18, 2)), N'Shipping', CAST(N'2023-05-22T08:45:22.8760000' AS DateTime2), N'Yêu cầu giao vào buổi tối', NULL)
INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) VALUES (9, 4, CAST(89.89 AS Decimal(18, 2)), N'Completed', CAST(N'2023-05-23T07:12:33.7650000' AS DateTime2), N'Khuyến mãi sinh nhật', NULL)
INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) VALUES (10, 1, CAST(199.99 AS Decimal(18, 2)), N'Ordering', CAST(N'2023-05-24T06:23:44.6540000' AS DateTime2), N'Tặng kèm phiếu giảm giá', NULL)
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[JewelrySizes] ON 

INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (1, 1, 10, 50)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (2, 2, 11, 35)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (3, 3, 12, 20)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (5, 5, 14, 50)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (6, 6, 15, 50)
SET IDENTITY_INSERT [dbo].[JewelrySizes] OFF
GO
