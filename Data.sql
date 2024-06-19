USE [DiamondStore]

/* Insert Category */
INSERT INTO [dbo].[Categories] (CategoryName) VALUES ('Diamond Rings');
INSERT INTO [dbo].[Categories] (CategoryName) VALUES ('Diamond Necklaces');
INSERT INTO [dbo].[Categories] (CategoryName) VALUES ('Diamond Earrings');
INSERT INTO [dbo].[Categories] (CategoryName) VALUES ('Diamond Bracelets');
INSERT INTO [dbo].[Categories] (CategoryName) VALUES ('Loose Diamonds');

/* Insert Role */
INSERT INTO [dbo].[Roles] (RoleName) VALUES ('Admin');
INSERT INTO [dbo].[Roles] (RoleName) VALUES ('Manage');
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
VALUES ( 1, 1, 'Gold Ring', 'A beautiful gold ring', 50, 1.2, 1000, 1);

INSERT INTO [dbo].[Product] (CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES (1, 2, 'Silver Necklace', 'Elegant silver necklace', 30, 1.5, 500, 1);

INSERT INTO [dbo].[Product] (CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES (2, 1, 'Diamond Earrings', 'Sparkling diamond earrings', 20, 1.3, 1500, 1);

INSERT INTO [dbo].[Product] (CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES (3, 3, 'Platinum Bracelet', 'Luxury platinum bracelet', 10, 1.4, 2000, 1);

INSERT INTO [dbo].[Product] (CategoryId, JewelrySettingID, ProductName, Description, Stock, MarkupRate, BasePrice, IsActive) 
VALUES (4, 4, 'Emerald Pendant', 'Beautiful emerald pendant', 25, 1.6, 750, 1);

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

/* Insert Diamond */
INSERT INTO [dbo].[Diamonds] (ProductID, Origin, Carat, Clarity, Cut, Color, BasePrice) 
VALUES (1, 'South Africa', 0.5, 'VS1', 'Round', 'D', 5000);

INSERT INTO [dbo].[Diamonds] (ProductID, Origin, Carat, Clarity, Cut, Color, BasePrice) 
VALUES (2, 'Russia', 0.75, 'VVS2', 'Princess', 'E', 7500);

INSERT INTO [dbo].[Diamonds] (ProductID, Origin, Carat, Clarity, Cut, Color, BasePrice) 
VALUES (3, 'Australia', 1.0, 'IF', 'Oval', 'F', 10000);

INSERT INTO [dbo].[Diamonds] (ProductID, Origin, Carat, Clarity, Cut, Color, BasePrice) 
VALUES (4, 'Canada', 0.6, 'SI1', 'Cushion', 'G', 6000);

