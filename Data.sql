USE [DiamondStore]

/* Insert Category */
INSERT INTO [dbo].[Categories] (CategoryName) VALUES ('Diamond Rings');
INSERT INTO [dbo].[Categories] (CategoryName) VALUES ('Diamond Necklaces');
INSERT INTO [dbo].[Categories] (CategoryName) VALUES ('Diamond Earrings');
INSERT INTO [dbo].[Categories] (CategoryName) VALUES ('Diamond Bracelets');
INSERT INTO [dbo].[Categories] (CategoryName) VALUES ('Loose Diamonds');

/* Insert Role */
INSERT INTO [dbo].[Roles] (RoleName) VALUES ('Admin');
INSERT INTO [dbo].[Roles] (RoleName) VALUES ('Manager');
INSERT INTO [dbo].[Roles] (RoleName) VALUES ('Member');
INSERT INTO [dbo].[Roles] (RoleName) VALUES ('Delivery');
INSERT INTO [dbo].[Roles] (RoleName) VALUES ('Staff');

/* Insert User */
INSERT INTO [dbo].[Users] (RoleId, Email, FullName, Username, Password, Address, LoyaltyPoints, IsActive) 
VALUES (1, 'admin@example.com', 'Admin User', 'admin', 'adminpassword', '123 Admin St', 100, 1);

INSERT INTO [dbo].[Users] (RoleId, Email, FullName, Username, Password, Address, LoyaltyPoints, IsActive) 
VALUES (2, 'manager@example.com', 'Manager User', 'manager', 'managerpassword', '456 Manager St', 200, 1);

INSERT INTO [dbo].[Users] (RoleId, Email, FullName, Username, Password, Address, LoyaltyPoints, IsActive) 
VALUES (3, 'member@example.com', 'Member User', 'member', 'memberpassword', '789 Member St', 300, 1);

INSERT INTO [dbo].[Users] (RoleId, Email, FullName, Username, Password, Address, LoyaltyPoints, IsActive) 
VALUES (4, 'delivery@example.com', 'Delivery User', 'delivery', 'deliverypassword', '101 Delivery St', 400, 1);

