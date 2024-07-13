﻿USE [DiamondStore]
/* Insert Category */
INSERT INTO [dbo].[Categories] (CategoryName) VALUES ('Nhan');
INSERT INTO [dbo].[Categories] (CategoryName) VALUES ('Daychuyen');
INSERT INTO [dbo].[Categories] (CategoryName) VALUES ('Matdaychuyen');
INSERT INTO [dbo].[Categories] (CategoryName) VALUES ('Vongtay');
INSERT INTO [dbo].[Categories] (CategoryName) VALUES ('Kimcuong');

/* Insert Role */
INSERT INTO [dbo].[Roles] (RoleName) VALUES ('Admin');
INSERT INTO [dbo].[Roles] (RoleName) VALUES ('Manager');
INSERT INTO [dbo].[Roles] (RoleName) VALUES ('Member');
INSERT INTO [dbo].[Roles] (RoleName) VALUES ('Delivery');
INSERT INTO [dbo].[Roles] (RoleName) VALUES ('Staff');

/* Insert User */
INSERT INTO [dbo].[Users] (RoleId, Email, FullName, NumberPhone, Username, Password, LoyaltyPoints, IsActive, Address) 
VALUES (1, 'admin@example.com', 'Admin User', '0912345678', 'admin', '123', 100, 1, '123 Admin St');

INSERT INTO [dbo].[Users] (RoleId, Email, FullName, NumberPhone, Username, Password, LoyaltyPoints, IsActive, Address) 
VALUES (2, 'manager@example.com', 'Manager User', '0987654321', 'manager', '123', 200, 1, '456 Manager Ave');

INSERT INTO [dbo].[Users] (RoleId, Email, FullName, NumberPhone, Username, Password, LoyaltyPoints, IsActive, Address) 
VALUES (3, 'member@example.com', 'Member User', '0915666777', 'member', '123', 300, 1, '789 Member Blvd');

INSERT INTO [dbo].[Users] (RoleId, Email, FullName, NumberPhone, Username, Password, LoyaltyPoints, IsActive, Address) 
VALUES (4, 'delivery@example.com', 'Delivery User', '0999888777', 'delivery', '123', 400, 1, '321 Delivery Dr');

INSERT INTO [dbo].[Users] (RoleId, Email, FullName, NumberPhone, Username, Password, LoyaltyPoints, IsActive, Address) 
VALUES (5, 'staff@example.com', 'Staff User', '0911122333', 'staff', '123', 500, 1, '654 Staff Ln');

/* Insert Product */
INSERT INTO [dbo].[Products] (ProductId, ProductName, ProductType, Description, MarkupRate, MarkupPrice, IsActive) 
VALUES ('N-001', N'Nhẫn Kim Cương Vàng 14k Timeless Diamond', N'Jewelry', N'A beautiful gold ring', 1, 56419000, 'True');

INSERT INTO [dbo].[Products] (ProductId, ProductName, ProductType, Description, MarkupRate, MarkupPrice, IsActive) 
VALUES ('N-002', N'Nhẫn Vàng trắng 14K đính đá ECZ', N'Jewelry', N'A beautiful gold ring', 1, 8359000, 'True');

INSERT INTO [dbo].[Products] (ProductId, ProductName, ProductType, Description, MarkupRate, MarkupPrice, IsActive) 
VALUES ('N-003', N'Nhẫn Kim Cương Vàng 14k Timeless Diamond', N'Jewelry', N'A beautiful gold ring', 1, 124398000, 'True');

INSERT INTO [dbo].[Products] (ProductId, ProductName, ProductType, Description, MarkupRate, MarkupPrice, IsActive) 
VALUES ('N-004', N'Nhẫn Kim cương Vàng trắng 14K', N'Jewelry', N'A beautiful gold ring', 1, 43544000, 'True');

INSERT INTO [dbo].[Products] (ProductId, ProductName, ProductType, Description, MarkupRate, MarkupPrice, IsActive) 
VALUES ('DC-001', N'Dây chuyền Bạc Ý 0000W060096', N'Jewelry', N'Sparkling diamond earrings', 1, 1995000, 'True');

