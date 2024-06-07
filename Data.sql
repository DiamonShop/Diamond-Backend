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
INSERT INTO [dbo].[User] (RoleId, Email, Status, FullName, Username, Password, IsActive) 
VALUES (1, 'admin@example.com', 'active', 'Admin User', 'admin', 'password123', 1);

INSERT INTO [dbo].[User] (RoleId, Email, Status, FullName, Username, Password, IsActive) 
VALUES (2, 'manager@example.com', 'active', 'Manager User', 'manager', 'password123', 1);

INSERT INTO [dbo].[User] (RoleId, Email, Status, FullName, Username, Password, IsActive) 
VALUES (3, 'member@example.com', 'inactive', 'Member User', 'member', 'password123', 0);

INSERT INTO [dbo].[User] (RoleId, Email, Status, FullName, Username, Password, IsActive) 
VALUES (4, 'delivery@example.com', 'active', 'Delivery User', 'staff', 'password123', 1);

/* Insert Product */
INSERT INTO Product (CategoryID, Description, Stock, IsActive, Price, ProductName) 
VALUES (1, 'A beautiful diamond ring with a 1-carat diamond.', 50, 1, 4999.99, 'Diamond Ring');

INSERT INTO Product (CategoryID, Description, Stock, IsActive, Price, ProductName) 
VALUES (2, 'Elegant diamond necklace with a heart-shaped pendant.', 30, 1, 2999.99, 'Diamond Necklace');

INSERT INTO Product (CategoryID, Description, Stock, IsActive, Price, ProductName) 
VALUES (3, 'Sparkling diamond earrings with a classic design.', 100, 1, 1999.99, 'Diamond Earrings');

INSERT INTO Product (CategoryID, Description, Stock, IsActive, Price, ProductName) 
VALUES (4, 'Stylish diamond bracelet with a modern look.', 25, 1, 1499.99, 'Diamond Bracelet');

INSERT INTO Product (CategoryID, Description, Stock, IsActive, Price, ProductName) 
VALUES (5, 'High-quality loose diamond with excellent clarity.', 10, 1, 9999.99, 'Loose Diamond');