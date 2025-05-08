CREATE DATABASE CoffeeShopManagement

USE CoffeeShopManagement
GO

CREATE TABLE Account (
    id INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(50) NOT NULL,
    role VARCHAR(10) NOT NULL,
    fullName NVARCHAR(100) NOT NULL,
    sex NVARCHAR(10) NOT NULL,
    dateOfBirth DATE NOT NULL,
    address NVARCHAR(255) NOT NULL,
    phoneNumber VARCHAR(10) NOT NULL,
    dateOfRegistration DATE NOT NULL DEFAULT GETDATE()
);

CREATE TABLE [Shift] (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(30) NOT NULL,
	time NVARCHAR(30)NOT NULL,
    wage FLOAT NOT NULL
);

CREATE TABLE Workday (
    accountID int NOT NULL,
	shiftID INT NOT NULL,
    [date] DATE NOT NULL,
    FOREIGN KEY (accountID) REFERENCES Account(id),
    FOREIGN KEY (shiftID) REFERENCES [Shift](id)
)ON [PRIMARY];

CREATE TABLE Category (
    id INT IDENTITY(1,1) PRIMARY KEY,
    [name] NVARCHAR(100) NOT NULL
);

CREATE TABLE Supplier (
    id VARCHAR(20) PRIMARY KEY,
    [name] NVARCHAR(100) NOT NULL,
    [address] [nvarchar](200) NOT NULL
);

CREATE TABLE Coupon (
    id VARCHAR(10) PRIMARY KEY,
    description NVARCHAR(255),
    value FLOAT NOT NULL
);

CREATE TABLE [Product] (
    id VARCHAR(10) PRIMARY KEY,
    [name] NVARCHAR(100) NOT NULL,
    price FLOAT NOT NULL DEFAULT 0,
    discount FLOAT DEFAULT 0,
    categoryID int NOT NULL,
    FOREIGN KEY (categoryID) REFERENCES Category(id),
);

CREATE TABLE [Order] (
    id INT IDENTITY(1,1) PRIMARY KEY,
    createdDate DATE NOT NULL DEFAULT GETDATE(),
    totalPrice FLOAT NOT NULL DEFAULT 0,
    counterfeit FLOAT NOT NULL DEFAULT 0,
    [change] FLOAT NOT NULL DEFAULT 0,
    paymentMethod VARCHAR(10) NOT NULL,
    couponID VARCHAR(10),
	accountID INT NOT NULL,
	FOREIGN KEY (couponID) REFERENCES Coupon(id),
    FOREIGN KEY (accountID) REFERENCES Account(id)
);

CREATE TABLE Item (
    itemID INT IDENTITY(1,1) PRIMARY KEY,
    orderID INT NOT NULL,
    productID VARCHAR(10) NOT NULL,
    quantity INT NOT NULL DEFAULT 1,
    price FLOAT NOT NULL DEFAULT 0,
    FOREIGN KEY (orderID) REFERENCES [Order](id),
    FOREIGN KEY (productID) REFERENCES [Product](id)
);

CREATE TABLE Ingredient (
    id VARCHAR(10) PRIMARY KEY,
    [name] NVARCHAR(100) NOT NULL,
    unit NVARCHAR(20) NOT NULL,
    quantity INT NOT NULL DEFAULT 0,
    expirationDate DATE NOT NULL,
    [status] NVARCHAR(20) NOT NULL,  -- 'STOCK', 'OUT_OF_STOCK', 'LOW_STOCK' or 'EXPIRED'
	supplierID VARCHAR(20) NOT NULL,
	FOREIGN KEY (supplierID) REFERENCES Supplier(id)
);

CREATE TABLE InventoryTransaction (
    id INT IDENTITY(1,1) PRIMARY KEY,
    ingredientID VARCHAR(10) NOT NULL,
    quantity INT NOT NULL,
    [type] VARCHAR(10) NOT NULL, --'IN' or 'OUT'
    [date] DATE NOT NULL DEFAULT GETDATE(),
    note NVARCHAR(255),
    FOREIGN KEY (ingredientID) REFERENCES Ingredient(id)
);

--================================================================================================================================

INSERT INTO Account (username, [password], [role], fullName, sex, dateOfBirth, [address], phoneNumber) VALUES
	('admin', '123', 'ADMIN', N'Trần Lê Hoài Nhân', N'Nữ', '2003-08-31', N'Hương Lộ 3, Bình Hưng Hòa, Bình Tân, TP.HCM', '0123456789'),
	('staff01', '111', 'STAFF', N'Võ Duy Khôi', N'Nam', '2003-04-14', N'Phạm Văn Đồng, Hiệp Bình Chánh, Thủ Đức, TP.HCM', '0987654321')
GO

INSERT INTO [Shift] ([name], [time], wage) VALUES 
	(N'Ca sáng', N'08:00 - 12:00', 120000),
	(N'Ca chiều', N'12:00 - 16:00', 120000),
	(N'Ca tối', N'16:00 - 20:00', 120000)
GO

INSERT INTO Workday (accountID, shiftID, [date]) VALUES 
	(1, 1, '2025-04-20'),
	(2, 2, '2025-04-20')
GO

INSERT INTO Category ([name]) VALUES 
	(N'Cà phê'), 
	(N'Trà sữa'),
	(N'Trà trái cây'),
	(N'Nước ép'),
	(N'Bánh ngọt'),
	(N'Soda'), 
	(N'Đá xay'),
	(N'Thức uống khác')