INSERT INTO [dbo].[Products] (ProductId, ProductName, ProductType, Description, MarkupRate, MarkupPrice, IsActive) 
VALUES ('DC-002', N'Dây chuyền Vàng trắng Ý 18K 0000W000871', N'Jewelry', N'Sparkling diamond earrings', 1, 16963000, 'True');

INSERT INTO [dbo].[Products] (ProductId, ProductName, ProductType, Description, MarkupRate, MarkupPrice, IsActive) 
VALUES ('DC-003', N'Dây chuyền Vàng Ý 18K 0000Y060507', N'Jewelry', N'Sparkling diamond earrings', 1, 20534400, 'True');

INSERT INTO [dbo].[Products] (ProductId, ProductName, ProductType, Description, MarkupRate, MarkupPrice, IsActive) 
VALUES ('DC-004', N'Dây chuyền nam Vàng trắng Ý 18K 0000W061242', N'Jewelry', N'Sparkling diamond earrings', 1, 11320000, 'True');

INSERT INTO [dbo].[Products] (ProductId, ProductName, ProductType, Description, MarkupRate, MarkupPrice, IsActive) 
VALUES ('DC-005', N'Dây chuyền nam Vàng trắng Ý 18K 0000W061240', N'Jewelry', N'Sparkling diamond earrings', 1, 33386800, 'True');

INSERT INTO [dbo].[Products] (ProductId, ProductName, ProductType, Description, MarkupRate, MarkupPrice, IsActive) 
VALUES ('DC-006', N'Dây chuyền Vàng Ý 18K PNJ 0000C000043', N'Jewelry', N'Sparkling diamond earrings', 1, 18077000, 'True');

INSERT INTO [dbo].[Products] (ProductId, ProductName, ProductType, Description, MarkupRate, MarkupPrice, IsActive) 
VALUES ('DC-007', N'Dây chuyền nam Vàng Ý 18K 0000Y060509', N'Jewelry', N'Sparkling diamond earrings', 1, 42494800, 'True');

INSERT INTO [dbo].[Products] (ProductId, ProductName, ProductType, Description, MarkupRate, MarkupPrice, IsActive) 
VALUES ('DC-008', N'Dây chuyền nam Vàng Ý 18K 0000C060176', N'Jewelry', N'Sparkling diamond earrings', 1, 73690000, 'True');

INSERT INTO [dbo].[Products] (ProductId, ProductName, ProductType, Description, MarkupRate, MarkupPrice, IsActive) 
VALUES ('MDC-001', N'Mặt dây chuyền Vàng 14K đính đá Ruby Disney', N'Jewelry', N'Luxury platinum bracelet', 1, 6283000, 'True');

INSERT INTO [dbo].[Products] (ProductId, ProductName, ProductType, Description, MarkupRate, MarkupPrice, IsActive) 
VALUES ('MDC-002', N'Mặt dây chuyền Vàng 18K đính đá CZ', N'Jewelry', N'Luxury platinum bracelet', 1, 17590000, 'True');

INSERT INTO [dbo].[Products] (ProductId, ProductName, ProductType, Description, MarkupRate, MarkupPrice, IsActive) 
VALUES ('MDC-003', N'Mặt dây chuyền Vàng 14K đính đá', N'Jewelry', N'Luxury platinum bracelet', 1, 7190000, 'True');

INSERT INTO [dbo].[Products] (ProductId, ProductName, ProductType, Description, MarkupRate, MarkupPrice, IsActive) 
VALUES ('MDC-004', N'Mặt dây chuyền Vàng 14K đính đá Synthetic HELLO KITTY', N'Jewelry', N'Luxury platinum bracelet', 1, 3180000, 'True');

