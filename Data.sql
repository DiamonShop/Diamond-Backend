USE [DiamondStore]

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
INSERT INTO [dbo].[Users] (RoleId, Email, FullName, Username, Password, Address, LoyaltyPoints, IsActive) 
VALUES (1, 'admin@example.com', 'Admin User', 'admin', '123', '123 Admin St', 100, 1);

INSERT INTO [dbo].[Users] (RoleId, Email, FullName, Username, Password, Address, LoyaltyPoints, IsActive) 
VALUES (2, 'manager@example.com', 'Manager User', 'manager', '123', '456 Manager St', 200, 1);

INSERT INTO [dbo].[Users] (RoleId, Email, FullName, Username, Password, Address, LoyaltyPoints, IsActive) 
VALUES (3, 'member@example.com', 'Member User', 'member', '123', '789 Member St', 300, 1);

INSERT INTO [dbo].[Users] (RoleId, Email, FullName, Username, Password, Address, LoyaltyPoints, IsActive) 
VALUES (4, 'delivery@example.com', 'Delivery User', 'delivery', '123', '101 Delivery St', 400, 1);

INSERT INTO [dbo].[Users] (RoleId, Email, FullName, Username, Password, Address, LoyaltyPoints, IsActive) 
VALUES (5, 'staff@example.com', 'Staff User', 'staff', '123', '202 Staff St', 500, 1);

/* Insert JewelrySetting */
INSERT INTO [dbo].[JewelrySetting] (Name, Material, BasePrice, Description) 
VALUES ('Classic', 'Gold', 500, 'Classic gold setting');

INSERT INTO [dbo].[JewelrySetting] (Name, Material, BasePrice, Description) 
VALUES ('Modern', 'Silver', 300, 'Modern silver setting');

INSERT INTO [dbo].[JewelrySetting] (Name, Material, BasePrice, Description)
VALUES ('Luxury', 'Platinum', 1000, 'Luxury platinum setting');

INSERT INTO [dbo].[JewelrySetting] (Name, Material, BasePrice, Description)
VALUES ('Vintage', 'Bronze', 200, 'Vintage bronze setting');

INSERT INTO [dbo].[JewelrySetting] (Name, Material, BasePrice, Description) 
VALUES ('Elegant', 'White Gold', 700, 'Elegant white gold setting');