INSERT INTO [dbo].[Users] (RoleId, Email, FullName, Username, Password, Address, LoyaltyPoints, IsActive) 
VALUES (5, 'staff@example.com', 'Staff User', 'staff', 'staffpassword', '202 Staff St', 500, 1);

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
INSERT INTO [dbo].[Product] (CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES ( 1, 1, 'Nhẫn Kim Cương Vàng 14k Timeless Diamond', 'A beautiful gold ring', 50, 1.2, 56419000, 1);

INSERT INTO [dbo].[Product] (CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive)
VALUES ( 1, 1, 'Nhẫn Vàng trắng 14K đính đá ECZ', 'A beautiful gold ring', 50, 1.2, 8359000, 1);

INSERT INTO [dbo].[Product] (CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES ( 1, 1, 'Nhẫn Kim Cương Vàng 14k Timeless Diamond', 'A beautiful gold ring', 50, 1.2, 124398000, 1);

INSERT INTO [dbo].[Product] (CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES (1, 1, 'Nhẫn Kim cương Vàng trắng 14K', 'A beautiful gold ring', 50, 1.2, 43544000, 1);

INSERT INTO [dbo].[Product] (CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES (1, 1, 'Nhẫn Kim cương Vàng trắng 14K DDDDW006782', 'A beautiful gold ring', 50, 1.2, 92246400, 1);

INSERT INTO [dbo].[Product] (CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES (1, 1, 'Nhẫn nam Kim cương Vàng trắng 14K DDDDW000287', 'A beautiful gold ring', 50, 1.2, 41657000, 1);

INSERT INTO [dbo].[Product] (CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES (1, 1, 'Nhẫn nam Kim cương Vàng 14K DD00H000294', 'A beautiful gold ring', 50, 1.2, 78219900, 1);

INSERT INTO [dbo].[Product] (CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES (1, 1, 'Nhẫn cưới nam Kim cương Vàng trắng 14K DD00W000471', 'A beautiful gold ring', 50, 1.2, 6185000, 1);

INSERT INTO [dbo].[Product] (CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES (1, 2, 'Silver Necklace', 'Elegant silver necklace', 30, 1.5, 500, 1);

INSERT INTO [dbo].[Product] (CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES (2, 1, 'Dây chuyền Bạc Ý 0000W060096', 'Sparkling diamond earrings', 20, 1.3, 1995000, 1);

INSERT INTO [dbo].[Product] (CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES (2, 1, 'Dây chuyền Vàng trắng Ý 18K 0000W000871', 'Sparkling diamond earrings', 20, 1.3, 16963000, 1);

INSERT INTO [dbo].[Product] (CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES (2, 1, 'Dây chuyền Vàng Ý 18K 0000Y060507', 'Sparkling diamond earrings', 20, 1.3, 20534400, 1);

INSERT INTO [dbo].[Product] (CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES (2, 1, 'Dây chuyền nam Vàng trắng Ý 18K 0000W061242', 'Sparkling diamond earrings', 20, 1.3, 11320000, 1);

INSERT INTO [dbo].[Product] (CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES (2, 1, 'Dây chuyền nam Vàng trắng Ý 18K 0000W061240', 'Sparkling diamond earrings', 20, 1.3, 33386800, 1);
INSERT INTO [dbo].[Product] (CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES (2, 1, 'Dây chuyền Vàng Ý 18K PNJ 0000C000043', 'Sparkling diamond earrings', 20, 1.3, 18077000, 1);

INSERT INTO [dbo].[Product] (CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES (2, 1, 'Dây chuyền nam Vàng Ý 18K 0000Y060509', 'Sparkling diamond earrings', 20, 1.3, 42494800, 1);

INSERT INTO [dbo].[Product] (CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES (2, 1, 'Dây chuyền nam Vàng Ý 18K 0000C060176', 'Sparkling diamond earrings', 20, 1.3, 73690000, 1);

INSERT INTO [dbo].[Product] (CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES (3, 3, 'Mặt dây chuyền Vàng 14K đính đá Ruby Disney', 'Luxury platinum bracelet', 10, 1.4, 6283000, 1);

INSERT INTO [dbo].[Product] (CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES (3, 3, 'Mặt dây chuyền Vàng 18K đính đá CZ', 'Luxury platinum bracelet', 10, 1.4, 17590000, 1);

INSERT INTO [dbo].[Product] (CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES (3, 3, 'Mặt dây chuyền Vàng 14K đính đá', 'Luxury platinum bracelet', 10, 1.4, 7190000, 1);

INSERT INTO [dbo].[Product] (CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES (3, 3, 'Mặt dây chuyền Vàng 14K đính đá Synthetic HELLO KITTY', 'Luxury platinum bracelet', 10, 1.4, 3180000, 1);

INSERT INTO [dbo].[Product] (CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES (3, 3, 'Mặt dây chuyền Vàng 14K đính đá Synthetic HELLO KITTY', 'Luxury platinum bracelet', 10, 1.4, 4105500, 1);

INSERT INTO [dbo].[Product] (CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES (3, 3, 'Mặt dây chuyền Vàng 14K đính đá Synthetic HELLO KITTY', 'Luxury platinum bracelet', 10, 1.4, 3170500, 1);

INSERT INTO [dbo].[Product] (CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES (3, 3, 'Mặt dây chuyền Vàng Trắng 14K đính ngọc trai Akoya PAXMW000101', 'Luxury platinum bracelet', 10, 1.4, 11567000, 1);

INSERT INTO [dbo].[Product] (CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES (3, 3, 'Mặt dây chuyền Vàng trắng 14K đính đá Topaz PNJ TPXMW000417', 'Luxury platinum bracelet', 10, 1.4, 6346000, 1);
INSERT INTO [dbo].[Product] (CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES (4, 4, 'Emerald Pendant', 'Beautiful emerald pendant', 25, 1.6, 7500000, 1);

/* Insert Orders */
INSERT INTO [dbo].[Orders] (UserId, TotalPrice, Status, OrderDate) VALUES (1, 99.99, 'Completed', '2023-05-15 12:34:56.123');
INSERT INTO [dbo].[Orders] (UserId, TotalPrice, Status, OrderDate) VALUES (2, 49.49, 'Pending', '2023-05-16 14:21:22.456');
INSERT INTO [dbo].[Orders] (UserId, TotalPrice, Status, OrderDate) VALUES (3, 75.00, 'Shipped', '2023-05-17 16:45:33.789');
INSERT INTO [dbo].[Orders] (UserId, TotalPrice, Status, OrderDate) VALUES (4, 120.50, 'Completed', '2023-05-18 11:12:12.012');
INSERT INTO [dbo].[Orders] (UserId, TotalPrice, Status, OrderDate) VALUES (1, 200.99, 'Cancelled', '2023-05-19 10:01:44.321');
INSERT INTO [dbo].[Orders] (UserId, TotalPrice, Status, OrderDate) VALUES (1, 15.75, 'Completed', '2023-05-20 17:23:55.654');
INSERT INTO [dbo].[Orders] (UserId, TotalPrice, Status, OrderDate) VALUES (2, 250.00, 'Pending', '2023-05-21 09:30:11.987');
INSERT INTO [dbo].[Orders] (UserId, TotalPrice, Status, OrderDate) VALUES (3, 60.60, 'Shipped', '2023-05-22 08:45:22.876');
INSERT INTO [dbo].[Orders] (UserId, TotalPrice, Status, OrderDate) VALUES (4, 89.89, 'Completed', '2023-05-23 07:12:33.765');
INSERT INTO [dbo].[Orders] (UserId, TotalPrice, Status, OrderDate) VALUES (1, 199.99, 'Pending', '2023-05-24 06:23:44.654');

/* Insert Orders */


/* Insert Diamond */
INSERT INTO [dbo].[Diamonds] (ProductID, Origin, Carat, Clarity, Cut, Color, BasePrice) 
VALUES (1, 'South Africa', 0.5, 'VS1', 'Round', 'D', 5000);

INSERT INTO [dbo].[Diamonds] (ProductID, Origin, Carat, Clarity, Cut, Color, BasePrice) 
VALUES (2, 'Russia', 0.75, 'VVS2', 'Princess', 'E', 7500);

INSERT INTO [dbo].[Diamonds] (ProductID, Origin, Carat, Clarity, Cut, Color, BasePrice) 
VALUES (3, 'Australia', 1.0, 'IF', 'Oval', 'F', 10000);

INSERT INTO [dbo].[Diamonds] (ProductID, Origin, Carat, Clarity, Cut, Color, BasePrice) 
VALUES (4, 'Canada', 0.6, 'SI1', 'Cushion', 'G', 6000);