INSERT INTO [dbo].[Products] (ProductId, ProductName, ProductType, Description, MarkupRate, MarkupPrice, IsActive) 
VALUES ('MDC-005', N'Mặt dây chuyền Vàng 14K đính đá Synthetic HELLO KITTY', N'Jewelry', N'Luxury platinum bracelet', 1, 4105500, 'True');

INSERT INTO [dbo].[Products] (ProductId, ProductName, ProductType, Description, MarkupRate, MarkupPrice, IsActive) 
VALUES ('MDC-006', N'Mặt dây chuyền Vàng 14K đính đá Synthetic HELLO KITTY', N'Jewelry', N'Luxury platinum bracelet', 1, 3170500, 'True');

INSERT INTO [dbo].[Products] (ProductId, ProductName, ProductType, Description, MarkupRate, MarkupPrice, IsActive) 
VALUES ('MDC-007', N'Mặt dây chuyền Vàng Trắng 14K đính ngọc trai Akoya PAXMW000101', N'Jewelry', N'Luxury platinum bracelet', 1, 11567000, 'True');

INSERT INTO [dbo].[Products] (ProductId, ProductName, ProductType, Description, MarkupRate, MarkupPrice, IsActive) 
VALUES ('MDC-008', N'Mặt dây chuyền Vàng trắng 14K đính đá Topaz PNJ TPXMW000417', N'Jewelry', N'Luxury platinum bracelet', 1, 6346000, 'True');

INSERT INTO [dbo].[Products] (ProductId, ProductName, ProductType, Description, MarkupRate, MarkupPrice, IsActive) 
VALUES ('VT-001', N'Emerald Pendant', N'Jewelry', N'Beautiful emerald pendant', 1, 7500000, 'True');

INSERT INTO [dbo].[Products] (ProductId, ProductName, ProductType, Description, MarkupRate, MarkupPrice, IsActive) 
VALUES ('KC-3.6-001', N'Diamond Ring 0.5 Carat', N'Diamond', N'A beautiful 0.5 carat diamond ring', 1, 5000, 'True');

INSERT INTO [dbo].[Products] (ProductId, ProductName, ProductType, Description, MarkupRate, MarkupPrice, IsActive) 
VALUES ('KC-4.1-001', N'Diamond Ring 0.75 Carat', N'Diamond', N'A beautiful 0.75 carat diamond ring', 1, 7500, 'True');

INSERT INTO [dbo].[Products] (ProductId, ProductName, ProductType, Description, MarkupRate, MarkupPrice, IsActive) 
VALUES ('KC-4.5-001', N'Diamond Ring 1.0 Carat', N'Diamond', N'A beautiful 1.0 carat diamond ring', 1, 10000, 'True');

INSERT INTO [dbo].[Products] (ProductId, ProductName, ProductType, Description, MarkupRate, MarkupPrice, IsActive) 
VALUES ('KC-5.4-001', N'Diamond Ring 0.6 Carat', N'Diamond', N'A beautiful 0.6 carat diamond ring', 1, 6000, 'True');

/* Insert JewelrySetting */
INSERT INTO [dbo].[JewelrySetting] (Material, BasePrice) 
VALUES (N'Vàng', 500000);  

INSERT INTO [dbo].[JewelrySetting] (Material, BasePrice) 
VALUES (N'Bạc', 200000);  

INSERT INTO [dbo].[JewelrySetting] (Material, BasePrice) 
VALUES ('White Gold', 300000);  