/* Insert Product */
INSERT INTO [dbo].[Products] (ProductId, CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES ('N-001', 1, 5, N'Nhẫn Kim Cương Vàng 14k Timeless Diamond', N'A beautiful gold ring', 50, 1.2, 56419000, 'True');

INSERT INTO [dbo].[Products] (ProductId, CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES ('N-002', 1, 5, N'Nhẫn Vàng trắng 14K đính đá ECZ', N'A beautiful gold ring', 50, 1.2, 8359000, 'True');

INSERT INTO [dbo].[Products] (ProductId, CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES ('N-003', 1, 5, N'Nhẫn Kim Cương Vàng 14k Timeless Diamond', N'A beautiful gold ring', 50, 1.2, 124398000, 'True');

INSERT INTO [dbo].[Products] (ProductId, CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES ('N-004', 1, 5, N'Nhẫn Kim cương Vàng trắng 14K', N'A beautiful gold ring', 50, 1.2, 43544000, 'True');

INSERT INTO [dbo].[Products] (ProductId, CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES ('DC-001', 2, 4, N'Dây chuyền Bạc Ý 0000W060096', N'Sparkling diamond earrings', 20, 1.3, 1995000, 'True');

INSERT INTO [dbo].[Products] (ProductId, CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES ('DC-002', 2, 4, N'Dây chuyền Vàng trắng Ý 18K 0000W000871', N'Sparkling diamond earrings', 20, 1.3, 16963000, 'True');

INSERT INTO [dbo].[Products] (ProductId, CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES ('DC-003', 2, 3, N'Dây chuyền Vàng Ý 18K 0000Y060507', N'Sparkling diamond earrings', 20, 1.3, 20534400, 'True');

INSERT INTO [dbo].[Products] (ProductId, CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES ('DC-004', 2, 3, N'Dây chuyền nam Vàng trắng Ý 18K 0000W061242', N'Sparkling diamond earrings', 20, 1.3, 11320000, 'True');

INSERT INTO [dbo].[Products] (ProductId, CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES ('DC-005', 2, 3, N'Dây chuyền nam Vàng trắng Ý 18K 0000W061240', N'Sparkling diamond earrings', 20, 1.3, 33386800, 'True');

INSERT INTO [dbo].[Products] (ProductId, CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES ('DC-006', 2, 2, N'Dây chuyền Vàng Ý 18K PNJ 0000C000043', N'Sparkling diamond earrings', 20, 1.3, 18077000, 'True');

INSERT INTO [dbo].[Products] (ProductId, CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES ('DC-007', 2, 2, N'Dây chuyền nam Vàng Ý 18K 0000Y060509', N'Sparkling diamond earrings', 20, 1.3, 42494800, 'True');

INSERT INTO [dbo].[Products] (ProductId, CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES ('DC-008', 2, 1, N'Dây chuyền nam Vàng Ý 18K 0000C060176', N'Sparkling diamond earrings', 20, 1.3, 73690000, 'True');

INSERT INTO [dbo].[Products] (ProductId, CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES ('MDC-001', 3, 1, N'Mặt dây chuyền Vàng 14K đính đá Ruby Disney', N'Luxury platinum bracelet', 10, 1.4, 6283000, 'True');

INSERT INTO [dbo].[Products] (ProductId, CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES ('MDC-002', 3, 1, N'Mặt dây chuyền Vàng 18K đính đá CZ', N'Luxury platinum bracelet', 10, 1.4, 17590000, 'True');

INSERT INTO [dbo].[Products] (ProductId, CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES ('MDC-003', 3, 3, N'Mặt dây chuyền Vàng 14K đính đá', N'Luxury platinum bracelet', 10, 1.4, 7190000, 'True');

INSERT INTO [dbo].[Products] (ProductId, CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES ('MDC-004', 3, 3, N'Mặt dây chuyền Vàng 14K đính đá Synthetic HELLO KITTY', N'Luxury platinum bracelet', 10, 1.4, 3180000, 'True');

INSERT INTO [dbo].[Products] (ProductId, CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES ('MDC-005', 3, 3, N'Mặt dây chuyền Vàng 14K đính đá Synthetic HELLO KITTY', N'Luxury platinum bracelet', 10, 1.4, 4105500, 'True');

INSERT INTO [dbo].[Products] (ProductId, CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES ('MDC-006', 3, 2, N'Mặt dây chuyền Vàng 14K đính đá Synthetic HELLO KITTY', N'Luxury platinum bracelet', 10, 1.4, 3170500, 'True');

INSERT INTO [dbo].[Products] (ProductId, CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES ('MDC-007', 3, 2, N'Mặt dây chuyền Vàng Trắng 14K đính ngọc trai Akoya PAXMW000101', N'Luxury platinum bracelet', 10, 1.4, 11567000, 'True');

INSERT INTO [dbo].[Products] (ProductId, CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES ('MDC-008', 3, 1, N'Mặt dây chuyền Vàng trắng 14K đính đá Topaz PNJ TPXMW000417', N'Luxury platinum bracelet', 10, 1.4, 6346000, 'True');

INSERT INTO [dbo].[Products] (ProductId, CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES ('VT-001', 4, 1, N'Emerald Pendant', N'Beautiful emerald pendant', 25, 1.6, 7500000, 'True');

/* Insert Orders */
INSERT INTO [dbo].[Orders] (UserId, TotalPrice, Status, OrderDate) VALUES (1, 99.99, 'Completed', '2023-05-15 12:34:56.123');
INSERT INTO [dbo].[Orders] (UserId, TotalPrice, Status, OrderDate) VALUES (2, 49.49, 'Ordering', '2023-05-16 14:21:22.456');
INSERT INTO [dbo].[Orders] (UserId, TotalPrice, Status, OrderDate) VALUES (3, 75.00, 'Shipped', '2023-05-17 16:45:33.789');
INSERT INTO [dbo].[Orders] (UserId, TotalPrice, Status, OrderDate) VALUES (4, 120.50, 'Completed', '2023-05-18 11:12:12.012');
INSERT INTO [dbo].[Orders] (UserId, TotalPrice, Status, OrderDate) VALUES (1, 200.99, 'Cancelled', '2023-05-19 10:01:44.321');
INSERT INTO [dbo].[Orders] (UserId, TotalPrice, Status, OrderDate) VALUES (1, 15.75, 'Completed', '2023-05-20 17:23:55.654');
INSERT INTO [dbo].[Orders] (UserId, TotalPrice, Status, OrderDate) VALUES (2, 250.00, 'Completed', '2023-05-21 09:30:11.987');
INSERT INTO [dbo].[Orders] (UserId, TotalPrice, Status, OrderDate) VALUES (3, 60.60, 'Shipped', '2023-05-22 08:45:22.876');
INSERT INTO [dbo].[Orders] (UserId, TotalPrice, Status, OrderDate) VALUES (4, 89.89, 'Completed', '2023-05-23 07:12:33.765');
INSERT INTO [dbo].[Orders] (UserId, TotalPrice, Status, OrderDate) VALUES (1, 199.99, 'Ordering', '2023-05-24 06:23:44.654');

/* Insert Diamond */
INSERT INTO [dbo].[Diamonds] (ProductID, Origin, Carat, Clarity, Cut, Color, BasePrice) 
VALUES ('MDC-008', 'South Africa', 0.5, 'VS1', 'Round', 'D', 5000);

INSERT INTO [dbo].[Diamonds] (ProductID, Origin, Carat, Clarity, Cut, Color, BasePrice) 
VALUES ('DC-007', 'Russia', 0.75, 'VVS2', 'Princess', 'E', 7500);

INSERT INTO [dbo].[Diamonds] (ProductID, Origin, Carat, Clarity, Cut, Color, BasePrice) 
VALUES ('VT-001', 'Australia', 1.0, 'IF', 'Oval', 'F', 10000);

INSERT INTO [dbo].[Diamonds] (ProductID, Origin, Carat, Clarity, Cut, Color, BasePrice) 
VALUES ('N-004', 'Canada', 0.6, 'SI1', 'Cushion', 'G', 6000);