GO

INSERT INTO Supplier (id, [name], [address]) VALUES 
	('Vinamilk', N'Công ty Sữa Vinamilk', N'268 Lý Thường Kiệt, Q10, TP.HCM'),
	('TNLegend', N'Công ty Cà phê Trung Nguyên', N'82 Nguyễn Du, Q1, TP.HCM')
GO

INSERT INTO Coupon (id, [description], [value]) VALUES 
	('CP001', N'Giảm 10k cho đơn từ 100k', 10000),
	('CP002', N'Tặng 50k cho hóa đơn từ 200k', 50000)
GO

INSERT INTO [Product] (id, [name], price, discount, categoryID) VALUES
	('CF001', N'Cà phê sữa đá', 25000, 0, 1),
	('CF002', N'Bạc sỉu', 28000, 0, 1),
    ('CF003', N'Cà phê đen', 23000, 0, 1),
    ('CF004', N'Cà phê Americano', 27000, 0, 1),
    ('CF005', N'Cà phê mocha', 32000, 0, 1),
    
	('MT001', N'Trà sữa trân châu', 32000, 0, 2),
    ('MT002', N'Trà sữa matcha', 35000, 0, 2),
    ('MT003', N'Trà sữa caramel', 34000, 0, 2),
    ('MT004', N'Trà sữa socola', 36000, 0, 2),
    ('MT005', N'Trà sữa xoài', 37000, 0, 2),
    
    ('FT001', N'Trà cam bưởi hồng', 30000, 0, 3),
    ('FT002', N'Trà dưa hấu', 31000, 0, 3),
    ('FT003', N'Trà olong kiwi', 32000, 0, 3),
    ('FT004', N'Trà long nhãn hạt sen', 45000, 0, 3),
    ('FT005', N'Trà trái cây mix', 34000, 0, 3),
    
	('FJ001', N'Nước ép cam', 30000, 0, 4),
    ('FJ002', N'Nước ép táo', 28000, 0, 4),
    ('FJ003', N'Nước ép dứa', 29000, 0, 4),
    ('FJ004', N'Nước ép cà rốt', 27000, 0, 4),
    ('FJ005', N'Nước ép nho', 31000, 0, 4),
    
    ('BN001', N'Bánh cheesecake', 45000, 0, 5),
    ('BN002', N'Bánh tiramisu', 42000, 0, 5),
    ('BN003', N'Bánh cupcake', 40000, 0, 5),
    ('BN004', N'Bánh mousse', 43000, 0, 5),
    ('BN005', N'Bánh brownies', 41000, 0, 5),
    
    ('SD001', N'Soda cam', 20000, 0, 6),
    ('SD002', N'Soda dưa hấu', 22000, 0, 6),
    ('SD003', N'Soda chanh', 21000, 0, 6),
    ('SD004', N'Soda nho', 23000, 0, 6),
    ('SD005', N'Soda việt quất', 24000, 0, 6),

    ('DX001', N'Cacao đá xay', 35000, 0, 7),
    ('DX002', N'Matcha đá xay', 35000, 0, 7),
    ('DX003', N'Oreo đá xay', 35000, 0, 7),
    ('DX004', N'Sữa chua việt quất đá xay', 35000, 0, 7),
    ('DX005', N'Chanh tuyết đá xay', 30000, 0, 7),

    ('TK001', N'Cacao nóng', 26000, 0, 8),
    ('TK002', N'Sữa chua đánh đá', 27000, 0, 8),
    ('TK003', N'Sữa tươi trân châu đường đen', 35000, 0, 8),
    ('TK004', N'Nước chanh', 20000, 0, 8),
    ('TK005', N'Sữa tươi', 20000, 0, 8);
GO

INSERT INTO [Order] (createdDate, totalPrice, counterfeit, [change], paymentMethod, couponID, accountID) VALUES 
	('2025-04-20', 60000, 100000, 40000, 'CASH', NULL, 2);
GO

/*
DELETE FROM [Order]
GO
DBCC CHECKIDENT ('[Order]', RESEED, 0)
GO
*/

INSERT INTO Item (orderID, productID, quantity, price) VALUES 
	(1, 'MT001', 1, 32000),
	(1, 'CF002', 1, 28000)
GO

INSERT INTO Ingredient (id, [name], unit, quantity, expirationDate, [status], supplierID) VALUES 
	('I0001', N'Sữa đặc', N'Hộp', 50, '2025-06-01', N'STOCK', 'Vinamilk'),
	('I0002', N'Hạt cà phê Arabica', N'Kg', 20, '2025-12-31', N'STOCK', 'TNLegend'),
	('I0003', N'Trà xanh', N'Gói', 15, '2025-10-15', N'LOW_STOCK', 'TNLegend')
GO

INSERT INTO InventoryTransaction (ingredientID, quantity, [type], [date], note) VALUES 
	('I0001', 20, 'IN', '2025-04-10', N'Nhập sữa mới từ Vinamilk'),
	('I0002', 10, 'IN', '2025-04-15', N'Nhập hạt cà phê'),
	('I0003', 5, 'OUT', '2025-04-18', N'Nguyên liệu hỏng'),
	('I0001', 2, 'OUT', '2025-04-20', N'Chuyển cho quầy pha chế')
GO

--///////////////// ADD COLUMN for workday
ALTER TABLE Workday
ADD isChecked BIT DEFAULT 0;