/* Insert Orders */
INSERT INTO [dbo].[Orders] (UserId, TotalPrice, Status, OrderDate, OrderNote, CancelReason) VALUES (1, 99.99, N'Completed', '2023-05-15 12:34:56.123', N'Giao hàng nhanh chóng', NULL);
INSERT INTO [dbo].[Orders] (UserId, TotalPrice, Status, OrderDate, OrderNote, CancelReason) VALUES (2, 49.49, N'Ordering', '2023-05-16 14:21:22.456', N'Yêu cầu gói quà', NULL);
INSERT INTO [dbo].[Orders] (UserId, TotalPrice, Status, OrderDate, OrderNote, CancelReason) VALUES (3, 75.00, N'Shipping', '2023-05-17 16:45:33.789', N'Liên hệ trước khi giao', NULL);
INSERT INTO [dbo].[Orders] (UserId, TotalPrice, Status, OrderDate, OrderNote, CancelReason) VALUES (4, 120.50, N'Completed', '2023-05-18 11:12:12.012', N'Khách hàng VIP', NULL);
INSERT INTO [dbo].[Orders] (UserId, TotalPrice, Status, OrderDate, OrderNote, CancelReason) VALUES (1, 200.99, N'Shipping', '2023-05-19 10:01:44.321', N'Địa chỉ giao hàng mới', NULL);
INSERT INTO [dbo].[Orders] (UserId, TotalPrice, Status, OrderDate, OrderNote, CancelReason) VALUES (1, 15.75, N'Completed', '2023-05-20 17:23:55.654', N'Ưu đãi đặc biệt', NULL);
INSERT INTO [dbo].[Orders] (UserId, TotalPrice, Status, OrderDate, OrderNote, CancelReason) VALUES (2, 250.00, N'Completed', '2023-05-21 09:30:11.987', N'Sản phẩm cao cấp', NULL);
INSERT INTO [dbo].[Orders] (UserId, TotalPrice, Status, OrderDate, OrderNote, CancelReason) VALUES (3, 60.60, N'Shipping', '2023-05-22 08:45:22.876', N'Yêu cầu giao vào buổi tối', NULL);
INSERT INTO [dbo].[Orders] (UserId, TotalPrice, Status, OrderDate, OrderNote, CancelReason) VALUES (4, 89.89, N'Completed', '2023-05-23 07:12:33.765', N'Khuyến mãi sinh nhật', NULL);
INSERT INTO [dbo].[Orders] (UserId, TotalPrice, Status, OrderDate, OrderNote, CancelReason) VALUES (1, 199.99, N'Ordering', '2023-05-24 06:23:44.654', N'Tặng kèm phiếu giảm giá', NULL);

/* Insert Diamond */
INSERT INTO [dbo].[Diamonds] (ProductID, Carat, Clarity, Cut, Color, BasePrice, DiameterMM, Quantity) 
VALUES ('KC-3.6-001', 0.5, 'VS1', 'Round', 'D', 5000, 3.6, 10);

INSERT INTO [dbo].[Diamonds] (ProductID, Carat, Clarity, Cut, Color, BasePrice, DiameterMM, Quantity) 
VALUES ('KC-4.1-001', 0.75, 'VVS2', 'Round', 'E', 7500, 4.1, 8);

INSERT INTO [dbo].[Diamonds] (ProductID, Carat, Clarity, Cut, Color, BasePrice, DiameterMM, Quantity) 
VALUES ('KC-4.5-001', 1.0, 'IF', 'Round', 'F', 10000, 4.5, 5);

INSERT INTO [dbo].[Diamonds] (ProductID, Carat, Clarity, Cut, Color, BasePrice, DiameterMM, Quantity) 
VALUES ('KC-5.4-001', 0.6, 'SI1', 'Round', 'G', 6000, 5.4, 7);

/* Insert MainDiamond */
INSERT INTO [dbo].[MainDiamonds] (MainDiamondName, Price) 
VALUES ('Diamond A', 5000000);

INSERT INTO [dbo].[MainDiamonds] (MainDiamondName, Price) 
VALUES ('Diamond B', 7500000);

INSERT INTO [dbo].[MainDiamonds] (MainDiamondName, Price) 
VALUES ('Diamond C', 10000000);

INSERT INTO [dbo].[MainDiamonds] (MainDiamondName, Price) 
VALUES ('Diamond D', 12000000);

INSERT INTO [dbo].[MainDiamonds] (MainDiamondName, Price) 
VALUES ('Diamond E', 15000000);

