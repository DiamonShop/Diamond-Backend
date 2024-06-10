USE [DiamondStore]

/* Insert Category */
INSERT INTO [dbo].[Category] (CategoryName) VALUES ('Diamond Rings');
INSERT INTO [dbo].[Category] (CategoryName) VALUES ('Diamond Necklaces');
INSERT INTO [dbo].[Category] (CategoryName) VALUES ('Diamond Earrings');
INSERT INTO [dbo].[Category] (CategoryName) VALUES ('Diamond Bracelets');
INSERT INTO [dbo].[Category] (CategoryName) VALUES ('Loose Diamonds');

/* Insert Role */
INSERT INTO [dbo].[Role] (RoleName) VALUES ('Admin');
INSERT INTO [dbo].[Role] (RoleName) VALUES ('Manage');
INSERT INTO [dbo].[Role] (RoleName) VALUES ('Member');
INSERT INTO [dbo].[Role] (RoleName) VALUES ('Delivery');
INSERT INTO [dbo].[Role] (RoleName) VALUES ('Staff');

/* Insert User */
INSERT INTO [dbo].[User] (RoleId, Email, FullName, Username, Password, IsActive) VALUES (1, 'admin@example.com', 'Admin User', 'admin', 'password123', 1);
INSERT INTO [dbo].[User] (RoleId, Email, FullName, Username, Password, IsActive) VALUES (2, 'manager@example.com', 'Manager User', 'manager', 'password123', 1);
INSERT INTO [dbo].[User] (RoleId, Email, FullName, Username, Password, IsActive) VALUES (3, 'member@example.com', 'Member User', 'member', 'password123', 0);
INSERT INTO [dbo].[User] (RoleId, Email, FullName, Username, Password, IsActive) VALUES (4, 'delivery@example.com', 'Delivery User', 'staff', 'password123', 1);

/* Insert Product */
INSERT INTO Product (CategoryID, Description, Stock, IsActive, Price, ProductName) VALUES (1, 'A beautiful diamond ring with a 1-carat diamond.', 50, 1, 4999.99, 'Diamond Ring');
INSERT INTO Product (CategoryID, Description, Stock, IsActive, Price, ProductName) VALUES (2, 'Elegant diamond necklace with a heart-shaped pendant.', 30, 1, 2999.99, 'Diamond Necklace');
INSERT INTO Product (CategoryID, Description, Stock, IsActive, Price, ProductName) VALUES (3, 'Sparkling diamond earrings with a classic design.', 100, 1, 1999.99, 'Diamond Earrings');
INSERT INTO Product (CategoryID, Description, Stock, IsActive, Price, ProductName) VALUES (4, 'Stylish diamond bracelet with a modern look.', 25, 1, 1499.99, 'Diamond Bracelet');
INSERT INTO Product (CategoryID, Description, Stock, IsActive, Price, ProductName) VALUES (5, 'High-quality loose diamond with excellent clarity.', 10, 1, 9999.99, 'Loose Diamond');

/* Insert Orders */
INSERT INTO [dbo].[Order] (UserId, TotalPrice, Status, OrderDate) VALUES (1, 99.99, 'Completed', '2023-05-15 12:34:56.123');
INSERT INTO [dbo].[Order] (UserId, TotalPrice, Status, OrderDate) VALUES (2, 49.49, 'Pending', '2023-05-16 14:21:22.456');
INSERT INTO [dbo].[Order] (UserId, TotalPrice, Status, OrderDate) VALUES (3, 75.00, 'Shipped', '2023-05-17 16:45:33.789');
INSERT INTO [dbo].[Order] (UserId, TotalPrice, Status, OrderDate) VALUES (4, 120.50, 'Completed', '2023-05-18 11:12:12.012');
INSERT INTO [dbo].[Order] (UserId, TotalPrice, Status, OrderDate) VALUES (1, 200.99, 'Cancelled', '2023-05-19 10:01:44.321');
INSERT INTO [dbo].[Order] (UserId, TotalPrice, Status, OrderDate) VALUES (1, 15.75, 'Completed', '2023-05-20 17:23:55.654');
INSERT INTO [dbo].[Order] (UserId, TotalPrice, Status, OrderDate) VALUES (2, 250.00, 'Pending', '2023-05-21 09:30:11.987');
INSERT INTO [dbo].[Order] (UserId, TotalPrice, Status, OrderDate) VALUES (3, 60.60, 'Shipped', '2023-05-22 08:45:22.876');
INSERT INTO [dbo].[Order] (UserId, TotalPrice, Status, OrderDate) VALUES (4, 89.89, 'Completed', '2023-05-23 07:12:33.765');
INSERT INTO [dbo].[Order] (UserId, TotalPrice, Status, OrderDate) VALUES (1, 199.99, 'Pending', '2023-05-24 06:23:44.654');

/* Insert Orders */
INSERT INTO [dbo].[ShoppingCart] (UserId) VALUES (1);
INSERT INTO [dbo].[ShoppingCart] (UserId) VALUES (2);
INSERT INTO [dbo].[ShoppingCart] (UserId) VALUES (3);
INSERT INTO [dbo].[ShoppingCart] (UserId) VALUES (4);