/* Insert SideDiamond */
INSERT INTO [dbo].[SideDiamonds] (SideDiamondName, Price) 
VALUES ('Side Diamond A', 2000000);

INSERT INTO [dbo].[SideDiamonds] (SideDiamondName, Price) 
VALUES ('Side Diamond B', 3500000);

INSERT INTO [dbo].[SideDiamonds] (SideDiamondName, Price) 
VALUES ('Side Diamond C', 5000000);

INSERT INTO [dbo].[SideDiamonds] (SideDiamondName, Price) 
VALUES ('Side Diamond D', 7000000);

INSERT INTO [dbo].[SideDiamonds] (SideDiamondName, Price) 
VALUES ('Side Diamond E', 9000000);

/* Insert Jewelry */
INSERT INTO [dbo].[Jewelry] (JewelrySettingID, ProductID, MainDiamondID, MainDiamondQuantity, SideDiamondID, SideDiamondQuantity, CategoryId, BasePrice) 
VALUES (3, 'N-001', 1, 2, 1, 4, 1, 56419000);

INSERT INTO [dbo].[Jewelry] (JewelrySettingID, ProductID, MainDiamondID, MainDiamondQuantity, SideDiamondID, SideDiamondQuantity, CategoryId, BasePrice) 
VALUES (3, 'N-002', 2, 2, 2, 4, 1, 8359000);

INSERT INTO [dbo].[Jewelry] (JewelrySettingID, ProductID, MainDiamondID, MainDiamondQuantity, SideDiamondID, SideDiamondQuantity, CategoryId, BasePrice) 
VALUES (3, 'N-003', 3, 2, 3, 4, 1, 124398000);

INSERT INTO [dbo].[Jewelry] (JewelrySettingID, ProductID, MainDiamondID, MainDiamondQuantity, SideDiamondID, SideDiamondQuantity, CategoryId, BasePrice) 
VALUES (3, 'N-004', 4, 2, 4, 4, 1, 43544000);

INSERT INTO [dbo].[Jewelry] (JewelrySettingID, ProductID, MainDiamondID, MainDiamondQuantity, SideDiamondID, SideDiamondQuantity, CategoryId, BasePrice) 
VALUES (3, 'DC-001', 1, 2, 1, 4, 2, 1995000);

INSERT INTO [dbo].[Jewelry] (JewelrySettingID, ProductID, MainDiamondID, MainDiamondQuantity, SideDiamondID, SideDiamondQuantity, CategoryId, BasePrice) 
VALUES (3, 'DC-002', 2, 2, 2, 4, 2, 16963000);

INSERT INTO [dbo].[Jewelry] (JewelrySettingID, ProductID, MainDiamondID, MainDiamondQuantity, SideDiamondID, SideDiamondQuantity, CategoryId, BasePrice) 
VALUES (3, 'DC-003', 3, 2, 3, 4, 2, 20534400);

INSERT INTO [dbo].[Jewelry] (JewelrySettingID, ProductID, MainDiamondID, MainDiamondQuantity, SideDiamondID, SideDiamondQuantity, CategoryId, BasePrice) 
VALUES (3, 'DC-004', 4, 2, 4, 4, 2, 11320000);

INSERT INTO [dbo].[Jewelry] (JewelrySettingID, ProductID, MainDiamondID, MainDiamondQuantity, SideDiamondID, SideDiamondQuantity, CategoryId, BasePrice) 
VALUES (3, 'DC-005', 1, 2, 1, 4, 2, 33386800);

INSERT INTO [dbo].[Jewelry] (JewelrySettingID, ProductID, MainDiamondID, MainDiamondQuantity, SideDiamondID, SideDiamondQuantity, CategoryId, BasePrice) 
VALUES (2, 'DC-006', 2, 2, 2, 4, 2, 18077000);

INSERT INTO [dbo].[Jewelry] (JewelrySettingID, ProductID, MainDiamondID, MainDiamondQuantity, SideDiamondID, SideDiamondQuantity, CategoryId, BasePrice) 
VALUES (2, 'DC-007', 3, 2, 3, 4, 2, 42494800);

INSERT INTO [dbo].[Jewelry] (JewelrySettingID, ProductID, MainDiamondID, MainDiamondQuantity, SideDiamondID, SideDiamondQuantity, CategoryId, BasePrice) 
VALUES (1, 'DC-008', 4, 2, 4, 4, 2, 73690000);

INSERT INTO [dbo].[Jewelry] (JewelrySettingID, ProductID, MainDiamondID, MainDiamondQuantity, SideDiamondID, SideDiamondQuantity, CategoryId, BasePrice) 
VALUES (1, 'MDC-001', 1, 2, 1, 4, 3, 6283000);

INSERT INTO [dbo].[Jewelry] (JewelrySettingID, ProductID, MainDiamondID, MainDiamondQuantity, SideDiamondID, SideDiamondQuantity, CategoryId, BasePrice) 
VALUES (1, 'MDC-002', 2, 2, 2, 4, 3, 17590000);

INSERT INTO [dbo].[Jewelry] (JewelrySettingID, ProductID, MainDiamondID, MainDiamondQuantity, SideDiamondID, SideDiamondQuantity, CategoryId, BasePrice) 
VALUES (3, 'MDC-003', 3, 2, 3, 4, 3, 7190000);

INSERT INTO [dbo].[Jewelry] (JewelrySettingID, ProductID, MainDiamondID, MainDiamondQuantity, SideDiamondID, SideDiamondQuantity, CategoryId, BasePrice) 
VALUES (3, 'MDC-004', 4, 2, 4, 4, 3, 3180000);

INSERT INTO [dbo].[Jewelry] (JewelrySettingID, ProductID, MainDiamondID, MainDiamondQuantity, SideDiamondID, SideDiamondQuantity, CategoryId, BasePrice) 
VALUES (3, 'MDC-005', 1, 2, 1, 4, 3, 4105500);

INSERT INTO [dbo].[Jewelry] (JewelrySettingID, ProductID, MainDiamondID, MainDiamondQuantity, SideDiamondID, SideDiamondQuantity, CategoryId, BasePrice) 
VALUES (2, 'MDC-006', 2, 2, 2, 4, 3, 3170500);

INSERT INTO [dbo].[Jewelry] (JewelrySettingID, ProductID, MainDiamondID, MainDiamondQuantity, SideDiamondID, SideDiamondQuantity, CategoryId, BasePrice) 
VALUES (2, 'MDC-007', 3, 2, 3, 4, 3, 11567000);

INSERT INTO [dbo].[Jewelry] (JewelrySettingID, ProductID, MainDiamondID, MainDiamondQuantity, SideDiamondID, SideDiamondQuantity, CategoryId, BasePrice) 
VALUES (1, 'MDC-008', 4, 2, 4, 4, 3, 6346000);

INSERT INTO [dbo].[Jewelry] (JewelrySettingID, ProductID, MainDiamondID, MainDiamondQuantity, SideDiamondID, SideDiamondQuantity, CategoryId, BasePrice) 
VALUES (1, 'VT-001', 1, 2, 1, 4, 4, 7500000);

/* Insert JewelrySizes */
INSERT INTO [dbo].[JewelrySizes] (JewelryID, Size, Quantity) 
VALUES (42, 10, 50);

INSERT INTO [dbo].[JewelrySizes] (JewelryID, Size, Quantity) 
VALUES (49, 11, 35);

INSERT INTO [dbo].[JewelrySizes] (JewelryID, Size, Quantity) 
VALUES (63, 12, 20);

INSERT INTO [dbo].[JewelrySizes] (JewelryID, Size, Quantity) 
VALUES (64, 13, 25);

INSERT INTO [dbo].[JewelrySizes] (JewelryID, Size, Quantity) 
VALUES (65, 14, 50);

INSERT INTO [dbo].[JewelrySizes] (JewelryID, Size, Quantity) 
VALUES (66, 15, 50);
